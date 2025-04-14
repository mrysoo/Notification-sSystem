using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationsSystem.GUI.Widgets
{
    internal class ToggleStateButton : CheckBox
    {
        private Color onBackColor = Color.MediumSlateBlue;
        private Color onToggleColor = Color.WhiteSmoke;
        private Color midLowBackColor = Color.SteelBlue;  // Цвет для промежуточного низкого состояния
        private Color midLowToggleColor = Color.DarkGray;  // Цвет для промежуточного низкого состояния
        private Color offBackColor = Color.Gray;
        private Color offToggleColor = Color.Gainsboro;
        private bool solidStyle = true;

        public event EventHandler StateChanged;

        private int state = 0;  // 0 - Off, 1 - Mid Low, 2 - On

        public Color OnBackColor
        {
            get => onBackColor;
            set
            {
                onBackColor = value;
                this.Invalidate();
            }
        }

        public Color OnToggleColor
        {
            get => onToggleColor;
            set
            {
                onToggleColor = value;
                this.Invalidate();
            }
        }

        public Color MidLowBackColor
        {
            get => midLowBackColor;
            set
            {
                midLowBackColor = value;
                this.Invalidate();
            }
        }

        public Color MidLowToggleColor
        {
            get => midLowToggleColor;
            set
            {
                midLowToggleColor = value;
                this.Invalidate();
            }
        }

        public Color OffBackColor
        {
            get => offBackColor;
            set
            {
                offBackColor = value;
                this.Invalidate();
            }
        }

        public Color OffToggleColor
        {
            get => offToggleColor;
            set
            {
                offToggleColor = value;
                this.Invalidate();
            }
        }

        [DefaultValue(true)]
        public bool SolidStyle
        {
            get => solidStyle;
            set
            {
                solidStyle = value;
                this.Invalidate();
            }
        }

        public int State
        {
            get => state;
            set
            {
                if (state != value % 3) // Проверка на изменение состояния
                {
                    state = value % 3;
                    OnStateChanged(EventArgs.Empty); // Вызов события
                    this.Invalidate(); // Перерисовка элемента управления
                }
            }
        }

        public ToggleStateButton()
        {
            this.MinimumSize = new Size(80, 22); // Увеличение размера для размещения четырех положений
            this.Click += ToggleState;
        }

        private void ToggleState(object sender, EventArgs e)
        {
            State = (State + 1) % 3;  // Переключение состояния 0 -> 1 -> 2 -> 3 -> 0
        }

        private GraphicsPath GetFigurePath()
        {
            int arcSize = this.Height - 1;
            Rectangle leftArc = new Rectangle(0, 0, arcSize, arcSize);
            Rectangle rightArc = new Rectangle(this.Width - arcSize - 2, 0, arcSize, arcSize);

            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(leftArc, 90, 180);
            path.AddArc(rightArc, 270, 180);
            path.CloseFigure();

            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            int toggleSize = this.Height - 5;
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            pevent.Graphics.Clear(this.Parent.BackColor);

            switch (State)
            {
                case 0:
                    // Off state
                    if (solidStyle)
                        pevent.Graphics.FillPath(new SolidBrush(offBackColor), GetFigurePath());
                    else
                        pevent.Graphics.DrawPath(new Pen(offBackColor, 2), GetFigurePath());

                    pevent.Graphics.FillEllipse(new SolidBrush(offToggleColor), new Rectangle(2, 2, toggleSize, toggleSize));
                    break;

                case 1:
                    // Mid Low state
                    if (solidStyle)
                        pevent.Graphics.FillPath(new SolidBrush(midLowBackColor), GetFigurePath());
                    else
                        pevent.Graphics.DrawPath(new Pen(midLowBackColor, 2), GetFigurePath());

                    pevent.Graphics.FillEllipse(new SolidBrush(midLowToggleColor), new Rectangle((this.Width / 2) - (toggleSize / 2), 2, toggleSize, toggleSize));
                    break;

                case 2:
                    // On state
                    if (solidStyle)
                        pevent.Graphics.FillPath(new SolidBrush(onBackColor), GetFigurePath());
                    else
                        pevent.Graphics.DrawPath(new Pen(onBackColor, 2), GetFigurePath());

                    pevent.Graphics.FillEllipse(new SolidBrush(onToggleColor), new Rectangle(this.Width - this.Height + 1, 2, toggleSize, toggleSize));
                    break;
            }
        }

        // Метод для вызова события StateChanged
        protected virtual void OnStateChanged(EventArgs e)
        {
            StateChanged?.Invoke(this, e);
        }
    }
}
