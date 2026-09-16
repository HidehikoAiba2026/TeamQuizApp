namespace TeamQuizApp
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
            answerButton1 = new Button();
            answerButton2 = new Button();
            answerButton3 = new Button();
            answerButton4 = new Button();
            questionLabel = new Label();
            logListBox = new ListBox();
            SuspendLayout();
            // 
            // answerButton1
            // 
            answerButton1.Location = new Point(351, 141);
            answerButton1.Name = "answerButton1";
            answerButton1.Size = new Size(94, 29);
            answerButton1.TabIndex = 0;
            answerButton1.Text = "button1";
            answerButton1.UseVisualStyleBackColor = true;
            answerButton1.Click += answerButton_Click;
            // 
            // answerButton2
            // 
            answerButton2.Location = new Point(351, 176);
            answerButton2.Name = "answerButton2";
            answerButton2.Size = new Size(94, 29);
            answerButton2.TabIndex = 1;
            answerButton2.Text = "button2";
            answerButton2.UseVisualStyleBackColor = true;
            answerButton2.Click += answerButton_Click;
            // 
            // answerButton3
            // 
            answerButton3.Location = new Point(351, 211);
            answerButton3.Name = "answerButton3";
            answerButton3.Size = new Size(94, 29);
            answerButton3.TabIndex = 2;
            answerButton3.Text = "button3";
            answerButton3.UseVisualStyleBackColor = true;
            answerButton3.Click += answerButton_Click;
            // 
            // answerButton4
            // 
            answerButton4.Location = new Point(351, 246);
            answerButton4.Name = "answerButton4";
            answerButton4.Size = new Size(94, 29);
            answerButton4.TabIndex = 3;
            answerButton4.Text = "button4";
            answerButton4.UseVisualStyleBackColor = true;
            answerButton4.Click += answerButton_Click;
            // 
            // questionLabel
            // 
            questionLabel.AutoSize = true;
            questionLabel.Location = new Point(98, 118);
            questionLabel.Name = "questionLabel";
            questionLabel.Size = new Size(50, 20);
            questionLabel.TabIndex = 4;
            questionLabel.Text = "label1";
            // 
            // logListBox
            // 
            logListBox.FormattingEnabled = true;
            logListBox.Location = new Point(98, 141);
            logListBox.Name = "logListBox";
            logListBox.Size = new Size(150, 184);
            logListBox.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(logListBox);
            Controls.Add(questionLabel);
            Controls.Add(answerButton4);
            Controls.Add(answerButton3);
            Controls.Add(answerButton2);
            Controls.Add(answerButton1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button answerButton1;
        private Button answerButton2;
        private Button answerButton3;
        private Button answerButton4;
        private Label questionLabel;
        private ListBox logListBox;
    }
}
