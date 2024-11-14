namespace Theme3
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
            toBox = new TextBox();
            fromBox = new TextBox();
            themeBox = new TextBox();
            bodyBox = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // toBox
            // 
            toBox.Location = new Point(12, 12);
            toBox.Name = "toBox";
            toBox.PlaceholderText = "Кому";
            toBox.Size = new Size(459, 23);
            toBox.TabIndex = 0;
            // 
            // fromBox
            // 
            fromBox.Location = new Point(12, 41);
            fromBox.Name = "fromBox";
            fromBox.PlaceholderText = "От кого";
            fromBox.Size = new Size(460, 23);
            fromBox.TabIndex = 1;
            // 
            // themeBox
            // 
            themeBox.Location = new Point(12, 70);
            themeBox.Name = "themeBox";
            themeBox.PlaceholderText = "Тема";
            themeBox.Size = new Size(459, 23);
            themeBox.TabIndex = 2;
            // 
            // bodyBox
            // 
            bodyBox.Location = new Point(13, 108);
            bodyBox.Multiline = true;
            bodyBox.Name = "bodyBox";
            bodyBox.PlaceholderText = "Текст сообщения";
            bodyBox.Size = new Size(459, 288);
            bodyBox.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(397, 415);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Отправить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 450);
            Controls.Add(button1);
            Controls.Add(bodyBox);
            Controls.Add(themeBox);
            Controls.Add(fromBox);
            Controls.Add(toBox);
            Name = "Form1";
            Text = "SMTP";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox toBox;
        private TextBox fromBox;
        private TextBox themeBox;
        private TextBox bodyBox;
        private Button button1;
    }
}
