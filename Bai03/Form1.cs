namespace Bai03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int a = r.Next(0, 255);
            int b = r.Next(0, 255);
            int c = r.Next(0, 255);
            BackColor = Color.FromArgb(a, b, c);
        }
    }
}
