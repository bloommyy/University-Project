using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Project
{
    /// <summary>
    /// Base class of AnimalImage.
    /// </summary>
    public abstract class AnimalImage
    {
        public Point Location { get; set; }
        public double Size { get; set; }

        /// <summary>
        /// Draws the body of the animal.
        /// </summary>
        protected abstract void DrawBody();

        /// <summary>
        /// Draws the head of the animal.
        /// </summary>
        protected abstract void DrawHead();

        /// <summary>
        /// Draws the legs of the animal.
        /// </summary>
        protected abstract void DrawLegs();

        /// <summary>
        /// Draws the special features of the animal.
        /// </summary>
        protected abstract void DrawSpecials();

        /// <summary>
        /// Draws the Animal using Graphics.Draw.
        /// </summary>
        public void DrawAnimal()
        {
            DrawBody();
            DrawHead();
            DrawLegs();
            DrawSpecials();
        }
    }
}
