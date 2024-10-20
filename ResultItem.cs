using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace html_image_listing
{
    public class FileItem
    {
        [XmlAttribute("path")]
        public string Path { get; set; }
        
        public string Title { get; set; }


        [XmlArray("Headers")]
        [XmlArrayItem("Header")]
        public List<HeaderItem> Headers { get; set; }


        [XmlArray("Images")]
        [XmlArrayItem("Image")]
        public List<ImageItem> Images { get; set; }


        [XmlArray("Links")]
        [XmlArrayItem("Link")]
        public List<LinkItem> Links { get; set; }

        public FileItem()
        {
            Headers = new List<HeaderItem>();
            Images = new List<ImageItem>();
            Links = new List<LinkItem>();
        }
    }

    public class HeaderItem
    {
        [XmlText]
        public string Value { get; set; }


        [XmlAttribute("level")]
        public int Level { get; set; }
    }

    public class ImageItem
    {
        [XmlAttribute("path")]
        public string Path { get; set; }

    }

    public class LinkItem
    {
        [XmlAttribute("url")]
        public string Url { get; set; }

        [XmlAttribute("status")]
        public string Status { get; set; }
    }
}
