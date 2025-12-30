using System;
using System.Drawing;
using System.Windows.Forms;
using X_O_Game.Properties;
using static Player;
enum Player { X, O };

namespace X_O_Game
{



    public partial class Form1 : Form
    {



        string PlayerXWin = "Player 1 Wins (X)";
        string PlayerOWin = "Player 2 Wins (O)";

        string PlayerXTurn = "Player 1 Turn (X)";
        string PlayerOTurn = "Player 2 Turn (O)";

        Player CurrentPlayer = X;
        enum enResult { GameIsInProgress, Win, Draw };

        struct stGameStatus
        {
            public enResult Result;
            public byte PlayCount;
        }
        stGameStatus GameStatus;





        public Form1()
        {
            InitializeComponent();

        }
        private void Group1_Paint(object sender, PaintEventArgs e)
        {



            e.Graphics.Clear(BackColor); // Clears the background


            Pen pen = new Pen(Color.White, width: 10);
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;


            e.Graphics.DrawLine(pen, new PointF(150, 10), new PointF(150, 350));
            e.Graphics.DrawLine(pen, new PointF(300, 10), new PointF(300, 350));

            e.Graphics.DrawLine(pen, new PointF(50, 120), new PointF(400, 120));
            e.Graphics.DrawLine(pen, new PointF(50, 240), new PointF(400, 240));


        }
        private void TurnBoxesGreen(PictureBox B1, PictureBox B2, PictureBox B3)
        {
            B1.BackColor = Color.Green;
            B2.BackColor = Color.Green;
            B3.BackColor = Color.Green;
        }
        private void CheckValues(PictureBox B1, PictureBox B2, PictureBox B3)
        {
            string B1String = B1.Tag.ToString();
            string B2String = B2.Tag.ToString();
            string B3String = B3.Tag.ToString();

            if (B1String != "?" && B1String == B2String && B1String == B3String)
            {
                TurnBoxesGreen(B1, B2, B3);

                if (B1String == "X")
                    labelPlayerWon.Text = PlayerXWin;
                else
                    labelPlayerWon.Text = PlayerOWin;

            }

        }

        private void ChoiceButton_CLick(object sender, System.EventArgs e)
        {

            if (GameStatus.Result == enResult.Draw || GameStatus.Result == enResult.Win)
            {
                return;
            }

            PictureBox picBox = (PictureBox)sender;
            if (picBox.Tag.ToString() != "?")
            {
                return;
            }

            if (CurrentPlayer == X)
            {
                picBox.Tag = CurrentPlayer.ToString();
                picBox.Image = Resources.X;
                CurrentPlayer = O;
                labelPlayerTurn.Text = PlayerOTurn;
            }
            else
            {
                picBox.Tag = CurrentPlayer.ToString();
                picBox.Image = Resources.O;
                CurrentPlayer = X;
                labelPlayerTurn.Text = PlayerXTurn;
            }

            CheckValues(pb1, pb2, pb3);
            CheckValues(pb4, pb5, pb6);
            CheckValues(pb7, pb8, pb9);


            CheckValues(pb1, pb4, pb7);
            CheckValues(pb2, pb5, pb8);
            CheckValues(pb3, pb6, pb9);


            CheckValues(pb1, pb5, pb9);
            CheckValues(pb3, pb5, pb7);


            GameStatus.PlayCount--;

            if (GameStatus.PlayCount == 0 && GameStatus.Result != enResult.Win)
            {
                GameStatus.Result = enResult.Draw;
                labelPlayerWon.Text = "Draw";
                labelPlayerTurn.Text = "Game Over";
            }

        }

        private void labelPlayerWon_TextChanged(object sender, EventArgs e)
        {
            if (labelPlayerWon.Text != "" && labelPlayerWon.Text != "Draw")
            {
                GameStatus.Result = enResult.Win;
                labelPlayerTurn.Text = "Game Over";
            }
        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            GameStatus.Result = enResult.GameIsInProgress;

            GameStatus.PlayCount = 9;
            labelPlayerTurn.Text = PlayerXTurn;
            CurrentPlayer = X;
            labelPlayerWon.Text = "";

            foreach (PictureBox picBox in groupBox1.Controls)
            {
                picBox.Tag = "?";
                picBox.BackColor = Color.Black;
                picBox.Image = Resources.question_mark_96;
            }

        }
    }
}
