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
    public partial class NormalUserEntry : Form
    {
        public NormalUserEntry()
        {
            InitializeComponent();
        }
        UserBLL user = new UserBLL();
        private void DataClear()
        {
            txtFirst.Text = txtLast.Text = txtAddrss.Text = txtEmail.Text = txtPassword.Text = txtPhone.Text = txtUsername.Text = "";
            rdoMale.Checked = false;
            rdoFemale.Checked = false;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string Firstname = txtFirst.Text;
            string Lastname = txtLast.Text;
            string Address = txtAddrss.Text;
            string Email = txtEmail.Text;
            string phone = txtPhone.Text;
            string Username = txtUsername.Text;
            string Password = txtPassword.Text;
            string Gender;

            user._FirstName = Firstname;
            user._LastName = Lastname;
            user._Address = Address;
            user._Email = Email;
            user._Password = Password;
            user._PhoneNo = phone;
            user._Username = Username;

            if (Firstname == "")
            {
                MessageBox.Show("Please input First name");
            }
            else if (Lastname == "")
            {
                MessageBox.Show("Please input Last name");
            }
            else if (Address == "")
            {
                MessageBox.Show("Please input Address");
            }
            else if (Email == "")
            {
                MessageBox.Show("Please input Email");
            }
            else if (phone == "")
            {
                MessageBox.Show("Please input Phone number");
            }
            else if (Username == "")
            {
                MessageBox.Show("Please input Username");
            }
            else if (Password == "")
            {
                MessageBox.Show("Please input Password");
            }

            else
            {
                if (rdoMale.Checked == true)
                {
                    Gender = "M";
                }
                else if (rdoFemale.Checked == true)
                {
                    Gender = "F";
                }
                else
                {
                    MessageBox.Show("Please select gender");
                    return;
                }
                user._Gender = Gender;

                DataTable dt = user.UsernameEntry();
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Username already exist");
                    txtUsername.Focus();
                }
                else
                {
                    user.Addnormal();
                    MessageBox.Show("Inserted");
                    DataClear();
                }

                
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                txtPassword.PasswordChar = new char();
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text != "")
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }

        }

        private void NormalUserEntry_Load(object sender, EventArgs e)
        {
           
                button1.Enabled = false;
           

        }
    }
}
