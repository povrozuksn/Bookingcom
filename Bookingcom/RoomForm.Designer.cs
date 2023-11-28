namespace Bookingcom
{
    partial class RoomForm
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
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.RoomTextBox = new System.Windows.Forms.TextBox();
            this.RoomLabel = new System.Windows.Forms.Label();
            this.RoomPictureBox = new System.Windows.Forms.PictureBox();
            this.RoomPanel = new System.Windows.Forms.Panel();
            this.CommentPanel = new System.Windows.Forms.Panel();
            this.CommentButton = new System.Windows.Forms.Button();
            this.CommentComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CommentTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BronButton = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveRoomButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.QuantityTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.STextBox = new System.Windows.Forms.TextBox();
            this.SaveParamButton = new System.Windows.Forms.Button();
            this.InfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoomPictureBox)).BeginInit();
            this.RoomPanel.SuspendLayout();
            this.CommentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // InfoPanel
            // 
            this.InfoPanel.Controls.Add(this.SaveParamButton);
            this.InfoPanel.Controls.Add(this.STextBox);
            this.InfoPanel.Controls.Add(this.label8);
            this.InfoPanel.Controls.Add(this.QuantityTextBox);
            this.InfoPanel.Controls.Add(this.label9);
            this.InfoPanel.Controls.Add(this.label7);
            this.InfoPanel.Controls.Add(this.PriceTextBox);
            this.InfoPanel.Controls.Add(this.label6);
            this.InfoPanel.Controls.Add(this.SaveRoomButton);
            this.InfoPanel.Controls.Add(this.label3);
            this.InfoPanel.Controls.Add(this.RoomTextBox);
            this.InfoPanel.Controls.Add(this.RoomLabel);
            this.InfoPanel.Controls.Add(this.RoomPictureBox);
            this.InfoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.InfoPanel.Location = new System.Drawing.Point(0, 0);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(1037, 270);
            this.InfoPanel.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(380, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Площадь, кв. м:";
            // 
            // RoomTextBox
            // 
            this.RoomTextBox.Enabled = false;
            this.RoomTextBox.Location = new System.Drawing.Point(385, 75);
            this.RoomTextBox.Multiline = true;
            this.RoomTextBox.Name = "RoomTextBox";
            this.RoomTextBox.ReadOnly = true;
            this.RoomTextBox.Size = new System.Drawing.Size(640, 102);
            this.RoomTextBox.TabIndex = 2;
            // 
            // RoomLabel
            // 
            this.RoomLabel.AutoSize = true;
            this.RoomLabel.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RoomLabel.Location = new System.Drawing.Point(384, 19);
            this.RoomLabel.Name = "RoomLabel";
            this.RoomLabel.Size = new System.Drawing.Size(81, 35);
            this.RoomLabel.TabIndex = 1;
            this.RoomLabel.Text = "label1";
            // 
            // RoomPictureBox
            // 
            this.RoomPictureBox.Location = new System.Drawing.Point(27, 22);
            this.RoomPictureBox.Name = "RoomPictureBox";
            this.RoomPictureBox.Size = new System.Drawing.Size(327, 229);
            this.RoomPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RoomPictureBox.TabIndex = 0;
            this.RoomPictureBox.TabStop = false;
            // 
            // RoomPanel
            // 
            this.RoomPanel.Controls.Add(this.CommentPanel);
            this.RoomPanel.Controls.Add(this.BronButton);
            this.RoomPanel.Controls.Add(this.dateTimePicker2);
            this.RoomPanel.Controls.Add(this.label2);
            this.RoomPanel.Controls.Add(this.dateTimePicker1);
            this.RoomPanel.Controls.Add(this.label1);
            this.RoomPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RoomPanel.Location = new System.Drawing.Point(0, 270);
            this.RoomPanel.Name = "RoomPanel";
            this.RoomPanel.Size = new System.Drawing.Size(1037, 315);
            this.RoomPanel.TabIndex = 1;
            // 
            // CommentPanel
            // 
            this.CommentPanel.Controls.Add(this.CommentButton);
            this.CommentPanel.Controls.Add(this.CommentComboBox);
            this.CommentPanel.Controls.Add(this.label5);
            this.CommentPanel.Controls.Add(this.CommentTextBox);
            this.CommentPanel.Controls.Add(this.label4);
            this.CommentPanel.Location = new System.Drawing.Point(168, 116);
            this.CommentPanel.Name = "CommentPanel";
            this.CommentPanel.Size = new System.Drawing.Size(736, 187);
            this.CommentPanel.TabIndex = 5;
            // 
            // CommentButton
            // 
            this.CommentButton.Location = new System.Drawing.Point(577, 115);
            this.CommentButton.Name = "CommentButton";
            this.CommentButton.Size = new System.Drawing.Size(142, 58);
            this.CommentButton.TabIndex = 4;
            this.CommentButton.Text = "Отправить";
            this.CommentButton.UseVisualStyleBackColor = true;
            this.CommentButton.Click += new System.EventHandler(this.CommentButton_Click);
            // 
            // CommentComboBox
            // 
            this.CommentComboBox.FormattingEnabled = true;
            this.CommentComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.CommentComboBox.Location = new System.Drawing.Point(577, 41);
            this.CommentComboBox.Name = "CommentComboBox";
            this.CommentComboBox.Size = new System.Drawing.Size(142, 33);
            this.CommentComboBox.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(572, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ваша оценка:";
            // 
            // CommentTextBox
            // 
            this.CommentTextBox.Location = new System.Drawing.Point(15, 41);
            this.CommentTextBox.Multiline = true;
            this.CommentTextBox.Name = "CommentTextBox";
            this.CommentTextBox.Size = new System.Drawing.Size(538, 133);
            this.CommentTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Оставьте отзыв";
            // 
            // BronButton
            // 
            this.BronButton.Location = new System.Drawing.Point(667, 22);
            this.BronButton.Name = "BronButton";
            this.BronButton.Size = new System.Drawing.Size(212, 66);
            this.BronButton.TabIndex = 4;
            this.BronButton.Text = "Забронировать";
            this.BronButton.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(353, 58);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(291, 30);
            this.dateTimePicker2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(189, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Дата выезда";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(353, 22);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(291, 30);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(189, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дата заезда";
            // 
            // SaveRoomButton
            // 
            this.SaveRoomButton.Location = new System.Drawing.Point(904, 34);
            this.SaveRoomButton.Name = "SaveRoomButton";
            this.SaveRoomButton.Size = new System.Drawing.Size(121, 35);
            this.SaveRoomButton.TabIndex = 5;
            this.SaveRoomButton.Text = "Сохранить";
            this.SaveRoomButton.UseVisualStyleBackColor = true;
            this.SaveRoomButton.Click += new System.EventHandler(this.SaveRoomButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(385, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Цена:";
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PriceTextBox.Location = new System.Drawing.Point(455, 189);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(116, 23);
            this.PriceTextBox.TabIndex = 7;
            this.PriceTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PriceTextBox_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(577, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "руб.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(958, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 25);
            this.label8.TabIndex = 11;
            this.label8.Text = "шт.";
            // 
            // QuantityTextBox
            // 
            this.QuantityTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QuantityTextBox.Location = new System.Drawing.Point(837, 189);
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.Size = new System.Drawing.Size(116, 23);
            this.QuantityTextBox.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(701, 192);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 25);
            this.label9.TabIndex = 9;
            this.label9.Text = "Количество:";
            // 
            // STextBox
            // 
            this.STextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.STextBox.Location = new System.Drawing.Point(547, 228);
            this.STextBox.Name = "STextBox";
            this.STextBox.Size = new System.Drawing.Size(78, 23);
            this.STextBox.TabIndex = 12;
            // 
            // SaveParamButton
            // 
            this.SaveParamButton.Location = new System.Drawing.Point(904, 226);
            this.SaveParamButton.Name = "SaveParamButton";
            this.SaveParamButton.Size = new System.Drawing.Size(121, 35);
            this.SaveParamButton.TabIndex = 13;
            this.SaveParamButton.Text = "Сохранить";
            this.SaveParamButton.UseVisualStyleBackColor = true;
            this.SaveParamButton.Click += new System.EventHandler(this.SaveParamButton_Click);
            // 
            // RoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 585);
            this.Controls.Add(this.RoomPanel);
            this.Controls.Add(this.InfoPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RoomForm";
            this.Text = "RoomForm";
            this.InfoPanel.ResumeLayout(false);
            this.InfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoomPictureBox)).EndInit();
            this.RoomPanel.ResumeLayout(false);
            this.RoomPanel.PerformLayout();
            this.CommentPanel.ResumeLayout(false);
            this.CommentPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel InfoPanel;
        private System.Windows.Forms.TextBox RoomTextBox;
        private System.Windows.Forms.Label RoomLabel;
        private System.Windows.Forms.PictureBox RoomPictureBox;
        private System.Windows.Forms.Panel RoomPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BronButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel CommentPanel;
        private System.Windows.Forms.Button CommentButton;
        private System.Windows.Forms.ComboBox CommentComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CommentTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox QuantityTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button SaveRoomButton;
        private System.Windows.Forms.Button SaveParamButton;
        private System.Windows.Forms.TextBox STextBox;
    }
}