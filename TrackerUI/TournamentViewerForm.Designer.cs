namespace TrackerUI
{
    partial class TournamentViewerForm
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
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.tournamentName = new System.Windows.Forms.Label();
            this.roundLabel = new System.Windows.Forms.Label();
            this.roundDropDown = new System.Windows.Forms.ComboBox();
            this.unplayedRound = new System.Windows.Forms.CheckBox();
            this.matchupListBox = new System.Windows.Forms.ListBox();
            this.teamOneName = new System.Windows.Forms.Label();
            this.teamOneScore = new System.Windows.Forms.Label();
            this.teamOneScoreValue = new System.Windows.Forms.TextBox();
            this.teamTwoName = new System.Windows.Forms.Label();
            this.teamTwoScore = new System.Windows.Forms.Label();
            this.teamTwoScoreValue = new System.Windows.Forms.TextBox();
            this.vs = new System.Windows.Forms.Label();
            this.score = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Segoe UI Light", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLabel.ForeColor = System.Drawing.Color.Fuchsia;
            this.HeaderLabel.Location = new System.Drawing.Point(12, 9);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(322, 74);
            this.HeaderLabel.TabIndex = 0;
            this.HeaderLabel.Text = "Tournament:";
            // 
            // tournamentName
            // 
            this.tournamentName.AutoSize = true;
            this.tournamentName.Font = new System.Drawing.Font("Segoe UI Light", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentName.ForeColor = System.Drawing.Color.Fuchsia;
            this.tournamentName.Location = new System.Drawing.Point(298, 9);
            this.tournamentName.Name = "tournamentName";
            this.tournamentName.Size = new System.Drawing.Size(223, 74);
            this.tournamentName.TabIndex = 1;
            this.tournamentName.Text = "<none>";
            // 
            // roundLabel
            // 
            this.roundLabel.AutoSize = true;
            this.roundLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.roundLabel.Location = new System.Drawing.Point(25, 125);
            this.roundLabel.Name = "roundLabel";
            this.roundLabel.Size = new System.Drawing.Size(83, 32);
            this.roundLabel.TabIndex = 2;
            this.roundLabel.Text = "Round";
            // 
            // roundDropDown
            // 
            this.roundDropDown.FormattingEnabled = true;
            this.roundDropDown.ItemHeight = 45;
            this.roundDropDown.Location = new System.Drawing.Point(114, 117);
            this.roundDropDown.Name = "roundDropDown";
            this.roundDropDown.Size = new System.Drawing.Size(371, 53);
            this.roundDropDown.TabIndex = 3;
            // 
            // unplayedRound
            // 
            this.unplayedRound.AutoSize = true;
            this.unplayedRound.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unplayedRound.ForeColor = System.Drawing.SystemColors.Highlight;
            this.unplayedRound.Location = new System.Drawing.Point(114, 186);
            this.unplayedRound.Name = "unplayedRound";
            this.unplayedRound.Size = new System.Drawing.Size(198, 36);
            this.unplayedRound.TabIndex = 4;
            this.unplayedRound.Text = "Unplayed Only";
            this.unplayedRound.UseVisualStyleBackColor = true;
            // 
            // matchupListBox
            // 
            this.matchupListBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matchupListBox.FormattingEnabled = true;
            this.matchupListBox.ItemHeight = 28;
            this.matchupListBox.Location = new System.Drawing.Point(114, 248);
            this.matchupListBox.Name = "matchupListBox";
            this.matchupListBox.Size = new System.Drawing.Size(371, 256);
            this.matchupListBox.TabIndex = 5;
            // 
            // teamOneName
            // 
            this.teamOneName.AutoSize = true;
            this.teamOneName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamOneName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.teamOneName.Location = new System.Drawing.Point(572, 211);
            this.teamOneName.Name = "teamOneName";
            this.teamOneName.Size = new System.Drawing.Size(148, 32);
            this.teamOneName.TabIndex = 6;
            this.teamOneName.Text = "<team one>";
            // 
            // teamOneScore
            // 
            this.teamOneScore.AutoSize = true;
            this.teamOneScore.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamOneScore.ForeColor = System.Drawing.SystemColors.Highlight;
            this.teamOneScore.Location = new System.Drawing.Point(572, 280);
            this.teamOneScore.Name = "teamOneScore";
            this.teamOneScore.Size = new System.Drawing.Size(73, 32);
            this.teamOneScore.TabIndex = 7;
            this.teamOneScore.Text = "Score";
            this.teamOneScore.Click += new System.EventHandler(this.label1_Click);
            // 
            // teamOneScoreValue
            // 
            this.teamOneScoreValue.Location = new System.Drawing.Point(651, 267);
            this.teamOneScoreValue.Name = "teamOneScoreValue";
            this.teamOneScoreValue.Size = new System.Drawing.Size(100, 50);
            this.teamOneScoreValue.TabIndex = 8;
            // 
            // teamTwoName
            // 
            this.teamTwoName.AutoSize = true;
            this.teamTwoName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamTwoName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.teamTwoName.Location = new System.Drawing.Point(584, 393);
            this.teamTwoName.Name = "teamTwoName";
            this.teamTwoName.Size = new System.Drawing.Size(146, 32);
            this.teamTwoName.TabIndex = 6;
            this.teamTwoName.Text = "<team two>";
            // 
            // teamTwoScore
            // 
            this.teamTwoScore.AutoSize = true;
            this.teamTwoScore.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamTwoScore.ForeColor = System.Drawing.SystemColors.Highlight;
            this.teamTwoScore.Location = new System.Drawing.Point(584, 462);
            this.teamTwoScore.Name = "teamTwoScore";
            this.teamTwoScore.Size = new System.Drawing.Size(73, 32);
            this.teamTwoScore.TabIndex = 7;
            this.teamTwoScore.Text = "Score";
            this.teamTwoScore.Click += new System.EventHandler(this.label1_Click);
            // 
            // teamTwoScoreValue
            // 
            this.teamTwoScoreValue.Location = new System.Drawing.Point(663, 449);
            this.teamTwoScoreValue.Name = "teamTwoScoreValue";
            this.teamTwoScoreValue.Size = new System.Drawing.Size(100, 50);
            this.teamTwoScoreValue.TabIndex = 8;
            // 
            // vs
            // 
            this.vs.AutoSize = true;
            this.vs.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vs.ForeColor = System.Drawing.SystemColors.Highlight;
            this.vs.Location = new System.Drawing.Point(655, 337);
            this.vs.Name = "vs";
            this.vs.Size = new System.Drawing.Size(83, 45);
            this.vs.TabIndex = 9;
            this.vs.Text = "-VS-";
            // 
            // score
            // 
            this.score.BackColor = System.Drawing.Color.LightGray;
            this.score.Location = new System.Drawing.Point(817, 326);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(138, 67);
            this.score.TabIndex = 10;
            this.score.Text = "Score";
            this.score.UseVisualStyleBackColor = false;
            // 
            // TournamentViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1033, 564);
            this.Controls.Add(this.score);
            this.Controls.Add(this.vs);
            this.Controls.Add(this.teamTwoScoreValue);
            this.Controls.Add(this.teamTwoScore);
            this.Controls.Add(this.teamOneScoreValue);
            this.Controls.Add(this.teamTwoName);
            this.Controls.Add(this.teamOneScore);
            this.Controls.Add(this.teamOneName);
            this.Controls.Add(this.matchupListBox);
            this.Controls.Add(this.unplayedRound);
            this.Controls.Add(this.roundDropDown);
            this.Controls.Add(this.roundLabel);
            this.Controls.Add(this.tournamentName);
            this.Controls.Add(this.HeaderLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "TournamentViewerForm";
            this.Text = "Tournament Viewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Label tournamentName;
        private System.Windows.Forms.Label roundLabel;
        private System.Windows.Forms.ComboBox roundDropDown;
        private System.Windows.Forms.CheckBox unplayedRound;
        private System.Windows.Forms.ListBox matchupListBox;
        private System.Windows.Forms.Label teamOneName;
        private System.Windows.Forms.Label teamOneScore;
        private System.Windows.Forms.TextBox teamOneScoreValue;
        private System.Windows.Forms.Label teamTwoName;
        private System.Windows.Forms.Label teamTwoScore;
        private System.Windows.Forms.TextBox teamTwoScoreValue;
        private System.Windows.Forms.Label vs;
        private System.Windows.Forms.Button score;
    }
}

