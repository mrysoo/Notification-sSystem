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
using NotificationsSystem.GUI.Items;
using Microsoft.Extensions.DependencyInjection;
using DataModel.Types;
using NotificationsSystem.GUI.Widgets;

namespace NotificationsSystem.GUI.Views
{
    public partial class SelectNotifiView : UserControl
    {
        private readonly UserStorage _userStorage;

        private bool rjCombobox1First = false;
        private bool rjCombobox2First = false;
        private bool rjCombobox3First = false;

        public delegate void UpdateCallBack();
        public event UpdateCallBack UpdateEvent;

        public SelectNotifiView(UserStorage userStorage)
        {
            _userStorage = userStorage;

            InitializeComponent();
        }

        private enum SortValueType : byte
        {
            Create = 0,
            Notifi = 1,
        }

        private enum SortType : byte
        {
            Big = 0,
            Low = 1,
        }
        
        private enum FilterType : byte
        {
            All = 0,
            Active = 1,
            Normal = 2,
            Warn = 3,
            VeryWarn = 4,
        }

        private void SelectNotifiView_Load(object sender, EventArgs e)
        {
            FillPanel1();

            rjCombobox1.Items.Clear();
            rjCombobox2.Items.Clear();
            rjCombobox3.Items.Clear();

            rjCombobox1.Items.AddRange(new string[] { "Дата создания", "Дата уведомления" });
            rjCombobox2.Items.AddRange(new string[] { "По возрастанию", "По убыванию" });
            rjCombobox3.Items.AddRange(new string[] { "Все", "Активные", "Обычные", "Важные", "Очень важные" });

            rjCombobox1.SelectedIndex = 0;
            rjCombobox2.SelectedIndex = 0;
            rjCombobox3.SelectedIndex = 0;
        }

        public async void FillPanel1()
        {
            try
            {
                if (_userStorage.CurrentUser == null)
                {
                    throw new Exception("Нет User");
                }

                using (var scope = Program.ServiceProvider.CreateScope())
                {
                    var notificationService = scope.ServiceProvider.GetRequiredService<INotificationService>();

                    var notifications = await notificationService.GetAllNotificationByUserId(_userStorage.CurrentUser.Id);

                    switch ((FilterType)rjCombobox3.SelectedIndex)
                    {
                        case FilterType.All:
                            break;
                        case FilterType.Active:
                            notifications = notifications.Where(x => x.IsActive).ToList();
                            break;
                        case FilterType.Normal:
                            notifications = notifications.Where(x => (NotificationType)x.NotificationType == NotificationType.Normal).ToList();
                            break;
                        case FilterType.Warn:
                            notifications = notifications.Where(x => (NotificationType)x.NotificationType == NotificationType.Important).ToList();
                            break;
                        case FilterType.VeryWarn:
                            notifications = notifications.Where(x => (NotificationType)x.NotificationType == NotificationType.VeryImportant).ToList();
                            break;
                    }

                    switch ((SortValueType)rjCombobox1.SelectedIndex)
                    {
                        case SortValueType.Create:
                            if ((SortType)rjCombobox2.SelectedIndex == SortType.Big)
                                notifications = notifications.OrderBy(x => x.CreateDateTime).ToList();
                            else
                                notifications = notifications.OrderByDescending(x => x.CreateDateTime).ToList();
                            break;
                        case SortValueType.Notifi:
                            if ((SortType)rjCombobox2.SelectedIndex == SortType.Big)
                                notifications = notifications.OrderBy(x => x.NotificationDateTime).ToList();
                            else
                                notifications = notifications.OrderByDescending(x => x.NotificationDateTime).ToList();
                            break;
                    }

                    panel1.Controls.Clear();

                    for (int i = 0; i < notifications.Count; i++)
                    {
                        var tmp = new NotificationItem(notifications[i]);
                        tmp.UpdateEvent += FillPanel1;
                        tmp.UpdateEditEvent += UpdateEdit;
                        tmp.Location = new Point(0, i * (100 + 20));
                        panel1.Controls.Add(tmp);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error ex: {ex}");
                throw;
            }
        }

        private void rjCombobox1_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (!rjCombobox1First)
            {
                rjCombobox1First = true;
                return;
            }

            FillPanel1();
        }

        private void rjCombobox2_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (!rjCombobox2First)
            {
                rjCombobox2First = true;
                return;
            }

            FillPanel1();
        }

        private void rjCombobox3_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (!rjCombobox3First)
            {
                rjCombobox3First = true;
                return;
            }

            FillPanel1();
        }

        private void UpdateEdit()
        {
            UpdateEvent?.Invoke();
        }
    }
}
