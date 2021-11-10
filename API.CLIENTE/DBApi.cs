using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace API.CLIENTE
{
    class DBApi
    {
        public dynamic GetA(string url)
        {
            HttpWebRequest mywebRequest = (HttpWebRequest)WebRequest.Create(url);
            mywebRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:23.0) Gecko/20100101 Firefox/23.0";
            mywebRequest.Credentials = CredentialCache.DefaultCredentials;
            mywebRequest.Proxy = null;
            HttpWebResponse myHttpWebResponse = (HttpWebResponse)mywebRequest.GetResponse();
            Stream myStream = myHttpWebResponse.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(myStream);
            string Datos = HttpUtility.HtmlDecode(myStreamReader.ReadToEnd());
            dynamic data = JsonConvert.DeserializeObject(Datos);
            return data;
        }
    }
}
