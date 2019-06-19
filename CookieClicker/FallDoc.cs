using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
namespace CookieClicker
{
    public class FallDoc
    {
        public List<Fall> Falls { get; set; }

        public FallDoc()
        {
            Falls = new List<Fall>();
        }

        public void AddFall(Point center)
        {
            Fall b = new Fall();
            b.Center = center;
            Falls.Add(b);
        }

        public void Move(int width)
        {
            foreach (Fall b in Falls)
                b.Move();
        }

        public void Draw(Graphics g)
        {
            foreach (Fall b in Falls)
            {
                b.Draw(g);
            }
        }
    }
}
