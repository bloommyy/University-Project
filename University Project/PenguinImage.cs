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
    [Serializable]
    class PenguinImage : AnimalImage
    {
        private Rectangle bodyRectangle;
        private Rectangle headRectangle;

        /// <summary>
        /// Draws the body of Penguin.
        /// </summary>
        protected override void DrawBody()
        {
     
            bodyRectangle = new Rectangle(Location.X, Location.Y, BodyWidth, BodyHeight);
            using(var pen = new Pen(Color.Black, base.outlineSize))
            {
                base.graphics.DrawEllipse(pen, bodyRectangle);
            }
            using(var brush = new SolidBrush(Color.Gray))
            {
                base.graphics.FillEllipse(brush, bodyRectangle);
            }
        }

        /// <summary>
        /// Draws the head of Penguin.
        /// </summary>
        protected override void DrawHead()
        {
            headRectangle = new Rectangle(Location.X + 15, Location.Y - 50, BodyWidth - 25, BodyHeight - 50);
            using (var pen = new Pen(Color.Black, base.outlineSize))
            {
                // Head 
                base.graphics.DrawEllipse(pen, headRectangle);
            }
            using (var brush = new SolidBrush(Color.Gray))
            {
                // Head 
                base.graphics.FillEllipse(brush, headRectangle);     
            }
            using (var brush = new SolidBrush(Color.White))
            {
                // Face 
                base.graphics.FillEllipse(brush, Location.X + 25, Location.Y - 40, 25, 40);
                base.graphics.FillEllipse(brush, Location.X + 55, Location.Y - 40, 25, 40);
            }
            using(var brush = new SolidBrush(Color.Black))
            {
                // Eyes
                base.graphics.FillEllipse(brush, Location.X + 32, Location.Y - 32, 7, 7);
                base.graphics.FillEllipse(brush, Location.X + 62, Location.Y - 32, 7, 7);
            }
            using(var brush = new SolidBrush(Color.Orange))
            {
                // Mouth
                base.graphics.FillEllipse(brush, Location.X + 38, Location.Y, 30, 12);
            }
        }

        /// <summary>
        /// Draws the legs of Penguin.
        /// </summary>
        protected override void DrawLegs()
        {
            using (var pen = new Pen(Color.Black, base.outlineSize))
            {
                // Left foot
                base.graphics.DrawEllipse(pen, Location.X + 15, Location.Y + BodyHeight - 12, 25, 15);
                // Right foot
                base.graphics.DrawEllipse(pen, Location.X + BodyWidth - 40, Location.Y + BodyHeight - 12, 25, 15);
            }
            using (var brush = new SolidBrush(Color.Orange))
            {
                // Left foot
                base.graphics.FillEllipse(brush, Location.X + 15, Location.Y + BodyHeight - 12, 25, 15);
                // Right foot
                base.graphics.FillEllipse(brush, Location.X + BodyWidth - 40, Location.Y + BodyHeight - 12, 25, 15);
            }
        }

        /// <summary>
        /// Draws the special features of Penguin.
        /// </summary>
        protected override void DrawSpecials()
        {
            using (var brush = new SolidBrush(Color.White))
            {
                // Stomach
                base.graphics.FillEllipse(brush, Location.X + 10, Location.Y + 10, BodyWidth - 20, BodyHeight - 20);
            }
            using (var pen = new Pen(Color.Black, base.outlineSize))
            {
                // Wings
                base.graphics.DrawEllipse(pen, Location.X + 5, Location.Y + 25, BodyWidth - 80, BodyHeight - 70);
                base.graphics.DrawEllipse(pen, Location.X + BodyWidth - 25, Location.Y + 25, BodyWidth - 80, BodyHeight - 70);
            }
            using (var brush = new SolidBrush(Color.Gray))
            {
                // Wings
                base.graphics.FillEllipse(brush, Location.X + 5, Location.Y + 25, BodyWidth - 80, BodyHeight - 70);
                base.graphics.FillEllipse(brush, Location.X + BodyWidth - 25, Location.Y + 25, BodyWidth - 80, BodyHeight - 70);
            }
        }

        /// <summary>
        /// Constructor for PeinguinImage.
        /// </summary>
        public PenguinImage()
        {
            base.Location = new Point(1000, 400);
            base.BodyWidth = 100;
            base.BodyHeight = 120;
            base.ActualHeight = BodyHeight;
        }

        /// <summary>
        /// Draws the animal.
        /// </summary>
        /// <param name="g"></param>
        public override void DrawAnimal(Graphics g)
        {
            graphics = g;
            DrawBody();
            DrawSpecials();
            DrawLegs();            
            DrawHead();
        }

        /// <summary>
        /// Checks if user has clicked on the penguin.
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        public override bool Contains(Point point)
        {
            using (var gp = new System.Drawing.Drawing2D.GraphicsPath())
            {
                gp.AddEllipse(bodyRectangle);
                gp.AddEllipse(headRectangle);
                if (gp.IsVisible(point)) return true;
            }
            return false;
        }

        public override void ScaleAnimalSize(Rectangle formBounds)
        {
            base.BodyWidth = (int)(formBounds.Width * 0.0781);
            base.BodyHeight = (int)(formBounds.Height * 0.1666);
        }
    }
}
