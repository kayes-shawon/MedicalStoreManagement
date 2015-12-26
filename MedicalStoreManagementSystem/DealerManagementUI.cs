using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MedicalStoreManagementSystem.DataAccess;

namespace MedicalStoreManagementSystem
{
    public partial class DealerManagementUI : Form
    {
        public DealerManagementUI()
        {
            InitializeComponent();
        }
        ConnectDB con = new ConnectDB();
        bool check;
        private void DealerManagementUI_Load(object sender, EventArgs e)
        {
            loadform();
        }

        private void loadform()
        {
            con.LoadDl(this.dataGridView1);
            loadtextbox();
            controlbutton(true);
        }

        private void loadtextbox()
        {
            idTextBox.DataBindings.Clear();
            idTextBox.DataBindings.Add("Text", dataGridView1.DataSource, "id");

            nameTextBox.DataBindings.Clear();
            nameTextBox.DataBindings.Add("Text", dataGridView1.DataSource, "name");

            addressTextBox.DataBindings.Clear();
            addressTextBox.DataBindings.Add("Text", dataGridView1.DataSource, "address");

            numberTextBox.DataBindings.Clear();
            numberTextBox.DataBindings.Add("Text", dataGridView1.DataSource, "number");

            medicineTextBox.DataBindings.Clear();
            medicineTextBox.DataBindings.Add("Text", dataGridView1.DataSource, "medicine");


        }

        private void controlbutton(bool b)
        {
            insertButton.Enabled = updateButton.Enabled = deleteButton.Enabled = b;
            saveButton.Enabled = !b;
            idTextBox.ReadOnly =
                nameTextBox.ReadOnly = addressTextBox.ReadOnly = numberTextBox.ReadOnly = medicineTextBox.ReadOnly = b;
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            controlbutton(false);
            check = true;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            if (idTextBox.Text.Trim() != "")
            {
                if (check)
                {
                    if (checkist())
                    {
                        MessageBox.Show("Exist");
                    }
                    else
                    {
                        int x = Int32.Parse(idTextBox.Text.Trim());
                        con.InsertDl(x, nameTextBox.Text, addressTextBox.Text, numberTextBox.Text, medicineTextBox.Text);
                        loadform();
                        MessageBox.Show("Saved Successfully");

                    }

                }
                else
                {
                    con.UpdateDl(Int32.Parse(idTextBox.Text.Trim()), nameTextBox.Text, addressTextBox.Text,
                        numberTextBox.Text, medicineTextBox.Text);
                    MessageBox.Show("Updated successfully");
                }
                loadform();
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            check = false;
            controlbutton(false);
            idTextBox.ReadOnly = true;
            

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes==MessageBox.Show("Do You Want To Delete Id '+ idTextBox.Text +'?","Message",MessageBoxButtons.YesNo,MessageBoxIcon.Question))
            {
                con.DeleteDl(Int32.Parse(idTextBox.Text));
                loadform();

            }
        }

        private bool checkist()
        {
            bool ch = false;
            SqlConnection conn = new SqlConnection("Server=KAYES-PC\\SQLEXPRESS;Initial Catalog=medicalstoremanagement;Integrated Security=True;");
            conn.Open();
            SqlDataAdapter da_check = new SqlDataAdapter("select * from Medicine where id='" +idTextBox.Text+ "'",conn);
            DataTable dt_check = new DataTable();
            da_check.Fill(dt_check);
            if (dt_check.Rows.Count > 0)
            {
                ch = true;
            }
            da_check.Dispose();
            return ch;
        }

    }
}
