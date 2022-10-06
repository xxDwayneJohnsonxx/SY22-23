using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Game
{
    public partial class Form1 : Form
    {
        public Canvas c = null;
        Sprite p1;
        EvilSean p2;
        Chaser b1;
        Chaser b2;
        public Form1()
        {

            InitializeComponent();
            c = new Canvas(this);
            p1 = new Sprite(player);
            p2 = new EvilSean(player2, 2, 2);
            b1 = new Chaser(chaser1);
            b2 = new Chaser(chaser2);
            c.Add(p1);
            c.Add(p2);
            c.Add(b1);
            c.Add(b2);
        }
        
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.Shift && progressBar1.Value > 2)
            {
                p1.m_speed = 10;
                progressBar1.Value--;
            }


            if (e.KeyCode == Keys.Left)
            {
                p1.moveleft();
            }
            if (e.KeyCode == Keys.Right)
            {
                p1.moveright();
            }
            if (e.KeyCode == Keys.Up)
            {
                p1.moveup();
            }
            if (e.KeyCode == Keys.Down)
            {
                p1.movedown();
            }
            if (e.KeyCode == Keys.A)
            {
                p2.moveleft();
            }
            if (e.KeyCode == Keys.D)
            {
                p2.moveright();
            }
            if (e.KeyCode == Keys.W)
            {
                p2.moveup();
            }
            if (e.KeyCode == Keys.S)
            {
                p2.movedown();
            }
            if (e.KeyCode == Keys.Space)
            {
                PictureBox p = new PictureBox();
                p.Location = player.Location;
                p.Width = chaser1.Width;
                p.Size = chaser1.Size;
                p.BackColor = chaser1.BackColor;
                p.Top = player.Location.X;
                p.Left = player.Location.Y;
                p.Width = chaser1.Width;
                p.Height = chaser1.Height;
                p.BackColor = chaser1.BackColor;
                p.SizeMode = chaser1.SizeMode;
                if (chaser1.Image != null)
                    p.Image = chaser1.Image;
                p.Name = chaser1.Name;
                p.Visible = true;
                Controls.Add(p);
                c.Add(new Sprite(p));
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum)
                progressBar1.Value++;
            // let the canvas do all the work
            c.tick();
            label1.Text = "score: " + progressBar1.Value * 50;
            if (progressBar1.Value == progressBar1.Maximum)
            { 
                MessageBox.Show("congratulations, you win!");
                Environment.Exit(0);
            }
        }
    }

}
