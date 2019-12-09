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

    public partial class Regisztracio : Form
    {
        public static string URL = "http://localhost:5000";
        public Regisztracio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var server = new RestClient(URL);
            var req = new RestRequest("/users/add", Method.POST);

            req.RequestFormat = DataFormat.Json;

            req.AddJsonBody(new User
            {
                Username = reg_felhNev.Text,
                Password = reg_jelszo.Text
            });

            var res = server.Execute(req);

            JObject response = JObject.Parse(res.Content);
            label4.Text = response["message"].ToString();

        }

        private void vissza_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}
