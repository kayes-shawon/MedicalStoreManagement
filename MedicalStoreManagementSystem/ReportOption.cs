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
    public partial class ReportOption : Form
    {
        public ReportOption()
        {
            InitializeComponent();
        }

        private void dealerButton_Click(object sender, EventArgs e)
        {
            DealerReportUI dr = new DealerReportUI();
            dr.Show();
            this.Hide();
        }
    }
}
