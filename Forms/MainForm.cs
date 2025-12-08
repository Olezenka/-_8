using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ЛР_8.Forms;
using ЛР_8.CastomElements;

namespace ЛР_8.Forms
{
    public partial class MainForm : ParrentForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            panelControls1.Fill();
        }

        private void panelControls1_Load(object sender, EventArgs e)
        {

        }
    }
}
