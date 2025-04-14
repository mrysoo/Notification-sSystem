using DataModel.Types;

namespace NotificationsSystem.GUI.Views
{
    partial class MonthCalendarView
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonthCalendarView));
            customCalendar1 = new NotificationsSystem.GUI.Widgets.CustomCalendar();
            SuspendLayout();
            // 
            // customCalendar1
            // 
            customCalendar1.CurrentMonth = new DateTime(2025, 4, 13, 0, 0, 0, 0);
            customCalendar1.Location = new Point(289, 86);
            customCalendar1.Name = "customCalendar1";
            customCalendar1.NotificationDates = (Dictionary<DateTime, NotificationType>)resources.GetObject("customCalendar1.NotificationDates");
            customCalendar1.Size = new Size(280, 240);
            customCalendar1.TabIndex = 0;
            customCalendar1.Text = "customCalendar1";
            // 
            // MonthCalendarView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(customCalendar1);
            Name = "MonthCalendarView";
            Size = new Size(878, 468);
            Load += MonthCalendarView_Load;
            ResumeLayout(false);
        }

        #endregion

        private Widgets.CustomCalendar customCalendar1;
    }
}
