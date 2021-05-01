using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University_Project
{

    public enum CagePosition
    {
        Left = 0,
        Right = 1
    }

    /// <summary>
    /// Class for the outlook of the cage in Zoo.
    /// </summary>
    public class AnimalCageImage
    {
        private int cageWidth;
        private readonly int cageHeight = 570;

        /// <summary>
        /// Used for x offset on first cage and for y offset on both cages.
        /// </summary>
        private readonly int cageOffset = 5;
        public Color Color;
        private Rectangle cageImage;
        public CagePosition cagePos;
        


        /// <summary>
        /// Draws first or second cage - 2/5ths of the width of the screen. 
        /// </summary>
        /// <param name="g"></param>
        public void DrawCage(Graphics g) // Should find a way to improve for multiple cages.
        {
            using(var pen = new Pen(Color, 10))
            {
                g.DrawRectangle(pen, cageImage);
            }
            using (var brush = new SolidBrush(Color.SandyBrown))
            {
                g.FillRectangle(brush, cageImage);
            }
        }
       
        /// <summary>
        /// Detemines if the point is in either of the cages.
        /// </summary>
        /// <param name="p">Location of mouse.</param>
        /// <returns></returns>
        public bool Contains(Point p)
        {
            return (cageImage.Contains(p));
        }

        /// <summary>
        /// Constructor for AnimalCageImage that sets the size of the Image of the cage calculated by the proportions of the form.
        /// </summary>
        /// <param name="formBounds">The bounds of the form.</param>
        /// <param name="_cagePos">The position of the cage.</param>
        public AnimalCageImage(Graphics g, Rectangle formBounds, CagePosition _cagePos)
        {
            Color = Color.Brown;
            cagePos = _cagePos;
            cageWidth = 2 * (formBounds.Width / 5);
            cageImage = new Rectangle(((int)(cagePos) * 3 * (formBounds.Width / 5) + cageOffset), cageOffset, cageWidth, cageHeight);
        }
    }
}
