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
    public partial class Forgotpassword : Form
    {
        public Forgotpassword()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (txtNewpassword.Text != "")
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }
        Forgorpasswordbll forgetpassword = new Forgorpasswordbll();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(txtUsername.Text=="")
            {
                txtNewpassword.Enabled = false;
                txtRetypenewpassword.Enabled = false;
            }
            DataTable dt = forgetpassword.Usernamecheck(txtUsername.Text);
            
            if(dt.Rows.Count>0)
            {
                txtNewpassword.Enabled = true;
                txtRetypenewpassword.Enabled = true;
            }
            else
            {
                txtNewpassword.Enabled = false;
                txtRetypenewpassword.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            forgetpassword._password = txtNewpassword.Text;
            if (txtRetypenewpassword.Text != txtNewpassword.Text)
            {
                MessageBox.Show("Password Doesnt match");
                txtRetypenewpassword.Text = "";
                txtRetypenewpassword.Focus();
                txtNewpassword.Text = txtRetypenewpassword.Text = txtUsername.Text = "";
            }
            else
            {
                forgetpassword.Changepassword(txtUsername.Text);
                MessageBox.Show("Password changed");
                txtNewpassword.Text = txtRetypenewpassword.Text = txtUsername.Text = "";
            }
            
            
        }

        private void txtRetypenewpassword_TextChanged(object sender, EventArgs e)
        {
            if (txtRetypenewpassword.Text != "")
            {
                button2.Enabled = true;
            }
            else
            {
                button2.Enabled = false;
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNewpassword.PasswordChar == '*')
            {
                txtNewpassword.PasswordChar = new char();
            }
            else
            {
                txtNewpassword.PasswordChar = '*';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtRetypenewpassword.PasswordChar == '*')
            {
                txtRetypenewpassword.PasswordChar = new char();
            }
            else
            {
                txtRetypenewpassword.PasswordChar = '*';
            }
        }

        private void Forgotpassword_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
        }
    }
}
