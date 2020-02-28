using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using STHG.control.elements.wrappers;
using STHG.control.helpers;
namespace STHG
{
    public partial class Home : Form
    {
        private IElement Selected { get; set; }
        private bool IsMouseDown { get; set; }

        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            SortedDictionary<string, IElement> elements = Util.LoadElements();
            elements.Keys.ToList().ForEach(key =>
            {
                elementList.Items.Add(key);
            });

            elementList.ItemSelectionChanged += new ListViewItemSelectionChangedEventHandler(selectionChangedHandler);
            elementList.MouseUp += new System.Windows.Forms.MouseEventHandler(handleMosueUp);
            designContainer.Panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(handleMosueUp);
            
        }

        private void selectionChangedHandler(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            IsMouseDown = true;
            if (elementList.SelectedItems.Count != 0)
            {
                Selected = Util.LoadElements()[elementList.SelectedItems[0].Text];
                Console.WriteLine(Selected.Tag);
            }
        }

        private void handleMosueUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            Console.WriteLine(IsMouseDown);
            if (IsMouseDown)
            {
                Util.Generate(Selected);
                designContainer.Panel1.Controls.Add(Selected.ElementControl);
            }

            IsMouseDown = false;
        }
    }
}
