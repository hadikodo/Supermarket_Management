namespace STSM.Forms
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.username_tb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pass_tb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Exit_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Minimize_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.welc_label = new System.Windows.Forms.Label();
            this.login_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.incorrect_txt = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // username_tb
            // 
            this.username_tb.BackColor = System.Drawing.Color.White;
            this.username_tb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.username_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.username_tb.Font = new System.Drawing.Font("Andalus", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_tb.ForeColor = System.Drawing.Color.Black;
            this.username_tb.HintForeColor = System.Drawing.SystemColors.WindowFrame;
            this.username_tb.HintText = "Username";
            this.username_tb.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.username_tb.isPassword = false;
            this.username_tb.LineFocusedColor = System.Drawing.Color.MidnightBlue;
            this.username_tb.LineIdleColor = System.Drawing.Color.Transparent;
            this.username_tb.LineMouseHoverColor = System.Drawing.Color.MidnightBlue;
            this.username_tb.LineThickness = 5;
            this.username_tb.Location = new System.Drawing.Point(214, 197);
            this.username_tb.Margin = new System.Windows.Forms.Padding(0);
            this.username_tb.Name = "username_tb";
            this.username_tb.Size = new System.Drawing.Size(275, 60);
            this.username_tb.TabIndex = 0;
            this.username_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.username_tb.OnValueChanged += new System.EventHandler(this.username_tb_vc);
            this.username_tb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Enter_Key);
            // 
            // pass_tb
            // 
            this.pass_tb.BackColor = System.Drawing.Color.White;
            this.pass_tb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pass_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pass_tb.Font = new System.Drawing.Font("Andalus", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_tb.ForeColor = System.Drawing.Color.Black;
            this.pass_tb.HintForeColor = System.Drawing.SystemColors.WindowFrame;
            this.pass_tb.HintText = "Password";
            this.pass_tb.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.pass_tb.isPassword = false;
            this.pass_tb.LineFocusedColor = System.Drawing.Color.MidnightBlue;
            this.pass_tb.LineIdleColor = System.Drawing.Color.Transparent;
            this.pass_tb.LineMouseHoverColor = System.Drawing.Color.MidnightBlue;
            this.pass_tb.LineThickness = 5;
            this.pass_tb.Location = new System.Drawing.Point(214, 270);
            this.pass_tb.Margin = new System.Windows.Forms.Padding(0);
            this.pass_tb.Name = "pass_tb";
            this.pass_tb.Size = new System.Drawing.Size(275, 60);
            this.pass_tb.TabIndex = 1;
            this.pass_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pass_tb.OnValueChanged += new System.EventHandler(this.pass_tb_vc);
            this.pass_tb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Enter_Key);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 440);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Powered by SuperTech";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 23);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Exit_btn
            // 
            this.Exit_btn.Activecolor = System.Drawing.Color.White;
            this.Exit_btn.BackColor = System.Drawing.Color.White;
            this.Exit_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Exit_btn.BorderRadius = 0;
            this.Exit_btn.ButtonText = "X";
            this.Exit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit_btn.DisabledColor = System.Drawing.Color.Gray;
            this.Exit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.Exit_btn.Iconimage = null;
            this.Exit_btn.Iconimage_right = null;
            this.Exit_btn.Iconimage_right_Selected = null;
            this.Exit_btn.Iconimage_Selected = null;
            this.Exit_btn.IconMarginLeft = 0;
            this.Exit_btn.IconMarginRight = 0;
            this.Exit_btn.IconRightVisible = true;
            this.Exit_btn.IconRightZoom = 0D;
            this.Exit_btn.IconVisible = true;
            this.Exit_btn.IconZoom = 90D;
            this.Exit_btn.IsTab = false;
            this.Exit_btn.Location = new System.Drawing.Point(665, 7);
            this.Exit_btn.Margin = new System.Windows.Forms.Padding(0);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Normalcolor = System.Drawing.Color.White;
            this.Exit_btn.OnHovercolor = System.Drawing.Color.SteelBlue;
            this.Exit_btn.OnHoverTextColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Exit_btn.selected = false;
            this.Exit_btn.Size = new System.Drawing.Size(31, 26);
            this.Exit_btn.TabIndex = 8;
            this.Exit_btn.Text = "X";
            this.Exit_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Exit_btn.Textcolor = System.Drawing.Color.Black;
            this.Exit_btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // Minimize_btn
            // 
            this.Minimize_btn.Activecolor = System.Drawing.Color.White;
            this.Minimize_btn.BackColor = System.Drawing.Color.White;
            this.Minimize_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Minimize_btn.BorderRadius = 0;
            this.Minimize_btn.ButtonText = "—";
            this.Minimize_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimize_btn.DisabledColor = System.Drawing.Color.Gray;
            this.Minimize_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minimize_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.Minimize_btn.Iconimage = null;
            this.Minimize_btn.Iconimage_right = null;
            this.Minimize_btn.Iconimage_right_Selected = null;
            this.Minimize_btn.Iconimage_Selected = null;
            this.Minimize_btn.IconMarginLeft = 0;
            this.Minimize_btn.IconMarginRight = 0;
            this.Minimize_btn.IconRightVisible = true;
            this.Minimize_btn.IconRightZoom = 0D;
            this.Minimize_btn.IconVisible = true;
            this.Minimize_btn.IconZoom = 90D;
            this.Minimize_btn.IsTab = false;
            this.Minimize_btn.Location = new System.Drawing.Point(633, 7);
            this.Minimize_btn.Margin = new System.Windows.Forms.Padding(0);
            this.Minimize_btn.Name = "Minimize_btn";
            this.Minimize_btn.Normalcolor = System.Drawing.Color.White;
            this.Minimize_btn.OnHovercolor = System.Drawing.Color.SteelBlue;
            this.Minimize_btn.OnHoverTextColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Minimize_btn.selected = false;
            this.Minimize_btn.Size = new System.Drawing.Size(32, 26);
            this.Minimize_btn.TabIndex = 9;
            this.Minimize_btn.Text = "—";
            this.Minimize_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Minimize_btn.Textcolor = System.Drawing.Color.Black;
            this.Minimize_btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minimize_btn.Click += new System.EventHandler(this.Minimize_btn_Click);
            // 
            // welc_label
            // 
            this.welc_label.AutoSize = true;
            this.welc_label.BackColor = System.Drawing.Color.Transparent;
            this.welc_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.welc_label.Font = new System.Drawing.Font("Monotype Corsiva", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welc_label.ForeColor = System.Drawing.Color.MidnightBlue;
            this.welc_label.Location = new System.Drawing.Point(386, 37);
            this.welc_label.Name = "welc_label";
            this.welc_label.Size = new System.Drawing.Size(307, 117);
            this.welc_label.TabIndex = 11;
            this.welc_label.Text = "Sign In";
            // 
            // login_btn
            // 
            this.login_btn.Activecolor = System.Drawing.Color.White;
            this.login_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.login_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.login_btn.BorderRadius = 0;
            this.login_btn.ButtonText = "Login";
            this.login_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_btn.DisabledColor = System.Drawing.Color.Gray;
            this.login_btn.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.login_btn.Iconimage = null;
            this.login_btn.Iconimage_right = null;
            this.login_btn.Iconimage_right_Selected = null;
            this.login_btn.Iconimage_Selected = null;
            this.login_btn.IconMarginLeft = 0;
            this.login_btn.IconMarginRight = 0;
            this.login_btn.IconRightVisible = false;
            this.login_btn.IconRightZoom = 0D;
            this.login_btn.IconVisible = false;
            this.login_btn.IconZoom = 0D;
            this.login_btn.IsTab = false;
            this.login_btn.Location = new System.Drawing.Point(250, 344);
            this.login_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.login_btn.Name = "login_btn";
            this.login_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.login_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(255)))));
            this.login_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.login_btn.selected = false;
            this.login_btn.Size = new System.Drawing.Size(200, 54);
            this.login_btn.TabIndex = 12;
            this.login_btn.Text = "Login";
            this.login_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.login_btn.Textcolor = System.Drawing.Color.White;
            this.login_btn.TextFont = new System.Drawing.Font("Andalus", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // incorrect_txt
            // 
            this.incorrect_txt.BackColor = System.Drawing.Color.Transparent;
            this.incorrect_txt.Font = new System.Drawing.Font("Andalus", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incorrect_txt.ForeColor = System.Drawing.Color.Red;
            this.incorrect_txt.Location = new System.Drawing.Point(20, 197);
            this.incorrect_txt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.incorrect_txt.Name = "incorrect_txt";
            this.incorrect_txt.Size = new System.Drawing.Size(172, 123);
            this.incorrect_txt.TabIndex = 13;
            this.incorrect_txt.Text = "Username or Password Incorrect! Please Try Again 1/3";
            this.incorrect_txt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(705, 457);
            this.ControlBox = false;
            this.Controls.Add(this.incorrect_txt);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.welc_label);
            this.Controls.Add(this.Minimize_btn);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pass_tb);
            this.Controls.Add(this.username_tb);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox username_tb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox pass_tb;
        private Bunifu.Framework.UI.BunifuCustomLabel label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton Exit_btn;
        private Bunifu.Framework.UI.BunifuFlatButton Minimize_btn;
        private System.Windows.Forms.Label welc_label;
        private Bunifu.Framework.UI.BunifuFlatButton login_btn;
        private Bunifu.Framework.UI.BunifuCustomLabel incorrect_txt;
        private System.Windows.Forms.Timer timer1;
    }
}