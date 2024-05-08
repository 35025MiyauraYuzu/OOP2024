namespace BallApp {
    public partial class Form1 : Form {
       
        PictureBox pb;
        
        Obj obj;

        //コンストラクタ
        public Form1() {
            InitializeComponent();
        }

        //フォームが最初にロードされるとき一度だけ実行される
        private void Form1_Load(object sender, EventArgs e) {
            this.BackColor = Color.Aqua;
        }

        private void timer1_Tick(object sender, EventArgs e) {

                obj.Move();
                pb.Location = new Point((int)(obj.PosX), (int)(obj.PosY));

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e) {

            pb = new PictureBox();//画像を表示するコントロール
            pb.Size = new Size(50, 50);

            if (e.Button == MouseButtons.Left) {
                obj = new SoccerBall(e.X, e.Y);
                pb.Image = obj.Image;
                pb.Location = new Point((int)(obj.PosX), (int)(obj.PosY));

            } else if (e.Button == MouseButtons.Right) {
                obj = new TennisBall(e.X, e.Y);
                pb.Image = obj.Image;
                pb.Location = new Point((int)(obj.PosX), (int)(obj.PosY));
            }


            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.Parent = this;

            timer1.Start();
        }
    }
}
