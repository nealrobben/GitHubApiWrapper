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
        public User()
        {

        }

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

        public string Login { get;  set; }
        public string ID { get;  set; }
        public string AvatarUrl { get;  set; }
        public string GravatarId { get;  set; }
        public string Url { get;  set; }
        public string HtmlUrl { get;  set; }
        public string FollowersUrl { get;  set; }
        public string FollowingUrl { get;  set; }
        public string GistsUrl { get;  set; }
        public string StarredUrl { get;  set; }
        public string SubscriptionsUrl { get;  set; }
        public string OrganizationsUrl { get;  set; }
        public string ReposUrl { get;  set; }
        public string EventsUrl { get;  set; }
        public string ReceivedEventsUrl { get;  set; }
        public string Type { get;  set; }
        public bool SiteAdmin { get;  set; }
        public string Name { get;  set; }
        public string Company { get;  set; }
        public string Blog { get;  set; }
        public string Location { get;  set; }
        public string Email { get;  set; }
        public bool Hireable { get;  set; }
        public string Bio { get;  set; }
        public int PublicRepos { get;  set; }
        public int PublicGists { get;  set; }
        public int Followers { get;  set; }
        public int Following { get;  set; }
        public DateTime CreatedAt { get;  set; }
        public DateTime UpdatedAt { get;  set; }

        public override string ToString()
        {
            return this.Name;
        }

    }
}
