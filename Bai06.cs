using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22521100_Lab4
{
    public partial class Bai06 : Form
    {
        public Bai06()
        {
            InitializeComponent();
        }

        private async void btn_get_Click(object sender, EventArgs e)
        {
            string url = tb_url.Text;
            string token = tb_token.Text;

            if (token.Length == 0)
            {
                MessageBox.Show("Please enter token!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                //Using http client to make HTTP get request
                using (var client = new HttpClient())
                {
                    //add token to request header
                    client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
                    //send Get request to spectified url asynchronously
                    var reponse = await client.GetAsync(url);

                    //ensure the reponse indicates success
                    reponse.EnsureSuccessStatusCode();

                    //Read the reponse conten as string
                    var content = await reponse.Content.ReadAsStringAsync();

                    //Display content on text box
                    rtb_view.Text = content;
                }
            }
            catch
            {
                rtb_view.Text = "Token not is no longer active!";
            }
        }
    }
}
