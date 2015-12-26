using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MedicalStoreManagementSystem.DataAccess;
using System.Data.SqlClient;


namespace MedicalStoreManagementSystem
{
    public partial class MedicineManagementUI : Form
    {
        public MedicineManagementUI()
        {
            InitializeComponent();
        }
        DBConnector con = new DBConnector();
        bool check;

        
        private void MedicineManagementUI_Load(object sender, EventArgs e)
        {
            loadform();
        }

        private void loadform()
        {
            con.LoadMc(this.dataGridView1);
            loadtextbox();
            controlbutton(true);
        }

        private void controlbutton(bool b)
        {
            insertButton.Enabled = updateButton.Enabled = deleteButton.Enabled = b;
            saveButton.Enabled = !b;
            idTextBox.ReadOnly =
                nameTextBox.ReadOnly = priceTextBox.ReadOnly = descriptionTextBox.ReadOnly = b;
        
        }

        private void loadtextbox()
        {

            idTextBox.DataBindings.Clear();
            idTextBox.DataBindings.Add("Text", dataGridView1.DataSource, "id");

            nameTextBox.DataBindings.Clear();
            nameTextBox.DataBindings.Add("Text", dataGridView1.DataSource, "name");

            priceTextBox.DataBindings.Clear();
            priceTextBox.DataBindings.Add("Text", dataGridView1.DataSource, "price");

            descriptionTextBox.DataBindings.Clear();
            descriptionTextBox.DataBindings.Add("Text", dataGridView1.DataSource, "description");

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
                        con.InsertMc(x, nameTextBox.Text, priceTextBox.Text, descriptionTextBox.Text);
                        loadform();
                        MessageBox.Show("Saved Successfully");

                    }

                }
                else
                {
                    con.UpdateMc(Int32.Parse(idTextBox.Text.Trim()), nameTextBox.Text, priceTextBox.Text,
                        descriptionTextBox.Text);
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
            if (DialogResult.Yes == MessageBox.Show("Do You Want To Delete Id '+ idTextBox.Text +'?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                con.DeleteMc(Int32.Parse(idTextBox.Text));
                loadform();

            }
        }


        private bool checkist()
        {
            bool ch = false;
            SqlConnection conn = new SqlConnection("Server=KAYES-PC\\SQLEXPRESS;Initial Catalog=medicalstoremanagement;Integrated Security=True;");
            conn.Open();
            SqlDataAdapter da_check = new SqlDataAdapter("select * from Medicine where id='" + idTextBox.Text + "'", conn);
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
