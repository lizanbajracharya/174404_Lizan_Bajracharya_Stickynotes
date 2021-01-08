using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _174404_Lizan_Bajracharya_Stickynotes
{
    class Dbconnection
    {
        SqlConnection cn = new SqlConnection(@"Data source=DESKTOP-0KENFII;Initial Catalog=Lizan_Bajracharya_174404_Stickynotes;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();

        //insert,update,delete
        public void Manipulate(string query)
        {
            try
            {
                cn.Open();
                cmd.Connection = cn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        //select
        public DataTable Retrieve(string query)
        {
            DataSet ds = null;
            try
            {
                ds = new DataSet();
                da = new SqlDataAdapter(query, cn);
                da.Fill(ds);
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return ds.Tables[0];
        }


    }
}
