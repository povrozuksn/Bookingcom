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
            this.InfoRoomsPanel.SuspendLayout();
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
            this.AddRoomsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddRoomsPanel.Location = new System.Drawing.Point(0, 330);
            this.AddRoomsPanel.Name = "AddRoomsPanel";
            this.AddRoomsPanel.Size = new System.Drawing.Size(1156, 352);
            this.AddRoomsPanel.TabIndex = 1;
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
            this.InfoRoomsPanel.ResumeLayout(false);
            this.InfoRoomsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel InfoRoomsPanel;
        private System.Windows.Forms.Panel AddRoomsPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}