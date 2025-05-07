namespace DamProducer
{
    partial class frmRptKharidKise
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
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("View_Bags", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn15 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Code_BagResid");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn16 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Code_Bag");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn17 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Name_Bag");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn18 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Date", -1, null, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, false);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn19 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Tedad");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn20 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Price");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn21 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Comment");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn22 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("HzHaml");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn23 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("HzTakhlie");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn13 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("PriceKol");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Code_fro");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn2 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("name_fro");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn14 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("select", 0);
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn24 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("PTamam", 1);
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance13 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance14 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance15 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance16 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance17 = new Infragistics.Win.Appearance();
            this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel2 = new Infragistics.Win.Misc.UltraLabel();
            this.btnPrint = new Infragistics.Win.Misc.UltraButton();
            this.btnSearch = new Infragistics.Win.Misc.UltraButton();
            this.UGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.uCalcMgr = new Infragistics.Win.UltraWinCalcManager.UltraCalcManager(this.components);
            this.db_DataSetGTP = new DamProducer.Dset.db_DataSetGTP();
            this.view_BagsTA = new DamProducer.Dset.db_DataSetGTPTableAdapters.View_BagsTA();
            this.ultraLabel3 = new Infragistics.Win.Misc.UltraLabel();
            this.tbl_BagResidTA = new DamProducer.Dset.db_DataSetGTPTableAdapters.Tbl_BagResidTA();
            this.CmbPRS = new Infragistics.Win.UltraWinEditors.UltraComboEditor();
            this.db_DataSetResid = new DamProducer.Dset.db_DataSetResid();
            this.view_PersonTA = new DamProducer.Dset.db_DataSetResidTableAdapters.View_PersonTA();
            this.txtDate2 = new DateControlBT.PDateBox();
            this.txtDate1 = new DateControlBT.PDateBox();
            ((System.ComponentModel.ISupportInitialize)(this.UGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uCalcMgr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_DataSetGTP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbPRS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_DataSetResid)).BeginInit();
            this.SuspendLayout();
            // 
            // ultraLabel1
            // 
            this.ultraLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraLabel1.Location = new System.Drawing.Point(1076, 20);
            this.ultraLabel1.Margin = new System.Windows.Forms.Padding(2);
            this.ultraLabel1.Name = "ultraLabel1";
            this.ultraLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ultraLabel1.Size = new System.Drawing.Size(102, 30);
            this.ultraLabel1.TabIndex = 48;
            this.ultraLabel1.Text = "تاریخ پایان:";
            // 
            // ultraLabel2
            // 
            this.ultraLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraLabel2.Location = new System.Drawing.Point(1294, 20);
            this.ultraLabel2.Margin = new System.Windows.Forms.Padding(2);
            this.ultraLabel2.Name = "ultraLabel2";
            this.ultraLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ultraLabel2.Size = new System.Drawing.Size(116, 30);
            this.ultraLabel2.TabIndex = 49;
            this.ultraLabel2.Text = "تاریخ شروع:";
            // 
            // btnPrint
            // 
            appearance1.Image = global::DamProducer.Properties.Resources.print;
            this.btnPrint.Appearance = appearance1;
            this.btnPrint.ImageSize = new System.Drawing.Size(24, 24);
            this.btnPrint.Location = new System.Drawing.Point(9, 17);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(130, 37);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "چاپ";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnSearch
            // 
            appearance2.Image = global::DamProducer.Properties.Resources.search;
            this.btnSearch.Appearance = appearance2;
            this.btnSearch.ImageSize = new System.Drawing.Size(24, 24);
            this.btnSearch.Location = new System.Drawing.Point(154, 17);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(130, 37);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "جست و جو";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // UGrid
            // 
            this.UGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UGrid.CalcManager = this.uCalcMgr;
            this.UGrid.DataMember = "View_Bags";
            this.UGrid.DataSource = this.db_DataSetGTP;
            appearance3.BackColor = System.Drawing.SystemColors.Window;
            appearance3.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.UGrid.DisplayLayout.Appearance = appearance3;
            this.UGrid.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridColumn15.Header.VisiblePosition = 0;
            ultraGridColumn15.MaxWidth = 65;
            ultraGridColumn15.MinWidth = 65;
            ultraGridColumn15.Width = 65;
            ultraGridColumn16.Header.VisiblePosition = 1;
            ultraGridColumn16.Hidden = true;
            ultraGridColumn17.Header.VisiblePosition = 5;
            ultraGridColumn17.MinLength = 140;
            ultraGridColumn17.Width = 192;
            ultraGridColumn18.Header.VisiblePosition = 2;
            ultraGridColumn18.MaxWidth = 100;
            ultraGridColumn18.Width = 100;
            ultraGridColumn19.Header.VisiblePosition = 7;
            ultraGridColumn19.Width = 93;
            ultraGridColumn20.Header.VisiblePosition = 10;
            ultraGridColumn20.Width = 127;
            ultraGridColumn21.Header.VisiblePosition = 3;
            ultraGridColumn21.Hidden = true;
            ultraGridColumn21.Width = 162;
            ultraGridColumn22.Header.VisiblePosition = 8;
            ultraGridColumn22.Width = 119;
            ultraGridColumn23.Header.VisiblePosition = 9;
            ultraGridColumn23.Width = 129;
            ultraGridColumn13.Header.VisiblePosition = 11;
            ultraGridColumn13.Width = 122;
            ultraGridColumn1.Header.VisiblePosition = 12;
            ultraGridColumn1.Hidden = true;
            ultraGridColumn1.Width = 91;
            ultraGridColumn2.Header.VisiblePosition = 4;
            ultraGridColumn2.Width = 247;
            appearance4.BackColor = System.Drawing.Color.WhiteSmoke;
            ultraGridColumn14.CellAppearance = appearance4;
            ultraGridColumn14.DataType = typeof(bool);
            ultraGridColumn14.DefaultCellValue = false;
            ultraGridColumn14.Header.Caption = "انتخاب";
            ultraGridColumn14.Header.VisiblePosition = 6;
            ultraGridColumn14.Hidden = true;
            ultraGridColumn14.MaxWidth = 55;
            ultraGridColumn14.MinWidth = 55;
            ultraGridColumn14.Width = 55;
            ultraGridColumn24.Format = "n0";
            ultraGridColumn24.Formula = "[PriceKol] /  [Tedad]";
            ultraGridColumn24.Header.Caption = "قیمت تمام شده";
            ultraGridColumn24.Header.VisiblePosition = 13;
            ultraGridColumn24.Width = 155;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn15,
            ultraGridColumn16,
            ultraGridColumn17,
            ultraGridColumn18,
            ultraGridColumn19,
            ultraGridColumn20,
            ultraGridColumn21,
            ultraGridColumn22,
            ultraGridColumn23,
            ultraGridColumn13,
            ultraGridColumn1,
            ultraGridColumn2,
            ultraGridColumn14,
            ultraGridColumn24});
            this.UGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.UGrid.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.UGrid.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            this.UGrid.DisplayLayout.EmptyRowSettings.ShowEmptyRows = true;
            this.UGrid.DisplayLayout.EmptyRowSettings.Style = Infragistics.Win.UltraWinGrid.EmptyRowStyle.ExtendRowSelector;
            appearance5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            appearance5.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance5.BorderColor = System.Drawing.SystemColors.Window;
            this.UGrid.DisplayLayout.GroupByBox.Appearance = appearance5;
            appearance6.ForeColor = System.Drawing.SystemColors.GrayText;
            this.UGrid.DisplayLayout.GroupByBox.BandLabelAppearance = appearance6;
            this.UGrid.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            appearance7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            appearance7.BackColor2 = System.Drawing.SystemColors.Control;
            appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance7.ForeColor = System.Drawing.SystemColors.GrayText;
            this.UGrid.DisplayLayout.GroupByBox.PromptAppearance = appearance7;
            this.UGrid.DisplayLayout.MaxColScrollRegions = 1;
            this.UGrid.DisplayLayout.MaxRowScrollRegions = 1;
            appearance8.BackColor = System.Drawing.Color.PeachPuff;
            appearance8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.UGrid.DisplayLayout.Override.ActiveCellAppearance = appearance8;
            appearance9.BackColor = System.Drawing.Color.PeachPuff;
            appearance9.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.UGrid.DisplayLayout.Override.ActiveRowAppearance = appearance9;
            this.UGrid.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.UGrid.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted;
            this.UGrid.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
            appearance10.BackColor = System.Drawing.SystemColors.Window;
            this.UGrid.DisplayLayout.Override.CardAreaAppearance = appearance10;
            appearance11.BorderColor = System.Drawing.Color.Silver;
            appearance11.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter;
            this.UGrid.DisplayLayout.Override.CellAppearance = appearance11;
            this.UGrid.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            this.UGrid.DisplayLayout.Override.CellPadding = 0;
            this.UGrid.DisplayLayout.Override.FilterOperandStyle = Infragistics.Win.UltraWinGrid.FilterOperandStyle.Edit;
            this.UGrid.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains;
            this.UGrid.DisplayLayout.Override.FilterOperatorLocation = Infragistics.Win.UltraWinGrid.FilterOperatorLocation.Hidden;
            appearance12.BackColor = System.Drawing.Color.Gainsboro;
            this.UGrid.DisplayLayout.Override.FilterRowAppearance = appearance12;
            this.UGrid.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow;
            appearance13.BackColor = System.Drawing.SystemColors.Control;
            appearance13.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance13.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
            appearance13.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance13.BorderColor = System.Drawing.SystemColors.Window;
            this.UGrid.DisplayLayout.Override.GroupByRowAppearance = appearance13;
            appearance14.TextHAlignAsString = "Center";
            this.UGrid.DisplayLayout.Override.HeaderAppearance = appearance14;
            this.UGrid.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            this.UGrid.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
            appearance15.BackColor = System.Drawing.SystemColors.Info;
            this.UGrid.DisplayLayout.Override.RowAlternateAppearance = appearance15;
            appearance16.BackColor = System.Drawing.SystemColors.Window;
            appearance16.BorderColor = System.Drawing.Color.Silver;
            this.UGrid.DisplayLayout.Override.RowAppearance = appearance16;
            this.UGrid.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.SeparateElement;
            this.UGrid.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex;
            this.UGrid.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.True;
            appearance17.BackColor = System.Drawing.SystemColors.ControlLight;
            this.UGrid.DisplayLayout.Override.TemplateAddRowAppearance = appearance17;
            this.UGrid.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.UGrid.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.UGrid.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand;
            this.UGrid.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.UGrid.Location = new System.Drawing.Point(9, 71);
            this.UGrid.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.UGrid.Name = "UGrid";
            this.UGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.UGrid.Size = new System.Drawing.Size(1400, 454);
            this.UGrid.TabIndex = 41;
            this.UGrid.Text = "مشخصات فردی";
            // 
            // uCalcMgr
            // 
            this.uCalcMgr.ContainingControl = this;
            // 
            // db_DataSetGTP
            // 
            this.db_DataSetGTP.DataSetName = "db_DataSetGTP";
            this.db_DataSetGTP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // view_BagsTA
            // 
            this.view_BagsTA.ClearBeforeFill = true;
            // 
            // ultraLabel3
            // 
            this.ultraLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraLabel3.Location = new System.Drawing.Point(859, 20);
            this.ultraLabel3.Margin = new System.Windows.Forms.Padding(2);
            this.ultraLabel3.Name = "ultraLabel3";
            this.ultraLabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ultraLabel3.Size = new System.Drawing.Size(81, 30);
            this.ultraLabel3.TabIndex = 48;
            this.ultraLabel3.Text = "فروشنده:";
            // 
            // tbl_BagResidTA
            // 
            this.tbl_BagResidTA.ClearBeforeFill = true;
            // 
            // CmbPRS
            // 
            this.CmbPRS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbPRS.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            this.CmbPRS.DataMember = "View_Person";
            this.CmbPRS.DataSource = this.db_DataSetResid;
            this.CmbPRS.DisplayMember = "name_fro";
            this.CmbPRS.Location = new System.Drawing.Point(549, 14);
            this.CmbPRS.Margin = new System.Windows.Forms.Padding(2);
            this.CmbPRS.Name = "CmbPRS";
            this.CmbPRS.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CmbPRS.Size = new System.Drawing.Size(306, 36);
            this.CmbPRS.TabIndex = 2;
            this.CmbPRS.ValueMember = "Code_fro";
            // 
            // db_DataSetResid
            // 
            this.db_DataSetResid.DataSetName = "db_DataSetResid";
            this.db_DataSetResid.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // view_PersonTA
            // 
            this.view_PersonTA.ClearBeforeFill = true;
            // 
            // txtDate2
            // 
            this.txtDate2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDate2.Culture = new System.Globalization.CultureInfo("fa-IR");
            this.txtDate2.Location = new System.Drawing.Point(980, 14);
            this.txtDate2.Mask = "####/##/##";
            this.txtDate2.Name = "txtDate2";
            this.txtDate2.Size = new System.Drawing.Size(105, 35);
            this.txtDate2.TabIndex = 1;
            this.txtDate2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDate1_KeyDown);
            // 
            // txtDate1
            // 
            this.txtDate1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDate1.Culture = new System.Globalization.CultureInfo("fa-IR");
            this.txtDate1.Location = new System.Drawing.Point(1205, 14);
            this.txtDate1.Mask = "####/##/##";
            this.txtDate1.Name = "txtDate1";
            this.txtDate1.Size = new System.Drawing.Size(105, 35);
            this.txtDate1.TabIndex = 0;
            this.txtDate1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDate1_KeyDown);
            // 
            // frmRptKharidKise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1424, 531);
            this.Controls.Add(this.txtDate2);
            this.Controls.Add(this.txtDate1);
            this.Controls.Add(this.CmbPRS);
            this.Controls.Add(this.ultraLabel3);
            this.Controls.Add(this.ultraLabel1);
            this.Controls.Add(this.ultraLabel2);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.UGrid);
            this.Font = new System.Drawing.Font("B Nazanin", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmRptKharidKise";
            this.Text = "گزارش خرید کیسه";
            this.Load += new System.EventHandler(this.frmRptKharidKise_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uCalcMgr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_DataSetGTP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbPRS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_DataSetResid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Infragistics.Win.UltraWinGrid.UltraGrid UGrid;
        private Dset.db_DataSetGTP db_DataSetGTP;
        private Dset.db_DataSetGTPTableAdapters.View_BagsTA view_BagsTA;
        private Infragistics.Win.Misc.UltraLabel ultraLabel1;
        private Infragistics.Win.Misc.UltraLabel ultraLabel2;
        private Infragistics.Win.Misc.UltraButton btnPrint;
        private Infragistics.Win.Misc.UltraButton btnSearch;
        private Infragistics.Win.UltraWinCalcManager.UltraCalcManager uCalcMgr;
        private Infragistics.Win.Misc.UltraLabel ultraLabel3;
        private Dset.db_DataSetGTPTableAdapters.Tbl_BagResidTA tbl_BagResidTA;
        private Infragistics.Win.UltraWinEditors.UltraComboEditor CmbPRS;
        private Dset.db_DataSetResid db_DataSetResid;
        private Dset.db_DataSetResidTableAdapters.View_PersonTA view_PersonTA;
        private DateControlBT.PDateBox txtDate2;
        private DateControlBT.PDateBox txtDate1;
    }
}