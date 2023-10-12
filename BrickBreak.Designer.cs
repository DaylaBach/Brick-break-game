
namespace BrickBreak
{
    partial class BrickBreak
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrickBreak));
            this.Catcher = new System.Windows.Forms.PictureBox();
            this.Breaker = new System.Windows.Forms.PictureBox();
            this.MainGameTimer = new System.Windows.Forms.Timer(this.components);
            this.ViewScore = new System.Windows.Forms.Label();
            this.gameOverLabel = new System.Windows.Forms.Label();
            this.pausedLabel = new System.Windows.Forms.Label();
            this.nextLevel = new System.Windows.Forms.Button();
            this.RestartLevel = new System.Windows.Forms.Button();
            this.Winner = new System.Windows.Forms.Label();
            this.Trophy = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SaveName = new System.Windows.Forms.Button();
            this.textBox1Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Catcher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Breaker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trophy)).BeginInit();
            this.SuspendLayout();
            // 
            // Catcher
            // 
            this.Catcher.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Catcher.Location = new System.Drawing.Point(262, 478);
            this.Catcher.Name = "Catcher";
            this.Catcher.Size = new System.Drawing.Size(104, 17);
            this.Catcher.TabIndex = 1;
            this.Catcher.TabStop = false;
            this.Catcher.Tag = "catcher";
            // 
            // Breaker
            // 
            this.Breaker.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Breaker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Breaker.Location = new System.Drawing.Point(306, 329);
            this.Breaker.Name = "Breaker";
            this.Breaker.Size = new System.Drawing.Size(18, 16);
            this.Breaker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Breaker.TabIndex = 2;
            this.Breaker.TabStop = false;
            this.Breaker.Tag = "breaker";
            // 
            // MainGameTimer
            // 
            this.MainGameTimer.Enabled = true;
            this.MainGameTimer.Interval = 20;
            this.MainGameTimer.Tick += new System.EventHandler(this.MainGameTimer_Tick);
            // 
            // ViewScore
            // 
            this.ViewScore.AutoSize = true;
            this.ViewScore.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ViewScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewScore.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ViewScore.Location = new System.Drawing.Point(12, 470);
            this.ViewScore.Name = "ViewScore";
            this.ViewScore.Size = new System.Drawing.Size(68, 25);
            this.ViewScore.TabIndex = 3;
            this.ViewScore.Text = "Score";
            // 
            // gameOverLabel
            // 
            this.gameOverLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gameOverLabel.AutoSize = true;
            this.gameOverLabel.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOverLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gameOverLabel.Location = new System.Drawing.Point(204, 225);
            this.gameOverLabel.Name = "gameOverLabel";
            this.gameOverLabel.Size = new System.Drawing.Size(212, 41);
            this.gameOverLabel.TabIndex = 4;
            this.gameOverLabel.Text = "GAME OVER";
            this.gameOverLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pausedLabel
            // 
            this.pausedLabel.AutoSize = true;
            this.pausedLabel.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pausedLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.pausedLabel.Location = new System.Drawing.Point(247, 184);
            this.pausedLabel.Name = "pausedLabel";
            this.pausedLabel.Size = new System.Drawing.Size(119, 41);
            this.pausedLabel.TabIndex = 5;
            this.pausedLabel.Text = "Paused";
            // 
            // nextLevel
            // 
            this.nextLevel.BackColor = System.Drawing.SystemColors.Control;
            this.nextLevel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.nextLevel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.nextLevel.Location = new System.Drawing.Point(262, 255);
            this.nextLevel.Name = "nextLevel";
            this.nextLevel.Size = new System.Drawing.Size(104, 37);
            this.nextLevel.TabIndex = 6;
            this.nextLevel.Text = "Next level";
            this.nextLevel.UseVisualStyleBackColor = false;
            this.nextLevel.Click += new System.EventHandler(this.nextLevel_Click);
            // 
            // RestartLevel
            // 
            this.RestartLevel.BackColor = System.Drawing.SystemColors.Control;
            this.RestartLevel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RestartLevel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RestartLevel.Location = new System.Drawing.Point(262, 130);
            this.RestartLevel.Name = "RestartLevel";
            this.RestartLevel.Size = new System.Drawing.Size(104, 37);
            this.RestartLevel.TabIndex = 7;
            this.RestartLevel.Text = "Restart";
            this.RestartLevel.UseVisualStyleBackColor = false;
            this.RestartLevel.Click += new System.EventHandler(this.RestartLevel_Click);
            // 
            // Winner
            // 
            this.Winner.AutoSize = true;
            this.Winner.Font = new System.Drawing.Font("MV Boli", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Winner.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Winner.Location = new System.Drawing.Point(6, 30);
            this.Winner.Name = "Winner";
            this.Winner.Size = new System.Drawing.Size(602, 63);
            this.Winner.TabIndex = 8;
            this.Winner.Text = "WE HAVE A WINNER !!";
            // 
            // Trophy
            // 
            this.Trophy.Image = ((System.Drawing.Image)(resources.GetObject("Trophy.Image")));
            this.Trophy.Location = new System.Drawing.Point(194, 173);
            this.Trophy.Name = "Trophy";
            this.Trophy.Size = new System.Drawing.Size(235, 263);
            this.Trophy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Trophy.TabIndex = 9;
            this.Trophy.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(148, 104);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(235, 20);
            this.textBox1.TabIndex = 11;
            // 
            // SaveName
            // 
            this.SaveName.Location = new System.Drawing.Point(407, 102);
            this.SaveName.Name = "SaveName";
            this.SaveName.Size = new System.Drawing.Size(75, 23);
            this.SaveName.TabIndex = 12;
            this.SaveName.Text = "Save";
            this.SaveName.UseVisualStyleBackColor = true;
            this.SaveName.Click += new System.EventHandler(this.SaveName_Click);
            // 
            // textBox1Label
            // 
            this.textBox1Label.AutoSize = true;
            this.textBox1Label.ForeColor = System.Drawing.SystemColors.Control;
            this.textBox1Label.Location = new System.Drawing.Point(27, 107);
            this.textBox1Label.Name = "textBox1Label";
            this.textBox1Label.Size = new System.Drawing.Size(115, 13);
            this.textBox1Label.TabIndex = 13;
            this.textBox1Label.Text = "Our champion\'s name :";
            // 
            // BrickBreak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(617, 507);
            this.Controls.Add(this.textBox1Label);
            this.Controls.Add(this.SaveName);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Trophy);
            this.Controls.Add(this.Winner);
            this.Controls.Add(this.RestartLevel);
            this.Controls.Add(this.nextLevel);
            this.Controls.Add(this.pausedLabel);
            this.Controls.Add(this.gameOverLabel);
            this.Controls.Add(this.Breaker);
            this.Controls.Add(this.Catcher);
            this.Controls.Add(this.ViewScore);
            this.Name = "BrickBreak";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.Catcher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Breaker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trophy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox Catcher;
        private System.Windows.Forms.PictureBox Breaker;
        private System.Windows.Forms.Timer MainGameTimer;
        private System.Windows.Forms.Label ViewScore;
        private System.Windows.Forms.Label gameOverLabel;
        private System.Windows.Forms.Label pausedLabel;
        private System.Windows.Forms.Button nextLevel;
        private System.Windows.Forms.Button RestartLevel;
        private System.Windows.Forms.Label Winner;
        private System.Windows.Forms.PictureBox Trophy;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button SaveName;
        private System.Windows.Forms.Label textBox1Label;
    }
}

