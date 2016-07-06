using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToWatch.model
{
    public class Movie
    {
        public void ResetMovie()
        {
            MovieInfo.Clear();
        }

        public Dictionary<String, String> MovieInfo { get;set; }
    }
}
