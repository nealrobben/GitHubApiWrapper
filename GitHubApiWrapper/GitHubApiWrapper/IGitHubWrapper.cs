using System.Collections.Generic;

namespace GitHubApiWrapper
{
    public interface IGitHubWrapper
    {
        IList<Repository> GetRepositoriesForUser(User user);
        IList<Repository> GetRepositoriesForUser(string username);
        User GetUser(string userName);
    }
}