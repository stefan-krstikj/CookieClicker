using System;
using System.Collections.Generic;
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
            image = Properties.Resources.cookie1;
            this.point = new Point(Constants.COOKIE_X, Constants.COOKIE_Y);
        }

        public void Draw(Graphics g)
        {
            // todo: Draw Cookie in image variable
        }
    }
}
