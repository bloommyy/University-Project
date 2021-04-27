using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Project
{
    public class GameSaves
    {
        private List<Zoo> gameSaves = new List<Zoo>();

        /// <summary>
        /// Saves the progress.
        /// </summary>
        public void SaveGames()
        {
            // Saves game by writing in a file using Serialization - 3rd Phase
        }

        public void AddGame(Zoo zoo)
        {
            gameSaves.Add(zoo);
        }

        public void DeleteGame(Zoo zoo)
        {
            gameSaves.Remove(zoo);
        }

        public List<Zoo> GetZoos()
        {
            return gameSaves;
        }
    }
}
