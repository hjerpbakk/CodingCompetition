using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Windows;
using System.Windows.Threading;
using NDC2015;
using Runner;
using Sidebar;

namespace Sidebar
{
    public class CompetitionRoundViewModel : ViewModelBase, ICompetition
    {
        private ObservableCollection<TestResultViewModel> testResults;

        private readonly Communicator communicator;
        private readonly Scores scores;
        private readonly DispatcherTimer uiUpdateTimer;
        private RangeObservableCollection<Score> theScores; 

        public CompetitionRoundViewModel()
        {
            communicator = new Communicator();
            scores = new Scores();
            TestResults = new ObservableCollection<TestResultViewModel>
            {
                new TestResultViewModel { Name = "FirstTest" },
                new TestResultViewModel { Name = "SecondTest" },
                new TestResultViewModel { Name = "ThirdTest" },
                new TestResultViewModel { Name = "FourthTest" },
                new TestResultViewModel { Name = "FifthTest" }
            };
            
            uiUpdateTimer = new DispatcherTimer();
            uiUpdateTimer.Tick += UpdateResults;
            uiUpdateTimer.Interval = TimeSpan.FromMilliseconds(300);
            
            RoundAdminViewModel = new RoundAdminViewModel(this);
            ResetTests();

            Scores = new RangeObservableCollection<Score>();
            Scores.AddRange(scores.TheScores);

            OpenLeaderboardCommand = new DelegateCommand(o => OpenLeaderboard());
            DrawWinnerCommand = new DelegateCommand(o => DrawWinner());
        }

        public RoundAdminViewModel RoundAdminViewModel { get; }
        public DelegateCommand OpenLeaderboardCommand { get; }
        public DelegateCommand DrawWinnerCommand { get; }

        public ObservableCollection<TestResultViewModel> TestResults
        {
            get { return testResults; }
            set { Set(ref testResults, value); }
        }

        public RangeObservableCollection<Score> Scores
        {
            get { return theScores; }
            set { Set(ref theScores, value); }
        }

        private void UpdateResults(object sender = null, EventArgs e = null)
        {
            var results = communicator.Read();
            bool finished = true;
            for (int i = 0; i < results.Length; i++)
            {
                var result = results[i] == 1;
                TestResults[i].Result = result;
                finished = finished && result;
            }

            if (!finished)
            {
                return;
            }

            uiUpdateTimer.Stop();
            RoundAdminViewModel.ButtonTwoCommand.Execute(results.Length);
        }

        public void ResetTests()
        {
            communicator.Reset();
            UpdateResults();
        }

        public int SaveScore(Score score)
        {
            uiUpdateTimer.Stop();
            Scores.Add(score);
            var position = scores.Save(score);
            Scores.Clear();
            Scores.AddRange(scores.TheScores.Take(10));
            return position;
        }

        public void StartRound()
        {
            uiUpdateTimer.Start();
        }

        private static void OpenLeaderboard() => Process.Start(Sidebar.Scores.LeaderBoardPath);

        private void DrawWinner()
        {
            var winner = scores.DrawWinner();
            MessageBox.Show(winner.ToString(), "The winner is...");
        }
    }

    public interface ICompetition
    {
        void ResetTests();
        int SaveScore(Score score);
        void StartRound();
    }
}