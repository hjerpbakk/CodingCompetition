using System;
using Newtonsoft.Json;

namespace Sidebar
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

        public TimeSpan ElapsedTime { get; }
        public string ContestantName { get; }
        public string Phone { get; }

        public string FriendlyElapsedTime => ElapsedTime.ToString(Leaderboard.ElapsedFormatString);

        public override string ToString() => $"{ContestantName} - {Phone}";
    }
}