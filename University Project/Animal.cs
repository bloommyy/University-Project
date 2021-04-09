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

    public enum AnimalComfort
    {
        Uncomfortable = 0,
        SlightlyUneasy = 1,
        Neutral = 2,
        Satisfied = 3,
        Comfortable = 4
    }

    public enum Directions
    {
        North = 1,
        East = 2,
        South = 4,
        West = 8
    }

    public abstract class Animal
    {
        public string test;
        public string Name { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }

        protected AnimalComfort comfort;
        protected int walkingSpeed;
        protected AnimalImage animalImage;

        public FodderState Eat(FodderState fodder)
        {
            if(fodder > 0)
                return --fodder;

            return fodder;
        }

        protected Directions GenerateMask(Point location)
        {
            // Making a mask with all directions
            Directions mask = Directions.East | Directions.North | Directions.South | Directions.West;

            // Removing West from possibilities
            if (location.X <= 15)
            {
                mask &= (Directions.East | Directions.North | Directions.South);
            }

            // Removing East from possibilities
            if (location.X >= 350) // right side of form
            {
                mask &= (Directions.West | Directions.North | Directions.South);
            }

            // Removing North from possibilities
            if (location.Y <= 15)
            {
                mask &= (Directions.East | Directions.West | Directions.South);
            }

            // Removing South from possibilities
            if (location.Y >= 350) // bottom side of form
            {
                mask &= (Directions.East | Directions.North | Directions.West);
            }

            return mask;
        }

        protected Directions GenerateValidDirection(Directions mask)
        {
            Random rnd = new Random();
            int randomDirection = rnd.Next(18); // Gets random number, 8 base ones + 10 for idling
            Directions dir = new Directions();
            switch (randomDirection) // Assigning direction
            {
                case 0:
                    dir = Directions.North;
                    break;
                case 1:
                    dir = Directions.North | Directions.East;
                    break;
                case 2:
                    dir = Directions.East;
                    break;
                case 3:
                    dir = Directions.East | Directions.South;
                    break;
                case 4:
                    dir = Directions.South;
                    break;
                case 5:
                    dir = Directions.South | Directions.West;
                    break;
                case 6:
                    dir = Directions.West;
                    break;
                case 7:
                    dir = Directions.West | Directions.North;
                    break;
            }

            if(dir != 0) // Checking if not idle
                if((dir & mask) == 0) // Preventing idling if chosen a way
                    GenerateValidDirection(mask);

            return dir & mask;
        }

        public virtual void Move()
        {
            Directions mask = GenerateMask(animalImage.Location);
            Directions dir = GenerateValidDirection(mask);
            if((dir & Directions.North) == Directions.North)
                animalImage.Location = new Point(animalImage.Location.X, animalImage.Location.Y - walkingSpeed);
            if ((dir & Directions.East) == Directions.East)
                animalImage.Location = new Point(animalImage.Location.X + walkingSpeed, animalImage.Location.Y);
            if ((dir & Directions.South) == Directions.South)
                animalImage.Location = new Point(animalImage.Location.X, animalImage.Location.Y - walkingSpeed);
            if ((dir & Directions.West) == Directions.West)
                animalImage.Location = new Point(animalImage.Location.X - walkingSpeed, animalImage.Location.Y);
        }
    }
}
