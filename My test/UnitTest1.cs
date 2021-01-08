using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _174404_Lizan_Bajracharya_Stickynotes;
using System.Data;

namespace My_test
{
    [TestClass]
    public class LoginBLLtesting
    {
        LoginBLL login = new LoginBLL();
        
        [TestMethod]
       

        public void Logintest()
        {
            login._Username = "admin";
            login._Password = "admin";
            bool remark = login.checkUser();
            bool valid = true;
            Assert.AreEqual(valid, remark);           
        }

        StickyNotesBLL note = new StickyNotesBLL();
        [TestMethod]

        public void Noteaddtest()
        {
            UsernameBLL._Username = "admin";
            DataTable dt = note.stickychecktest();
            int expected = dt.Rows.Count + 1;
            
            note._Title = "base";
            note._Content = "asd";
            note._Category = "2021" ;
            note.Add();
            dt = note.stickychecktest();
            int actual = dt.Rows.Count;

            Assert.AreEqual(expected, actual);


        }
        CategoryBLL category = new CategoryBLL();
        [TestMethod]
        public void Categoryaddtest()
        {
            UsernameBLL._Username = "admin";
            DataTable dt = category.categoryselecttest();
            int expected = int.Parse(dt.Rows[0][0].ToString()) + 1;
            category._Category = "Home";
            category.CategoryEntry();

             dt = category.categoryselecttest();

            int actual = int.Parse(dt.Rows[0][0].ToString());
            Assert.AreEqual(expected, actual);

        }

        Forgorpasswordbll forget = new Forgorpasswordbll();
        [TestMethod]
        public void forgetpasswordusernamecheck()
        {
            UsernameBLL._Username = "asd";
            bool expected = true;
            bool actual = false;
            DataTable dt = forget.checkuser();
            int remark=int.Parse(dt.Rows[0][0].ToString()) + 1;
            if (remark > 0)
            {
                actual = true;
            }
            Assert.AreEqual(expected, actual);

        }

        UserBLL user = new UserBLL();
        [TestMethod]
        public void userentry()
        {
            DataTable dt = user.countuser();
            int expected = dt.Rows.Count + 1;
            user._FirstName = "lizan";
            user._LastName = "bajracharya";
            user._Address = "patan";
            user._Email = "aa";
            user._Gender = "M";
            user._PhoneNo = "987";
            user._Username = "asd";
            user._Password = "asd";
            user.Addnormal();
            dt = user.countuser();
            int actual = dt.Rows.Count;
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void Changepassword()
        {
            UsernameBLL._Username = "admin";
            bool expected = true;
            bool actual = false;
            string oldpassword = forget.usercheck();
            forget._password = "admin";
            forget.Changepassword(UsernameBLL._Username);
            string newpassword = forget.usercheck();
            if(oldpassword!=newpassword)
            {
                actual = true;
            }
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void UserupdatebySuperadmin()
        {
            UsernameBLL._Username = "lizan";
            bool expected = true;
            bool actual = false;
            user._ID = 2022;
            user._FirstName = "fer";
            user._LastName = "asd";
            user._Address = "asd";
            user._Email = "asd";
            user._Gender = "M";
            user._PhoneNo = "98";
            user._Username = "asd";
            user._Password = "yet";
            user._Usertype = "3";
            user.Update();
            DataTable dt = user.UserUpdate();
            string firstname = dt.Rows[0][0].ToString();
            if(firstname!="asd")
            {
                actual = true;
            }
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void adminuserentry()
        {
            DataTable dt = user.countuser();
            int expected = dt.Rows.Count + 1;
            user._FirstName = "lizan";
            user._LastName = "bajracharya";
            user._Address = "patan";
            user._Email = "aa";
            user._Gender = "M";
            user._PhoneNo = "987";
            user._Username = "asd";
            user._Password = "asd";
            user._Usertype = "2";
            user.Add();
            dt = user.countuser();
            int actual = dt.Rows.Count;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void UpdatebyAdmin()
        {
            UsernameBLL._Username = "fer";
            bool expected = true;
            bool actual = false;
            user._ID = 2022;
            user._FirstName = "asd";
            user._LastName = "asd";
            user._Address = "asd";
            user._Email = "asd";
            user._Gender = "M";
            user._PhoneNo = "98";
            user._Username = "asd";
            user._Password = "yet";
            
            user.AdminUpdate();
            DataTable dt = user.UserUpdateadmin();
            string firstname = dt.Rows[0][0].ToString();
            if (firstname != "fer")
            {
                actual = true;
            }
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void deleteuser()
        {
            UsernameBLL._Username = "asd";
            bool expected = true;
            bool actual = false;
            user._ID = 2023;
            user.Delete();
            DataTable dt = user.Userloadadmin();
            if(dt.Rows.Count>0)
            {
                actual = true;
            }
            Assert.AreEqual(expected, actual);

        }
    }


}
