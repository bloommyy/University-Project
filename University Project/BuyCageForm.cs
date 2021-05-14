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
    public partial class BuyCageForm : Form
    {
        /// <summary>
        /// User's choice from the combo box.
        /// </summary>
        public string choice;

        /// <summary>
        /// Form for selecting the type of a cage the user wants to buy.
        /// </summary>
        public BuyCageForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sets the user's choice and closes the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuy_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
                return;

            choice = comboBox1.SelectedItem.ToString();
            DialogResult = DialogResult.OK;
        }
    }
}
