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
    public class GitHubApiWrapper
    {
        private const string UserAgent = @"Mozilla/5.0 (Windows NT 6.1; WOW64; Trident/7.0; rv:11.0) like Gecko";
        private const string AcceptHeader = @"text/html, application/xhtml+xml, */*";

        public User GetUser(string userName)
        {
            string userJson = GetUserInfo(userName);
            User usr = ParseUser(userJson);

            return usr;
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
            dynamic usrJson = JsonConvert.DeserializeObject(json);

            var usr = new User();

            usr.Login = usrJson.login;
            usr.ID = usrJson.id;
            usr.AvatarUrl = usrJson.avatar_url;
            usr.GravatarId = usrJson.gravatar_id;
            usr.Url = usrJson.url;
            usr.HtmlUrl = usrJson.html_url;
            usr.FollowersUrl = usrJson.html_url;
            usr.FollowingUrl = usrJson.following_url;
            usr.GistsUrl = usrJson.gists_url;
            usr.StarredUrl = usrJson.starred_url;
            usr.SubscriptionsUrl = usrJson.subscriptions_url;
            usr.OrganizationsUrl = usrJson.organizations_url;
            usr.ReposUrl = usrJson.repos_url;
            usr.EventsUrl = usrJson.events_url;
            usr.ReceivedEventsUrl = usrJson.received_events_url;
            usr.Type = usrJson.type;
            usr.SiteAdmin = (bool)usrJson.site_admin;
            usr.Name = usrJson.name;
            usr.Company = usrJson.company;
            usr.Blog = usrJson.blog;
            usr.Location = usrJson.location;
            usr.Email = usrJson.email;
            //usr.Hireable = (bool)usrJson.hireable;
            usr.Bio = usrJson.bio;
            usr.PublicRepos = (int)usrJson.public_repos;
            usr.PublicGists = (int)usrJson.public_gists;
            usr.Followers = (int)usrJson.followers;
            usr.Following = (int)usrJson.following;
            //usr.CreatedAt = DateTime.Parse(usrJson.created_at);
            //usr.UpdatedAt = DateTime.Parse(usrJson.updated_at);

            return usr;

        }

    }
}
