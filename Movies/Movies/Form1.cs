using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;
using Newtonsoft.Json.Linq;

namespace Movies
{
    public partial class Form1 : Form
    {
        public static string UNAME = "";
        public static string URL = "http://localhost:5000/";
        public Form1()
        {
            InitializeComponent();
        }

        private void regisztracio_Click(object sender, EventArgs e)
        {
            Regisztracio form = new Regisztracio();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void belepes_Click(object sender, EventArgs e)
        {
            var server = new RestClient(URL);
            var req = new RestRequest("/users/login", Method.POST);

            req.RequestFormat = DataFormat.Json;

            req.AddJsonBody(new User
            {
                Username = felhNev.Text,
                Password = jelszo.Text
            });

            var res = server.Execute(req);

            JObject response = JObject.Parse(res.Content);
            bool bo = (Boolean)response["success"];
            if (bo == true)
            {
                UNAME = response["username"].ToString();
                Movie form = new Movie();
                this.Hide();
                form.ShowDialog();
                this.Close();

            }
            else
            {
                label4.Text = response["message"].ToString();
            }
        }
    }
}
