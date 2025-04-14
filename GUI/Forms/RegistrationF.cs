using Microsoft.Extensions.DependencyInjection;
using NotifiCommHub.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotificationsSystem.GUI.Forms
{
    public partial class RegistrationF : BaseForm
    {
        private readonly FormNavigator _formNavigator;

        public RegistrationF(FormNavigator formNavigator)
        {
            _formNavigator = formNavigator;

            InitializeComponent();
        }

        private void RegistrationF_Load(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
            textBox3.PasswordChar = '*';
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            try
            {
                _formNavigator.NavigateTo<AuthorizationF>(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error ex: {ex}");
                throw;
            }
        }

        private async void rjButton1_Click(object sender, EventArgs e)
        {
            try
            {
                using (var scope = Program.ServiceProvider.CreateScope())
                {
                    var userService = scope.ServiceProvider.GetRequiredService<IUserService>();

                    if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text))
                    {
                        MessageBox.Show("Введите данные");
                        return;
                    }

                    if (textBox2.Text != textBox3.Text)
                    {
                        MessageBox.Show("Пароли не одинаковые");
                        return;
                    }

                    bool isExists = await userService.IsExistsRegistrUserAsync(textBox1.Text, textBox4.Text);

                    if (isExists)
                    {
                        MessageBox.Show("Пользователь с таким Login и Email уже есть");
                        return;
                    }

                    await userService.RegistrationUserAsync(textBox1.Text, textBox2.Text, textBox4.Text);

                    MessageBox.Show("Регистрация прошла успешно");

                    _formNavigator.NavigateTo<AuthorizationF>(this);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error ex: {ex}");
                throw;
            }
        }
    }
}
