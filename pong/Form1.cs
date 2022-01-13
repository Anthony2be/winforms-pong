namespace pong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            inputbox.KeyDown += Inputbox_KeyDown;
            timer1.Start();
        }

        private void Inputbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                pong1.Location = new Point(pong1.Location.X, pong1.Location.Y - 10);
            }
            if (e.KeyCode == Keys.S)
            {
                pong1.Location = new Point(pong1.Location.X, pong1.Location.Y + 10);
            }
            if (e.KeyCode == Keys.Up)
            {
                pong2.Location = new Point(pong2.Location.X, pong2.Location.Y - 10);
            }
            if (e.KeyCode == Keys.Down)
            {
                pong2.Location = new Point(pong2.Location.X, pong2.Location.Y + 10);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (ball.Location.X >= pong2.Location.X-40 && ball.Location.Y >= pong2.Location.Y && ball.Location.Y <= pong2.Location.Y + 142)
            {
                Globals.ballX = -5;
            }

            if (ball.Location.X <= pong1.Location.X + 40 && ball.Location.Y >= pong1.Location.Y && ball.Location.Y <= pong1.Location.Y + 142)
            {
                Globals.ballX = 5;
            }

            if (ball.Location.X < 0)
            {
                ball.Location = new Point(110, 195);
                Globals.score2++;
                score2.Text = $"Score: {Globals.score2}";
                Globals.ballX = 5;
            }
            if (ball.Location.Y < 0)
            {
                Globals.ballY = 5;
            }
            if (ball.Location.X > this.Width-50)
            {
                ball.Location = new Point(671, 195);
                Globals.score1++;
                score1.Text = $"Score: {Globals.score1}";
                Globals.ballX = -5;
            }
            if (ball.Location.Y > this.Height-95)
            {
                Globals.ballY = -5;
            }
            ball.Location = new Point(ball.Location.X + Globals.ballX, ball.Location.Y + Globals.ballY);
        }

        public static class Globals
        {
            public static int score1 = 0;
            public static int score2 = 0;
            public static int ballY = -5;
            public static int ballX = 5;
        }
    }
}