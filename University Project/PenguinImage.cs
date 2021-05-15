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
        private Rectangle bodyRectangle;
        private Rectangle headRectangle;

        /// <summary>
        /// Draws the body of Penguin.
        /// </summary>
        protected override void DrawBody()
        {
            bodyRectangle = new Rectangle(Location.X, Location.Y, Width, Height);
            using(var pen = new Pen(Color.Black, 3))
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
            headRectangle = new Rectangle(Location.X + 15, Location.Y - 50, Width - 25, Height - 50);
            using (var pen = new Pen(Color.Black, 3))
            {
                //Head 
                base.graphics.DrawEllipse(pen, headRectangle);
            }
            using (var brush = new SolidBrush(Color.Gray))
            {
                base.graphics.FillEllipse(brush, Location.X + 15, Location.Y - 50, Width - 25, Height - 50);     
            }
            using (var brush = new SolidBrush(Color.White))
            {
                // Eyes 
                base.graphics.FillEllipse(brush, Location.X + 25, Location.Y - 40, 25, 40);
                base.graphics.FillEllipse(brush, Location.X + 55, Location.Y - 40, 25, 40);
            }
            using(var brush = new SolidBrush(Color.Black))
            {
                // Eyeballs
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
            using (var pen = new Pen(Color.Black, 3))
            {
                // Left foot
                base.graphics.DrawEllipse(pen, Location.X + 15, Location.Y + Height - 12, 25, 15);
                // Right foot
                base.graphics.DrawEllipse(pen, Location.X + Width - 40, Location.Y + Height - 12, 25, 15);
            }
            using (var brush = new SolidBrush(Color.Orange))
            {
                // Left foot
                base.graphics.FillEllipse(brush, Location.X + 15, Location.Y + Height - 12, 25, 15);
                // Right foot
                base.graphics.FillEllipse(brush, Location.X + Width - 40, Location.Y + Height - 12, 25, 15);
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
                base.graphics.FillEllipse(brush, Location.X + 10, Location.Y + 10, Width - 20, Height - 20);
            }
            using (var pen = new Pen(Color.Black, 3))
            {
                base.graphics.DrawEllipse(pen, Location.X + 5, Location.Y + 25, Width - 80, Height - 70);
                base.graphics.DrawEllipse(pen, Location.X + Width - 25, Location.Y + 25, Width - 80, Height - 70);
            }
            using (var brush = new SolidBrush(Color.Gray))
            {
                base.graphics.FillEllipse(brush, Location.X + 5, Location.Y + 25, Width - 80, Height - 70);
                base.graphics.FillEllipse(brush, Location.X + Width - 25, Location.Y + 25, Width - 80, Height - 70);
            }
        }

        /// <summary>
        /// Constructor for PeinguinImage.
        /// </summary>
        public PenguinImage()
        {
            base.Location = new Point(400, 400);
            base.Width = 100;
            base.Height = 120;
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
    }
}
