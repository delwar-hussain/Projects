using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SBMS.Model;
using  SBMS.BLL;

namespace SBMS
{
    public partial class Customer : Form
    {

        CustomerManager _customerManager = new CustomerManager();
        Customers _customers = new Customers();
        public Customer()
        {
            InitializeComponent();
            custmerGridView.DataSource = _customerManager.show();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(codeTextBox.Text))
            {
                MessageBox.Show("code must be required");
                codeTextBox.Focus();
                return;

            }

            if (string.IsNullOrEmpty(nameTextBox.Text))
            {
                MessageBox.Show("please fill the name");
                nameTextBox.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(emailTextBox.Text))
            {
                MessageBox.Show("please fill the email");
                emailTextBox.Focus();
                return;

            }
            else if (string.IsNullOrEmpty(contactTextBox.Text))
            {
                MessageBox.Show("please fill the contact");
                contactTextBox.Focus();
                return;

            }

            if (codeTextBox.TextLength > 4 || codeTextBox.TextLength < 4)
            {
                MessageBox.Show("code must be 4 digit");
                return;
            }

            if (_customerManager.IsNameexist(_customers))
            {
                MessageBox.Show(nameTextBox.Text + "name already exit");
                return;
            }

            if (saveButton.Text == "save")
            {
                bool isInsert = _customerManager.insertvalue(_customers);
                if (isInsert)
                {
                    MessageBox.Show("successfull save");
                }
                else
                {
                    MessageBox.Show("not save");
                }
            }
        
            else

            {
                bool IsUpdate = _customerManager.update(_customers);
                if (IsUpdate)
                {
                    MessageBox.Show("update Successfully");
                    saveButton.Text = "save";
                }
                else
                {
                    MessageBox.Show("not update");
                }
            }
            custmerGridView.DataSource = _customerManager.show();
            cleartext();
           

            



            
             


        }

        private void custmerGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (custmerGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                custmerGridView.CurrentRow.Selected = true;
                //_customers.Id = Convert.ToInt32(custmerGridView.Rows[e.RowIndex].Cells[0]);
                codeTextBox.Text = custmerGridView.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                nameTextBox.Text = custmerGridView.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                addressTextBox.Text = custmerGridView.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                emailTextBox.Text = custmerGridView.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                contactTextBox.Text = custmerGridView.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
                loyaltyTextBox.Text = custmerGridView.Rows[e.RowIndex].Cells[6].FormattedValue.ToString();
                saveButton.Text = "Update";
            }
        }
        private void cleartext()
        {
            codeTextBox.Clear();
            nameTextBox.Clear();
            addressTextBox.Clear();
            emailTextBox.Clear();
            contactTextBox.Clear();
            loyaltyTextBox.Clear();

        }
    }
}
