namespace Bai05
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
            Number1 = new TextBox();
            Number2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            Cong = new Button();
            Tru = new Button();
            Nhan = new Button();
            Chia = new Button();
            Answer = new Label();
            textAnswer = new TextBox();
            SuspendLayout();
            // 
            // Number1
            // 
            Number1.Location = new Point(146, 57);
            Number1.Name = "Number1";
            Number1.Size = new Size(166, 23);
            Number1.TabIndex = 0;
            // 
            // Number2
            // 
            Number2.Location = new Point(146, 102);
            Number2.Name = "Number2";
            Number2.Size = new Size(166, 23);
            Number2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 60);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 2;
            label1.Text = "Number 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 105);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 3;
            label2.Text = "Number 2";
            // 
            // Cong
            // 
            Cong.Location = new Point(54, 169);
            Cong.Name = "Cong";
            Cong.Size = new Size(75, 23);
            Cong.TabIndex = 4;
            Cong.Text = "+";
            Cong.UseVisualStyleBackColor = true;
            Cong.Click += Cong_Click;
            // 
            // Tru
            // 
            Tru.Location = new Point(146, 169);
            Tru.Name = "Tru";
            Tru.Size = new Size(75, 23);
            Tru.TabIndex = 5;
            Tru.Text = "-";
            Tru.UseVisualStyleBackColor = true;
            Tru.Click += Tru_Click;
            // 
            // Nhan
            // 
            Nhan.Location = new Point(237, 169);
            Nhan.Name = "Nhan";
            Nhan.Size = new Size(75, 23);
            Nhan.TabIndex = 6;
            Nhan.Text = "x";
            Nhan.UseVisualStyleBackColor = true;
            Nhan.Click += Nhan_Click;
            // 
            // Chia
            // 
            Chia.Location = new Point(331, 169);
            Chia.Name = "Chia";
            Chia.Size = new Size(75, 23);
            Chia.TabIndex = 7;
            Chia.Text = "/";
            Chia.UseVisualStyleBackColor = true;
            Chia.Click += Chia_Click;
            // 
            // Answer
            // 
            Answer.AutoSize = true;
            Answer.Location = new Point(81, 230);
            Answer.Name = "Answer";
            Answer.Size = new Size(46, 15);
            Answer.TabIndex = 9;
            Answer.Text = "Answer";
            // 
            // textAnswer
            // 
            textAnswer.Enabled = false;
            textAnswer.Location = new Point(146, 227);
            textAnswer.Name = "textAnswer";
            textAnswer.Size = new Size(166, 23);
            textAnswer.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 292);
            Controls.Add(Answer);
            Controls.Add(textAnswer);
            Controls.Add(Chia);
            Controls.Add(Nhan);
            Controls.Add(Tru);
            Controls.Add(Cong);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Number2);
            Controls.Add(Number1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Number1;
        private TextBox Number2;
        private Label label1;
        private Label label2;
        private Button Cong;
        private Button Tru;
        private Button Nhan;
        private Button Chia;
        private Label Answer;
        private TextBox textAnswer;
    }
}
