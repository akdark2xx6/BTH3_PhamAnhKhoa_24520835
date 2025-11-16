namespace Bai06
{
    public partial class Form1 : Form
    {
        static double mc = 0;
        static bool isCE = false;
        static bool isResult = false;
        static double beforeValue = 0;
        static char op = 'n';
        public Form1()
        {
            InitializeComponent();
        }
        static double returnInput(string h)
        {
            return Convert.ToDouble(h);
        }
        private void C_Click(object sender, EventArgs e)
        {
            isResult = false;
            beforeValue = 0;
            textBox1.Text = "0";
            op = 'n';
        }
        private void CE_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            isCE = true;
        }

        private void one_Click(object sender, EventArgs e)
        {
            if (returnInput(textBox1.Text) == 0 && textBox1.Text.Length < 2 || isResult == true)
            {
                textBox1.Text = "1";
                isResult = false;
            }
            else
                textBox1.Text += '1';
        }

        private void two_Click(object sender, EventArgs e)
        {
            if (returnInput(textBox1.Text) == 0 && textBox1.Text.Length < 2 || isResult == true)
            {
                textBox1.Text = "2";
                isResult = false;
            }
            else
                textBox1.Text += '2';
        }

        private void three_Click(object sender, EventArgs e)
        {
            if (returnInput(textBox1.Text) == 0 && textBox1.Text.Length < 2 || isResult == true)
            {
                textBox1.Text = "3";
                isResult = false;
            }
            else
                textBox1.Text += '3';
        }

        private void four_Click(object sender, EventArgs e)
        {
            if (returnInput(textBox1.Text) == 0 && textBox1.Text.Length < 2 || isResult == true)
            {
                textBox1.Text = "4";
                isResult = false;
            }
            else
                textBox1.Text += '4';
        }

        private void five_Click(object sender, EventArgs e)
        {
            if (returnInput(textBox1.Text) == 0 && textBox1.Text.Length < 2 || isResult == true)
            {
                textBox1.Text = "5";
                isResult = false;
            }
            else
                textBox1.Text += '5';
        }

        private void six_Click(object sender, EventArgs e)
        {
            if (returnInput(textBox1.Text) == 0 && textBox1.Text.Length < 2 || isResult == true)
            {
                textBox1.Text = "6";
                isResult = false;
            }
            else
                textBox1.Text += '6';
        }

        private void seven_Click(object sender, EventArgs e)
        {
            if (returnInput(textBox1.Text) == 0 && textBox1.Text.Length < 2 || isResult == true)
            {
                textBox1.Text = "7";
                isResult = false;
            }
            else
                textBox1.Text += '7';
        }

        private void eight_Click(object sender, EventArgs e)
        {
            if (returnInput(textBox1.Text) == 0 && textBox1.Text.Length < 2 || isResult == true)
            {
                textBox1.Text = "8";
                isResult = false;
            }
            else
                textBox1.Text += '8';
        }

        private void nine_Click(object sender, EventArgs e)
        {
            if (returnInput(textBox1.Text) == 0 && textBox1.Text.Length < 2 || isResult == true)
            {
                textBox1.Text = "9";
                isResult = false;
            }
            else
                textBox1.Text += '9';
        }

        private void zero_Click(object sender, EventArgs e)
        {
            if (returnInput(textBox1.Text) == 0 && textBox1.Text.Length < 2 || isResult == true)
            {
                textBox1.Text = "0";
                isResult = false;
            }
            else
                textBox1.Text += '0';
        }

        private void phay_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.IndexOf(',') != -1)
                return;
            textBox1.Text += ',';
        }

        private void Backspace_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            isResult = true;
            double afterValue = returnInput(textBox1.Text);
            switch (op)
            {
                case '+': beforeValue = beforeValue + afterValue; break;
                case '-': beforeValue = beforeValue - afterValue; break;
                case '*': beforeValue = beforeValue * afterValue; break;
                case '/':
                    if (afterValue == 0)
                    {
                        MessageBox.Show("Không thể chia cho 0!");
                        textBox1.Text = "0";
                        return;
                    }
                    beforeValue = beforeValue / afterValue;
                    break;
                case 'n': beforeValue = afterValue; break;
            }
            textBox1.Text = beforeValue.ToString();
            isCE = false;
            op = 'n';
        }

        private void negative_Click(object sender, EventArgs e)
        {
            textBox1.Text = (returnInput(textBox1.Text) * -1).ToString();
        }

        private void cong_Click(object sender, EventArgs e)
        {
            if (op != 'n' && isResult == false)
            {
                calculate_Click(sender, e);
                cong_Click(sender, e);
            }

            op = '+';
            if (isCE == false)
                beforeValue = returnInput(textBox1.Text);
            isResult = true;
        }

        private void tru_Click(object sender, EventArgs e)
        {
            if (op != 'n' && isResult == false)
            {
                calculate_Click(sender, e);
                tru_Click(sender, e);
            }
            op = '-';
            if (isCE == false)
                beforeValue = returnInput(textBox1.Text);
            isResult = true;
        }

        private void nhan_Click(object sender, EventArgs e)
        {
            if (op != 'n' && isResult == false)
            {
                calculate_Click(sender, e);
                nhan_Click(sender, e);
            }
            op = '*';
            if (isCE == false)
                beforeValue = returnInput(textBox1.Text);
            isResult = true;
        }

        private void chia_Click(object sender, EventArgs e)
        {
            if (op != 'n' && isResult == false)
            {
                calculate_Click(sender, e);
                chia_Click(sender, e);
            }
            op = '/';
            if (isCE == false)
                beforeValue = returnInput(textBox1.Text);
            isResult = true;
        }

        private void nghichdao_Click(object sender, EventArgs e)
        {
            if (returnInput(textBox1.Text) == 0)
            {
                MessageBox.Show("Không thể chia cho 0!");
                textBox1.Text = "0";
                return;
            }
            beforeValue = 1 / returnInput(textBox1.Text);
            if (isCE == false)
                textBox1.Text = beforeValue.ToString();
            isResult = true;
        }

        private void percent_Click(object sender, EventArgs e)
        {
            textBox1.Text = (returnInput(textBox1.Text) / 100).ToString();
            isResult = true;
        }

        private void sqrt_Click(object sender, EventArgs e)
        {
            beforeValue = returnInput(textBox1.Text) * returnInput(textBox1.Text);
            textBox1.Text = beforeValue.ToString();
            isResult = true;
        }

        private void MC_Click(object sender, EventArgs e)
        {
            mc = 0;
        }

        private void MR_Click(object sender, EventArgs e)
        {
            textBox1.Text = mc.ToString();
            isResult = true;
        }

        private void MS_Click(object sender, EventArgs e)
        {
            mc = returnInput(textBox1.Text);

        }

        private void M_Plus_Click(object sender, EventArgs e)
        {
            mc += returnInput(textBox1.Text);

        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox1.Text);
        }
    }
}

