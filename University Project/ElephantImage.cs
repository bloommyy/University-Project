using System;
using System.Collections.Generic;
using System.Drawing;
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
            using (var pen = new Pen(Color.LightBlue, 3))
            {
                base.graphics.DrawEllipse(pen, Location.X, Location.Y, Width, Height);
            }
            using (var brush = new SolidBrush(Color.LightBlue))
            {
                base.graphics.FillEllipse(brush, Location.X, Location.Y, Width, Height);
            }
        }

        /// <summary>
        /// Draws the head of Elephant.
        /// </summary>
        protected override void DrawHead()
        {
            using(var brush = new SolidBrush(Color.LightBlue))
            {
                base.graphics.FillEllipse(brush, Location.X + 120, Location.Y - 10, Width - 90, Height - 40);
            }
        }

        /// <summary>
        /// Draws the legs of Elephant.
        /// </summary>
        protected override void DrawLegs()
        {
            using (var pen = new Pen(Color.LightBlue, 20))
            {
                base.graphics.DrawLine(pen, Location.X + 20, Location.Y + 65, Location.X + 20, Location.Y + 140);
                base.graphics.DrawLine(pen, Location.X + 50, Location.Y + 65, Location.X + 50, Location.Y + 140);
                base.graphics.DrawLine(pen, Location.X + 100, Location.Y + 65, Location.X + 100, Location.Y + 140);
                base.graphics.DrawLine(pen, Location.X + 130, Location.Y + 65, Location.X + 130, Location.Y + 140);
            }
        }

        /// <summary>
        /// Draws the special features of Elephant.
        /// </summary>
        protected override void DrawSpecials()
        {
            using (var pen = new Pen(Color.LightBlue, 6)) // trunk
            {
                Point point1 = new Point(Location.X + 178, Location.Y + 15);
                Point point2 = new Point(Location.X + 186, Location.Y + 20);
                Point point3 = new Point(Location.X + 188, Location.Y + 25);
                Point point4 = new Point(Location.X + 188, Location.Y + 55);
                Point point5 = new Point(Location.X + 188, Location.Y + 75);
                Point point6 = new Point(Location.X + 195, Location.Y + 85);

                Point[] curvePoints = { point1, point2, point3, point4, point5, point6 };

                // Draw curve to screen.
                base.graphics.DrawCurve(pen, curvePoints);
            }
        }

        /// <summary>
        /// Constructor for ElephantImage.
        /// </summary>
        public ElephantImage()
        {
            base.Location = new Point(400, 400);
            base.Width = 150;
            base.Height = 100;
        }
    }
}
