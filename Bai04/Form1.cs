namespace Bai04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cdg = new ColorDialog();
            cdg.ShowDialog();
            BackColor = cdg.Color;
        }

    }
}
