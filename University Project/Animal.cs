using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University_Project
{
    /// <summary>
    /// Enum for the comfort of the animal.
    /// </summary>
    public enum AnimalComfort
    {
        Uncomfortable = 0,
        SlightlyUneasy = 1,
        Neutral = 2,
        Satisfied = 3,
        Comfortable = 4
    }

    /// <summary>
    /// Enum for the Direction the animal is going in.
    /// </summary>
    public enum Direction
    {
        North = 1,
        East = 2,
        South = 4,
        West = 8
    }

    /// <summary>
    /// This is the base class of Animal.
    /// </summary>
    public abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }

        protected AnimalComfort comfort;
        protected int walkingSpeed;
        protected AnimalImage animalImage;
        protected Direction direction;

        /// <summary>
        /// Method Eat that lowers the given FodderState by one, if Empty - it does nothing.
        /// </summary>
        /// <param name="fodder"></param>
        /// <returns>FodderState</returns>
        public FodderState Eat(FodderState fodder)
        {
            if(fodder > 0)
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
            if (location.X <= 15)
            {
                mask &= (Direction.East | Direction.North | Direction.South);
            }

            // Removing East from possibilities
            if (location.X >= 350) // right side of form - hard coded when Forms are added.
            {
                mask &= (Direction.West | Direction.North | Direction.South);
            }

            // Removing North from possibilities
            if (location.Y <= 15)
            {
                mask &= (Direction.East | Direction.West | Direction.South);
            }

            // Removing South from possibilities
            if (location.Y >= 350) // bottom side of form - hard coded when Forms are added.
            {
                mask &= (Direction.East | Direction.North | Direction.West);
            }

            // Returns the ready mask with the available Directions
            return mask;
        }

        /// <summary>
        /// Returns a random Direction that is validated by the given mask.
        /// </summary>
        /// <param name="location"></param>
        /// <returns>Direction</returns>
        public void ChangeDirection(Point location)
        {
            Direction mask = GenerateMask(location);
            Random rnd = new Random();
            int randomDirection = rnd.Next(18); // Gets random number, 8 base ones + 10 for idling (Increasing % for idling)
            Direction dir = new Direction();
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
            }

            if(dir != 0) // Checking if not idle 
                if((dir & mask) == 0) // Preventing idling if chosen a way                  
                    ChangeDirection(location); // (lowering chances of idling if we have generated a Direction but the it's invalid)

            // Returns the validated Direction
            direction = dir & mask; 
        }

        /// <summary>
        /// Moves animalImage using its location.
        /// </summary>
        public virtual void Move()
        {
            // Using bitwise AND on North only to check if Direction holds North
            if((direction & Direction.North) == Direction.North)
                animalImage.Location = new Point(animalImage.Location.X, animalImage.Location.Y - walkingSpeed);
            if ((direction & Direction.East) == Direction.East)
                animalImage.Location = new Point(animalImage.Location.X + walkingSpeed, animalImage.Location.Y);
            if ((direction & Direction.South) == Direction.South)
                animalImage.Location = new Point(animalImage.Location.X, animalImage.Location.Y - walkingSpeed);
            if ((direction & Direction.West) == Direction.West)
                animalImage.Location = new Point(animalImage.Location.X - walkingSpeed, animalImage.Location.Y);
        }
    }
}
