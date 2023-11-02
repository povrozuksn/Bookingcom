using System;
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

            List<string> users = SQLClass.MySelect("SELECT name, family FROM users");
            int y = 50;
            for (int i = 0; i < users.Count; i += 2)
            {
                Label lbl = new Label();
                lbl.Location = new Point(20, y);
                lbl.Size = new Size(220, 30);
                lbl.Font = new Font("Arial Narrow", 13);
                lbl.Text = users[i];
                InfoUsersPanel.Controls.Add(lbl);

                Label lbl1 = new Label();
                lbl1.Location = new Point(300, y);
                lbl1.Size = new Size(220, 30);
                lbl1.Font = new Font("Arial Narrow", 13);
                lbl1.Text = users[i + 1];
                InfoUsersPanel.Controls.Add(lbl1);

                y += 35;
            }
        }
    }
}
