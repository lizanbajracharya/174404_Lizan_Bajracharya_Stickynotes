using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _174404_Lizan_Bajracharya_Stickynotes
{
   public class StickyNotesBLL
    {
        private string Title;
        private string Category;
        private string Content;
        
        public string _Title
        {
            get { return Title; }
            set { Title = value; }
        }

        public string _Category
        {
            get { return Category; }
            set { Category = value; }
        }

        public string _Content
        {
            get { return Content; }
            set { Content = value; }
        }
       
        Dbconnection conn = new Dbconnection();
        
        public int User()
        {
            DataTable dt = null;
            string user=UsernameBLL._Username;
            string query = "select UserID from Users where Username='"+user+"'";
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
        //add notes
        public void Add()
        {
            string query;
            query = "insert into StickyNotes(UserID,Title,CategoryID,ContentOfNotes,DateCreated,IsStickied,IsCompleted) values('"+User()+"','" + Title + "','" + Category + "','" + Content + "','"+DateTime.Now+"',1,0)";
            try
            {
                conn.Manipulate(query);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

       
        public DataTable StickyLoad()
        {
            DataTable dt = null;
            string query;
            query = "select CategoryID,CategoryName from Categories where UserID="+User();
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

        public DataTable stickychecktest()
        {
            DataTable dt = null;
            string query = "select NoteID,UserID,CategoryID,DateCreated,Title,ContentOfNotes,IsStickied,IsCompleted from StickyNotes where UserID=" + User();
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
        
    }
}
