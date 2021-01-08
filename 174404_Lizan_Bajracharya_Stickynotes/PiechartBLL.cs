using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _174404_Lizan_Bajracharya_Stickynotes
{
    public class PiechartBLL
    {
        public int usersss()
        {
            DataTable dt = null;
            string user = UsernameBLL._Username;
            string query = "select UserID from Users where Username='" + user + "'";
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

        Dbconnection conn = new Dbconnection();
        //today chart query
        public DataTable NoteCounttodaydate(DateTime todaydate)
        {
            DataTable dt = null;
            string query;
            query = "select Count(IsCompleted) from StickyNotes where DateCreated='"+todaydate+"'and IsCompleted='1' and UserID="+usersss();
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

        public DataTable NoteCounttodaydate2(DateTime todaydate)
        {
            DataTable dt = null;
            string query;
            query = "select Count(IsCompleted) from StickyNotes where DateCreated='" + todaydate + "' and IsCompleted='0'and UserID=" + usersss();
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
        //week chary query
        public DataTable NoteCountweekdate(string todaydate,string Nowdate)
        {
            DataTable dt = null;
            string query;
            query = "select Count(IsCompleted) from StickyNotes where DateCreated between '" + Nowdate + "' and '"+todaydate+"' and IsCompleted='1' and UserID=" + usersss();
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

        public DataTable NoteCountweekdate2(string todaydate, string Nowdate)
        {
            DataTable dt = null;
            string query;
            query = "select Count(IsCompleted) from StickyNotes where DateCreated between '" + Nowdate + "' and '" + todaydate + "' and IsCompleted='0' and UserID=" + usersss();
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
        //month chart query
        public DataTable NoteCountmonthdate(string todaydate, string Nowdate)
        {
            DataTable dt = null;
            string query;
            query = "select Count(IsCompleted) from StickyNotes where DateCreated between '" + Nowdate + "' and '" + todaydate + "'and IsCompleted='1' and UserID=" + usersss();
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

        public DataTable NoteCountmonthdate2(string todaydate, string Nowdate)
        {
            DataTable dt = null;
            string query;
            query = "select Count(IsCompleted) from StickyNotes where DateCreated between '" + Nowdate + "' and '" + todaydate + "' and IsCompleted='0'and UserID=" + usersss();
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
        //year chart query
        public DataTable NoteCountyeardate(string todaydate, string Nowdate)
        {
            DataTable dt = null;
            string query;
            query = "select Count(IsCompleted) from StickyNotes where DateCreated between '" + Nowdate + "' and '" + todaydate + "'and IsCompleted='1' and UserID=" + usersss();
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

        public DataTable NoteCountyeardate2(string todaydate, string Nowdate)
        {
            DataTable dt = null;
            string query;
            query = "select Count(IsCompleted) from StickyNotes where DateCreated between '" + Nowdate + "' and '" + todaydate + "' and IsCompleted='0'and UserID=" + usersss();
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
