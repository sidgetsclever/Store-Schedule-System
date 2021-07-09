using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace StoresScheduleSystem
{
    class StoresScheduleDAO
    {
        public SqlConnection connection;
        public SqlCommand command;
        public SqlDataAdapter adapter;
        public string connstring = ConfigurationManager.ConnectionStrings["StoresConnection"].ConnectionString;




        public DataTable FindStore(int storeId)
        {
            DataTable table = new DataTable();
            // Donot change method signature
            // Implement code here
            //StoresScheduleDAO a = new StoresScheduleDAO();


                connection = new SqlConnection(connstring);
                string query = "select * from Stores where storeId= " + storeId;
         
                connection.Open();

                adapter = new SqlDataAdapter(query, connection);
                //DataSet a = new DataSet();
                adapter.Fill(table);
                // table = a.Tables[0];
                connection.Close();
              
            

            return table;
        }

        public int UpdateStore(int storeId, string openingTime, string closingTime)
        {
            int RowsAffected = 0;
            // Donot change method signature
            // Implement code here
            connection = new SqlConnection(connstring);
            string query = "update dbo.Stores set OpeningTime= '" + openingTime + "' ,ClosingTime= '" + closingTime + "' where StoreId= " + storeId;
            connection.Open();
            command = new SqlCommand(query, connection);
            RowsAffected = command.ExecuteNonQuery();
            connection.Close();


            return RowsAffected;
        }
    }
}
