using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace University_Project
{
    /// <summary>
    /// Enum for the state of the fodder.
    /// </summary>
    public enum FodderState
    {
        Empty = 0,
        HalfFull = 1,
        Full = 2
    }

    /// <summary>
    /// Enum for the type of animals in the cage.
    /// </summary>
    public enum CageType
    {
        Elephant = 0,
        Penguin = 1
    }

    /// <summary>
    /// Class AnimalCage, holding a list of objects from type Animal.
    /// </summary>
    public class AnimalCage
    {
        private List<Animal> _animals = new List<Animal>();
        public bool isTaskDone;
        public FodderState FodderState;
        public AnimalCageImage cageImage;
        public CageType cageType;

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

        /// <summary>
        /// Constructor for AnimalCage.
        /// </summary>
        /// <param name="g">Graphics used for drawing.</param>
        /// <param name="cagePos">Position of the cage.</param>
        /// <param name="formBounds">Bounds of the Form.</param>
        public AnimalCage(Graphics g, Rectangle formBounds, CagePosition cagePos, CageType ct)
        {
            cageImage = new AnimalCageImage(g, formBounds, cagePos);  
            isTaskDone = false;
            FodderState = FodderState.HalfFull;
            cageType = ct;
        }

        /// <summary>
        /// Returns the animals in the cage.
        /// </summary>
        /// <returns></returns>
        public List<Animal> GetAnimals()
        {
            return _animals;
        }
    }
}
