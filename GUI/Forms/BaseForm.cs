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
    public partial class BaseForm : Form, IForm
    {
        private static bool isExiting = false;
        public bool IsNavigating { get; set; }

        protected BaseForm()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormClosing += OnFormClosing;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            if (isExiting || IsNavigating)
                return;

            if (ConfirmClose())
            {
                isExiting = true;
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }

        public virtual bool ConfirmClose()
        {
            var result = MessageBox.Show("Вы уверены что хотите закрыть программу?", "Информация", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return result == DialogResult.Yes;
        }

        public new void Show()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            base.Show();
        }
    }
}
