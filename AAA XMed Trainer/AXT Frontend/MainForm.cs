using AXT_Engine.Entities;
using System;
using System.Windows.Forms;

namespace AXT_Frontend
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        #region Menu Buttons
        #region File
        #region New Game..
        private void tutorialToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void easyRandomToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mediumRandomToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hardRandomToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void customToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomGameSetupForm.GetInstance.Show();
        }
        #endregion New Game..
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion File

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OptionsForm.GetInstance.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm.GetInstance.Show();
        }
        #endregion Menu Buttons
    }
}
