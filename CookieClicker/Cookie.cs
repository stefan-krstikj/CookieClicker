using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieClicker
{
    class Cookie
    {
        public Image image { get; set; }
        public Point point { get; set; }
        public Cookie()
        {
            image = Properties.Resources.cookie1_transparent;
            this.point = new Point(Constants.COOKIE_X, Constants.COOKIE_Y);
        }

        public void DrawBig(Graphics g)
        {
            int imgWidth = (int)((float)image.Width * 0.2f);
            int imgHeight = (int)((float)image.Height * 0.2f);
            int x = point.X - (imgWidth / 2);
            int y = point.Y - (imgHeight / 2);
            g.DrawImage(image, x, y, imgWidth, imgHeight);
            // Debug.WriteLine(x + y + imgWidth + imgHeight);
        }

        public void DrawSmall(Graphics g)
        {
            int imgWidth = (int)((float)image.Width * 0.15f);
            int imgHeight = (int)((float)image.Height * 0.15f);
            int x = point.X - (imgWidth);
            int y = point.Y - (int)(imgHeight * 1.5);
            g.DrawImage(image, x, y, imgWidth, imgHeight);
            //Debug.WriteLine("X: " + x + " Y: " + y + " WID: " + imgWidth + " HEI: "+ imgHeight);
        }

        public Boolean IsCookiePressed(Point p)
        {
            return true;
        }

    }
}
