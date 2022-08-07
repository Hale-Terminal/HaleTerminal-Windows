using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using HaleTerminal;

namespace HaleTerminal
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        
        public Login()
        {
            Log.Instance.Info("Login window opened at: {time}", DateTimeOffset.UtcNow);
            InitializeComponent();
        }

        private void username_Click(object sender, RoutedEventArgs e)
        {
            username.BorderBrush = Brushes.White;
        }

        private void username_Enter(object sender, RoutedEventArgs e)
        {
            username.BorderBrush = Brushes.White;
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            if (username.Text == "" & password.Password.ToString() == "")
            {
                username.BorderBrush = Brushes.Red;
                password.BorderBrush = Brushes.Red;
                return;
            }
            else
            {
                if (username.Text == "")
                {
                    username.BorderBrush = Brushes.Red;
                    return;
                }
                else
                {
                    password.BorderBrush = Brushes.Red;
                    return;
                }
            }

            var person = new UserLogin();
            person.username = username.Text;
            person.password = password.Password.ToString();

            var json = JsonConvert.SerializeObject(person);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://127.0.0.1:8000/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = await client.PostAsync("api/v1/auth/login", data);
            var result = await response.Content.ReadAsStringAsync();
            LoginToken token = JsonConvert.DeserializeObject<LoginToken>(result);
            MessageBox.Show(token.token);
    
        }

    }
}
