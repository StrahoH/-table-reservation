namespace Room_resevation
{
    partial class regester
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
            email = new TextBox();
            label2 = new Label();
            name = new TextBox();
            label1 = new Label();
            Signin = new Button();
            label3 = new Label();
            pass = new TextBox();
            label4 = new Label();
            p8 = new Label();
            pn = new Label();
            ps = new Label();
            pc = new Label();
            SuspendLayout();
            // 
            // email
            // 
            email.Location = new Point(264, 173);
            email.Name = "email";
            email.Size = new Size(260, 23);
            email.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(264, 155);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 9;
            label2.Text = "Email";
            // 
            // name
            // 
            name.Location = new Point(264, 57);
            name.Name = "name";
            name.Size = new Size(260, 23);
            name.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(264, 39);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 7;
            label1.Text = "Username";
            // 
            // Signin
            // 
            Signin.Location = new Point(267, 237);
            Signin.Name = "Signin";
            Signin.Size = new Size(257, 23);
            Signin.TabIndex = 11;
            Signin.Text = "Sign in";
            Signin.UseVisualStyleBackColor = true;
            Signin.Click += Signin_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(484, 263);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 12;
            label3.Text = "Log in";
            label3.Click += label3_Click;
            // 
            // pass
            // 
            pass.Location = new Point(264, 115);
            pass.Name = "pass";
            pass.Size = new Size(260, 23);
            pass.TabIndex = 14;
            pass.TextChanged += pass_TextChanged_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(264, 97);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 13;
            label4.Text = "Password";
            // 
            // p8
            // 
            p8.AutoSize = true;
            p8.Enabled = false;
            p8.Location = new Point(271, 303);
            p8.Name = "p8";
            p8.Size = new Size(240, 15);
            p8.TabIndex = 15;
            p8.Text = "The password should be at least 8 characters";
            // 
            // pn
            // 
            pn.AutoSize = true;
            pn.Enabled = false;
            pn.Location = new Point(271, 327);
            pn.Name = "pn";
            pn.Size = new Size(269, 15);
            pn.TabIndex = 16;
            pn.Text = "The password should contain at least one number";
            // 
            // ps
            // 
            ps.AutoSize = true;
            ps.Enabled = false;
            ps.Location = new Point(271, 377);
            ps.Name = "ps";
            ps.Size = new Size(315, 15);
            ps.TabIndex = 17;
            ps.Text = "The password should contain at least one special character";
            // 
            // pc
            // 
            pc.AutoSize = true;
            pc.Enabled = false;
            pc.Location = new Point(271, 353);
            pc.Name = "pc";
            pc.Size = new Size(292, 15);
            pc.TabIndex = 18;
            pc.Text = "The password should contain at least one capital letter";
            // 
            // regester
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pc);
            Controls.Add(ps);
            Controls.Add(pn);
            Controls.Add(p8);
            Controls.Add(pass);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Signin);
            Controls.Add(email);
            Controls.Add(label2);
            Controls.Add(name);
            Controls.Add(label1);
            Name = "regester";
            Text = "LogIn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox email;
        private Label label2;
        private TextBox name;
        private Label label1;
        private Button Signin;
        private Label label3;
        private TextBox pass;
        private Label label4;
        private Label p8;
        private Label pn;
        private Label ps;
        private Label pc;
    }
}