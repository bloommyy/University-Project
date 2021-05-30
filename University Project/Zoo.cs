using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University_Project
{
    /// <summary>
    /// Gamesave, holding all the data for one zoo.
    /// </summary>
    [Serializable]
    public class Zoo
    {
        private List<AnimalCage> _cages = new List<AnimalCage>();

        /// <summary>
        /// The name of the save/zoo.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The date of the save/zoo.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// The ingame day.
        /// </summary>
        public int Day { get; set; }

        /// <summary>
        /// The ingame hour.
        /// </summary>
        public int Hour { get; set; }

        /// <summary>
        /// The ingame minutes.
        /// </summary>
        public int Minute { get; set; }

        /// <summary>
        /// The ingame money.
        /// </summary>
        public int Money { get; set; }

        /// <summary>
        /// The graphics used to draw the cages.
        /// </summary>
        [NonSerialized]
        public Graphics Graphics;

        /// <summary>
        /// Adds an AnimalCage to the Zoo.
        /// </summary>
        /// <param name="formBounds">Bounds of the form.</param>
        /// <param name="ct">The type of the cage.</param>
        public void AddCage(Rectangle formBounds, CageType ct)
        {
            CagePosition availableCagePos = CagePosition.Left;
            // Checks if one of the cages is there, if it's there, put the other one as "available".
            foreach(var cage in _cages)
            {
                if (cage.cageImage.cagePos == CagePosition.Left)
                    availableCagePos = CagePosition.Right;
                else if (cage.cageImage.cagePos == CagePosition.Right)
                    availableCagePos = CagePosition.Left;
            }
            _cages.Add(new AnimalCage(Graphics, formBounds, availableCagePos, ct));
        }

        /// <summary>
        /// Removes an AnimalCage from the Zoo.
        /// </summary>
        /// <param name="ac"></param>
        public void RemoveCage(AnimalCage ac)
        {
            _cages.Remove(ac);
        }
        
        /// <summary>
        /// Ends the day and starts a new one.
        /// </summary>
        public void NextDay()
        {
            Day += 1;
            Hour = 9;
            Minute = 0;
            Money += 300;
            foreach (var cage in _cages)
            {
                foreach(var animal in cage.GetAnimals())
                {
                    Money += 200; // Gives 200 money for each animal.
                }

                if (!cage.isTaskDone)
                {
                    foreach(var animal in cage.GetAnimals())
                    {
                        animal.LowerComfort(); // If task isn't done, lower comfort on each animal in the cage.
                    }
                }
                else
                {
                    Money += 200;
                    cage.isTaskDone = false;
                } 
            }
        }

        /// <summary>
        /// Constructor for zoo.
        /// </summary>
        public Zoo(string name, DateTime date)
        {
            Name = name;
            Date = date;
            Day = 1;
            Hour = 9;
            Minute = 0;
            Money = 800;
        }

        /// <summary>
        /// Returns the cages.
        /// </summary>
        /// <returns></returns>
        public List<AnimalCage> GetCages()
        {
            return _cages;
        }

        /// <summary>
        /// Shows the name of the zoo(gamesave) and the date it was created.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Name} - {Date}";
        }

        /// <summary>
        /// Shows the amount of tasks left.
        /// </summary>
        /// <returns>A string of a number </returns>
        public string GetTasksLeft()
        {
            return "Will be added in 3rd phase - LINQ";
        }
    }
}
