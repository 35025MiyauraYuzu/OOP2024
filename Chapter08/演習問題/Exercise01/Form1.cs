using System.Globalization;

namespace Exercise01 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Btex81_Click(object sender, EventArgs e) {
            var dete =DateTime.Now;
            tbDisp.Text = DateTime.Now.ToString() + "\r\n";
            tbDisp.Text += DateTime.Now.ToString("yyyy”NMMŒŽdd“ú hhŽžmm•ªss•b") + "\r\n";
            var culture = new CultureInfo("ja-jp");
            culture.DateTimeFormat.Calendar = new JapaneseCalendar();
            var Week = culture.DateTimeFormat.GetDayName(DateTime.Now.DayOfWeek);
            tbDisp.Text += DateTime.Now.ToString("ggyy”NmŒŽd“ú", culture) + "(" + Week + ")";
        }

        private void BtEx82_Click(object sender, EventArgs e) {
            
        }
    }
}
