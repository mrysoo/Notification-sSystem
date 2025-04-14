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
    public partial class AuthorizationF : BaseForm
    {
        private readonly FormNavigator _formNavigator;
        private readonly UserStorage _userStorage;

        public AuthorizationF(FormNavigator formNavigator, UserStorage userStorage)
        {
            _formNavigator = formNavigator;
            _userStorage = userStorage;

            InitializeComponent();
        }

        private void AuthorizationF_Load(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        private async void rjButton1_Click(object sender, EventArgs e)
        {
            try
            {
                using (var scope = Program.ServiceProvider.CreateScope())
                {
                    var userService = scope.ServiceProvider.GetRequiredService<IUserService>();

                    if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
                    {
                        MessageBox.Show("Введите пароль и логин");
                        return;
                    }

                    var user = await userService.AuthorizationUserAsync(textBox1.Text, textBox2.Text);

                    if (user != null)
                    {
                        _userStorage.CurrentUser = user;
                        _formNavigator.NavigateTo<MainF>(this);
                    }
                    else
                    {
                        MessageBox.Show("Такого пользователя нет");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error ex: {ex}");
                throw;
            }
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            try
            {
                _formNavigator.NavigateTo<RegistrationF>(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error ex: {ex}");
                throw;
            }
        }
    }
}
