using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Project
{
    /// <summary>
    /// Image for Elephant, inherits AnimalImage.
    /// </summary>
    class ElephantImage : AnimalImage
    {
        /// <summary>
        /// Draws the body of Elephant.
        /// </summary>
        protected override void DrawBody()
        {
            // Draws elephant body - will be added when Forms are added.
        }

        /// <summary>
        /// Draws the head of Elephant.
        /// </summary>
        protected override void DrawHead()
        {
            // Draws elephant head - will be added when Forms are added.
        }

        /// <summary>
        /// Draws the legs of Elephant.
        /// </summary>
        protected override void DrawLegs()
        {
            // Draws elephant legs - will be added when Forms are added.
        }

        /// <summary>
        /// Draws the special features of Elephant.
        /// </summary>
        protected override void DrawSpecials()
        {
            // Draws elephant special features - will be added when Forms are added.
        }

        /// <summary>
        /// Constructor for ElephantImage.
        /// </summary>
        public ElephantImage()
        {
            base.DrawAnimal();
        }
    }
}
