using System.Collections.Generic;
using System.Text;

namespace Sidebar
{
    public class Leaderboard
    {
        public const string ElapsedFormatString = @"hh\:mm\:ss\:fff";

        public string CreateHTML(List<Score> scores, int latestContestant = 0)
        {
            int numberOfRowsToDisplay = scores.Count >= 10 ? 10 : scores.Count;
            var html = new StringBuilder(GetHtmlHeaderAndStartOfBody());

            AddRowsInHtmlTable(html, scores, latestContestant, numberOfRowsToDisplay);
            AddLatestContestantIfBelowHighScoreList(html, scores, latestContestant);

            html.Append(GetHtmlFooter());
            return html.ToString();
        }

        private static void AddRowsInHtmlTable(StringBuilder stringBuilder, IReadOnlyList<Score> scores, int latestContestant, int numberOfRowsToDisplay)
        {
            for (int i = 0; i < numberOfRowsToDisplay; i++)
            {
                AddRowInHtmlTable(stringBuilder, scores, latestContestant, i + 1);
            }
        }

        private static void AddLatestContestantIfBelowHighScoreList(StringBuilder stringBuilder, IReadOnlyList<Score> scores, int latestContestant)
        {
            if (latestContestant > 10)
            {
                AddRowInHtmlTable(stringBuilder, scores, latestContestant, latestContestant);
            }
        }

        private static void AddRowInHtmlTable(StringBuilder stringBuilder, IReadOnlyList<Score> scores, int latestContestant, int position)
        {
            string rowClass = position == latestContestant ? "id=\"selected\"" : "";
            var score = scores[position-1];
            stringBuilder.Append("<tr ");
            stringBuilder.Append(rowClass);
            stringBuilder.Append("><td align=\"right\" style=\"width: 80px\">");
            stringBuilder.Append(position);
            stringBuilder.Append(".</td><td>");
            stringBuilder.Append(score.ContestantName);
            stringBuilder.Append("</td><td align=\"center\" style=\"width: 250px\">");
            stringBuilder.Append(score.FriendlyElapsedTime);
            stringBuilder.AppendLine("</td></tr>");
        }

        private static string GetHtmlHeaderAndStartOfBody()
        {
            const string HtmlHeader =
                @"<html>
                    <head>
                        <META HTTP-EQUIV=""refresh"" CONTENT=""10""/>
                        <link rel=""stylesheet"" type =""text/css"" href =""leaderboard.css"" media =""screen"" />
                    </head>";
            const string HtmlStartOfBody = 
                @"<body>
                    <h1>
                        Leaderboard <img src=""logo.png"" align=""right"" height=""150"">
                    </h1>
                    <table style = ""width:100%"">";
            return HtmlHeader + HtmlStartOfBody;
        }

        private static string GetHtmlFooter()
        {
            return "</table></body></html>";
        }
    }
}