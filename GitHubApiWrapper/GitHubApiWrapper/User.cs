using GitHubApiWrapper.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GitHubApiWrapper
{ 
    /// <summary>
    /// A single GitHub User
    /// </summary>
    public class User
    {
        public User(UserJson userJson)
        {
            this.Login = userJson.login;
            this.ID = userJson.id;
            this.AvatarUrl = userJson.avatar_url;
            this.GravatarId = userJson.gravatar_id;
            this.Url = userJson.url;
            this.HtmlUrl = userJson.html_url;
            this.FollowersUrl = userJson.followers_url;
            this.FollowingUrl = userJson.following_url;
            this.GistsUrl = userJson.gists_url;
            this.StarredUrl = userJson.starred_url;
            this.SubscriptionsUrl = userJson.subscriptions_url;
            this.ReposUrl = userJson.repos_url;
            this.EventsUrl = userJson.events_url;
            this.ReceivedEventsUrl = userJson.received_events_url;

            this.Type = userJson.type;
            this.SiteAdmin = userJson.site_admin;
            this.Name = userJson.name;
            this.Company = userJson.company;
            this.Blog = userJson.blog;
            this.Location = userJson.location;
            this.Email = userJson.email;
            this.Hireable = userJson.hireable;
            this.Bio = userJson.bio;
            this.PublicRepos = userJson.public_repos;
            this.PublicGists = userJson.public_gists;
            this.Followers = userJson.followers;
            this.Following = userJson.following;
            this.CreatedAt = userJson.created_at;
            this.UpdatedAt = userJson.updated_at;
        }

        public string Login { get; private set; }
        public string ID { get; private set; }
        public string AvatarUrl { get; private set; }
        public string GravatarId { get; private set; }
        public string Url { get; private set; }
        public string HtmlUrl { get; private set; }
        public string FollowersUrl { get; private set; }
        public string FollowingUrl { get; private set; }
        public string GistsUrl { get; private set; }
        public string StarredUrl { get; private set; }
        public string SubscriptionsUrl { get; private set; }
        public string OrganizationsUrl { get; private set; }
        public string ReposUrl { get; private set; }
        public string EventsUrl { get; private set; }
        public string ReceivedEventsUrl { get; private set; }
        public string Type { get; private set; }
        public bool SiteAdmin { get; private set; }
        public string Name { get; private set; }
        public string Company { get; private set; }
        public string Blog { get; private set; }
        public string Location { get; private set; }
        public string Email { get; private set; }
        public bool? Hireable { get; private set; }
        public string Bio { get; private set; }
        public int PublicRepos { get; private set; }
        public int PublicGists { get; private set; }
        public int Followers { get; private set; }
        public int Following { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }

        public override string ToString()
        {
            return this.Name;
        }

    }
}
