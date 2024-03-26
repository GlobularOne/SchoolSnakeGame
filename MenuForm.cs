using System;
using System.Drawing;
#if DEBUG
using System.Runtime.InteropServices;
#endif
using System.Windows.Forms;

namespace SchoolSnakeGame
{
    public partial class MenuForm : Form
    {
#if DEBUG
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();
#endif
        private int Difficulty = 1;
        private PenaltyModes PenaltyMode = PenaltyModes.LoseGame;
        public MenuForm()
        {
#if DEBUG
            AllocConsole();
#endif
            Console.Error.WriteLine("[NOTE] Launcher started");
            InitializeComponent();
        }

        private void TimerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.TimerCheckBox.Checked)
            {
                // Allow checking lose 1 second in penalty mode group
                LoseOneSecondRadioButton.Enabled = true;
            }
            else
            {
                if (LoseOneSecondRadioButton.Checked)
                {
                    Console.Error.WriteLine("[IMPORTANT] Overriding user decision: Checking StopGameRadioButton as timer is disabled");
                    // This choice is no longer valid, fallback to stop game
                    StopGameRadioButton.Checked = true;
                }
                // Uncheck and disable it
                LoseOneSecondRadioButton.Checked = false;
                LoseOneSecondRadioButton.Enabled = false;

            }
        }

        private void PlayerNameTextBox_TextChanged(object sender, EventArgs e)
        {
            // 3 is a fair limit
            StartButton.Enabled = PlayerNameTextBox.Text.Length >= 3;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            // Create the default instance so the game knows what to default to
            Instance DefaultInstance = new Instance
            {
                Difficulty = Difficulty,
                FoodCount = (int)FoodCountNumeric.Value,
                PlayerName = PlayerNameTextBox.Text,
                Height = 16,
                Width = 16,
                // Later, GameForm puts the timer's interval to 1000 / Speed.
                // So the more, the faster the game is (which clearly makes it harder)
                Speed = 10 + Difficulty * 5,
                Score = 0,
                TimerEnabled = TimerCheckBox.Checked,
                ReversedControls = ReversedControlsCheckBox.Checked,
                GameFinished = false,
                MoveDirection = Directions.Down,
                ChosenPenaltyMode = PenaltyMode,
                TicksLeft = 70,
                SnakeHeadColor = new SolidBrush(SnakeHeadColorDialog.Color),
                SnakeBodyColor = new SolidBrush(SnakeBodyColorDialog.Color),
                FoodColor = new SolidBrush(FoodColorDialog.Color),
                BackColor = BackColorDialog.Color
            };
            Console.Error.WriteLine("[IMPORTANT] Starting game instance with settings:");
            Console.Error.WriteLine("[IMPORTANT]     Difficulty: {0}", DefaultInstance.Difficulty);
            Console.Error.WriteLine("[IMPORTANT]     FoodCount: {0}", DefaultInstance.FoodCount);
            Console.Error.WriteLine("[IMPORTANT]     PlayerName: {0}", DefaultInstance.PlayerName);
            Console.Error.WriteLine("[IMPORTANT]     Height: {0}", DefaultInstance.Height);
            Console.Error.WriteLine("[IMPORTANT]     Width: {0}", DefaultInstance.Width);
            Console.Error.WriteLine("[IMPORTANT]     Speed: {0}", DefaultInstance.Speed);
            Console.Error.WriteLine("[IMPORTANT]     Score: {0}", DefaultInstance.Score);
            Console.Error.WriteLine("[IMPORTANT]     TimerEnabled: {0}", DefaultInstance.TimerEnabled);
            Console.Error.WriteLine("[IMPORTANT]     ReversedControls: {0}", DefaultInstance.ReversedControls);
            Console.Error.WriteLine("[IMPORTANT]     GameFinished: {0}", DefaultInstance.GameFinished);
            Console.Error.WriteLine("[IMPORTANT]     MoveDirection: {0}", DefaultInstance.MoveDirection);
            Console.Error.WriteLine("[IMPORTANT]     ChosenPenaltyMode: {0}", DefaultInstance.ChosenPenaltyMode);
            Console.Error.WriteLine("[IMPORTANT]     TicksLeft: {0}", DefaultInstance.TicksLeft);
            Console.Error.WriteLine("[IMPORTANT]     SnakeHeadColor: {0}", SnakeHeadColorDialog.Color);
            Console.Error.WriteLine("[IMPORTANT]     SnakeBodyColor: {0}", SnakeBodyColorDialog.Color);
            Console.Error.WriteLine("[IMPORTANT]     FoodColor: {0}", FoodColorDialog.Color);
            Console.Error.WriteLine("[IMPORTANT]     BackColor: {0}", BackColorDialog.Color);
            MainForm GameForm = new MainForm(DefaultInstance);
            GameForm.Show();
        }

        private void EasyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (EasyRadioButton.Checked)
            {
                Difficulty = 1;
            }
        }

        private void MediumRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (MediumRadioButton.Checked)
            {
                Difficulty = 2;
            }
        }

        private void HardRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (HardRadioButton.Checked)
            {
                Difficulty = 3;
            }
        }

        private void LoseScoreRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (LoseScoreRadioButton.Checked)
            {
                PenaltyMode = PenaltyModes.LoseScore;
            }
        }

        private void LoseOneSecondRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (LoseOneSecondRadioButton.Checked)
            {
                PenaltyMode = PenaltyModes.LoseTime;
            }
        }

        private void StopGameRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (StopGameRadioButton.Checked)
            {
                PenaltyMode = PenaltyModes.LoseGame;
            }
        }

        private void CreditsButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Development and design: Kamyar Hatamnezhad\nSound effects: SoundSnap (Format conversion using freeconvert.com)", "Credits");
        }
        private void CheckColors()
        {
            if (BackColorDialog.Color == SnakeHeadColorDialog.Color ||
                BackColorDialog.Color == SnakeBodyColorDialog.Color ||
                BackColorDialog.Color == FoodColorDialog.Color)
            {
                Console.Error.WriteLine("[WARNING] CheckColors(): Invalid color settings, blocking access to game");
                // The player wouldn't be able to see some things
                StartButton.Enabled = false;
            }
            else
            {
                StartButton.Enabled = true;
            }
        }
        private void SnakeHeadButton_Click(object sender, EventArgs e)
        {
            SnakeHeadColorDialog.ShowDialog();
            SnakeHeadPreview.BackColor = SnakeHeadColorDialog.Color;
            Console.Error.WriteLine("[NOTE] New snake head color: {0}", SnakeHeadColorDialog.Color);
            CheckColors();
        }

        private void SnakeBodyButton_Click(object sender, EventArgs e)
        {
            SnakeBodyColorDialog.ShowDialog();
            SnakeBodyPreview.BackColor = SnakeBodyColorDialog.Color;
            Console.Error.WriteLine("[NOTE] New snake body color: {0}", SnakeBodyColorDialog.Color);
            CheckColors();

        }

        private void FoodButton_Click(object sender, EventArgs e)
        {
            FoodColorDialog.ShowDialog();
            FoodPreview.BackColor = FoodColorDialog.Color;
            Console.Error.WriteLine("[NOTE] New food color: {0}", FoodColorDialog.Color);
            CheckColors();
        }

        private void BackColorButton_Click(object sender, EventArgs e)
        {
            BackColorDialog.ShowDialog();
            BackColorPreview.BackColor = BackColorDialog.Color;
            Console.Error.WriteLine("[NOTE] New background color: {0}", BackColorDialog.Color);
            CheckColors();
        }
    }
}
