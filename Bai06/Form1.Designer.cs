namespace Bai06
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
            menuStrip1 = new MenuStrip();
            editToolStripMenuItem = new ToolStripMenuItem();
            textBox1 = new TextBox();
            C = new Button();
            Backspace = new Button();
            CE = new Button();
            seven = new Button();
            eight = new Button();
            sqrt = new Button();
            chia = new Button();
            nine = new Button();
            six = new Button();
            nhan = new Button();
            percent = new Button();
            five = new Button();
            four = new Button();
            three = new Button();
            tru = new Button();
            nghichdao = new Button();
            two = new Button();
            one = new Button();
            phay = new Button();
            cong = new Button();
            calculate = new Button();
            negative = new Button();
            zero = new Button();
            M_Plus = new Button();
            MS = new Button();
            MR = new Button();
            MC = new Button();
            copyToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(299, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { copyToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(15, 39);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(272, 23);
            textBox1.TabIndex = 1;
            textBox1.Text = "0";
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // C
            // 
            C.BackgroundImageLayout = ImageLayout.None;
            C.ForeColor = Color.Red;
            C.Location = new Point(223, 79);
            C.Name = "C";
            C.Size = new Size(64, 39);
            C.TabIndex = 2;
            C.Text = "C";
            C.UseVisualStyleBackColor = true;
            C.Click += C_Click;
            // 
            // Backspace
            // 
            Backspace.BackgroundImageLayout = ImageLayout.None;
            Backspace.ForeColor = Color.Red;
            Backspace.Location = new Point(60, 79);
            Backspace.Name = "Backspace";
            Backspace.Size = new Size(88, 39);
            Backspace.TabIndex = 3;
            Backspace.Text = "Backspace";
            Backspace.UseVisualStyleBackColor = true;
            Backspace.Click += Backspace_Click;
            // 
            // CE
            // 
            CE.BackgroundImageLayout = ImageLayout.None;
            CE.ForeColor = Color.Red;
            CE.Location = new Point(154, 79);
            CE.Name = "CE";
            CE.Size = new Size(63, 39);
            CE.TabIndex = 4;
            CE.Text = "CE";
            CE.UseVisualStyleBackColor = true;
            CE.Click += CE_Click;
            // 
            // seven
            // 
            seven.BackgroundImageLayout = ImageLayout.None;
            seven.ForeColor = Color.Blue;
            seven.Location = new Point(60, 124);
            seven.Name = "seven";
            seven.Size = new Size(42, 39);
            seven.TabIndex = 5;
            seven.Text = "7";
            seven.UseVisualStyleBackColor = true;
            seven.Click += seven_Click;
            // 
            // eight
            // 
            eight.BackgroundImageLayout = ImageLayout.None;
            eight.ForeColor = Color.Blue;
            eight.Location = new Point(108, 124);
            eight.Name = "eight";
            eight.Size = new Size(40, 39);
            eight.TabIndex = 6;
            eight.Text = "8";
            eight.UseVisualStyleBackColor = true;
            eight.Click += eight_Click;
            // 
            // sqrt
            // 
            sqrt.BackgroundImageLayout = ImageLayout.None;
            sqrt.ForeColor = Color.Blue;
            sqrt.Location = new Point(247, 124);
            sqrt.Name = "sqrt";
            sqrt.Size = new Size(39, 39);
            sqrt.TabIndex = 7;
            sqrt.Text = "sqrt";
            sqrt.UseVisualStyleBackColor = true;
            sqrt.Click += sqrt_Click;
            // 
            // chia
            // 
            chia.BackgroundImageLayout = ImageLayout.None;
            chia.ForeColor = Color.Red;
            chia.Location = new Point(202, 124);
            chia.Name = "chia";
            chia.Size = new Size(39, 39);
            chia.TabIndex = 8;
            chia.Text = "/";
            chia.UseVisualStyleBackColor = true;
            chia.Click += chia_Click;
            // 
            // nine
            // 
            nine.BackgroundImageLayout = ImageLayout.None;
            nine.ForeColor = Color.Blue;
            nine.Location = new Point(154, 124);
            nine.Name = "nine";
            nine.Size = new Size(42, 39);
            nine.TabIndex = 9;
            nine.Text = "9";
            nine.UseVisualStyleBackColor = true;
            nine.Click += nine_Click;
            // 
            // six
            // 
            six.BackgroundImageLayout = ImageLayout.None;
            six.ForeColor = Color.Blue;
            six.Location = new Point(154, 169);
            six.Name = "six";
            six.Size = new Size(42, 39);
            six.TabIndex = 14;
            six.Text = "6";
            six.UseVisualStyleBackColor = true;
            six.Click += six_Click;
            // 
            // nhan
            // 
            nhan.BackgroundImageLayout = ImageLayout.None;
            nhan.ForeColor = Color.Red;
            nhan.Location = new Point(202, 169);
            nhan.Name = "nhan";
            nhan.Size = new Size(39, 39);
            nhan.TabIndex = 13;
            nhan.Text = "*";
            nhan.UseVisualStyleBackColor = true;
            nhan.Click += nhan_Click;
            // 
            // percent
            // 
            percent.BackgroundImageLayout = ImageLayout.None;
            percent.ForeColor = Color.Blue;
            percent.Location = new Point(247, 169);
            percent.Name = "percent";
            percent.Size = new Size(39, 39);
            percent.TabIndex = 12;
            percent.Text = "%";
            percent.UseVisualStyleBackColor = true;
            percent.Click += percent_Click;
            // 
            // five
            // 
            five.BackgroundImageLayout = ImageLayout.None;
            five.ForeColor = Color.Blue;
            five.Location = new Point(108, 169);
            five.Name = "five";
            five.Size = new Size(40, 39);
            five.TabIndex = 11;
            five.Text = "5";
            five.UseVisualStyleBackColor = true;
            five.Click += five_Click;
            // 
            // four
            // 
            four.BackgroundImageLayout = ImageLayout.None;
            four.ForeColor = Color.Blue;
            four.Location = new Point(60, 169);
            four.Name = "four";
            four.Size = new Size(42, 39);
            four.TabIndex = 10;
            four.Text = "4";
            four.UseVisualStyleBackColor = true;
            four.Click += four_Click;
            // 
            // three
            // 
            three.BackgroundImageLayout = ImageLayout.None;
            three.ForeColor = Color.Blue;
            three.Location = new Point(154, 214);
            three.Name = "three";
            three.Size = new Size(42, 39);
            three.TabIndex = 19;
            three.Text = "3";
            three.UseVisualStyleBackColor = true;
            three.Click += three_Click;
            // 
            // tru
            // 
            tru.BackgroundImageLayout = ImageLayout.None;
            tru.ForeColor = Color.Red;
            tru.Location = new Point(202, 214);
            tru.Name = "tru";
            tru.Size = new Size(39, 39);
            tru.TabIndex = 18;
            tru.Text = "-";
            tru.UseVisualStyleBackColor = true;
            tru.Click += tru_Click;
            // 
            // nghichdao
            // 
            nghichdao.BackgroundImageLayout = ImageLayout.None;
            nghichdao.ForeColor = Color.Blue;
            nghichdao.Location = new Point(247, 214);
            nghichdao.Name = "nghichdao";
            nghichdao.Size = new Size(39, 39);
            nghichdao.TabIndex = 17;
            nghichdao.Text = "1/x";
            nghichdao.UseVisualStyleBackColor = true;
            nghichdao.Click += nghichdao_Click;
            // 
            // two
            // 
            two.BackgroundImageLayout = ImageLayout.None;
            two.ForeColor = Color.Blue;
            two.Location = new Point(108, 214);
            two.Name = "two";
            two.Size = new Size(40, 39);
            two.TabIndex = 16;
            two.Text = "2";
            two.UseVisualStyleBackColor = true;
            two.Click += two_Click;
            // 
            // one
            // 
            one.BackgroundImageLayout = ImageLayout.None;
            one.ForeColor = Color.Blue;
            one.Location = new Point(60, 214);
            one.Name = "one";
            one.Size = new Size(42, 39);
            one.TabIndex = 15;
            one.Text = "1";
            one.UseVisualStyleBackColor = true;
            one.Click += one_Click;
            // 
            // phay
            // 
            phay.BackgroundImageLayout = ImageLayout.None;
            phay.ForeColor = Color.Blue;
            phay.Location = new Point(154, 259);
            phay.Name = "phay";
            phay.Size = new Size(42, 39);
            phay.TabIndex = 24;
            phay.Text = ",";
            phay.UseVisualStyleBackColor = true;
            phay.Click += phay_Click;
            // 
            // cong
            // 
            cong.BackgroundImageLayout = ImageLayout.None;
            cong.ForeColor = Color.Red;
            cong.Location = new Point(202, 259);
            cong.Name = "cong";
            cong.Size = new Size(39, 39);
            cong.TabIndex = 23;
            cong.Text = "+";
            cong.UseVisualStyleBackColor = true;
            cong.Click += cong_Click;
            // 
            // calculate
            // 
            calculate.BackgroundImageLayout = ImageLayout.None;
            calculate.ForeColor = Color.Red;
            calculate.Location = new Point(247, 259);
            calculate.Name = "calculate";
            calculate.Size = new Size(39, 39);
            calculate.TabIndex = 22;
            calculate.Text = "=";
            calculate.UseVisualStyleBackColor = true;
            calculate.Click += calculate_Click;
            // 
            // negative
            // 
            negative.BackgroundImageLayout = ImageLayout.None;
            negative.ForeColor = Color.Blue;
            negative.Location = new Point(108, 259);
            negative.Name = "negative";
            negative.Size = new Size(40, 39);
            negative.TabIndex = 21;
            negative.Text = "+/-";
            negative.UseVisualStyleBackColor = true;
            negative.Click += negative_Click;
            // 
            // zero
            // 
            zero.BackgroundImageLayout = ImageLayout.None;
            zero.ForeColor = Color.Blue;
            zero.Location = new Point(60, 259);
            zero.Name = "zero";
            zero.Size = new Size(42, 39);
            zero.TabIndex = 20;
            zero.Text = "0";
            zero.UseVisualStyleBackColor = true;
            zero.Click += zero_Click;
            // 
            // M_Plus
            // 
            M_Plus.BackgroundImageLayout = ImageLayout.None;
            M_Plus.ForeColor = Color.Red;
            M_Plus.Location = new Point(15, 259);
            M_Plus.Name = "M_Plus";
            M_Plus.Size = new Size(39, 39);
            M_Plus.TabIndex = 28;
            M_Plus.Text = "M+";
            M_Plus.UseVisualStyleBackColor = true;
            M_Plus.Click += M_Plus_Click;
            // 
            // MS
            // 
            MS.BackgroundImageLayout = ImageLayout.None;
            MS.ForeColor = Color.Red;
            MS.Location = new Point(15, 214);
            MS.Name = "MS";
            MS.Size = new Size(39, 39);
            MS.TabIndex = 27;
            MS.Text = "MS";
            MS.UseVisualStyleBackColor = true;
            MS.Click += MS_Click;
            // 
            // MR
            // 
            MR.BackgroundImageLayout = ImageLayout.None;
            MR.ForeColor = Color.Red;
            MR.Location = new Point(15, 169);
            MR.Name = "MR";
            MR.Size = new Size(39, 39);
            MR.TabIndex = 26;
            MR.Text = "MR";
            MR.UseVisualStyleBackColor = true;
            MR.Click += MR_Click;
            // 
            // MC
            // 
            MC.BackgroundImageLayout = ImageLayout.None;
            MC.ForeColor = Color.Red;
            MC.Location = new Point(15, 124);
            MC.Name = "MC";
            MC.Size = new Size(39, 39);
            MC.TabIndex = 25;
            MC.Text = "MC";
            MC.UseVisualStyleBackColor = true;
            MC.Click += MC_Click;
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.Size = new Size(180, 22);
            copyToolStripMenuItem.Text = "Copy";
            copyToolStripMenuItem.Click += copyToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(299, 312);
            Controls.Add(M_Plus);
            Controls.Add(MS);
            Controls.Add(MR);
            Controls.Add(MC);
            Controls.Add(phay);
            Controls.Add(cong);
            Controls.Add(calculate);
            Controls.Add(negative);
            Controls.Add(zero);
            Controls.Add(three);
            Controls.Add(tru);
            Controls.Add(nghichdao);
            Controls.Add(two);
            Controls.Add(one);
            Controls.Add(six);
            Controls.Add(nhan);
            Controls.Add(percent);
            Controls.Add(five);
            Controls.Add(four);
            Controls.Add(nine);
            Controls.Add(chia);
            Controls.Add(sqrt);
            Controls.Add(eight);
            Controls.Add(seven);
            Controls.Add(CE);
            Controls.Add(Backspace);
            Controls.Add(C);
            Controls.Add(textBox1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem editToolStripMenuItem;
        private TextBox textBox1;
        private Button C;
        private Button Backspace;
        private Button CE;
        private Button seven;
        private Button eight;
        private Button sqrt;
        private Button chia;
        private Button nine;
        private Button six;
        private Button nhan;
        private Button percent;
        private Button five;
        private Button four;
        private Button three;
        private Button tru;
        private Button nghichdao;
        private Button two;
        private Button one;
        private Button phay;
        private Button cong;
        private Button calculate;
        private Button negative;
        private Button zero;
        private Button M_Plus;
        private Button MS;
        private Button MR;
        private Button MC;
        private ToolStripMenuItem copyToolStripMenuItem;
    }
}
