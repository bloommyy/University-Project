using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Project
{
    /// <summary>
    /// Gamesave, holding all the data for one zoo.
    /// </summary>
    public class Zoo
    {
        private List<AnimalCage> _cages = new List<AnimalCage>();
        public int Day { get; set; }
        public int Hour { get; set; }
        public int Minute { get; set; }
        public int Money { get; set; }

        /// <summary>
        /// Adds an AnimalCage to the Zoo.
        /// </summary>
        /// <param name="ac"></param>
        public void AddCage(AnimalCage ac)
        {
            _cages.Add(ac);
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
        }

        /// <summary>
        /// Constructor for zoo.
        /// </summary>
        public Zoo()
        {
            Day = 0;
            Hour = 9;
            Minute = 0;
            Money = 800;
        }

         void DrawZoo()
        {

        }
    }
}
