using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Project
{
    class Elephant : Animal
    {
        public override void Move()
        {
            base.Move();
        }

        public Elephant(string name, int age, double weight)
        {
            base.Name = name;
            base.Age = age;
            base.Weight = weight;
            base.comfort = AnimalComfort.Neutral;
            base.walkingSpeed = 1;
            base.animalImage = new ElephantImage();
        }
    }
}
