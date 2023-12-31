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
    public partial class HotelForm : Form
    {
        string _idHotel = "";

        public HotelForm(string idHotel)
        {
            _idHotel = idHotel;

            InitializeComponent();

            HotelTextBox.ReadOnly = !Convert.ToBoolean(MainForm.isAdmin);
            HotelTextBox.Enabled = Convert.ToBoolean(MainForm.isAdmin);

            AdressTextBox.ReadOnly = !Convert.ToBoolean(MainForm.isAdmin);
            AdressTextBox.Enabled = Convert.ToBoolean(MainForm.isAdmin);            
            
            TelTextBox.ReadOnly = !Convert.ToBoolean(MainForm.isAdmin);
            TelTextBox.Enabled = Convert.ToBoolean(MainForm.isAdmin);

            if(MainForm.isAdmin == 1)
            {
                AdressTextBox.BorderStyle = BorderStyle.FixedSingle;
                TelTextBox.BorderStyle = BorderStyle.FixedSingle;
                label1.Visible = true; 
                label2.Visible = true;
            }
            else
            {
                AdressTextBox.BorderStyle = BorderStyle.None;
                TelTextBox.BorderStyle = BorderStyle.None;
                label1.Visible = false;
                label2.Visible = false;
            }

            AddDescButton.Visible = Convert.ToBoolean(MainForm.isAdmin);

            List<string> hotel = SQLClass.MySelect("SELECT * FROM hotels WHERE id = " + _idHotel);
            List<string> rooms = SQLClass.MySelect("SELECT id, name, adress_pic, price, kol FROM rooms WHERE id_hotel = " + _idHotel);

            #region Выбранная гостиница на панеле HotelPanel 
            Text = hotel[1] + " : " + hotel[6];
            HotelLabel.Text = hotel[1] + " : " + hotel[6];
            HotelPictureBox.Load("../../Pictures/" + hotel[4]);
            HotelTextBox.Text = hotel[3];

            int ratingHotel = Convert.ToInt32(hotel[2]);
            int x = 415;
            for(int i=0; i< ratingHotel; i++)
            {
                PictureBox box = new PictureBox();
                box.Load("../../Pictures/Star.png");
                box.Location = new Point(x, 70);
                box.Size = new Size(50, 50);
                box.SizeMode = PictureBoxSizeMode.Zoom;
                HotelPanel.Controls.Add(box);

                x += 55;
            }

            AdressTextBox.Text = hotel[7];
            TelTextBox.Text = hotel[8];
            #endregion

            #region Номера выбранной гостиницы на панеле InfoPanel
            int x1 = 20;
            for (int i = 0; i < rooms.Count; i += 5)
            {
                Label lbl = new Label();
                lbl.Location = new Point(x1, 30);
                lbl.Size = new Size(220, 30);
                lbl.Font = new Font("Arial Narrow", 13);
                lbl.Text = rooms[i + 1];
                lbl.Tag = rooms[i];
                lbl.Click += new EventHandler(labelRoom_Click);
                InfoPanel.Controls.Add(lbl);

                PictureBox pb = new PictureBox();
                try
                {
                    pb.Load("../../Pictures/" + rooms[i + 2]);
                }
                catch (Exception) { }
                pb.Location = new Point(x1, 70);
                pb.Size = new Size(270, 184);
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                pb.Tag = rooms[i];
                pb.Click += new EventHandler(Room_Click);
                InfoPanel.Controls.Add(pb);

                Label lbl1 = new Label();
                lbl1.Location = new Point(x1, 255);
                lbl1.Size = new Size(120, 30);
                lbl1.Font = new Font("Arial Narrow", 11);
                lbl1.Text = "Цена, руб.  " + rooms[i + 3];
                InfoPanel.Controls.Add(lbl1);

                Label lbl2 = new Label();
                lbl2.Location = new Point(x1+150, 255);
                lbl2.Size = new Size(120, 30);
                lbl2.Font = new Font("Arial Narrow", 11);
                lbl2.Text = "Кол-во, шт.  " + rooms[i + 4];
                InfoPanel.Controls.Add(lbl2);

                x1 += 320;
            }
            #endregion

        }

        private void HotelForm_Load(object sender, EventArgs e)
        {

        }

        private void Room_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            RoomForm rf = new RoomForm(pb.Tag.ToString());
            rf.ShowDialog();
        }

        private void labelRoom_Click(object sender, EventArgs e)
        {
            Label lb = (Label)sender;
            RoomForm rf = new RoomForm(lb.Tag.ToString());
            rf.ShowDialog();
        }

        private void AddDescButton_Click(object sender, EventArgs e)
        {
            SQLClass.MyUpDate("UPDATE hotels SET opisanie = '" + HotelTextBox.Text + "', adress = '" + AdressTextBox.Text + "', tel = '" + TelTextBox.Text + "' WHERE id = '" + _idHotel + "'");
            MessageBox.Show("Сохранено");
        }
    }
}
