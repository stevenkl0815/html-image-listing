using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace html_image_listing
{
    [XmlRoot("Result")]
    public class ResultObject
    {
        [XmlElement("Base-Path")]
        public string BasePath { get; set; }


        [XmlArray("Files")]
        [XmlArrayItem("File")]
        public List<FileItem> Files { get; set; }


        [XmlArray("Unused-Images")]
        [XmlArrayItem("Image")]
        public List<ImageItem> UnusedImages { get; set; }

        public ResultObject()
        {
            Files = new List<FileItem>();
            UnusedImages = new List<ImageItem>();
        }
    }
}
