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
    public partial class Category : Form
    {
        CategoryManager _categoryManager = new CategoryManager();
        Categories _categories = new Categories();
        public Category()
        {
            InitializeComponent();
            categoryGridView.DataSource = _categoryManager.show();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            _categories.Code = categoryCodeTextBox.Text;
            _categories.Name = categoryNameTextBox.Text;



            //if (string.IsNullOrEmpty(codeTextBox.Text))
            if (string.IsNullOrEmpty(categoryCodeTextBox.Text))
            {
                MessageBox.Show("Code Must be required");
                categoryCodeTextBox.Focus();
                return;
            }
            if (string.IsNullOrEmpty(categoryNameTextBox.Text))
            {
                MessageBox.Show("Please fill the name");
                categoryNameTextBox.Focus();
                return;
            }

            if (categoryCodeTextBox.TextLength > 4 || categoryCodeTextBox.TextLength < 4)
            {
                MessageBox.Show("Code must be in 4 digit");
                return;
            }
            else
            {
                //if (_supplierManager.IsNameexist(codeTextBox.Text,emailTextBox.Text,contactTextBox.Text))
                if (_categoryManager.IsNameexist(categoryCodeTextBox.Text, categoryNameTextBox.Text))

                {
                    MessageBox.Show("Already Exist");
                    return;
                }
                else
                {
                    if (saveButton.Text == "Save")
                    {
                        //bool isInsert = _supplierManager.insertvalue(codeTextBox.Text, nameTextBox.Text, addressTextBox.Text, emailTextBox.Text, contactTextBox.Text, contactPersonTextBox.Text);
                        bool isInsert = _categoryManager.insertvalue(_categories);
                        if (isInsert)
                        {
                            MessageBox.Show("Successfully saved");
                        }
                        else
                        {
                            MessageBox.Show("Not saved");
                        }
                    }




                }
            }
            categoryGridView.DataSource = _categoryManager.show();
        }

        private void categoryGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (categoryGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                categoryGridView.CurrentRow.Selected = true;

                categoryCodeTextBox.Text = categoryGridView.Rows[e.RowIndex].Cells["Code"].FormattedValue.ToString();
                categoryNameTextBox.Text = categoryGridView.Rows[e.RowIndex].Cells["Name"].FormattedValue.ToString();

            }
        }
    }
}
