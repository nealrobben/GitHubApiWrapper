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

        /// <summary>
        /// Get a User based on the login of the user
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public User GetUser(string userName)
        {
            var userWrapper = new UserWrapper(AcceptHeader, UserAgent);
            return userWrapper.GetUser(userName);
        }

        /// <summary>
        /// Get the Repositories for a User
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public IList<Repository> GetRepositoriesForUser(User user)
        {
            return GetRepositoriesForUser(user.Login);
        }

        /// <summary>
        /// Get the Repositories for a user login
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public IList<Repository> GetRepositoriesForUser(string username)
        {
            var repositoryWrapper = new RepositoryWrapper(AcceptHeader, UserAgent);
            return repositoryWrapper.GetRepositoriesForUser(username);
        }

    }
}
