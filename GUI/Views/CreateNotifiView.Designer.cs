namespace NotificationsSystem.GUI.Views
{
    partial class CreateNotifiView
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
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            richTextBox1 = new RichTextBox();
            label3 = new Label();
            toggleStateButton1 = new NotificationsSystem.GUI.Widgets.ToggleStateButton();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label7 = new Label();
            rjButton2 = new NotificationsSystem.GUI.Widgets.RJButton();
            dateTimePicker2 = new DateTimePicker();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.MediumSlateBlue;
            label2.Location = new Point(14, 13);
            label2.Name = "label2";
            label2.Size = new Size(101, 25);
            label2.TabIndex = 13;
            label2.Text = "Заголовок";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(121, 15);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(412, 23);
            textBox1.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.MediumSlateBlue;
            label1.Location = new Point(14, 47);
            label1.Name = "label1";
            label1.Size = new Size(58, 25);
            label1.TabIndex = 15;
            label1.Text = "Текст";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(121, 52);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ScrollBars = RichTextBoxScrollBars.Vertical;
            richTextBox1.Size = new Size(412, 306);
            richTextBox1.TabIndex = 16;
            richTextBox1.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.MediumSlateBlue;
            label3.Location = new Point(603, 15);
            label3.Name = "label3";
            label3.Size = new Size(164, 25);
            label3.TabIndex = 17;
            label3.Text = "Тип уведомления";
            // 
            // toggleStateButton1
            // 
            toggleStateButton1.AutoSize = true;
            toggleStateButton1.Location = new Point(623, 78);
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
            toggleStateButton1.TabIndex = 18;
            toggleStateButton1.Text = "toggleStateButton1";
            toggleStateButton1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.ForeColor = Color.MediumSlateBlue;
            label4.Location = new Point(557, 111);
            label4.Name = "label4";
            label4.Size = new Size(93, 25);
            label4.TabIndex = 19;
            label4.Text = "Обычное";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.ForeColor = Color.MediumSlateBlue;
            label5.Location = new Point(649, 50);
            label5.Name = "label5";
            label5.Size = new Size(79, 25);
            label5.TabIndex = 20;
            label5.Text = "Важное";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.ForeColor = Color.MediumSlateBlue;
            label6.Location = new Point(718, 111);
            label6.Name = "label6";
            label6.Size = new Size(139, 25);
            label6.TabIndex = 21;
            label6.Text = "Очень важное";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(603, 195);
            dateTimePicker1.MinDate = new DateTime(2025, 4, 12, 10, 23, 11, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(181, 23);
            dateTimePicker1.TabIndex = 22;
            dateTimePicker1.Value = new DateTime(2025, 4, 12, 10, 23, 11, 0);
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label7.ForeColor = Color.MediumSlateBlue;
            label7.Location = new Point(603, 157);
            label7.Name = "label7";
            label7.Size = new Size(181, 25);
            label7.TabIndex = 23;
            label7.Text = "День напоминания";
            // 
            // rjButton2
            // 
            rjButton2.BackColor = Color.MediumSlateBlue;
            rjButton2.Background_color = Color.MediumSlateBlue;
            rjButton2.Border_color = Color.PaleVioletRed;
            rjButton2.Border_radius = 40;
            rjButton2.Border_size = 0;
            rjButton2.FlatAppearance.BorderSize = 0;
            rjButton2.FlatStyle = FlatStyle.Flat;
            rjButton2.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            rjButton2.Fore_color = Color.White;
            rjButton2.ForeColor = Color.White;
            rjButton2.Location = new Point(14, 364);
            rjButton2.Name = "rjButton2";
            rjButton2.Size = new Size(843, 88);
            rjButton2.TabIndex = 24;
            rjButton2.Text = "Добавить";
            rjButton2.UseVisualStyleBackColor = false;
            rjButton2.Click += rjButton2_Click;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Time;
            dateTimePicker2.Location = new Point(603, 224);
            dateTimePicker2.MinDate = new DateTime(1999, 4, 12, 10, 23, 0, 0);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(181, 23);
            dateTimePicker2.TabIndex = 25;
            dateTimePicker2.Value = new DateTime(2025, 4, 12, 10, 23, 11, 0);
            // 
            // CreateNotifiView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dateTimePicker2);
            Controls.Add(rjButton2);
            Controls.Add(label7);
            Controls.Add(dateTimePicker1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(toggleStateButton1);
            Controls.Add(label3);
            Controls.Add(richTextBox1);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Name = "CreateNotifiView";
            Size = new Size(878, 468);
            Load += CreateNotifiView_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private RichTextBox richTextBox1;
        private Label label3;
        private Widgets.ToggleStateButton toggleStateButton1;
        private Label label4;
        private Label label5;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private Label label7;
        private Widgets.RJButton rjButton2;
        private DateTimePicker dateTimePicker2;
    }
}
