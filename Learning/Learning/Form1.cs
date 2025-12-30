using System.Drawing;
using System.Windows.Forms;

namespace Learning
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color Black = Color.FromArgb(255, 0, 0, 0);

            Pen pen = new Pen(Black, width: 10);

            PointF[] Lines = {
                new PointF(x: 10, y: 50), new PointF(x: 100, y: 200),
                new PointF(x: 300, y: 200), new PointF(x: 200, y: 50),
                new PointF(x: 10, y: 50), new PointF(x: 100, y: 200),
            };

            e.Graphics.DrawLines(pen, Lines);


        }

    }
}
