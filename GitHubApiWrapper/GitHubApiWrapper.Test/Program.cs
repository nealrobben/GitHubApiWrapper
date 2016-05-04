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
        private const string AcceptHeader = @"text/html, application/xhtml+xml, */*";

        static void Main(string[] args)
        {

            GitHubApiWrapper wrapper = new GitHubApiWrapper();
            User usr = wrapper.GetUser("nealrobben");

            Console.WriteLine(usr);
            Console.ReadLine();

        }
    }
}
