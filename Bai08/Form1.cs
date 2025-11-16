namespace Bai08
{
    public partial class Form1 : Form
    {
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void them_capnhat_Click(object sender, EventArgs e)
        {
            long Tien;
            if (string.IsNullOrEmpty(textBox1.Text) ||
               string.IsNullOrEmpty(textBox2.Text) ||
               string.IsNullOrEmpty(textBox3.Text) ||
               string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ dữ liệu");
                return;
            }
            else if (!long.TryParse(textBox4.Text, out Tien) || long.Parse(textBox4.Text) <0)
            {
                MessageBox.Show("Số tiền không hợp lệ");
                return;
            }
            foreach (ListViewItem item in listView1.Items)
            {
                if (item.SubItems[1].Text == textBox1.Text)
                {
                    textBox5.Text = (int.Parse(textBox5.Text) - (int.Parse(item.SubItems[4].Text)-int.Parse(textBox4.Text))).ToString();
                    item.SubItems[2].Text = textBox2.Text;
                    item.SubItems[3].Text = textBox3.Text;
                    item.SubItems[4].Text = textBox4.Text;
                    MessageBox.Show("Cập nhật dữ liệu thành công!");
                    return;
                }
            }
            ListViewItem t = new ListViewItem((count + 1).ToString());
            count++;
            t.SubItems.Add(textBox1.Text);
            t.SubItems.Add(textBox2.Text);
            t.SubItems.Add(textBox3.Text);
            t.SubItems.Add(textBox4.Text);
            textBox5.Text = (int.Parse(textBox5.Text) + int.Parse(textBox4.Text)).ToString();
            listView1.Items.Add(t);
            MessageBox.Show("Thêm mới dữ liệu thành công!");
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                textBox1.Text = listView1.SelectedItems[0].SubItems[1].Text;
                textBox2.Text = listView1.SelectedItems[0].SubItems[2].Text;
                textBox3.Text = listView1.SelectedItems[0].SubItems[3].Text;
                textBox4.Text = listView1.SelectedItems[0].SubItems[4].Text;

            }
        }

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                them_capnhat_Click(sender, e);
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (ListViewItem item in listView1.Items)
            {
                if (item.SubItems[1].Text == textBox1.Text)
                {
                    DialogResult = MessageBox.Show("Bạn có muốn xóa tài khoản này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question); ;
                    if (DialogResult == DialogResult.Yes)
                    {
                        textBox5.Text = (int.Parse(textBox5.Text) - int.Parse(textBox4.Text)).ToString();
                        listView1.Items.RemoveAt(count);
                        MessageBox.Show("Xóa tài khoản thành công");
                    }
                    return;
                }
            }
            MessageBox.Show("Không tìm thấy số tài khoản cần xóa");
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
