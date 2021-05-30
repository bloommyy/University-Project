using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University_Project
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
            if(File.Exists("gamesaves.db"))
                using (Stream stream = new FileStream("gamesaves.db", FileMode.Open, FileAccess.Read))
                {
                    var gameSavesArray = formatter.Deserialize(stream);
                    smf.gameSaves.SetZoos((List<Zoo>)gameSavesArray);
                }
            Application.Run(smf);
        }
    }
}
