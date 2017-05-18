using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

namespace HaloClipFinder.Models
{
    public class TeamColor
    {        
        public string name { get; set; }
        public object description { get; set; }
        public string color { get; set; }
        public string iconUrl { get; set; }
        public string id { get; set; }
        public string contentId { get; set; }
        
        public static TeamColor GetTeamColor(string teamId)
        {
            JArray o1 = JArray.Parse(File.ReadAllText(@"wwwroot/lib/TeamColors.json"));
            JToken thisTeamColorToken = o1.FirstOrDefault(r => r["id"].ToString() == teamId);
            TeamColor thisTeamColor = JsonConvert.DeserializeObject<TeamColor>(thisTeamColorToken.ToString());

            return thisTeamColor;
        }
    }
}
