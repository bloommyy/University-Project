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

        private int headPositionOffsetX;
        private int headPositionOffsetY;
        private int headWidth;
        private int headHeight;

        private int leftFaceCirclePositionOffsetX;
        private int rightFaceCirclePositionOffsetX;
        private int faceCirclePositionOffsetY;
        private int faceCircleWidth;
        private int faceCircleHeight;

        private int leftEyePositionOffsetX;
        private int rightEyePositionOffsetX;
        private int eyesPositionOffsetY;
        private int eyeWidth;
        private int eyeHeight;

        private int mouthPositionOffsetX;
        private int mouthWidth;
        private int mouthHeight;

        private int leftFootPositionOffsetX;
        private int rightFootPositionOffsetX;
        private int feetPositionOffsetY;
        private int feetWidth;
        private int feetHeight;

        private int stomachPositionOffsetX;
        private int stomachPositionOffsetY;
        private int stomachWidth;
        private int stomachHeight;

        private int leftWingPositionOffsetX;
        private int rightWingPositionOffsetX;
        private int wingsPositionOffsetY;
        private int wingsWidth;
        private int wingsHeight;

        /// <summary>
        /// Draws the body of Penguin.
        /// </summary>
        protected override void DrawBody()
        {
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
                base.graphics.FillEllipse(brush, Location.X + leftFaceCirclePositionOffsetX,
                    Location.Y - faceCirclePositionOffsetY, faceCircleWidth, faceCircleHeight);
                base.graphics.FillEllipse(brush, Location.X + rightFaceCirclePositionOffsetX,
                    Location.Y - faceCirclePositionOffsetY, faceCircleWidth, faceCircleHeight);       
            }
            using(var brush = new SolidBrush(Color.Black))
            {
                // Eyes
                base.graphics.FillEllipse(brush, Location.X + leftEyePositionOffsetX,
                    Location.Y - eyesPositionOffsetY, eyeWidth, eyeHeight);
                base.graphics.FillEllipse(brush, Location.X + rightEyePositionOffsetX,
                    Location.Y - eyesPositionOffsetY, eyeWidth, eyeHeight);
            }
            using(var brush = new SolidBrush(Color.Orange))
            {
                // Mouth
                base.graphics.FillEllipse(brush, Location.X + mouthPositionOffsetX,
                    Location.Y, mouthWidth, mouthHeight);
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
                base.graphics.DrawEllipse(pen, Location.X + leftFootPositionOffsetX,
                    Location.Y + feetPositionOffsetY, feetWidth, feetHeight);
                // Right foot
                base.graphics.DrawEllipse(pen, Location.X + rightFootPositionOffsetX,
                    Location.Y + feetPositionOffsetY, feetWidth, feetHeight);
            }
            using (var brush = new SolidBrush(Color.Orange))
            {
                // Left foot
                base.graphics.FillEllipse(brush, Location.X + leftFootPositionOffsetX,
                    Location.Y + feetPositionOffsetY, feetWidth, feetHeight);
                // Right foot
                base.graphics.FillEllipse(brush, Location.X + rightFootPositionOffsetX,
                    Location.Y + feetPositionOffsetY, feetWidth, feetHeight);
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
                base.graphics.FillEllipse(brush, Location.X + stomachPositionOffsetX,
                    Location.Y + stomachPositionOffsetY, stomachWidth, stomachHeight);
            }
            using (var pen = new Pen(Color.Black, base.outlineSize))
            {
                // Wings
                base.graphics.DrawEllipse(pen, Location.X + leftWingPositionOffsetX,
                    Location.Y + wingsPositionOffsetY, wingsWidth, wingsHeight);
                base.graphics.DrawEllipse(pen, Location.X + rightWingPositionOffsetX,
                    Location.Y + wingsPositionOffsetY, wingsWidth, wingsHeight);
            }
            using (var brush = new SolidBrush(Color.Gray))
            {
                // Wings
                base.graphics.FillEllipse(brush, Location.X + leftWingPositionOffsetX,
                    Location.Y + wingsPositionOffsetY, wingsWidth, wingsHeight);
                base.graphics.FillEllipse(brush, Location.X + rightWingPositionOffsetX,
                    Location.Y + wingsPositionOffsetY, wingsWidth, wingsHeight);
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

            headPositionOffsetX = 15;
            headPositionOffsetY = 50;
            headWidth = 75;
            headHeight = 70;

            leftFaceCirclePositionOffsetX = 25;
            rightFaceCirclePositionOffsetX = leftFaceCirclePositionOffsetX + 30;
            faceCirclePositionOffsetY = 40;
            faceCircleWidth = 25;
            faceCircleHeight = 40;

            leftEyePositionOffsetX = 32;
            rightEyePositionOffsetX = 62;
            eyesPositionOffsetY = 32;
            eyeWidth = 7;
            eyeHeight = 7;

            mouthPositionOffsetX = 38;
            mouthWidth = 30;
            mouthHeight = 12;
            

            leftFootPositionOffsetX = 15;
            rightFootPositionOffsetX = 60;
            feetPositionOffsetY = 108;
            feetWidth = 25;
            feetHeight = 15;

            stomachPositionOffsetX = 10;
            stomachPositionOffsetY = 10;
            stomachWidth = 80;
            stomachHeight = 100;

            leftWingPositionOffsetX = 5;
            rightWingPositionOffsetX = 75;
            wingsPositionOffsetY = 25;
            wingsWidth = 20;
            wingsHeight = 50;
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

            // Scaling head
            headPositionOffsetX = (int)(formBounds.Width * 0.0117);
            headPositionOffsetY = (int)(formBounds.Height * 0.0694);
            headWidth = (int)(formBounds.Width * 0.0585);
            headHeight = (int)(formBounds.Height * 0.0972);
            headRectangle = new Rectangle(Location.X + headPositionOffsetX,
                Location.Y - headPositionOffsetY, headWidth, headHeight);

            // Scaling body
            bodyRectangle = new Rectangle(Location.X, Location.Y, BodyWidth, BodyHeight);

            // Scaling circles on the face
            leftFaceCirclePositionOffsetX = (int)(formBounds.Width * 0.0195);
            rightFaceCirclePositionOffsetX = leftFaceCirclePositionOffsetX + (int)(formBounds.Width * 0.0234);
            faceCirclePositionOffsetY = (int)(formBounds.Height * 0.0555);
            faceCircleWidth = (int)(formBounds.Width * 0.0195);
            faceCircleHeight = (int)(formBounds.Height * 0.0555);
            
            // Scaling eyes
            leftEyePositionOffsetX = (int)(formBounds.Width * 0.025);
            rightEyePositionOffsetX = (int)(formBounds.Width * 0.0484);
            eyesPositionOffsetY = (int)(formBounds.Height * 0.0444);
            eyeWidth = (int)(formBounds.Width * 0.0054);
            eyeHeight = (int)(formBounds.Height * 0.0097);

            // Scaling mouth
            mouthPositionOffsetX = (int)(formBounds.Width * 0.0296);
            mouthWidth = (int)(formBounds.Width * 0.0234);
            mouthHeight = (int)(formBounds.Height * 0.0166);

            // Scaling feet
            leftFootPositionOffsetX = (int)(formBounds.Width * 0.0117);
            rightFootPositionOffsetX  = (int)(formBounds.Width * 0.0468);
            feetPositionOffsetY = (int)(formBounds.Height * 0.15);
            feetWidth = (int)(formBounds.Width * 0.0195);
            feetHeight = (int)(formBounds.Height * 0.0208);

            // Scaling stomach
            stomachPositionOffsetX = (int)(formBounds.Width * 0.0078);
            stomachPositionOffsetY = (int)(formBounds.Height * 0.0138);
            stomachWidth = (int)(formBounds.Width * 0.0625);
            stomachHeight = (int)(formBounds.Height * 0.1388);

            // Scaling wings
            leftWingPositionOffsetX = (int)(formBounds.Width * 0.0039);
            rightWingPositionOffsetX = (int)(formBounds.Width * 0.0585);
            wingsPositionOffsetY = (int)(formBounds.Height * 0.0347);
            wingsWidth = (int)(formBounds.Width * 0.0156);
            wingsHeight = (int)(formBounds.Height * 0.0694);
        }
    }
}
