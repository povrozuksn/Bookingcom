namespace Bookingcom
{
    partial class HotelForm
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
            this.HotelPanel = new System.Windows.Forms.Panel();
            this.AddDescButton = new System.Windows.Forms.Button();
            this.HotelTextBox = new System.Windows.Forms.TextBox();
            this.HotelLabel = new System.Windows.Forms.Label();
            this.HotelPictureBox = new System.Windows.Forms.PictureBox();
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.AdressTextBox = new System.Windows.Forms.TextBox();
            this.TelTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.HotelPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HotelPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // HotelPanel
            // 
            this.HotelPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.HotelPanel.Controls.Add(this.label2);
            this.HotelPanel.Controls.Add(this.label1);
            this.HotelPanel.Controls.Add(this.TelTextBox);
            this.HotelPanel.Controls.Add(this.AdressTextBox);
            this.HotelPanel.Controls.Add(this.AddDescButton);
            this.HotelPanel.Controls.Add(this.HotelTextBox);
            this.HotelPanel.Controls.Add(this.HotelLabel);
            this.HotelPanel.Controls.Add(this.HotelPictureBox);
            this.HotelPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HotelPanel.Location = new System.Drawing.Point(0, 0);
            this.HotelPanel.Margin = new System.Windows.Forms.Padding(4);
            this.HotelPanel.Name = "HotelPanel";
            this.HotelPanel.Size = new System.Drawing.Size(1163, 288);
            this.HotelPanel.TabIndex = 0;
            // 
            // AddDescButton
            // 
            this.AddDescButton.Location = new System.Drawing.Point(1040, 230);
            this.AddDescButton.Name = "AddDescButton";
            this.AddDescButton.Size = new System.Drawing.Size(105, 34);
            this.AddDescButton.TabIndex = 6;
            this.AddDescButton.Text = "Сохранить";
            this.AddDescButton.UseVisualStyleBackColor = true;
            this.AddDescButton.Click += new System.EventHandler(this.AddDescButton_Click);
            // 
            // HotelTextBox
            // 
            this.HotelTextBox.Enabled = false;
            this.HotelTextBox.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HotelTextBox.Location = new System.Drawing.Point(415, 129);
            this.HotelTextBox.Multiline = true;
            this.HotelTextBox.Name = "HotelTextBox";
            this.HotelTextBox.ReadOnly = true;
            this.HotelTextBox.Size = new System.Drawing.Size(619, 135);
            this.HotelTextBox.TabIndex = 3;
            // 
            // HotelLabel
            // 
            this.HotelLabel.AutoSize = true;
            this.HotelLabel.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HotelLabel.Location = new System.Drawing.Point(409, 32);
            this.HotelLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HotelLabel.Name = "HotelLabel";
            this.HotelLabel.Size = new System.Drawing.Size(81, 35);
            this.HotelLabel.TabIndex = 1;
            this.HotelLabel.Text = "label1";
            // 
            // HotelPictureBox
            // 
            this.HotelPictureBox.Location = new System.Drawing.Point(22, 32);
            this.HotelPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.HotelPictureBox.Name = "HotelPictureBox";
            this.HotelPictureBox.Size = new System.Drawing.Size(315, 232);
            this.HotelPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HotelPictureBox.TabIndex = 0;
            this.HotelPictureBox.TabStop = false;
            // 
            // InfoPanel
            // 
            this.InfoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfoPanel.Location = new System.Drawing.Point(0, 288);
            this.InfoPanel.Margin = new System.Windows.Forms.Padding(4);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(1163, 321);
            this.InfoPanel.TabIndex = 1;
            // 
            // AdressTextBox
            // 
            this.AdressTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AdressTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AdressTextBox.Location = new System.Drawing.Point(739, 67);
            this.AdressTextBox.Name = "AdressTextBox";
            this.AdressTextBox.Size = new System.Drawing.Size(295, 23);
            this.AdressTextBox.TabIndex = 7;
            // 
            // TelTextBox
            // 
            this.TelTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TelTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TelTextBox.Location = new System.Drawing.Point(739, 95);
            this.TelTextBox.Name = "TelTextBox";
            this.TelTextBox.Size = new System.Drawing.Size(295, 23);
            this.TelTextBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(676, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Адрес";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(694, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Тел";
            // 
            // HotelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 609);
            this.Controls.Add(this.InfoPanel);
            this.Controls.Add(this.HotelPanel);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HotelForm";
            this.Text = "HotelForm";
            this.Load += new System.EventHandler(this.HotelForm_Load);
            this.HotelPanel.ResumeLayout(false);
            this.HotelPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HotelPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HotelPanel;
        private System.Windows.Forms.Panel InfoPanel;
        private System.Windows.Forms.TextBox HotelTextBox;
        private System.Windows.Forms.Label HotelLabel;
        private System.Windows.Forms.PictureBox HotelPictureBox;
        private System.Windows.Forms.Button AddDescButton;
        private System.Windows.Forms.TextBox AdressTextBox;
        private System.Windows.Forms.TextBox TelTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}