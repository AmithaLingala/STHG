
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using STHG.control.elements.wrappers;
using System.Windows.Forms;

namespace STHG.control.elements
{
    public class Image : IElement
    {

        public string Tag { get { return "img"; } set{} }
        public string Value { get; set; }
        public Control ElementControl { get {return new PictureBox(); } set { } }

        public List<Property> getProperties()
        {
            return null;
        }
    }
}
