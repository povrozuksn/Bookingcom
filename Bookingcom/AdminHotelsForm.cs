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
    public partial class AdminHotelsForm : Form
    {
        public AdminHotelsForm()
        {
            InitializeComponent();

            List<string> hotels = SQLClass.MySelect("SELECT name, name_city, rating FROM hotels");
            int y = 50;
            for (int i = 0; i < hotels.Count; i += 3)
            {
                Label lbl = new Label();
                lbl.Location = new Point(20, y);
                lbl.Size = new Size(220, 30);
                lbl.Font = new Font("Arial Narrow", 13);
                lbl.Text = hotels[i];
                InfoHotelsPanel.Controls.Add(lbl);

                Label lbl1 = new Label();
                lbl1.Location = new Point(250, y);
                lbl1.Size = new Size(120, 30);
                lbl1.Font = new Font("Arial Narrow", 13);
                lbl1.Text = hotels[i+1];
                InfoHotelsPanel.Controls.Add(lbl1);

                Label lbl2 = new Label();
                lbl2.Location = new Point(450, y);
                lbl2.Size = new Size(220, 30);
                lbl2.Font = new Font("Arial Narrow", 13);
                lbl2.Text = hotels[i+2];
                InfoHotelsPanel.Controls.Add(lbl2);

                y += 35;
            }
        }
    }
}
