using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Project
{
    public enum FodderState
    {
        Empty = 0,
        HalfFull = 1,
        Full = 2
    }

    /// <summary>
    /// Class AnimalCage, holding a list of objects from type Animal.
    /// </summary>
    public class AnimalCage
    {
        private List<Animal> _animals = new List<Animal>();
        private bool isTaskDone;
        public FodderState FodderState;

        /// <summary>
        /// Adds an Animal to the list of animals.
        /// </summary>
        /// <param name="animal"></param>
        public void AddAnimal(Animal animal)
        {
            _animals.Add(animal);
        }

        /// <summary>
        /// Removes an Animal from the list of animals.
        /// </summary>
        /// <param name="animal"></param>
        public void RemoveAnimal(Animal animal)
        {
            _animals.Remove(animal);
        }
    }
}
