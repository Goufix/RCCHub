using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RCCHub
{
    class user
    {
        // set Config xml
        public void SetCfg(string nick, string TAG, string position)
        {
            Properties.Settings.Default.Nick = nick;
            Properties.Settings.Default.TAG = TAG;
            Properties.Settings.Default.Position = position;
            Properties.Settings.Default.Save();
        }
        // Get nick uniqueID (ID from habbo's API)
        public string habboID(string nick)
        {
            WebClient client = new WebClient();
            client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
            string id = client.DownloadString(string.Format("https://www.habbo.com.br/api/public/users?name={0}", nick));
            id = id.Substring(id.IndexOf("\"uniqueId\":\""), id.IndexOf("\","));
            id = id.Replace("\"uniqueId\":\"", "").
                   Replace("\"", "");
            return id;
        }
        // Get full habbo's API result
        public string habboProfile(string id)
        {
            WebClient habboProfile = new WebClient();
            habboProfile.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
            string profileString = habboProfile.DownloadString(string.Format("https://www.habbo.com/api/public/users/{0}/profile", id));
            return profileString;
        }
        // Get company group data
        public bool isOnGroup(string profileString, string company)
        {
            if (profileString.Contains(company))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
