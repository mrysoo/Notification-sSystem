namespace NotificationsSystem.GUI.Items
{
    partial class NotificationItem
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
            dateTimePicker2 = new DateTimePicker();
            label7 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            toggleStateButton1 = new NotificationsSystem.GUI.Widgets.ToggleStateButton();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            label4 = new Label();
            rjSwitch1 = new NotificationsSystem.GUI.Widgets.RJSwitch();
            rjButton1 = new NotificationsSystem.GUI.Widgets.RJButton();
            rjButton2 = new NotificationsSystem.GUI.Widgets.RJButton();
            rjButton3 = new NotificationsSystem.GUI.Widgets.RJButton();
            SuspendLayout();
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Time;
            dateTimePicker2.Location = new Point(14, 67);
            dateTimePicker2.MinDate = new DateTime(1753, 1, 31, 0, 0, 0, 0);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(181, 23);
            dateTimePicker2.TabIndex = 28;
            dateTimePicker2.Value = new DateTime(2025, 4, 12, 10, 23, 11, 0);
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label7.ForeColor = Color.MediumSlateBlue;
            label7.Location = new Point(14, 10);
            label7.Name = "label7";
            label7.Size = new Size(181, 25);
            label7.TabIndex = 27;
            label7.Text = "День напоминания";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(14, 38);
            dateTimePicker1.MinDate = new DateTime(1753, 1, 31, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(181, 23);
            dateTimePicker1.TabIndex = 26;
            dateTimePicker1.Value = new DateTime(2025, 4, 12, 10, 23, 11, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.MediumSlateBlue;
            label1.Location = new Point(210, 10);
            label1.Name = "label1";
            label1.Size = new Size(141, 25);
            label1.TabIndex = 30;
            label1.Text = "День создания";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.MediumSlateBlue;
            label2.Location = new Point(210, 38);
            label2.Name = "label2";
            label2.Size = new Size(149, 25);
            label2.TabIndex = 31;
            label2.Text = "00.00.0000 00:00";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.MediumSlateBlue;
            label3.Location = new Point(365, 10);
            label3.Name = "label3";
            label3.Size = new Size(164, 25);
            label3.TabIndex = 32;
            label3.Text = "Тип уведомления";
            // 
            // toggleStateButton1
            // 
            toggleStateButton1.AutoSize = true;
            toggleStateButton1.Location = new Point(383, 39);
            toggleStateButton1.MidLowBackColor = Color.FromArgb(255, 192, 128);
            toggleStateButton1.MidLowToggleColor = Color.MediumPurple;
            toggleStateButton1.MinimumSize = new Size(80, 30);
            toggleStateButton1.Name = "toggleStateButton1";
            toggleStateButton1.OffBackColor = Color.FromArgb(128, 255, 128);
            toggleStateButton1.OffToggleColor = Color.MediumPurple;
            toggleStateButton1.OnBackColor = Color.FromArgb(255, 128, 128);
            toggleStateButton1.OnToggleColor = Color.MediumPurple;
            toggleStateButton1.Size = new Size(128, 30);
            toggleStateButton1.State = 0;
            toggleStateButton1.TabIndex = 33;
            toggleStateButton1.Text = "toggleStateButton1";
            toggleStateButton1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumSlateBlue;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(848, 2);
            panel1.TabIndex = 34;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MediumSlateBlue;
            panel2.Location = new Point(0, 98);
            panel2.Name = "panel2";
            panel2.Size = new Size(848, 2);
            panel2.TabIndex = 35;
            // 
            // panel3
            // 
            panel3.BackColor = Color.MediumSlateBlue;
            panel3.Location = new Point(752, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(2, 100);
            panel3.TabIndex = 36;
            // 
            // panel4
            // 
            panel4.BackColor = Color.MediumSlateBlue;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(2, 100);
            panel4.TabIndex = 37;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.ForeColor = Color.MediumSlateBlue;
            label4.Location = new Point(535, 10);
            label4.Name = "label4";
            label4.Size = new Size(105, 25);
            label4.TabIndex = 38;
            label4.Text = "Состояние";
            // 
            // rjSwitch1
            // 
            rjSwitch1.AutoSize = true;
            rjSwitch1.Location = new Point(547, 37);
            rjSwitch1.MinimumSize = new Size(80, 30);
            rjSwitch1.Name = "rjSwitch1";
            rjSwitch1.OffBackColor = Color.Gray;
            rjSwitch1.OffToggleColor = Color.Gainsboro;
            rjSwitch1.OnBackColor = Color.MediumSlateBlue;
            rjSwitch1.OnToggleColor = Color.WhiteSmoke;
            rjSwitch1.Size = new Size(80, 30);
            rjSwitch1.TabIndex = 39;
            rjSwitch1.UseVisualStyleBackColor = true;
            // 
            // rjButton1
            // 
            rjButton1.BackColor = Color.MediumSlateBlue;
            rjButton1.Background_color = Color.MediumSlateBlue;
            rjButton1.Border_color = Color.PaleVioletRed;
            rjButton1.Border_radius = 25;
            rjButton1.Border_size = 0;
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.FlatStyle = FlatStyle.Flat;
            rjButton1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            rjButton1.Fore_color = Color.White;
            rjButton1.ForeColor = Color.White;
            rjButton1.Location = new Point(672, 5);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(74, 30);
            rjButton1.TabIndex = 40;
            rjButton1.Text = "Text";
            rjButton1.UseVisualStyleBackColor = false;
            rjButton1.Click += rjButton1_Click;
            // 
            // rjButton2
            // 
            rjButton2.BackColor = Color.MediumSlateBlue;
            rjButton2.Background_color = Color.MediumSlateBlue;
            rjButton2.Border_color = Color.PaleVioletRed;
            rjButton2.Border_radius = 25;
            rjButton2.Border_size = 0;
            rjButton2.FlatAppearance.BorderSize = 0;
            rjButton2.FlatStyle = FlatStyle.Flat;
            rjButton2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            rjButton2.Fore_color = Color.White;
            rjButton2.ForeColor = Color.White;
            rjButton2.Location = new Point(672, 36);
            rjButton2.Name = "rjButton2";
            rjButton2.Size = new Size(74, 30);
            rjButton2.TabIndex = 41;
            rjButton2.Text = "Edit";
            rjButton2.UseVisualStyleBackColor = false;
            rjButton2.Click += rjButton2_Click;
            // 
            // rjButton3
            // 
            rjButton3.BackColor = Color.MediumSlateBlue;
            rjButton3.Background_color = Color.MediumSlateBlue;
            rjButton3.Border_color = Color.PaleVioletRed;
            rjButton3.Border_radius = 25;
            rjButton3.Border_size = 0;
            rjButton3.FlatAppearance.BorderSize = 0;
            rjButton3.FlatStyle = FlatStyle.Flat;
            rjButton3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            rjButton3.Fore_color = Color.White;
            rjButton3.ForeColor = Color.White;
            rjButton3.Location = new Point(672, 67);
            rjButton3.Name = "rjButton3";
            rjButton3.Size = new Size(74, 30);
            rjButton3.TabIndex = 42;
            rjButton3.Text = "Del";
            rjButton3.UseVisualStyleBackColor = false;
            rjButton3.Click += rjButton3_Click;
            // 
            // NotificationItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(rjButton3);
            Controls.Add(rjButton2);
            Controls.Add(rjButton1);
            Controls.Add(rjSwitch1);
            Controls.Add(label4);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(toggleStateButton1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker2);
            Controls.Add(label7);
            Controls.Add(dateTimePicker1);
            Name = "NotificationItem";
            Size = new Size(754, 100);
            Load += NotificationItem_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker2;
        private Label label7;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Widgets.ToggleStateButton toggleStateButton1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label label4;
        private Widgets.RJSwitch rjSwitch1;
        private Widgets.RJButton rjButton1;
        private Widgets.RJButton rjButton2;
        private Widgets.RJButton rjButton3;
    }
}
