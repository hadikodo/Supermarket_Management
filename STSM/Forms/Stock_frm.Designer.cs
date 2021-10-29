                                                                                                                                  namespace STSM.Forms
{
    partial class Stock_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stock_frm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.viewbtn = new System.Windows.Forms.Button();
            this.refreshbtn = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.toolbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1171, 427);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1171, 427);
            this.panel3.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dataGridView1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 34);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1171, 393);
            this.panel5.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(1171, 393);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1171, 34);
            this.panel4.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Right;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(728, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 34);
            this.label5.TabIndex = 47;
            this.label5.Text = "Show More";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(832, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 34);
            this.label1.TabIndex = 43;
            this.label1.Text = "Refresh";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Right;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(949, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 34);
            this.label4.TabIndex = 46;
            this.label4.Text = "Add";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(1062, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 34);
            this.label2.TabIndex = 44;
            this.label2.Text = "Tool";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.Tag = "First Choose Product below";
            this.toolTip1.ToolTipTitle = "First Choose Product below";
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.CausesValidation = false;
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.viewbtn);
            this.panel1.Controls.Add(this.refreshbtn);
            this.panel1.Controls.Add(this.addbtn);
            this.panel1.Controls.Add(this.toolbtn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1171, 67);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.ForeColor = System.Drawing.Color.White;
            this.radioButton2.Location = new System.Drawing.Point(321, 35);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(72, 17);
            this.radioButton2.TabIndex = 49;
            this.radioButton2.Text = "Barcode";
            this.radioButton2.UseVisualStyleBackColor = false;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.Color.White;
            this.radioButton1.Location = new System.Drawing.Point(321, 12);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(72, 17);
            this.radioButton1.TabIndex = 48;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Name";
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // viewbtn
            // 
            this.viewbtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.viewbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.viewbtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.viewbtn.Image = global::STSM.Properties.Resources.eye_32px;
            this.viewbtn.Location = new System.Drawing.Point(724, 0);
            this.viewbtn.Name = "viewbtn";
            this.viewbtn.Size = new System.Drawing.Size(108, 67);
            this.viewbtn.TabIndex = 42;
            this.viewbtn.UseVisualStyleBackColor = false;
            this.viewbtn.Click += new System.EventHandler(this.viewbtn_Click);
            // 
            // refreshbtn
            // 
            this.refreshbtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.refreshbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.refreshbtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.refreshbtn.Image = global::STSM.Properties.Resources.refresh_32px;
            this.refreshbtn.Location = new System.Drawing.Point(832, 0);
            this.refreshbtn.Name = "refreshbtn";
            this.refreshbtn.Size = new System.Drawing.Size(113, 67);
            this.refreshbtn.TabIndex = 41;
            this.refreshbtn.UseVisualStyleBackColor = false;
            this.refreshbtn.Click += new System.EventHandler(this.refreshbtn_Click);
            // 
            // addbtn
            // 
            this.addbtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.addbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.addbtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.addbtn.Image = ((System.Drawing.Image)(resources.GetObject("addbtn.Image")));
            this.addbtn.Location = new System.Drawing.Point(945, 0);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(117, 67);
            this.addbtn.TabIndex = 40;
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // toolbtn
            // 
            this.toolbtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toolbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.toolbtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolbtn.Image = global::STSM.Properties.Resources.maintenance_32px;
            this.toolbtn.Location = new System.Drawing.Point(1062, 0);
            this.toolbtn.Name = "toolbtn";
            this.toolbtn.Size = new System.Drawing.Size(109, 67);
            this.toolbtn.TabIndex = 39;
            this.toolbtn.UseVisualStyleBackColor = false;
            this.toolbtn.Click += new System.EventHandler(this.toolbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::STSM.Properties.Resources.search_32px;
            this.pictureBox1.Location = new System.Drawing.Point(283, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(274, 20);
            this.textBox1.TabIndex = 36;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Stock_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 494);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1187, 533);
            this.Name = "Stock_frm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Stock_frm_FormClosed);
            this.Load += new System.EventHandler(this.Stock_frm_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button viewbtn;
        private System.Windows.Forms.Button refreshbtn;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button toolbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}