using System;
using System.Drawing;

namespace Preslav.ZooGame.ClassLibraryZoo
{
    /// <summary>
    /// Base class of AnimalImage.
    /// </summary>
    [Serializable]
    public abstract class AnimalImage
    {
        private Point _location;

        /// <summary>
        /// The location of the animal's drawing.
        /// </summary>
        public Point Location
        {
            get { return _location; }
            set { _location = value; }
        }

        private int _bodyWidth;
        /// <summary>
        /// The width of the animal.
        /// </summary>
        public int BodyWidth { get { return _bodyWidth; } set { _bodyWidth = value; } }

        private int _bodyHeight;
        /// <summary>
        /// The height of the animal.
        /// </summary>
        public int BodyHeight { get { return _bodyHeight; } set { _bodyHeight = value; } }

        /// <summary>
        /// The actual height of the animal - body + head;
        /// </summary>
        public int ActualHeight { get; set; }

        private int _outlineSize = 3;
        /// <summary>
        /// The size of the outline of the animal's drawing.
        /// </summary>
        public int OutlineSize
        {
            get { return _outlineSize; }
            set { _outlineSize = value; }
        }

        /// <summary>
        /// Draws the Animal using Graphics.Draw.
        /// </summary>
        public abstract void DrawAnimal(IDrawAnimal drawAnimal, Animal animal);


        /// <summary>
        ///  Method for checking if the cursor is over the animalImage.
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        public abstract bool Contains(Point point);

        /// <summary>
        /// Changes the height and the width according to the form's size.
        /// </summary>
        /// <param name="formBounds"></param>
        public abstract void ScaleAnimalSize(Rectangle formBounds);
    }
}
