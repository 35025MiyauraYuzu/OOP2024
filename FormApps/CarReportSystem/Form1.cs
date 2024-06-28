using System.ComponentModel;

namespace CarReportSystem {
    public partial class Form1 : Form {


        BindingList<CarReport> listCarReports = new BindingList<CarReport>();

        //�R���X�g���N�^�[
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
        //�I������Ă��郁�[�J�[����񋓌^�ŕԂ�
        private CarReport.MakerGroup GetRedioButtonMaker() {
            if (rbToyota.Checked) {
                return CarReport.MakerGroup.�g���^;
            }
            if (rbNissan.Checked) {
                return CarReport.MakerGroup.���Y;
            }
            if (rbHonda.Checked) {
                return CarReport.MakerGroup.�z���_;
            }
            if (rbSubaru.Checked) {
                return CarReport.MakerGroup.�X�o��;
            }
            if (rbOther.Checked) {
                return CarReport.MakerGroup.�A����;
            } else

                return CarReport.MakerGroup.���̑�;

        }

        private void rbHonda_CheckedChanged(object sender, EventArgs e) {

        }
    }
}
