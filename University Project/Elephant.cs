using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Project
{
    /// <summary>
    /// Class Elephant that inherits class Animal.
    /// </summary>
    class Elephant : Animal
    {
        /// <summary>
        /// Moves animalImage using its location.
        /// </summary>
        public override void Move()
        {
            base.Move();
        }

        /// <summary>
        /// Constructor for Elephant.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="weight"></param>
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
