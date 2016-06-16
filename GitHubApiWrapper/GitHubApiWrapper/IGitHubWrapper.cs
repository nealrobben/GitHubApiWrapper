using System.Collections.Generic;

namespace GitHubApiWrapper
{
    public interface IGitHubWrapper
    {
        IList<IRepository> GetRepositoriesForUser(User user);
        IList<IRepository> GetRepositoriesForUser(string username);
        IUser GetUser(string userName);
    }
}