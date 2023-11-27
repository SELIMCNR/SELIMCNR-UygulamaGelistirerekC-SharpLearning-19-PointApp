using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pointapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            
        }
        Point konum = new Point();
        
        int time;
        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            label1.Text = time.ToString();
            if (time == 0 || time == 15)
            {
                konum.X = 10;
                konum.Y = 40;
                pictureBox1.Location = konum;
            }



            else if (time == 20 || time == 50)
            {
                konum.X = 20;
                konum.Y = 90;
                pictureBox1.Location = konum;
            }

            else if (time == 50 || time == 120)
            {
                konum.X = 20;
                konum.Y = 120;
                pictureBox1.Location = konum;
            }
        }
    }
}
