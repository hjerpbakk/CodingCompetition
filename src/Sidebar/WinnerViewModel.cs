using System;
using System.Windows;
using NDC2015;

namespace Sidebar
{
    public class WinnerViewModel : ViewModelBase
    {
        private string awesomePassword;
        private string theWinner;
        private Visibility endCompetitionVisibility;

        private readonly Scores scores;

        public WinnerViewModel(Scores scores, Action endCompetition)
        {
            this.scores = scores;
            EndCompetitionCommand = new DelegateCommand(
                o =>
                {
                    scores.EndCompetition();
                    endCompetition();
                });
            endCompetitionVisibility = Visibility.Collapsed;
        }

        public DelegateCommand EndCompetitionCommand { get; }
        
        public string AwesomePassword
        {
            get { return awesomePassword; }
            set
            {
                Set(ref awesomePassword, value);
                switch (value)
                {
                    case "runarerbest":
                        TheWinner = scores.DrawWinner().ToString();
                        EndCompetitionVisibility = Visibility.Visible;
                        break;
                }
            }
        }

        public string TheWinner
        {
            get { return theWinner; }
            set { Set(ref theWinner, value); }
        }

        public Visibility EndCompetitionVisibility
        {
            get { return endCompetitionVisibility; }
            set { Set(ref endCompetitionVisibility, value); }
        }
    }
}