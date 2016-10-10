using System;
using System.Diagnostics;
using System.Windows.Threading;

namespace NDC2015
{
    public class RoundAdminViewModel : ViewModelBase
    {
        private const string RunningText = "I give up!";
        private const string FinishedText = "New contestant";

        private const string SummaryTextFailed = "Better luck next time :)";
        private const string SummaryTextSuccess = "That was enough for {0}. place :)";

        private string contestant;
        private string phone;

        private string buttonText;
        private string summaryText;

        private bool showSummary;
        private bool enableButtonTwo;

        private readonly ICompetition competition;
        private readonly Stopwatch stopWatch;
        private readonly DispatcherTimer uiUpdateTimer;

        public RoundAdminViewModel(ICompetition competition)
        {
            this.competition = competition;
            StartCommand = new DelegateCommand(o => !string.IsNullOrEmpty(contestant) &&
                                                !string.IsNullOrEmpty(phone), StartRound);
            ButtonTwoCommand = new DelegateCommand(o => enableButtonTwo, EndRound);

            stopWatch = new Stopwatch();
            uiUpdateTimer = new DispatcherTimer();
            uiUpdateTimer.Tick += UpdateElapsedTime;
            uiUpdateTimer.Interval = TimeSpan.FromMilliseconds(8);

            ButtonText = RunningText;
        }

        public DelegateCommand StartCommand { get; private set; }
        public DelegateCommand ButtonTwoCommand { get; private set; }

        public string Contestant
        {
            get { return contestant; }
            set
            {
                Set(ref contestant, value);
                StartCommand.OnCanExecuteChanged();
            }
        }

        public string Phone
        {
            get { return phone; }
            set
            {
                Set(ref phone, value);
                StartCommand.OnCanExecuteChanged();
            }
        }

        public string SummaryText
        {
            get { return summaryText; }
            set { Set(ref summaryText, value); }
        }

        public string ButtonText
        {
            get { return buttonText; }
            set { Set(ref buttonText, value); }
        }
        
        public bool ShowSummary
        {
            get { return showSummary; }
            set { Set(ref showSummary, value); }
        }

        public bool Running
        {
            get { return stopWatch.IsRunning; }
        }

        public string ElapsedTime { get; private set; }

        private void StartRound(object obj)
        {
            competition.ResetTests();
            competition.StartRound();
            stopWatch.Reset();
            stopWatch.Start();
            uiUpdateTimer.Start();

            enableButtonTwo = true;
            ButtonTwoCommand.OnCanExecuteChanged();
            OnPropertyChanged("Running");
        }

        private void EndRound(object obj)
        {
            ShowSummary = !ShowSummary;

            if (ShowSummary)
            {
                ButtonText = FinishedText;
                stopWatch.Stop();
                uiUpdateTimer.Stop();

                if (obj is int)
                {
                    UpdateElapsedTime(null, null);
                    var score = new Score(stopWatch.Elapsed, Contestant, Phone);
                    var position = competition.SaveScore(score);
                    SummaryText = string.Format(SummaryTextSuccess, position);
                }
                else
                {
                    SummaryText = SummaryTextFailed;
                }
            }
            else
            {
                ButtonText = RunningText;
                enableButtonTwo = false;
                ButtonTwoCommand.OnCanExecuteChanged();

                competition.ResetTests();
                Contestant = "";
                Phone = "";
                OnPropertyChanged("Running");
            }
        }
        
        private void UpdateElapsedTime(object sender, EventArgs e)
        {
            ElapsedTime = stopWatch.Elapsed.ToString(Leaderboard.ElapsedFormatString);
            OnPropertyChanged("ElapsedTime");
        }
    }
}