using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToWatch.model
{
    public class MovieRequester
    {
        MovieRequester()
        {
            RequestMaker = new UrlMaker();
            Sender = new RequestSender();
        }

        public Movie GetMovie(string imdbId)
        {
            // make url
            string movie_request_url = RequestMaker.MakeMovieRequest(imdbId);

            // send request
            Movie requested_movie = Sender.Send(movie_request_url);

            return new Movie();
        }

        private RequestSender Sender { get; }
        private UrlMaker RequestMaker { get; }
        private string BaseUrl { get; set; }
    }
}
