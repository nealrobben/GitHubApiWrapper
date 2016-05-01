using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GitHubApiWrapper.Test
{
    class Program
    {
        private const string UserAgent = @"Mozilla/5.0 (Windows NT 6.1; WOW64; Trident/7.0; rv:11.0) like Gecko";

        static void Main(string[] args)
        {
            HttpWebRequest loginRequest = (HttpWebRequest)WebRequest.Create("https://api.github.com/users/nealrobben");
            loginRequest.UserAgent = UserAgent;
            loginRequest.Method = "Get";
            loginRequest.Accept = @"text/html, application/xhtml+xml, */*";
            loginRequest.AllowAutoRedirect = false;

            var httpresp2 = (HttpWebResponse)loginRequest.GetResponse();
            StreamReader reader2 = new StreamReader(httpresp2.GetResponseStream());
            string responseContent = reader2.ReadToEnd();
            Console.WriteLine(responseContent);
            Console.ReadLine();

        }
    }
}
