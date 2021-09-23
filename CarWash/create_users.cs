using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarWash
{
    public partial class create_users : Form
    {
        public create_users()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkboxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxShowPass.Checked)
                txtPass.UseSystemPasswordChar = false;
            else
                txtPass.UseSystemPasswordChar = true;
        }

        private void checkBoxConfirmShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxConfirmShowPass.Checked)
                txtConfirmPass.UseSystemPasswordChar = false;
            else
                txtConfirmPass.UseSystemPasswordChar = true;
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Close_MouseHover(object sender, EventArgs e)
        {
            Close.BackColor = Color.Silver;
        }

        private void Close_MouseLeave(object sender, EventArgs e)
        {
            Close.BackColor = Color.Transparent;
        }

        private void Minimize_MouseHover(object sender, EventArgs e)
        {
            Minimize.BackColor = Color.Silver;
        }

        private void Minimize_MouseLeave(object sender, EventArgs e)
        {
            Minimize.BackColor = Color.Transparent;
        }

        private void btAddUser_Click(object sender, EventArgs e)
        {
            string pass = txtPass.Text;
            string cpass = txtConfirmPass.Text;
            string username = txtUsername.Text;
            string position = cbPosition.Text;
            if(pass!=cpass)
            {
                MessageBox.Show("Password doesn't match");
                return;
            }
            else
            {

            }
        }
    }
}
