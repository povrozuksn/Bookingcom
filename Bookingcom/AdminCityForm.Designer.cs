namespace Bookingcom
{
    partial class AdminCityForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.InfoCityPanel = new System.Windows.Forms.Panel();
            this.AddCityPanel = new System.Windows.Forms.Panel();
            this.InfoCityPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Список городов в БД";
            // 
            // InfoCityPanel
            // 
            this.InfoCityPanel.Controls.Add(this.label1);
            this.InfoCityPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.InfoCityPanel.Location = new System.Drawing.Point(0, 0);
            this.InfoCityPanel.Name = "InfoCityPanel";
            this.InfoCityPanel.Size = new System.Drawing.Size(348, 648);
            this.InfoCityPanel.TabIndex = 1;
            // 
            // AddCityPanel
            // 
            this.AddCityPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.AddCityPanel.Location = new System.Drawing.Point(354, 0);
            this.AddCityPanel.Name = "AddCityPanel";
            this.AddCityPanel.Size = new System.Drawing.Size(553, 648);
            this.AddCityPanel.TabIndex = 2;
            // 
            // AdminCityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 648);
            this.Controls.Add(this.AddCityPanel);
            this.Controls.Add(this.InfoCityPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AdminCityForm";
            this.Text = "AdminCityForm";
            this.InfoCityPanel.ResumeLayout(false);
            this.InfoCityPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel InfoCityPanel;
        private System.Windows.Forms.Panel AddCityPanel;
    }
}