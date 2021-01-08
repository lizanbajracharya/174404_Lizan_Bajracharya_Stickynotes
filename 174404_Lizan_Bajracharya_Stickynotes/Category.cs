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
    public partial class Category : Form
    {
       
        public Category()
        {
           
            InitializeComponent();
        }

        CategoryBLL category = new CategoryBLL();
        Dbconnection conn = new Dbconnection();
        private void button1_Click(object sender, EventArgs e)
        {
            string Cateogoryname = txtCategory.Text;
            category._Category = Cateogoryname;
            if (btnSave.Text == "Save")
            {                
                category.CategoryEntry();
                MessageBox.Show("New Category Added");
                cleardata();
                Data();
            }
            else if (btnSave.Text == "Update")
            {
                category.UpdateCategory();
                MessageBox.Show("Category Updated");
                Data();
            }
        }

        private void cleardata()
        {
            txtCategory.Text = "";
        }

        private void Data()
        {
            DataTable dt = category.CategoryLoad();
            dgCategory.DataSource = dt;
        }

        private void Category_Load(object sender, EventArgs e)
        {
            Data();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            DashBoard dashboard = new DashBoard();
            dashboard.BringToFront();
            
        }

        private void dgCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgCategory_Click(object sender, EventArgs e)
        {
            int columnIndex = dgCategory.CurrentCell.ColumnIndex;
            int Categoryid = int.Parse(dgCategory.CurrentRow.Cells["Cid"].Value.ToString());
            
            category._ID = Categoryid;
            
            if (dgCategory.CurrentRow.Cells[columnIndex].Value.ToString() == "Edit")
            {
                DataTable dt=category.DelCategory();
                txtCategory.Text = dt.Rows[0][1].ToString();
                btnSave.Text = "Update";
            }
            else if (dgCategory.CurrentRow.Cells[columnIndex].Value.ToString() == "Delete")
            {
                DialogResult confirmResult = MessageBox.Show("Are you sure to delete this item??", "Confirm Delete?", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    category.DeleteCategory();
                    DataTable dt = category.Delcat();
                    dgCategory.DataSource = dt;
                }
            }
        }

        private void Category_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            DashBoard dashboard = new DashBoard();
            dashboard.BringToFront();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            StickyNotes sticky = new StickyNotes();
            sticky.ShowDialog();
            this.Close();
        }
    }
}
