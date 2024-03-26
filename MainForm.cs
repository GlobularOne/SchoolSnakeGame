using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;


namespace SchoolSnakeGame
{
    public partial class MainForm : Form
    {
        // Body parts of the snake
        private readonly List<Point> BodyParts = new List<Point>();
        // Position of food
        private readonly List<Point> FoodPoints = new List<Point>();
        // Default instance to default to
        private readonly Instance DefaultInstance;
        // Current instance of the game
        private Instance CurrentInstance;
        // Random generator, used for generating food
        private readonly Random RandomGen = new Random();
        // Table of keys pressed
        private readonly Hashtable KeyTable = new Hashtable();
        // The current game's scoreboard
        private readonly ScoreBoardManager CurrentScoreBoard = new ScoreBoardManager();
        // Whatever scoresboard is shown or not
        private bool ScoresShown = false;

        public MainForm(Instance DefaultInstance)
        {
            InitializeComponent();
            CurrentInstance = DefaultInstance.Clone();
            this.DefaultInstance = DefaultInstance;
            GameCanvas.BackColor = DefaultInstance.BackColor;
            StartGame();
        }
        // Returns whatever key is pressed or not
        public bool IsKeyPressed(Keys key)
        {
            return this.KeyTable[key] != null && (bool)this.KeyTable[key];
        }
        // Changes the key state
        public void ChangeKeyState(Keys key, bool state)
        {
            this.KeyTable[key] = state;
        }

        private void RenderTimer_Tick(object sender, EventArgs e)
        {
            if (CurrentInstance.GameFinished)
            {
                if (IsKeyPressed(Keys.Enter))
                {
                    StartGame();
                }
            }
            else
            {
                if (IsKeyPressed(Keys.Right) && CurrentInstance.MoveDirection != Directions.Left)
                {
                    CurrentInstance.MoveDirection = Directions.Right;
                }
                else if (IsKeyPressed(Keys.Left) && CurrentInstance.MoveDirection != Directions.Right)
                {
                    CurrentInstance.MoveDirection = Directions.Left;
                }
                else if (IsKeyPressed(Keys.Up) && CurrentInstance.MoveDirection != Directions.Down)
                {
                    CurrentInstance.MoveDirection = Directions.Up;
                }
                else if (IsKeyPressed(Keys.Down) && CurrentInstance.MoveDirection != Directions.Up)
                {
                    CurrentInstance.MoveDirection = Directions.Down;
                }
                for (int i = BodyParts.Count - 1; i >= 0; i--)
                {
                    if (i == 0)
                    {
                        switch (CurrentInstance.MoveDirection)
                        {
                            case Directions.Right:
                                BodyParts[i] = new Point { X = BodyParts[i].X + 1, Y = BodyParts[i].Y };
                                break;
                            case Directions.Left:
                                BodyParts[i] = new Point { X = BodyParts[i].X - 1, Y = BodyParts[i].Y };
                                break;
                            case Directions.Up:
                                BodyParts[i] = new Point { X = BodyParts[i].X, Y = BodyParts[i].Y - 1 };
                                break;
                            case Directions.Down:
                                BodyParts[i] = new Point { X = BodyParts[i].X, Y = BodyParts[i].Y + 1 };
                                break;
                        }
                        int MaxPosX = GameCanvas.Size.Width / CurrentInstance.Width;
                        int MaxPosY = GameCanvas.Size.Height / CurrentInstance.Height;

                        if (
                            BodyParts[i].X < 0 || BodyParts[i].Y < 0 ||
                            BodyParts[i].X >= MaxPosX || BodyParts[i].Y >= MaxPosY
                            )
                        {
                            Penalty();
                        }
                        for (int j = 1; j < BodyParts.Count; j++)
                        {
                            if (BodyParts[i].X == BodyParts[j].X && BodyParts[i].Y == BodyParts[j].Y)
                            {

                                Penalty();
                            }
                        }
                        foreach (Point Food in FoodPoints)
                        {
                            if (BodyParts[0].X == Food.X && BodyParts[0].Y == Food.Y)
                            {
                                EatFood(Food);
                                break;
                            }
                        }

                    }
                    else
                    {
                        BodyParts[i] = new Point { X = BodyParts[i - 1].X, Y = BodyParts[i - 1].Y };
                    }
                }
            }

            GameCanvas.Invalidate();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            Keys Key = e.KeyCode;
            if (CurrentInstance.ReversedControls)
            {
                switch (e.KeyCode)
                {
                    case Keys.Down:
                        Key = Keys.Up;
                        break;
                    case Keys.Up:
                        Key = Keys.Down;
                        break;
                    case Keys.Left:
                        Key = Keys.Right;
                        break;
                    case Keys.Right:
                        Key = Keys.Left;
                        break;
                }
            }
            ChangeKeyState(Key, true);
        }

        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            Keys Key = e.KeyCode;
            if (CurrentInstance.ReversedControls)
            {
                switch (e.KeyCode)
                {
                    case Keys.Down:
                        Key = Keys.Up;
                        break;
                    case Keys.Up:
                        Key = Keys.Down;
                        break;
                    case Keys.Left:
                        Key = Keys.Right;
                        break;
                    case Keys.Right:
                        Key = Keys.Left;
                        break;
                }
            }
            ChangeKeyState(Key, false);
        }

