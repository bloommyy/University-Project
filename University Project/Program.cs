using Preslav.ZooGame.ClassLibraryZoo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Preslav.ZooGame
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            IFormatter formatter = new BinaryFormatter();
            StartMenuForm smf = new StartMenuForm();
            if (File.Exists("gamesaves.db"))
                using (Stream stream = new FileStream("gamesaves.db", FileMode.Open, FileAccess.Read))
                {
                    var gameSavesArray = formatter.Deserialize(stream);
                    smf.gameSaves.SetZoos((List<Zoo>)gameSavesArray);
                }
            Application.Run(smf);
        }
    }
}
