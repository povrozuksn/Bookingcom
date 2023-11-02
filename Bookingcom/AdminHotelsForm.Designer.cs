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
            this.InfoHotelsPanel.SuspendLayout();
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
            this.AddHotelsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddHotelsPanel.Location = new System.Drawing.Point(0, 312);
            this.AddHotelsPanel.Name = "AddHotelsPanel";
            this.AddHotelsPanel.Size = new System.Drawing.Size(962, 304);
            this.AddHotelsPanel.TabIndex = 1;
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
            this.InfoHotelsPanel.ResumeLayout(false);
            this.InfoHotelsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel InfoHotelsPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel AddHotelsPanel;
    }
}