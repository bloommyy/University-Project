using System;
using System.Drawing;

namespace Preslav.ZooGame.ClassLibraryZoo
{
    /// <summary>
    /// Enum for the comfort of the animal.
    /// </summary>
    public enum AnimalComfort
    {
        /// <summary>
        /// Animal is uncomfortable. May run away.
        /// </summary>
        Uncomfortable = 0,

        /// <summary>
        /// Animal is slightly uneasy.
        /// </summary>
        SlightlyUneasy = 1,

        /// <summary>
        /// Animal's comfort is neutral.
        /// </summary>
        Neutral = 2,

        /// <summary>
        /// Animal is satisfied.
        /// </summary>
        Satisfied = 3,

        /// <summary>
        /// Animal is comfortable.
        /// </summary>
        Comfortable = 4
    }

    /// <summary>
    /// Enum for the Direction the animal is going in.
    /// </summary>
    public enum Direction
    {
        /// <summary>
        /// animalImage will move North.
        /// </summary>
        North = 1,

        /// <summary>
        /// animalImage will move East.
        /// </summary>
        East = 2,

        /// <summary>
        /// animalImage will move South.
        /// </summary>
        South = 4,

        /// <summary>
        /// animalImage will move West.
        /// </summary>
        West = 8
    }

    /// <summary>
    /// This is the base class of Animal.
    /// </summary>
    [Serializable]
    public abstract class Animal
    {
        /// <summary>
        /// The name of the animal.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The age of the animal.
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// The weight of the animal.
        /// </summary>
        public double Weight { get; set; }

        /// <summary>
        /// Animal's comfort.
        /// </summary>
        protected AnimalComfort comfort;

        /// <summary>
        /// The walking speed of the animal.
        /// </summary>
        protected int walkingSpeed;

        /// <summary>
        /// The outlook/drawing of the animal.
        /// </summary>
        public AnimalImage animalImage;

        /// <summary>
        /// The direction the animal is going in.
        /// </summary>
        public Direction direction;
        private static readonly Random rnd = new Random();
        private Rectangle _cageFormBounds;

        /// <summary>
        /// The bounds of the cageForm.
        /// </summary>
        public Rectangle CageFormBounds { get { return _cageFormBounds; } set { _cageFormBounds = value; } }

        /// <summary>
        /// The height of the panel in cageForm.
        /// </summary>
        public int panelHeight;

        /// <summary>
        /// Boolean for check if an animal has been close to going out of the form.
        /// </summary>
        public bool hasBeenCloseToOutOfBounds = false;

        /// <summary>
        /// Method Eat that lowers the given FodderState by one, if Empty - it does nothing.
        /// </summary>
        /// <param name="fodder"></param>
        /// <returns>FodderState</returns>
        public FodderState Eat(FodderState fodder)
        {
            if (fodder > 0)
                return --fodder;

            return fodder;
        }

        /// <summary>
        /// Returns a mask with the available directions according to the given Point by using bitwise OR and AND.
        /// </summary>
        /// <param name="location"></param>
        /// <returns>Direction</returns>
        protected Direction GenerateMask(Point location)
        {

            // Making a mask with all directions available
            Direction mask = Direction.East | Direction.North | Direction.South | Direction.West;

            // Removing West from possibilities
            if (location.X <= _cageFormBounds.Width / 10 + 9)
            {
                mask &= (Direction.East | Direction.North | Direction.South);
            }

            // Removing East from possibilities
            if (location.X >= _cageFormBounds.Width - animalImage.BodyWidth - 50)
            {
                mask &= (Direction.West | Direction.North | Direction.South);
            }

            // Removing North from possibilities
            if (location.Y <= 40)
            {
                mask &= (Direction.East | Direction.West | Direction.South);
            }

            // Removing South from possibilities
            if (location.Y >= _cageFormBounds.Height - panelHeight - animalImage.ActualHeight - 40)
            {
                mask &= (Direction.East | Direction.North | Direction.West);
            }

            // Returns the ready mask with the available Directions
            return mask;
        }

        /// <summary>
        /// Returns a random Direction that is validated by the given mask.
        /// </summary>
        /// <returns></returns>
        public void ChangeDirection()
        {
            Point location = animalImage.Location;
            Direction mask = GenerateMask(location);
            Direction dir;
            do
            {
                int randomDirection = rnd.Next(18); // Gets random number, 8 base ones + 10 for idling (Increasing % for idling)
                switch (randomDirection) // Assigning direction
                {
                    case 0:
                        dir = Direction.North;
                        break;
                    case 1:
                        dir = Direction.North | Direction.East;
                        break;
                    case 2:
                        dir = Direction.East;
                        break;
                    case 3:
                        dir = Direction.East | Direction.South;
                        break;
                    case 4:
                        dir = Direction.South;
                        break;
                    case 5:
                        dir = Direction.South | Direction.West;
                        break;
                    case 6:
                        dir = Direction.West;
                        break;
                    case 7:
                        dir = Direction.West | Direction.North;
                        break;
                    default:
                        dir = 0;
                        break;
                }
            } while ((dir != 0) && (dir & mask) == 0);

            // Returns the validated Direction
            direction = dir & mask;
        }

        /// <summary>
        /// Moves animalImage using its location.
        /// </summary>
        public virtual void Move()
        {
            int X = animalImage.Location.X;
            int Y = animalImage.Location.Y;
            // Using bitwise AND to move the location of the animalImage accordingly to its direction.
            if ((direction & Direction.North) == Direction.North)
                animalImage.Location = new Point(X, Y-- - walkingSpeed);
            if ((direction & Direction.East) == Direction.East)
                animalImage.Location = new Point(X++ + walkingSpeed, Y);
            if ((direction & Direction.South) == Direction.South)
                animalImage.Location = new Point(X, Y++ + walkingSpeed);
            if ((direction & Direction.West) == Direction.West)
                animalImage.Location = new Point(X-- - walkingSpeed, Y);
        }

        /// <summary>
        /// Checking if the animalImage is not in the form.
        /// </summary>
        public void CheckForOutOfBounds()
        {
            var location = animalImage.Location;
            if (location.X <= _cageFormBounds.Width / 10 + 9)
            {
                direction = Direction.East;
                hasBeenCloseToOutOfBounds = true;
            }
            if (location.X >= _cageFormBounds.Width - animalImage.BodyWidth - 10)
            {
                direction = Direction.West;
                hasBeenCloseToOutOfBounds = true;
            }
            if (location.Y <= 40)
            {
                direction = Direction.South;
                hasBeenCloseToOutOfBounds = true;
            }
            if (location.Y >= _cageFormBounds.Height - panelHeight - animalImage.ActualHeight - 40)
            {
                direction = Direction.North;
                hasBeenCloseToOutOfBounds = true;
            }
        }

        /// <summary>
        /// Returns the comfort of the animal.
        /// </summary>
        /// <returns></returns>
        public AnimalComfort GetComfort()
        {
            return comfort;
        }

        /// <summary>
        /// Lowers the animal's comfort.
        /// </summary>
        public void LowerComfort()
        {
            if ((int)comfort > 0)
                comfort--;
        }

        /// <summary>
        /// Increases the animal's comfort.
        /// </summary>
        public void IncreaseComfort()
        {
            if ((int)comfort < 4)
                comfort++;
        }
    }
}
