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
    public partial class AboutUs : Form
    {
        public AboutUs()
        {
            InitializeComponent();
        }

        private void AboutUs_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            DashBoard dashboard = new DashBoard();
            dashboard.BringToFront();
            
        }
    }
}
