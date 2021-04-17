using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; 

namespace Sahand
{
    class Sqldata : Ghavanin
    {
        private string contection = "Data Source=.;Initial Catalog=data;Integrated Security=true";  
        public bool Delete(int Id)
        {
            SqlConnection connect = new SqlConnection(contection);
            
            try
            {
                
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText= "delete from inv.partpic where Id=@ID";
                cmd.Connection = connect;
                cmd.Parameters.AddWithValue("@ID", Id);
                connect.Open();
                cmd.ExecuteNonQuery();
                return true; 
                
            }
            catch
            {
                return false; 
            }
            finally
            {
                connect.Close(); 
            }
            
            
        }

       

        public DataTable Selectall()
        { 
            SqlConnection connect = new SqlConnection(contection);
            string query = "select * from inv.partpic";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connect);
            DataTable table = new DataTable();
            adapter.Fill(table); 
            return table; 
        }

        public DataTable Select_on()
        {
            return null; 
        }

        public bool update(string name, int number)
        {
            throw new NotImplementedException();
        }

        //public DataTable Search (string searcher)
        //{
        //    string query = "select * from inv.partpic where Name like @s ";
        //    SqlConnection connect = new SqlConnection(contection);
        //    SqlDataAdapter adapter = new SqlDataAdapter();
        //    adapter.SelectCommand.Parameters.AddWithValue("@s" + "%" + searcher + "%"); 
        //}
    }
}
