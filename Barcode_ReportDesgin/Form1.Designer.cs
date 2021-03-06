namespace Barcode_ReportDesgin
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
            this.imageBoxEx1 = new Cyotek.Windows.Forms.Demo.ImageBoxEx();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.kryptonButton2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton3 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton4 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton5 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtData = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btn_Generate_barcode = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.cbEncodeType = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkGenerateLabel = new System.Windows.Forms.CheckBox();
            this.txt_bc_H = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.cbLabelLocation = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.cbRotateFlip = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.cbBarcodeAlign = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.txt_bc_w = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel8 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel7 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_item_name = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txt_price = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel9 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel13 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel10 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_market_name = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chk_barcode = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.chk_price = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.chk_item_name = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.chk_marketName = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbEncodeType)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbLabelLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbRotateFlip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbBarcodeAlign)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageBoxEx1
            // 
            this.imageBoxEx1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageBoxEx1.BackColor = System.Drawing.Color.Black;
            this.imageBoxEx1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBoxEx1.GridColor = System.Drawing.Color.White;
            this.imageBoxEx1.ImageBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.imageBoxEx1.ImageBorderStyle = Cyotek.Windows.Forms.ImageBoxBorderStyle.FixedSingleDropShadow;
            this.imageBoxEx1.Location = new System.Drawing.Point(652, 117);
            this.imageBoxEx1.Name = "imageBoxEx1";
            this.imageBoxEx1.SelectionMode = Cyotek.Windows.Forms.ImageBoxSelectionMode.Rectangle;
            this.imageBoxEx1.Size = new System.Drawing.Size(434, 539);
            this.imageBoxEx1.TabIndex = 0;
            this.imageBoxEx1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.imageBoxEx1_MouseUp);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1098, 60);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("justagain DIN", 25F);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1098, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Barcode printing desgin";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kryptonButton2
            // 
            this.kryptonButton2.Location = new System.Drawing.Point(968, 70);
            this.kryptonButton2.Name = "kryptonButton2";
            this.kryptonButton2.Size = new System.Drawing.Size(46, 40);
            this.kryptonButton2.TabIndex = 1;
            this.kryptonButton2.Values.Text = "F";
            // 
            // kryptonButton3
            // 
            this.kryptonButton3.Location = new System.Drawing.Point(916, 70);
            this.kryptonButton3.Name = "kryptonButton3";
            this.kryptonButton3.Size = new System.Drawing.Size(46, 40);
            this.kryptonButton3.TabIndex = 1;
            this.kryptonButton3.Values.Text = "A";
            // 
            // kryptonButton4
            // 
            this.kryptonButton4.Location = new System.Drawing.Point(864, 70);
            this.kryptonButton4.Name = "kryptonButton4";
            this.kryptonButton4.Size = new System.Drawing.Size(46, 40);
            this.kryptonButton4.TabIndex = 1;
            this.kryptonButton4.Values.Text = "-";
            // 
            // kryptonButton5
            // 
            this.kryptonButton5.Location = new System.Drawing.Point(812, 70);
            this.kryptonButton5.Name = "kryptonButton5";
            this.kryptonButton5.Size = new System.Drawing.Size(46, 40);
            this.kryptonButton5.TabIndex = 1;
            this.kryptonButton5.Values.Text = "+";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(13, 70);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(87, 20);
            this.kryptonLabel1.TabIndex = 3;
            this.kryptonLabel1.Values.Text = "Barcode value";
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(140, 144);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(389, 39);
            this.txtData.StateCommon.Border.Color1 = System.Drawing.Color.Green;
            this.txtData.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtData.StateCommon.Border.Rounding = 5;
            this.txtData.StateCommon.Border.Width = 1;
            this.txtData.StateCommon.Content.Font = new System.Drawing.Font("justagain DIN", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.TabIndex = 4;
            this.txtData.Text = "123456789";
            // 
            // btn_Generate_barcode
            // 
            this.btn_Generate_barcode.Location = new System.Drawing.Point(535, 114);
            this.btn_Generate_barcode.Name = "btn_Generate_barcode";
            this.btn_Generate_barcode.Size = new System.Drawing.Size(94, 52);
            this.btn_Generate_barcode.StateCommon.Border.Color1 = System.Drawing.Color.Red;
            this.btn_Generate_barcode.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_Generate_barcode.StateCommon.Border.Rounding = 5;
            this.btn_Generate_barcode.StateCommon.Border.Width = 1;
            this.btn_Generate_barcode.StateCommon.Content.ShortText.Font = new System.Drawing.Font("justagain DIN", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Generate_barcode.TabIndex = 1;
            this.btn_Generate_barcode.Values.Text = "Set";
            this.btn_Generate_barcode.Click += new System.EventHandler(this.btn_Generate_barcode_Click);
            // 
            // cbEncodeType
            // 
            this.cbEncodeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEncodeType.DropDownWidth = 385;
            this.cbEncodeType.Items.AddRange(new object[] {
            "Code 93",
            "Code 128",
            "Code 128-A",
            "Code 128-B",
            "Code 128-C",
            "UPC-A",
            "UPC-E",
            "EAN-13",
            "JAN-13",
            "EAN-8",
            "Bookland/ISBN",
            "Code 11",
            "Code 39",
            "Code 39 Extended",
            "Code 39 Mod 43",
            ""});
            this.cbEncodeType.Location = new System.Drawing.Point(140, 101);
            this.cbEncodeType.Name = "cbEncodeType";
            this.cbEncodeType.Size = new System.Drawing.Size(389, 37);
            this.cbEncodeType.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.Red;
            this.cbEncodeType.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbEncodeType.StateCommon.ComboBox.Border.Rounding = 5;
            this.cbEncodeType.StateCommon.ComboBox.Border.Width = 1;
            this.cbEncodeType.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("justagain DIN", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEncodeType.TabIndex = 5;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(1, 148);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(131, 33);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("justagain DIN", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 3;
            this.kryptonLabel2.Values.Text = "Barcode value";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(13, 105);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(126, 33);
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("justagain DIN", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 3;
            this.kryptonLabel3.Values.Text = "Barcode Type";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkGenerateLabel);
            this.groupBox1.Controls.Add(this.txt_bc_H);
            this.groupBox1.Controls.Add(this.cbLabelLocation);
            this.groupBox1.Controls.Add(this.cbRotateFlip);
            this.groupBox1.Controls.Add(this.cbBarcodeAlign);
            this.groupBox1.Controls.Add(this.txt_bc_w);
            this.groupBox1.Controls.Add(this.kryptonLabel5);
            this.groupBox1.Controls.Add(this.kryptonLabel8);
            this.groupBox1.Controls.Add(this.kryptonLabel7);
            this.groupBox1.Controls.Add(this.kryptonLabel6);
            this.groupBox1.Controls.Add(this.kryptonLabel4);
            this.groupBox1.Font = new System.Drawing.Font("justagain DIN", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 189);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 203);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Barcode size";
            // 
            // chkGenerateLabel
            // 
            this.chkGenerateLabel.AutoSize = true;
            this.chkGenerateLabel.Location = new System.Drawing.Point(222, 165);
            this.chkGenerateLabel.Name = "chkGenerateLabel";
            this.chkGenerateLabel.Size = new System.Drawing.Size(197, 32);
            this.chkGenerateLabel.TabIndex = 41;
            this.chkGenerateLabel.Text = "Show barcode value";
            this.chkGenerateLabel.UseVisualStyleBackColor = true;
            // 
            // txt_bc_H
            // 
            this.txt_bc_H.Location = new System.Drawing.Point(48, 74);
            this.txt_bc_H.Name = "txt_bc_H";
            this.txt_bc_H.Size = new System.Drawing.Size(85, 39);
            this.txt_bc_H.StateCommon.Border.Color1 = System.Drawing.Color.Green;
            this.txt_bc_H.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_bc_H.StateCommon.Border.Rounding = 5;
            this.txt_bc_H.StateCommon.Border.Width = 1;
            this.txt_bc_H.StateCommon.Content.Font = new System.Drawing.Font("justagain DIN", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bc_H.TabIndex = 4;
            this.txt_bc_H.Text = "100";
            this.txt_bc_H.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbLabelLocation
            // 
            this.cbLabelLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLabelLocation.DropDownWidth = 385;
            this.cbLabelLocation.Items.AddRange(new object[] {
            "BottomCenter",
            "BottomLeft",
            "BottomRight",
            "TopCenter",
            "TopLeft",
            "TopRight"});
            this.cbLabelLocation.Location = new System.Drawing.Point(239, 119);
            this.cbLabelLocation.Name = "cbLabelLocation";
            this.cbLabelLocation.Size = new System.Drawing.Size(231, 37);
            this.cbLabelLocation.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.Red;
            this.cbLabelLocation.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbLabelLocation.StateCommon.ComboBox.Border.Rounding = 5;
            this.cbLabelLocation.StateCommon.ComboBox.Border.Width = 1;
            this.cbLabelLocation.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("justagain DIN", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLabelLocation.TabIndex = 5;
            // 
            // cbRotateFlip
            // 
            this.cbRotateFlip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRotateFlip.DropDownWidth = 385;
            this.cbRotateFlip.Enabled = false;
            this.cbRotateFlip.Items.AddRange(new object[] {
            "Center",
            "Left",
            "Right"});
            this.cbRotateFlip.Location = new System.Drawing.Point(239, 76);
            this.cbRotateFlip.Name = "cbRotateFlip";
            this.cbRotateFlip.Size = new System.Drawing.Size(231, 37);
            this.cbRotateFlip.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.Red;
            this.cbRotateFlip.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbRotateFlip.StateCommon.ComboBox.Border.Rounding = 5;
            this.cbRotateFlip.StateCommon.ComboBox.Border.Width = 1;
            this.cbRotateFlip.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("justagain DIN", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRotateFlip.TabIndex = 5;
            // 
            // cbBarcodeAlign
            // 
            this.cbBarcodeAlign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBarcodeAlign.DropDownWidth = 385;
            this.cbBarcodeAlign.Items.AddRange(new object[] {
            "Center",
            "Left",
            "Right"});
            this.cbBarcodeAlign.Location = new System.Drawing.Point(239, 29);
            this.cbBarcodeAlign.Name = "cbBarcodeAlign";
            this.cbBarcodeAlign.Size = new System.Drawing.Size(231, 37);
            this.cbBarcodeAlign.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.Red;
            this.cbBarcodeAlign.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbBarcodeAlign.StateCommon.ComboBox.Border.Rounding = 5;
            this.cbBarcodeAlign.StateCommon.ComboBox.Border.Width = 1;
            this.cbBarcodeAlign.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("justagain DIN", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBarcodeAlign.TabIndex = 5;
            // 
            // txt_bc_w
            // 
            this.txt_bc_w.Location = new System.Drawing.Point(48, 33);
            this.txt_bc_w.Name = "txt_bc_w";
            this.txt_bc_w.Size = new System.Drawing.Size(85, 39);
            this.txt_bc_w.StateCommon.Border.Color1 = System.Drawing.Color.Green;
            this.txt_bc_w.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_bc_w.StateCommon.Border.Rounding = 5;
            this.txt_bc_w.StateCommon.Border.Width = 1;
            this.txt_bc_w.StateCommon.Content.Font = new System.Drawing.Font("justagain DIN", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bc_w.TabIndex = 4;
            this.txt_bc_w.Text = "400";
            this.txt_bc_w.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(6, 72);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(26, 33);
            this.kryptonLabel5.StateCommon.ShortText.Font = new System.Drawing.Font("justagain DIN", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel5.TabIndex = 3;
            this.kryptonLabel5.Values.Text = "H";
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Location = new System.Drawing.Point(6, 124);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(206, 33);
            this.kryptonLabel8.StateCommon.ShortText.Font = new System.Drawing.Font("justagain DIN", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel8.TabIndex = 3;
            this.kryptonLabel8.Values.Text = "Barcode value  location";
            this.kryptonLabel8.Paint += new System.Windows.Forms.PaintEventHandler(this.kryptonLabel4_Paint);
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(139, 76);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(67, 33);
            this.kryptonLabel7.StateCommon.ShortText.Font = new System.Drawing.Font("justagain DIN", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel7.TabIndex = 3;
            this.kryptonLabel7.Values.Text = "Rotate";
            this.kryptonLabel7.Paint += new System.Windows.Forms.PaintEventHandler(this.kryptonLabel4_Paint);
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(139, 33);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(98, 33);
            this.kryptonLabel6.StateCommon.ShortText.Font = new System.Drawing.Font("justagain DIN", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel6.TabIndex = 3;
            this.kryptonLabel6.Values.Text = "Alignment";
            this.kryptonLabel6.Paint += new System.Windows.Forms.PaintEventHandler(this.kryptonLabel4_Paint);
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(6, 33);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(29, 33);
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("justagain DIN", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.TabIndex = 3;
            this.kryptonLabel4.Values.Text = "W";
            this.kryptonLabel4.Paint += new System.Windows.Forms.PaintEventHandler(this.kryptonLabel4_Paint);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_market_name);
            this.groupBox2.Controls.Add(this.txt_item_name);
            this.groupBox2.Controls.Add(this.txt_price);
            this.groupBox2.Controls.Add(this.kryptonLabel10);
            this.groupBox2.Controls.Add(this.kryptonLabel9);
            this.groupBox2.Controls.Add(this.kryptonLabel13);
            this.groupBox2.Font = new System.Drawing.Font("justagain DIN", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(9, 398);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(489, 203);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data";
            // 
            // txt_item_name
            // 
            this.txt_item_name.Location = new System.Drawing.Point(125, 78);
            this.txt_item_name.Name = "txt_item_name";
            this.txt_item_name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_item_name.Size = new System.Drawing.Size(358, 39);
            this.txt_item_name.StateCommon.Border.Color1 = System.Drawing.Color.Green;
            this.txt_item_name.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_item_name.StateCommon.Border.Rounding = 5;
            this.txt_item_name.StateCommon.Border.Width = 1;
            this.txt_item_name.StateCommon.Content.Font = new System.Drawing.Font("justagain DIN", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_item_name.TabIndex = 4;
            this.txt_item_name.Text = "جبنه براميلى";
            this.txt_item_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(125, 33);
            this.txt_price.Name = "txt_price";
            this.txt_price.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_price.Size = new System.Drawing.Size(358, 39);
            this.txt_price.StateCommon.Border.Color1 = System.Drawing.Color.Green;
            this.txt_price.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_price.StateCommon.Border.Rounding = 5;
            this.txt_price.StateCommon.Border.Width = 1;
            this.txt_price.StateCommon.Content.Font = new System.Drawing.Font("justagain DIN", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_price.TabIndex = 4;
            this.txt_price.Text = "50.89 EGP";
            this.txt_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // kryptonLabel9
            // 
            this.kryptonLabel9.Location = new System.Drawing.Point(15, 78);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.Size = new System.Drawing.Size(104, 33);
            this.kryptonLabel9.StateCommon.ShortText.Font = new System.Drawing.Font("justagain DIN", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel9.TabIndex = 3;
            this.kryptonLabel9.Values.Text = "Item Name";
            // 
            // kryptonLabel13
            // 
            this.kryptonLabel13.Location = new System.Drawing.Point(63, 34);
            this.kryptonLabel13.Name = "kryptonLabel13";
            this.kryptonLabel13.Size = new System.Drawing.Size(56, 33);
            this.kryptonLabel13.StateCommon.ShortText.Font = new System.Drawing.Font("justagain DIN", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel13.TabIndex = 3;
            this.kryptonLabel13.Values.Text = "Price";
            // 
            // kryptonLabel10
            // 
            this.kryptonLabel10.Location = new System.Drawing.Point(-4, 123);
            this.kryptonLabel10.Name = "kryptonLabel10";
            this.kryptonLabel10.Size = new System.Drawing.Size(123, 33);
            this.kryptonLabel10.StateCommon.ShortText.Font = new System.Drawing.Font("justagain DIN", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel10.TabIndex = 3;
            this.kryptonLabel10.Values.Text = "Market name";
            // 
            // txt_market_name
            // 
            this.txt_market_name.Location = new System.Drawing.Point(125, 123);
            this.txt_market_name.Name = "txt_market_name";
            this.txt_market_name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_market_name.Size = new System.Drawing.Size(358, 39);
            this.txt_market_name.StateCommon.Border.Color1 = System.Drawing.Color.Green;
            this.txt_market_name.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_market_name.StateCommon.Border.Rounding = 5;
            this.txt_market_name.StateCommon.Border.Width = 1;
            this.txt_market_name.StateCommon.Content.Font = new System.Drawing.Font("justagain DIN", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_market_name.TabIndex = 4;
            this.txt_market_name.Text = "الهوارى ماركت";
            this.txt_market_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chk_marketName);
            this.groupBox3.Controls.Add(this.chk_item_name);
            this.groupBox3.Controls.Add(this.chk_price);
            this.groupBox3.Controls.Add(this.chk_barcode);
            this.groupBox3.Font = new System.Drawing.Font("justagain DIN", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(491, 218);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(155, 174);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Current Edit";
            // 
            // chk_barcode
            // 
            this.chk_barcode.Checked = true;
            this.chk_barcode.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel;
            this.chk_barcode.Location = new System.Drawing.Point(16, 23);
            this.chk_barcode.Name = "chk_barcode";
            this.chk_barcode.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.chk_barcode.Size = new System.Drawing.Size(95, 35);
            this.chk_barcode.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.chk_barcode.StateCommon.ShortText.Font = new System.Drawing.Font("justagain DIN", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_barcode.TabIndex = 0;
            this.chk_barcode.Values.Text = "Barcode";
            this.chk_barcode.Click += new System.EventHandler(this.chk_barcode_Click);
            // 
            // chk_price
            // 
            this.chk_price.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel;
            this.chk_price.Location = new System.Drawing.Point(16, 59);
            this.chk_price.Name = "chk_price";
            this.chk_price.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.chk_price.Size = new System.Drawing.Size(69, 35);
            this.chk_price.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.chk_price.StateCommon.ShortText.Font = new System.Drawing.Font("justagain DIN", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_price.TabIndex = 0;
            this.chk_price.Values.Text = "Price";
            this.chk_price.Click += new System.EventHandler(this.chk_price_Click);
            // 
            // chk_item_name
            // 
            this.chk_item_name.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel;
            this.chk_item_name.Location = new System.Drawing.Point(16, 98);
            this.chk_item_name.Name = "chk_item_name";
            this.chk_item_name.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.chk_item_name.Size = new System.Drawing.Size(117, 35);
            this.chk_item_name.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.chk_item_name.StateCommon.ShortText.Font = new System.Drawing.Font("justagain DIN", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_item_name.TabIndex = 0;
            this.chk_item_name.Values.Text = "Item Name";
            this.chk_item_name.Click += new System.EventHandler(this.chk_item_name_Click);
            // 
            // chk_marketName
            // 
            this.chk_marketName.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel;
            this.chk_marketName.Location = new System.Drawing.Point(16, 135);
            this.chk_marketName.Name = "chk_marketName";
            this.chk_marketName.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.chk_marketName.Size = new System.Drawing.Size(128, 35);
            this.chk_marketName.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.chk_marketName.StateCommon.ShortText.Font = new System.Drawing.Font("justagain DIN", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_marketName.TabIndex = 0;
            this.chk_marketName.Values.Text = "Mrket Name";
            this.chk_marketName.Click += new System.EventHandler(this.chk_marketName_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 664);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbEncodeType);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Generate_barcode);
            this.Controls.Add(this.kryptonButton5);
            this.Controls.Add(this.kryptonButton4);
            this.Controls.Add(this.kryptonButton3);
            this.Controls.Add(this.kryptonButton2);
            this.Controls.Add(this.imageBoxEx1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbEncodeType)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbLabelLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbRotateFlip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbBarcodeAlign)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Cyotek.Windows.Forms.Demo.ImageBoxEx imageBoxEx1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton4;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton5;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtData;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Generate_barcode;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbEncodeType;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_bc_H;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_bc_w;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbBarcodeAlign;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private System.Windows.Forms.CheckBox chkGenerateLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbLabelLocation;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbRotateFlip;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private System.Windows.Forms.GroupBox groupBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_market_name;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_item_name;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_price;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel10;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel9;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel13;
        private System.Windows.Forms.GroupBox groupBox3;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton chk_marketName;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton chk_item_name;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton chk_price;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton chk_barcode;
    }
}

