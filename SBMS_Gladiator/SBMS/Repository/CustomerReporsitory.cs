using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using SBMS.Model;
using SBMS.BLL;

namespace SBMS.Repository
{
   public class CustomerReporsitory
    {
         public bool insertvalue(Customers customers)
       
        {
            bool isAdded = false;


            string connectionString = @"Server=DESKTOP-Q5FQUO6; Database=SBMS; Integrated Security=True";

            SqlConnection sqlConnection = new SqlConnection(connectionString);

             
            string Commandstring = @"INSERT INTO CUSTOMERS VALUES('" + customers.Code + "','" + customers.Name+ "','" + customers.Address + "','" + customers.Email + "', '" + customers.Contact + "'," + customers.LoyltyPoint + ")";

            SqlCommand sqlCommand = new SqlCommand(Commandstring, sqlConnection);


            sqlConnection.Open();
            int isExecuted = sqlCommand.ExecuteNonQuery();
            if (isExecuted > 0)
            {

                isAdded = true;
            }
            sqlConnection.Close();


            return isAdded;
        }

        public bool IsNameexist(Customers customers)
        {
            bool exist = false;

            string connectionString = @"Server=DESKTOP-Q5FQUO6; Database=SBMS; Integrated Security=True";

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            string Commandstring = @"SELECT * FROM CUSTOMERS WHERE Code='" + customers.Code + "' OR Contact='" + customers.Contact + "' OR Email='" + customers.Email + "' Where Id = "+customers.Id+" ";    //string thats why use ''


            SqlCommand sqlCommand = new SqlCommand(Commandstring, sqlConnection);


            sqlConnection.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();

            sqlDataAdapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                exist = true;
                //customerDataGridView.DataSource = dataTable;
            }

            sqlConnection.Close();



            return exist;
        }

        public DataTable show()
        {

            string connectionString = @"Server=DESKTOP-Q5FQUO6; Database=SBMS; Integrated Security=True";

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            string Commandstring = @"SELECT * FROM CUSTOMERS";

            SqlCommand sqlCommand = new SqlCommand(Commandstring, sqlConnection);


            sqlConnection.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();

            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();

            return dataTable;
        }
        public bool update(Customers customers)
        
        {
           bool isUpdate = false;

            string connectionString = @"Server=DESKTOP-Q5FQUO6; Database=SBMS; Integrated Security=True";

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            string Commandstring = @"UPDATE CUSTOMERS SET Code='" + customers.Code+"',Name='"+ customers.Name+"',Address='"+ customers.Address+"',Email='"+ customers.Email+"',Contact='"+ customers.Contact+ "',LoyltyPoint=" + customers.LoyltyPoint+" WHERE Id="+ customers.Id+" ";


            SqlCommand sqlCommand = new SqlCommand(Commandstring, sqlConnection);


            sqlConnection.Open();

            int isExecuted = sqlCommand.ExecuteNonQuery();
            if (isExecuted > 0)
            {
                isUpdate = true;
            }

            sqlConnection.Close();

            return isUpdate;
        }

        public bool delete(Customers customers)
        {
            bool isDelete = false;

            string connectionString = @"Server=DESKTOP-Q5FQUO6; Database=SBMS; Integrated Security=True";

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            string Commandstring = @"DELETE FROM CUSTOMERS WHERE Code=" + customers.Code + ";";

            SqlCommand sqlCommand = new SqlCommand(Commandstring, sqlConnection);


            sqlConnection.Open();

            int isExecuted = sqlCommand.ExecuteNonQuery();
            if (isExecuted > 0)
            {
                isDelete = true;
            }

            sqlConnection.Close();

            return isDelete;
        }

    }
}
