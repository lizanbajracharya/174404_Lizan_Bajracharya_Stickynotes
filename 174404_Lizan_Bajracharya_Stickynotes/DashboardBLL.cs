using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _174404_Lizan_Bajracharya_Stickynotes
{
   public class DashboardBLL
    {                     
        Dbconnection conn = new Dbconnection();
        //sticky update
        public void Update(string Content,int ID)
        {
            string query;
            query = "update StickyNotes set ContentOfNotes ='" + Content + "' where NoteID=" + ID;
            try
            {
                conn.Manipulate(query);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        //delete notes
        public void DeleteNote(int ID)
        {
            string query;
            query = "Delete from StickyNotes where NoteID=" + ID;
            try
            {
                conn.Manipulate(query);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        //user load
        public int usersss()
        {
            DataTable dt = null;
            string user = UsernameBLL._Username;
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

      /*  public DataTable LoadSticky(int ID)
        {
            string query = "select NoteID,UserID,CategoryID,DateCreated,Title,ContentOfNotes,IsStickied,IsCompleted from StickyNotes where NoteID='" + ID +"' and IsStickied='1'";
            DataTable dt = conn.Retrieve(query);
            return dt;
        }

        public DataTable LoadComplete(int ID)
        {
            string query = "select NoteID,UserID,CategoryID,DateCreated,Title,ContentOfNotes,IsStickied,IsCompleted from StickyNotes where NoteID='" + ID + "' and IsCompleted='0'";
            DataTable dt = conn.Retrieve(query);
            return dt;
        }*/
        
        public DataTable NoteDetail()
        {
            DataTable dt = null;
            string query;
            query = "select s.NoteID,s.UserID,c.CategoryName,s.DateCreated,s.Title,s.ContentOfNotes,s.IsStickied,s.IsCompleted from StickyNotes s,Categories c where s.CategoryID=c.CategoryID and s.UserID=" + usersss()+" and s.IsStickied='1'" ;
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

        public DataTable StartupLoad()
        {
            DataTable dt = null;
            string query;
            query = "select s.NoteID,s.UserID,c.CategoryName,s.DateCreated,s.Title,s.ContentOfNotes,s.IsStickied,s.IsCompleted from StickyNotes s,Categories c where s.CategoryID=c.CategoryID and s.UserID=" + usersss() + " and s.IsStickied='1' order by s.DateCreated desc";
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

        public void UpdateCompletedCheckbox(int nid,bool iscomplete)
        {
            string query="update StickyNotes set IsCompleted='"+iscomplete+"' where NoteID='"+nid+"'";
            try
            {
                conn.Manipulate(query);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void UpdateStickiedCheckbox(int nid,bool isSticky)
        {
            string query = "update StickyNotes set IsStickied='" + isSticky + "' where NoteID='" + nid + "'";
            try
            {
                conn.Manipulate(query);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public DataTable CompletedNotes()
        {
            DataTable dt = null;
            string query = "select s.NoteID,s.UserID,c.CategoryName,s.DateCreated,s.Title,s.ContentOfNotes,s.IsStickied,s.IsCompleted from StickyNotes s,Categories c where s.CategoryID=c.CategoryID and s.UserID=" + usersss()+"and s.IsCompleted='1'";
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

        public DataTable NotCompleteNotes()
        {
            DataTable dt = null;
            string query= "select s.NoteID,s.UserID,c.CategoryName,s.DateCreated,s.Title,s.ContentOfNotes,s.IsStickied,s.IsCompleted from StickyNotes s,Categories c where s.CategoryID=c.CategoryID and s.UserID=" + usersss() + "and s.IsCompleted='0'";
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

        public DataTable Loadall()
        {
            DataTable dt = null;
            string query= "select s.NoteID, s.UserID, c.CategoryName, s.DateCreated, s.Title, s.ContentOfNotes, s.IsStickied, s.IsCompleted from StickyNotes s,Categories c where s.CategoryID=c.CategoryID and s.UserID = " + usersss();
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

        public DataTable DateLoad(string date)
        {
            DataTable dt = null;
            string query= "select s.NoteID, s.UserID, c.CategoryName, s.DateCreated, s.Title, s.ContentOfNotes, s.IsStickied, s.IsCompleted from StickyNotes s,Categories c where s.CategoryID=c.CategoryID and s.UserID = " + usersss() + " and s.DateCreated='"+date+"'";
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

        public DataTable Titleload(string title)
        {
            DataTable dt = null;
            string query = "select s.NoteID, s.UserID, c.CategoryName, s.DateCreated, s.Title, s.ContentOfNotes, s.IsStickied, s.IsCompleted from StickyNotes s,Categories c where s.CategoryID=c.CategoryID and s.UserID = " + usersss() + " and s.Title='"+title+"'";
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

        public DataTable Noteload()
        {
            DataTable dt = null;
            string query;
            query = "select s.NoteID,s.UserID,c.CategoryName,s.DateCreated,s.Title,s.ContentOfNotes,s.IsStickied,s.IsCompleted from StickyNotes s,Categories c where s.CategoryID=c.CategoryID and s.UserID=" + usersss() + " and s.IsStickied='1'";
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

        public DataTable usertype()
        {
            DataTable dt = null;
            string query = "select UsertypeID from Users where UserID='" + usersss() + "'";
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
