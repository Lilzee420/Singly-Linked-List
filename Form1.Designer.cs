namespace Linked_List
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            richTextBox1 = new RichTextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button8 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(24, 202);
            button1.Name = "button1";
            button1.Size = new Size(91, 54);
            button1.TabIndex = 0;
            button1.Text = "Add First";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(121, 202);
            button2.Name = "button2";
            button2.Size = new Size(91, 54);
            button2.TabIndex = 1;
            button2.Text = "Add Last";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(218, 172);
            button3.Name = "button3";
            button3.Size = new Size(91, 54);
            button3.TabIndex = 2;
            button3.Text = "Arrange";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(218, 232);
            button4.Name = "button4";
            button4.Size = new Size(91, 54);
            button4.TabIndex = 3;
            button4.Text = "Add Sorted";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(412, 202);
            button5.Name = "button5";
            button5.Size = new Size(91, 54);
            button5.TabIndex = 4;
            button5.Text = "Remove First";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(509, 202);
            button6.Name = "button6";
            button6.Size = new Size(91, 54);
            button6.TabIndex = 5;
            button6.Text = "Remove Last";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(606, 202);
            button7.Name = "button7";
            button7.Size = new Size(91, 54);
            button7.TabIndex = 6;
            button7.Text = "Clear";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(24, 310);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(673, 78);
            richTextBox1.TabIndex = 7;
            richTextBox1.Text = "";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(310, 57);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(106, 23);
            textBox1.TabIndex = 8;
            textBox1.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(326, 39);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 9;
            label1.Text = "Enter Data: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 292);
            label2.Name = "label2";
            label2.Size = new Size(238, 15);
            label2.TabIndex = 10;
            label2.Text = "This is what your linked list looks like so far: ";
            // 
            // button8
            // 
            button8.Location = new Point(315, 202);
            button8.Name = "button8";
            button8.Size = new Size(91, 54);
            button8.TabIndex = 11;
            button8.Text = "Reverse";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(721, 400);
            Controls.Add(button8);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(richTextBox1);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private RichTextBox richTextBox1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Button button8;
    }
}