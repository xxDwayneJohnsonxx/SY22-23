using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myvidagame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int speed = 5;
            if (e.Shift)   
                speed = 30;  
            if (e.KeyCode== Keys.Left || e.KeyCode==Keys.A)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X - speed, pictureBox1.Location.Y);
            }
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X + speed, pictureBox1.Location.Y);
            }
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y-speed);
            }
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y+speed);
            }
        }
    }
}
