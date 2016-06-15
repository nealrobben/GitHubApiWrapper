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
        static void Main(string[] args)
        {
            GitHubWrapper wrapper = new GitHubWrapper();
            User usr = wrapper.GetUser("nealrobben");

            Console.WriteLine(usr);
            Console.ReadLine();
        }
    }
}
