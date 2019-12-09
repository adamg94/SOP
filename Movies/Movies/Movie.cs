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
    public partial class Movie : Form
    {
        public static string username = Form1.UNAME;
        public Movie()
        {
            InitializeComponent();
            var server = new RestClient(Regisztracio.URL);
            var req = new RestRequest("/movies/", Method.GET);

            req.RequestFormat = DataFormat.Json;
            var res = server.Execute(req);
            JObject response = JObject.Parse(res.Content);
            if ((Boolean)response["success"] == true)
            {
                foreach (JObject content in response["movies"])
                {
                    Movies m = new Movies();

                    m.Id = int.Parse(content.Property("id").Value.ToString());
                    m.Name = content.Property("name").Value.ToString();
                    m.Creation_date = (DateTime)content.Property("creation_date").Value;
                    m.Imdb_points = float.Parse(content.Property("imdb_points").Value.ToString());
                    m.Length_in_minutes = short.Parse(content.Property("length_in_minutes").Value.ToString());
                    m.Director = content.Property("director").Value.ToString();
                    m.Writer = content.Property("writer").Value.ToString();
                    m.Stars = content.Property("stars").Value.ToString();


                    lista.Items.Add(m);
                }
            }





        }

        private void felvisz_Click(object sender, EventArgs e)
        {
            var server = new RestClient(Regisztracio.URL);
            var req = new RestRequest("/movies/add", Method.POST);

            req.RequestFormat = DataFormat.Json;
            req.AddJsonBody(new Movies
            {
                Username = username,
                Id = (int)id.Value,
                Name = title.Text,
                Creation_date = creationdate.Value,
                Imdb_points = (float)imdb.Value,
                Length_in_minutes = (short)length.Value,
                Director = director.Text,
                Writer = writer.Text,
                Stars = stars.Text
            });

            var res = server.Execute(req);

            JObject result = JObject.Parse(res.Content);
            info.Text = result["message"].ToString();
        }

        private void modosit_Click(object sender, EventArgs e)
        {
            var server = new RestClient(Regisztracio.URL);
            var req = new RestRequest("/movies/update", Method.POST);

            req.RequestFormat = DataFormat.Json;
            req.AddJsonBody(new Movies
            {
                Username = username,
                Id = (int)id.Value,
                Name = title.Text,
                Creation_date = creationdate.Value,
                Imdb_points = (float)imdb.Value,
                Length_in_minutes = (short)length.Value,
                Director = director.Text,
                Writer = writer.Text,
                Stars = stars.Text
            });

            var res = server.Execute(req);

            JObject result = JObject.Parse(res.Content);
            info.Text = result["message"].ToString();
        }

        private void torol_Click(object sender, EventArgs e)
        {

            var server = new RestClient(Regisztracio.URL);
            var req = new RestRequest("/movies/delete/" + id.Value, Method.POST);

            req.RequestFormat = DataFormat.Json;
            req.AddJsonBody(new Movies
            {
                Username = username              
            });
            var res = server.Execute(req);

            JObject result = JObject.Parse(res.Content);
            info.Text = result["message"].ToString();

        }

        private void listaz_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
            var server = new RestClient(Regisztracio.URL);
            var req = new RestRequest("/movies/", Method.GET);

            req.RequestFormat = DataFormat.Json;
            var res = server.Execute(req);
            JObject response = JObject.Parse(res.Content);
            if ((Boolean)response["success"] == true)
            {
                foreach (JObject content in response["movies"])
                {
                    Movies m = new Movies();

                    m.Id = int.Parse(content.Property("id").Value.ToString());
                    m.Name = content.Property("name").Value.ToString();
                    m.Creation_date = (DateTime)content.Property("creation_date").Value;
                    m.Imdb_points = float.Parse(content.Property("imdb_points").Value.ToString());
                    m.Length_in_minutes = short.Parse(content.Property("length_in_minutes").Value.ToString());
                    m.Director = content.Property("director").Value.ToString();
                    m.Writer = content.Property("writer").Value.ToString();
                    m.Stars = content.Property("stars").Value.ToString();


                    lista.Items.Add(m);
                }
            }

        }
    }
}
