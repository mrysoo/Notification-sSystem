namespace NotificationsSystem.GUI.Forms
{
    partial class RegistrationF
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
            label3 = new Label();
            label2 = new Label();
            rjButton2 = new NotificationsSystem.GUI.Widgets.RJButton();
            rjButton1 = new NotificationsSystem.GUI.Widgets.RJButton();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.MediumSlateBlue;
            label1.Location = new Point(93, 9);
            label1.Name = "label1";
            label1.Size = new Size(219, 47);
            label1.TabIndex = 1;
            label1.Text = "Регистрация";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.MediumSlateBlue;
            label3.Location = new Point(12, 108);
            label3.Name = "label3";
            label3.Size = new Size(78, 25);
            label3.TabIndex = 12;
            label3.Text = "Пароль";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.MediumSlateBlue;
            label2.Location = new Point(12, 79);
            label2.Name = "label2";
            label2.Size = new Size(65, 25);
            label2.TabIndex = 11;
            label2.Text = "Логин";
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
            rjButton2.Location = new Point(12, 250);
            rjButton2.Name = "rjButton2";
            rjButton2.Size = new Size(419, 47);
            rjButton2.TabIndex = 10;
            rjButton2.Text = "Назад";
            rjButton2.UseVisualStyleBackColor = false;
            rjButton2.Click += rjButton2_Click;
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
            rjButton1.Location = new Point(12, 197);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(419, 47);
            rjButton1.TabIndex = 9;
            rjButton1.Text = "Регистрация";
            rjButton1.UseVisualStyleBackColor = false;
            rjButton1.Click += rjButton1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(192, 110);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(239, 23);
            textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(192, 81);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(239, 23);
            textBox1.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.ForeColor = Color.MediumSlateBlue;
            label4.Location = new Point(12, 137);
            label4.Name = "label4";
            label4.Size = new Size(174, 25);
            label4.TabIndex = 14;
            label4.Text = "Повторите пароль";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(192, 139);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(239, 23);
            textBox3.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.ForeColor = Color.MediumSlateBlue;
            label5.Location = new Point(12, 166);
            label5.Name = "label5";
            label5.Size = new Size(58, 25);
            label5.TabIndex = 16;
            label5.Text = "Email";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(192, 168);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(239, 23);
            textBox4.TabIndex = 15;
            // 
            // RegistrationF
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 315);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(rjButton2);
            Controls.Add(rjButton1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "RegistrationF";
            Text = "Регистрация";
            Load += RegistrationF_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label2;
        private Widgets.RJButton rjButton2;
        private Widgets.RJButton rjButton1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox4;
    }
}