using System.Globalization;

namespace Exercise01 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Btex81_Click(object sender, EventArgs e) {
            var dete = DateTime.Now;
            tbDisp.Text = DateTime.Now.ToString() + "\r\n";
            tbDisp.Text += DateTime.Now.ToString("yyyy年MM月dd日 hh時mm分ss秒") + "\r\n";
            var culture = new CultureInfo("ja-jp");
            culture.DateTimeFormat.Calendar = new JapaneseCalendar();
            var Week = culture.DateTimeFormat.GetDayName(DateTime.Now.DayOfWeek);
            tbDisp.Text += DateTime.Now.ToString("ggyy年m月d日", culture) + "(" + Week + ")";
        }

        private void BtEx82_Click(object sender, EventArgs e) {

            var dateTime = DateTime.Today;
            foreach (var dayofweek in Enum.GetValues(typeof(DayOfWeek))) {

                var str1 = string.Format("{0:yy/MM/dd}の次週の{1}:", dateTime, (DayOfWeek)dayofweek);
                ;
                var str2 = string.Format("{0:yy/MM/dd}:", NextWeek(dateTime, (DayOfWeek)dayofweek));

                tbDisp.Text += str1 + str2 + "\r\n";
            }


        }

        //第一引数で指定した日付の翌週のインスタンスを返却。
        public static DateTime NextWeek(DateTime date, DayOfWeek dayOfWeek) {
            /* var days = (int)dayOfWeek - (int)(date.DayOfWeek);

             days += 7;

             return date.AddDays(days);*/

            var nextwek = date.AddDays(7);
            var day = (int)dayOfWeek - (int)date.DayOfWeek;
            return nextwek.AddDays(day);

        }

        private void btex8_3_Click(object sender, EventArgs e) {
            var tw = new TimeWatch();
            tw.Start();
            Thread.Sleep(1000);
            TimeSpan duration = tw.Stop();
            var str = string.Format("処理時間は{0}ミリ秒でした", duration.TotalMilliseconds);
            tbDisp.Text += str + "\r\n";

        }
    }
    class TimeWatch {
        private DateTime _Time;

        public void Start() {
            _Time = DateTime.Now;

        }

        public TimeSpan Stop() {
            var stop = DateTime.Now;

            return stop - _Time;
            //return DateTime.Now - _Time; 
        }

    }
}
