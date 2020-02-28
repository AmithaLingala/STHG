using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STHG.control.elements.wrappers
{
    public  interface IElement
    {
        string Tag { get; set; }
        string Value { get; set; }
        Control ElementControl { get; set; }

        List<Property> getProperties();
    }
}
