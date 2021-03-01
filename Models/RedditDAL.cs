using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace RedditAPILab.Models
{
    public class RedditDAL
    {
        public string GetData(string url)
        {
            HttpWebRequest request = WebRequest.CreateHttp(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            StreamReader rd = new StreamReader(response.GetResponseStream());
            string json = rd.ReadToEnd();

            return json;
        }

        public Reddit ConvertToReddit(string url)
        {
            string redditData = GetData(url);
            Reddit r = JsonConvert.DeserializeObject<Reddit>(redditData);

            return r;
        }
    }
}
