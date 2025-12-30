using System;
using System.Drawing;
using System.Windows.Forms;
using X_O_Game.Properties;
using static XandO;
enum XandO { X, O, None };

namespace X_O_Game
{



    public partial class Form1 : Form
    {
        bool GameOver = false;
        bool Draw = false;
        string PlayerXWin = "Player 1 Wins (X)";
        string PlayerOWin = "Player 2 Wins (O)";

        string PlayerXTurn = "Player 1 Turn (X)";
        string PlayerOTurn = "Player 2 Turn (O)";


        XandO[,] XAndOMap = {
                {None,None,None},
                {None,None,None},
                {None,None,None},
            };
        XandO CurrentPlayer = X;


        private void DrawMap()
        {

            for (byte i = 0; i < 3; i++)
            {
                for (byte j = 0; j < 3; j++)
                {

                    Control[] controls = groupBox1.Controls.Find("pb" + i + j, false);
                    PictureBox picBox = (PictureBox)controls[0];

                    switch (XAndOMap[i, j])
                    {
                        case X:
                            picBox.Image = Resources.X;
                            break;
                        case O:
                            picBox.Image = Resources.O;
                            break;
                        case None:
                            picBox.Image = Resources.question_mark_96;
                            break;

                    }
                }
            }

        }
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

            DrawMap();
        }
        private PictureBox IndexTubleToPictureBox(byte[] index)
        {
            Control[] controls = groupBox1.Controls.Find("pb" + index[0] + index[1], false);
            return (PictureBox)controls[0];
        }
        private void TurnBoxesGreen(byte[] index1, byte[] index2, byte[] index3)
        {
            IndexTubleToPictureBox(index1).BackColor = Color.Green;
            IndexTubleToPictureBox(index2).BackColor = Color.Green;
            IndexTubleToPictureBox(index3).BackColor = Color.Green;


        }
        private void CheckDiagonally()
        {
            if (XAndOMap[0, 0] == X && XAndOMap[1, 1] == X && XAndOMap[2, 2] == X)
            {
                labelPlayerWon.Text = PlayerXWin;
                TurnBoxesGreen(new byte[] { 0, 0 }, new byte[] { 1, 1 }, new byte[] { 2, 2 });
            }
            else if (XAndOMap[0, 2] == X && XAndOMap[1, 1] == X && XAndOMap[2, 0] == X)
            {
                labelPlayerWon.Text = PlayerXWin;
                TurnBoxesGreen(new byte[] { 0, 2 }, new byte[] { 1, 1 }, new byte[] { 2, 0 });
            }

            else if (XAndOMap[0, 0] == O && XAndOMap[1, 1] == O && XAndOMap[2, 2] == O)
            {
                labelPlayerWon.Text = PlayerOWin;
                TurnBoxesGreen(new byte[] { 0, 0 }, new byte[] { 1, 1 }, new byte[] { 2, 2 });
            }

            else if (XAndOMap[0, 2] == O && XAndOMap[1, 1] == O && XAndOMap[2, 0] == O)
            {
                labelPlayerWon.Text = PlayerOWin;
                TurnBoxesGreen(new byte[] { 0, 2 }, new byte[] { 1, 1 }, new byte[] { 2, 0 });
            }
        }

        private void CheckVertically()
        {

            for (byte i = 0; i < 3; i++)
            {
                if (XAndOMap[0, i] == O && XAndOMap[1, i] == O && XAndOMap[2, i] == O)
                {
                    labelPlayerWon.Text = PlayerOWin;
                    TurnBoxesGreen(new byte[] { 0, i }, new byte[] { 1, i }, new byte[] { 2, i });
                }
                else if (XAndOMap[0, i] == X && XAndOMap[1, i] == X && XAndOMap[2, i] == X)
                {
                    labelPlayerWon.Text = PlayerXWin;
                    TurnBoxesGreen(new byte[] { 0, i }, new byte[] { 1, i }, new byte[] { 2, i });
                }
            }
        }
        private void CheckHorozontally()
        {

            for (byte i = 0; i < 3; i++)
            {
                if (XAndOMap[i, 0] == O && XAndOMap[i, 1] == O && XAndOMap[i, 2] == O)
                {
                    labelPlayerWon.Text = PlayerOWin;
                    TurnBoxesGreen(new byte[] { i, 0 }, new byte[] { i, 1 }, new byte[] { i, 2 });
                }
                else if (XAndOMap[i, 0] == X && XAndOMap[i, 1] == X && XAndOMap[i, 2] == X)
                {
                    labelPlayerWon.Text = PlayerXWin;
                    TurnBoxesGreen(new byte[] { i, 0 }, new byte[] { i, 1 }, new byte[] { i, 2 });
                }
            }
        }

        private void ChoiceButton_CLick(object sender, System.EventArgs e)
        {

            if (GameOver || Draw)
            {
                return;
            }

            PictureBox picBox = (PictureBox)sender;
            string IndexString = picBox.Name.Remove(0, 2);

            byte i = Convert.ToByte(Convert.ToString(IndexString[0]));
            byte j = Convert.ToByte(Convert.ToString(IndexString[1]));





            if (CurrentPlayer == X)
            {
                XAndOMap[i, j] = X;
                CurrentPlayer = O;
                labelPlayerTurn.Text = PlayerOTurn;
            }
            else
            {
                XAndOMap[i, j] = O;
                CurrentPlayer = X;
                labelPlayerTurn.Text = PlayerXTurn;
            }


            DrawMap();

            CheckHorozontally();

            CheckVertically();

            CheckDiagonally();


            byte EmptyBoxes = 0;
            foreach (XandO Box in XAndOMap)
            {
                if (Box == None) EmptyBoxes++;


            }
            if (EmptyBoxes == 0 && !GameOver)
            {
                Draw = true;
                labelPlayerWon.Text = "Draw";
            }

        }

        private void labelPlayerWon_TextChanged(object sender, EventArgs e)
        {
            if (labelPlayerWon.Text != "" && labelPlayerWon.Text != "Draw")
            {
                GameOver = true;
                labelPlayerTurn.Text = "Game Over";
            }
        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            GameOver = false;
            labelPlayerTurn.Text = PlayerXTurn;
            CurrentPlayer = X;
            labelPlayerWon.Text = "";
            foreach (PictureBox picBox in groupBox1.Controls)
            {
                picBox.Image = Resources.question_mark_96;
                picBox.BackColor = Color.Black;
            }

            XAndOMap = new XandO[,] {
                { None,None,None},
                { None,None,None},
                { None,None,None},
            };

            DrawMap();


        }
    }
}
