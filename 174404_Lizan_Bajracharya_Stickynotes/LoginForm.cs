using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _174404_Lizan_Bajracharya_Stickynotes
{
    public partial class LoginForm : Form
    {
        
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            LoginBLL login = new LoginBLL();
            login._Username = username;
            login._Password = password;

            UsernameBLL._Username = txtUsername.Text;
            bool isValidUser = login.checkUser();

            if(isValidUser)
            {
                MessageBox.Show("Welcome");
                this.Hide();
                Pie_Chart pie = new Pie_Chart();
                pie.ShowDialog();
                
                this.Hide();
                DashBoard dashboard = new DashBoard();
                dashboard.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
                txtPassword.Text = "";
                txtUsername.Focus();
                txtUsername.SelectAll();
            }

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginBLL login = new LoginBLL();
            int usercheck = login.usercheck();
            if(usercheck==0)
            {
                UserEntry user = new UserEntry();
                user.ShowDialog();
            }
            else
            {
                NormalUserEntry userentry = new NormalUserEntry();
                userentry.ShowDialog();
            }
            
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forgotpassword forgotpassword = new Forgotpassword();
            forgotpassword.ShowDialog();
        }
    }
}
