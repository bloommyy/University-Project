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
    [Serializable]
    class ElephantImage : AnimalImage
    {
        private Rectangle bodyRectangle;

        private Rectangle headRectangle;
        private int headPositionOffsetX;
        private int headPositionOffsetY;
        private int headWidth;
        private int headHeight;

        private Rectangle[] legs;
        private int firstLegPositionOffsetX;
        private int secondLegPositionOffsetX;
        private int thirdLegPositionOffsetX;
        private int fourthLegPositionOffsetX;
        private int legsPositionOffsetY;
        private int legWidth;
        private int legHeight;

        private Point[] curvePoints;
        private int trunkContour;
        private int trunkWidth;
        private int firstTrunkOffsetX;
        private int firstTrunkOffsetY;
        private int secondTrunkOffsetX;
        private int secondTrunkOffsetY;
        private int thirdFourthFifthTrunkOffsetX;
        private int thirdTrunkOffsetY;
        private int fourthTrunkOffsetY;
        private int fifthTrunkOffsetY;
        private int sixthTrunkOffsetX;
        private int sixthTrunkOffsetY;



        /// <summary>
        /// Draws the body of Elephant.
        /// </summary>
        protected override void DrawBody()
        {
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
            if (base.outlineSize == 6)
                trunkWidth /= 2;

            // Outline of trunk
            using (var pen = new Pen(Color.Black, trunkContour)) // trunk
            {
                base.graphics.DrawCurve(pen, curvePoints);
            }
            // Drawing trunk
            using (var pen = new Pen(Color.LightBlue, trunkWidth)) // trunk
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

            headPositionOffsetX = 120;
            headPositionOffsetY = 10;
            headWidth = 60;
            headHeight = 60;

            firstLegPositionOffsetX = 10;
            secondLegPositionOffsetX = 40;
            thirdLegPositionOffsetX = 90;
            fourthLegPositionOffsetX = 120;
            legsPositionOffsetY = 55;
            legWidth = 20;
            legHeight = 100;

            trunkWidth = 4;
            trunkContour = 6;
            firstTrunkOffsetX = 178;
            firstTrunkOffsetY = 15;
            secondTrunkOffsetX = 186;
            secondTrunkOffsetY = 20;
            thirdFourthFifthTrunkOffsetX = 188;
            thirdTrunkOffsetY = 25;
            fourthTrunkOffsetY = 55;
            fifthTrunkOffsetY = 75;
            sixthTrunkOffsetX = 195;
            sixthTrunkOffsetY = 85;
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

        public override void ScaleAnimalSize(Rectangle formBounds)
        {
            base.BodyWidth = (int)(formBounds.Width * 0.1171);
            base.BodyHeight = (int)(formBounds.Height * 0.1388);

            // Scaling head
            headPositionOffsetX = (int)(formBounds.Width * 0.0937);
            headPositionOffsetY = (int)(formBounds.Height * 0.0138);
            headWidth = (int)(formBounds.Width * 0.0468);
            headHeight = (int)(formBounds.Height * 0.0833);
            headRectangle = new Rectangle(Location.X + headPositionOffsetX,
                Location.Y - headPositionOffsetY, headWidth, headHeight);

            // Scaling body
            bodyRectangle = new Rectangle(Location.X, Location.Y, BodyWidth, BodyHeight);

            // Scaling legs
            firstLegPositionOffsetX = (int)(formBounds.Width * 0.0078);
            secondLegPositionOffsetX = (int)(formBounds.Width * 0.0312);
            thirdLegPositionOffsetX = (int)(formBounds.Width * 0.0703);
            fourthLegPositionOffsetX = (int)(formBounds.Width * 0.0937);
            legsPositionOffsetY = (int)(formBounds.Height * 0.0763);
            legWidth = (int)(formBounds.Width * 0.0156);
            legHeight = (int)(formBounds.Height * 0.1388);
            legs = new Rectangle[]{
                new Rectangle(Location.X + firstLegPositionOffsetX,
                Location.Y + legsPositionOffsetY, legWidth, legHeight),
                new Rectangle(Location.X + secondLegPositionOffsetX,
                Location.Y + legsPositionOffsetY, legWidth, legHeight),
                new Rectangle(Location.X + thirdLegPositionOffsetX,
                Location.Y + legsPositionOffsetY, legWidth, legHeight),
                new Rectangle(Location.X + fourthLegPositionOffsetX,
                Location.Y + legsPositionOffsetY, legWidth, legHeight)
            };

            // Scaling trunk
            trunkWidth = (int)(formBounds.Width * 0.0031);
            trunkContour = (int)(formBounds.Width * 0.0046);
            firstTrunkOffsetX = (int)(formBounds.Width * 0.139);
            firstTrunkOffsetY = (int)(formBounds.Height * 0.0208);
            secondTrunkOffsetX = (int)(formBounds.Width * 0.1453);
            secondTrunkOffsetY = (int)(formBounds.Height * 0.0277);
            thirdFourthFifthTrunkOffsetX = (int)(formBounds.Width * 0.1468);
            thirdTrunkOffsetY = (int)(formBounds.Height * 0.0347);
            fourthTrunkOffsetY = (int)(formBounds.Height * 0.0763);
            fifthTrunkOffsetY = (int)(formBounds.Height * 0.1041);
            sixthTrunkOffsetX = (int)(formBounds.Width * 0.1523);
            sixthTrunkOffsetY = (int)(formBounds.Height * 0.118);
            Point point1 = new Point(Location.X + firstTrunkOffsetX, Location.Y + firstTrunkOffsetY);
            Point point2 = new Point(Location.X + secondTrunkOffsetX, Location.Y + secondTrunkOffsetY);
            Point point3 = new Point(Location.X + thirdFourthFifthTrunkOffsetX, Location.Y + thirdTrunkOffsetY);
            Point point4 = new Point(Location.X + thirdFourthFifthTrunkOffsetX, Location.Y + fourthTrunkOffsetY);
            Point point5 = new Point(Location.X + thirdFourthFifthTrunkOffsetX, Location.Y + fifthTrunkOffsetY);
            Point point6 = new Point(Location.X + sixthTrunkOffsetX, Location.Y + sixthTrunkOffsetY);
            curvePoints = new Point[] { point1, point2, point3, point4, point5, point6 };
        }
    }
}
