using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace opt
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (textUserName.Text == "" && textPassword.Text == "")
                {
                    this.Hide();
                    Home mainForm = new Home();
                    mainForm.Show();
                }
                else
                {
                    MessageBox.Show("Enter correct Username and Password!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                return;
            }
            catch(Exception)
            {
                throw;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
