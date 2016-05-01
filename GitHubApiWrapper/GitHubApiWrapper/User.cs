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
        public User(string Login, string ID, string AvatarUrl, string GravatarId, string Url, string HtmlUrl, string FollowersUrl, 
            string FollowingUrl, string GistsUrl, string StarredUrl, string SubscriptionsUrl, string OrganizationsUrl, string ReposUrl,
            string EventsUrl, string ReceivedEventsUrl, string Type, bool SiteAdmin, string Name, string Company, string Blog, string Location,
            string Email, bool Hireable, string Bio, int PublicRepos, int PublicGists, int Followers, int Following, DateTime CreatedAt,
            DateTime UpdatedAt)
        {
            this.Login = Login;
            this.ID = ID;
            this.AvatarUrl = AvatarUrl;
            this.GravatarId = GravatarId;
            this.Url = Url;
            this.HtmlUrl = HtmlUrl;
            this.FollowersUrl = FollowersUrl;
            this.FollowingUrl = FollowingUrl;
            this.GistsUrl = GistsUrl;
            this.StarredUrl = StarredUrl;
            this.SubscriptionsUrl = SubscriptionsUrl;
            this.OrganizationsUrl = OrganizationsUrl;
            this.ReposUrl = ReposUrl;
            this.EventsUrl = EventsUrl;
            this.ReceivedEventsUrl = ReceivedEventsUrl;

            this.Type = Type;
            this.SiteAdmin = SiteAdmin;
            this.Name = Name;
            this.Company = Company;
            this.Blog = Blog;
            this.Location = Location;
            this.Email = Email;
            this.Hireable = Hireable;
            this.Bio = Bio;
            this.PublicRepos = PublicRepos;
            this.PublicGists = PublicGists;
            this.Followers = Followers;
            this.Following = Following;
            this.CreatedAt = CreatedAt;
            this.UpdatedAt = UpdatedAt;

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
        public bool Hireable { get; private set; }
        public string Bio { get; private set; }
        public int PublicRepos { get; private set; }
        public int PublicGists { get; private set; }
        public int Followers { get; private set; }
        public int Following { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }
    }
}
