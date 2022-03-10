namespace STSM.Forms
{
    partial class Loading
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loading));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.loading_logo = new System.Windows.Forms.PictureBox();
            this.loading_poweredby = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.loading_ProgressBar = new Bunifu.Framework.UI.BunifuProgressBar();
            this.loading_Timer = new System.Windows.Forms.Timer(this.components);
            this.Progress_Value = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.barLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.loading_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 100;
            this.bunifuElipse1.TargetControl = this;
            // 
            // loading_logo
            // 
            this.loading_logo.BackColor = System.Drawing.Color.Transparent;
            this.loading_logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loading_logo.BackgroundImage")));
            this.loading_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loading_logo.Location = new System.Drawing.Point(347, 12);
            this.loading_logo.Name = "loading_logo";
            this.loading_logo.Size = new System.Drawing.Size(168, 162);
            this.loading_logo.TabIndex = 0;
            this.loading_logo.TabStop = false;
            this.loading_logo.Click += new System.EventHandler(this.loading_logo_Click);
            // 
            // loading_poweredby
            // 
            this.loading_poweredby.AutoSize = true;
            this.loading_poweredby.BackColor = System.Drawing.Color.Transparent;
            this.loading_poweredby.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loading_poweredby.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.loading_poweredby.Location = new System.Drawing.Point(351, 177);
            this.loading_poweredby.Name = "loading_poweredby";
            this.loading_poweredby.Size = new System.Drawing.Size(160, 18);
            this.loading_poweredby.TabIndex = 1;
            this.loading_poweredby.Text = "Powered by SuperTech";
            // 
            // loading_ProgressBar
            // 
            this.loading_ProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.loading_ProgressBar.BorderRadius = 5;
            this.loading_ProgressBar.Location = new System.Drawing.Point(29, 261);
            this.loading_ProgressBar.MaximumValue = 100;
            this.loading_ProgressBar.Name = "loading_ProgressBar";
            this.loading_ProgressBar.ProgressColor = System.Drawing.Color.AliceBlue;
            this.loading_ProgressBar.Size = new System.Drawing.Size(495, 29);
            this.loading_ProgressBar.TabIndex = 2;
            this.loading_ProgressBar.Value = 0;
            this.loading_ProgressBar.progressChanged += new System.EventHandler(this.loading_ProgressBar_progressChanged);
            // 
            // loading_Timer
            // 
            this.loading_Timer.Enabled = true;
            this.loading_Timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Progress_Value
            // 
            this.Progress_Value.AutoSize = true;
            this.Progress_Value.BackColor = System.Drawing.Color.Transparent;
            this.Progress_Value.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Progress_Value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Progress_Value.Location = new System.Drawing.Point(254, 262);
            this.Progress_Value.Name = "Progress_Value";
            this.Progress_Value.Size = new System.Drawing.Size(33, 22);
            this.Progress_Value.TabIndex = 3;
            this.Progress_Value.Text = "0%";
            // 
            // barLabel
            // 
            this.barLabel.BackColor = System.Drawing.Color.Transparent;
            this.barLabel.Font = new System.Drawing.Font("Andalus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.barLabel.Location = new System.Drawing.Point(109, 291);
            this.barLabel.Name = "barLabel";
            this.barLabel.Size = new System.Drawing.Size(323, 35);
            this.barLabel.TabIndex = 4;
            this.barLabel.Text = "Initializing...";
            this.barLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(551, 329);
            this.Controls.Add(this.barLabel);
            this.Controls.Add(this.Progress_Value);
            this.Controls.Add(this.loading_ProgressBar);
            this.Controls.Add(this.loading_poweredby);
            this.Controls.Add(this.loading_logo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Loading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading";
            this.Load += new System.EventHandler(this.Loading_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loading_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox loading_logo;
        private Bunifu.Framework.UI.BunifuCustomLabel loading_poweredby;
        private Bunifu.Framework.UI.BunifuProgressBar loading_ProgressBar;
        private System.Windows.Forms.Timer loading_Timer;
        private Bunifu.Framework.UI.BunifuCustomLabel Progress_Value;
        private System.Windows.Forms.Label barLabel;
    }
}