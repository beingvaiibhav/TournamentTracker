namespace TrackerUI
{
    partial class CreateTournamentForm
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
            this.createTournament = new System.Windows.Forms.Label();
            this.tournamentName = new System.Windows.Forms.Label();
            this.tournamentNameValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.entryFeeValue = new System.Windows.Forms.TextBox();
            this.selectTeam = new System.Windows.Forms.Label();
            this.selectTeamDrop = new System.Windows.Forms.ComboBox();
            this.addTeam = new System.Windows.Forms.Button();
            this.createPrize = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tournamentPlayerListBox = new System.Windows.Forms.ListBox();
            this.deletePlayer = new System.Windows.Forms.Button();
            this.deletePrize = new System.Windows.Forms.Button();
            this.prizeListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createTournament
            // 
            this.createTournament.AutoSize = true;
            this.createTournament.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTournament.ForeColor = System.Drawing.SystemColors.Highlight;
            this.createTournament.Location = new System.Drawing.Point(26, 34);
            this.createTournament.Name = "createTournament";
            this.createTournament.Size = new System.Drawing.Size(361, 54);
            this.createTournament.TabIndex = 0;
            this.createTournament.Text = "Create Tournament";
            // 
            // tournamentName
            // 
            this.tournamentName.AutoSize = true;
            this.tournamentName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.tournamentName.Location = new System.Drawing.Point(28, 117);
            this.tournamentName.Name = "tournamentName";
            this.tournamentName.Size = new System.Drawing.Size(247, 38);
            this.tournamentName.TabIndex = 1;
            this.tournamentName.Text = "Tournament Name";
            // 
            // tournamentNameValue
            // 
            this.tournamentNameValue.Location = new System.Drawing.Point(35, 159);
            this.tournamentNameValue.Name = "tournamentNameValue";
            this.tournamentNameValue.Size = new System.Drawing.Size(324, 26);
            this.tournamentNameValue.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(28, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Entry Fee";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // entryFeeValue
            // 
            this.entryFeeValue.Location = new System.Drawing.Point(166, 215);
            this.entryFeeValue.Name = "entryFeeValue";
            this.entryFeeValue.Size = new System.Drawing.Size(100, 26);
            this.entryFeeValue.TabIndex = 4;
            // 
            // selectTeam
            // 
            this.selectTeam.AutoSize = true;
            this.selectTeam.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectTeam.ForeColor = System.Drawing.SystemColors.Highlight;
            this.selectTeam.Location = new System.Drawing.Point(28, 285);
            this.selectTeam.Name = "selectTeam";
            this.selectTeam.Size = new System.Drawing.Size(164, 38);
            this.selectTeam.TabIndex = 5;
            this.selectTeam.Text = "Select Team";
            // 
            // selectTeamDrop
            // 
            this.selectTeamDrop.FormattingEnabled = true;
            this.selectTeamDrop.Location = new System.Drawing.Point(35, 336);
            this.selectTeamDrop.Name = "selectTeamDrop";
            this.selectTeamDrop.Size = new System.Drawing.Size(324, 28);
            this.selectTeamDrop.TabIndex = 6;
            // 
            // addTeam
            // 
            this.addTeam.Location = new System.Drawing.Point(137, 396);
            this.addTeam.Name = "addTeam";
            this.addTeam.Size = new System.Drawing.Size(129, 51);
            this.addTeam.TabIndex = 7;
            this.addTeam.Text = "Add Team";
            this.addTeam.UseVisualStyleBackColor = true;
            // 
            // createPrize
            // 
            this.createPrize.Location = new System.Drawing.Point(137, 477);
            this.createPrize.Name = "createPrize";
            this.createPrize.Size = new System.Drawing.Size(129, 51);
            this.createPrize.TabIndex = 8;
            this.createPrize.Text = "Create Prize";
            this.createPrize.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(452, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 38);
            this.label2.TabIndex = 9;
            this.label2.Text = "Teams / Players";
            // 
            // tournamentPlayerListBox
            // 
            this.tournamentPlayerListBox.FormattingEnabled = true;
            this.tournamentPlayerListBox.ItemHeight = 20;
            this.tournamentPlayerListBox.Location = new System.Drawing.Point(459, 98);
            this.tournamentPlayerListBox.Name = "tournamentPlayerListBox";
            this.tournamentPlayerListBox.Size = new System.Drawing.Size(373, 164);
            this.tournamentPlayerListBox.TabIndex = 10;
            // 
            // deletePlayer
            // 
            this.deletePlayer.Location = new System.Drawing.Point(876, 138);
            this.deletePlayer.Name = "deletePlayer";
            this.deletePlayer.Size = new System.Drawing.Size(129, 51);
            this.deletePlayer.TabIndex = 11;
            this.deletePlayer.Text = "Delete Selected";
            this.deletePlayer.UseVisualStyleBackColor = true;
            // 
            // deletePrize
            // 
            this.deletePrize.Location = new System.Drawing.Point(876, 400);
            this.deletePrize.Name = "deletePrize";
            this.deletePrize.Size = new System.Drawing.Size(129, 51);
            this.deletePrize.TabIndex = 14;
            this.deletePrize.Text = "Delete Selected";
            this.deletePrize.UseVisualStyleBackColor = true;
            // 
            // prizeListBox
            // 
            this.prizeListBox.FormattingEnabled = true;
            this.prizeListBox.ItemHeight = 20;
            this.prizeListBox.Location = new System.Drawing.Point(459, 360);
            this.prizeListBox.Name = "prizeListBox";
            this.prizeListBox.Size = new System.Drawing.Size(373, 164);
            this.prizeListBox.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(452, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 38);
            this.label3.TabIndex = 12;
            this.label3.Text = "Teams / Players";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(349, 559);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(252, 64);
            this.button1.TabIndex = 15;
            this.button1.Text = "Create Tournament";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 653);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.deletePrize);
            this.Controls.Add(this.prizeListBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.deletePlayer);
            this.Controls.Add(this.tournamentPlayerListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.createPrize);
            this.Controls.Add(this.addTeam);
            this.Controls.Add(this.selectTeamDrop);
            this.Controls.Add(this.selectTeam);
            this.Controls.Add(this.entryFeeValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tournamentNameValue);
            this.Controls.Add(this.tournamentName);
            this.Controls.Add(this.createTournament);
            this.Name = "CreateTournamentForm";
            this.Text = "CreateTournamentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label createTournament;
        private System.Windows.Forms.Label tournamentName;
        private System.Windows.Forms.TextBox tournamentNameValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox entryFeeValue;
        private System.Windows.Forms.Label selectTeam;
        private System.Windows.Forms.ComboBox selectTeamDrop;
        private System.Windows.Forms.Button addTeam;
        private System.Windows.Forms.Button createPrize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox tournamentPlayerListBox;
        private System.Windows.Forms.Button deletePlayer;
        private System.Windows.Forms.Button deletePrize;
        private System.Windows.Forms.ListBox prizeListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}