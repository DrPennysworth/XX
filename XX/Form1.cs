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
    public partial class Form1 : Form
    {
        public void reset()
        {
            
            //progressBar_climaxProgress.Value = 0;
            deClimaxer.Enabled = true;
            resetProgressTimer.Enabled = true;
        }

        public void Cum()
        {
            System.IO.Stream str = Properties.Resources.male_orgasm_1;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            
            snd.PlaySync();
            this.Close();
            
        }

        public int progress;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            progressBar_climaxProgress.Value += 5;
        }

        private void deClimaxer_Tick(object sender, EventArgs e)
        {
            progress = progressBar_climaxProgress.Value;
            if (progressBar_climaxProgress.Value > 0)
            {
                progressBar_climaxProgress.Value = progressBar_climaxProgress.Value - 1;
            }
            if (progressBar_climaxProgress.Value >= progressBar_climaxProgress.Maximum - 50)
            {
                deClimaxer.Enabled = false;
                button1.Enabled = false;
                KeepGoingWindow keepGoingWin = new KeepGoingWindow();
                keepGoingWin.ShowDialog();
            }
        }

        private void resetProgressTimer_Tick(object sender, EventArgs e)
        {
            if (progressBar_climaxProgress.Value <= 10)
            {
                button1.Enabled = true;
                resetProgressTimer.Enabled = false;

            }
            else
            {
                progressBar_climaxProgress.Value = progressBar_climaxProgress.Value - 5;
            }
            

        }
    }
}
