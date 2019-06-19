using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace CookieClicker
{
    public class Fall
    {
        Image cookie = Properties.Resources.cookie1_fall;
        public static readonly int RADIUS = 30;

        public int State { get; set; }

        public Point Center { get; set; }

        public Fall() { }

        public void Move()
        {
            Center = new Point(Center.X, Center.Y + 10);
        }

        public void Draw(Graphics g)
        {

            g.DrawImage(cookie, Center);

        }
    }
}

