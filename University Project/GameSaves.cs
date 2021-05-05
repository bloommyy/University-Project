using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Project
{
    /// <summary>
    /// Class for game saves.
    /// </summary>
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

        /// <summary>
        /// Adds a save.
        /// </summary>
        /// <param name="zoo"></param>
        public void AddGame(Zoo zoo)
        {
            gameSaves.Add(zoo);
        }

        /// <summary>
        /// Removes a save.
        /// </summary>
        /// <param name="zoo"></param>
        public void DeleteGame(Zoo zoo)
        {
            gameSaves.Remove(zoo);
        }

        /// <summary>
        /// Gets saves.
        /// </summary>
        /// <returns></returns>
        public List<Zoo> GetZoos()
        {
            return gameSaves;
        }
    }
}
