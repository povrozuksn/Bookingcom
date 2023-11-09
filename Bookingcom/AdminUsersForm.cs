﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookingcom
{
    public partial class AdminUsersForm : Form
    {
        public AdminUsersForm()
        {
            InitializeComponent();

        }

        private void AdminUsersForm_Load(object sender, EventArgs e)
        {
            InfoUsersPanel.Controls.Clear();
            InfoUsersPanel.Controls.Add(label1);
            InfoUsersPanel.Controls.Add(label2);
            List<string> users = SQLClass.MySelect("SELECT id, name, family FROM users");
            int y = 50;
            for (int i = 0; i < users.Count; i += 3)
            {
                Label lbl = new Label();
                lbl.Location = new Point(20, y);
                lbl.Size = new Size(220, 30);
                lbl.Font = new Font("Arial Narrow", 13);
                lbl.Tag = users[i];
                lbl.Text = users[i+1];
                InfoUsersPanel.Controls.Add(lbl);

                Label lbl1 = new Label();
                lbl1.Location = new Point(300, y);
                lbl1.Size = new Size(220, 30);
                lbl1.Font = new Font("Arial Narrow", 13);
                lbl1.Text = users[i+2];
                InfoUsersPanel.Controls.Add(lbl1);

                Button btn = new Button();
                btn.Location = new Point(800, y);
                btn.Size = new Size(100, 30);
                btn.Font = new Font("Arial Narrow", 12);
                btn.Click += new EventHandler(DeleteUserClick);
                btn.Text = "Удалить";
                InfoUsersPanel.Controls.Add(btn);

                y += 35;
            }
        }

        private void DeleteUserClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int y = btn.Location.Y;

            foreach (Control control in InfoUsersPanel.Controls)
            {
                if (control.Location == new Point(20, y))
                {
                    SQLClass.MyUpDate("DELETE FROM users WHERE id = '" + control.Tag + "'");
                    MessageBox.Show("Удаление успешно");
                    AdminUsersForm_Load(sender, e);
                }
            }
        }

    }
}
