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
    public partial class Pie_Chart : Form
    {
        
        public Pie_Chart()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Todaychart()
        {
            DateTime todayDate = DateTime.Now;
           
            DataTable dt = piechart.NoteCounttodaydate(todayDate);
            DataTable dts = piechart.NoteCounttodaydate2(todayDate);
            float x, y;
            float xx,yy;
            x = float.Parse(dt.Rows[0][0].ToString());
            y = float.Parse(dts.Rows[0][0].ToString());
            if (x <= 0)
            {
                xx = 0;
            }
            else
            {
                xx = ((x / (x + y)) * 100);
            }
            if (y <= 0)
            {
                yy = 0;
            }
            else
            {
                yy = ((y / (x + y)) * 100);
            }
            bool isData = true;
            if (x > 0 && y > 0)
            {
                chart1.Series["CurrentDate"].Points.AddXY("Completed", x);
                chart1.Series["CurrentDate"].Points.AddXY("Incompleted", y);
            }

            else if (x > 0 && y < 1)
            {
                chart1.Series["CurrentDate"].Points.AddXY("Completed", x);
            }

            else if (x <= 1 && y > 0)
            {
                chart1.Series["CurrentDate"].Points.AddXY("Incompleted", y);
            }

            else
            {
                chart1.Series["CurrentDate"].Points.AddXY("No data", 0);
                isData = false;
            }

            if (isData)
            {
                lblCompleted.Text = "Completed :" + String.Format("{0:0.00}", xx) + "%";
                lblIncompleted.Text = "Incompleted : " + String.Format("{0:0.00}", yy) + "%";
                chart1.Titles.Add("Status");
            }

            else
            {
                lblCompleted.Text = "";
                lblIncompleted.Text = "";
                chart1.Titles.Add("No data to evaluate");
            }
        }

        private void WeekChart()
        {
            string todayDate = DateTime.Now.AddDays(-7).ToString();
            string nowdate = DateTime.Now.ToString();
            DataTable dt = piechart.NoteCountweekdate(nowdate,todayDate);
            DataTable dts = piechart.NoteCountweekdate2(nowdate,todayDate);
            float x, y,xx,yy;
            x = float.Parse(dt.Rows[0][0].ToString());
            y = float.Parse(dts.Rows[0][0].ToString());
            if (x <= 0)
            {
                xx = 0;
            }
            else
            {
                xx = ((x / (x + y)) * 100);
            }
            if (y <= 0)
            {
                yy = 0;
            }
            else
            {
                yy = ((y / (x + y)) * 100);
            }
            bool isData = true;
            if (x > 0 && y > 0)
            {
                chart3.Series["OneWeek"].Points.AddXY("Completed", x);
                chart3.Series["OneWeek"].Points.AddXY("Incompleted", y);
            }

            else if (x > 0 && y < 1)
            {
                chart3.Series["OneWeek"].Points.AddXY("Completed", x);
            }

            else if (x < 1 && y > 0)
            {
                chart3.Series["OneWeek"].Points.AddXY("Incompleted", y);
            }

            else
            {
                chart3.Series["OneWeek"].Points.AddXY("No data", 0);
                isData = false;
            }

            if (isData)
            {
                lblComplete.Text = "Completed :" + String.Format("{0:0.00}", xx) + "%";
                lblIncomplete.Text = "Incompleted : " + String.Format("{0:0.00}", yy) + "%";
                chart3.Titles.Add("Status");
            }

            else
            {
                lblComplete.Text = "";
                lblIncomplete.Text = "";
                chart3.Titles.Add("No data to evaluate");
            }
        }

        private void MonthChart()
        {
            string todayDate = DateTime.Now.AddDays(-30).ToString();
            string nowdate = DateTime.Now.ToString();
            
            DataTable dt = piechart.NoteCountmonthdate(nowdate,todayDate);
            DataTable dts = piechart.NoteCountmonthdate2(nowdate,todayDate);
            float x, y,xx,yy;
            x = float.Parse(dt.Rows[0][0].ToString());
            y = float.Parse(dts.Rows[0][0].ToString());
            if (x <= 0)
            {
                xx = 0;
            }
            else
            {
                xx = ((x / (x + y)) * 100);
            }
            if (y <= 0)
            {
                yy = 0;
            }
            else
            {
                yy = ((y / (x + y)) * 100);
            }
            bool isData = true;
            if (x > 0 && y > 0)
            {
                chart2.Series["OneMonth"].Points.AddXY("Completed", x);
                chart2.Series["OneMonth"].Points.AddXY("Incompleted", y);
            }

            else if (x > 0 && y < 1)
            {
                chart2.Series["OneMonth"].Points.AddXY("Completed", x);
            }

            else if (x < 1 && y > 0)
            {
                chart2.Series["OneMonth"].Points.AddXY("Incompleted", y);
            }

            else
            {
                chart2.Series["OneMonth"].Points.AddXY("No data", 0);
                isData = false;
            }

            if (isData)
            {
                lblComp.Text = "Completed :" + String.Format("{0:0.00}", xx) + "%";
                lblIncom.Text = "Incompleted : " + String.Format("{0:0.00}", yy) + "%";
                chart2.Titles.Add("Status");
            }

            else
            {
                lblComp.Text = "";
                lblIncom.Text = "";
                chart2.Titles.Add("No data to evaluate");
            }
        }

        private void Yearchart()
        {
            string todayDate = DateTime.Now.AddYears(-1).ToString();
            string nowdate = DateTime.Now.ToString();
            DataTable dt = piechart.NoteCountyeardate(nowdate,todayDate);
            DataTable dts = piechart.NoteCountyeardate2(nowdate,todayDate);
            float x, y,xx,yy;
            x = float.Parse(dt.Rows[0][0].ToString());
            y = float.Parse(dts.Rows[0][0].ToString());
            if (x <= 0)
            {
                xx = 0;
            }
            else
            {
                xx = ((x / (x + y)) * 100);
            }
            if (y <= 0)
            {
                yy = 0;
            }
            else
            {
                yy = ((y / (x + y)) * 100);
            }
            bool isData = true;
            if (xx > 0 && yy > 0)
            {
                chart4.Series["Oneyear"].Points.AddXY("Completed", xx);
                chart4.Series["Oneyear"].Points.AddXY("Incompleted", yy);
            }

            else if (x > 0 && y < 1)
            {
                chart4.Series["Oneyear"].Points.AddXY("Completed", x);
            }

            else if (x < 1 && y > 0)
            {
                chart4.Series["Oneyear"].Points.AddXY("Incompleted", y);
            }

            else
            {
                chart4.Series["Oneyear"].Points.AddXY("No data", 0);
                isData = false;
            }

            if (isData)
            {
                lblComplet.Text = "Completed :" + String.Format("{0:0.00}", xx) + "%";
                lblIncomple.Text = "Incompleted : " + String.Format("{0:0.00}", yy) + "%";
                chart4.Titles.Add("Status");
            }

            else
            {
                lblComplet.Text = "";
                lblIncomple.Text = "";
                chart4.Titles.Add("No data to evaluate");
            }
        }
        private void Pie_Chart_Load(object sender, EventArgs e)
        {
            Todaychart();
            WeekChart();
            MonthChart();
            Yearchart();
            
        }
        PiechartBLL piechart = new PiechartBLL();
        private void chart1_Click(object sender, EventArgs e)
        {
          
            
        }

        private void Pie_Chart_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            DashBoard dashboard = new DashBoard();
            dashboard.BringToFront();
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
