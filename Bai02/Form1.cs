using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bai02
{
    public partial class Form1 : Form
    {
        private Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
            this.Activated += (s, e) => this.Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.Clear(Color.White);

            int x = rand.Next(0, this.ClientSize.Width);
            int y = rand.Next(0, this.ClientSize.Height);
            Color color = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));

            using (Font f = new Font("Microsoft Sans Serif", 20))
            using (SolidBrush brush = new SolidBrush(color))
            {
                g.DrawString("Paint Event", f, brush, new Point(x, y));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Invalidate();
        }
    }
}
