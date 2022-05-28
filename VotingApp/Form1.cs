using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VotingApp
{
    public partial class defaultForm : Form
    {
        public defaultForm()
        {
            InitializeComponent();
        }

        private void onExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void onHelpBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Help Button Clicked");
        }

        private void usedCNPLabel_Click(object sender, EventArgs e)
        {
            usedCNPLabel.Text = "CNP-ul este folosit!";
        }

        private void onConfirmBtn_Click(object sender, EventArgs e)
        {
            usedCNPLabel.Text = "CNP-ul este folosit pentru a vota!";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
