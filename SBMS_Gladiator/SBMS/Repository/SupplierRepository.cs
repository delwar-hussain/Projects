using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using SBMS.Model;

namespace SBMS.Repository
{
    
   public class SupplierRepository
    {
      //  public bool insertvalue(string code, string name, string address, string email, string contact, string contactperson)
        public bool insertvalue(Suppliers suppliers)
       
        {
            bool isAdded = false;


            string connectionString = @"Server=DESKTOP-MB5PO9A; Database=SBMS; Integrated Security=True";

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //string Commandstring = @"INSERT INTO Suppliers( Code,Name,Address,Email,Contact,ContactPerson) VALUES('" + code + "','" + name + "','" + address + "','" + email + "', '" + contact + "','" + contactperson + "')";
            string Commandstring = @"INSERT INTO Suppliers VALUES('" +suppliers.Code + "','" + suppliers.Name+ "','" + suppliers.Address + "','" + suppliers.Email + "', '" + suppliers.Contact + "','" +suppliers.ContactPerson + "')";

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

        public bool IsNameexist(string code,string email,string contact)
        {
            bool exist = false;

            string connectionString = @"Server=DESKTOP-MB5PO9A; Database=SBMS; Integrated Security=True";

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            string Commandstring = @"SELECT * FROM Suppliers WHERE Code='" + code + "' OR Contact='" + contact + "' OR Email='" + email + "'";    //string thats why use ''


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

            string Commandstring = @"SELECT * FROM Suppliers";

            SqlCommand sqlCommand = new SqlCommand(Commandstring, sqlConnection);


            sqlConnection.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();

            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();

            return dataTable;
        }
        public bool update(Suppliers suppliers)
        // public bool update(string code, string name, string address, string email, string contact, string contactperson)
        {
           bool isUpdate = false;

            string connectionString = @"Server=DESKTOP-MB5PO9A; Database=SBMS; Integrated Security=True";

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            string Commandstring = @"UPDATE Suppliers SET Code='"+suppliers.Code+"',Name='"+suppliers.Name+"',Address='"+suppliers.Address+"',Email='"+suppliers.Email+"',Contact='"+suppliers.Contact+"',ContactPerson='"+suppliers.ContactPerson+"' WHERE Code='"+suppliers.Code+"'";


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

        public bool delete(string code)
        {
            bool isDelete = false;

            string connectionString = @"Server=DESKTOP-MB5PO9A; Database=SBMS; Integrated Security=True";

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            string Commandstring = @"DELETE FROM Suppliers WHERE Code=" + code + ";";

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
