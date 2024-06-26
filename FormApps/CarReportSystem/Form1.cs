using System.ComponentModel;

namespace CarReportSystem {
    public partial class Form1 : Form {


        BindingList<CarReport> listCarReports = new BindingList<CarReport>();

        //コンストラクター
        public Form1() {
            InitializeComponent();
            dgvCarReport.DataSource = listCarReports;
        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void dgvCarReport_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void tbReport_TextChanged(object sender, EventArgs e) {

        }

        private void btAddreport_Click(object sender, EventArgs e) {
            CarReport carReport = new CarReport {
                Date = dtpDate.Value,
            };
            listCarReports.Add(carReport);

        }
    }
}
