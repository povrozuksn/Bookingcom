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
    public partial class AdminBookingForm : Form
    {
        public AdminBookingForm()
        {
            InitializeComponent();
        }

        private void AdminBookingForm_Load(object sender, EventArgs e)
        {
            List<string> bookinglist = SQLClass.MySelect(
                "SELECT booking.room_id, booking.user, booking.dateFrom, booking.dateTo, " +
                        "rooms.name, hotels.name" + 
                " FROM booking" +
                  " JOIN rooms ON rooms.id = booking.room_id" +
                  " JOIN hotels ON hotels.id = rooms.id_hotel" +
                " ORDER BY booking.dateFrom");
            
            InfoBookingPanel.Controls.Clear();
            InfoBookingPanel.Controls.Add(label1);
            InfoBookingPanel.Controls.Add(label2);
            InfoBookingPanel.Controls.Add(label3);
            InfoBookingPanel.Controls.Add(label4);
            InfoBookingPanel.Controls.Add(label5);

            int y = 40;
            for(int i=0; i< bookinglist.Count; i+=6)
            {
                #region Пользователь
                Label lbl = new Label();
                lbl.Location = new Point(10, y);
                lbl.Size = new Size(150, 25);
                lbl.Text = bookinglist[i+1];
                InfoBookingPanel.Controls.Add(lbl);
                #endregion

                #region Дата заезда
                Label lbl1 = new Label();
                lbl1.Location = new Point(250, y);
                lbl1.Size = new Size(150, 25);
                lbl1.Text = bookinglist[i + 2];
                InfoBookingPanel.Controls.Add(lbl1);
                #endregion

                #region Дата выезда
                Label lbl2 = new Label();
                lbl2.Location = new Point(450, y);
                lbl2.Size = new Size(150, 25);
                lbl2.Text = bookinglist[i + 3];
                InfoBookingPanel.Controls.Add(lbl2);
                #endregion

                #region Номер
                Label lbl3 = new Label();
                lbl3.Location = new Point(650, y);
                lbl3.Size = new Size(250, 25);
                lbl3.Text = bookinglist[i + 4];
                InfoBookingPanel.Controls.Add(lbl3);
                #endregion

                #region Гостиница
                Label lbl4 = new Label();
                lbl4.Location = new Point(900, y);
                lbl4.Size = new Size(250, 25);
                lbl4.Text = bookinglist[i + 5];
                InfoBookingPanel.Controls.Add(lbl4);
                #endregion

                y += 30;
            }

        }
    }
}
