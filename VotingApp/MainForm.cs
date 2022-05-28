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
    public partial class mainForm : Form
    {
        public mainForm()
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
            Form _question=new QuestionForm();
            _question.Show();
            this.Visible=false;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void onCreateBtn_Click(object sender, EventArgs e)
        {
            Form _create = new CreatePoolForm();
            _create.Show();
            this.Visible=false;

        }
    }
}
