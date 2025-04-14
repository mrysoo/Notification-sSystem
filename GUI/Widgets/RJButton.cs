using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationsSystem.GUI.Widgets
{
    public class RJButton : Button
    {
        private int border_size = 0;
        private int border_radius = 40;
        private Color border_color = Color.PaleVioletRed;


        #region Propertis
        public int Border_size
        {
            get
            {
                return border_size;
            }
            set
            {
                border_size = value;
                Invalidate();
            }

        }
        public int Border_radius
        {
            get
            {
                return border_radius;
            }
            set
            {
                if (value <= Height)
                    border_radius = value;
                else
                    border_radius = Height;
                Invalidate();
            }
        }
        public Color Border_color
        {
            get
            {
                return border_color;
            }
            set
            {
                border_color = value;
                Invalidate();
            }
        }
        public Color Background_color
        {
            get
            {
                return BackColor;
            }
            set
            {
                BackColor = value;
            }
        }
        public Color Fore_color
        {
            get
            {
                return ForeColor;
            }
            set
            {
                ForeColor = value;
            }
        }
        #endregion

        public RJButton()
        {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            Size = new Size(150, 40);
            BackColor = Color.MediumSlateBlue;
            ForeColor = Color.White;
            Resize += new EventHandler(button_resize);
        }


        private GraphicsPath get_figure_path(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            RectangleF rect_surface = new RectangleF(0, 0, Width, Height);
            RectangleF rect_border = new RectangleF(1, 1, Width - 0.8f, Height - 1);

            if (border_radius > 2) // Rouder button
            {
                using (GraphicsPath path_surface = get_figure_path(rect_surface, border_radius))
                using (GraphicsPath path_border = get_figure_path(rect_border, border_radius - 1f))
                using (Pen pen_surface = new Pen(Parent.BackColor, 2))
                using (Pen pen_border = new Pen(border_color, border_size))
                {
                    pen_border.Alignment = PenAlignment.Inset;

                    // Button surface
                    Region = new Region(path_surface);

                    // Draw surface border for HD result
                    pevent.Graphics.DrawPath(pen_surface, path_surface);

                    // Button border
                    if (border_size >= 1)
                        // Draw control border
                        pevent.Graphics.DrawPath(pen_border, path_border);
                }
            }
            else // Normal button
            {
                // Button surface
                Region = new Region(rect_surface);

                // Button border
                if (border_size >= 1)
                {
                    using (Pen pen_border = new Pen(border_color, border_size))
                    {
                        pen_border.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(pen_border, 0, 0, Width - 1, Height - 1);
                    }
                }
            }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            Parent.BackColorChanged += new EventHandler(Container_BackColor_changed);
        }

        private void Container_BackColor_changed(object sender, EventArgs e)
        {
            if (DesignMode)
                Invalidate();
        }
        private void button_resize(object sender, EventArgs e)
        {
            if (border_radius > Height)
                border_radius = Height;
        }
    }
}
