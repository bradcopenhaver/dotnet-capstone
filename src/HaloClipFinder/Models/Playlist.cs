using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace HaloClipFinder.Models
{
    public class Playlist
    {
        public string name { get; set; }
        public string description { get; set; }
        public bool isRanked { get; set; }
        public object imageUrl { get; set; }
        public string gameMode { get; set; }
        public bool isActive { get; set; }
        public string id { get; set; }
        public string contentId { get; set; }

        public static Playlist GetPlaylist(string id)
        {
            JArray o1 = JArray.Parse(File.ReadAllText(@"wwwroot/lib/Playlists.json"));
            JToken thisPlaylistToken = o1.FirstOrDefault(p => p["id"].ToString() == id);
            Playlist thisPlaylist = JsonConvert.DeserializeObject<Playlist>(thisPlaylistToken.ToString());

            return thisPlaylist;
        }
    }
}
