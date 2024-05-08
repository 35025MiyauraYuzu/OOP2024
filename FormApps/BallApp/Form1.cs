namespace BallApp {
    public partial class Form1 : Form {
        SoccerBall soccerBall;
        PictureBox pb;
        TennisBall tennisBall;

        //コンストラクタ
        public Form1() {
            InitializeComponent();
        }

        //フォームが最初にロードされるとき一度だけ実行される
        private void Form1_Load(object sender, EventArgs e) {
            this.BackColor = Color.Aqua;
        }

        private void timer1_Tick(object sender, EventArgs e) {

            if (pb.Image == soccerBall.Image) {
                soccerBall.Move();
                pb.Location = new Point((int)(soccerBall.PosX), (int)(soccerBall.PosY));
            }  else if (pb.Image == tennisBall.Image) {
                tennisBall.Move();
                pb.Location = new Point((int)(tennisBall.PosX), (int)(tennisBall.PosY));
            }

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e) {

            pb = new PictureBox();//画像を表示するコントロール
            pb.Size = new Size(50, 50);

            if (e.Button == MouseButtons.Left) {
                soccerBall = new SoccerBall(e.X, e.Y);
                pb.Image = soccerBall.Image;
                pb.Location = new Point((int)(soccerBall.PosX), (int)(soccerBall.PosY));

            } else if (e.Button == MouseButtons.Right) {
                tennisBall = new TennisBall(e.X, e.Y);
                pb.Image = tennisBall.Image;
                pb.Location = new Point((int)(tennisBall.PosX), (int)(tennisBall.PosY));
            }


            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.Parent = this;

            timer1.Start();
        }
    }
}
