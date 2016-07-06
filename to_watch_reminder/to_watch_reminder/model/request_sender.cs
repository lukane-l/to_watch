using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Web.Script.Serialization;


namespace ToWatch.model
{
    public class RequestSender
    {
        public Movie Send(string url)
        {
            string json = "";
            using (WebClient client = new WebClient())
            {
                json = client.DownloadString(url);
            }

            JsonToMovie(json);

            return m_movie;
        }

        private void JsonToMovie(string json)
        {
            var serializer = new JavaScriptSerializer();
            m_movie.MovieInfo = serializer.Deserialize<Dictionary<string, string>>(json);
        }

        private Movie m_movie = new Movie();
    }


}
