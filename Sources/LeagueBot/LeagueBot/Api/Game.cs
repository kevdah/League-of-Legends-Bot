﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace LeagueBot.Api
{
    public class Game
    {
        public double currentHealth { get; set; }
        public double maxHealth { get; set; }
        public double resourceValue { get; set; }
        public double resourceMax { get; set; }

        [JsonProperty("currentGold")]
        public double currentGold { get; set; }
        [JsonProperty("level")]
        public int level { get; set; }
        [JsonProperty("summonerName")]
        public string summonerName { get; set; }
        public double kills { get; set; }
        public double deaths { get; set; }
        public double assists { get; set; }
        public double creepScore { get; set; }
    }
}