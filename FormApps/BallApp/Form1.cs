namespace BallApp {
    public partial class Form1 : Form {

        private double posX; //X���W
        private double posY; //Y���W
        private double moveX;//�ړ���(x����)
        private double moveY;//�ړ���(y����)



        //�R���X�g���N�^
        public Form1() {
            InitializeComponent();
            moveX = moveY = 7;
        }


        //�t�H�[�����ŏ��Ƀ��[�h�����Ƃ���x�������s�����
        private void Form1_Load(object sender, EventArgs e) {
            this.BackColor = Color.Aqua;
            timer1.Start();


        }

        private void timer1_Tick(object sender, EventArgs e) {

            if (pbBall.Location.X >= 700||pbBall.Location.X <0) {
                moveX = -moveX;
            }

            if (pbBall.Location.Y >= 500 || pbBall.Location.Y < 0) {
                moveY = -moveY;
            }
            posX += moveX;
            posY += moveY;

            pbBall.Location = new Point((int)posX, (int)posY);
        }
    }
}
