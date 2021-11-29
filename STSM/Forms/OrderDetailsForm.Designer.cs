
namespace STSM.Forms
{
    partial class OrderDetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderDetailsForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.fluentDesignFormContainer1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.panel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.itemname_value = new System.Windows.Forms.Label();
            this.dataview_main = new System.Windows.Forms.DataGridView();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.close_btn = new System.Windows.Forms.Button();
            this.print_btn = new System.Windows.Forms.Button();
            this.cashname_value = new System.Windows.Forms.Label();
            this.cash_name_label = new System.Windows.Forms.Label();
            this.tprice_value = new System.Windows.Forms.Label();
            this.tprice_label = new System.Windows.Forms.Label();
            this.qte_value = new System.Windows.Forms.Label();
            this.qte_label = new System.Windows.Forms.Label();
            this.date_value = new System.Windows.Forms.Label();
            this.o_date_label = new System.Windows.Forms.Label();
            this.oid_value = new System.Windows.Forms.Label();
            this.o_id_label = new System.Windows.Forms.Label();
            this.barcode_clm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName_clm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price_clm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity_clm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_clm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataview_main)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fluentDesignFormContainer1
            // 
            this.fluentDesignFormContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fluentDesignFormContainer1.Location = new System.Drawing.Point(260, 0);
            this.fluentDesignFormContainer1.Name = "fluentDesignFormContainer1";
            this.fluentDesignFormContainer1.Size = new System.Drawing.Size(540, 450);
            this.fluentDesignFormContainer1.TabIndex = 0;
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Location = new System.Drawing.Point(0, 0);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(260, 450);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(800, 0);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.itemname_value);
            this.panel2.Controls.Add(this.dataview_main);
            this.panel2.Controls.Add(this.bunifuGradientPanel1);
            this.panel2.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel2.GradientBottomRight = System.Drawing.Color.Cyan;
            this.panel2.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel2.GradientTopRight = System.Drawing.Color.Cyan;
            this.panel2.Location = new System.Drawing.Point(-3, -1);
            this.panel2.Name = "panel2";
            this.panel2.Quality = 10;
            this.panel2.Size = new System.Drawing.Size(1024, 768);
            this.panel2.TabIndex = 34;
            // 
            // itemname_value
            // 
            this.itemname_value.AutoSize = true;
            this.itemname_value.BackColor = System.Drawing.Color.Transparent;
            this.itemname_value.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemname_value.ForeColor = System.Drawing.Color.White;
            this.itemname_value.Location = new System.Drawing.Point(481, 90);
            this.itemname_value.Name = "itemname_value";
            this.itemname_value.Size = new System.Drawing.Size(0, 28);
            this.itemname_value.TabIndex = 28;
            this.itemname_value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataview_main
            // 
            this.dataview_main.AllowUserToAddRows = false;
            this.dataview_main.AllowUserToDeleteRows = false;
            this.dataview_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataview_main.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataview_main.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dataview_main.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataview_main.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataview_main.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataview_main.ColumnHeadersHeight = 35;
            this.dataview_main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataview_main.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.barcode_clm,
            this.productName_clm,
            this.price_clm,
            this.quantity_clm,
            this.total_clm});
            this.dataview_main.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataview_main.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataview_main.Location = new System.Drawing.Point(3, 121);
            this.dataview_main.Margin = new System.Windows.Forms.Padding(0);
            this.dataview_main.Name = "dataview_main";
            this.dataview_main.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataview_main.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataview_main.RowHeadersWidth = 25;
            this.dataview_main.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataview_main.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataview_main.RowTemplate.Height = 35;
            this.dataview_main.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataview_main.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataview_main.Size = new System.Drawing.Size(1021, 647);
            this.dataview_main.TabIndex = 28;
            this.dataview_main.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Cell_Click);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.close_btn);
            this.bunifuGradientPanel1.Controls.Add(this.print_btn);
            this.bunifuGradientPanel1.Controls.Add(this.cashname_value);
            this.bunifuGradientPanel1.Controls.Add(this.cash_name_label);
            this.bunifuGradientPanel1.Controls.Add(this.tprice_value);
            this.bunifuGradientPanel1.Controls.Add(this.tprice_label);
            this.bunifuGradientPanel1.Controls.Add(this.qte_value);
            this.bunifuGradientPanel1.Controls.Add(this.qte_label);
            this.bunifuGradientPanel1.Controls.Add(this.date_value);
            this.bunifuGradientPanel1.Controls.Add(this.o_date_label);
            this.bunifuGradientPanel1.Controls.Add(this.oid_value);
            this.bunifuGradientPanel1.Controls.Add(this.o_id_label);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.Cyan;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Cyan;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(3, 3);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1024, 84);
            this.bunifuGradientPanel1.TabIndex = 18;
            // 
            // close_btn
            // 
            this.close_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.close_btn.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_btn.ForeColor = System.Drawing.Color.White;
            this.close_btn.Location = new System.Drawing.Point(816, 44);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(147, 35);
            this.close_btn.TabIndex = 28;
            this.close_btn.Text = "Close";
            this.close_btn.UseVisualStyleBackColor = false;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // print_btn
            // 
            this.print_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.print_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.print_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.print_btn.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.print_btn.ForeColor = System.Drawing.Color.White;
            this.print_btn.Location = new System.Drawing.Point(663, 44);
            this.print_btn.Name = "print_btn";
            this.print_btn.Size = new System.Drawing.Size(147, 35);
            this.print_btn.TabIndex = 27;
            this.print_btn.Text = "Print";
            this.print_btn.UseVisualStyleBackColor = false;
            this.print_btn.Click += new System.EventHandler(this.print_btn_Click);
            // 
            // cashname_value
            // 
            this.cashname_value.AutoSize = true;
            this.cashname_value.BackColor = System.Drawing.Color.Transparent;
            this.cashname_value.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashname_value.ForeColor = System.Drawing.Color.White;
            this.cashname_value.Location = new System.Drawing.Point(822, 5);
            this.cashname_value.Name = "cashname_value";
            this.cashname_value.Size = new System.Drawing.Size(63, 28);
            this.cashname_value.TabIndex = 26;
            this.cashname_value.Text = "value";
            this.cashname_value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cash_name_label
            // 
            this.cash_name_label.AutoSize = true;
            this.cash_name_label.BackColor = System.Drawing.Color.Transparent;
            this.cash_name_label.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cash_name_label.ForeColor = System.Drawing.Color.White;
            this.cash_name_label.Location = new System.Drawing.Point(665, 5);
            this.cash_name_label.Name = "cash_name_label";
            this.cash_name_label.Size = new System.Drawing.Size(154, 28);
            this.cash_name_label.TabIndex = 25;
            this.cash_name_label.Text = "Cashier Name :";
            this.cash_name_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tprice_value
            // 
            this.tprice_value.AutoSize = true;
            this.tprice_value.BackColor = System.Drawing.Color.Transparent;
            this.tprice_value.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tprice_value.ForeColor = System.Drawing.Color.White;
            this.tprice_value.Location = new System.Drawing.Point(460, 7);
            this.tprice_value.Name = "tprice_value";
            this.tprice_value.Size = new System.Drawing.Size(63, 28);
            this.tprice_value.TabIndex = 24;
            this.tprice_value.Text = "value";
            this.tprice_value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tprice_label
            // 
            this.tprice_label.AutoSize = true;
            this.tprice_label.BackColor = System.Drawing.Color.Transparent;
            this.tprice_label.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tprice_label.ForeColor = System.Drawing.Color.White;
            this.tprice_label.Location = new System.Drawing.Point(325, 7);
            this.tprice_label.Name = "tprice_label";
            this.tprice_label.Size = new System.Drawing.Size(129, 28);
            this.tprice_label.TabIndex = 23;
            this.tprice_label.Text = "Total Price :";
            this.tprice_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // qte_value
            // 
            this.qte_value.AutoSize = true;
            this.qte_value.BackColor = System.Drawing.Color.Transparent;
            this.qte_value.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qte_value.ForeColor = System.Drawing.Color.White;
            this.qte_value.Location = new System.Drawing.Point(496, 44);
            this.qte_value.Name = "qte_value";
            this.qte_value.Size = new System.Drawing.Size(63, 28);
            this.qte_value.TabIndex = 22;
            this.qte_value.Text = "value";
            this.qte_value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // qte_label
            // 
            this.qte_label.AutoSize = true;
            this.qte_label.BackColor = System.Drawing.Color.Transparent;
            this.qte_label.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qte_label.ForeColor = System.Drawing.Color.White;
            this.qte_label.Location = new System.Drawing.Point(325, 44);
            this.qte_label.Name = "qte_label";
            this.qte_label.Size = new System.Drawing.Size(168, 28);
            this.qte_label.TabIndex = 21;
            this.qte_label.Text = "Total Quantity :";
            this.qte_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // date_value
            // 
            this.date_value.AutoSize = true;
            this.date_value.BackColor = System.Drawing.Color.Transparent;
            this.date_value.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_value.ForeColor = System.Drawing.Color.White;
            this.date_value.Location = new System.Drawing.Point(84, 48);
            this.date_value.Name = "date_value";
            this.date_value.Size = new System.Drawing.Size(57, 25);
            this.date_value.TabIndex = 20;
            this.date_value.Text = "value";
            this.date_value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // o_date_label
            // 
            this.o_date_label.AutoSize = true;
            this.o_date_label.BackColor = System.Drawing.Color.Transparent;
            this.o_date_label.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.o_date_label.ForeColor = System.Drawing.Color.White;
            this.o_date_label.Location = new System.Drawing.Point(12, 44);
            this.o_date_label.Name = "o_date_label";
            this.o_date_label.Size = new System.Drawing.Size(72, 28);
            this.o_date_label.TabIndex = 19;
            this.o_date_label.Text = "Date :";
            this.o_date_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // oid_value
            // 
            this.oid_value.AutoSize = true;
            this.oid_value.BackColor = System.Drawing.Color.Transparent;
            this.oid_value.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oid_value.ForeColor = System.Drawing.Color.White;
            this.oid_value.Location = new System.Drawing.Point(71, 7);
            this.oid_value.Name = "oid_value";
            this.oid_value.Size = new System.Drawing.Size(63, 28);
            this.oid_value.TabIndex = 18;
            this.oid_value.Text = "value";
            this.oid_value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // o_id_label
            // 
            this.o_id_label.AutoSize = true;
            this.o_id_label.BackColor = System.Drawing.Color.Transparent;
            this.o_id_label.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.o_id_label.ForeColor = System.Drawing.Color.White;
            this.o_id_label.Location = new System.Drawing.Point(12, 7);
            this.o_id_label.Name = "o_id_label";
            this.o_id_label.Size = new System.Drawing.Size(53, 28);
            this.o_id_label.TabIndex = 17;
            this.o_id_label.Text = "ID :";
            this.o_id_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // barcode_clm
            // 
            this.barcode_clm.HeaderText = "Barcode";
            this.barcode_clm.Name = "barcode_clm";
            this.barcode_clm.ReadOnly = true;
            this.barcode_clm.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.barcode_clm.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // productName_clm
            // 
            this.productName_clm.HeaderText = "Product Name";
            this.productName_clm.Name = "productName_clm";
            this.productName_clm.ReadOnly = true;
            this.productName_clm.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.productName_clm.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // price_clm
            // 
            this.price_clm.HeaderText = "Piece Price";
            this.price_clm.Name = "price_clm";
            this.price_clm.ReadOnly = true;
            this.price_clm.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.price_clm.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // quantity_clm
            // 
            this.quantity_clm.HeaderText = "Quantity";
            this.quantity_clm.Name = "quantity_clm";
            this.quantity_clm.ReadOnly = true;
            this.quantity_clm.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.quantity_clm.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // total_clm
            // 
            this.total_clm.HeaderText = "Total Price";
            this.total_clm.Name = "total_clm";
            this.total_clm.ReadOnly = true;
            this.total_clm.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.total_clm.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // OrderDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 767);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "OrderDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderDetailsForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.OrderDetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataview_main)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer1;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private Bunifu.Framework.UI.BunifuGradientPanel panel2;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label o_id_label;
        private System.Windows.Forms.Label oid_value;
        private System.Windows.Forms.Label date_value;
        private System.Windows.Forms.Label o_date_label;
        private System.Windows.Forms.Label tprice_value;
        private System.Windows.Forms.Label tprice_label;
        private System.Windows.Forms.Label qte_value;
        private System.Windows.Forms.Label qte_label;
        private System.Windows.Forms.Label cashname_value;
        private System.Windows.Forms.Label cash_name_label;
        private System.Windows.Forms.Label itemname_value;
        public System.Windows.Forms.DataGridView dataview_main;
        private System.Windows.Forms.Button print_btn;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcode_clm;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName_clm;
        private System.Windows.Forms.DataGridViewTextBoxColumn price_clm;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity_clm;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_clm;
    }
}