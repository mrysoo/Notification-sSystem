using DataModel.DataBase;
using DataModel.Types;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Toolkit.Uwp.Notifications;
using NotificationScheduler;
using NotificationsSystem.GUI.Forms;
using NotificationsSystem.GUI.Views;
using NotifiCommHub;
using NotifiCommHub.Services;
using System;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Threading.Tasks;
using Windows.UI.Notifications;

namespace NotificationsSystem
{
    public partial class MainF : BaseForm
    {
        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);
        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);
        // Константы
        private const int WM_HOTKEY = 0x0312;
        private const int HOTKEY_ID = 1;
        private const int MOD_CONTROL_SHIFT = 0x0006; // Ctrl + Shift + H

        private readonly FormNavigator _formNavigator;
        private readonly UserStorage _userStorage;

        private Scheduler _scheduler;

        private CreateNotifiView _addNotifiView;
        private SelectNotifiView _selectNotifiView;
        private MonthCalendarView _monthCalendarView;

        private System.Windows.Forms.Timer _timer;

        public MainF(FormNavigator formNavigator, UserStorage userStorage)
        {
            _formNavigator = formNavigator;
            _userStorage = userStorage;

            InitializeComponent();
        }

        private async void MainF_Load(object sender, EventArgs e)
        {
            await InitViews();
            _timer = new System.Windows.Forms.Timer();
            _timer.Interval = 30000;
            _timer.Tick += UpdateTableNotifications;
            _timer.Start();
            InitScheduler();

            label2.Text = _userStorage.CurrentUser?.Email;
            _selectNotifiView.Visible = true;
            _addNotifiView.Visible = false;
            _monthCalendarView.Visible = false;
        }

        private async void rjButton1_Click(object sender, EventArgs e)
        {
            try
            {
                _timer.Stop();
                await _scheduler.Stop();
                _scheduler.ShowNotifiEvent -= ShowNotification;
                _userStorage.CurrentUser = null;
                _formNavigator.NavigateTo<AuthorizationF>(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error ex: {ex}");
                throw;
            }
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            _addNotifiView.Visible = true;

            _selectNotifiView.Visible = false;
            _monthCalendarView.Visible = false;
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            try
            {
                _selectNotifiView.FillPanel1();

                _selectNotifiView.Visible = true;

                _addNotifiView.Visible = false;
                _monthCalendarView.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error ex: {ex}");
                throw;
            }
        }

        private async Task InitViews()
        {
            try
            {
                _addNotifiView = new CreateNotifiView(_userStorage);
                _addNotifiView.UpdateEvent += AddNotifiScheduler;
                panel1.Controls.Add(_addNotifiView);

                _selectNotifiView = new SelectNotifiView(_userStorage);
                _selectNotifiView.UpdateEvent += UpdateEdit;
                panel1.Controls.Add(_selectNotifiView);

                using (var scope = Program.ServiceProvider.CreateScope())
                {
                    var notificationService = scope.ServiceProvider.GetRequiredService<INotificationService>();

                    _monthCalendarView = new MonthCalendarView(await notificationService.GetAllNotificationByUserId(_userStorage.CurrentUser.Id));
                    panel1.Controls.Add(_monthCalendarView);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error ex: {ex}");
                throw;
            }
        }

        private void InitScheduler()
        {
            _scheduler = new Scheduler(Program.ServiceProvider, _userStorage.CurrentUser);
            _scheduler.ShowNotifiEvent += ShowNotification;
            _scheduler.Init();
        }

        private async void AddNotifiScheduler(NotificationDTO notification)
        {
            await _scheduler.AddNotification(notification);
        }

        private void UpdateTableNotifications(object? sender, EventArgs e)
        {
            if (_selectNotifiView.Visible)
            {
                _selectNotifiView.FillPanel1();
            }
        }

        private void ShowNotification(NotificationDTO notification)
        {
            string? exeDir = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

            if (exeDir == null)
            {
                throw new Exception("exeDir null");
            }

            string imageUrl = Path.Combine(exeDir, "Images\\Type0.png");

            switch ((NotificationType)notification.NotificationType)
            {
                case NotificationType.Normal:
                    imageUrl = Path.Combine(exeDir, "Images\\Type0.png");
                    break;
                case NotificationType.Important:
                    imageUrl = Path.Combine(exeDir, "Images\\Type1.png");
                    break;
                case NotificationType.VeryImportant:
                    imageUrl = Path.Combine(exeDir, "Images\\Type2.png");
                    break;
            }

            new ToastContentBuilder()
                .AddText(notification.Title)
                .AddText(notification.Content)
                .AddAppLogoOverride(new Uri(imageUrl, UriKind.Absolute), ToastGenericAppLogoCrop.Default)
                .AddButton(new ToastButton().SetContent("OK"))
                .SetToastScenario(ToastScenario.Default)
                .SetToastDuration(ToastDuration.Short)
                .Show();
        }

        private void rjButton4_Click(object sender, EventArgs e)
        {
            HideToBackground();
        }

        private void HideToBackground()
        {
            this.Hide();
            this.ShowInTaskbar = false;

            RegisterHotKey(this.Handle, HOTKEY_ID, MOD_CONTROL_SHIFT, (int)Keys.H);
        }

        private void RestoreFromBackground()
        {
            this.Show();
            this.ShowInTaskbar = true;
            UnregisterHotKey(this.Handle, HOTKEY_ID);
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_HOTKEY)
            {
                int id = m.WParam.ToInt32();
                if (id == HOTKEY_ID)
                {
                    RestoreFromBackground();
                }
            }
            base.WndProc(ref m);
        }

        private async void rjButton5_Click(object sender, EventArgs e)
        {
            using (var saveDialog = new SaveFileDialog())
            {
                saveDialog.Title = "Сохранить уведомления";
                saveDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
                saveDialog.FileName = $"notifications{DateTime.Now.ToString("dd-MM-yy_HH-mm")}.json";
                saveDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                saveDialog.DefaultExt = ".json";
                saveDialog.AddExtension = true;

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (var scope = Program.ServiceProvider.CreateScope())
                        {
                            var notificationService = scope.ServiceProvider.GetRequiredService<INotificationService>();
                            var notifications = await notificationService.GetAllNotificationByUserId(_userStorage.CurrentUser.Id);

                            Export.ExportToFile(notifications, saveDialog.FileName);
                        }

                        MessageBox.Show("Файл успешно сохранен!", "Успех",
                                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка сохранения: {ex.Message}", "Ошибка",
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private async void rjButton6_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Открыть файл уведомлений";
                openFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                openFileDialog.CheckFileExists = true;
                openFileDialog.CheckPathExists = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var notifications = Import.ImportFromFile(openFileDialog.FileName);

                        using (var scope = Program.ServiceProvider.CreateScope())
                        {
                            var notificationService = scope.ServiceProvider.GetRequiredService<INotificationService>();

                            foreach (var item in notifications)
                            {
                                item.Id = 0;
                                await notificationService.CreateNotification(item);
                            }
                        }

                        MessageBox.Show("Данные успешно загружены!", "Успех",
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);

                        _selectNotifiView.FillPanel1();
                    }
                    catch (JsonException ex)
                    {
                        MessageBox.Show($"Ошибка формата файла: {ex.Message}", "Ошибка",
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка загрузки: {ex.Message}", "Ошибка",
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private async void UpdateEdit()
        {
            if (_scheduler != null)
            {
                await _scheduler.Stop();
                _scheduler.ShowNotifiEvent -= ShowNotification;
                _scheduler = null;
                _scheduler = new Scheduler(Program.ServiceProvider, _userStorage.CurrentUser);
                _scheduler.ShowNotifiEvent += ShowNotification;
                _scheduler.Init();
            }
        }

        private async void rjButton7_Click(object sender, EventArgs e)
        {
            try
            {
                _monthCalendarView.Visible = true;

                _selectNotifiView.Visible = false;
                _addNotifiView.Visible = false;

                using (var scope = Program.ServiceProvider.CreateScope())
                {
                    var notificationService = scope.ServiceProvider.GetRequiredService<INotificationService>();

                    _monthCalendarView.SetNotifi(await notificationService.GetAllNotificationByUserId(_userStorage.CurrentUser.Id));
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
