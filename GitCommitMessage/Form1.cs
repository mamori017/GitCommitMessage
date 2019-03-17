using System;
using System.Windows.Forms;

namespace GitCommitMessage
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Form1
        /// </summary>
        public Form1()
        {
            // Initialize
            InitializeComponent();
        }

        /// <summary>
        /// CloseToolStripMenuItem_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notifyIcon1.Visible = false;
            Application.Exit();
        }

        /// <summary>
        /// Menu_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Menu_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem obj = (ToolStripMenuItem)sender;
            Clipboard.SetText("[" + obj.Name + "]要約\n\n変更理由\n");
        }
    }
}
