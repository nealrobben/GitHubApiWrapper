using System;

namespace GitHubApiWrapper
{
    public interface IUser
    {
        string AvatarUrl { get; }
        string Bio { get; }
        string Blog { get; }
        string Company { get; }
        DateTime CreatedAt { get; }
        string Email { get; }
        string EventsUrl { get; }
        int Followers { get; }
        string FollowersUrl { get; }
        int Following { get; }
        string FollowingUrl { get; }
        string GistsUrl { get; }
        string GravatarId { get; }
        bool? Hireable { get; }
        string HtmlUrl { get; }
        string ID { get; }
        string Location { get; }
        string Login { get; }
        string Name { get; }
        string OrganizationsUrl { get; }
        int PublicGists { get; }
        int PublicRepos { get; }
        string ReceivedEventsUrl { get; }
        string ReposUrl { get; }
        bool SiteAdmin { get; }
        string StarredUrl { get; }
        string SubscriptionsUrl { get; }
        string Type { get; }
        DateTime UpdatedAt { get; }
        string Url { get; }

        string ToString();
    }
}