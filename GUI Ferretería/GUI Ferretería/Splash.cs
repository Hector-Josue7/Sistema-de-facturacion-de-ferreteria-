using System;
using System.Windows.Forms;

namespace GUI_Ferretería
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void Splash_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        } 

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity <= 1)
            {
                this.Opacity += 0.03;
                this.Refresh();
            }
            else
            {
                this.timer1.Enabled = false;
            }
        }               
    }
}