namespace Bai08
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            them_capnhat = new Button();
            xoa = new Button();
            thoat = new Button();
            listView1 = new ListView();
            stt = new ColumnHeader();
            mataikhoan = new ColumnHeader();
            tenkhachhang = new ColumnHeader();
            diachi = new ColumnHeader();
            sotien = new ColumnHeader();
            textBox5 = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(780, 65);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÍ THÔNG TIN TÀI KHOẢN";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(171, 90);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 1;
            label2.Text = "Số tài khoản";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(249, 87);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(418, 23);
            textBox1.TabIndex = 2;
            textBox1.KeyDown += textBox_KeyDown;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Location = new Point(249, 116);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(418, 23);
            textBox2.TabIndex = 4;
            textBox2.KeyDown += textBox_KeyDown;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(153, 119);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 3;
            label3.Text = "Tên khách hàng";
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox3.Location = new Point(249, 145);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(418, 23);
            textBox3.TabIndex = 6;
            textBox3.KeyDown += textBox_KeyDown;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(135, 148);
            label4.Name = "label4";
            label4.Size = new Size(108, 15);
            label4.TabIndex = 5;
            label4.Text = "Địa chỉ khách hàng";
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox4.Location = new Point(249, 174);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(418, 23);
            textBox4.TabIndex = 8;
            textBox4.KeyDown += textBox_KeyDown;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(116, 177);
            label5.Name = "label5";
            label5.Size = new Size(127, 15);
            label5.TabIndex = 7;
            label5.Text = "Số tiền trong tài khoản";
            // 
            // them_capnhat
            // 
            them_capnhat.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            them_capnhat.Location = new Point(358, 211);
            them_capnhat.Name = "them_capnhat";
            them_capnhat.Size = new Size(128, 23);
            them_capnhat.TabIndex = 9;
            them_capnhat.Text = "Thêm/Cập nhật";
            them_capnhat.UseVisualStyleBackColor = true;
            them_capnhat.Click += them_capnhat_Click;
            // 
            // xoa
            // 
            xoa.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            xoa.Location = new Point(501, 211);
            xoa.Name = "xoa";
            xoa.Size = new Size(75, 23);
            xoa.TabIndex = 10;
            xoa.Text = "Xóa";
            xoa.UseVisualStyleBackColor = true;
            xoa.Click += xoa_Click;
            // 
            // thoat
            // 
            thoat.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            thoat.Location = new Point(591, 211);
            thoat.Name = "thoat";
            thoat.Size = new Size(75, 23);
            thoat.TabIndex = 11;
            thoat.Text = "Thoát";
            thoat.UseVisualStyleBackColor = true;
            thoat.Click += thoat_Click;
            // 
            // listView1
            // 
            listView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listView1.Columns.AddRange(new ColumnHeader[] { stt, mataikhoan, tenkhachhang, diachi, sotien });
            listView1.FullRowSelect = true;
            listView1.Location = new Point(12, 248);
            listView1.Name = "listView1";
            listView1.Size = new Size(778, 261);
            listView1.TabIndex = 12;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // stt
            // 
            stt.Text = "STT";
            stt.Width = 40;
            // 
            // mataikhoan
            // 
            mataikhoan.Text = "Mã tài khoản";
            mataikhoan.Width = 150;
            // 
            // tenkhachhang
            // 
            tenkhachhang.Text = "Tên khách hàng";
            tenkhachhang.Width = 200;
            // 
            // diachi
            // 
            diachi.Text = "Địa chỉ";
            diachi.Width = 270;
            // 
            // sotien
            // 
            sotien.Text = "Số tiền";
            sotien.Width = 116;
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox5.Enabled = false;
            textBox5.Location = new Point(633, 515);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(157, 23);
            textBox5.TabIndex = 14;
            textBox5.Text = "0";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(573, 518);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 13;
            label6.Text = "Tổng tiền";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 547);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(listView1);
            Controls.Add(thoat);
            Controls.Add(xoa);
            Controls.Add(them_capnhat);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private Button them_capnhat;
        private Button xoa;
        private Button thoat;
        private ListView listView1;
        private ColumnHeader stt;
        private ColumnHeader mataikhoan;
        private ColumnHeader tenkhachhang;
        private ColumnHeader diachi;
        private ColumnHeader sotien;
        private TextBox textBox5;
        private Label label6;
    }
}
