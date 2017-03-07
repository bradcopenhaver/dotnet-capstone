using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace HaloClipFinder.Models
{
    public class Medal
    {
        public class SpriteLocation
        {
            public string spriteSheetUri { get; set; }
            public int left { get; set; }
            public int top { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public int spriteWidth { get; set; }
            public int spriteHeight { get; set; }
        }

        public class Root
        {
            public string name { get; set; }
            public string description { get; set; }
            public string classification { get; set; }
            public int difficulty { get; set; }
            public SpriteLocation spriteLocation { get; set; }
            public string id { get; set; }
            public string contentId { get; set; }
        }

        public static Root GetMedal(string id)
        {
            JArray o1 = JArray.Parse(File.ReadAllText(@"wwwroot/lib/Medals.json"));
            List<JToken> thisMedalList = o1.Children().Where(r => r["id"].ToString() == id).ToList();
            Root thisMedal = JsonConvert.DeserializeObject<Root>(thisMedalList[0].ToString());

            return thisMedal;
        }
    }
}
