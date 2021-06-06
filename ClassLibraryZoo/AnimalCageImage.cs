using System;
using System.Drawing;

namespace Preslav.ZooGame.ClassLibraryZoo
{
    /// <summary>
    /// Enum showing which side the cage is on.
    /// </summary>
    public enum CagePosition
    {
        /// <summary>
        /// Left side of the screen.
        /// </summary>
        Left = 0,

        /// <summary>
        /// Right side of the screen.
        /// </summary>
        Right = 1
    }

    /// <summary>
    /// Class for the outlook of the cage in Zoo.
    /// </summary>
    [Serializable]
    public class AnimalCageImage
    {
        private int cageWidth;
        private int cageHeight = 570;

        /// <summary>
        /// Used for x and y offset on both cages.
        /// </summary>
        private readonly int cageOffset = 5;

        /// <summary>
        /// The color of the fence. Black = selected.
        /// </summary>
        public Color fenceColor;

        /// <summary>
        /// A rectangle for the cage.
        /// </summary>
        public Rectangle cageImageRectangle;

        /// <summary>
        /// The position of the cage. Can be Left or Right.
        /// </summary>
        public CagePosition cagePos;

        /// <summary>
        /// Draws first or second cage - 2/5ths of the width of the screen. 
        /// </summary>
        /// <param name="g"></param>
        public void DrawCage(IDrawZoo g)
        {
            g.DrawCage(fenceColor, cageImageRectangle);
        }

        /// <summary>
        /// Determines if the point is in either of the cages.
        /// </summary>
        /// <param name="p">Location of mouse.</param>
        /// <returns></returns>
        public bool Contains(Point p)
        {
            return (cageImageRectangle.Contains(p));
        }

        /// <summary>
        /// Constructor for AnimalCageImage that sets the size of the Image of the cage calculated by the proportions of the form.
        /// </summary>
        /// <param name="g">Graphics used for drawing.</param>
        /// <param name="formBounds">The bounds of the form.</param>
        /// <param name="_cagePos">The position of the cage.</param>
        public AnimalCageImage(Rectangle formBounds, CagePosition _cagePos)
        {
            fenceColor = Color.Brown;
            cagePos = _cagePos;
            cageWidth = 2 * (formBounds.Width / 5);
            cageImageRectangle = new Rectangle(((int)(cagePos) * 3 * (formBounds.Width / 5) + cageOffset), cageOffset, cageWidth, cageHeight);
        }

        /// <summary>
        /// Updates the width and height of the cageImage.
        /// </summary>
        /// <param name="formBounds"></param>
        /// <param name="panelInfoBounds"></param>
        public void UpdateScale(Rectangle formBounds, Rectangle panelInfoBounds)
        {
            cageWidth = 2 * (formBounds.Width / 5) - 25;
            cageHeight = formBounds.Height - panelInfoBounds.Height - 50;
            cageImageRectangle = new Rectangle(((int)(cagePos) * 3 * (formBounds.Width / 5) + cageOffset), cageOffset, cageWidth, cageHeight);
        }
    }
}
