namespace Bai09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox2.Checked = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                {
                    checkBox1.Checked = false;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e) //thêm
        {
            if (textBox1.Text == "" || textBox2.Text == "" || comboBox1.Text == "" || (checkBox1.Checked == false && checkBox2.Checked == false))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin");
                return;
            }
            if (listBox2.Items.Count == 0)
            {
                MessageBox.Show("Chưa chọn môn nào");
                return;
            }
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value != null)
                    if (row.Cells[0].Value.ToString() == textBox1.Text)
                    {
                        row.Cells[1].Value = textBox2.Text;
                        row.Cells[2].Value = comboBox1.Text;
                        row.Cells[3].Value = (checkBox1.Checked == true) ? "Nam" : "Nữ";
                        row.Cells[4].Value = listBox2.Items.Count;
                        MessageBox.Show("Updated");
                        return;
                    }
            }
            dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, comboBox1.Text, (checkBox1.Checked == true) ? "Nam" : "Nữ", listBox2.Items.Count);
            MessageBox.Show("Added");
        }

        private void button1_Click(object sender, EventArgs e)//thêm môn
        {
            if (listBox1.SelectedIndex != -1)
            {
                listBox2.Items.Add(listBox1.SelectedItem);
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void button2_Click(object sender, EventArgs e)//xóa môn
        {
            if (listBox2.SelectedIndex != -1)
            {
                listBox1.Items.Add(listBox2.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Text = null;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            listBox1.Items.Clear();
            listBox1.Items.Add("Cơ sở dữ liệu");
            listBox1.Items.Add("Cơ sở DL NC");
            listBox1.Items.Add("PTTK Hệ Thống thông tin");
            listBox2.Items.Clear();
        }
    }
}
