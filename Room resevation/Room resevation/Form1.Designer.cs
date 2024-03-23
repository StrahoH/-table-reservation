namespace Room_resevation
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
            pricebox = new ComboBox();
            typebox = new ComboBox();
            placebox = new ComboBox();
            showdata = new DataGridView();
            Price = new Label();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            usernameLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)showdata).BeginInit();
            SuspendLayout();
            // 
            // pricebox
            // 
            pricebox.FormattingEnabled = true;
            pricebox.Items.AddRange(new object[] { "10", "20", "30", "50" });
            pricebox.Location = new Point(538, 98);
            pricebox.Name = "pricebox";
            pricebox.Size = new Size(121, 23);
            pricebox.TabIndex = 0;
            // 
            // typebox
            // 
            typebox.FormattingEnabled = true;
            typebox.Items.AddRange(new object[] { "Small", "Medium ", "Big" });
            typebox.Location = new Point(333, 98);
            typebox.Name = "typebox";
            typebox.Size = new Size(121, 23);
            typebox.TabIndex = 1;
            // 
            // placebox
            // 
            placebox.FormattingEnabled = true;
            placebox.Items.AddRange(new object[] { "Outside", "Inside" });
            placebox.Location = new Point(127, 98);
            placebox.Name = "placebox";
            placebox.Size = new Size(121, 23);
            placebox.TabIndex = 2;
            // 
            // showdata
            // 
            showdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            showdata.Location = new Point(127, 127);
            showdata.Name = "showdata";
            showdata.RowTemplate.Height = 25;
            showdata.Size = new Size(532, 150);
            showdata.TabIndex = 3;
            // 
            // Price
            // 
            Price.AutoSize = true;
            Price.Font = new Font("MV Boli", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Price.Location = new Point(579, 74);
            Price.Name = "Price";
            Price.Size = new Size(47, 21);
            Price.TabIndex = 4;
            Price.Text = "Price";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MV Boli", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(165, 74);
            label1.Name = "label1";
            label1.Size = new Size(48, 21);
            label1.TabIndex = 5;
            label1.Text = "Place";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MV Boli", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(368, 74);
            label2.Name = "label2";
            label2.Size = new Size(45, 21);
            label2.TabIndex = 6;
            label2.Text = "Type";
            // 
            // button1
            // 
            button1.Location = new Point(540, 291);
            button1.Name = "button1";
            button1.Size = new Size(119, 23);
            button1.TabIndex = 7;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.Location = new Point(127, 291);
            button2.Name = "button2";
            button2.Size = new Size(121, 23);
            button2.TabIndex = 8;
            button2.Text = "Rerserve";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("MV Boli", 12F, FontStyle.Regular, GraphicsUnit.Point);
            usernameLabel.Location = new Point(127, 26);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(0, 21);
            usernameLabel.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(usernameLabel);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Price);
            Controls.Add(showdata);
            Controls.Add(placebox);
            Controls.Add(typebox);
            Controls.Add(pricebox);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)showdata).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox pricebox;
        private ComboBox typebox;
        private ComboBox placebox;
        private DataGridView showdata;
        private Label Price;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Label usernameLabel;
    }
}