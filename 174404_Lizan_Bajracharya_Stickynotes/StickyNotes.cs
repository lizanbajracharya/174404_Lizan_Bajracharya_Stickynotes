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
    public partial class StickyNotes : Form
    {
       
        public StickyNotes()
        {
            
            InitializeComponent();
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            DashBoard dashboard = new DashBoard();
            dashboard.ShowDialog();
        }

        StickyNotesBLL stickynotes = new StickyNotesBLL();
        private void btnAdd_Click(object sender, EventArgs e)
        {
                string title = txtTitle.Text;
                string category = cmbCategory.SelectedValue.ToString();
                string content = txtContent.Text;



                stickynotes._Title = title;
                stickynotes._Category = category;
                stickynotes._Content = content;

                if (title == "")
                {
                    MessageBox.Show("Please give a title");
                    txtTitle.Focus();
                }
                else if (category == "")
                {
                    MessageBox.Show("Please Select a Category");
                }
                else
                {
                    if (txtTitle.TextLength > 10)
                    {
                        MessageBox.Show("Title Character exceeded");
                        txtTitle.Focus();
                    }
                    else
                    {
                        stickynotes.Add();
                        MessageBox.Show("New Note Added");
                        txtTitle.Text = txtContent.Text = "";
                    }
                }
        }
        Dbconnection conn = new Dbconnection();
        private void StickyNotes_Load(object sender, EventArgs e)
        {
            txtContent.Enabled = false;
            txtTitle.Enabled = false;
            btnAdd.Enabled = false;
            cmbCategory.Enabled = false;
           
            DataTable dt = stickynotes.StickyLoad();
            cmbCategory.DataSource = dt;
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryID";
        }

        private void StickyNotes_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            DashBoard dashboard = new DashBoard();
            dashboard.ShowDialog();
            this.Close();
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
            if(txtTitle.TextLength>=10)
            {
                lblText.Visible = true;
                lblText.Text ="! Must be 10 character long.";
            }
            else
            {
                lblText.Visible = false;
            }
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            this.Hide();
            Category category = new Category();
            category.ShowDialog();
            this.Close();
        }

        private void cmbCategory_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cmbCategory.Text!="")
            {
                txtTitle.Enabled = true;
                txtContent.Enabled = true;
                btnAdd.Enabled = true;
                cmbCategory.Enabled = true;
            }
        }
    }
}
