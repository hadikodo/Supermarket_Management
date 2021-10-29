namespace STSM.Forms
{
    partial class Stock_Product_ADD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stock_Product_ADD));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.catbox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pricetxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.barcodetxt = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 371);
            this.panel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::STSM.Properties.Resources.blue_abstract_line_background_1409_893;
            this.groupBox1.Controls.Add(this.catbox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.pricetxt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nametxt);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.barcodetxt);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 371);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // catbox
            // 
            this.catbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.catbox.FormattingEnabled = true;
            this.catbox.Location = new System.Drawing.Point(112, 192);
            this.catbox.Name = "catbox";
            this.catbox.Size = new System.Drawing.Size(187, 21);
            this.catbox.TabIndex = 14;
            this.catbox.SelectedIndexChanged += new System.EventHandler(this.catbox_SelectedIndexChanged);
            this.catbox.SelectedValueChanged += new System.EventHandler(this.catbox_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(12, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 30);
            this.label3.TabIndex = 13;
            this.label3.Text = "Category";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(12, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 30);
            this.label4.TabIndex = 11;
            this.label4.Text = "Price";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pricetxt
            // 
            this.pricetxt.Location = new System.Drawing.Point(112, 143);
            this.pricetxt.Name = "pricetxt";
            this.pricetxt.Size = new System.Drawing.Size(187, 20);
            this.pricetxt.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(12, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 30);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(112, 91);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(187, 20);
            this.nametxt.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(123, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 38);
            this.button1.TabIndex = 7;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(12, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Barcode";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // barcodetxt
            // 
            this.barcodetxt.Location = new System.Drawing.Point(112, 43);
            this.barcodetxt.Name = "barcodetxt";
            this.barcodetxt.Size = new System.Drawing.Size(187, 20);
            this.barcodetxt.TabIndex = 1;
            // 
            // Stock_Product_ADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 371);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(391, 410);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(391, 410);
            this.Name = "Stock_Product_ADD";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Stock Product ADD";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox barcodetxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pricetxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.ComboBox catbox;
    }
}