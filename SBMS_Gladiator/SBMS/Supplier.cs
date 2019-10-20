using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SBMS.BLL;
using SBMS.Model;

namespace SBMS
{
    public partial class Supplier : Form
    {
        SupplierManager _supplierManager = new SupplierManager();
        Suppliers _suppliers = new Suppliers();

        public Supplier()
        {
            InitializeComponent();
            supplierGridView.DataSource = _supplierManager.show();
        }
        
        private void saveButton_Click(object sender, EventArgs e)
        {

        }

        private void ClearText()
        {
            codeTextBox.Clear();
            nameTextBox.Clear();
            addressTextBox.Clear();
            emailTextBox.Clear();
            contactTextBox.Clear();
            contactPersonTextBox.Clear();
        }

        private void supplierGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           if(supplierGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                supplierGridView.CurrentRow.Selected = true;
                
                //codeTextBox.Text = supplierGridView.Rows[e.RowIndex].Cells["Id"].FormattedValue.ToString();
                codeTextBox.Text = supplierGridView.Rows[e.RowIndex].Cells["Code"].FormattedValue.ToString();
                nameTextBox.Text = supplierGridView.Rows[e.RowIndex].Cells["Name"].FormattedValue.ToString();
                addressTextBox.Text= supplierGridView.Rows[e.RowIndex].Cells["Address"].FormattedValue.ToString();
                emailTextBox.Text= supplierGridView.Rows[e.RowIndex].Cells["Email"].FormattedValue.ToString();
                contactTextBox.Text= supplierGridView.Rows[e.RowIndex].Cells["Contact"].FormattedValue.ToString();
                contactPersonTextBox.Text= supplierGridView.Rows[e.RowIndex].Cells["ContactPerson"].FormattedValue.ToString();
            }
            
        }

    



        private void deleteButton_Click(object sender, EventArgs e)
        {
            bool isDelete = _supplierManager.delete(codeTextBox.Text);
            if (isDelete)
            {
                MessageBox.Show("Deleted");
            }
            else
            {
                MessageBox.Show("Not deleted");
            }
        }

        private void Supplier_Load(object sender, EventArgs e)
        {

        }

        private void supplierGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (supplierGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                supplierGridView.CurrentRow.Selected = true;

                codeTextBox.Text = supplierGridView.Rows[e.RowIndex].Cells["Code"].FormattedValue.ToString();
                nameTextBox.Text = supplierGridView.Rows[e.RowIndex].Cells["Name"].FormattedValue.ToString();
                addressTextBox.Text = supplierGridView.Rows[e.RowIndex].Cells["Address"].FormattedValue.ToString();
                emailTextBox.Text = supplierGridView.Rows[e.RowIndex].Cells["Email"].FormattedValue.ToString();
                contactTextBox.Text = supplierGridView.Rows[e.RowIndex].Cells["Contact"].FormattedValue.ToString();
                contactPersonTextBox.Text = supplierGridView.Rows[e.RowIndex].Cells["ContactPerson"].FormattedValue.ToString();
                saveButton.Text = "Update";
            }
        }
    }
}
