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
    public partial class Adminuserentry : Form
    {
        public Adminuserentry()
        {
            InitializeComponent();
        }

        UserBLL user = new UserBLL();

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
                if (btnSave.Text == "Save")
                {
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
                        DataDisplay();
                    }
                }
                else if (btnSave.Text == "Update")
                {
                    user.AdminUpdate();
                    MessageBox.Show("Updated");
                    DataClear();
                    DataDisplay();
                    btnSave.Text = "Save";
                }
            }

        }
        private void DataClear()
        {
            txtFirst.Text = txtLast.Text = txtAddrss.Text = txtEmail.Text = txtPassword.Text = txtPhone.Text = txtUsername.Text = "";
            rdoMale.Checked = false;
            rdoFemale.Checked = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Adminuserentry_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            DataDisplay();
        }
        private void DataDisplay()
        {
            DataTable dt = user.Userloadadmin();
            dgUser.DataSource = dt;
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

        private void dgUser_Click(object sender, EventArgs e)
        {
            
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

        private void dgUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgUser_Click_1(object sender, EventArgs e)
        {
            int columnIndex = dgUser.CurrentCell.ColumnIndex;
            int customerid = int.Parse(dgUser.CurrentRow.Cells["Uid"].Value.ToString());
            user._ID = customerid;
            if (dgUser.CurrentRow.Cells[columnIndex].Value.ToString() == "Edit")
            {
                DataTable dts = user.UserUpdateadmin();
                txtFirst.Text = dts.Rows[0][0].ToString();
                txtLast.Text = dts.Rows[0][1].ToString();
                txtAddrss.Text = dts.Rows[0][2].ToString();
                txtPhone.Text = dts.Rows[0][3].ToString();
                txtEmail.Text = dts.Rows[0][4].ToString();
                txtUsername.Text = dts.Rows[0][5].ToString();
                txtPassword.Text = dts.Rows[0][6].ToString();
                string Gender = dts.Rows[0][7].ToString();
                if (Gender == "M")
                {
                    rdoMale.Checked = true;
                }
                else if (Gender == "F")
                {
                    rdoFemale.Checked = true;
                }
                btnSave.Text = "Update";
            }
            else if (dgUser.CurrentRow.Cells[columnIndex].Value.ToString() == "Delete")
            {
                DialogResult confirmResult = MessageBox.Show("Are you sure to delete this item??", "Confirm Delete?", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    user.Delete();
                    DataTable dts = user.Userloadadmin();
                    dgUser.DataSource = dts;
                }
            }
        }
    }
}
