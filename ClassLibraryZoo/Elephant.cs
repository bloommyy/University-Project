using System;

namespace Preslav.ZooGame.ClassLibraryZoo
{
    /// <summary>
    /// Class Elephant that inherits class Animal.
    /// </summary>
    [Serializable]
    public class Elephant : Animal
    {
        /// <summary>
        /// Moves animalImage using its location and direction.
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
