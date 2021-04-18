using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Project
{
    class GameSaves
    {
        private List<Zoo> gameSaves = new List<Zoo>();

        public void SaveGames()
        {
            // Saves game
        }

        public void AddGame(Zoo zoo)
        {
            gameSaves.Add(zoo);
        }

        public void DeleteGame(Zoo zoo)
        {
            gameSaves.Remove(zoo);
        }
    }
}
