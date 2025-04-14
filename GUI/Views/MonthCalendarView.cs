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
using Windows.UI.Notifications;
using DataModel.Types;
using NotificationsSystem.GUI.Widgets;

namespace NotificationsSystem.GUI.Views
{
    public partial class MonthCalendarView : UserControl
    {
        private List<NotificationDTO> _notifications = new List<NotificationDTO>();

        public MonthCalendarView(List<NotificationDTO> notifications)
        {
            InitializeComponent();
            _notifications.AddRange(notifications.Where(x => x.IsActive));
        }

        public void SetNotifi(List<NotificationDTO> notifications)
        {
            _notifications.Clear();
            _notifications.AddRange(notifications.Where(x => x.IsActive));

            customCalendar1.NotificationDates.Clear();
            var tmp = new Dictionary<DateTime, NotificationType>();
            foreach (var item in _notifications)
            {
                customCalendar1.NotificationDates[item.NotificationDateTime.Date] = (NotificationType)item.NotificationType;
            }
            customCalendar1.Refresh();
        }

        private void MonthCalendarView_Load(object sender, EventArgs e)
        {
            customCalendar1.NotificationDates.Clear();
            var tmp = new Dictionary<DateTime, NotificationType>();
            foreach (var item in _notifications)
            {
                customCalendar1.NotificationDates[item.NotificationDateTime.Date] = (NotificationType)item.NotificationType;
            }
            customCalendar1.Refresh();
        }
    }
}
