using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Project
{
    class Zoo
    {
        private List<AnimalCage> _cages = new List<AnimalCage>();
        public int Day { get; set; }
        public int Hour { get; set; }
        public int Minute { get; set; }
        public int Money { get; set; }

        public void AddCage(AnimalCage ac)
        {
            _cages.Add(ac);
        }

          

        public void RemoveCage(AnimalCage ac)
        {
            _cages.Remove(ac);
        }

        public void SaveGame()
        {
            // Saves information about game in a file using Serialization
        }
        
        public void NextDay()
        {
            Day++;
            Hour = 9;
            Minute = 0;
        }
    }
}
