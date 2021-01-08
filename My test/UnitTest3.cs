using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _174404_Lizan_Bajracharya_Stickynotes;
namespace My_test
{
    [TestClass]
    public class UnitTest3
    {
        CategoryBLL category = new CategoryBLL();
        [TestMethod]
        public void Categoryaddtest()
        {
            category._Category = "Home";
            category.CategoryEntry();
        }
    }
}
