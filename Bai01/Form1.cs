namespace Bai01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.Text += "Load\n";
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            richTextBox1.Text += "Activated\n";
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            richTextBox1.Text += "Shown\n";
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            richTextBox1.Text += "Deactivate\n";
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            richTextBox1.Text += "FormClosed\n";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            richTextBox1.Text += "FormClosing\n";
            MessageBox.Show("Form đang được đóng");
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            richTextBox1.Text += "FormResize\n";
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "Click\n";
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn có muốn thoát", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Form1_Move(object sender, EventArgs e)
        {
            richTextBox1.Text += "Moving\n";
        }
    }
}
