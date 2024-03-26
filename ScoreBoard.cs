using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SchoolSnakeGame
{
    public partial class ScoreBoard : Form
    {
        public ScoreBoard()
        {
            InitializeComponent();
            
        }
    }
    public class ScoreBoardManager
    {
        private SortedList<int, string> Records = new SortedList<int, string>(10);
        public void AddScore(string Name, int Score)
        {
            try
            {
                Records.Add(Score, Name);
            }
            catch (ArgumentException)
            {
                // Duplicate entry, never mind it
            }
        }
        public void InvalidateScores()
        {
            Records.Clear();
        }
        public void ShowScores(IWin32Window parent)
        {
            ScoreBoard CurrentScoreBoard = new ScoreBoard();
            List<Label> Labels = new List<Label>
            {
                CurrentScoreBoard.Place1th, CurrentScoreBoard.Place2th, CurrentScoreBoard.Place3th,
                CurrentScoreBoard.Place4th, CurrentScoreBoard.Place5th, CurrentScoreBoard.Place6th,
                CurrentScoreBoard.Place7th, CurrentScoreBoard.Place8th, CurrentScoreBoard.Place9th,
                CurrentScoreBoard.Place10th
            };
            List<Label> ScoreLabels = new List<Label>
            {
                CurrentScoreBoard.Score1, CurrentScoreBoard.Score2, CurrentScoreBoard.Score3,
                CurrentScoreBoard.Score4, CurrentScoreBoard.Score5, CurrentScoreBoard.Score6,
                CurrentScoreBoard.Score7, CurrentScoreBoard.Score8, CurrentScoreBoard.Score9,
                CurrentScoreBoard.Score10
            };
            int i;
            // Reset the labels
            for (i = 0; i < 10; i++)
            {
                Labels[i].Text = "-";
                ScoreLabels[i].Text = "0";
            }
            int IterMax = Records.Count < 10 ? Records.Count - 1: 9;
            int j = 0;
            for (i = IterMax; i >= 0; i--)
            {
                Labels[j].Text = Records.Values[i];
                ScoreLabels[j].Text = Records.Keys[i].ToString();
                j++;
            }
            CurrentScoreBoard.Show(parent);
        }
    }
}
