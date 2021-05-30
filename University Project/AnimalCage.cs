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
        /// <summary>
        /// Fodder is empty. Animal may run away.
        /// </summary>
        Empty = 0,

        /// <summary>
        /// Fodder is half ful.
        /// </summary>
        HalfFull = 1,

        /// <summary>
        /// Fodder is full.
        /// </summary>
        Full = 2
    }

    /// <summary>
    /// Enum for the type of animals in the cage.
    /// </summary>
    public enum CageType
    {
        /// <summary>
        /// Signifies the cage is for elephants.
        /// </summary>
        Elephant = 0,

        /// <summary>
        /// Signifies the cage is for penguins.
        /// </summary>
        Penguin = 1
    }

    /// <summary>
    /// Class AnimalCage, holding a list of objects from type Animal.
    /// </summary>
    [Serializable]
    public class AnimalCage
    {
        private List<Animal> _animals = new List<Animal>();

        /// <summary>
        /// Boolean showing if the daily task is done. If done - gives money, if not - reduces comfort.
        /// </summary>
        public bool isTaskDone;

        /// <summary>
        /// Shows the state of the fodder.
        /// </summary>
        public FodderState fodderState;

        /// <summary>
        /// The outlook of the cage in MainForm.
        /// </summary>
        public AnimalCageImage cageImage;

        /// <summary>
        /// Shows that type the cage is.
        /// </summary>
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
        /// <param name="ct">The type of the cage.</param>
        public AnimalCage(Graphics g, Rectangle formBounds, CagePosition cagePos, CageType ct)
        {
            cageImage = new AnimalCageImage(g, formBounds, cagePos);  
            isTaskDone = false;
            fodderState = FodderState.HalfFull;
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

        /// <summary>
        /// Increases the fodder.
        /// </summary>
        public void BuyFodder()
        {
            if ((int)fodderState < 2)
                ++fodderState;
        }
    }
}
