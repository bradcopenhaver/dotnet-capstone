using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace HaloClipFinder.Models
{
    public class GameBaseVariant
    {
        public string name { get; set; }

        public static string GetGameBaseVariant(string id)
        {
            JArray o1 = JArray.Parse(File.ReadAllText(@"wwwroot/lib/BaseGameVariants.json"));
            JToken thisGameBaseVariantToken = o1.FirstOrDefault(b => b["id"].ToString() == id);
            string thisGameBaseVariant = thisGameBaseVariantToken["name"].ToString();

            return thisGameBaseVariant;
        }
    }
}
