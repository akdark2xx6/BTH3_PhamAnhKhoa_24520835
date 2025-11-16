namespace Bai05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Cong_Click(object sender, EventArgs e)
        {
            Number1.Text=Number1.Text.Replace('.', ',');
            Number2.Text=Number2.Text.Replace('.', ',');
            double a, b;
            if (!double.TryParse(Number1.Text, out a) || !double.TryParse(Number2.Text, out b))
            {
                MessageBox.Show("Gia tri khong hop le, vui long nhap lai");
                textAnswer.Text.DefaultIfEmpty();
                return;
            }
            textAnswer.Text = (a+b).ToString();
        }

        private void Tru_Click(object sender, EventArgs e)
        {
            Number1.Text=Number1.Text.Replace('.', ',');
            Number2.Text=Number2.Text.Replace('.', ',');
            double a, b;
            if (!double.TryParse(Number1.Text, out a) || !double.TryParse(Number2.Text, out b))
            {
                MessageBox.Show("Gia tri khong hop le, vui long nhap lai");
                textAnswer.Text.DefaultIfEmpty();
                return;
            }
            textAnswer.Text = (a - b).ToString();
        }

        private void Nhan_Click(object sender, EventArgs e)
        {
            Number1.Text=Number1.Text.Replace('.', ',');
            Number2.Text=Number2.Text.Replace('.', ',');
            double a, b;
            if (!double.TryParse(Number1.Text, out a) || !double.TryParse(Number2.Text, out b))
            {
                MessageBox.Show("Gia tri khong hop le, vui long nhap lai");
                textAnswer.Text.DefaultIfEmpty();
                return;
            }
            textAnswer.Text = (a * b).ToString();
        }

        private void Chia_Click(object sender, EventArgs e)
        {
            Number1.Text=Number1.Text.Replace('.', ',');
            Number2.Text=Number2.Text.Replace('.', ',');
            double a, b;
            if (!double.TryParse(Number1.Text, out a) || !double.TryParse(Number2.Text, out b))
            {
                MessageBox.Show("Gia tri khong hop le, vui long nhap lai");
                textAnswer.Text.DefaultIfEmpty();
                return;
            }
            textAnswer.Text = (a / b).ToString();
        }
    }
}
