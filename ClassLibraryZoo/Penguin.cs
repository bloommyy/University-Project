using System;
using System.Drawing;

namespace Preslav.ZooGame.ClassLibraryZoo
{
    /// <summary>
    /// Class Penguin that inherits class Animal.
    /// </summary>
    [Serializable]
    public class Penguin : Animal
    {
        private readonly int swimmingSpeed = 2;
        private bool isSwimming;

        /// <summary>
        /// Checks if the object is swimming.
        /// </summary>
        /// <returns>Result according to the animalImage's location.</returns>
        private bool CheckIfSwimming()
        {
            if (base.animalImage.Location.X >= base.CageFormBounds.Width / 2) // Checks if in water
                return true;

            return false;
        }

        /// <summary>
        /// Method that changes the animalImage's location according to the swimming or walking speed.
        /// </summary>
        public override void Move()
        {
            isSwimming = CheckIfSwimming();
            if (!isSwimming)
                base.Move();
            else
            {
                int X = base.animalImage.Location.X;
                int Y = base.animalImage.Location.Y;
                if ((base.direction & Direction.North) == Direction.North)
                {
                    animalImage.Location = new Point(X, Y - swimmingSpeed);
                    Y -= swimmingSpeed;
                }
                if ((base.direction & Direction.East) == Direction.East)
                {
                    animalImage.Location = new Point(X + swimmingSpeed, Y);
                    X += swimmingSpeed;
                }
                if ((base.direction & Direction.South) == Direction.South)
                {
                    animalImage.Location = new Point(X, Y + swimmingSpeed);
                    Y += swimmingSpeed;
                }
                if ((base.direction & Direction.West) == Direction.West)
                {
                    animalImage.Location = new Point(X - swimmingSpeed, Y);
                    X -= swimmingSpeed;
                }
            }
        }

        /// <summary>
        /// Constructor for Penguin.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="weight"></param>
        public Penguin(string name, int age, double weight)
        {
            base.Name = name;
            base.Age = age;
            base.Weight = weight;
            base.comfort = AnimalComfort.Neutral;
            base.walkingSpeed = 1;
            base.animalImage = new PenguinImage();
            isSwimming = false;
        }
    }
}
