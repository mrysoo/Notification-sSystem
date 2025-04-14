namespace NotificationsSystem.GUI.Forms
{
    partial class NotificEditMF
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dateTimePicker2 = new DateTimePicker();
            label7 = new Label();
            dateTimePicker1 = new DateTimePicker();
            rjSwitch1 = new NotificationsSystem.GUI.Widgets.RJSwitch();
            label4 = new Label();
            toggleStateButton1 = new NotificationsSystem.GUI.Widgets.ToggleStateButton();
            label3 = new Label();
            textBox1 = new TextBox();
            richTextBox1 = new RichTextBox();
            rjButton1 = new NotificationsSystem.GUI.Widgets.RJButton();
            SuspendLayout();
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Time;
            dateTimePicker2.Location = new Point(12, 66);
            dateTimePicker2.MinDate = new DateTime(1753, 1, 31, 0, 0, 0, 0);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(181, 23);
            dateTimePicker2.TabIndex = 31;
            dateTimePicker2.Value = new DateTime(2025, 4, 12, 10, 23, 11, 0);
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label7.ForeColor = Color.MediumSlateBlue;
            label7.Location = new Point(12, 9);
            label7.Name = "label7";
            label7.Size = new Size(181, 25);
            label7.TabIndex = 30;
            label7.Text = "День напоминания";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 37);
            dateTimePicker1.MinDate = new DateTime(1753, 1, 31, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(181, 23);
            dateTimePicker1.TabIndex = 29;
            dateTimePicker1.Value = new DateTime(2025, 4, 12, 10, 23, 11, 0);
            // 
            // rjSwitch1
            // 
            rjSwitch1.AutoSize = true;
            rjSwitch1.Location = new Point(381, 36);
            rjSwitch1.MinimumSize = new Size(80, 30);
            rjSwitch1.Name = "rjSwitch1";
            rjSwitch1.OffBackColor = Color.Gray;
            rjSwitch1.OffToggleColor = Color.Gainsboro;
            rjSwitch1.OnBackColor = Color.MediumSlateBlue;
            rjSwitch1.OnToggleColor = Color.WhiteSmoke;
            rjSwitch1.Size = new Size(80, 30);
            rjSwitch1.TabIndex = 43;
            rjSwitch1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.ForeColor = Color.MediumSlateBlue;
            label4.Location = new Point(369, 9);
            label4.Name = "label4";
            label4.Size = new Size(105, 25);
            label4.TabIndex = 42;
            label4.Text = "Состояние";
            // 
            // toggleStateButton1
            // 
            toggleStateButton1.AutoSize = true;
            toggleStateButton1.Location = new Point(217, 38);
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
            toggleStateButton1.TabIndex = 41;
            toggleStateButton1.Text = "toggleStateButton1";
            toggleStateButton1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.MediumSlateBlue;
            label3.Location = new Point(199, 9);
            label3.Name = "label3";
            label3.Size = new Size(164, 25);
            label3.TabIndex = 40;
            label3.Text = "Тип уведомления";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 123);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(460, 23);
            textBox1.TabIndex = 44;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 152);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(460, 128);
            richTextBox1.TabIndex = 45;
            richTextBox1.Text = "";
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
            rjButton1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            rjButton1.Fore_color = Color.White;
            rjButton1.ForeColor = Color.White;
            rjButton1.Location = new Point(12, 286);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(460, 62);
            rjButton1.TabIndex = 46;
            rjButton1.Text = "Сохранить";
            rjButton1.UseVisualStyleBackColor = false;
            rjButton1.Click += rjButton1_Click;
            // 
            // NotificEditMF
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 360);
            Controls.Add(rjButton1);
            Controls.Add(richTextBox1);
            Controls.Add(textBox1);
            Controls.Add(rjSwitch1);
            Controls.Add(label4);
            Controls.Add(toggleStateButton1);
            Controls.Add(label3);
            Controls.Add(dateTimePicker2);
            Controls.Add(label7);
            Controls.Add(dateTimePicker1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "NotificEditMF";
            Text = "Date";
            Load += NotificEditMF_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker2;
        private Label label7;
        private DateTimePicker dateTimePicker1;
        private Widgets.RJSwitch rjSwitch1;
        private Label label4;
        private Widgets.ToggleStateButton toggleStateButton1;
        private Label label3;
        private TextBox textBox1;
        private RichTextBox richTextBox1;
        private Widgets.RJButton rjButton1;
    }
}