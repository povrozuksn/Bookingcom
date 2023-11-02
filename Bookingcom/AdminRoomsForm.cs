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
    public partial class AdminRoomsForm : Form
    {
        public AdminRoomsForm()
        {
            InitializeComponent();

            List<string> rooms = SQLClass.MySelect("SELECT name, id_hotel FROM rooms");
            int y = 50;
            for (int i = 0; i < rooms.Count; i+=2)
            {
                Label lbl = new Label();
                lbl.Location = new Point(20, y);
                lbl.Size = new Size(220, 30);
                lbl.Font = new Font("Arial Narrow", 13);
                lbl.Text = rooms[i];
                InfoRoomsPanel.Controls.Add(lbl);

                List<string> hotel = new List<string>();
                hotel.Clear();
                hotel = SQLClass.MySelect("SELECT name FROM hotels WHERE id = " + rooms[i+1]);
                
                Label lbl1 = new Label();
                lbl1.Location = new Point(475, y);
                lbl1.Size = new Size(250, 30);
                lbl1.Font = new Font("Arial Narrow", 13);
                lbl1.Text = hotel[0];
                InfoRoomsPanel.Controls.Add(lbl1);
                
                y += 35;
            }
        }
    }
}
