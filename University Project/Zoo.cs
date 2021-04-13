﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Project
{
    /// <summary>
    /// Gamesave, holding all the data for one zoo.
    /// </summary>
    class Zoo
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
        /// Saves the game.
        /// </summary>
        public void SaveGame()
        {
            // Saves information about game in a file using Serialization - will be implemented in Phase 3.
        }
        
        /// <summary>
        /// Ends the day and starts a new one.
        /// </summary>
        public void NextDay()
        {
            Day++;
            Hour = 9;
            Minute = 0;
            Money += 300;
        }
    }
}
