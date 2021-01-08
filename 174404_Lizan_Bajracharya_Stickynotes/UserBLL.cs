using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _174404_Lizan_Bajracharya_Stickynotes
{
   public class UserBLL
    {
        private string FirstName;
        private string LastName;
        private string Address;
        private string Email;
        private string PhoneNo;
        private string Gender;
        private string Username;
        private string Password;
        private int ID;
        private string Usertype;

        public string _FirstName
        {
            get { return FirstName; }
            set { FirstName = value; }
        }

        public string _LastName
        {
            get { return LastName; }
            set { LastName = value; }
        }

        public string _Address
        {
            get { return Address; }
            set { Address = value; }
        }

        public string _Email
        {
            get { return Email; }
            set { Email = value; }
        }

        public string _PhoneNo
        {
            get { return PhoneNo; }
            set { PhoneNo = value; }
        }

        public string _Gender
        {
            get { return Gender; }
            set { Gender = value; }
        }

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

        public int _ID
        {
            get { return ID; }
            set { ID = value; }
        }

        public string _Usertype
        {
            get { return Usertype; }
            set { Usertype = value; }
        }

        Dbconnection conn = new Dbconnection();
        //To add the user
        public void Add()
        {
            string query;
            query = "insert into Users(FirstName,LastName,Addrss,PhoneNo,Email,Gender,Username,Pssword,UserTypeID)values('" + FirstName + "','" + LastName + "','" + Address + "','" + PhoneNo + "','" + Email + "','" + Gender + "','" + Username + "','" + Password + "','"+Usertype+"')";
            try
            {
                conn.Manipulate(query);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void Addnormal()
        {
            string query;
            query = "insert into Users(FirstName,LastName,Addrss,PhoneNo,Email,Gender,Username,Pssword,UserTypeID)values('" + FirstName + "','" + LastName + "','" + Address + "','" + PhoneNo + "','" + Email + "','" + Gender + "','" + Username + "','" + Password + "','3')";
            try
            {
                conn.Manipulate(query);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        //to update user
        public void Update()
        {
            string query;
            query = "Update Users set FirstName='" + FirstName + "',LastName='" + LastName + "',Addrss='" + Address + "',PhoneNo='" + PhoneNo + "',Email='" + Email + "',Gender='" + Gender + "',Username='" + Username + "',Pssword='" + Password + "',UsertypeID='"+Usertype+"' where UserID="+ID;
            try
            {
                conn.Manipulate(query);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void AdminUpdate()
        {
            string query;
            query = "Update Users set FirstName='" + FirstName + "',LastName='" + LastName + "',Addrss='" + Address + "',PhoneNo='" + PhoneNo + "',Email='" + Email + "',Gender='" + Gender + "',Username='" + Username + "',Pssword='" + Password + "' where UserID=" + ID;
            try
            {
                conn.Manipulate(query);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        // to delete user
        public void Delete()
        {
            string query,query1,query2;
            query = "Delete from Users where UserID=" + ID;
            query1 = "Delete from Categories where UserID=" + ID;
            query2 = "Delete From StickyNotes where UserID=" + ID;            
            try
            {
                conn.Manipulate(query2);
                conn.Manipulate(query1);
                conn.Manipulate(query);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        //to load the user
        public DataTable Userload()
        {
            DataTable dt = null;
            string query;
            query = "Select u.UserID,u.FirstName,u.LastName,u.Addrss,u.Email,u.PhoneNo,u.Gender,u.Username,s.UsertypeName from Users u,Usertype s where u.UsertypeID=s.UsertypeID";
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

        public DataTable Userloadadmin()
        {
            DataTable dt = null;
            string query;
            query = "Select u.UserID,u.FirstName,u.LastName,u.Addrss,u.Email,u.PhoneNo,u.Gender,u.Username from Users u,UserType s where u.UsertypeID=s.UsertypeID and s.UsertypeName='User'";
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

        public DataTable UserUpdate()
        {
            DataTable dt = null;
            string query;
            query = "select Firstname,Lastname,Addrss,PhoneNo,Email,Username,Pssword,Gender,UsertypeID from Users where UserID=" + ID;
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

        public DataTable UserUpdateadmin()
        {
            DataTable dt = null;
            string query;
            query = "select Firstname,Lastname,Addrss,PhoneNo,Email,Username,Pssword,Gender from Users where UserID=" + ID;
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
        public DataTable UsernameEntry()
        {
            DataTable dt = null;
            string query = "select Username from Users where Username='"+Username+"'";
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

        public DataTable Usertypeload()
        {
            DataTable dt = null;
            string query = "select UsertypeName,UsertypeID from Usertype";
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
        public DataTable countuser()
        {
            DataTable dt = null;
            string query = "select Firstname,Lastname,Addrss,PhoneNo,Email,Username,Pssword,Gender from Users ";
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
