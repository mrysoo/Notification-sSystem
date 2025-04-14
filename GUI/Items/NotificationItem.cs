using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataModel.DataBase;
using NotificationsSystem.GUI.Forms;
using NotifiCommHub.Services;
using Microsoft.Extensions.DependencyInjection;

namespace NotificationsSystem.GUI.Items
{
    public partial class NotificationItem : UserControl
    {
        private readonly NotificationDTO _notification;

        public delegate void UpdateCallBack();
        public event UpdateCallBack UpdateEvent;
        public delegate void UpdateEditCallBack();
        public event UpdateCallBack UpdateEditEvent;

        public NotificationItem(NotificationDTO notification)
        {
            _notification = notification;

            InitializeComponent();
        }

        private void NotificationItem_Load(object sender, EventArgs e)
        {
            try
            {
                dateTimePicker1.Value = _notification.NotificationDateTime;
                dateTimePicker2.Value = _notification.NotificationDateTime;
                label2.Text = _notification.CreateDateTime.ToString("dd.MM.yyyy HH:mm");
                toggleStateButton1.State = _notification.NotificationType;
                rjSwitch1.Checked = _notification.IsActive;

                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
                toggleStateButton1.Enabled = false;
                rjSwitch1.Enabled = false;
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
                var tmpForm = new NotifiContentMF(_notification.Title, _notification.Content, _notification.NotificationDateTime);
                tmpForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error ex: {ex}");
                throw;
            }
        }

        private async void rjButton3_Click(object sender, EventArgs e)
        {
            try
            {
                using (var scope = Program.ServiceProvider.CreateScope())
                {
                    var notificationService = scope.ServiceProvider.GetRequiredService<INotificationService>();

                    await notificationService.DeleteNotificationById(_notification.Id);
                }
                UpdateEvent?.Invoke();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error ex: {ex}");
                throw;
            }
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            try
            {
                var tmpForm = new NotificEditMF(_notification);
                tmpForm.UpdateEvent += Update;
                tmpForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error ex: {ex}");
                throw;
            }
        }

        private async void Update(NotificationDTO notification)
        {
            try
            {
                using (var scope = Program.ServiceProvider.CreateScope())
                {
                    var notificationService = scope.ServiceProvider.GetRequiredService<INotificationService>();

                    await notificationService.UpdateNotification(notification);
                }

                UpdateEvent?.Invoke();
                UpdateEditEvent?.Invoke();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error ex: {ex}");
                throw;
            }
        }
    }
}
