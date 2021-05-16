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
        private readonly int legWidth = 20; // Will be made scalable maybe
        private readonly int legHeight = 100; // Will be made scalable maybe
        private Rectangle[] legs;
        private Rectangle bodyRectangle;
        private Rectangle headRectangle;

        /// <summary>
        /// Draws the body of Elephant.
        /// </summary>
        protected override void DrawBody()
        {
            bodyRectangle = new Rectangle(Location.X, Location.Y, BodyWidth, BodyHeight);
            using (var pen = new Pen(Color.Black, base.outlineSize))
            {
                base.graphics.DrawEllipse(pen, bodyRectangle);
            }
            using (var brush = new SolidBrush(Color.LightBlue))
            {
                base.graphics.FillEllipse(brush, bodyRectangle);
            }
        }

        /// <summary>
        /// Draws the head of Elephant.
        /// </summary>
        protected override void DrawHead()
        {
            headRectangle = new Rectangle(Location.X + 120, Location.Y - 10, BodyWidth - 90, BodyHeight - 40);
            using (var pen = new Pen(Color.Black, base.outlineSize))
            {
                base.graphics.DrawEllipse(pen, headRectangle);
            }
            using (var brush = new SolidBrush(Color.LightBlue))
            {
                base.graphics.FillEllipse(brush, headRectangle);
            }
        }

        /// <summary>
        /// Draws the legs of Elephant.
        /// </summary>
        protected override void DrawLegs()
        {
            legs = new Rectangle[]{ 
                new Rectangle(Location.X + 10, Location.Y + 55, legWidth, legHeight),
                new Rectangle(Location.X + 40, Location.Y + 55, legWidth, legHeight),
                new Rectangle(Location.X + 90, Location.Y + 55, legWidth, legHeight),
                new Rectangle(Location.X + 120, Location.Y + 55, legWidth, legHeight)};

            using (var pen = new Pen(Color.Black, base.outlineSize))
            {
                for(int i  = 0; i < legs.Length; i++)
                {
                    base.graphics.DrawRectangle(pen,legs[i]);
                }
            }
            using (var brush = new SolidBrush(Color.LightBlue))
            {
                for (int i = 0; i < legs.Length; i++)
                {
                    base.graphics.FillRectangle(brush, legs[i]);
                }
            }
        }

        /// <summary>
        /// Draws the special features of Elephant.
        /// </summary>
        protected override void DrawSpecials()
        {
            Point point1 = new Point(Location.X + 178, Location.Y + 15);
            Point point2 = new Point(Location.X + 186, Location.Y + 20);
            Point point3 = new Point(Location.X + 188, Location.Y + 25);
            Point point4 = new Point(Location.X + 188, Location.Y + 55);
            Point point5 = new Point(Location.X + 188, Location.Y + 75);
            Point point6 = new Point(Location.X + 195, Location.Y + 85);
            Point[] curvePoints = { point1, point2, point3, point4, point5, point6 };

            int trunkSize = 4;
            if (base.outlineSize == 6)
                trunkSize = 2;

            // Outline of trunk
            using (var pen = new Pen(Color.Black, 6)) // trunk
            {
                base.graphics.DrawCurve(pen, curvePoints);
            }
            // Drawing trunk
            using (var pen = new Pen(Color.LightBlue, trunkSize)) // trunk
            {
                base.graphics.DrawCurve(pen, curvePoints);
            }
        }

        /// <summary>
        /// Constructor for ElephantImage.
        /// </summary>
        public ElephantImage()
        {
            base.Location = new Point(400, 400);
            base.BodyWidth = 150;
            base.BodyHeight = 100;
            base.ActualHeight = BodyHeight + legHeight;
        }

        /// <summary>
        /// Method for checking if the cursor is over the animalImage.
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        public override bool Contains(Point point)
        {
            // Checking if clicked on legs
            for(int i = 0; i < legs.Length; i++)
            {
                if (legs[i].Contains(point)) return true;
            }
            //Checking if clicked on head
            using(var gp = new System.Drawing.Drawing2D.GraphicsPath())
            {
                gp.AddEllipse(headRectangle);
                gp.AddEllipse(bodyRectangle);
                if (gp.IsVisible(point)) return true;
            }
            return false;
        }
    }
}
