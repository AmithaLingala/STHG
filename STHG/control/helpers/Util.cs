using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using STHG.control;
using STHG.control.elements;
using STHG.control.elements.wrappers;

namespace STHG.control.helpers
{
    public class Util
    {
        private static SortedDictionary<string, IElement> elements { get; set; }
        public static SortedDictionary<string, IElement> LoadElements()
        {
            if (elements == null)
            {
                elements = new SortedDictionary<string, IElement>();
                elements.Add("☐ Text Box", new TextField());
                elements.Add("🌄 Image", new Image());
            }
            return elements;
        }

        public static string Generate(IElement Element)
        {
            StringBuilder builder = new StringBuilder();
            //opening tag
            builder.Append("<");
            builder.Append(Element.Tag);
            //if (Element.Properties != null)
            //{
            //    Element.Properties.ForEach(attribute =>
            //    {
            //        builder.Append(" ");
            //        builder.Append('"' + attribute.Name + '"');
            //        builder.Append("=");
            //        builder.Append('"' + attribute.Value + '"');
            //    });
            //}
            builder.Append(">");

            if (Element.Value != null && Element.Value.Length != 0)
            {
                builder.Append(Element.Value);
            }
            //closing tag
            builder.Append("</");
            builder.Append(Element.Tag);
            builder.Append(">");
            return builder.ToString();
        }
    }
}
