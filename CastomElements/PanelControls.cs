using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ЛР_8.DataModel;

namespace ЛР_8.CastomElements
{
    public partial class PanelControls : UserControl
    {
        public PanelControls()
        {
            InitializeComponent();
        }
        public void Fill()
        {
            Model1 model1 = new Model1();
            model1.Product.ToList().ForEach(x =>
            flowLayoutPanel1.Controls.Add(new ProductControl(x)));
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
