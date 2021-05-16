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
    /// A form for naming the game save.
    /// </summary>
    public partial class CreateGameForm : Form
    {
        private string _name;
        private DateTime _dateTime;

        /// <summary>
        /// Contains the name of a gamesave.
        /// </summary>
        public new string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                textBoxName.Text = _name;
            }
        }

        /// <summary>
        /// Contains the date of a gamesave.
        /// </summary>
        public DateTime Date
        {
            get
            {
                return _dateTime;
            }
            set
            {
                _dateTime = value;
                labelDate.Text = _dateTime.ToString();
            }
        }

        /// <summary>
        /// Constructor for CreateGameForm.
        /// </summary>
        public CreateGameForm()
        {
            InitializeComponent();
            textBoxName.Text = "";
            Date = DateTime.Now;
        }

        /// <summary>
        /// Method that saves the data when buttonCreate is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Name = textBoxName.Text;
            DialogResult = DialogResult.OK;
        }
    }
}
