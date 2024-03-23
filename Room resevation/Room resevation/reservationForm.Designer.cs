namespace Room_resevation
{
    partial class reservationForm
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
            datashow = new DataGridView();
            comboBox1 = new ComboBox();
            Reserve = new Button();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)datashow).BeginInit();
            SuspendLayout();
            // 
            // datashow
            // 
            datashow.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datashow.Location = new Point(265, 43);
            datashow.Name = "datashow";
            datashow.RowTemplate.Height = 25;
            datashow.Size = new Size(240, 150);
            datashow.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(265, 299);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(260, 23);
            comboBox1.TabIndex = 1;
            // 
            // Reserve
            // 
            Reserve.Location = new Point(265, 367);
            Reserve.Name = "Reserve";
            Reserve.Size = new Size(260, 23);
            Reserve.TabIndex = 2;
            Reserve.Text = "Reserve";
            Reserve.UseVisualStyleBackColor = true;
            Reserve.Click += Reserve_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(265, 233);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(260, 23);
            dateTimePicker1.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(266, 273);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 8;
            label3.Text = "Choose ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(265, 206);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 9;
            label1.Text = "Choose a date";
            // 
            // reservationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(dateTimePicker1);
            Controls.Add(Reserve);
            Controls.Add(comboBox1);
            Controls.Add(datashow);
            Name = "reservationForm";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)datashow).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView datashow;
        private ComboBox comboBox1;
        private Button Reserve;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private Label label1;
    }
}