﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    internal class EvilSean : Sprite
    {
        int m_xdir = 0;
        int m_ydir = 10;
        int m_count = 0;
        public EvilSean(PictureBox picture, int xdir, int ydir) : base(picture)
        {
            m_xdir = xdir;
            m_ydir = ydir;
        }
        public override bool collision(PictureBox other)
        {
            Debug.Print(m_picture.Name + " collided with " + other.Name);
            // We collided, so let's figure out which way we should "bounce"
            // Clear
            //if (!m_parent.isClear(m_picture,m_picture.Location.X + m_xdir, m_picture.Location.Y))
            m_xdir *= -1;
            //if (!m_parent.isClear(m_picture, m_picture.Location.X, m_picture.Location.Y + m_ydir))
            m_ydir *= -1;

            return false; // bounce
        }
        public override void tick()
        {
            m_count += 1;
            if (m_count %3 == 0)
                m_ydir *= -1;
            move(m_xdir, m_ydir);
        }
    }
}
