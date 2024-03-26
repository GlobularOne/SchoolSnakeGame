namespace SchoolSnakeGame
{
    partial class MenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.PlayerNameLabel = new System.Windows.Forms.Label();
            this.PlayerNameTextBox = new System.Windows.Forms.TextBox();
            this.DifficultyGroup = new System.Windows.Forms.GroupBox();
            this.MediumRadioButton = new System.Windows.Forms.RadioButton();
            this.HardRadioButton = new System.Windows.Forms.RadioButton();
            this.EasyRadioButton = new System.Windows.Forms.RadioButton();
            this.StartButton = new System.Windows.Forms.Button();
            this.TimerCheckBox = new System.Windows.Forms.CheckBox();
            this.PenaltyModeGroup = new System.Windows.Forms.GroupBox();
            this.LoseOneSecondRadioButton = new System.Windows.Forms.RadioButton();
            this.StopGameRadioButton = new System.Windows.Forms.RadioButton();
            this.LoseScoreRadioButton = new System.Windows.Forms.RadioButton();
            this.ReversedControlsCheckBox = new System.Windows.Forms.CheckBox();
            this.CreditsButton = new System.Windows.Forms.Button();
            this.SnakeHeadColorDialog = new System.Windows.Forms.ColorDialog();
            this.SnakeBodyColorDialog = new System.Windows.Forms.ColorDialog();
            this.FoodColorDialog = new System.Windows.Forms.ColorDialog();
            this.SnakeHeadButton = new System.Windows.Forms.Button();
            this.SnakeBodyButton = new System.Windows.Forms.Button();
            this.FoodButton = new System.Windows.Forms.Button();
            this.SnakeHeadPreview = new System.Windows.Forms.PictureBox();
            this.FoodPreview = new System.Windows.Forms.PictureBox();
            this.SnakeBodyPreview = new System.Windows.Forms.PictureBox();
            this.BackColorPreview = new System.Windows.Forms.PictureBox();
            this.BackColorButton = new System.Windows.Forms.Button();
            this.BackColorDialog = new System.Windows.Forms.ColorDialog();
            this.FoodCountNumeric = new System.Windows.Forms.NumericUpDown();
            this.food_count_label = new System.Windows.Forms.Label();
            this.DifficultyGroup.SuspendLayout();
            this.PenaltyModeGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SnakeHeadPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FoodPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SnakeBodyPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackColorPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FoodCountNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayerNameLabel
            // 
            resources.ApplyResources(this.PlayerNameLabel, "PlayerNameLabel");
            this.PlayerNameLabel.Name = "PlayerNameLabel";
            // 
            // PlayerNameTextBox
            // 
            this.PlayerNameTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            resources.ApplyResources(this.PlayerNameTextBox, "PlayerNameTextBox");
            this.PlayerNameTextBox.Name = "PlayerNameTextBox";
            this.PlayerNameTextBox.TextChanged += new System.EventHandler(this.PlayerNameTextBox_TextChanged);
            // 
            // DifficultyGroup
            // 
            this.DifficultyGroup.Controls.Add(this.MediumRadioButton);
            this.DifficultyGroup.Controls.Add(this.HardRadioButton);
            this.DifficultyGroup.Controls.Add(this.EasyRadioButton);
            resources.ApplyResources(this.DifficultyGroup, "DifficultyGroup");
            this.DifficultyGroup.Name = "DifficultyGroup";
            this.DifficultyGroup.TabStop = false;
            // 
            // MediumRadioButton
            // 
            resources.ApplyResources(this.MediumRadioButton, "MediumRadioButton");
            this.MediumRadioButton.Name = "MediumRadioButton";
            this.MediumRadioButton.UseVisualStyleBackColor = true;
            this.MediumRadioButton.CheckedChanged += new System.EventHandler(this.MediumRadioButton_CheckedChanged);
            // 
            // HardRadioButton
            // 
            resources.ApplyResources(this.HardRadioButton, "HardRadioButton");
            this.HardRadioButton.Name = "HardRadioButton";
            this.HardRadioButton.UseVisualStyleBackColor = true;
            this.HardRadioButton.CheckedChanged += new System.EventHandler(this.HardRadioButton_CheckedChanged);
            // 
            // EasyRadioButton
            // 
            resources.ApplyResources(this.EasyRadioButton, "EasyRadioButton");
            this.EasyRadioButton.Checked = true;
            this.EasyRadioButton.Name = "EasyRadioButton";
            this.EasyRadioButton.TabStop = true;
            this.EasyRadioButton.UseVisualStyleBackColor = true;
            this.EasyRadioButton.CheckedChanged += new System.EventHandler(this.EasyRadioButton_CheckedChanged);
            // 
            // StartButton
            // 
            resources.ApplyResources(this.StartButton, "StartButton");
            this.StartButton.Name = "StartButton";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // TimerCheckBox
            // 
            resources.ApplyResources(this.TimerCheckBox, "TimerCheckBox");
            this.TimerCheckBox.Name = "TimerCheckBox";
            this.TimerCheckBox.UseVisualStyleBackColor = true;
            this.TimerCheckBox.CheckedChanged += new System.EventHandler(this.TimerCheckBox_CheckedChanged);
            // 
            // PenaltyModeGroup
            // 
            this.PenaltyModeGroup.Controls.Add(this.LoseOneSecondRadioButton);
            this.PenaltyModeGroup.Controls.Add(this.StopGameRadioButton);
            this.PenaltyModeGroup.Controls.Add(this.LoseScoreRadioButton);
            resources.ApplyResources(this.PenaltyModeGroup, "PenaltyModeGroup");
            this.PenaltyModeGroup.Name = "PenaltyModeGroup";
            this.PenaltyModeGroup.TabStop = false;
            // 
            // LoseOneSecondRadioButton
            // 
            resources.ApplyResources(this.LoseOneSecondRadioButton, "LoseOneSecondRadioButton");
            this.LoseOneSecondRadioButton.Name = "LoseOneSecondRadioButton";
            this.LoseOneSecondRadioButton.UseVisualStyleBackColor = true;
            this.LoseOneSecondRadioButton.CheckedChanged += new System.EventHandler(this.LoseOneSecondRadioButton_CheckedChanged);
            // 
            // StopGameRadioButton
            // 
            resources.ApplyResources(this.StopGameRadioButton, "StopGameRadioButton");
            this.StopGameRadioButton.Checked = true;
            this.StopGameRadioButton.Name = "StopGameRadioButton";
            this.StopGameRadioButton.TabStop = true;
            this.StopGameRadioButton.UseVisualStyleBackColor = true;
            this.StopGameRadioButton.CheckedChanged += new System.EventHandler(this.StopGameRadioButton_CheckedChanged);
            // 
            // LoseScoreRadioButton
            // 
            resources.ApplyResources(this.LoseScoreRadioButton, "LoseScoreRadioButton");
            this.LoseScoreRadioButton.Name = "LoseScoreRadioButton";
            this.LoseScoreRadioButton.TabStop = true;
            this.LoseScoreRadioButton.UseVisualStyleBackColor = true;
            this.LoseScoreRadioButton.CheckedChanged += new System.EventHandler(this.LoseScoreRadioButton_CheckedChanged);
            // 
            // ReversedControlsCheckBox
            // 
            resources.ApplyResources(this.ReversedControlsCheckBox, "ReversedControlsCheckBox");
            this.ReversedControlsCheckBox.Name = "ReversedControlsCheckBox";
            this.ReversedControlsCheckBox.UseVisualStyleBackColor = true;
            // 
            // CreditsButton
            // 
            resources.ApplyResources(this.CreditsButton, "CreditsButton");
            this.CreditsButton.Name = "CreditsButton";
            this.CreditsButton.UseVisualStyleBackColor = true;
            this.CreditsButton.Click += new System.EventHandler(this.CreditsButton_Click);
            // 
            // SnakeHeadColorDialog
            // 
            this.SnakeHeadColorDialog.SolidColorOnly = true;
            // 
            // SnakeBodyColorDialog
            // 
            this.SnakeBodyColorDialog.Color = System.Drawing.Color.Green;
            this.SnakeBodyColorDialog.SolidColorOnly = true;
            // 
            // FoodColorDialog
            // 
            this.FoodColorDialog.Color = System.Drawing.Color.Red;
            this.FoodColorDialog.SolidColorOnly = true;
            // 
            // SnakeHeadButton
            // 
            resources.ApplyResources(this.SnakeHeadButton, "SnakeHeadButton");
            this.SnakeHeadButton.Name = "SnakeHeadButton";
            this.SnakeHeadButton.UseVisualStyleBackColor = true;
            this.SnakeHeadButton.Click += new System.EventHandler(this.SnakeHeadButton_Click);
            // 
            // SnakeBodyButton
            // 
            resources.ApplyResources(this.SnakeBodyButton, "SnakeBodyButton");
            this.SnakeBodyButton.Name = "SnakeBodyButton";
            this.SnakeBodyButton.UseVisualStyleBackColor = true;
            this.SnakeBodyButton.Click += new System.EventHandler(this.SnakeBodyButton_Click);
            // 
            // FoodButton
            // 
            resources.ApplyResources(this.FoodButton, "FoodButton");
            this.FoodButton.Name = "FoodButton";
            this.FoodButton.UseVisualStyleBackColor = true;
            this.FoodButton.Click += new System.EventHandler(this.FoodButton_Click);
            // 
            // SnakeHeadPreview
            // 
            this.SnakeHeadPreview.BackColor = System.Drawing.Color.Black;
            this.SnakeHeadPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.SnakeHeadPreview, "SnakeHeadPreview");
            this.SnakeHeadPreview.Name = "SnakeHeadPreview";
            this.SnakeHeadPreview.TabStop = false;
            this.SnakeHeadPreview.Click += new System.EventHandler(this.SnakeHeadButton_Click);
            // 
            // FoodPreview
            // 
            this.FoodPreview.BackColor = System.Drawing.Color.Red;
            this.FoodPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.FoodPreview, "FoodPreview");
            this.FoodPreview.Name = "FoodPreview";
            this.FoodPreview.TabStop = false;
            this.FoodPreview.Click += new System.EventHandler(this.FoodButton_Click);
            // 
            // SnakeBodyPreview
            // 
            this.SnakeBodyPreview.BackColor = System.Drawing.Color.Green;
            this.SnakeBodyPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.SnakeBodyPreview, "SnakeBodyPreview");
            this.SnakeBodyPreview.Name = "SnakeBodyPreview";
            this.SnakeBodyPreview.TabStop = false;
            this.SnakeBodyPreview.Click += new System.EventHandler(this.SnakeBodyButton_Click);
            // 
            // BackColorPreview
            // 
            this.BackColorPreview.BackColor = System.Drawing.SystemColors.Control;
            this.BackColorPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.BackColorPreview, "BackColorPreview");
            this.BackColorPreview.Name = "BackColorPreview";
            this.BackColorPreview.TabStop = false;
            this.BackColorPreview.Click += new System.EventHandler(this.BackColorButton_Click);
            // 
            // BackColorButton
            // 
            resources.ApplyResources(this.BackColorButton, "BackColorButton");
            this.BackColorButton.Name = "BackColorButton";
            this.BackColorButton.UseVisualStyleBackColor = true;
            this.BackColorButton.Click += new System.EventHandler(this.BackColorButton_Click);
            // 
            // BackColorDialog
            // 
            this.BackColorDialog.Color = System.Drawing.SystemColors.Control;
            this.BackColorDialog.SolidColorOnly = true;
            // 
            // FoodCountNumeric
            // 
            resources.ApplyResources(this.FoodCountNumeric, "FoodCountNumeric");
            this.FoodCountNumeric.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.FoodCountNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.FoodCountNumeric.Name = "FoodCountNumeric";
            this.FoodCountNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // food_count_label
            // 
            resources.ApplyResources(this.food_count_label, "food_count_label");
            this.food_count_label.Name = "food_count_label";
            // 
            // MenuForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.food_count_label);
            this.Controls.Add(this.FoodCountNumeric);
            this.Controls.Add(this.BackColorPreview);
            this.Controls.Add(this.BackColorButton);
            this.Controls.Add(this.SnakeBodyPreview);
            this.Controls.Add(this.FoodPreview);
            this.Controls.Add(this.SnakeHeadPreview);
            this.Controls.Add(this.FoodButton);
            this.Controls.Add(this.SnakeBodyButton);
            this.Controls.Add(this.SnakeHeadButton);
            this.Controls.Add(this.CreditsButton);
            this.Controls.Add(this.ReversedControlsCheckBox);
            this.Controls.Add(this.PenaltyModeGroup);
            this.Controls.Add(this.TimerCheckBox);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.DifficultyGroup);
            this.Controls.Add(this.PlayerNameTextBox);
            this.Controls.Add(this.PlayerNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MenuForm";
            this.DifficultyGroup.ResumeLayout(false);
            this.DifficultyGroup.PerformLayout();
            this.PenaltyModeGroup.ResumeLayout(false);
            this.PenaltyModeGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SnakeHeadPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FoodPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SnakeBodyPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackColorPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FoodCountNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PlayerNameLabel;
        private System.Windows.Forms.TextBox PlayerNameTextBox;
        private System.Windows.Forms.GroupBox DifficultyGroup;
        private System.Windows.Forms.RadioButton MediumRadioButton;
        private System.Windows.Forms.RadioButton HardRadioButton;
        private System.Windows.Forms.RadioButton EasyRadioButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.CheckBox TimerCheckBox;
        private System.Windows.Forms.GroupBox PenaltyModeGroup;
        private System.Windows.Forms.RadioButton LoseOneSecondRadioButton;
        private System.Windows.Forms.RadioButton StopGameRadioButton;
        private System.Windows.Forms.RadioButton LoseScoreRadioButton;
        private System.Windows.Forms.CheckBox ReversedControlsCheckBox;
        private System.Windows.Forms.Button CreditsButton;
        private System.Windows.Forms.ColorDialog SnakeHeadColorDialog;
        private System.Windows.Forms.ColorDialog SnakeBodyColorDialog;
        private System.Windows.Forms.ColorDialog FoodColorDialog;
        private System.Windows.Forms.Button SnakeHeadButton;
        private System.Windows.Forms.Button SnakeBodyButton;
        private System.Windows.Forms.Button FoodButton;
        private System.Windows.Forms.PictureBox SnakeHeadPreview;
        private System.Windows.Forms.PictureBox FoodPreview;
        private System.Windows.Forms.PictureBox SnakeBodyPreview;
        private System.Windows.Forms.PictureBox BackColorPreview;
        private System.Windows.Forms.Button BackColorButton;
        private System.Windows.Forms.ColorDialog BackColorDialog;
        private System.Windows.Forms.NumericUpDown FoodCountNumeric;
        private System.Windows.Forms.Label food_count_label;
    }
}

