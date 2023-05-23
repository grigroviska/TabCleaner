using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabCleaner
{
    public partial class loading : Form
    {
        public loading()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            timerstart.Enabled = true;
            this.Opacity = 0.3;
            this.TransparencyKey = Color.Turquoise;
            this.BackColor = Color.Turquoise;
            timer1.Interval = 9000;//9000 //5200 diğer gifte
            timer1.Start();
        }
        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            if (i==1)
            {
                timer1.Stop();
                this.Hide();
            }
        }

        private void timerstart_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 0.8) 

            {

                this.Opacity += 0.014;  

            }



            else

            {

                timerstart.Enabled = false;

            }
        }

        private void timerclose_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0.0) 

            {

                this.Opacity -= 0.1;

            }



            else

            {

                timerclose.Enabled = false;  
            }
        }
    }
}
