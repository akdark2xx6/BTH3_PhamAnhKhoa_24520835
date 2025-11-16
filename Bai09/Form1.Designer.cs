namespace Bai09
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            listBox2 = new ListBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            listBox1 = new ListBox();
            label5 = new Label();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            label4 = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            MSSV = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listBox2);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(listBox1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(653, 353);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sinh viên";
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(368, 211);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(217, 79);
            listBox2.TabIndex = 18;
            // 
            // button4
            // 
            button4.Location = new Point(354, 310);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 17;
            button4.Text = "Xóa chọn";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(212, 310);
            button3.Name = "button3";
            button3.Size = new Size(109, 23);
            button3.TabIndex = 16;
            button3.Text = "Lưu thông tin";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(318, 254);
            button2.Name = "button2";
            button2.Size = new Size(33, 31);
            button2.TabIndex = 15;
            button2.Text = "<";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(318, 218);
            button1.Name = "button1";
            button1.Size = new Size(33, 31);
            button1.TabIndex = 14;
            button1.Text = ">";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Items.AddRange(new object[] { "Cơ Sở Dữ Liệu", "Cơ Sở DL NC", "PTTK Hệ Thống thông tin" });
            listBox1.Location = new Point(84, 211);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(217, 79);
            listBox1.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(81, 176);
            label5.Name = "label5";
            label5.Size = new Size(158, 15);
            label5.TabIndex = 1;
            label5.Text = "Chọn các môn học tham gia";
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(325, 145);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(42, 19);
            checkBox2.TabIndex = 12;
            checkBox2.Text = "Nữ";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(269, 145);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(52, 19);
            checkBox1.TabIndex = 11;
            checkBox1.Text = "Nam";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(187, 145);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 10;
            label4.Text = "Giới tính";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Hệ thống thông tin", "Khoa học máy tính", "Kĩ thuật máy tính", "Kĩ thuật phần mềm", "An toàn thông tin", "Công nghệ thông tin" });
            comboBox1.Location = new Point(240, 111);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(235, 23);
            comboBox1.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(154, 114);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 8;
            label3.Text = "Chuyên ngành";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(196, 85);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 7;
            label2.Text = "Họ tên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(202, 56);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 6;
            label1.Text = "MSSV";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(240, 82);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(235, 23);
            textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(240, 53);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(235, 23);
            textBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { MSSV, Column2, Column3, Column4, Column5 });
            dataGridView1.Location = new Point(12, 371);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(653, 258);
            dataGridView1.TabIndex = 1;
            // 
            // MSSV
            // 
            MSSV.HeaderText = "MSSV";
            MSSV.Name = "MSSV";
            // 
            // Column2
            // 
            Column2.HeaderText = "Họ tên";
            Column2.Name = "Column2";
            Column2.Width = 150;
            // 
            // Column3
            // 
            Column3.HeaderText = "Chuyên ngành";
            Column3.Name = "Column3";
            Column3.Width = 180;
            // 
            // Column4
            // 
            Column4.HeaderText = "Giới tính";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Số môn";
            Column5.Name = "Column5";
            Column5.Width = 83;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(676, 641);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Label label4;
        private ComboBox comboBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private ListBox listBox1;
        private Label label5;
        private ListBox listBox2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn MSSV;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}
