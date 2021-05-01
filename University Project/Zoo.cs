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
    public class Zoo
    {
        private List<AnimalCage> _cages = new List<AnimalCage>();
        public int Day { get; set; }
        public int Hour { get; set; }
        public int Minute { get; set; }
        public int Money { get; set; }
        public Graphics Graphics { get; set; }

        /// <summary>
        /// Adds an AnimalCage to the Zoo.
        /// </summary>
        /// <param name="ac"></param>
        public void AddCage(Rectangle formBounds)
        {
            CagePosition cagePos = CagePosition.Left;
            // Checks if one of the cages is there, if it's there, put the other one as "needed".
            foreach(var cage in _cages)
            {
                if (cage.cageImage.cagePos == CagePosition.Left)
                    cagePos = CagePosition.Right;
                else if (cage.cageImage.cagePos == CagePosition.Right)
                    cagePos = CagePosition.Left;
            }
            _cages.Add(new AnimalCage(Graphics, formBounds, cagePos));
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

        /// <summary>
        /// Returns the cages.
        /// </summary>
        /// <returns></returns>
        public List<AnimalCage> GetCages()
        {
            return _cages;
        }
    }
}
