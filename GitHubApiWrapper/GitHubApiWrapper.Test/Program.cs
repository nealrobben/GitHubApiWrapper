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

            var repos = wrapper.GetRepositoriesForUser("nealrobben");
            foreach(var repo in repos)
            {
                Console.WriteLine(repo);
            }

            Console.WriteLine(usr);
            Console.ReadLine();
        }
    }
}
