using DataModel.Types;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationsSystem.GUI.Widgets
{
    public class CustomCalendar : Control
    {
        // Словарь дат с уведомлениями: ключ — дата, значение — тип уведомления
        public Dictionary<DateTime, NotificationType> NotificationDates { get; set; } = new Dictionary<DateTime, NotificationType>();

        // Текущий отображаемый месяц
        private DateTime currentMonth = DateTime.Today;
        public DateTime CurrentMonth
        {
            get => currentMonth;
            set
            {
                currentMonth = value;
                Invalidate(); // перерисовка
            }
        }

        // Размеры ячеек и заголовка
        private const int cellWidth = 40;
        private const int cellHeight = 30;
        private const int headerHeight = 40;
        private const int daysHeaderHeight = 20;

        // Размеры кнопок-стрелок
        private Rectangle prevArrowRect;
        private Rectangle nextArrowRect;

        public CustomCalendar()
        {
            // Устанавливаем двойную буферизацию для плавной отрисовки
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint, true);
            this.Size = new Size(cellWidth * 7, headerHeight + daysHeaderHeight + cellHeight * 6);

            int arrowWidth = 30;
            prevArrowRect = new Rectangle(5, 5, arrowWidth, headerHeight - 10);
            nextArrowRect = new Rectangle(this.Width - arrowWidth - 5, 5, arrowWidth, headerHeight - 10);

            this.Resize += (s, e) =>
            {
                nextArrowRect = new Rectangle(this.Width - arrowWidth - 5, 5, arrowWidth, headerHeight - 10);
                Invalidate();
            };
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.Clear(Color.White);

            // Рисуем заголовок (месяц и год)
            string headerText = currentMonth.ToString("Y", CultureInfo.CurrentCulture);
            using (Font headerFont = new Font("Arial", 12, FontStyle.Bold))
            {
                SizeF headerSize = g.MeasureString(headerText, headerFont);
                int textX = (prevArrowRect.Right + nextArrowRect.Left - (int)headerSize.Width) / 2;
                g.DrawString(headerText, headerFont, Brushes.Black, textX, (headerHeight - headerSize.Height) / 2);
            }

            // Рисуем стрелки для переключения месяца
            DrawArrow(g, prevArrowRect, ArrowDirection.Left);
            DrawArrow(g, nextArrowRect, ArrowDirection.Right);

            // Рисуем дни недели
            string[] dayNames = CultureInfo.CurrentCulture.DateTimeFormat.AbbreviatedDayNames;
            for (int i = 0; i < 7; i++)
            {
                Rectangle rect = new Rectangle(i * cellWidth, headerHeight, cellWidth, daysHeaderHeight);
                g.DrawRectangle(Pens.Gray, rect);
                StringFormat sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
                g.DrawString(dayNames[i], this.Font, Brushes.Black, rect, sf);
            }

            // Вычисляем, с какого дня недели начинается месяц
            DateTime firstOfMonth = new DateTime(currentMonth.Year, currentMonth.Month, 1);
            int startDay = (int)firstOfMonth.DayOfWeek;
            int daysInMonth = DateTime.DaysInMonth(currentMonth.Year, currentMonth.Month);
            int dayCounter = 1;

            for (int row = 0; row < 6; row++)
            {
                for (int col = 0; col < 7; col++)
                {
                    int cellIndex = row * 7 + col;
                    Rectangle cellRect = new Rectangle(col * cellWidth, headerHeight + daysHeaderHeight + row * cellHeight, cellWidth, cellHeight);
                    if (cellIndex < startDay || dayCounter > daysInMonth)
                    {
                        g.DrawRectangle(Pens.LightGray, cellRect);
                    }
                    else
                    {
                        DateTime cellDate = new DateTime(currentMonth.Year, currentMonth.Month, dayCounter);
                        // Определяем, если для этой даты задан тип уведомления
                        if (NotificationDates.TryGetValue(cellDate.Date, out NotificationType notifType))
                        {
                            Color fillColor = Color.White;
                            switch (notifType)
                            {
                                case NotificationType.Normal:
                                    fillColor = Color.LightGreen;
                                    break;
                                case NotificationType.Important:
                                    fillColor = Color.PeachPuff;
                                    break;
                                case NotificationType.VeryImportant:
                                    fillColor = Color.LightCoral;
                                    break;
                            }
                            using (SolidBrush sb = new SolidBrush(fillColor))
                            {
                                g.FillRectangle(sb, cellRect);
                            }
                        }
                        else
                        {
                            using (SolidBrush sb = new SolidBrush(Color.White))
                            {
                                g.FillRectangle(sb, cellRect);
                            }
                        }

                        g.DrawRectangle(Pens.Gray, cellRect);
                        StringFormat sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
                        g.DrawString(dayCounter.ToString(), this.Font, Brushes.Black, cellRect, sf);
                        dayCounter++;
                    }
                }
            }
        }

        // Определение направления стрелки
        private enum ArrowDirection { Left, Right }

        // Метод для отрисовки стрелки в заданном прямоугольнике
        private void DrawArrow(Graphics g, Rectangle rect, ArrowDirection direction)
        {
            using (Font arrowFont = new Font("Arial", 12, FontStyle.Bold))
            {
                string arrowChar = direction == ArrowDirection.Left ? "<" : ">";
                StringFormat sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
                g.DrawString(arrowChar, arrowFont, Brushes.Black, rect, sf);
                g.DrawRectangle(Pens.Gray, rect);
            }
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            if (prevArrowRect.Contains(e.Location))
            {
                PreviousMonth();
            }
            else if (nextArrowRect.Contains(e.Location))
            {
                NextMonth();
            }
        }

        public void NextMonth()
        {
            CurrentMonth = currentMonth.AddMonths(1);
        }

        public void PreviousMonth()
        {
            CurrentMonth = currentMonth.AddMonths(-1);
        }
    }
}
