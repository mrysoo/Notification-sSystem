using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NotifiCommHub.Services;
using DataModel.Types;
using Microsoft.Extensions.DependencyInjection;
using DataModel.DataBase;

namespace NotificationsSystem.GUI.Views
{
    public partial class CreateNotifiView : UserControl
    {
        private readonly UserStorage _userStorage;

        public delegate void UpdateCallBack(NotificationDTO notification);
        public event UpdateCallBack UpdateEvent;

        public CreateNotifiView(UserStorage userStorage)
        {
            _userStorage = userStorage;

            InitializeComponent();
        }

        private void CreateNotifiView_Load(object sender, EventArgs e)
        {
            dateTimePicker2.ShowUpDown = true;
            dateTimePicker1.MinDate = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
        }

        private async void rjButton2_Click(object sender, EventArgs e)
        {
            try
            {
                using (var scope = Program.ServiceProvider.CreateScope())
                {
                    var notificationService = scope.ServiceProvider.GetRequiredService<INotificationService>();

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

                    var notification =  await notificationService.CreateNotification(DateTime.Now, notifiDateTime, (NotificationType)toggleStateButton1.State, textBox1.Text, richTextBox1.Text, _userStorage.CurrentUser);

                    UpdateEvent?.Invoke(notification);

                    textBox1.Text = "";
                    richTextBox1.Text = "";
                    dateTimePicker1.Value = DateTime.Now;
                    dateTimePicker2.Value = DateTime.Now;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error ex: {ex}");
                throw;
            }
        }
    }
}
