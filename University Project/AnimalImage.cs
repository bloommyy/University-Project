using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Project
{
    public abstract class AnimalImage
    {
        public Point Location { get; set; }
        public double Size { get; set; }

        protected virtual void DrawBody()
        {
            // Draws body
        }

        protected virtual void DrawHead()
        {
            // Draws head
        }

        protected virtual void DrawLegs()
        {
            // Draws legs
        }

        protected virtual void DrawSpecials()
        {
            // Draws special features
        }

        public void DrawAnimal()
        {
            DrawBody();
            DrawHead();
            DrawLegs();
            DrawSpecials();
        }
    }
}
