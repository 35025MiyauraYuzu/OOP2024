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
                Auter = cbAuther.Text,
                Maker = GetRedioButtonMaker(),
                CarName = cbCarname.Text,
                Report = tbReport.Text,
                Picture = pbPicture.Image,

            };
            listCarReports.Add(carReport);

        }
        //選択されているメーカー名を列挙型で返す
        private CarReport.MakerGroup GetRedioButtonMaker() {
            if (rbToyota.Checked) {
                return CarReport.MakerGroup.トヨタ;
            }
            if (rbNissan.Checked) {
                return CarReport.MakerGroup.日産;
            }
            if (rbHonda.Checked) {
                return CarReport.MakerGroup.ホンダ;
            }
            if (rbSubaru.Checked) {
                return CarReport.MakerGroup.スバル;
            }
            if (rbOther.Checked) {
                return CarReport.MakerGroup.輸入車;
            } else

                return CarReport.MakerGroup.その他;

        }

        private void rbHonda_CheckedChanged(object sender, EventArgs e) {

        }
    }
}
