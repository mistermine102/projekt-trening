using projekt_trening.UserControls;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace projekt_trening
{
    internal class Test
    {
        public StreamReader sendRequest(string url, string method)
        {
            string responseString = "";
            //call api request
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Accept = "application/json";
            request.Method = method;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    Console.WriteLine("Bad response");
                    throw new ApplicationException(response.StatusCode.ToString());
                }
                using (Stream responseStream = response.GetResponseStream())
                {
                    if (responseStream != null)
                    {
                        using (StreamReader reader = new StreamReader(responseStream))
                        {
                            return reader;
                        }
                    }
                    return null;
                }
            }
        }
    }
}
