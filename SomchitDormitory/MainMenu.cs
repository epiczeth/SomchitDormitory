using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SomchitDormitory
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var renter = new Renters();
            renter.MdiParent = this;
            renter.Show();
        }
    }
}
