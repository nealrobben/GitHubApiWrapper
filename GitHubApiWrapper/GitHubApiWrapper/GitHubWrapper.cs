using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GitHubApiWrapper
{
    public class GitHubWrapper : IGitHubWrapper
    {
        private const string UserAgent = @"Mozilla/5.0 (Windows NT 6.1; WOW64; Trident/7.0; rv:11.0) like Gecko";
        private const string AcceptHeader = @"text/html, application/xhtml+xml, */*";

        public User GetUser(string userName)
        {
            string userJson = GetUserInfo(userName);
            User usr = ParseUser(userJson);

            return usr;
        }

        public IList<Repository> GetRepositoriesForUser(User user)
        {
            return GetRepositoriesForUser(user.Login);
        }

        public IList<Repository> GetRepositoriesForUser(string username)
        {
            var repositoryWrapper = new RepositoryWrapper(AcceptHeader, UserAgent);
            return repositoryWrapper.GetRepositoriesForUser(username);
        }

        private string GetUserInfo(string userName)
        {
            try
            {
                HttpWebRequest loginRequest = (HttpWebRequest)WebRequest.Create("https://api.github.com/users/" + userName);
                loginRequest.UserAgent = UserAgent;
                loginRequest.Method = "Get";
                loginRequest.Accept = AcceptHeader;
                loginRequest.AllowAutoRedirect = false;

                var httpresp2 = (HttpWebResponse)loginRequest.GetResponse();
                StreamReader reader2 = new StreamReader(httpresp2.GetResponseStream());
                return reader2.ReadToEnd();
            }
            catch (Exception)
            {
                throw new ArgumentException("Invalid username");
            }
        }

        private User ParseUser(string json)
        {
            UserJson usr = JsonConvert.DeserializeObject<UserJson>(json);
            return new User(usr);
        }

    }
}
