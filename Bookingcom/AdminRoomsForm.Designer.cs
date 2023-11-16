namespace Bookingcom
{
    partial class AdminRoomsForm
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
            this.InfoRoomsPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddRoomsPanel = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.AddRoomButton = new System.Windows.Forms.Button();
            this.RoomPictureBox = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.HotelsComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.NameRoomTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.InfoRoomsPanel.SuspendLayout();
            this.AddRoomsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoomPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // InfoRoomsPanel
            // 
            this.InfoRoomsPanel.AutoScroll = true;
            this.InfoRoomsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.InfoRoomsPanel.Controls.Add(this.label2);
            this.InfoRoomsPanel.Controls.Add(this.label1);
            this.InfoRoomsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.InfoRoomsPanel.Location = new System.Drawing.Point(0, 0);
            this.InfoRoomsPanel.Name = "InfoRoomsPanel";
            this.InfoRoomsPanel.Size = new System.Drawing.Size(1156, 330);
            this.InfoRoomsPanel.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(475, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Гостиница";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Название";
            // 
            // AddRoomsPanel
            // 
            this.AddRoomsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.AddRoomsPanel.Controls.Add(this.label12);
            this.AddRoomsPanel.Controls.Add(this.label11);
            this.AddRoomsPanel.Controls.Add(this.AddRoomButton);
            this.AddRoomsPanel.Controls.Add(this.RoomPictureBox);
            this.AddRoomsPanel.Controls.Add(this.label8);
            this.AddRoomsPanel.Controls.Add(this.HotelsComboBox);
            this.AddRoomsPanel.Controls.Add(this.label7);
            this.AddRoomsPanel.Controls.Add(this.NameRoomTextBox);
            this.AddRoomsPanel.Controls.Add(this.label5);
            this.AddRoomsPanel.Controls.Add(this.label4);
            this.AddRoomsPanel.Controls.Add(this.label10);
            this.AddRoomsPanel.Controls.Add(this.label9);
            this.AddRoomsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddRoomsPanel.Location = new System.Drawing.Point(0, 330);
            this.AddRoomsPanel.Name = "AddRoomsPanel";
            this.AddRoomsPanel.Size = new System.Drawing.Size(1156, 352);
            this.AddRoomsPanel.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(24, 270);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(245, 16);
            this.label12.TabIndex = 27;
            this.label12.Text = "Поля обязательные для заполнения";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(12, 270);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 25);
            this.label11.TabIndex = 26;
            this.label11.Text = "*";
            // 
            // AddRoomButton
            // 
            this.AddRoomButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AddRoomButton.Location = new System.Drawing.Point(0, 298);
            this.AddRoomButton.Name = "AddRoomButton";
            this.AddRoomButton.Size = new System.Drawing.Size(1156, 54);
            this.AddRoomButton.TabIndex = 23;
            this.AddRoomButton.Text = "Добавить";
            this.AddRoomButton.UseVisualStyleBackColor = true;
            this.AddRoomButton.Click += new System.EventHandler(this.AddRoomButton_Click);
            // 
            // RoomPictureBox
            // 
            this.RoomPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RoomPictureBox.Location = new System.Drawing.Point(538, 75);
            this.RoomPictureBox.Name = "RoomPictureBox";
            this.RoomPictureBox.Size = new System.Drawing.Size(277, 179);
            this.RoomPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RoomPictureBox.TabIndex = 22;
            this.RoomPictureBox.TabStop = false;
            this.RoomPictureBox.Click += new System.EventHandler(this.RoomPictureBox_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(533, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 25);
            this.label8.TabIndex = 21;
            this.label8.Text = "Фото";
            // 
            // HotelsComboBox
            // 
            this.HotelsComboBox.FormattingEnabled = true;
            this.HotelsComboBox.Location = new System.Drawing.Point(229, 147);
            this.HotelsComboBox.Name = "HotelsComboBox";
            this.HotelsComboBox.Size = new System.Drawing.Size(251, 33);
            this.HotelsComboBox.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(224, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 25);
            this.label7.TabIndex = 19;
            this.label7.Text = "Гостиница";
            // 
            // NameRoomTextBox
            // 
            this.NameRoomTextBox.Location = new System.Drawing.Point(229, 75);
            this.NameRoomTextBox.Name = "NameRoomTextBox";
            this.NameRoomTextBox.Size = new System.Drawing.Size(256, 30);
            this.NameRoomTextBox.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(224, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Название";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Добавление номеров";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(208, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 32);
            this.label10.TabIndex = 25;
            this.label10.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(208, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 32);
            this.label9.TabIndex = 24;
            this.label9.Text = "*";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // AdminRoomsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 682);
            this.Controls.Add(this.AddRoomsPanel);
            this.Controls.Add(this.InfoRoomsPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AdminRoomsForm";
            this.Text = "AdminRoomsForm";
            this.Load += new System.EventHandler(this.AdminRoomsForm_Load);
            this.InfoRoomsPanel.ResumeLayout(false);
            this.InfoRoomsPanel.PerformLayout();
            this.AddRoomsPanel.ResumeLayout(false);
            this.AddRoomsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoomPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel InfoRoomsPanel;
        private System.Windows.Forms.Panel AddRoomsPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button AddRoomButton;
        private System.Windows.Forms.PictureBox RoomPictureBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox HotelsComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox NameRoomTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}