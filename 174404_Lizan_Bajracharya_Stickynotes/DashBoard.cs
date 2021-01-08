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
    public partial class DashBoard : Form
    {
        
        public DashBoard()
        {
            
            InitializeComponent();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            AboutUs aboutus = new AboutUs();
            aboutus.ShowDialog();
            
        }
        

        
        Dbconnection conn = new Dbconnection();

        DashboardBLL dashboard = new DashboardBLL();
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        //stickynoted display
        public void LoadNotes(DataTable dt)
        {   
            int x, y;
            x = 10;
            y = 20;
                      
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int nid = int.Parse(dt.Rows[i][0].ToString());
                int uid = int.Parse(dt.Rows[i][1].ToString());
                string cid = dt.Rows[i][2].ToString();
                string date = dt.Rows[i][3].ToString();
                string title = dt.Rows[i][4].ToString();
                string content = dt.Rows[i][5].ToString();
                bool stickied = bool.Parse(dt.Rows[i][6].ToString());
                bool completed = bool.Parse(dt.Rows[i][7].ToString());

                //ChildPanel adding
                Panel ChildPanel = new Panel();
                ChildPanel.Location = new Point(x, y);
                ChildPanel.Size = new Size(300, 300);
                ChildPanel.BackColor = Color.LightGreen;
                
                
                Label lblNoteid = new Label();
                lblNoteid.Text = nid.ToString();
                lblNoteid.Name = "lblNoteId";
                lblNoteid.Visible = false;
                ChildPanel.Controls.Add(lblNoteid);

                Label lblTitle = new Label();
                lblTitle.Text = "Title";
                lblTitle.Location = new Point(10, 10);
                lblTitle.Font = new Font("Segoe Marker", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                ChildPanel.Controls.Add(lblTitle);

                Label txtTitle = new Label();
                txtTitle.Name = "lblTitle";
                txtTitle.Text = title;
                txtTitle.Location = new Point(150, 10);
                txtTitle.Font= new Font("Segoe Marker", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                ChildPanel.Controls.Add(txtTitle);

                Label lblCategory = new Label();
                lblCategory.Text = "Category";
                lblCategory.Location = new Point(10, 35);
                lblCategory.Font= new Font("Segoe Marker", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                ChildPanel.Controls.Add(lblCategory);

                ComboBox txtCategory = new ComboBox();
                txtCategory.Text = cid;             
                txtCategory.Location = new Point(150, 35);
                txtCategory.DropDownStyle = ComboBoxStyle.DropDown;
                txtCategory.Font= new Font("Segoe Marker", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                ChildPanel.Controls.Add(txtCategory);

                Label lblContent = new Label();
                lblContent.Text = "Content";
                lblContent.Location = new Point(10, 65);
                lblContent.Font= new Font("Segoe Marker", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                ChildPanel.Controls.Add(lblContent);

                Label lblDate = new Label();
                lblDate.Text = date.ToString();
                lblDate.Location = new Point(150, 65);
                lblDate.Font = new Font("Segoe Marker", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                ChildPanel.Controls.Add(lblDate);

                TextBox txtContent = new TextBox();
                txtContent.Name = "txtContent";
                txtContent.Text = content;
                txtContent.Multiline = true;
                txtContent.Location = new Point(10, 90);
                txtContent.Size = new Size(200, 100);
                txtContent.ScrollBars = ScrollBars.Vertical;
                txtContent.Font= new Font("Segoe Marker", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                txtContent.TextChanged += (s, a) =>
                  {
                      dashboard.Update(txtContent.Text, nid);
                  };
                ChildPanel.Controls.Add(txtContent);

              /*  Button btnSave = new Button();
                btnSave.Name = "btnSave";
                btnSave.Text = "Save";
                btnSave.Location = new Point(10, 200);
                btnSave.Click += (s, a) =>
                {
                    
                    MessageBox.Show("Updated");
                };
                ChildPanel.Controls.Add(btnSave);*/

                Button btnDelete = new Button();
                btnDelete.Name = "btnDelete";
                btnDelete.Text = "Delete";
                btnDelete.Location = new Point(10, 225);
                btnDelete.Font= new Font("Segoe Marker", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btnDelete.Click += (s, a) =>
                {
                    DialogResult confirmResult = MessageBox.Show("Are you sure to delete this item??", "Confirm Delete?", MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        dashboard.DeleteNote(nid);
                        panel1.Controls.Clear();
                        LoadNotes(dashboard.NoteDetail());
                    }
                };
                ChildPanel.Controls.Add(btnDelete);

                CheckBox chkCompleted = new CheckBox();
                chkCompleted.Name = "chkCompleted";
                chkCompleted.Text = "Completed";
                chkCompleted.Location = new Point(220, 230);
                chkCompleted.Font= new Font("Segoe Marker", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                if (completed==true)
                {
                    chkCompleted.Checked = true;
                    txtContent.Enabled = false;
                    txtCategory.Enabled = false;
                }
                else
                {
                    txtContent.Enabled = true;
                    txtCategory.Enabled = true;
                }
                chkCompleted.CheckedChanged += (s, a) =>
                  {
                      int noteid = int.Parse(lblNoteid.Text);
                      bool isComplete = false;
                      if (chkCompleted.Checked)
                      {
                          isComplete = true;
                      }
                      dashboard.UpdateCompletedCheckbox(noteid, isComplete);

                      //refresh
                      panel1.Controls.Clear();
                      LoadNotes(dashboard.NoteDetail());
                  };
              
                ChildPanel.Controls.Add(chkCompleted);

                CheckBox chkStickied = new CheckBox();
                chkStickied.Name = "chkStickied";
                chkStickied.Text = "Stickied";
                chkStickied.Location = new Point(220, 250);
                chkStickied.Font= new Font("Segoe Marker", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                if (stickied==true)
                {
                    chkStickied.Checked = true;
                }

                chkStickied.CheckedChanged += (s, a) =>
                  {
                      int noteid = int.Parse(lblNoteid.Text);
                      bool isSticky = false;
                      if(chkStickied.Checked)
                      {
                          isSticky = true;
                      }
                      dashboard.UpdateStickiedCheckbox(noteid, isSticky);

                      //refresh
                      panel1.Controls.Clear();
                      LoadNotes(dashboard.Noteload());
                  };

                ChildPanel.Controls.Add(chkStickied);

                panel1.Controls.Add(ChildPanel);
                x = x + ChildPanel.Width + 30;
                if (x > panel1.Width - 300)
                {
                    x = 10;
                    y = y + ChildPanel.Height + 30;
                }
            }
        }
        private void pieChartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Pie_Chart piechart = new Pie_Chart();
            piechart.ShowDialog();
            
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.ShowDialog();
            this.Close();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            txtSearch.Enabled = false;
            dtmDate.Enabled = false;
            DataTable dataTable = dashboard.StartupLoad();
            LoadNotes(dataTable);
            DataTable dt = dashboard.usertype();
            lblUsername.Text = UsernameBLL._Username;
            lblDate.Text = DateTime.Now.ToString();
            if(dt.Rows[0][0].ToString()=="1")
            {
                tsmUser.Visible = true;
            }
            else if(dt.Rows[0][0].ToString()=="2")
            {
                admUpdate.Visible = true;
            }
           
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void byTitleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Category category = new Category();
            category.ShowDialog();
            
        }

        private void newNotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            StickyNotes sticky = new StickyNotes();
            sticky.ShowDialog();
           
        }

        private void completedNotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            LoadNotes(dashboard.CompletedNotes());
        }

        private void incompleteNotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            LoadNotes(dashboard.NotCompleteNotes());
        }

        private void showAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            LoadNotes(dashboard.Loadall());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void rdoTitle_Click(object sender, EventArgs e)
        {
            
        }

        private void rdoDate_Click(object sender, EventArgs e)
        {
           
        }

        private void tsmUser_Click(object sender, EventArgs e)
        {
            UserEntry userentry = new UserEntry();
            userentry.ShowDialog();
        }

        private void rdoTitle_Click_1(object sender, EventArgs e)
        {
            txtSearch.Enabled = true;
            dtmDate.Enabled = false;
        }

        private void rdoDate_CheckedChanged(object sender, EventArgs e)
        {
            dtmDate.Enabled = true;
            txtSearch.Enabled = false;
        }
        
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (rdoTitle.Checked == true)
            {
                DataTable dt = dashboard.Titleload(txtSearch.Text);
                
                    if (dt.Rows.Count > 0)
                    {
                        panel1.Controls.Clear();
                        LoadNotes(dt);
                    }
                    else
                    {
                        MessageBox.Show("No Sticky Notes with that title");
                        txtSearch.Focus();
                    }
                
            }
            else if (rdoDate.Checked == true)
            {
                DataTable dt = dashboard.DateLoad(dtmDate.Text);
                if (dt.Rows.Count > 0)
                {
                    panel1.Controls.Clear();
                    LoadNotes(dt);
                }
                else
                {
                    MessageBox.Show("No notes in that date");
                    dtmDate.Focus();
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblUsername_Click_1(object sender, EventArgs e)
        {

        }

        private void admUpdate_Click(object sender, EventArgs e)
        {
            Adminuserentry adminentry = new Adminuserentry();
            adminentry.ShowDialog();
        }

        private void DashBoard_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.ShowDialog();
            this.Close();
        }
    }
}
