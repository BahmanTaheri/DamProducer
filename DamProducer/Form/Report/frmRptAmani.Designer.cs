namespace DamProducer
{
    partial class frmRptAmani
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
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("View_Amani", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn13 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("IDFtype");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn14 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FtypeC");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn15 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FCode");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn16 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FDate", -1, null, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, false);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn17 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("TitleMatter");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn20 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Code_fro");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn22 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("name_fro");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn23 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("VKhorooj");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn24 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("VVorood");
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
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
            this.ultraButton1 = new Infragistics.Win.Misc.UltraButton();
            this.btnSearch = new Infragistics.Win.Misc.UltraButton();
            this.UGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.db_DataSetResid = new DamProducer.Dset.db_DataSetResid();
            this.view_AmaniTA = new DamProducer.Dset.db_DataSetResidTableAdapters.View_AmaniTA();
            this.view_PersonTA = new DamProducer.Dset.db_DataSetResidTableAdapters.View_PersonTA();
            this.txtDate1 = new DateControlBT.PDateBox();
            this.txtDate2 = new DateControlBT.PDateBox();
            ((System.ComponentModel.ISupportInitialize)(this.UGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_DataSetResid)).BeginInit();
            this.SuspendLayout();
            // 
            // ultraLabel1
            // 
            this.ultraLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraLabel1.Location = new System.Drawing.Point(907, 38);
            this.ultraLabel1.Margin = new System.Windows.Forms.Padding(2);
            this.ultraLabel1.Name = "ultraLabel1";
            this.ultraLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ultraLabel1.Size = new System.Drawing.Size(80, 33);
            this.ultraLabel1.TabIndex = 65;
            this.ultraLabel1.Text = "تاریخ پایان";
            // 
            // ultraLabel2
            // 
            this.ultraLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraLabel2.Location = new System.Drawing.Point(1097, 38);
            this.ultraLabel2.Margin = new System.Windows.Forms.Padding(2);
            this.ultraLabel2.Name = "ultraLabel2";
            this.ultraLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ultraLabel2.Size = new System.Drawing.Size(80, 32);
            this.ultraLabel2.TabIndex = 66;
            this.ultraLabel2.Text = "تاریخ شروع";
            // 
            // ultraButton1
            // 
            appearance1.Image = global::DamProducer.Properties.Resources.print;
            this.ultraButton1.Appearance = appearance1;
            this.ultraButton1.ImageSize = new System.Drawing.Size(24, 24);
            this.ultraButton1.Location = new System.Drawing.Point(1, 32);
            this.ultraButton1.Margin = new System.Windows.Forms.Padding(2);
            this.ultraButton1.Name = "ultraButton1";
            this.ultraButton1.Size = new System.Drawing.Size(129, 44);
            this.ultraButton1.TabIndex = 62;
            this.ultraButton1.Text = "چاپ";
            this.ultraButton1.Click += new System.EventHandler(this.ultraButton1_Click);
            // 
            // btnSearch
            // 
            appearance2.Image = global::DamProducer.Properties.Resources.search;
            this.btnSearch.Appearance = appearance2;
            this.btnSearch.ImageSize = new System.Drawing.Size(24, 24);
            this.btnSearch.Location = new System.Drawing.Point(134, 32);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(127, 44);
            this.btnSearch.TabIndex = 61;
            this.btnSearch.Text = "جست و جو";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // UGrid
            // 
            this.UGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UGrid.DataMember = "View_Amani";
            this.UGrid.DataSource = this.db_DataSetResid;
            appearance3.BackColor = System.Drawing.SystemColors.Window;
            appearance3.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.UGrid.DisplayLayout.Appearance = appearance3;
            this.UGrid.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridColumn13.Header.VisiblePosition = 0;
            ultraGridColumn13.Hidden = true;
            ultraGridColumn13.Width = 89;
            ultraGridColumn14.Header.VisiblePosition = 1;
            ultraGridColumn14.Width = 97;
            ultraGridColumn15.Header.VisiblePosition = 2;
            ultraGridColumn15.Width = 109;
            ultraGridColumn16.Header.VisiblePosition = 3;
            ultraGridColumn16.Width = 142;
            ultraGridColumn17.Header.VisiblePosition = 4;
            ultraGridColumn17.Width = 242;
            ultraGridColumn20.Header.VisiblePosition = 5;
            ultraGridColumn20.Hidden = true;
            ultraGridColumn20.Width = 108;
            ultraGridColumn22.Header.VisiblePosition = 6;
            ultraGridColumn22.Width = 242;
            ultraGridColumn23.Header.VisiblePosition = 8;
            ultraGridColumn23.Width = 147;
            ultraGridColumn24.Header.VisiblePosition = 7;
            ultraGridColumn24.Width = 146;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn13,
            ultraGridColumn14,
            ultraGridColumn15,
            ultraGridColumn16,
            ultraGridColumn17,
            ultraGridColumn20,
            ultraGridColumn22,
            ultraGridColumn23,
            ultraGridColumn24});
            appearance4.TextHAlignAsString = "Center";
            appearance4.TextVAlignAsString = "Middle";
            ultraGridBand1.Header.Appearance = appearance4;
            ultraGridBand1.Header.TextOrientation = new Infragistics.Win.TextOrientationInfo(0, Infragistics.Win.TextFlowDirection.Horizontal);
            appearance5.BackColor = System.Drawing.Color.Gainsboro;
            ultraGridBand1.Override.SummaryFooterAppearance = appearance5;
            ultraGridBand1.Override.SummaryFooterCaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            ultraGridBand1.SummaryFooterCaption = "";
            this.UGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.UGrid.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.UGrid.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            appearance6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            appearance6.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance6.BorderColor = System.Drawing.SystemColors.Window;
            this.UGrid.DisplayLayout.GroupByBox.Appearance = appearance6;
            appearance7.ForeColor = System.Drawing.SystemColors.GrayText;
            this.UGrid.DisplayLayout.GroupByBox.BandLabelAppearance = appearance7;
            this.UGrid.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            appearance8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            appearance8.BackColor2 = System.Drawing.SystemColors.Control;
            appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance8.ForeColor = System.Drawing.SystemColors.GrayText;
            this.UGrid.DisplayLayout.GroupByBox.PromptAppearance = appearance8;
            this.UGrid.DisplayLayout.MaxColScrollRegions = 1;
            this.UGrid.DisplayLayout.MaxRowScrollRegions = 1;
            appearance9.BackColor = System.Drawing.SystemColors.Window;
            appearance9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.UGrid.DisplayLayout.Override.ActiveCellAppearance = appearance9;
            appearance10.BackColor = System.Drawing.Color.PeachPuff;
            appearance10.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.UGrid.DisplayLayout.Override.ActiveRowAppearance = appearance10;
            this.UGrid.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No;
            this.UGrid.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False;
            this.UGrid.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.True;
            this.UGrid.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.False;
            this.UGrid.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted;
            this.UGrid.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
            appearance11.BackColor = System.Drawing.SystemColors.Window;
            this.UGrid.DisplayLayout.Override.CardAreaAppearance = appearance11;
            appearance12.BorderColor = System.Drawing.Color.Silver;
            appearance12.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter;
            this.UGrid.DisplayLayout.Override.CellAppearance = appearance12;
            this.UGrid.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            this.UGrid.DisplayLayout.Override.CellPadding = 0;
            this.UGrid.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow;
            appearance13.BackColor = System.Drawing.SystemColors.Control;
            appearance13.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance13.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
            appearance13.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance13.BorderColor = System.Drawing.SystemColors.Window;
            this.UGrid.DisplayLayout.Override.GroupByRowAppearance = appearance13;
            appearance14.TextHAlignAsString = "Left";
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
            this.UGrid.DisplayLayout.Override.SummaryDisplayArea = ((Infragistics.Win.UltraWinGrid.SummaryDisplayAreas)((Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed | Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.RootRowsFootersOnly)));
            appearance17.BackColor = System.Drawing.SystemColors.ControlLight;
            this.UGrid.DisplayLayout.Override.TemplateAddRowAppearance = appearance17;
            this.UGrid.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.UGrid.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.UGrid.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand;
            this.UGrid.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.UGrid.Location = new System.Drawing.Point(1, 93);
            this.UGrid.Margin = new System.Windows.Forms.Padding(11, 13, 11, 13);
            this.UGrid.Name = "UGrid";
            this.UGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.UGrid.Size = new System.Drawing.Size(1176, 381);
            this.UGrid.TabIndex = 2;
            this.UGrid.Text = "لیست فروش";
            // 
            // db_DataSetResid
            // 
            this.db_DataSetResid.DataSetName = "db_DataSetResid";
            this.db_DataSetResid.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // view_AmaniTA
            // 
            this.view_AmaniTA.ClearBeforeFill = true;
            // 
            // view_PersonTA
            // 
            this.view_PersonTA.ClearBeforeFill = true;
            // 
            // txtDate1
            // 
            this.txtDate1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDate1.Culture = new System.Globalization.CultureInfo("fa-IR");
            this.txtDate1.Location = new System.Drawing.Point(992, 32);
            this.txtDate1.Mask = "####/##/##";
            this.txtDate1.Name = "txtDate1";
            this.txtDate1.Size = new System.Drawing.Size(105, 35);
            this.txtDate1.TabIndex = 0;
            this.txtDate1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDate2_KeyDown);
            // 
            // txtDate2
            // 
            this.txtDate2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDate2.Culture = new System.Globalization.CultureInfo("fa-IR");
            this.txtDate2.Location = new System.Drawing.Point(811, 32);
            this.txtDate2.Mask = "####/##/##";
            this.txtDate2.Name = "txtDate2";
            this.txtDate2.Size = new System.Drawing.Size(105, 35);
            this.txtDate2.TabIndex = 1;
            this.txtDate2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDate2_KeyDown);
            // 
            // frmRptAmani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1179, 483);
            this.Controls.Add(this.txtDate2);
            this.Controls.Add(this.txtDate1);
            this.Controls.Add(this.ultraLabel1);
            this.Controls.Add(this.ultraLabel2);
            this.Controls.Add(this.ultraButton1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.UGrid);
            this.Font = new System.Drawing.Font("B Nazanin", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmRptAmani";
            this.Text = "گزارش امانی";
            this.Load += new System.EventHandler(this.frmRptAmani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_DataSetResid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Infragistics.Win.Misc.UltraLabel ultraLabel1;
        private Infragistics.Win.Misc.UltraLabel ultraLabel2;
        private Infragistics.Win.Misc.UltraButton ultraButton1;
        private Infragistics.Win.Misc.UltraButton btnSearch;
        private Infragistics.Win.UltraWinGrid.UltraGrid UGrid;
        private Dset.db_DataSetResid db_DataSetResid;
        private Dset.db_DataSetResidTableAdapters.View_AmaniTA view_AmaniTA;
        private Dset.db_DataSetResidTableAdapters.View_PersonTA view_PersonTA;
        private DateControlBT.PDateBox txtDate1;
        private DateControlBT.PDateBox txtDate2;
    }
}