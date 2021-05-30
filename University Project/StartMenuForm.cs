using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University_Project
{
    /// <summary>
    /// Form for choosing which save to load or create a new one.
    /// </summary>
    public partial class StartMenuForm : Form
    {
        /// <summary>
        /// Object containing all the game saves.
        /// </summary>
        public GameSaves gameSaves = new GameSaves();

        /// <summary>
        /// Constructor for StartMenuForm.
        /// </summary>
        public StartMenuForm()
        {
            InitializeComponent();
            RefreshListBoxGames();
        }

        /// <summary>
        /// Adds a new gamesave to the list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCreateNewGame_Click(object sender, EventArgs e)
        {
            CreateGameForm cgf = new CreateGameForm();
            if(cgf.ShowDialog() == DialogResult.OK)
            {
                gameSaves.AddGame(new Zoo(cgf.Name, cgf.Date));
            }
            RefreshListBoxGames();
        }

        /// <summary>
        /// Loads chosen gamesave.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPlay_Click(object sender, EventArgs e)
        {
            if (listBoxGames.SelectedItem == null)
                return;

            MainForm mf = new MainForm
            {
                zoo = (Zoo)listBoxGames.SelectedItem
            };
            this.Hide();
            mf.FormClosed += (s, args) => {
                gameSaves.SaveGames((Zoo)listBoxGames.SelectedItem);
                this.Close(); 
            };
            mf.Show();
        }

        /// <summary>
        /// Deletes chosen gamesave.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxGames.SelectedItem == null)
                return;

            gameSaves.DeleteGame((Zoo)listBoxGames.SelectedItem);
            RefreshListBoxGames();
        }

        /// <summary>
        /// Refreshes the listBoxGames.
        /// </summary>
        private void RefreshListBoxGames()
        {
            listBoxGames.Items.Clear();
            foreach (var item in gameSaves.GetZoos())
            {
                listBoxGames.Items.Add(item);
            }
        }

        /// <summary>
        /// Opens CreateGameForm, so user can change the name of the save.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxGames_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxGames.SelectedItem == null)
                return;

            Zoo item = (Zoo)listBoxGames.SelectedItem;
            CreateGameForm cgf = new CreateGameForm();
            cgf.Name = item.Name;
            cgf.Date = item.Date;
            if(cgf.ShowDialog() == DialogResult.OK)
            {
                var save = gameSaves.GetZoos().Single(zoo => zoo == item);
                save.Name = cgf.Name;
                save.Date = cgf.Date;
            }
            RefreshListBoxGames();
        }

        private void StartMenuForm_Shown(object sender, EventArgs e)
        {
            RefreshListBoxGames();
        }
    }
}
