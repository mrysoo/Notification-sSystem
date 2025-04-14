namespace NotificationsSystem.GUI.Views
{
    partial class SelectNotifiView
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
            panel1 = new Panel();
            rjCombobox1 = new NotificationsSystem.GUI.Widgets.RJCombobox();
            rjCombobox2 = new NotificationsSystem.GUI.Widgets.RJCombobox();
            rjCombobox3 = new NotificationsSystem.GUI.Widgets.RJCombobox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.MediumSlateBlue;
            label2.Location = new Point(13, 13);
            label2.Name = "label2";
            label2.Size = new Size(179, 25);
            label2.TabIndex = 14;
            label2.Text = "Ваши уведомления";
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Location = new Point(13, 54);
            panel1.Name = "panel1";
            panel1.Size = new Size(848, 398);
            panel1.TabIndex = 15;
            // 
            // rjCombobox1
            // 
            rjCombobox1.BackColor = Color.WhiteSmoke;
            rjCombobox1.Border_radius = 0;
            rjCombobox1.BorderColor = Color.MediumSlateBlue;
            rjCombobox1.BorderSize = 2;
            rjCombobox1.DropDownStyle = ComboBoxStyle.DropDown;
            rjCombobox1.Font = new Font("Segoe UI", 10F);
            rjCombobox1.ForeColor = Color.DimGray;
            rjCombobox1.IconColor = Color.MediumSlateBlue;
            rjCombobox1.ListBackColor = Color.FromArgb(230, 228, 245);
            rjCombobox1.ListTextColor = Color.DimGray;
            rjCombobox1.Location = new Point(198, 8);
            rjCombobox1.MinimumSize = new Size(100, 30);
            rjCombobox1.Name = "rjCombobox1";
            rjCombobox1.Padding = new Padding(2);
            rjCombobox1.Size = new Size(184, 30);
            rjCombobox1.TabIndex = 16;
            rjCombobox1.Texts = "";
            rjCombobox1.OnSelectedIndexChanged += rjCombobox1_OnSelectedIndexChanged;
            // 
            // rjCombobox2
            // 
            rjCombobox2.BackColor = Color.WhiteSmoke;
            rjCombobox2.Border_radius = 0;
            rjCombobox2.BorderColor = Color.MediumSlateBlue;
            rjCombobox2.BorderSize = 2;
            rjCombobox2.DropDownStyle = ComboBoxStyle.DropDown;
            rjCombobox2.Font = new Font("Segoe UI", 10F);
            rjCombobox2.ForeColor = Color.DimGray;
            rjCombobox2.IconColor = Color.MediumSlateBlue;
            rjCombobox2.ListBackColor = Color.FromArgb(230, 228, 245);
            rjCombobox2.ListTextColor = Color.DimGray;
            rjCombobox2.Location = new Point(388, 8);
            rjCombobox2.MinimumSize = new Size(100, 30);
            rjCombobox2.Name = "rjCombobox2";
            rjCombobox2.Padding = new Padding(2);
            rjCombobox2.Size = new Size(184, 30);
            rjCombobox2.TabIndex = 17;
            rjCombobox2.Texts = "";
            rjCombobox2.OnSelectedIndexChanged += rjCombobox2_OnSelectedIndexChanged;
            // 
            // rjCombobox3
            // 
            rjCombobox3.BackColor = Color.WhiteSmoke;
            rjCombobox3.Border_radius = 0;
            rjCombobox3.BorderColor = Color.MediumSlateBlue;
            rjCombobox3.BorderSize = 2;
            rjCombobox3.DropDownStyle = ComboBoxStyle.DropDown;
            rjCombobox3.Font = new Font("Segoe UI", 10F);
            rjCombobox3.ForeColor = Color.DimGray;
            rjCombobox3.IconColor = Color.MediumSlateBlue;
            rjCombobox3.ListBackColor = Color.FromArgb(230, 228, 245);
            rjCombobox3.ListTextColor = Color.DimGray;
            rjCombobox3.Location = new Point(578, 8);
            rjCombobox3.MinimumSize = new Size(100, 30);
            rjCombobox3.Name = "rjCombobox3";
            rjCombobox3.Padding = new Padding(2);
            rjCombobox3.Size = new Size(218, 30);
            rjCombobox3.TabIndex = 18;
            rjCombobox3.Texts = "";
            rjCombobox3.OnSelectedIndexChanged += rjCombobox3_OnSelectedIndexChanged;
            // 
            // SelectNotifiView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(rjCombobox3);
            Controls.Add(rjCombobox2);
            Controls.Add(rjCombobox1);
            Controls.Add(panel1);
            Controls.Add(label2);
            Name = "SelectNotifiView";
            Size = new Size(878, 468);
            Load += SelectNotifiView_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Panel panel1;
        private Widgets.RJCombobox rjCombobox1;
        private Widgets.RJCombobox rjCombobox2;
        private Widgets.RJCombobox rjCombobox3;
    }
}
