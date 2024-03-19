using System.ComponentModel;

namespace Odev3
{
    public partial class Form1 : Form
    {
        int timeCounter = 0, x = 10, y = 10;
        bool isGameRunning = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeCounter++;
            timeValue.Text = (timeCounter / 10).ToString();
            if (ball.Location.X + ball.Width >= rightEdge.Location.X - 2 || ball.Location.X <= leftEdge.Location.X + leftEdge.Width + 10)
                x = -x;
            if (ball.Location.Y <= topEdge.Location.Y + topEdge.Height + 2)
                y = -y;
            if (ball.Location.Y + ball.Height >= bottomEdge.Location.Y - 2){
                timer1.Stop();
                isGameRunning = false;
                startBtn.Text = "Başlat";
                ball.Location = new Point(370, 220);
                timeCounter = 0;
                timeValue.Text = "0";
                hitCountValue.Text = "0";
                remainingLifeValue.Text = (int.Parse(remainingLifeValue.Text) - 1).ToString();
            } else if (ball.Location.Y + ball.Height + 5 == bar.Location.Y && 
                (
                    ball.Location.X + ball.Width >= bar.Location.X &&
                    ball.Location.X <= bar.Location.X + bar.Width + 2
                ))
            {
                y = -y;
                hitCountValue.Text = (int.Parse(hitCountValue.Text) + 1).ToString();
            }
            if (remainingLifeValue.Text == "0")
            {
                timer1.Stop();
                MessageBox.Show("Canınız bitti! Toplam süre: " + timeValue.Text + " saniye");
                Application.Exit();
            }
            ball.Location = new Point(ball.Location.X + x, ball.Location.Y + y);
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            if (!isGameRunning)
            {
                timer1.Start();
                isGameRunning = true;
                startBtn.Text = "Durdur";
            } else
            {
                timer1.Stop();
                isGameRunning = false;
                startBtn.Text = "Başlat";
            }
        }

        private void Form1_Load(object sender, EventArgs e){
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            int barX = e.X - bar.Width / 2;
            if (barX < leftEdge.Location.X + leftEdge.Width)
                barX = leftEdge.Location.X + leftEdge.Width;
            if (barX + bar.Width > rightEdge.Location.X)
                barX = rightEdge.Location.X - bar.Width;
            bar.Location = new Point(barX, bar.Location.Y);
        }
    }
}
