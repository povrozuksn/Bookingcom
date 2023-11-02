namespace Bookingcom
{
    partial class AdminForm
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
            this.AdminCityButton = new System.Windows.Forms.Button();
            this.AdminHotelsButton = new System.Windows.Forms.Button();
            this.AdminRoomsButton = new System.Windows.Forms.Button();
            this.AdminUsersButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AdminCityButton
            // 
            this.AdminCityButton.Location = new System.Drawing.Point(134, 115);
            this.AdminCityButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AdminCityButton.Name = "AdminCityButton";
            this.AdminCityButton.Size = new System.Drawing.Size(233, 61);
            this.AdminCityButton.TabIndex = 0;
            this.AdminCityButton.Text = "Города";
            this.AdminCityButton.UseVisualStyleBackColor = true;
            this.AdminCityButton.Click += new System.EventHandler(this.AdminCityButton_Click);
            // 
            // AdminHotelsButton
            // 
            this.AdminHotelsButton.Location = new System.Drawing.Point(134, 209);
            this.AdminHotelsButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AdminHotelsButton.Name = "AdminHotelsButton";
            this.AdminHotelsButton.Size = new System.Drawing.Size(233, 61);
            this.AdminHotelsButton.TabIndex = 1;
            this.AdminHotelsButton.Text = "Гостиницы";
            this.AdminHotelsButton.UseVisualStyleBackColor = true;
            this.AdminHotelsButton.Click += new System.EventHandler(this.AdminHotelsButton_Click);
            // 
            // AdminRoomsButton
            // 
            this.AdminRoomsButton.Location = new System.Drawing.Point(134, 306);
            this.AdminRoomsButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AdminRoomsButton.Name = "AdminRoomsButton";
            this.AdminRoomsButton.Size = new System.Drawing.Size(233, 61);
            this.AdminRoomsButton.TabIndex = 2;
            this.AdminRoomsButton.Text = "Номера";
            this.AdminRoomsButton.UseVisualStyleBackColor = true;
            this.AdminRoomsButton.Click += new System.EventHandler(this.AdminRoomsButton_Click);
            // 
            // AdminUsersButton
            // 
            this.AdminUsersButton.Location = new System.Drawing.Point(134, 406);
            this.AdminUsersButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AdminUsersButton.Name = "AdminUsersButton";
            this.AdminUsersButton.Size = new System.Drawing.Size(233, 61);
            this.AdminUsersButton.TabIndex = 3;
            this.AdminUsersButton.Text = "Пользователи";
            this.AdminUsersButton.UseVisualStyleBackColor = true;
            this.AdminUsersButton.Click += new System.EventHandler(this.AdminUsersButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Форма администрирования БД";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(506, 513);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AdminUsersButton);
            this.Controls.Add(this.AdminRoomsButton);
            this.Controls.Add(this.AdminHotelsButton);
            this.Controls.Add(this.AdminCityButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AdminForm";
            this.Text = "Панель администратора";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AdminCityButton;
        private System.Windows.Forms.Button AdminHotelsButton;
        private System.Windows.Forms.Button AdminRoomsButton;
        private System.Windows.Forms.Button AdminUsersButton;
        private System.Windows.Forms.Label label1;
    }
}