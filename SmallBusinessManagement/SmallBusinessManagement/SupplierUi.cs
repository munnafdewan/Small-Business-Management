using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmallBusinessManagement.BLL;
using SmallBusinessManagement.Model;


namespace SmallBusinessManagement
{
    public partial class SupplierUi : Form
    {
        SupplierManager _supplierManager = new SupplierManager();
        int indexRow;
        public SupplierUi()
        {
            InitializeComponent();
        }
        private void Edit()
        {
            DataGridViewLinkColumn Editlink = new DataGridViewLinkColumn();
            Editlink.UseColumnTextForLinkValue = true;
            Editlink.HeaderText = "Action";
            Editlink.DataPropertyName = "lnkColumn";
            Editlink.LinkBehavior = LinkBehavior.SystemDefault;
            Editlink.Text = "Edit";
            showDataGridView.Columns.Add(Editlink);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Supplier supplier = new Supplier();

            
            supplier.code = codeTextBox.Text;
            supplier.name = nameTextBox.Text;
            supplier.address = addressTextBox.Text;
            supplier.contact = contactTextBox.Text;
            supplier.email = emailTextBox.Text;
            supplier.contactperson = contactPersonTextBox.Text;

            if (saveButton.Text == "Update")
            { 

                //Update

                if (_supplierManager.Update(supplier))
                {
                    MessageBox.Show("Supplier Updated Successfully");
                    //Edit();

                    showDataGridView.DataSource = _supplierManager.Display();
                    saveButton.Text = "Save";

                    clear();
                    return;
                }
                else
                {
                    MessageBox.Show("Supplier Not Updated, Check details");
                    return;
                }

            }
            try
            {
                //Manadatory
                if (String.IsNullOrEmpty(codeTextBox.Text))
                {
                    MessageBox.Show("Code can not be Empty!!");
                    return;
                }
                if (String.IsNullOrEmpty(nameTextBox.Text))
                {
                    MessageBox.Show("Name can not be Empty!!");
                    return;
                }
                if (String.IsNullOrEmpty(contactTextBox.Text))
                {
                    MessageBox.Show("Contact can not be Empty!!");
                    return;
                }
                if (String.IsNullOrEmpty(emailTextBox.Text))
                {
                    MessageBox.Show("Please enter a email!!");
                    return;
                }

                supplier.code = codeTextBox.Text;
                supplier.name = nameTextBox.Text;
                supplier.address = addressTextBox.Text;
                supplier.contact = contactTextBox.Text;
                supplier.email = emailTextBox.Text;
                supplier.contactperson = contactPersonTextBox.Text;



                //Unique
                if (_supplierManager.IsCodeExist(supplier))
                {
                    MessageBox.Show(nameTextBox.Text + " Code Already Exist!!");
                    return;
                }
                if (_supplierManager.IsContactExist(supplier))
                {
                    MessageBox.Show(nameTextBox.Text + "Contact Already Exist!!");
                    return;
                }

                if (_supplierManager.IsEmailExist(supplier))
                {
                    MessageBox.Show(emailTextBox.Text + "Email Alraedy Exist!!");
                }

                //Validity
                if (codeTextBox.Text.Length != 4)
                {
                    MessageBox.Show("Code must be within 4 characters");
                }
                if(contactTextBox.Text.Length!=11)
                {
                    MessageBox.Show("Contact number must be within 11 characters");

                }
                    //Add/Insert
                    if (_supplierManager.Add(supplier))
                    {
                        MessageBox.Show("Saved");
                    }
                    else
                    {
                        MessageBox.Show("Not Saved");
                    }
                    //showDataGridView.DataSource = dataTable;
                    showDataGridView.DataSource = _supplierManager.Display();
                    clear();
                

            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
                return;
            }
        
        }
        private void clear()
        {
            codeTextBox.Clear();
            nameTextBox.Clear();
            addressTextBox.Clear();
            emailTextBox.Clear();
            contactTextBox.Clear();
            contactPersonTextBox.Clear();
        }

    


        private void searchButton_Click(object sender, EventArgs e)
        {
            showDataGridView.DataSource = _supplierManager.Search(contactTextBox.Text,nameTextBox.Text,emailTextBox.Text);
        }

        private void showDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            showDataGridView.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void SupplierUi_Load(object sender, EventArgs e)
        {
            showDataGridView.DataSource = _supplierManager.Display();
            Edit();
        }

        private void showDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            indexRow = e.RowIndex;
            DataGridViewRow row = showDataGridView.Rows[indexRow];
            codeTextBox.Text = row.Cells[2].Value.ToString();
            nameTextBox.Text = row.Cells[3].Value.ToString();
            addressTextBox.Text = row.Cells[4].Value.ToString();
            emailTextBox.Text = row.Cells[5].Value.ToString();
            contactTextBox.Text = row.Cells[6].Value.ToString();
            contactPersonTextBox.Text = row.Cells[7].Value.ToString();
            saveButton.Text = "Update";

        }

        private void emailTextBox_Leave(object sender, EventArgs e)
        {
            Regex mRegxExpression;
            if (emailTextBox.Text.Trim() != string.Empty)
            {
                mRegxExpression = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");

                if (!mRegxExpression.IsMatch(emailTextBox.Text.Trim()))
                {
                    MessageBox.Show("E-mail address format is not correct.", "MojoCRM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    emailTextBox.Focus();
                }
            }
        }
    }
}
