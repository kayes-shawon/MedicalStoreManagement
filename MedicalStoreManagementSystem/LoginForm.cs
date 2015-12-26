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

namespace MedicalStoreManagementSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Server=KAYES-PC\\SQLEXPRESS;Initial Catalog=medicalstoremanagement;Integrated Security=True;");
            //"Data Source=KRISHNA-PC\\SQLEXPRESS;Initial Catalog=STUDENT;Integrated Security=True"
            SqlDataAdapter sda = new SqlDataAdapter("Select Role from login_table Where Username='"+ userNameTextBox.Text +"'and Password='"+ passwordTextBox.Text +"'",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                AdminOption admin1 = new AdminOption();
                admin1.Show();
                this.Hide();
            }

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