        private void GameCanvas_Paint(object sender, PaintEventArgs e)
        {
            if (!CurrentInstance.GameFinished)
            {
                // Render the head out of the loop to avoid having an if statement in the for loop
                e.Graphics.FillEllipse(CurrentInstance.SnakeHeadColor,
                                    new Rectangle(
                                        BodyParts[0].X * CurrentInstance.Width,
                                        BodyParts[0].Y * CurrentInstance.Height,
                                        CurrentInstance.Width, CurrentInstance.Height
                                        ));
                for (int i = 1; i < BodyParts.Count; i++)
                {
                    e.Graphics.FillEllipse(CurrentInstance.SnakeBodyColor,
                                        new Rectangle(
                                            BodyParts[i].X * CurrentInstance.Width,
                                            BodyParts[i].Y * CurrentInstance.Height,
                                            CurrentInstance.Width, CurrentInstance.Height
                                            ));
                }
                foreach (Point Food in FoodPoints)
                {
                    // Now paint the foods
                    e.Graphics.FillEllipse(CurrentInstance.FoodColor,
                                        new Rectangle(
                                            Food.X * CurrentInstance.Width,
                                            Food.Y * CurrentInstance.Height,
                                            CurrentInstance.Width, CurrentInstance.Height
                                            ));
                }
            }
        }

        private void StartGame()
        {
            RenderTimer.Interval = 1000 / CurrentInstance.Speed;
            ScoresShown = false;
            Console.Error.WriteLine("[NOTE] Starting game (Render loop interval: {0})", RenderTimer.Interval);
            RenderTimer.Start();
            ScoreLabel.Text = "0";
            if (CurrentInstance.TimerEnabled)
            {
                TimeLabel.Text = "0";
                GameTimer.Enabled = true;
            }
            else
            {
                TimeLabel.Visible = false;
            }
            CurrentInstance = DefaultInstance.Clone();
            BodyParts.Clear();
            BodyParts.Add(new Point { X = 10, Y = 5 });
            ScoreLabel.Text = CurrentInstance.Score.ToString();
            FillFood();

        }

        private void Shake(int amplitude, int amount)
        {
            Point OriginalLocation = Location;
            // Do not use RandomGen for obvious reasons
            Random Rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                Location = new Point
                {
                    X = OriginalLocation.X + Rnd.Next(-amplitude, amplitude),
                    Y = OriginalLocation.Y + Rnd.Next(-amplitude, amplitude)
                };
                Thread.Sleep(amount / 10);
            }
            Location = OriginalLocation;
        }
        private void FillFood()
        {
            for (int i = FoodPoints.Count; i < CurrentInstance.FoodCount; i++)
            {

                Point Food = new Point
                {
                    // Use one as the min value and subtract one from the max value so no food will be generated
                    // exactly at the borders
                    X = RandomGen.Next(1, (GameCanvas.Size.Width / CurrentInstance.Width) - 1),
                    Y = RandomGen.Next(1, (GameCanvas.Size.Height / CurrentInstance.Height) - 1)
                };
                FoodPoints.Add(Food);
            }
        }

        private void EatFood(Point Food)
        {
            FoodPoints.Remove(Food);
            BodyParts.Add(new Point
            {
                X = BodyParts[BodyParts.Count - 1].X,
                Y = BodyParts[BodyParts.Count - 1].Y

            });
            CurrentInstance.Score += 100;
            if (CurrentInstance.TimerEnabled)
            {
                GameTimer.Enabled = false;
                CurrentInstance.TicksLeft += 15 / CurrentInstance.Difficulty;
                TimeLabel.Text = CurrentInstance.TicksLeft.ToString();
                // Re-enable it
                GameTimer.Enabled = true;

            }
            ScoreLabel.Text = CurrentInstance.Score.ToString();
            FillFood();
        }
        private void LoseTime(int amount)
        {
            // To avoid race conditions, disable the timer first
            GameTimer.Enabled = false;
            CurrentInstance.TicksLeft -= amount;
            TimeLabel.Text = CurrentInstance.TicksLeft.ToString();
            if (CurrentInstance.TicksLeft <= 0)
            {
                GameTimer.Stop();
                TimeLabel.Text = "0";
                CurrentInstance.GameFinished = true;
                if (CurrentInstance.ChosenPenaltyMode != PenaltyModes.LoseScore && !ScoresShown)
                {
                    CurrentScoreBoard.AddScore(CurrentInstance.PlayerName, CurrentInstance.Score);
                    CurrentScoreBoard.ShowScores(this);
                    ScoresShown = true;
                }
            }
            else
            {
                TimeLabel.Text = CurrentInstance.TicksLeft.ToString();
            }
            // Re-enable it
            GameTimer.Enabled = true;

        }
        private void Penalty()
        {
            if (CurrentInstance.ChosenPenaltyMode == PenaltyModes.LoseScore)
            {
                if (CurrentInstance.Score > 0)
                {
                    CurrentInstance.Score -= 100;
                    BodyParts.Remove(BodyParts.First());
                }
                ScoreLabel.Text = CurrentInstance.Score.ToString();
            }
            else if (CurrentInstance.ChosenPenaltyMode == PenaltyModes.LoseTime)
            {

                LoseTime(5);
            }
            if (CurrentInstance.ChosenPenaltyMode == PenaltyModes.LoseGame || CurrentInstance.Score <= 0)
            {
                CurrentInstance.GameFinished = true;
                if (CurrentInstance.TimerEnabled)
                {
                    GameTimer.Enabled = false;
                }
                Shake(10, 70);
                if (CurrentInstance.ChosenPenaltyMode != PenaltyModes.LoseScore && !ScoresShown)
                {
                    CurrentScoreBoard.AddScore(CurrentInstance.PlayerName, CurrentInstance.Score);
                    CurrentScoreBoard.ShowScores(this);
                    ScoresShown = true;
                }
            }
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            LoseTime(1);
        }
    }
}
