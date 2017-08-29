using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XX
{
    public partial class KeepGoingWindow : Form
    {
        public KeepGoingWindow()
        {
            InitializeComponent();

        }

        private void KeepGoingWindow_Load(object sender, EventArgs e)
        {

        }

        private void btn_cum_Click(object sender, EventArgs e)
        {
            Form1 formMain = (Form1)Application.OpenForms["form1"];
            formMain.Cum();
        }

        private void btn_edge_Click(object sender, EventArgs e)
        {
            Form1 formMain = (Form1)Application.OpenForms["form1"];
            formMain.reset();
            this.Close();
        }
    }
}
