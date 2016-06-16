using GitHubApiWrapper.Json;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GitHubApiWrapper.Wrappers
{
    public class RepositoryWrapper
    {
        private readonly string _acceptheader;
        readonly string _useragent;

        public RepositoryWrapper(string acceptheader, string useragent)
        {
            this._useragent = useragent;
            this._acceptheader = acceptheader;
        }

        public IList<Repository> GetRepositoriesForUser(User user)
        {
            return GetRepositoriesForUser(user.Login);
        }

        public IList<Repository> GetRepositoriesForUser(string username)
        {
            //TODO: implement
            //return new List<Repository>();
            var repositoriesJson = GetRepositoryInfo(username);
            IList<Repository> repositories = ParseRepositories(repositoriesJson);
            return repositories;
        }

        private IList<Repository> ParseRepositories(string repositoriesJson)
        {
            List<RepositoryJson> repositories = JsonConvert.DeserializeObject<List<RepositoryJson>>(repositoriesJson);
            var repositoriesList = new List<Repository>();

            foreach (var repositoryJson in repositories)
            {
                repositoriesList.Add(new Repository(repositoryJson));
            }

            return repositoriesList;
        }

        private string GetRepositoryInfo(string userName)
        {
            try
            {
                HttpWebRequest loginRequest = (HttpWebRequest)WebRequest.Create("https://api.github.com/users/" + userName + "/repos");
                loginRequest.UserAgent = _useragent;
                loginRequest.Method = "Get";
                loginRequest.Accept = _acceptheader;
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
    }
}
