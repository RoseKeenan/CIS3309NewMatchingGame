using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MatchingGame.Classes;

namespace MatchingGame.Forms
{
    public partial class frmWelcome : Form
    {

        public frmWelcome()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(txtEnterName.Text))
            {
                PlayerClass.setName(txtEnterName.Text);
                frmGame GameForm = new frmGame();
                GameForm.ShowDialog();
                this.Visible = false;
                this.Close();
            }

            else
            {
                MessageBox.Show("Please enter a name!");
                txtEnterName.Focus();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmWelcome_Load(object sender, EventArgs e)
        {
            txtEnterName.Focus();
        }
    }
}
