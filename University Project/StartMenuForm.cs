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

        private GameSaves gameSaves = new GameSaves();

        /// <summary>
        /// Constructor for StartMenuForm.
        /// </summary>
        public StartMenuForm()
        {
            InitializeComponent();
            // Deserialization - Added in 3rd Phase.
        }

        /// <summary>
        /// Adds a new gamesave to the list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCreateNewGame_Click(object sender, EventArgs e)
        {
            gameSaves.AddGame(new Zoo());
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
            mf.FormClosed += (s, args) => this.Close();
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
        /// Refreshes the listBoxGames
        /// </summary>
        private void RefreshListBoxGames()
        {
            listBoxGames.Items.Clear();
            foreach (var item in gameSaves.GetZoos())
            {
                listBoxGames.Items.Add(item);
            }
        }



    }
}
