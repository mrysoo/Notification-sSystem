using DataModel.DataBase;
using NotifiCommHub.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotificationsSystem.GUI.Forms
{
    public partial class NotificEditMF : Form
    {
        private readonly NotificationDTO _notification;

        public delegate void UpdateCallBack(NotificationDTO notification);
        public event UpdateCallBack UpdateEvent;

        public NotificEditMF(NotificationDTO notification)
        {
            _notification = notification;

            InitializeComponent();
        }

        private void NotificEditMF_Load(object sender, EventArgs e)
        {
            try
            {
                dateTimePicker1.Value = _notification.NotificationDateTime;
                dateTimePicker2.Value = _notification.NotificationDateTime;
                this.Text = _notification.CreateDateTime.ToString("dd.MM.yyyy HH:mm");
                toggleStateButton1.State = _notification.NotificationType;
                rjSwitch1.Checked = _notification.IsActive;
                textBox1.Text = _notification.Title;
                richTextBox1.Text = _notification.Content;

                dateTimePicker2.ShowUpDown = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error ex: {ex}");
                throw;
            }
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(richTextBox1.Text))
                {
                    MessageBox.Show("Данные пустые");
                    return;
                }

                var notifiDateTime = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day,
                    dateTimePicker2.Value.Hour, dateTimePicker2.Value.Minute, dateTimePicker2.Value.Second);

                if (DateTime.Now >= notifiDateTime)
                {
                    MessageBox.Show("Время уведомления неправильное");
                    return;
                }

                var newNotification = new NotificationDTO
                {
                    Id = _notification.Id,
                    Title = textBox1.Text,
                    Content = richTextBox1.Text,
                    CreateDateTime = _notification.CreateDateTime,
                    NotificationDateTime = notifiDateTime,
                    IsActive = rjSwitch1.Checked,
                    NotificationType = toggleStateButton1.State,
                    UserId = _notification.UserId,
                };

                UpdateEvent?.Invoke(newNotification);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error ex: {ex}");
                throw;
            }
        }
    }
}
