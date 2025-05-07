namespace DamProducer
{
    partial class frmMojodiAvalye
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
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_Tbl_ResidRiz_Tbl_Resid", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn71 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Code_rz");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn72 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Code_resid");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn73 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Code_matter");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn74 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Code_vahed");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn75 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Zarfiat_vahed");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn76 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Tedad");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn78 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Darsad_oft");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn79 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("vaznPor");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn80 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("vaznKhali");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn81 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Tax");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn82 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Price_tamam");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn83 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Price_vahed");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn77 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Takhfif");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("PriceORG");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn84 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("vazn", 0);
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMojodiAvalye));
            this.CmbMater = new Infragistics.Win.UltraWinEditors.UltraComboEditor();
            this.viewMatterBS = new System.Windows.Forms.BindingSource(this.components);
            this.db_DataSetResid = new DamProducer.Dset.db_DataSetResid();
            this.UGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.TblResidRizTblResidBS = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_ResidBS = new System.Windows.Forms.BindingSource(this.components);
            this.bNavigatorResid = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.saveButton = new System.Windows.Forms.ToolStripButton();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ultraLabel2 = new Infragistics.Win.Misc.UltraLabel();
            this.cmbAnbar = new Infragistics.Win.UltraWinEditors.UltraComboEditor();
            this.viewAnbarBS = new System.Windows.Forms.BindingSource(this.components);
            this.ultraLabel9 = new Infragistics.Win.Misc.UltraLabel();
            this.Cdresid = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.ubtnComite = new Infragistics.Win.Misc.UltraButton();
            this.CdCode = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.tbl_ResidTA = new DamProducer.Dset.db_DataSetResidTableAdapters.Tbl_ResidTA();
            this.tbl_ResidRizTA = new DamProducer.Dset.db_DataSetResidTableAdapters.Tbl_ResidRizTA();
            this.view_MatterTA = new DamProducer.Dset.db_DataSetResidTableAdapters.View_MatterTA();
            this.view_AnbarTA = new DamProducer.Dset.db_DataSetResidTableAdapters.View_AnbarTA();
            this.utPreviewDialog = new Infragistics.Win.Printing.UltraPrintPreviewDialog(this.components);
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtDate = new DateControlBT.PDateBox();
            ((System.ComponentModel.ISupportInitialize)(this.CmbMater)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewMatterBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_DataSetResid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TblResidRizTblResidBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_ResidBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bNavigatorResid)).BeginInit();
            this.bNavigatorResid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAnbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewAnbarBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cdresid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CdCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // CmbMater
            // 
            this.CmbMater.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbMater.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.CmbMater.DataSource = this.viewMatterBS;
            this.CmbMater.DisplayMember = "Name_matter";
            this.CmbMater.Location = new System.Drawing.Point(491, 162);
            this.CmbMater.Margin = new System.Windows.Forms.Padding(2);
            this.CmbMater.Name = "CmbMater";
            this.CmbMater.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CmbMater.Size = new System.Drawing.Size(251, 36);
            this.CmbMater.TabIndex = 14;
            this.CmbMater.ValueMember = "Code_matter";
            this.CmbMater.Visible = false;
            // 
            // viewMatterBS
            // 
            this.viewMatterBS.DataMember = "View_Matter";
            this.viewMatterBS.DataSource = this.db_DataSetResid;
            // 
            // db_DataSetResid
            // 
            this.db_DataSetResid.DataSetName = "db_DataSetResid";
            this.db_DataSetResid.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // UGrid
            // 
            this.UGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UGrid.DataSource = this.TblResidRizTblResidBS;
            appearance1.BackColor = System.Drawing.SystemColors.Window;
            appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.UGrid.DisplayLayout.Appearance = appearance1;
            this.UGrid.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn;
            ultraGridColumn71.Header.VisiblePosition = 0;
            ultraGridColumn71.Hidden = true;
            ultraGridColumn72.Header.VisiblePosition = 1;
            ultraGridColumn72.Hidden = true;
            ultraGridColumn73.EditorComponent = this.CmbMater;
            ultraGridColumn73.Header.Caption = "نام کالا";
            ultraGridColumn73.Header.VisiblePosition = 2;
            ultraGridColumn73.Width = 315;
            ultraGridColumn74.Header.Caption = "واحد";
            ultraGridColumn74.Header.VisiblePosition = 3;
            ultraGridColumn74.Hidden = true;
            ultraGridColumn74.Width = 75;
            ultraGridColumn75.Header.Caption = "ظرفیت واحد";
            ultraGridColumn75.Header.VisiblePosition = 4;
            ultraGridColumn75.Hidden = true;
            ultraGridColumn75.Width = 86;
            ultraGridColumn76.Header.Caption = "مقدار/ تعداد";
            ultraGridColumn76.Header.VisiblePosition = 5;
            ultraGridColumn76.Hidden = true;
            ultraGridColumn76.Width = 98;
            ultraGridColumn78.Header.Caption = "درصد افت";
            ultraGridColumn78.Header.VisiblePosition = 11;
            ultraGridColumn78.Hidden = true;
            ultraGridColumn78.Width = 78;
            ultraGridColumn79.Format = "n0";
            ultraGridColumn79.Header.Caption = "وزن (کیلوگرم)";
            ultraGridColumn79.Header.VisiblePosition = 9;
            ultraGridColumn80.Header.VisiblePosition = 10;
            ultraGridColumn80.Hidden = true;
            ultraGridColumn81.Header.Caption = "ارزش افزوده";
            ultraGridColumn81.Header.VisiblePosition = 13;
            ultraGridColumn81.Hidden = true;
            ultraGridColumn81.Width = 104;
            ultraGridColumn82.Format = "n0";
            ultraGridColumn82.Header.Caption = "قیمت تمام شده";
            ultraGridColumn82.Header.VisiblePosition = 12;
            ultraGridColumn82.Hidden = true;
            ultraGridColumn83.Format = "n0";
            ultraGridColumn83.Header.Caption = "قیمت واحد";
            ultraGridColumn83.Header.VisiblePosition = 7;
            ultraGridColumn83.Width = 161;
            ultraGridColumn77.Header.Caption = "تخفیف (%)";
            ultraGridColumn77.Header.VisiblePosition = 8;
            ultraGridColumn77.Hidden = true;
            ultraGridColumn77.Width = 76;
            ultraGridColumn1.Header.VisiblePosition = 14;
            ultraGridColumn1.Hidden = true;
            ultraGridColumn84.Formula = "[Tedad] *  [Zarfiat_vahed]";
            ultraGridColumn84.Header.Caption = "وزن";
            ultraGridColumn84.Header.VisiblePosition = 6;
            ultraGridColumn84.Hidden = true;
            ultraGridColumn84.Width = 100;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn71,
            ultraGridColumn72,
            ultraGridColumn73,
            ultraGridColumn74,
            ultraGridColumn75,
            ultraGridColumn76,
            ultraGridColumn78,
            ultraGridColumn79,
            ultraGridColumn80,
            ultraGridColumn81,
            ultraGridColumn82,
            ultraGridColumn83,
            ultraGridColumn77,
            ultraGridColumn1,
            ultraGridColumn84});
            ultraGridBand1.SummaryFooterCaption = "";
            this.UGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.UGrid.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.UGrid.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.True;
            this.UGrid.DisplayLayout.EmptyRowSettings.ShowEmptyRows = true;
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
            this.UGrid.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.UGrid.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.UGrid.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.UGrid.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            this.UGrid.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted;
            this.UGrid.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
            appearance7.BackColor = System.Drawing.SystemColors.Window;
            this.UGrid.DisplayLayout.Override.CardAreaAppearance = appearance7;
            appearance8.BorderColor = System.Drawing.Color.Silver;
            appearance8.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter;
            this.UGrid.DisplayLayout.Override.CellAppearance = appearance8;
            this.UGrid.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            this.UGrid.DisplayLayout.Override.CellPadding = 0;
            this.UGrid.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow;
            appearance9.BackColor = System.Drawing.SystemColors.Control;
            appearance9.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance9.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
            appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance9.BorderColor = System.Drawing.SystemColors.Window;
            this.UGrid.DisplayLayout.Override.GroupByRowAppearance = appearance9;
            appearance10.TextHAlignAsString = "Center";
            this.UGrid.DisplayLayout.Override.HeaderAppearance = appearance10;
            this.UGrid.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
            appearance11.BackColor = System.Drawing.SystemColors.Info;
            this.UGrid.DisplayLayout.Override.RowAlternateAppearance = appearance11;
            appearance12.BackColor = System.Drawing.SystemColors.Window;
            appearance12.BorderColor = System.Drawing.Color.Silver;
            this.UGrid.DisplayLayout.Override.RowAppearance = appearance12;
            this.UGrid.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.SeparateElement;
            this.UGrid.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex;
            this.UGrid.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.True;
            this.UGrid.DisplayLayout.Override.RowSizing = Infragistics.Win.UltraWinGrid.RowSizing.Fixed;
            this.UGrid.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Single;
            this.UGrid.DisplayLayout.Override.SummaryDisplayArea = ((Infragistics.Win.UltraWinGrid.SummaryDisplayAreas)((Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed | Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.RootRowsFootersOnly)));
            appearance13.BackColor = System.Drawing.SystemColors.ControlLight;
            this.UGrid.DisplayLayout.Override.TemplateAddRowAppearance = appearance13;
            this.UGrid.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.UGrid.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.UGrid.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.UGrid.Location = new System.Drawing.Point(0, 54);
            this.UGrid.Margin = new System.Windows.Forms.Padding(5);
            this.UGrid.Name = "UGrid";
            this.UGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.UGrid.Size = new System.Drawing.Size(795, 365);
            this.UGrid.TabIndex = 3;
            this.UGrid.Text = "موجودی اولیه";
            this.UGrid.InitializeLayout += new Infragistics.Win.UltraWinGrid.InitializeLayoutEventHandler(this.UGrid_InitializeLayout);
            this.UGrid.BeforeRowsDeleted += new Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventHandler(this.UGrid_BeforeRowsDeleted);
            this.UGrid.CellDataError += new Infragistics.Win.UltraWinGrid.CellDataErrorEventHandler(this.UGrid_CellDataError);
            this.UGrid.InitializePrintPreview += new Infragistics.Win.UltraWinGrid.InitializePrintPreviewEventHandler(this.UGrid_InitializePrintPreview);
            this.UGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UGrid_KeyDown);
            // 
            // TblResidRizTblResidBS
            // 
            this.TblResidRizTblResidBS.DataMember = "FK_Tbl_ResidRiz_Tbl_Resid";
            this.TblResidRizTblResidBS.DataSource = this.tbl_ResidBS;
            // 
            // tbl_ResidBS
            // 
            this.tbl_ResidBS.DataMember = "Tbl_Resid";
            this.tbl_ResidBS.DataSource = this.db_DataSetResid;
            // 
            // bNavigatorResid
            // 
            this.bNavigatorResid.AddNewItem = this.toolStripAdd;
            this.bNavigatorResid.BindingSource = this.tbl_ResidBS;
            this.bNavigatorResid.CountItem = this.toolStripLabel1;
            this.bNavigatorResid.CountItemFormat = "از {0}";
            this.bNavigatorResid.DeleteItem = this.toolStripButton2;
            this.bNavigatorResid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bNavigatorResid.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bNavigatorResid.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bNavigatorResid.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bNavigatorResid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.toolStripButton3,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton4,
            this.bindingNavigatorMoveLastItem,
            this.toolStripSeparator3,
            this.toolStripAdd,
            this.toolStripButton2,
            this.saveButton,
            this.printToolStripButton});
            this.bNavigatorResid.Location = new System.Drawing.Point(0, 422);
            this.bNavigatorResid.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bNavigatorResid.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bNavigatorResid.MoveNextItem = this.toolStripButton4;
            this.bNavigatorResid.MovePreviousItem = this.toolStripButton3;
            this.bNavigatorResid.Name = "bNavigatorResid";
            this.bNavigatorResid.Padding = new System.Windows.Forms.Padding(0);
            this.bNavigatorResid.PositionItem = this.toolStripTextBox1;
            this.bNavigatorResid.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.bNavigatorResid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bNavigatorResid.Size = new System.Drawing.Size(799, 55);
            this.bNavigatorResid.TabIndex = 29;
            // 
            // toolStripAdd
            // 
            this.toolStripAdd.Image = ((System.Drawing.Image)(resources.GetObject("toolStripAdd.Image")));
            this.toolStripAdd.Name = "toolStripAdd";
            this.toolStripAdd.RightToLeftAutoMirrorImage = true;
            this.toolStripAdd.Size = new System.Drawing.Size(83, 52);
            this.toolStripAdd.Text = "اضافه کردن";
            this.toolStripAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripAdd.ToolTipText = "درج رکورد جدید";
            this.toolStripAdd.Click += new System.EventHandler(this.toolStripAdd_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(53, 52);
            this.toolStripLabel1.Text = "از {0}";
            this.toolStripLabel1.ToolTipText = "Total number of items";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(48, 52);
            this.toolStripButton2.Text = "حذف";
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton2.ToolTipText = "حذف رکورد جاری";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(46, 52);
            this.bindingNavigatorMoveFirstItem.Text = "اولین";
            this.bindingNavigatorMoveFirstItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(43, 52);
            this.toolStripButton3.Text = "قبلی";
            this.toolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 55);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "Position";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(41, 36);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Current position";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 55);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(47, 52);
            this.toolStripButton4.Text = "بعدی";
            this.toolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(92, 52);
            this.bindingNavigatorMoveLastItem.Text = "آخرین رکورد";
            this.bindingNavigatorMoveLastItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 55);
            // 
            // saveButton
            // 
            this.saveButton.Image = ((System.Drawing.Image)(resources.GetObject("saveButton.Image")));
            this.saveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(88, 52);
            this.saveButton.Text = "ذخیره کردن";
            this.saveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.saveButton.ToolTipText = "ذخیره سازی اطلاعات موجود";
            this.saveButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // printToolStripButton
            // 
            this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
            this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripButton.Name = "printToolStripButton";
            this.printToolStripButton.Size = new System.Drawing.Size(43, 52);
            this.printToolStripButton.Text = "چاپ";
            this.printToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.printToolStripButton.ToolTipText = "چاپ جدول";
            this.printToolStripButton.Click += new System.EventHandler(this.printToolStripButton_Click);
            // 
            // ultraLabel2
            // 
            this.ultraLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraLabel2.Location = new System.Drawing.Point(491, 14);
            this.ultraLabel2.Margin = new System.Windows.Forms.Padding(2);
            this.ultraLabel2.Name = "ultraLabel2";
            this.ultraLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ultraLabel2.Size = new System.Drawing.Size(46, 24);
            this.ultraLabel2.TabIndex = 31;
            this.ultraLabel2.Text = "تاریخ ";
            // 
            // cmbAnbar
            // 
            this.cmbAnbar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbAnbar.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            this.cmbAnbar.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tbl_ResidBS, "Code_anbar", true));
            this.cmbAnbar.DataSource = this.viewAnbarBS;
            this.cmbAnbar.DisplayMember = "Name_anbar";
            this.cmbAnbar.Location = new System.Drawing.Point(557, 9);
            this.cmbAnbar.Margin = new System.Windows.Forms.Padding(2);
            this.cmbAnbar.Name = "cmbAnbar";
            this.cmbAnbar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbAnbar.Size = new System.Drawing.Size(169, 36);
            this.cmbAnbar.TabIndex = 0;
            this.cmbAnbar.ValueMember = "Code_anbar";
            this.cmbAnbar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UGrid_KeyDown);
            // 
            // viewAnbarBS
            // 
            this.viewAnbarBS.DataMember = "View_Anbar";
            this.viewAnbarBS.DataSource = this.db_DataSetResid;
            // 
            // ultraLabel9
            // 
            this.ultraLabel9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraLabel9.Location = new System.Drawing.Point(729, 14);
            this.ultraLabel9.Margin = new System.Windows.Forms.Padding(2);
            this.ultraLabel9.Name = "ultraLabel9";
            this.ultraLabel9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ultraLabel9.Size = new System.Drawing.Size(62, 24);
            this.ultraLabel9.TabIndex = 32;
            this.ultraLabel9.Text = "نام انبار";
            // 
            // Cdresid
            // 
            this.Cdresid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Cdresid.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tbl_ResidBS, "Code_resid", true));
            this.Cdresid.Location = new System.Drawing.Point(258, -400);
            this.Cdresid.Margin = new System.Windows.Forms.Padding(2);
            this.Cdresid.Name = "Cdresid";
            this.Cdresid.ReadOnly = true;
            this.Cdresid.Size = new System.Drawing.Size(62, 38);
            this.Cdresid.TabIndex = 34;
            this.Cdresid.TabStop = false;
            this.Cdresid.ValueChanged += new System.EventHandler(this.Cdresid_ValueChanged);
            // 
            // ubtnComite
            // 
            this.ubtnComite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ubtnComite.Location = new System.Drawing.Point(275, 8);
            this.ubtnComite.Margin = new System.Windows.Forms.Padding(2);
            this.ubtnComite.Name = "ubtnComite";
            this.ubtnComite.Size = new System.Drawing.Size(101, 36);
            this.ubtnComite.TabIndex = 2;
            this.ubtnComite.TabStop = false;
            this.ubtnComite.Text = "تایید";
            this.ubtnComite.Click += new System.EventHandler(this.ubtnComite_Click);
            // 
            // CdCode
            // 
            this.CdCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CdCode.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tbl_ResidBS, "Code_fro", true));
            this.CdCode.Location = new System.Drawing.Point(331, -400);
            this.CdCode.Margin = new System.Windows.Forms.Padding(2);
            this.CdCode.Name = "CdCode";
            this.CdCode.ReadOnly = true;
            this.CdCode.Size = new System.Drawing.Size(61, 38);
            this.CdCode.TabIndex = 36;
            this.CdCode.TabStop = false;
            // 
            // tbl_ResidTA
            // 
            this.tbl_ResidTA.ClearBeforeFill = true;
            // 
            // tbl_ResidRizTA
            // 
            this.tbl_ResidRizTA.ClearBeforeFill = true;
            // 
            // view_MatterTA
            // 
            this.view_MatterTA.ClearBeforeFill = true;
            // 
            // view_AnbarTA
            // 
            this.view_AnbarTA.ClearBeforeFill = true;
            // 
            // utPreviewDialog
            // 
            this.utPreviewDialog.Name = "ultraPrintPreviewDialog1";
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // txtDate
            // 
            this.txtDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDate.Culture = new System.Globalization.CultureInfo("fa-IR");
            this.txtDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_ResidBS, "Date_resid", true));
            this.txtDate.Location = new System.Drawing.Point(403, 9);
            this.txtDate.Margin = new System.Windows.Forms.Padding(2);
            this.txtDate.Mask = "####/##/##";
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(85, 36);
            this.txtDate.TabIndex = 1;
            this.txtDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UGrid_KeyDown);
            // 
            // frmMojodiAvalye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(799, 477);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.CdCode);
            this.Controls.Add(this.ubtnComite);
            this.Controls.Add(this.Cdresid);
            this.Controls.Add(this.cmbAnbar);
            this.Controls.Add(this.ultraLabel9);
            this.Controls.Add(this.ultraLabel2);
            this.Controls.Add(this.bNavigatorResid);
            this.Controls.Add(this.CmbMater);
            this.Controls.Add(this.UGrid);
            this.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmMojodiAvalye";
            this.Text = "موجودی اولیه";
            this.Load += new System.EventHandler(this.frmMojodiAvalye_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMojodiAvalye_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.CmbMater)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewMatterBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_DataSetResid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TblResidRizTblResidBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_ResidBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bNavigatorResid)).EndInit();
            this.bNavigatorResid.ResumeLayout(false);
            this.bNavigatorResid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAnbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewAnbarBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cdresid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CdCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Dset.db_DataSetResid db_DataSetResid;
        private System.Windows.Forms.BindingSource tbl_ResidBS;
        private Dset.db_DataSetResidTableAdapters.Tbl_ResidTA tbl_ResidTA;
        private Infragistics.Win.UltraWinGrid.UltraGrid UGrid;
        private System.Windows.Forms.BindingSource TblResidRizTblResidBS;
        private Dset.db_DataSetResidTableAdapters.Tbl_ResidRizTA tbl_ResidRizTA;
        private Infragistics.Win.UltraWinEditors.UltraComboEditor CmbMater;
        private System.Windows.Forms.BindingSource viewMatterBS;
        private Dset.db_DataSetResidTableAdapters.View_MatterTA view_MatterTA;
        private System.Windows.Forms.BindingNavigator bNavigatorResid;
        private System.Windows.Forms.ToolStripButton toolStripAdd;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton saveButton;
        private Infragistics.Win.Misc.UltraLabel ultraLabel2;
        private Infragistics.Win.UltraWinEditors.UltraComboEditor cmbAnbar;
        private System.Windows.Forms.BindingSource viewAnbarBS;
        private Infragistics.Win.Misc.UltraLabel ultraLabel9;
        private Dset.db_DataSetResidTableAdapters.View_AnbarTA view_AnbarTA;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor Cdresid;
        private Infragistics.Win.Misc.UltraButton ubtnComite;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor CdCode;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private Infragistics.Win.Printing.UltraPrintPreviewDialog utPreviewDialog;
        private System.Windows.Forms.ErrorProvider err;
        private DateControlBT.PDateBox txtDate;
    }
}