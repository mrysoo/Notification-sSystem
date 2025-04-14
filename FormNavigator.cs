using Microsoft.Extensions.DependencyInjection;
using NotificationsSystem.GUI.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationsSystem
{
    public class FormNavigator
    {
        private readonly IServiceProvider _serviceProvider;

        public FormNavigator(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void NavigateTo<T>(BaseForm currentForm) where T : BaseForm
        {
            currentForm.IsNavigating = true;

            currentForm.Hide();

            var nextForm = _serviceProvider.GetRequiredService<T>();
            nextForm.Show();
        }
    }
}
