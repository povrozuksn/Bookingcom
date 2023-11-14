namespace Bookingcom
{
    partial class AdminHotelsForm
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
            this.InfoHotelsPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddHotelsPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NameHotelTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.RatingComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CityComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.HotelPictureBox = new System.Windows.Forms.PictureBox();
            this.AddHotelButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.InfoHotelsPanel.SuspendLayout();
            this.AddHotelsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HotelPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // InfoHotelsPanel
            // 
            this.InfoHotelsPanel.AutoScroll = true;
            this.InfoHotelsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.InfoHotelsPanel.Controls.Add(this.label3);
            this.InfoHotelsPanel.Controls.Add(this.label2);
            this.InfoHotelsPanel.Controls.Add(this.label1);
            this.InfoHotelsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.InfoHotelsPanel.Location = new System.Drawing.Point(0, 0);
            this.InfoHotelsPanel.Name = "InfoHotelsPanel";
            this.InfoHotelsPanel.Size = new System.Drawing.Size(962, 312);
            this.InfoHotelsPanel.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(450, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Рейтинг";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Город";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название";
            // 
            // AddHotelsPanel
            // 
            this.AddHotelsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.AddHotelsPanel.Controls.Add(this.label12);
            this.AddHotelsPanel.Controls.Add(this.label11);
            this.AddHotelsPanel.Controls.Add(this.AddHotelButton);
            this.AddHotelsPanel.Controls.Add(this.HotelPictureBox);
            this.AddHotelsPanel.Controls.Add(this.label8);
            this.AddHotelsPanel.Controls.Add(this.CityComboBox);
            this.AddHotelsPanel.Controls.Add(this.label7);
            this.AddHotelsPanel.Controls.Add(this.RatingComboBox);
            this.AddHotelsPanel.Controls.Add(this.label6);
            this.AddHotelsPanel.Controls.Add(this.NameHotelTextBox);
            this.AddHotelsPanel.Controls.Add(this.label5);
            this.AddHotelsPanel.Controls.Add(this.label4);
            this.AddHotelsPanel.Controls.Add(this.label10);
            this.AddHotelsPanel.Controls.Add(this.label9);
            this.AddHotelsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddHotelsPanel.Location = new System.Drawing.Point(0, 312);
            this.AddHotelsPanel.Name = "AddHotelsPanel";
            this.AddHotelsPanel.Size = new System.Drawing.Size(962, 304);
            this.AddHotelsPanel.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Добавление гостиниц";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(101, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Название";
            // 
            // NameHotelTextBox
            // 
            this.NameHotelTextBox.Location = new System.Drawing.Point(106, 74);
            this.NameHotelTextBox.Name = "NameHotelTextBox";
            this.NameHotelTextBox.Size = new System.Drawing.Size(256, 30);
            this.NameHotelTextBox.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(101, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "Рейтинг";
            // 
            // RatingComboBox
            // 
            this.RatingComboBox.FormattingEnabled = true;
            this.RatingComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.RatingComboBox.Location = new System.Drawing.Point(106, 135);
            this.RatingComboBox.Name = "RatingComboBox";
            this.RatingComboBox.Size = new System.Drawing.Size(91, 33);
            this.RatingComboBox.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(101, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "Город";
            // 
            // CityComboBox
            // 
            this.CityComboBox.FormattingEnabled = true;
            this.CityComboBox.Location = new System.Drawing.Point(106, 199);
            this.CityComboBox.Name = "CityComboBox";
            this.CityComboBox.Size = new System.Drawing.Size(251, 33);
            this.CityComboBox.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(473, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Фото";
            // 
            // HotelPictureBox
            // 
            this.HotelPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HotelPictureBox.Location = new System.Drawing.Point(478, 46);
            this.HotelPictureBox.Name = "HotelPictureBox";
            this.HotelPictureBox.Size = new System.Drawing.Size(277, 179);
            this.HotelPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HotelPictureBox.TabIndex = 8;
            this.HotelPictureBox.TabStop = false;
            this.HotelPictureBox.Click += new System.EventHandler(this.HotelPictureBox_Click);
            // 
            // AddHotelButton
            // 
            this.AddHotelButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AddHotelButton.Location = new System.Drawing.Point(0, 271);
            this.AddHotelButton.Name = "AddHotelButton";
            this.AddHotelButton.Size = new System.Drawing.Size(962, 33);
            this.AddHotelButton.TabIndex = 9;
            this.AddHotelButton.Text = "Добавить";
            this.AddHotelButton.UseVisualStyleBackColor = true;
            this.AddHotelButton.Click += new System.EventHandler(this.AddHotelButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(85, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 32);
            this.label9.TabIndex = 10;
            this.label9.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(85, 171);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 32);
            this.label10.TabIndex = 11;
            this.label10.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(9, 247);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 25);
            this.label11.TabIndex = 12;
            this.label11.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(24, 254);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(245, 16);
            this.label12.TabIndex = 13;
            this.label12.Text = "Поля обязательные для заполнения";
            // 
            // AdminHotelsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 616);
            this.Controls.Add(this.AddHotelsPanel);
            this.Controls.Add(this.InfoHotelsPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AdminHotelsForm";
            this.Text = "AdminHotelsForm";
            this.Load += new System.EventHandler(this.AdminHotelsForm_Load);
            this.InfoHotelsPanel.ResumeLayout(false);
            this.InfoHotelsPanel.PerformLayout();
            this.AddHotelsPanel.ResumeLayout(false);
            this.AddHotelsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HotelPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel InfoHotelsPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel AddHotelsPanel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox RatingComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NameHotelTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CityComboBox;
        private System.Windows.Forms.Button AddHotelButton;
        private System.Windows.Forms.PictureBox HotelPictureBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}