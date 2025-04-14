namespace NotificationsSystem.GUI.Forms
{
    partial class AuthorizationF
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
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            rjButton1 = new NotificationsSystem.GUI.Widgets.RJButton();
            rjButton2 = new NotificationsSystem.GUI.Widgets.RJButton();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.MediumSlateBlue;
            label1.Location = new Point(128, 17);
            label1.Name = "label1";
            label1.Size = new Size(96, 47);
            label1.TabIndex = 0;
            label1.Text = "Вход";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(96, 97);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(239, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(96, 131);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(239, 23);
            textBox2.TabIndex = 2;
            // 
            // rjButton1
            // 
            rjButton1.BackColor = Color.MediumSlateBlue;
            rjButton1.Background_color = Color.MediumSlateBlue;
            rjButton1.Border_color = Color.PaleVioletRed;
            rjButton1.Border_radius = 40;
            rjButton1.Border_size = 0;
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.FlatStyle = FlatStyle.Flat;
            rjButton1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            rjButton1.Fore_color = Color.White;
            rjButton1.ForeColor = Color.White;
            rjButton1.Location = new Point(12, 160);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(323, 47);
            rjButton1.TabIndex = 3;
            rjButton1.Text = "Войти";
            rjButton1.UseVisualStyleBackColor = false;
            rjButton1.Click += rjButton1_Click;
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
            rjButton2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            rjButton2.Fore_color = Color.White;
            rjButton2.ForeColor = Color.White;
            rjButton2.Location = new Point(12, 213);
            rjButton2.Name = "rjButton2";
            rjButton2.Size = new Size(323, 47);
            rjButton2.TabIndex = 4;
            rjButton2.Text = "Регистрация";
            rjButton2.UseVisualStyleBackColor = false;
            rjButton2.Click += rjButton2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.MediumSlateBlue;
            label2.Location = new Point(12, 95);
            label2.Name = "label2";
            label2.Size = new Size(65, 25);
            label2.TabIndex = 5;
            label2.Text = "Логин";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.MediumSlateBlue;
            label3.Location = new Point(12, 129);
            label3.Name = "label3";
            label3.Size = new Size(78, 25);
            label3.TabIndex = 6;
            label3.Text = "Пароль";
            // 
            // AuthorizationF
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(353, 278);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(rjButton2);
            Controls.Add(rjButton1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "AuthorizationF";
            Text = "Авторизация";
            Load += AuthorizationF_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Widgets.RJButton rjButton1;
        private Widgets.RJButton rjButton2;
        private Label label2;
        private Label label3;
    }
}