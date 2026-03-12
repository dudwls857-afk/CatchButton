namespace CatchButton
{
    public partial class Form1 : Form
    {
        int score = 0;
        int missCount = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            score += 100;
            MessageBox.Show("축하합니다~!");
            this.Text = $"점수 : {score}";
            Target.Width = (int)(Target.Width * 0.9);
            Target.Height = (int)(Target.Height * 0.9);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Reset.Visible = false;
           
            score = 0;
            missCount = 0;

            Target.Enabled = true;
            this.Text = $"점수:{score}/놓친횟수:{missCount}";
        }

        private void Target_MouseEnter(object sender, EventArgs e)
        {
            // 1. 난수생성기준비
            Random rd = new Random();

            // 2. 가용영역계산(버튼이폼테두리에걸리지않게보호)
            // ClientSize는타이틀바와테두리를제외한실제흰도화지영역임
            int maxX = this.ClientSize.Width - Target.Width;
            int maxY = this.ClientSize.Height - Target.Height;

            // 3. 랜덤좌표추출(0 ~ 최대가용치사이)
            int nextX = rd.Next(0, maxX);
            int nextY = rd.Next(0, maxY);

            // 4. 위치할당(새로운Point 객체생성)
            Target.Location = new Point(nextX, nextY);
            score -= 10;
            missCount += 1;
            this.Text = "점수: {score} / 놓친 횟수:{missCount} ";
            if (missCount >= 20)
            {
                MessageBox.Show("Game Over");
                Target.Enabled = false;
                Reset.Visible = true;
            }
            // 소리 출력
            System.Media.SystemSounds.Beep.Play();

            // 5. 시각적피드백(폼제목표시줄에좌표출력)
            this.Text = $"버튼위치: ({nextX}, {nextY})";
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            score = 0;
            missCount = 0;

            Target.Enabled = true;
            Target.Width = 400;
            Target.Height = 300;

            Target.Location = new Point(100, 100);

            this.Text = $"점수:{score} / 놓친 횟수:{missCount}";

        }

        private void Reset_Click_1(object sender, EventArgs e)
        {
            score = 0;
            missCount = 0;

            Target.Enabled = true;
            Target.Width = 400;
            Target.Height = 300;

            Target.Location = new Point(100, 100);

            this.Text = $"점수:{score} / 놓친 횟수:{missCount}";
        }
    }
}
