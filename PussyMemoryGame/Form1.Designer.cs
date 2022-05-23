namespace PussyMemoryGame
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblTimeLeft = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnRestart = new System.Windows.Forms.Button();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.BtnStop = new System.Windows.Forms.Button();
            this.BtnPause = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Snow;
            this.lblStatus.Location = new System.Drawing.Point(1039, 250);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(189, 18);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Find The Right Pussies";
            // 
            // lblTimeLeft
            // 
            this.lblTimeLeft.AutoSize = true;
            this.lblTimeLeft.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeLeft.ForeColor = System.Drawing.Color.Salmon;
            this.lblTimeLeft.Location = new System.Drawing.Point(1069, 285);
            this.lblTimeLeft.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimeLeft.Name = "lblTimeLeft";
            this.lblTimeLeft.Size = new System.Drawing.Size(114, 18);
            this.lblTimeLeft.TabIndex = 0;
            this.lblTimeLeft.Text = "Time Left: 45";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.DarkTurquoise;
            this.linkLabel1.Location = new System.Drawing.Point(903, 836);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(355, 16);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Visit Raider Knight Forums for helps or suggestion!";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnRestart.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.ForeColor = System.Drawing.Color.Snow;
            this.btnRestart.Location = new System.Drawing.Point(1027, 27);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(214, 44);
            this.btnRestart.TabIndex = 2;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.RestartGameEvent);
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 1000;
            this.GameTimer.Tick += new System.EventHandler(this.TimerEvent);
            // 
            // BtnStop
            // 
            this.BtnStop.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnStop.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStop.ForeColor = System.Drawing.Color.White;
            this.BtnStop.Location = new System.Drawing.Point(1027, 166);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(214, 44);
            this.BtnStop.TabIndex = 3;
            this.BtnStop.Text = "No Timer";
            this.BtnStop.UseVisualStyleBackColor = false;
            this.BtnStop.Click += new System.EventHandler(this.StopTimer);
            // 
            // BtnPause
            // 
            this.BtnPause.BackColor = System.Drawing.Color.Teal;
            this.BtnPause.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPause.ForeColor = System.Drawing.Color.White;
            this.BtnPause.Location = new System.Drawing.Point(1027, 96);
            this.BtnPause.Name = "BtnPause";
            this.BtnPause.Size = new System.Drawing.Size(214, 44);
            this.BtnPause.TabIndex = 3;
            this.BtnPause.Text = "Pause";
            this.BtnPause.UseVisualStyleBackColor = false;
            this.BtnPause.Click += new System.EventHandler(this.TimerPause);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PussyMemoryGame.Properties.Resources.forums350;
            this.pictureBox1.Location = new System.Drawing.Point(906, 749);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 75);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1268, 861);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnPause);
            this.Controls.Add(this.BtnStop);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lblTimeLeft);
            this.Controls.Add(this.lblStatus);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matching Pussy Game";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblTimeLeft;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.Button BtnPause;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

