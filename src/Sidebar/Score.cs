using System;
using Newtonsoft.Json;

namespace NDC2015
{
    [Serializable]
    public struct Score
    {
        [JsonConstructor]
        public Score(TimeSpan elapsedTime, string contestantName, string phone)
        {
            ElapsedTime = elapsedTime;
            ContestantName = contestantName;
            Phone = phone;
        }

        public readonly TimeSpan ElapsedTime;
        public string ContestantName { get; }
        public readonly string Phone;

        public string FriendlyElapsedTime
        {
            get { return ElapsedTime.ToString(Leaderboard.ElapsedFormatString); }
        }
    }
}