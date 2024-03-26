using System;
using System.Drawing;

namespace SchoolSnakeGame
{
    using Direction = Directions;
    using PenaltyMode = PenaltyModes;
    public enum Directions
    {
        Left,
        Right,
        Up,
        Down
    };
    public enum PenaltyModes
    {
        LoseGame,
        LoseScore,
        LoseTime
    };
    public class Instance : ICloneable
    {
        public int Difficulty
        {
            get; set;
        }
        public int FoodCount
        {
            get; set;
        }
        public string PlayerName
        {
            get; set;
        }
        public int Width
        {
            get; set;
        }
        public int Height
        {
            get; set;
        }
        public int Speed
        {
            get; set;
        }
        public int Score
        {
            get; set;
        }
        public bool TimerEnabled
        {
            get; set;
        }
        public bool ReversedControls
        {
            get; set;
        }
        public bool GameFinished
        {
            get; set;
        }
        public Direction MoveDirection
        {
            get; set;
        }
        public PenaltyMode ChosenPenaltyMode
        {
            get; set;
        }
        public int TicksLeft
        {
            get; set;
        }
        public Brush SnakeHeadColor
        {
            get; set;
        }
        public Brush SnakeBodyColor
        {
            get; set;
        }
        public Brush FoodColor
        {
            get; set;
        }
        public Color BackColor
        {
            get; set;
        }
        public Instance Clone()
        {
            return (Instance)this.MemberwiseClone();
        }
        object ICloneable.Clone()
        {
            return Clone();
        }
    }
}
