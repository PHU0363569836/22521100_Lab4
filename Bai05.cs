using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net.Http.Json;
using System.Security.Policy;

namespace _22521100_Lab4
{
    public partial class Bai05 : Form
    {
        public Bai05()
        {
            InitializeComponent();
        }

        private async void btn_login_Click(object sender, EventArgs e)
        {
            string URL = tb_url.Text;
            string username = tb_username.Text.Trim();
            string password = tb_password.Text;
            if (username == "" || password == "")
            {
                MessageBox.Show("Please enter username and password");
                return;
            }
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var formContent = new FormUrlEncodedContent(new[]
                    {
                        new KeyValuePair<string, string>("username", username),
                        new KeyValuePair<string, string>("password", password)
                    });
                    HttpResponseMessage response = await client.PostAsync(URL, formContent);
                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();
                        JObject jsonResponse = JObject.Parse(responseBody);
                        string tokenType = jsonResponse.Value<string>("token_type");
                        string accessToken = jsonResponse.Value<string>("access_token");
                        rtb_view.Text = $"{tokenType} {accessToken}\n\nĐăng nhập thành công!";
                    }
                    else
                    {
                        string errorResponse = await response.Content.ReadAsStringAsync();
                        JObject errorJson = JObject.Parse(errorResponse);
                        string detail = errorJson.Value<string>("detail");
                        rtb_view.Text = $"Đăng nhập thất bại!\n{detail}";
                    }
                }
            }
            catch (Exception ex)
            {
                rtb_view.Text = $"Đăng nhập thất bại!\n{ex.Message}";
            }
        }
    }
}
