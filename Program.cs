using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using HtmlAgilityPack;

namespace html_image_listing
{
    static class Program
    {

        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        public static AppState state = new AppState();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main(string[] args)
        {
            if (args.Length >= 1)
            {
                state.SetState("inputpath", args[0]);
            }
            if (args.Length >= 2)
            {
                state.SetState("outputfile", args[1]);
            }

            Logger.Debug("Starting application");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            
        }

        public static void BeginAnalyze()
        {

            var images = Directory.EnumerateFiles(state.InputPath, "*.jpg", SearchOption.AllDirectories);
            state.Images = images.ToList();

            var list = new List<FileItem>();
            var files = GetFiles(state.InputPath, "*.html");

            foreach(var f in files)
            {
                try
                {
                    var ri = ParseFile(f.FullName);
                    list.Add(ri);
                }
                catch (Exception e)
                {
                    Logger.Error(e, $"Error while parsing file {f}.");
                }
                
            }

            Logger.Debug("{0} files are parsed", list.Count);


            foreach (var img in state.UsedImages)
            {
                if (state.Images.Contains(img))
                {
                    state.Images.Remove(img);
                }
            }

            Logger.Debug("{0} item in UnusedImages", state.Images.Count);

            var ulist = new List<ImageItem>();
            foreach (var img in state.Images)
            {
                ulist.Add(new ImageItem { Path = img.Replace(state.InputPath, "") });
            }

            var ro = new ResultObject
            {
                BasePath = state.InputPath,
                Files = list,
                UnusedImages = ulist
            };

            Logger.Debug("Serialize results to xml file.");
            try
            {
                var xs = new XmlSerializer(typeof(ResultObject));
                var tw = new StreamWriter(state.OutputFile);
                xs.Serialize(tw, ro);
                tw.Flush();
                tw.Close();

            } catch (Exception e)
            {
                Logger.Error(e);
                Application.Exit();
            }

            state.Result = ro;
            
        }

        public static List<FileInfo> GetFiles(string searchpath, string filter)
        {
            var infoList = new List<FileInfo>();
            foreach (string file in Directory.EnumerateFiles(searchpath, filter, SearchOption.AllDirectories))
            {
                Logger.Debug("Checking for file {0}...", file);
                var info = new FileInfo(file);
                infoList.Add(info);
            }
            return infoList;
        }

        public static FileItem ParseFile(string filepath)
        {
            var ri = new FileItem
            {
                Path = filepath.Replace(state.InputPath, "")
            };

            var doc = new HtmlAgilityPack.HtmlDocument();
            doc.Load(filepath);

            // find <title>
            try
            {
                ri.Title = doc.DocumentNode.SelectSingleNode("//title").InnerText;
            }
            catch(Exception e)
            {
                Logger.Debug(e);
                ri.Title = "No title found";
            }
            

            // find <h1>
            var h1_ = doc.DocumentNode.SelectNodes("//h1");
            if (h1_ != null)
            {
                foreach (HtmlNode node in h1_)
                {
                    ri.Headers.Add(new HeaderItem { Level = 1, Value = node.InnerText });
                }
            }

            // find <h2>
            var h2_ = doc.DocumentNode.SelectNodes("//h2");
            if (h2_ != null)
            {
                foreach (HtmlNode node in h2_)
                {
                    ri.Headers.Add(new HeaderItem { Level = 2, Value = node.InnerText });
                }
            }

            // find <h3>
            var h3_ = doc.DocumentNode.SelectNodes("//h3");
            if (h3_ != null)
            {
                foreach (HtmlNode node in h3_)
                {
                    ri.Headers.Add(new HeaderItem { Level = 3, Value = node.InnerText });
                }
            }

            // find <h4>
            var h4_ = doc.DocumentNode.SelectNodes("//h4");
            if (h4_ != null)
            {
                foreach (HtmlNode node in h4_)
                {
                    ri.Headers.Add(new HeaderItem { Level = 4, Value = node.InnerText });
                }
            }


            // find all <img>
            var images = doc.DocumentNode.SelectNodes("//img");
            if (images != null)
            {
                foreach (HtmlNode img in images)
                {
                    var image = new FileInfo(state.InputPath + "/" + img.Attributes["src"].Value);
                    if (image.Exists)
                    {
                        state.UsedImages.Add(image.FullName);
                    }
                    var item = new ImageItem { Path = img.Attributes["src"].Value };
                    ri.Images.Add(item);
                }
            }


            // find all <a>
            var links = doc.DocumentNode.SelectNodes("//a");
            if (links != null)
            {
                foreach (HtmlNode node in links)
                {
                    var item = new LinkItem();
                    var url = node.Attributes["href"].Value;

                    item.Url = url;

                    if (url.StartsWith("HIS") || url.EndsWith(".html"))
                    {
                        var fi = new FileInfo(state.InputPath + "/" + url);
                        if (!fi.Exists)
                        {
                            item.Status = "broken";
                        }
                        else
                        {
                            item.Status = "ok";
                        }
                    }
                    ri.Links.Add(item);
                }
            }

            return ri;
        }

    }
}
