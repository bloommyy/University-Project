using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Preslav.ZooGame.ClassLibraryZoo
{

    /// <summary>
    /// Class for game saves.
    /// </summary>

    public class GameSaves
    {
        private List<Zoo> gameSaves = new List<Zoo>();
        private IFormatter formatter = new BinaryFormatter();

        /// <summary>
        /// Saves the progress.
        /// </summary>
        public void SaveGames(Zoo zooToSave = null)
        {
            var gameToSave = gameSaves.Where(z => z == zooToSave).SingleOrDefault();
            if (gameToSave != default)
                gameToSave.Date = DateTime.Now;

            using (Stream stream = new FileStream("gamesaves.db", FileMode.Create, FileAccess.Write))
            {
                formatter.Serialize(stream, gameSaves);
            }
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

        /// <summary>
        /// Sets the zoos/gamesaves.
        /// </summary>
        /// <param name="listOfZoos"></param>
        public void SetZoos(List<Zoo> listOfZoos)
        {
            gameSaves = listOfZoos;
        }
    }
}
