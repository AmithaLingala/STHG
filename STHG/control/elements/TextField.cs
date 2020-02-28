using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using STHG.control.elements.wrappers;
using System.Windows.Forms;

namespace STHG.control.elements
{
    public class TextField : IElement
    {
        public string Tag { get { return "input"; } set { } }
        public string Value { get; set; }
        public Control ElementControl { get { return new TextBox(); } set { } }

        public List<Property> getProperties()
        {
            return null;
        }

        public TextField()
        {
        }
        
    }
}
