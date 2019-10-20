using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using SBMS.BLL;
using SBMS.Model;

namespace SBMS.Repository
{
    public class CategoryRepository
    {
        public bool insertvalue(Categories categories)

        {
            bool isAdded = false;


            string connectionString = @"Server=DESKTOP-MB5PO9A; Database=SBMS; Integrated Security=True";

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            
            string Commandstring = @"INSERT INTO Category VALUES('" + categories.Code + "','" + categories.Name + "' )";

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

        public bool IsNameexist(string code, string name)
        {
            bool exist = false;

            string connectionString = @"Server=DESKTOP-MB5PO9A; Database=SBMS; Integrated Security=True";

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            string Commandstring = @"SELECT * FROM Category WHERE Code='" + code + "' OR   Name='" + name + "'";    //string thats why use ''


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

            string connectionString = @"Server=DESKTOP-MB5PO9A; Database=SBMS; Integrated Security=True";

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            string Commandstring = @"SELECT * FROM Category";

            SqlCommand sqlCommand = new SqlCommand(Commandstring, sqlConnection);


            sqlConnection.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();

            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();

            return dataTable;
        }

    }
}
