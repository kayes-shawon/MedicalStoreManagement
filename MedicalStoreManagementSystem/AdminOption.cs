using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalStoreManagementSystem
{
    public partial class AdminOption : Form
    {
        public AdminOption()
        {
            InitializeComponent();
        }

        private void dealerManagementButton_Click(object sender, EventArgs e)
        {
            //AddDealerUI dm = new AddDealerUI();
            DealerManagementUI dm = new DealerManagementUI();
            dm.Show();
            this.Hide();
        }

        private void signoutButton_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
            //Practise ps = new Practise();
           // ps.Show();
        }

        private void medicineManagementButton_Click(object sender, EventArgs e)
        {
            MedicineManagementUI mc = new MedicineManagementUI();
            mc.Show();
            this.Hide();
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            ReportOption rp = new ReportOption();
            rp.Show();
            this.Hide();
        }

        
    }
}
