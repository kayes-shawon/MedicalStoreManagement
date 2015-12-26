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
    public partial class DealerReportUI : Form
    {
        public DealerReportUI()
        {
            InitializeComponent();
        }

        private void DealerReportUI_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'medicalstoremanagementDataSet.Dealer_table' table. You can move, or remove it, as needed.
            this.Dealer_tableTableAdapter.Fill(this.medicalstoremanagementDataSet.Dealer_table);

            this.reportViewer1.RefreshReport();
        }
    }
}
