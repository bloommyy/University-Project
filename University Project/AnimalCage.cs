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

    public class AnimalCage
    {
        private List<Animal> _animals = new List<Animal>();
        private bool isTaskDone;
        public FodderState FodderState;

        public void AddAnimal(Animal animal)
        {
            _animals.Add(animal);
        }

        public void RemoveAnimal(Animal animal)
        {
            _animals.Remove(animal);
        }
    }
}
