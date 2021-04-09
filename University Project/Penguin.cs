using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Project
{
    class Penguin : Animal
    {
        private readonly int swimmingSpeed = 2;
        private bool isSwimming;

        private bool CheckIfSwimming()
        {
            if (base.animalImage.Location.Y >= 150) // Checks if in water
                return true;
            else
                return false;
        }

        public override void Move()
        {
            isSwimming = CheckIfSwimming();
            if (!isSwimming)
                base.Move();
            else
            {
                Directions mask =base.GenerateMask(base.animalImage.Location);
                Directions dir = base.GenerateValidDirection(mask);
                if ((dir & Directions.North) == Directions.North)
                    animalImage.Location = new Point(animalImage.Location.X, animalImage.Location.Y - swimmingSpeed);
                if ((dir & Directions.East) == Directions.East)
                    animalImage.Location = new Point(animalImage.Location.X + swimmingSpeed, animalImage.Location.Y);
                if ((dir & Directions.South) == Directions.South)
                    animalImage.Location = new Point(animalImage.Location.X, animalImage.Location.Y - swimmingSpeed);
                if ((dir & Directions.West) == Directions.West)
                    animalImage.Location = new Point(animalImage.Location.X - swimmingSpeed, animalImage.Location.Y);
            }
        }

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
