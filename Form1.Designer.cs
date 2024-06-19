namespace Gui7Z
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
            openFileDialog1 = new OpenFileDialog();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            folderBrowserDialog1 = new FolderBrowserDialog();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.Filter = "Zip|*.zip|Rar|*.rar|7z|*.7z";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // button1
            // 
            button1.Location = new Point(12, 2);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Select File";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(114, 2);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "Select Dest.";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(2, 71);
            button3.Name = "button3";
            button3.Size = new Size(106, 23);
            button3.TabIndex = 2;
            button3.Text = "Extract";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(2, 28);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 3;
            label1.Text = "Select a file!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(2, 53);
            label2.Name = "label2";
            label2.Size = new Size(131, 15);
            label2.TabIndex = 4;
            label2.Text = "Select your Destination!";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(114, 72);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Password (if any)";
            textBox1.Size = new Size(96, 23);
            textBox1.TabIndex = 5;
            //textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(238, 100);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            RightToLeft = RightToLeft.No;
            Text = "7z GUI Interface Beta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Label label2;
        private FolderBrowserDialog folderBrowserDialog1;
        private TextBox textBox1;
    }
}
