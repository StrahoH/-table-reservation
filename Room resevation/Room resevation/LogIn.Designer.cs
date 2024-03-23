namespace Room_resevation
{
    partial class LogIn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label4 = new Label();
            uname = new TextBox();
            label1 = new Label();
            button1 = new Button();
            password = new MaskedTextBox();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 86);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 17;
            label4.Text = "Password";
            // 
            // uname
            // 
            uname.Location = new Point(45, 46);
            uname.Name = "uname";
            uname.Size = new Size(260, 23);
            uname.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 28);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 15;
            label1.Text = "Username";
            // 
            // button1
            // 
            button1.Location = new Point(47, 155);
            button1.Name = "button1";
            button1.Size = new Size(258, 23);
            button1.TabIndex = 19;
            button1.Text = "Log in";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // password
            // 
            password.Location = new Point(47, 115);
            password.Name = "password";
            password.PasswordChar = '*';
            password.Size = new Size(258, 23);
            password.TabIndex = 20;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(365, 234);
            Controls.Add(password);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(uname);
            Controls.Add(label1);
            Name = "LogIn";
            Text = "LogIn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label4;
        private TextBox uname;
        private Label label1;
        private Button button1;
        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox password;
    }
}