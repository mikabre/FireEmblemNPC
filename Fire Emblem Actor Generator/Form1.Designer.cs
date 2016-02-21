namespace Fire_Emblem_Actor_Generator
{
    partial class Form1
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
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.cmbJob = new System.Windows.Forms.ComboBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.cmbLevel = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(12, 80);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(262, 244);
            this.txtOutput.TabIndex = 0;
            // 
            // cmbJob
            // 
            this.cmbJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbJob.FormattingEnabled = true;
            this.cmbJob.Items.AddRange(new object[] {
            "Archer",
            "Assassin",
            "Avenger",
            "Barbarian",
            "Berserker",
            "Bishop",
            "Cavalier",
            "Cleric",
            "Drifter",
            "Falcoknight",
            "Fighter",
            "General",
            "Great Knight",
            "Griffon Rider",
            "Hero",
            "Hunter",
            "Journeyman",
            "Knight",
            "Lancer",
            "Mage",
            "Mage Knight",
            "Magus",
            "Mercenary",
            "Myrmidon",
            "Nomad",
            "Paladin",
            "Pegasus Knight",
            "Pupil",
            "Recruit",
            "Rogue",
            "Sage",
            "Saint",
            "Scout",
            "Sentinel",
            "Shaman",
            "Sniper",
            "Spellsword",
            "Squire",
            "Summoner",
            "Swordmaster",
            "Thief",
            "Trooper",
            "Troubadour",
            "Valkyrie",
            "War Cleric",
            "Warrior",
            "Wyvern Lord",
            "Wyvern Rider"});
            this.cmbJob.Location = new System.Drawing.Point(12, 12);
            this.cmbJob.Name = "cmbJob";
            this.cmbJob.Size = new System.Drawing.Size(121, 28);
            this.cmbJob.TabIndex = 1;
            this.cmbJob.SelectedIndexChanged += new System.EventHandler(this.cmbJob_SelectedIndexChanged);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(139, 12);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(135, 62);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "Generate!";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopy.Location = new System.Drawing.Point(12, 330);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(262, 40);
            this.btnCopy.TabIndex = 3;
            this.btnCopy.Text = "Copy to Clipboard";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // cmbLevel
            // 
            this.cmbLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLevel.FormattingEnabled = true;
            this.cmbLevel.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cmbLevel.Location = new System.Drawing.Point(12, 46);
            this.cmbLevel.Name = "cmbLevel";
            this.cmbLevel.Size = new System.Drawing.Size(121, 28);
            this.cmbLevel.TabIndex = 4;
            this.cmbLevel.SelectedIndexChanged += new System.EventHandler(this.cmbLevel_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 377);
            this.Controls.Add(this.cmbLevel);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.cmbJob);
            this.Controls.Add(this.txtOutput);
            this.Name = "Form1";
            this.Text = "Fire Emblem NPC Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.ComboBox cmbJob;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.ComboBox cmbLevel;
    }
}

