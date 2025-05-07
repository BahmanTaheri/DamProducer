namespace DamProducer
{
    partial class frmMojodi
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
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("View_Mojoodi", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn4 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Code_matter");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn31 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Name_matter");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn32 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("vazv");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn33 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("vazk");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn34 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("vazn");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn24 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("select", 0);
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
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
            this.db_DataSetContent = new DamProducer.Dset.db_DataSetContent();
            this.view_MojoodiTA = new DamProducer.Dset.db_DataSetContentTableAdapters.View_MojoodiTA();
            this.btnPay = new Infragistics.Win.Misc.UltraButton();
            this.btnReload = new Infragistics.Win.Misc.UltraButton();
            this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel2 = new Infragistics.Win.Misc.UltraLabel();
            this.commit = new Infragistics.Win.Misc.UltraButton();
            this.UGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.btnPrintExport = new Infragistics.Win.Misc.UltraButton();
            this.txtDate1 = new DateControlBT.PDateBox();
            this.txtDate2 = new DateControlBT.PDateBox();
            ((System.ComponentModel.ISupportInitialize)(this.db_DataSetContent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // db_DataSetContent
            // 
            this.db_DataSetContent.DataSetName = "db_DataSetContent";
            this.db_DataSetContent.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // view_MojoodiTA
            // 
            this.view_MojoodiTA.ClearBeforeFill = true;
            // 
            // btnPay
            // 
            this.btnPay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPay.Location = new System.Drawing.Point(5, 509);
            this.btnPay.Margin = new System.Windows.Forms.Padding(2);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(129, 38);
            this.btnPay.TabIndex = 16;
            this.btnPay.Text = "چاپ";
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnReload
            // 
            this.btnReload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReload.Location = new System.Drawing.Point(271, 509);
            this.btnReload.Margin = new System.Windows.Forms.Padding(2);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(151, 38);
            this.btnReload.TabIndex = 17;
            this.btnReload.Text = "بارگزاری مجدد";
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // ultraLabel1
            // 
            this.ultraLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraLabel1.Location = new System.Drawing.Point(749, 21);
            this.ultraLabel1.Margin = new System.Windows.Forms.Padding(2);
            this.ultraLabel1.Name = "ultraLabel1";
            this.ultraLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ultraLabel1.Size = new System.Drawing.Size(80, 30);
            this.ultraLabel1.TabIndex = 32;
            this.ultraLabel1.Text = "تاریخ پایان";
            // 
            // ultraLabel2
            // 
            this.ultraLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraLabel2.Location = new System.Drawing.Point(960, 21);
            this.ultraLabel2.Margin = new System.Windows.Forms.Padding(2);
            this.ultraLabel2.Name = "ultraLabel2";
            this.ultraLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ultraLabel2.Size = new System.Drawing.Size(80, 30);
            this.ultraLabel2.TabIndex = 33;
            this.ultraLabel2.Text = "تاریخ شروع";
            // 
            // commit
            // 
            this.commit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.commit.Location = new System.Drawing.Point(496, 17);
            this.commit.Margin = new System.Windows.Forms.Padding(2);
            this.commit.Name = "commit";
            this.commit.Size = new System.Drawing.Size(115, 38);
            this.commit.TabIndex = 2;
            this.commit.Text = "تایید";
            this.commit.Click += new System.EventHandler(this.commit_Click);
            // 
            // UGrid
            // 
            this.UGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UGrid.DataMember = "View_Mojoodi";
            this.UGrid.DataSource = this.db_DataSetContent;
            appearance1.BackColor = System.Drawing.SystemColors.Window;
            appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.UGrid.DisplayLayout.Appearance = appearance1;
            this.UGrid.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridColumn4.Header.VisiblePosition = 1;
            ultraGridColumn4.Hidden = true;
            ultraGridColumn31.Header.VisiblePosition = 2;
            ultraGridColumn31.MinWidth = 250;
            ultraGridColumn31.Width = 408;
            ultraGridColumn32.Format = "n0";
            ultraGridColumn32.Header.Caption = "وزن خرید";
            ultraGridColumn32.Header.VisiblePosition = 3;
            ultraGridColumn32.MaxWidth = 175;
            ultraGridColumn32.MinWidth = 165;
            ultraGridColumn32.Width = 175;
            ultraGridColumn33.Format = "n0";
            ultraGridColumn33.Header.Caption = "وزن مصرفی";
            ultraGridColumn33.Header.VisiblePosition = 4;
            ultraGridColumn33.MaxWidth = 175;
            ultraGridColumn33.MinWidth = 165;
            ultraGridColumn33.Width = 175;
            ultraGridColumn34.Format = "n0";
            ultraGridColumn34.Header.VisiblePosition = 5;
            ultraGridColumn34.MaxWidth = 175;
            ultraGridColumn34.MinWidth = 165;
            ultraGridColumn34.Width = 175;
            ultraGridColumn24.DataType = typeof(bool);
            ultraGridColumn24.DefaultCellValue = false;
            ultraGridColumn24.Header.Caption = "انتخاب";
            ultraGridColumn24.Header.VisiblePosition = 0;
            ultraGridColumn24.MaxWidth = 60;
            ultraGridColumn24.MinWidth = 60;
            ultraGridColumn24.Width = 60;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn4,
            ultraGridColumn31,
            ultraGridColumn32,
            ultraGridColumn33,
            ultraGridColumn34,
            ultraGridColumn24});
            this.UGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.UGrid.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.UGrid.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance2.BorderColor = System.Drawing.SystemColors.Window;
            this.UGrid.DisplayLayout.GroupByBox.Appearance = appearance2;
            appearance3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.UGrid.DisplayLayout.GroupByBox.BandLabelAppearance = appearance3;
            this.UGrid.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            appearance4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            appearance4.BackColor2 = System.Drawing.SystemColors.Control;
            appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.UGrid.DisplayLayout.GroupByBox.PromptAppearance = appearance4;
            this.UGrid.DisplayLayout.MaxColScrollRegions = 1;
            this.UGrid.DisplayLayout.MaxRowScrollRegions = 1;
            appearance5.BackColor = System.Drawing.Color.PeachPuff;
            appearance5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.UGrid.DisplayLayout.Override.ActiveCellAppearance = appearance5;
            appearance6.BackColor = System.Drawing.Color.PeachPuff;
            appearance6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.UGrid.DisplayLayout.Override.ActiveRowAppearance = appearance6;
            this.UGrid.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.True;
            this.UGrid.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted;
            this.UGrid.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
            appearance7.BackColor = System.Drawing.SystemColors.Window;
            this.UGrid.DisplayLayout.Override.CardAreaAppearance = appearance7;
            appearance8.BorderColor = System.Drawing.Color.Silver;
            appearance8.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter;
            this.UGrid.DisplayLayout.Override.CellAppearance = appearance8;
            this.UGrid.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            this.UGrid.DisplayLayout.Override.CellPadding = 0;
            this.UGrid.DisplayLayout.Override.FilterOperandStyle = Infragistics.Win.UltraWinGrid.FilterOperandStyle.Edit;
            appearance9.BackColor = System.Drawing.Color.Gainsboro;
            this.UGrid.DisplayLayout.Override.FilterRowAppearance = appearance9;
            this.UGrid.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow;
            appearance10.BackColor = System.Drawing.SystemColors.Control;
            appearance10.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance10.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
            appearance10.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance10.BorderColor = System.Drawing.SystemColors.Window;
            this.UGrid.DisplayLayout.Override.GroupByRowAppearance = appearance10;
            appearance11.TextHAlignAsString = "Center";
            this.UGrid.DisplayLayout.Override.HeaderAppearance = appearance11;
            this.UGrid.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            this.UGrid.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
            appearance12.BackColor = System.Drawing.SystemColors.Info;
            this.UGrid.DisplayLayout.Override.RowAlternateAppearance = appearance12;
            appearance13.BackColor = System.Drawing.SystemColors.Window;
            appearance13.BorderColor = System.Drawing.Color.Silver;
            this.UGrid.DisplayLayout.Override.RowAppearance = appearance13;
            this.UGrid.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.SeparateElement;
            this.UGrid.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex;
            this.UGrid.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.True;
            appearance14.BackColor = System.Drawing.SystemColors.ControlLight;
            this.UGrid.DisplayLayout.Override.TemplateAddRowAppearance = appearance14;
            this.UGrid.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.UGrid.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.UGrid.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand;
            this.UGrid.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.UGrid.Location = new System.Drawing.Point(0, 77);
            this.UGrid.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.UGrid.Name = "UGrid";
            this.UGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.UGrid.Size = new System.Drawing.Size(1044, 425);
            this.UGrid.TabIndex = 34;
            this.UGrid.Text = "مشخصات فردی";
            // 
            // btnPrintExport
            // 
            this.btnPrintExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrintExport.Location = new System.Drawing.Point(138, 509);
            this.btnPrintExport.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrintExport.Name = "btnPrintExport";
            this.btnPrintExport.Size = new System.Drawing.Size(129, 38);
            this.btnPrintExport.TabIndex = 35;
            this.btnPrintExport.Text = "چاپ خروجی";
            this.btnPrintExport.Click += new System.EventHandler(this.btnPrintExport_Click);
            // 
            // txtDate1
            // 
            this.txtDate1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDate1.Culture = new System.Globalization.CultureInfo("fa-IR");
            this.txtDate1.Location = new System.Drawing.Point(850, 15);
            this.txtDate1.Mask = "####/##/##";
            this.txtDate1.Name = "txtDate1";
            this.txtDate1.Size = new System.Drawing.Size(105, 36);
            this.txtDate1.TabIndex = 0;
            this.txtDate1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDate1_KeyDown);
            // 
            // txtDate2
            // 
            this.txtDate2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDate2.Culture = new System.Globalization.CultureInfo("fa-IR");
            this.txtDate2.Location = new System.Drawing.Point(639, 15);
            this.txtDate2.Mask = "####/##/##";
            this.txtDate2.Name = "txtDate2";
            this.txtDate2.Size = new System.Drawing.Size(105, 36);
            this.txtDate2.TabIndex = 1;
            this.txtDate2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDate1_KeyDown);
            // 
            // frmMojodi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1060, 558);
            this.Controls.Add(this.txtDate2);
            this.Controls.Add(this.txtDate1);
            this.Controls.Add(this.btnPrintExport);
            this.Controls.Add(this.UGrid);
            this.Controls.Add(this.ultraLabel1);
            this.Controls.Add(this.ultraLabel2);
            this.Controls.Add(this.commit);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnPay);
            this.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmMojodi";
            this.Text = "موجودی انبار";
            this.Load += new System.EventHandler(this.frmMojodi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db_DataSetContent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Dset.db_DataSetContent db_DataSetContent;
        private Dset.db_DataSetContentTableAdapters.View_MojoodiTA view_MojoodiTA;
        private Infragistics.Win.Misc.UltraButton btnPay;
        private Infragistics.Win.Misc.UltraButton btnReload;
        private Infragistics.Win.Misc.UltraLabel ultraLabel1;
        private Infragistics.Win.Misc.UltraLabel ultraLabel2;
        private Infragistics.Win.Misc.UltraButton commit;
        private Infragistics.Win.UltraWinGrid.UltraGrid UGrid;
        private Infragistics.Win.Misc.UltraButton btnPrintExport;
        private DateControlBT.PDateBox txtDate1;
        private DateControlBT.PDateBox txtDate2;
    }
}