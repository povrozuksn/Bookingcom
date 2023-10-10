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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HotelForm));
            this.HotelPanel = new System.Windows.Forms.Panel();
            this.HotelTextBox = new System.Windows.Forms.TextBox();
            this.HotelLabel = new System.Windows.Forms.Label();
            this.HotelPictureBox = new System.Windows.Forms.PictureBox();
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.HotelPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HotelPictureBox)).BeginInit();
            this.InfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // HotelPanel
            // 
            this.HotelPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            // HotelTextBox
            // 
            this.HotelTextBox.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HotelTextBox.Location = new System.Drawing.Point(415, 148);
            this.HotelTextBox.Multiline = true;
            this.HotelTextBox.Name = "HotelTextBox";
            this.HotelTextBox.ReadOnly = true;
            this.HotelTextBox.Size = new System.Drawing.Size(458, 116);
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
            this.InfoPanel.Controls.Add(this.pictureBox4);
            this.InfoPanel.Controls.Add(this.label1);
            this.InfoPanel.Controls.Add(this.pictureBox2);
            this.InfoPanel.Controls.Add(this.label8);
            this.InfoPanel.Controls.Add(this.pictureBox3);
            this.InfoPanel.Controls.Add(this.label7);
            this.InfoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfoPanel.Location = new System.Drawing.Point(0, 288);
            this.InfoPanel.Margin = new System.Windows.Forms.Padding(4);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(1163, 321);
            this.InfoPanel.TabIndex = 1;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(650, 77);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(270, 184);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "Номер Люкс";
            this.pictureBox4.Click += new System.EventHandler(this.Room_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(646, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Номер Люкс";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(337, 77);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(270, 184);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "Номер Двухместный";
            this.pictureBox2.Click += new System.EventHandler(this.Room_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(333, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(168, 24);
            this.label8.TabIndex = 6;
            this.label8.Text = "Номер Двухместный";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(22, 77);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(270, 184);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "Номер Одноместный";
            this.pictureBox3.Click += new System.EventHandler(this.Room_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 24);
            this.label7.TabIndex = 4;
            this.label7.Text = "Номер Одноместный";
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
            this.InfoPanel.ResumeLayout(false);
            this.InfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HotelPanel;
        private System.Windows.Forms.Panel InfoPanel;
        private System.Windows.Forms.TextBox HotelTextBox;
        private System.Windows.Forms.Label HotelLabel;
        private System.Windows.Forms.PictureBox HotelPictureBox;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label7;
    }
}