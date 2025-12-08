using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ЛР_8.DataModel;

namespace ЛР_8.CastomElements
{
    public partial class ProductControl : UserControl
    {
        public ProductControl(Product product)
        {
            InitializeComponent();
            Fill(product);
        }
        private void Fill(Product product)
        {
            labelName.Text = product.Title;
            labelMinCost.Text = product.MinCostForAgent.ToString();
            MemoryStream ms = new MemoryStream(product.Image, 0, product.Image.Length);
            pictureBox1.Image = Image.FromStream(ms);
        }
    }
}
