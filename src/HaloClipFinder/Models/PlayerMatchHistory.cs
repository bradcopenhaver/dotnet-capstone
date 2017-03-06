using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HaloClipFinder.Models
{
    public class PlayerMatchHistory
    {
        public class Id
        {
            public string MatchId { get; set; }
            public string GameMode { get; set; }
        }

        public class MapVariant
        {
            public int ResourceType { get; set; }
            public string ResourceId { get; set; }
            public string OwnerType { get; set; }
            public string Owner { get; set; }
        }

        public class GameVariant
        {
            public int ResourceType { get; set; }
            public string ResourceId { get; set; }
            public string OwnerType { get; set; }
            public string Owner { get; set; }
        }

        public class MatchCompletedDate
        {
            public string ISO8601Date { get; set; }
        }

        public class Team
        {
            public string Id { get; set; }
            public string Score { get; set; }
            public string Rank { get; set; }
        }

        public class Player
        {
            public string Gamertag { get; set; }
            public object Xuid { get; set; }
        }

        public class Players
        {
            public Player Player { get; set; }
            public string TeamId { get; set; }
            public string Rank { get; set; }
            public string Result { get; set; }
            public string TotalKills { get; set; }
            public string TotalDeaths { get; set; }
            public string TotalAssists { get; set; }
            public object PreMatchRatings { get; set; }
            public object PostMatchRatings { get; set; }
        }

        public class Result
        {
            public string Links { get; set; }
            public Id Id { get; set; }
            public string HopperId { get; set; }
            public string MapId { get; set; }
            public MapVariant MapVariant { get; set; }
            public string GameBaseVariantId { get; set; }
            public GameVariant GameVariant { get; set; }
            public string MatchDuration { get; set; }
            public MatchCompletedDate MatchCompletedDate { get; set; }
            public List<Team> Teams { get; set; }
            public List<Player> Players { get; set; }
            public string IsTeamGame { get; set; }
            public object SeasonId { get; set; }
            public string MatchCompletedDateFidelity { get; set; }
        }

        public class RootObject
        {
            public string Start { get; set; }
            public string Count { get; set; }
            public string ResultCount { get; set; }
            public List<Result> Results { get; set; }
        }

        public static PlayerMatchHistory GetPlayerMatchHistory(string gamertag)
        {
            RestClient client = new RestClient("https://www.haloapi.com/");
            RestRequest request = new RestRequest($"/stats/h5/players/{gamertag}/matches?&count=10");
            request.AddHeader("Ocp-Apim-Subscription-Key", EnvironmentVariables.HaloApiKey);
            RestResponse response = new RestResponse();

            Task.Run(async () =>
            {
                response = await GetResponseContentAsync(client, request) as RestResponse;
            }).Wait();

            PlayerMatchHistory returnedHistory = JsonConvert.DeserializeObject<PlayerMatchHistory>(response.Content);

            return returnedHistory;
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
