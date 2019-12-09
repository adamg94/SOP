using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies
{
    class Movies
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
        public DateTime Creation_date { get; set; }
        public float Imdb_points { get; set; }
        public short Length_in_minutes { get; set; }
        public string Director { get; set; }
        public string Writer { get; set; }
        public string Stars { get; set; }

        public override string ToString()
        {
            return string.Format("{0}  {1}  {2}  {3}  {4}  {5}  {6}  {7}",
                Id,
                Name,
                Creation_date,
                Imdb_points,
                Length_in_minutes,
                Director,
                Writer,
                Stars
                );
        }
    }
}
