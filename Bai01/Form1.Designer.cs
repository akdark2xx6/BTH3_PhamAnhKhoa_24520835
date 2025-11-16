using Microsoft.VisualBasic.ApplicationServices;

namespace Bai01
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        StreamWriter sr = new StreamWriter("C:\\Users\\ADMIN\\source\\repos\\BTH3_PhamAnhKhoa_24520835\\Bai01\\sr.txt");
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
            sr.Close();
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            richTextBox1 = new RichTextBox();
            Exit = new Button();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(28, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(266, 309);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // Exit
            // 
            Exit.Location = new Point(480, 239);
            Exit.Name = "Exit";
            Exit.Size = new Size(140, 48);
            Exit.TabIndex = 1;
            Exit.Text = "Exit";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(723, 364);
            Controls.Add(Exit);
            Controls.Add(richTextBox1);
            Name = "Form1";
            Text = "Form1";
            Activated += Form1_Activated;
            Deactivate += Form1_Deactivate;
            FormClosing += Form1_FormClosing;
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            Shown += Form1_Shown;
            Click += Form1_Click;
            Move += Form1_Move;
            Resize += Form1_Resize;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button Exit;
    }
}
