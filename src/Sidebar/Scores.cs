using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Runner;

namespace Sidebar
{
    public class Scores
    {
        public static readonly string LeaderBoardPath;

        private static readonly string scoresPath;

        private static readonly Random randomGenerator;

        static Scores()
        {
            LeaderBoardPath = Path.Combine(Communicator.SaveFolder, "Leaderboard.html");
            scoresPath = Path.Combine(Communicator.SaveFolder, "Scores.json");
            CreateFileIfNeeded(LeaderBoardPath);
            CreateFileIfNeeded(scoresPath);
            CopyFileIfNeeded("leaderboard.css");
            CopyFileIfNeeded("logo.png");
            randomGenerator = new Random();
        }

        public Scores()
        {
            GetPreviousScores();
            WriteLeaderBoard();
        }

        public List<Score> TheScores { get; private set; }

        public int Save(Score score)
        {
            TheScores.Add(score);
            TheScores = TheScores.OrderBy(s => s.ElapsedTime).ToList();
            var position = TheScores.IndexOf(score) + 1;
            File.WriteAllText(scoresPath, JsonConvert.SerializeObject(TheScores), Encoding.UTF8);
            WriteLeaderBoard(position);
            return position;
        }

        public Score DrawWinner()
        {
            var luckyNumber = randomGenerator.Next(TheScores.Count);
            return TheScores[luckyNumber];
        }

        private void WriteLeaderBoard(int position = 0)
        {
            var leaderboard = new Leaderboard().CreateHTML(TheScores, position);
            File.WriteAllText(LeaderBoardPath, leaderboard, Encoding.UTF8);
        }

        private static void CreateFileIfNeeded(string path)
        {
            if (File.Exists(path))
            {
                return;
            }

            using (File.Create(path)) { }
        }

        private static void CopyFileIfNeeded(string fileName)
        {
            var path = Path.Combine(Communicator.SaveFolder, fileName);
            if (File.Exists(path))
            {
                return;
            }

            File.Copy(fileName, path);
        }

        private void GetPreviousScores()
        {
            if (File.Exists(scoresPath))
            {
                var fileContent = File.ReadAllText(scoresPath, Encoding.UTF8);
                TheScores = JsonConvert.DeserializeObject<List<Score>>(fileContent);
            }
            
            if (TheScores == null)
            {
                TheScores = new List<Score>();
            }        
        } 
    }
}