using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToWatch.model
{
    public class UrlMaker
    {
        public UrlMaker()
        {
            m_reqParameters.Add(ReqTypes.imdbId, "i");
            m_reqParameters.Add(ReqTypes.title, "t");
            m_reqParameters.Add(ReqTypes.resultType, "type");
            m_reqParameters.Add(ReqTypes.releaseYear, "year");
            m_reqParameters.Add(ReqTypes.plotSize, "plot");
            m_reqParameters.Add(ReqTypes.returnType, "r");
            m_reqParameters.Add(ReqTypes.rating, "tomatoes");
        }

        public string MakeMovieRequest(string imdbId = null, string title = null)
        {
            string requestUrl = null;
            if (imdbId != null)
            {
                requestUrl = AddCondition(m_baseUrl, imdbId, ReqTypes.imdbId);
            }

            if (title != null)
            {
                requestUrl = AddCondition(m_baseUrl, title, ReqTypes.title);
            }

            return requestUrl;
        }

        // TODO
        public string MakeSearchRequest()
        {
            return "";
        }

        private string AddCondition(string url, string request, ReqTypes type)
        {
            if (url.EndsWith("?"))
            {
                url += m_reqParameters[type] + "=" + request;
            }
            else if (m_reqParameters.ContainsKey(type))
            {
                url += @"&" + m_reqParameters[type] + "=" + request;
            }
            return url;
        }

        enum ReqTypes { imdbId, title, resultType, releaseYear, plotSize, returnType, rating}

        // The movie database used to get movie information.
        private string m_baseUrl = "http://www.omdbapi.com/?";

        private Dictionary<ReqTypes, string> m_reqParameters = new Dictionary<ReqTypes, string>();
    }
}
