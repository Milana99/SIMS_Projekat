﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Bolnica.xaml_window.Manager
{
    
    public partial class RenovationSeparationRoomAdd : Window
    {
        
        private RenovationSeparation renovationSeparation;
        private Controller.RoomController roomController;
        public RenovationSeparationRoomAdd(RenovationSeparation renovationSeparation, Controller.RoomController roomController)
        {
            InitializeComponent();
            this.renovationSeparation = renovationSeparation;
            this.roomController = roomController;
            lbuID.Content = roomController.getNextId();
            lbuFloor.Content = renovationSeparation.lbFloor.Content;
            LoadRoomTypes();
            LoadStaticEquipment();
        }
        private void LoadRoomTypes()
        {
            cbRoomType.Items.Add("OperationRoom");
            cbRoomType.Items.Add("HospitalRoom");
            cbRoomType.Items.Add("Ordination");
        }
        private void LoadStaticEquipment()
        {
            Controller.StaticEquipmentController equipmentController = new Controller.StaticEquipmentController();
            foreach (Model.StaticEquipment equipment in equipmentController.GetAllStaticEquipmentForRoom(int.Parse(renovationSeparation.cbRooms.SelectedItem.ToString()))){
                lvDataBindingStaticEqOldRoom.Items.Add(equipment);
            }
        }
        private void Button_Click_Cancel(object sender, RoutedEventArgs e)
        {
            var renovation_division = new RenovationSeparation();
            renovation_division.Show();
            this.Close();
        }

        private void Button_Click_Ok(object sender, RoutedEventArgs e)
        {
            CreateRoom();            
        }
        private void CreateRoom()
        {
            Model.Room room = new Model.Room(int.Parse(lbuID.Content.ToString()), tbuDescription.Text, int.Parse(lbuFloor.Content.ToString()),
                double.Parse(tbuArea.Text), (Model.RoomType)Enum.Parse(typeof(Model.RoomType), cbRoomType.Text));
            if (room.Area > double.Parse(renovationSeparation.lbArea.Content.ToString()))
            {
                MessageBox.Show("Površina ne može biti veća od " + renovationSeparation.lbArea.Content.ToString());
            }
            else
            {
                roomController.CreateRoom(room);
                renovationSeparation.lvDataBindingRooms.Items.Add(room);
                ChangeArea();
                moveStaticEquipment();
                renovationSeparation.Show();
                this.Close();
            }
        }
        private void ChangeArea()
        {
            Model.Room room = roomController.GetByIdRoom(int.Parse(renovationSeparation.cbRooms.SelectedItem.ToString()));
            room.Area -= double.Parse(tbuArea.Text);
            roomController.UpdateRoom(room.RoomId, room.Description, room.Area, room.RoomType);
            renovationSeparation.LoadArea();
        }
        private void moveStaticEquipment()
        {
            for(int i=0; i<lvDataBindingStaticEqNewRoom.Items.Count; i++)
            {
                Model.StaticEquipment equipment = (Model.StaticEquipment)lvDataBindingStaticEqNewRoom.Items[i];
                Controller.StaticEquipmentController staticEquipmentController = new Controller.StaticEquipmentController();
                staticEquipmentController.ChangeRoom(equipment.StaticEquipmentId, int.Parse(lbuID.Content.ToString()));
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            lvDataBindingStaticEqNewRoom.Items.Add(lvDataBindingStaticEqOldRoom.SelectedItem);
            lvDataBindingStaticEqOldRoom.Items.Remove(lvDataBindingStaticEqOldRoom.SelectedItem);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            lvDataBindingStaticEqOldRoom.Items.Add(lvDataBindingStaticEqNewRoom.SelectedItem);
            lvDataBindingStaticEqNewRoom.Items.Remove(lvDataBindingStaticEqNewRoom.SelectedItem);
        }
    }
}
