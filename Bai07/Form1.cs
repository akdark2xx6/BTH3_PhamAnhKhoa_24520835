
namespace Bai07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonA_Click(object sender, EventArgs e)
        {
            if (sender is Control ctrl)
            {
                Button but = (Button)sender;
                if (but.BackColor == SystemColors.Control)
                    but.BackColor = Color.Blue;
                else if (but.BackColor == Color.Blue)
                    but.BackColor = SystemColors.Control;
                else MessageBox.Show("Ghế đã được đặt");
            }
        }
        private void chon_Click(object sender, EventArgs e)
        {
            int Tien = 0;
            foreach (Control ctrl in gheNgoi.Controls)
            {
                if (ctrl is Button button && ctrl.BackColor == Color.Blue)
                {
                    ctrl.BackColor = Color.Yellow;
                    if (int.Parse(ctrl.Text) < 6)
                        Tien += 5000;
                    else if (int.Parse(ctrl.Text) < 11)
                        Tien += 6500;
                    else
                        Tien += 8000;

                }
            }
            if (Tien == 0)
                MessageBox.Show("Chưa chọn ghế nào");
            else
                textBox1.Text = Tien.ToString();
        }

        private void huybo_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in gheNgoi.Controls)
            {
                if (ctrl is Button button && ctrl.BackColor == Color.Blue)
                {
                    ctrl.BackColor = SystemColors.Control;
                }
            }
            textBox1.Text = "0";
        }

        private void ketthuc_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
