using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Newtonsoft.Json;

namespace poliklinika
{
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private async void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            string login = TbLogin.Text.Trim();
            string password = PbPassword.Password.Trim();

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                TbError.Text = "Введите логин и пароль!";
                return;
            }

            try
            {
                using (var client = new HttpClient())
                {
                    var loginData = new { login = login, password = password };
                    var content = new StringContent(JsonConvert.SerializeObject(loginData), Encoding.UTF8, "application/json");

                
                    var response = await client.PostAsync("http://localhost:5026/api/Auth/login", content);

                    if (response.IsSuccessStatusCode)
                    {
                        var responseString = await response.Content.ReadAsStringAsync();
                        var authData = JsonConvert.DeserializeObject<TokenResponse>(responseString);

                        App.Token = authData.token;

                        if (authData.role == 1)
                        {
                            AdminWindow adminWin = new AdminWindow();
                            adminWin.Show();
                        }
                        else if (authData.role == 2)
                        {
                            RegistrarWindow regWin = new RegistrarWindow();
                            regWin.Show();
                        }
                        else
                        {
                            DoctorWindow docWin = new DoctorWindow();
                            docWin.Show();
                        }

                        this.Close();
                    }
                    else
                    {
                        var errorContent = await response.Content.ReadAsStringAsync();
                        TbError.Text = "Ошибка сервера!";
                        MessageBox.Show($"Ошибка API: {response.StatusCode}\n{errorContent}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                TbError.Text = "Ошибка подключения!";
                MessageBox.Show("Не удалось подключиться к API. Убедитесь, что оно запущено.\n\n" + ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }

    public class TokenResponse
    {
        public string token { get; set; }
        public int role { get; set; }
    }
}