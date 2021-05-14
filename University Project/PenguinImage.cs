using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Project
{
    /// <summary>
    /// Image for Penguin, inherits AnimalImage.
    /// </summary>
    class PenguinImage : AnimalImage
    {
        /// <summary>
        /// Draws the body of Penguin.
        /// </summary>
        protected override void DrawBody()
        {
            // Draws penguin body - will be added when Forms are added.
        }

        /// <summary>
        /// Draws the head of Penguin.
        /// </summary>
        protected override void DrawHead()
        {
            // Draws penguin head - will be added when Forms are added.
        }

        /// <summary>
        /// Draws the legs of Penguin.
        /// </summary>
        protected override void DrawLegs()
        {
            // Draws penguin legs - will be added when Forms are added.
        }

        /// <summary>
        /// Draws the special features of Penguin.
        /// </summary>
        protected override void DrawSpecials()
        {
            // Draws penguin special features
        }

        /// <summary>
        /// Constructor for PeinguinImage.
        /// </summary>
        public PenguinImage()
        {
            base.Location = new Point(400, 400);
            base.Width = 150;
            base.Height = 100;
        }
    }
}
