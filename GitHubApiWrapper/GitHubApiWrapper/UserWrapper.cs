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
    public class UserWrapper
    {
        private readonly string _acceptheader;
        readonly string _useragent;

        public UserWrapper(string acceptheader, string useragent)
        {
            this._useragent = useragent;
            this._acceptheader = acceptheader;
        }

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

        private User ParseUser(string json)
        {
            UserJson usr = JsonConvert.DeserializeObject<UserJson>(json);
            return new User(usr);
        }
    }
}
