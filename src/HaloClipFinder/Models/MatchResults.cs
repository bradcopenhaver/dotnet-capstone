using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HaloClipFinder.Models
{
    public class MatchResults
    {
        public class XpInfo
        {
            public int PrevSpartanRank { get; set; }
            public int SpartanRank { get; set; }
            public int PrevTotalXP { get; set; }
            public int TotalXP { get; set; }
            public double SpartanRankMatchXPScalar { get; set; }
            public int PlayerTimePerformanceXPAward { get; set; }
            public int PerformanceXP { get; set; }
            public int PlayerRankXPAward { get; set; }
            public int BoostAmount { get; set; }
            public int MatchSpeedWinAmount { get; set; }
            public int ObjectivesCompletedAmount { get; set; }
        }

        public class KilledOpponentDetail
        {
            public string GamerTag { get; set; }
            public int TotalKills { get; set; }
        }

        public class KilledByOpponentDetail
        {
            public string GamerTag { get; set; }
            public int TotalKills { get; set; }
        }

        public class MedalStatCount
        {
            public string Id { get; set; }
            public int Count { get; set; }
        }

        public class ImpulseStatCount
        {
            public string Id { get; set; }
            public int Count { get; set; }
        }

        public class ImpulseTimelaps
        {
            public string Id { get; set; }
            public string Timelapse { get; set; }
        }


        public class FlexibleStats
        {
            public List<MedalStatCount> MedalStatCounts { get; set; }
            public List<ImpulseStatCount> ImpulseStatCounts { get; set; }
            public List<object> MedalTimelapses { get; set; }
            public List<ImpulseTimelaps> ImpulseTimelapses { get; set; }
        }

        public class RewardSets
        {
            public string RewardSet { get; set; }
            public int RewardSourceType { get; set; }
            public object SpartanRankSource { get; set; }
            public string CommendationLevelId { get; set; }
            public string CommendationSource { get; set; }
        }

        public class CreditsEarned
        {
            public int Result { get; set; }
            public int TotalCreditsEarned { get; set; }
            public double SpartanRankModifier { get; set; }
            public int PlayerRankAmount { get; set; }
            public double TimePlayedAmount { get; set; }
            public int BoostAmount { get; set; }
            public int MatchSpeedWinAmount { get; set; }
            public int ObjectivesCompletedAmount { get; set; }
        }

        public class ProgressiveCommendationDelta
        {
            public string Id { get; set; }
            public int PreviousProgress { get; set; }
            public int Progress { get; set; }
        }

        public class Player
        {
            public string Gamertag { get; set; }
            public object Xuid { get; set; }
        }

        public class WeaponId
        {
            public uint StockId { get; set; }
            public List<object> Attachments { get; set; }
        }

        public class WeaponWithMostKills
        {
            public WeaponId WeaponId { get; set; }
            public int TotalShotsFired { get; set; }
            public int TotalShotsLanded { get; set; }
            public int TotalHeadshots { get; set; }
            public int TotalKills { get; set; }
            public double TotalDamageDealt { get; set; }
            public string TotalPossessionTime { get; set; }
        }

        public class MedalAward
        {
            public object MedalId { get; set; }
            public int Count { get; set; }
        }

        public class WeaponStat
        {
            public WeaponId WeaponId { get; set; }
            public int TotalShotsFired { get; set; }
            public int TotalShotsLanded { get; set; }
            public int TotalHeadshots { get; set; }
            public int TotalKills { get; set; }
            public double TotalDamageDealt { get; set; }
            public string TotalPossessionTime { get; set; }
        }

        public class Impulse
        {
            public long Id { get; set; }
            public int Count { get; set; }
        }

        public class PlayerStat
        {
            public XpInfo XpInfo { get; set; }
            public object PreviousCsr { get; set; }
            public object CurrentCsr { get; set; }
            public int MeasurementMatchesLeft { get; set; }
            public List<KilledOpponentDetail> KilledOpponentDetails { get; set; }
            public List<KilledByOpponentDetail> KilledByOpponentDetails { get; set; }
            public int WarzoneLevel { get; set; }
            public int TotalPiesEarned { get; set; }
            public FlexibleStats FlexibleStats { get; set; }
            public List<RewardSets> RewardSets { get; set; }
            public CreditsEarned CreditsEarned { get; set; }
            public List<object> MetaCommendationDeltas { get; set; }
            public List<ProgressiveCommendationDelta> ProgressiveCommendationDeltas { get; set; }
            public object BoostInfo { get; set; }
            public object PveTotalRoundKillBonuses { get; set; }
            public object PveTotalRoundAssistBonuses { get; set; }
            public object PveTotalRoundSurvivalBonuses { get; set; }
            public object PveTotalRoundSpeedBonuses { get; set; }
            public Player Player { get; set; }
            public int TeamId { get; set; }
            public int Rank { get; set; }
            public bool DNF { get; set; }
            public string AvgLifeTimeOfPlayer { get; set; }
            public object PreMatchRatings { get; set; }
            public object PostMatchRatings { get; set; }
            public int PlayerScore { get; set; }
            public int GameEndStatus { get; set; }
            public int TotalKills { get; set; }
            public int TotalHeadshots { get; set; }
            public double TotalWeaponDamage { get; set; }
            public int TotalShotsFired { get; set; }
            public int TotalShotsLanded { get; set; }
            public WeaponWithMostKills WeaponWithMostKills { get; set; }
            public int TotalMeleeKills { get; set; }
            public double TotalMeleeDamage { get; set; }
            public int TotalAssassinations { get; set; }
            public int TotalGroundPoundKills { get; set; }
            public double TotalGroundPoundDamage { get; set; }
            public int TotalShoulderBashKills { get; set; }
            public double TotalShoulderBashDamage { get; set; }
            public double TotalGrenadeDamage { get; set; }
            public int TotalPowerWeaponKills { get; set; }
            public double TotalPowerWeaponDamage { get; set; }
            public int TotalPowerWeaponGrabs { get; set; }
            public string TotalPowerWeaponPossessionTime { get; set; }
            public int TotalDeaths { get; set; }
            public int TotalAssists { get; set; }
            public int TotalGamesCompleted { get; set; }
            public int TotalGamesWon { get; set; }
            public int TotalGamesLost { get; set; }
            public int TotalGamesTied { get; set; }
            public string TotalTimePlayed { get; set; }
            public int TotalGrenadeKills { get; set; }
            public List<MedalAward> MedalAwards { get; set; }
            public List<object> DestroyedEnemyVehicles { get; set; }
            public List<object> EnemyKills { get; set; }
            public List<WeaponStat> WeaponStats { get; set; }
            public List<Impulse> Impulses { get; set; }
            public int TotalSpartanKills { get; set; }
            public string FastestMatchWin { get; set; }
        }

        public class Root
        {
            public List<PlayerStat> PlayerStats { get; set; }
        }

        public static Root CurrentMatchResults { get; set; }
        public static List<List<String>> CurrentTeams { get; set; }

        public static void GetMatchResultsById(string matchId, string gameMode)
        {
            CurrentTeams = new List<List<string>> { };
            string mode = "";
            switch (gameMode)
            {
                case "1":
                    mode = "arena";
                    break;
                case "3":
                    mode = "custom";
                    break;
                case "4":
                    mode = "warzone";
                    break;
                default:
                    break;
            }
            RestClient client = new RestClient("https://www.haloapi.com/");
            RestRequest request = new RestRequest($"/stats/h5/{mode}/matches/{matchId}");
            request.AddHeader("Ocp-Apim-Subscription-Key", EnvironmentVariables.HaloApiKey);
            RestResponse response = new RestResponse();

            Task.Run(async () =>
            {
                response = await GetResponseContentAsync(client, request) as RestResponse;
            }).Wait();

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                CurrentMatchResults = JsonConvert.DeserializeObject<Root>(response.Content);
                var possibleTeams = new List<String>[8] { new List<String> { }, new List<String> { }, new List<String> { }, new List<String> { }, new List<String> { }, new List<String> { }, new List<String> { }, new List<String> { } };
                for (int i = 0; i < CurrentMatchResults.PlayerStats.Count; i++)
                {
                    if (CurrentMatchResults.PlayerStats[i].DNF)
                    {
                        possibleTeams[CurrentMatchResults.PlayerStats[i].TeamId].Add(CurrentMatchResults.PlayerStats[i].Player.Gamertag + " -- DNF");
                    }
                    else
                    {
                        possibleTeams[CurrentMatchResults.PlayerStats[i].TeamId].Add(CurrentMatchResults.PlayerStats[i].Player.Gamertag);
                    }
                    
                }
                for (int i = 0; i < possibleTeams.Length; i++)
                {
                    if (possibleTeams[i].Count >0)
                    {
                        possibleTeams[i].Insert(0, "Team Color");
                        CurrentTeams.Add(possibleTeams[i]);
                    }
                }
            }
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
