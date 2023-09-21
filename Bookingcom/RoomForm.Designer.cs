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
            this.RoomTextBox = new System.Windows.Forms.TextBox();
            this.RoomLabel = new System.Windows.Forms.Label();
            this.RoomPictureBox = new System.Windows.Forms.PictureBox();
            this.RoomPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.BronButton = new System.Windows.Forms.Button();
            this.InfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoomPictureBox)).BeginInit();
            this.RoomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // InfoPanel
            // 
            this.InfoPanel.Controls.Add(this.RoomTextBox);
            this.InfoPanel.Controls.Add(this.RoomLabel);
            this.InfoPanel.Controls.Add(this.RoomPictureBox);
            this.InfoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.InfoPanel.Location = new System.Drawing.Point(0, 0);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(1037, 270);
            this.InfoPanel.TabIndex = 0;
            // 
            // RoomTextBox
            // 
            this.RoomTextBox.Location = new System.Drawing.Point(385, 75);
            this.RoomTextBox.Multiline = true;
            this.RoomTextBox.Name = "RoomTextBox";
            this.RoomTextBox.Size = new System.Drawing.Size(533, 164);
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
            this.RoomPanel.Controls.Add(this.BronButton);
            this.RoomPanel.Controls.Add(this.dateTimePicker2);
            this.RoomPanel.Controls.Add(this.label2);
            this.RoomPanel.Controls.Add(this.dateTimePicker1);
            this.RoomPanel.Controls.Add(this.label1);
            this.RoomPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RoomPanel.Location = new System.Drawing.Point(0, 270);
            this.RoomPanel.Name = "RoomPanel";
            this.RoomPanel.Size = new System.Drawing.Size(1037, 280);
            this.RoomPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(61, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дата заезда";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(225, 57);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(291, 30);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(225, 109);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(291, 30);
            this.dateTimePicker2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(61, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Дата выезда";
            // 
            // BronButton
            // 
            this.BronButton.Location = new System.Drawing.Point(539, 57);
            this.BronButton.Name = "BronButton";
            this.BronButton.Size = new System.Drawing.Size(212, 82);
            this.BronButton.TabIndex = 4;
            this.BronButton.Text = "Забронировать";
            this.BronButton.UseVisualStyleBackColor = true;
            // 
            // RoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 550);
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
    }
}