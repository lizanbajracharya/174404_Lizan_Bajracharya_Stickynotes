using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _174404_Lizan_Bajracharya_Stickynotes
{
   public class Forgorpasswordbll
    {
        private string password;

        public string _password
        {
            get { return password; }
            set { password = value; }
        }

        Dbconnection conn = new Dbconnection();
        public DataTable Usernamecheck(string username)
        {
            DataTable dt = null;
            string query = "Select u.Username,s.UsertypeID from Users u,Usertype s where u.UsertypeID=s.UsertypeID and Username='" + username + "' and UsertypeName='User'";
            try
            {
                dt = conn.Retrieve(query);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return dt;
        }

        public void Changepassword(string username)
        {
            string query = "update Users set Pssword='" + password + "' where Username='" + username + "'";
            try
            {
                conn.Manipulate(query);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public DataTable checkuser()
        {
            DataTable dt = null;
            string user=UsernameBLL._Username;
            string query = "select count(Username) from Users where Username='" + user + "'";
            try
            {
                dt = conn.Retrieve(query);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return dt;
        }
        public string usercheck()
        {
            DataTable dt = null;
            string user = UsernameBLL._Username;
            string query = "select Pssword from Users where Username='"+user+"'";
            try
            {
                dt = conn.Retrieve(query);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return dt.Rows[0][0].ToString();
        }
   }
}
