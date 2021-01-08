using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _174404_Lizan_Bajracharya_Stickynotes
{
   public class LoginBLL
    {
        private string Username;
        private string Password;

        public string _Username
        {
            get { return Username; }
            set { Username = value; }
        }

        public string _Password
        {
            get { return Password; }
            set { Password = value; }
        }
        Dbconnection conn = new Dbconnection();
        //this function check if there is user or not
        public bool checkUser()
        {
            DataTable dt = null;
            string query;
            query = "Select Username,Pssword from Users where Username='" + Username + "' and Pssword='" + Password + "'";
            try
            {
                dt = conn.Retrieve(query);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            if (dt.Rows.Count>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int usercheck()
        {
            DataTable dt = null;
            string query = "select count(UserID) from Users";
            try
            {
                dt = conn.Retrieve(query);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return int.Parse(dt.Rows[0][0].ToString());
        }
    }
}
