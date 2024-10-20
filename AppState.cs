using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace html_image_listing
{
    class AppState
    {
        public string InputPath { get; private set; }
        public string OutputFile { get; private set; }

        public List<string> Images { get; set; }
        public List<string> UsedImages { get; set; }

        public ResultObject Result { get; set; }

        public int LastError = 0;


        public AppState()
        {
            Images = new List<string>();
            UsedImages = new List<string>();
        }


        public void SetState(string Keyname, object Data)
        {
            switch (Keyname.ToLower()) {
                case "inputpath":
                    InputPath = (string)Data;
                    break;
                case "outputfile":
                    OutputFile = (string)Data;
                    break;
                case "images":
                    Images = (List<string>)Data;
                    break;
                case "usedimages":
                    UsedImages = (List<string>)Data;
                    break;

                default:
                    break;
            }

            if (OnStateChange == null) { return; }
            OnStateChange(this);
            
        }

        public delegate void StateChangeHandler(object sender);
        public event StateChangeHandler OnStateChange;
    }
}
