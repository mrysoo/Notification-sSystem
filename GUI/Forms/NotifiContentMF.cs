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
    public partial class NotifiContentMF: Form
    {
        public NotifiContentMF(string title, string content, DateTime notifiDateTime)
        {
            InitializeComponent();

            textBox1.Text = title;
            richTextBox1.Text = content;
            this.Text = notifiDateTime.ToString("dd.MM.yyyy HH:mm");

            textBox1.ReadOnly = true;
            richTextBox1.ReadOnly = true;
        }
    }
}
