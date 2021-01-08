using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _174404_Lizan_Bajracharya_Stickynotes
{
   public class CategoryBLL
    {
        private string Category;
        private int ID;
        public string _Category
        {
            get { return Category; }
            set { Category = value; }
        }

        public int _ID
        {
            get { return ID; }
            set { ID = value; }
        }

        Dbconnection conn = new Dbconnection();
        public void CategoryEntry()
        {
            string query;
            query = "insert into Categories(CategoryName,UserID) values('" + Category + "','"+UserLoad()+"')";
            try
            {
                conn.Manipulate(query);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void UpdateCategory()
        {
            string query;
            query = "Update Categories set CategoryName='" + Category + "' where CategoryID=" + ID;
            try
            {
                conn.Manipulate(query);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void DeleteCategory()
        {
            string query;
            string query1;
            query1 = "Delete from StickyNotes where CategoryID=" + ID;
            query = "Delete from Categories where CategoryID=" + ID;            
            try
            {
                conn.Manipulate(query1);
                conn.Manipulate(query);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public int UserLoad()
        {
            DataTable dt = null;
            string userid = UsernameBLL._Username;
            string query = "select UserID from Users where Username='" + userid +"'";
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

        public DataTable CategoryLoad()
        {
            DataTable dt = null; 
            string query;
            query = "Select CategoryID,CategoryName from Categories where UserID="+UserLoad();
            try
            {
                 dt = conn.Retrieve(query);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return dt;
        }
       
        public DataTable DelCategory()
        {
            DataTable dt = null;
            string query = "select CategoryID,CategoryName from Categories where CategoryID=" + ID;
            try
            {
                 dt = conn.Retrieve(query);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return dt;
            
        }

        public DataTable Delcat()
        {
            DataTable dt = null;
            string query = "select CategoryName,CategoryID from Categories";
            try
            {
                dt = conn.Retrieve(query);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return dt;
        }
        public DataTable categoryselecttest()
        {
            DataTable dt = null;
            string query = "select Count(CategoryID) from Categories where UserID=" + UserLoad();
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
    }
}
