using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;

namespace HaloClipFinder.Models
{
    public class MatchEvents
    {
        public class Assistant
        {
            public string Gamertag { get; set; }
            public object Xuid { get; set; }
        }

        public class Killer
        {
            public string Gamertag { get; set; }
            public object Xuid { get; set; }
        }

        public class KillerWorldLocation
        {
            public string x { get; set; }
            public string y { get; set; }
            public string z { get; set; }
        }

        public class Player
        {
            public string Gamertag { get; set; }
            public object Xuid { get; set; }
        }

        public class Victim
        {
            public string Gamertag { get; set; }
            public object Xuid { get; set; }
        }

        public class VictimWorldLocation
        {
            public string x { get; set; }
            public string y { get; set; }
            public string z { get; set; }
        }

        public class GameEvent
        {
            public List<Assistant> Assistants { get; set; }
            public string DeathDisposition { get; set; }
            public string ImpulseId { get; set; }
            public string IsAssassination { get; set; }
            public string IsGroundPound { get; set; }
            public string IsHeadshot { get; set; }
            public string IsMelee { get; set; }
            public string IsShoulderBash { get; set; }
            public string IsWeapon { get; set; }
            public Killer Killer { get; set; }
            public string KillerAgent { get; set; }
            public List<string> KillerWeaponAttachmentIds { get; set; }
            public string KillerWeaponStockId { get; set; }
            public KillerWorldLocation KillerWorldLocation { get; set; }
            public string MedalId { get; set; }
            public Player Player { get; set; }
            public string RoundIndex { get; set; }
            public string ShotsFired { get; set; }
            public string ShotsLanded { get; set; }
            public string TimeWeaponActiveAsPrimary { get; set; }
            public Victim Victim { get; set; }
            public string VictimAgent { get; set; }
            public List<string> VictimAttachmentIds { get; set; }
            public string VictimStockId { get; set; }
            public VictimWorldLocation VictimWorldLocation { get; set; }
            public List<string> WeaponAttachmentIds { get; set; }
            public string WeaponStockId { get; set; }
            public string EventName { get; set; }
            public string TimeSinceStart { get; set; }
        }

        public class Root
        {
            public List<GameEvent> GameEvents { get; set; }
            public string IsCompleteSetOfEvents { get; set; }
            public object Links { get; set; }
        }
        public static Root currentMatchEvents { get; set; }

        

        public static void GetMatchEventsById(string matchId)
        {
            RestClient client = new RestClient("https://www.haloapi.com/");
            RestRequest request = new RestRequest($"/stats/h5/matches/{matchId}/events?");
            request.AddHeader("Ocp-Apim-Subscription-Key", EnvironmentVariables.HaloApiKey);
            RestResponse response = new RestResponse();

            Task.Run(async () =>
            {
                response = await GetResponseContentAsync(client, request) as RestResponse;
            }).Wait();

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                currentMatchEvents = JsonConvert.DeserializeObject<Root>(response.Content);
            }
        }

        public static List<GameEvent> GetMatchEvents(string gamertag)
        {
            List<GameEvent> relevantEvents = new List<GameEvent> { };
                        
            for (int i = 0; i < currentMatchEvents.GameEvents.Count; i++)
            {
                if (currentMatchEvents.GameEvents[i].EventName == "Medal" && currentMatchEvents.GameEvents[i].Player.Gamertag == gamertag)
                {
                    TimeSpan time = XmlConvert.ToTimeSpan(currentMatchEvents.GameEvents[i].TimeSinceStart);
                    string timeString = time.ToString(@"d\d\ hh\hmm\mss\s").TrimStart(' ', 'd', 'h', 'm', 's', '0');
                    currentMatchEvents.GameEvents[i].TimeSinceStart = timeString;
                    relevantEvents.Add(currentMatchEvents.GameEvents[i]);
                }
            }

            return relevantEvents;
        }

        public static Task<IRestResponse> GetResponseContentAsync(RestClient theClient, RestRequest theRequest)
        {
            var tcs = new TaskCompletionSource<IRestResponse>();
            theClient.ExecuteAsync(theRequest, response => {
                tcs.SetResult(response);
            });
            return tcs.Task;
        }

        
    }
}
