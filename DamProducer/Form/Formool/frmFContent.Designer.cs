namespace DamProducer
{
    partial class frmFContent
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
            Infragistics.Win.Appearance appearance35 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand3 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Tbl_Matter", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn69 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Code_matter");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn70 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Name_matter");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn71 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Point_Stone");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn72 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Tax");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn73 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("en");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn74 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("oft");
            Infragistics.Win.Appearance appearance36 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance37 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance38 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance39 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance40 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance41 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance42 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance43 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance44 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance45 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance46 = new Infragistics.Win.Appearance();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFContent));
            Infragistics.Win.Appearance appearance18 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand2 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Tbl_KolMavad_Tbl_Riz", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn59 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Code_riz");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn60 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Code_kol");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn61 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Code_matter", -1, null, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, false);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn62 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Price_vahed");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn63 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Price_haml");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn64 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Price_takhlie");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn65 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Price_Other");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn66 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Meghdar");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn67 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Price_Takhfif");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn68 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Jam", 0);
            Infragistics.Win.Appearance appearance19 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.SummarySettings summarySettings1 = new Infragistics.Win.UltraWinGrid.SummarySettings("SumVazn", Infragistics.Win.UltraWinGrid.SummaryType.Sum, null, "Meghdar", 7, true, "Tbl_KolMavad_Tbl_Riz", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "Meghdar", 7, true);
            Infragistics.Win.Appearance appearance20 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.SummarySettings summarySettings2 = new Infragistics.Win.UltraWinGrid.SummarySettings("", Infragistics.Win.UltraWinGrid.SummaryType.Formula, "if( [SumVazn()]<=1000 , \"\" , \"مقادیر بیشتر از یک تن میباشد\" )", null, -1, false, null, -1, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "Code_matter", 2, true);
            Infragistics.Win.Appearance appearance21 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.SummarySettings summarySettings3 = new Infragistics.Win.UltraWinGrid.SummarySettings("SumJam", Infragistics.Win.UltraWinGrid.SummaryType.Sum, null, "Jam", 0, false, "Tbl_KolMavad_Tbl_Riz", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "Jam", 0, false);
            Infragistics.Win.Appearance appearance22 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance23 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance24 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance25 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance26 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance27 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance28 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance29 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance30 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance31 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance32 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance33 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance34 = new Infragistics.Win.Appearance();
            Infragistics.Win.ValueListItem valueListItem3 = new Infragistics.Win.ValueListItem();
            Infragistics.Win.ValueListItem valueListItem4 = new Infragistics.Win.ValueListItem();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("View_Kharidar", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn55 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Code_fro");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn56 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("name_fro");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn57 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Addres");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn58 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Code_meli");
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
            this.UComboMatter = new Infragistics.Win.UltraWinGrid.UltraCombo();
            this.uCalcMgr = new Infragistics.Win.UltraWinCalcManager.UltraCalcManager(this.components);
            this.tblMatterBS = new System.Windows.Forms.BindingSource(this.components);
            this.db_DataSetGTP = new DamProducer.Dset.db_DataSetGTP();
            this.bNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.BsTblKolMavad = new System.Windows.Forms.BindingSource(this.components);
            this.db_DataSetContent = new DamProducer.Dset.db_DataSetContent();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.BNavDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.CancelToolButton = new System.Windows.Forms.ToolStripButton();
            this.PrintfmStripButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.mnuPrintTonAll = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrintDarsad = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuPrintTonH = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchStripButton = new System.Windows.Forms.ToolStripButton();
            this.UGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.MnuGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MnuCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.tblKolMavadTblRizBS = new System.Windows.Forms.BindingSource(this.components);
            this.cmbGroup = new Infragistics.Win.UltraWinEditors.UltraComboEditor();
            this.tblGroupBS = new System.Windows.Forms.BindingSource(this.components);
            this.cmbProduct = new Infragistics.Win.UltraWinEditors.UltraComboEditor();
            this.TblProductTblGroupBS = new System.Windows.Forms.BindingSource(this.components);
            this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel3 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel5 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel12 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel11 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel9 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel8 = new Infragistics.Win.Misc.UltraLabel();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.ultraLabel4 = new Infragistics.Win.Misc.UltraLabel();
            this.cmbSefaresh = new Infragistics.Win.UltraWinEditors.UltraComboEditor();
            this.ultraLabel6 = new Infragistics.Win.Misc.UltraLabel();
            this.txtOft = new ArzTextBox.ArzTextBox();
            this.txtTolid = new ArzTextBox.ArzTextBox();
            this.txtOther = new ArzTextBox.ArzTextBox();
            this.txtKise = new ArzTextBox.ArzTextBox();
            this.txtJamKol = new ArzTextBox.ArzTextBox();
            this.ultraLabel7 = new Infragistics.Win.Misc.UltraLabel();
            this.txtVahed = new ArzTextBox.ArzTextBox();
            this.rpt1 = new FastReport.Report();
            this.tbl_KolMavadTA = new DamProducer.Dset.db_DataSetContentTableAdapters.Tbl_KolMavadTA();
            this.tbl_RizTA = new DamProducer.Dset.db_DataSetContentTableAdapters.Tbl_RizTA();
            this.view_KolTA = new DamProducer.Dset.db_DataSetContentTableAdapters.View_KolTA();
            this.view_RizTA = new DamProducer.Dset.db_DataSetContentTableAdapters.View_RizTA();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.ultraLabel2 = new Infragistics.Win.Misc.UltraLabel();
            this.txtTakhfif = new ArzTextBox.ArzTextBox();
            this.btnSave = new Infragistics.Win.Misc.UltraButton();
            this.arzTextBox1 = new ArzTextBox.ArzTextBox();
            this.ultraLabel13 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel14 = new Infragistics.Win.Misc.UltraLabel();
            this.txtDarsad = new System.Windows.Forms.TextBox();
            this.txtProt = new ArzTextBox.ArzTextBox();
            this.ultraLabel15 = new Infragistics.Win.Misc.UltraLabel();
            this.TxtOtherlbl = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.btnRefresh = new Infragistics.Win.Misc.UltraButton();
            this.chkStatus = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            this.txtDarsadKarmozd = new System.Windows.Forms.TextBox();
            this.ultraLabel10 = new Infragistics.Win.Misc.UltraLabel();
            this.tbl_GroupTA = new DamProducer.Dset.db_DataSetGTPTableAdapters.Tbl_GroupTA();
            this.tbl_ProductTA = new DamProducer.Dset.db_DataSetGTPTableAdapters.Tbl_ProductTA();
            this.tbl_MatterTA = new DamProducer.Dset.db_DataSetGTPTableAdapters.Tbl_MatterTA();
            this.txtDate = new DateControlBT.PDateBox();
            this.cmbKharidar = new Infragistics.Win.UltraWinGrid.UltraCombo();
            this.db_DataSetPerson = new DamProducer.Dset.db_DataSetPerson();
            this.view_KharidarTAD = new DamProducer.Dset.db_DataSetPersonTableAdapters.View_KharidarTAD();
            ((System.ComponentModel.ISupportInitialize)(this.UComboMatter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uCalcMgr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMatterBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_DataSetGTP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bNavigator1)).BeginInit();
            this.bNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BsTblKolMavad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_DataSetContent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UGrid)).BeginInit();
            this.MnuGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblKolMavadTblRizBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblGroupBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TblProductTblGroupBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSefaresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpt1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtOtherlbl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbKharidar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_DataSetPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // UComboMatter
            // 
            this.UComboMatter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            appearance1.BackColor2 = System.Drawing.Color.Gainsboro;
            this.UComboMatter.Appearance = appearance1;
            this.UComboMatter.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            this.UComboMatter.AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.Contains;
            this.UComboMatter.CalcManager = this.uCalcMgr;
            this.UComboMatter.DataSource = this.tblMatterBS;
            appearance35.BackColor = System.Drawing.SystemColors.Window;
            appearance35.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.UComboMatter.DisplayLayout.Appearance = appearance35;
            this.UComboMatter.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn;
            ultraGridColumn69.Header.VisiblePosition = 0;
            ultraGridColumn69.Hidden = true;
            ultraGridColumn69.Width = 55;
            ultraGridColumn70.Header.VisiblePosition = 1;
            ultraGridColumn70.MaxLength = 150;
            ultraGridColumn70.MaxWidth = 340;
            ultraGridColumn70.MinWidth = 310;
            ultraGridColumn70.Width = 310;
            ultraGridColumn71.Header.VisiblePosition = 2;
            ultraGridColumn71.Hidden = true;
            ultraGridColumn71.Width = 56;
            ultraGridColumn72.Header.VisiblePosition = 3;
            ultraGridColumn72.Hidden = true;
            ultraGridColumn72.Width = 25;
            ultraGridColumn73.Header.VisiblePosition = 4;
            ultraGridColumn73.Hidden = true;
            ultraGridColumn73.Width = 23;
            ultraGridColumn74.Header.VisiblePosition = 5;
            ultraGridColumn74.Hidden = true;
            ultraGridColumn74.Width = 44;
            ultraGridBand3.Columns.AddRange(new object[] {
            ultraGridColumn69,
            ultraGridColumn70,
            ultraGridColumn71,
            ultraGridColumn72,
            ultraGridColumn73,
            ultraGridColumn74});
            this.UComboMatter.DisplayLayout.BandsSerializer.Add(ultraGridBand3);
            this.UComboMatter.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.UComboMatter.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            appearance36.BackColor = System.Drawing.SystemColors.ActiveBorder;
            appearance36.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance36.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance36.BorderColor = System.Drawing.SystemColors.Window;
            this.UComboMatter.DisplayLayout.GroupByBox.Appearance = appearance36;
            appearance37.ForeColor = System.Drawing.SystemColors.GrayText;
            this.UComboMatter.DisplayLayout.GroupByBox.BandLabelAppearance = appearance37;
            this.UComboMatter.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            appearance38.BackColor = System.Drawing.SystemColors.ControlLightLight;
            appearance38.BackColor2 = System.Drawing.SystemColors.Control;
            appearance38.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance38.ForeColor = System.Drawing.SystemColors.GrayText;
            this.UComboMatter.DisplayLayout.GroupByBox.PromptAppearance = appearance38;
            this.UComboMatter.DisplayLayout.MaxColScrollRegions = 1;
            this.UComboMatter.DisplayLayout.MaxRowScrollRegions = 1;
            appearance39.BackColor = System.Drawing.SystemColors.Window;
            appearance39.ForeColor = System.Drawing.SystemColors.ControlText;
            this.UComboMatter.DisplayLayout.Override.ActiveCellAppearance = appearance39;
            appearance40.BackColor = System.Drawing.SystemColors.Highlight;
            appearance40.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.UComboMatter.DisplayLayout.Override.ActiveRowAppearance = appearance40;
            this.UComboMatter.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted;
            this.UComboMatter.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
            appearance41.BackColor = System.Drawing.SystemColors.Window;
            this.UComboMatter.DisplayLayout.Override.CardAreaAppearance = appearance41;
            appearance42.BorderColor = System.Drawing.Color.Silver;
            appearance42.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter;
            this.UComboMatter.DisplayLayout.Override.CellAppearance = appearance42;
            this.UComboMatter.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            this.UComboMatter.DisplayLayout.Override.CellPadding = 0;
            appearance43.BackColor = System.Drawing.SystemColors.Control;
            appearance43.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance43.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
            appearance43.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance43.BorderColor = System.Drawing.SystemColors.Window;
            this.UComboMatter.DisplayLayout.Override.GroupByRowAppearance = appearance43;
            appearance44.TextHAlignAsString = "Left";
            this.UComboMatter.DisplayLayout.Override.HeaderAppearance = appearance44;
            this.UComboMatter.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            this.UComboMatter.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
            appearance45.BackColor = System.Drawing.Color.WhiteSmoke;
            appearance45.BorderColor = System.Drawing.Color.Silver;
            this.UComboMatter.DisplayLayout.Override.RowAppearance = appearance45;
            this.UComboMatter.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            appearance46.BackColor = System.Drawing.SystemColors.ControlLight;
            this.UComboMatter.DisplayLayout.Override.TemplateAddRowAppearance = appearance46;
            this.UComboMatter.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.UComboMatter.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.UComboMatter.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.UComboMatter.DisplayMember = "Name_matter";
            this.UComboMatter.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.UComboMatter.Location = new System.Drawing.Point(770, 207);
            this.UComboMatter.Margin = new System.Windows.Forms.Padding(2);
            this.UComboMatter.Name = "UComboMatter";
            this.UComboMatter.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.UComboMatter.Size = new System.Drawing.Size(398, 47);
            this.UComboMatter.TabIndex = 7;
            this.UComboMatter.TabStop = false;
            this.UComboMatter.ValueMember = "Code_matter";
            this.UComboMatter.Visible = false;
            this.UComboMatter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCode_KeyDown);
            // 
            // uCalcMgr
            // 
            this.uCalcMgr.ContainingControl = this;
            // 
            // tblMatterBS
            // 
            this.tblMatterBS.DataMember = "Tbl_Matter";
            this.tblMatterBS.DataSource = this.db_DataSetGTP;
            // 
            // db_DataSetGTP
            // 
            this.db_DataSetGTP.DataSetName = "db_DataSetGTP";
            this.db_DataSetGTP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bNavigator1
            // 
            this.bNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bNavigator1.BindingSource = this.BsTblKolMavad;
            this.bNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bNavigator1.CountItemFormat = "از {0}";
            this.bNavigator1.DeleteItem = null;
            this.bNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bNavigator1.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bNavigator1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.BNavDeleteItem,
            this.saveToolStripButton,
            this.toolStripSeparator1,
            this.CancelToolButton,
            this.PrintfmStripButton,
            this.SearchStripButton});
            this.bNavigator1.Location = new System.Drawing.Point(0, 524);
            this.bNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bNavigator1.Name = "bNavigator1";
            this.bNavigator1.Padding = new System.Windows.Forms.Padding(0);
            this.bNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bNavigator1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.bNavigator1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bNavigator1.Size = new System.Drawing.Size(1242, 62);
            this.bNavigator1.TabIndex = 11;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(104, 59);
            this.bindingNavigatorAddNewItem.Text = "اضافه کردن";
            this.bindingNavigatorAddNewItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bindingNavigatorAddNewItem.ToolTipText = "درج فرمول جدید";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // BsTblKolMavad
            // 
            this.BsTblKolMavad.DataMember = "Tbl_KolMavad";
            this.BsTblKolMavad.DataSource = this.db_DataSetContent;
            // 
            // db_DataSetContent
            // 
            this.db_DataSetContent.DataSetName = "db_DataSetContent";
            this.db_DataSetContent.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(66, 59);
            this.bindingNavigatorCountItem.Text = "از {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(106, 59);
            this.bindingNavigatorMoveFirstItem.Text = "اولین رکورد";
            this.bindingNavigatorMoveFirstItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(53, 59);
            this.bindingNavigatorMovePreviousItem.Text = "قبلی";
            this.bindingNavigatorMovePreviousItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 62);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 36);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 62);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(58, 59);
            this.bindingNavigatorMoveNextItem.Text = "بعدی";
            this.bindingNavigatorMoveNextItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(115, 59);
            this.bindingNavigatorMoveLastItem.Text = "آخرین رکورد";
            this.bindingNavigatorMoveLastItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 62);
            // 
            // BNavDeleteItem
            // 
            this.BNavDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("BNavDeleteItem.Image")));
            this.BNavDeleteItem.Name = "BNavDeleteItem";
            this.BNavDeleteItem.RightToLeftAutoMirrorImage = true;
            this.BNavDeleteItem.Size = new System.Drawing.Size(58, 59);
            this.BNavDeleteItem.Text = "حذف";
            this.BNavDeleteItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BNavDeleteItem.ToolTipText = "حذف رکورد جاری";
            this.BNavDeleteItem.Click += new System.EventHandler(this.BNavDeleteItem_Click);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(110, 59);
            this.saveToolStripButton.Text = "ذخیره کردن";
            this.saveToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.saveToolStripButton.ToolTipText = "ذخیره سازی اطلاعات موجود";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 62);
            // 
            // CancelToolButton
            // 
            this.CancelToolButton.Image = ((System.Drawing.Image)(resources.GetObject("CancelToolButton.Image")));
            this.CancelToolButton.Name = "CancelToolButton";
            this.CancelToolButton.RightToLeftAutoMirrorImage = true;
            this.CancelToolButton.Size = new System.Drawing.Size(70, 59);
            this.CancelToolButton.Text = "انصراف";
            this.CancelToolButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CancelToolButton.ToolTipText = "حذف رکورد جاری";
            this.CancelToolButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // PrintfmStripButton
            // 
            this.PrintfmStripButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPrintTonAll,
            this.mnuPrintDarsad,
            this.MnuPrintTonH});
            this.PrintfmStripButton.Image = ((System.Drawing.Image)(resources.GetObject("PrintfmStripButton.Image")));
            this.PrintfmStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PrintfmStripButton.Name = "PrintfmStripButton";
            this.PrintfmStripButton.Size = new System.Drawing.Size(114, 59);
            this.PrintfmStripButton.Text = "چاپ فرمول";
            this.PrintfmStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.PrintfmStripButton.ToolTipText = "چاپ جدول";
            // 
            // mnuPrintTonAll
            // 
            this.mnuPrintTonAll.Name = "mnuPrintTonAll";
            this.mnuPrintTonAll.Size = new System.Drawing.Size(207, 40);
            this.mnuPrintTonAll.Text = "براساس وزن";
            this.mnuPrintTonAll.Click += new System.EventHandler(this.mnuPrintTon_Click);
            // 
            // mnuPrintDarsad
            // 
            this.mnuPrintDarsad.Name = "mnuPrintDarsad";
            this.mnuPrintDarsad.Size = new System.Drawing.Size(207, 40);
            this.mnuPrintDarsad.Text = "براساس درصد";
            this.mnuPrintDarsad.Click += new System.EventHandler(this.mnuPrintDarsad_Click);
            // 
            // MnuPrintTonH
            // 
            this.MnuPrintTonH.Name = "MnuPrintTonH";
            this.MnuPrintTonH.Size = new System.Drawing.Size(207, 40);
            this.MnuPrintTonH.Text = "براساس تن";
            this.MnuPrintTonH.Click += new System.EventHandler(this.MnuPrintTonH_Click);
            // 
            // SearchStripButton
            // 
            this.SearchStripButton.Image = global::DamProducer.Properties.Resources.search;
            this.SearchStripButton.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.SearchStripButton.Name = "SearchStripButton";
            this.SearchStripButton.Size = new System.Drawing.Size(104, 59);
            this.SearchStripButton.Text = "جست و جو";
            this.SearchStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.SearchStripButton.ToolTipText = "جست و جو فرمولها";
            this.SearchStripButton.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // UGrid
            // 
            this.UGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UGrid.CalcManager = this.uCalcMgr;
            this.UGrid.ContextMenuStrip = this.MnuGrid;
            this.UGrid.DataSource = this.tblKolMavadTblRizBS;
            appearance18.BackColor = System.Drawing.SystemColors.Window;
            appearance18.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.UGrid.DisplayLayout.Appearance = appearance18;
            this.UGrid.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridColumn59.Header.VisiblePosition = 0;
            ultraGridColumn59.Hidden = true;
            ultraGridColumn60.Header.VisiblePosition = 1;
            ultraGridColumn60.Hidden = true;
            ultraGridColumn61.EditorComponent = this.UComboMatter;
            ultraGridColumn61.Header.Caption = "نام ماده";
            ultraGridColumn61.Header.VisiblePosition = 2;
            ultraGridColumn61.Width = 289;
            ultraGridColumn62.Format = "n0";
            ultraGridColumn62.Header.Caption = "قیمت واحد";
            ultraGridColumn62.Header.VisiblePosition = 3;
            ultraGridColumn62.Width = 116;
            ultraGridColumn63.Format = "n0";
            ultraGridColumn63.Header.Caption = "هزینه حمل";
            ultraGridColumn63.Header.VisiblePosition = 4;
            ultraGridColumn63.Width = 111;
            ultraGridColumn64.Format = "n0";
            ultraGridColumn64.Header.Caption = "هزینه تخلیه";
            ultraGridColumn64.Header.VisiblePosition = 5;
            ultraGridColumn64.Width = 134;
            ultraGridColumn65.Format = "n0";
            ultraGridColumn65.Header.Caption = "ارزش افزوده";
            ultraGridColumn65.Header.VisiblePosition = 6;
            ultraGridColumn65.Width = 124;
            ultraGridColumn66.Format = "###.###";
            ultraGridColumn66.Header.Caption = "مقدار";
            ultraGridColumn66.Header.VisiblePosition = 8;
            ultraGridColumn66.Width = 109;
            ultraGridColumn67.Header.Caption = "تخفیف";
            ultraGridColumn67.Header.VisiblePosition = 7;
            ultraGridColumn67.Width = 103;
            ultraGridColumn68.Format = "n0";
            ultraGridColumn68.Formula = "(  [Price_haml] +  [Price_takhlie] +  [Price_vahed]+ [Price_Other] -  [Price_Takh" +
    "fif] ) *  [Meghdar]";
            ultraGridColumn68.Header.Caption = "جمع";
            ultraGridColumn68.Header.VisiblePosition = 9;
            ultraGridColumn68.Width = 155;
            ultraGridBand2.Columns.AddRange(new object[] {
            ultraGridColumn59,
            ultraGridColumn60,
            ultraGridColumn61,
            ultraGridColumn62,
            ultraGridColumn63,
            ultraGridColumn64,
            ultraGridColumn65,
            ultraGridColumn66,
            ultraGridColumn67,
            ultraGridColumn68});
            ultraGridBand2.Override.AllowMultiCellOperations = ((Infragistics.Win.UltraWinGrid.AllowMultiCellOperation)((((Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.Copy | Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.Delete) 
            | Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.Paste) 
            | Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.Undo)));
            appearance19.BackColor = System.Drawing.Color.LightGray;
            ultraGridBand2.Override.SummaryFooterAppearance = appearance19;
            ultraGridBand2.Override.SummaryFooterCaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            summarySettings1.DisplayFormat = "{0:###.###}";
            summarySettings1.GroupBySummaryValueAppearance = appearance20;
            summarySettings1.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed;
            summarySettings2.DisplayFormat = "{0}";
            summarySettings2.GroupBySummaryValueAppearance = appearance21;
            summarySettings2.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed;
            summarySettings3.DisplayFormat = "{0:n0}";
            summarySettings3.GroupBySummaryValueAppearance = appearance22;
            summarySettings3.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed;
            ultraGridBand2.Summaries.AddRange(new Infragistics.Win.UltraWinGrid.SummarySettings[] {
            summarySettings1,
            summarySettings2,
            summarySettings3});
            ultraGridBand2.SummaryFooterCaption = "";
            this.UGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand2);
            this.UGrid.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.UGrid.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            appearance23.BackColor = System.Drawing.SystemColors.ActiveBorder;
            appearance23.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance23.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance23.BorderColor = System.Drawing.SystemColors.Window;
            this.UGrid.DisplayLayout.GroupByBox.Appearance = appearance23;
            appearance24.ForeColor = System.Drawing.SystemColors.GrayText;
            this.UGrid.DisplayLayout.GroupByBox.BandLabelAppearance = appearance24;
            this.UGrid.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.UGrid.DisplayLayout.GroupByBox.Hidden = true;
            this.UGrid.DisplayLayout.GroupByBox.Prompt = " ";
            appearance25.BackColor = System.Drawing.SystemColors.ControlLightLight;
            appearance25.BackColor2 = System.Drawing.SystemColors.Control;
            appearance25.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance25.ForeColor = System.Drawing.SystemColors.GrayText;
            this.UGrid.DisplayLayout.GroupByBox.PromptAppearance = appearance25;
            this.UGrid.DisplayLayout.MaxColScrollRegions = 1;
            this.UGrid.DisplayLayout.MaxRowScrollRegions = 1;
            appearance26.BackColor = System.Drawing.Color.PeachPuff;
            appearance26.ForeColor = System.Drawing.Color.Black;
            this.UGrid.DisplayLayout.Override.ActiveCellAppearance = appearance26;
            appearance27.BackColor = System.Drawing.Color.Cornsilk;
            this.UGrid.DisplayLayout.Override.AddRowAppearance = appearance27;
            this.UGrid.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.UGrid.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.UGrid.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            this.UGrid.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted;
            this.UGrid.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
            appearance28.BackColor = System.Drawing.SystemColors.Window;
            this.UGrid.DisplayLayout.Override.CardAreaAppearance = appearance28;
            appearance29.BorderColor = System.Drawing.Color.Silver;
            appearance29.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter;
            this.UGrid.DisplayLayout.Override.CellAppearance = appearance29;
            this.UGrid.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            this.UGrid.DisplayLayout.Override.CellPadding = 0;
            appearance30.BackColor = System.Drawing.SystemColors.Control;
            appearance30.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance30.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
            appearance30.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance30.BorderColor = System.Drawing.SystemColors.Window;
            this.UGrid.DisplayLayout.Override.GroupByRowAppearance = appearance30;
            appearance31.TextHAlignAsString = "Center";
            this.UGrid.DisplayLayout.Override.HeaderAppearance = appearance31;
            this.UGrid.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            this.UGrid.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
            appearance32.BackColor = System.Drawing.SystemColors.Info;
            this.UGrid.DisplayLayout.Override.RowAlternateAppearance = appearance32;
            appearance33.BorderColor = System.Drawing.Color.Silver;
            this.UGrid.DisplayLayout.Override.RowAppearance = appearance33;
            this.UGrid.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.SeparateElement;
            this.UGrid.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex;
            this.UGrid.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.True;
            appearance34.BackColor = System.Drawing.SystemColors.ControlLight;
            this.UGrid.DisplayLayout.Override.TemplateAddRowAppearance = appearance34;
            this.UGrid.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.UGrid.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.UGrid.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand;
            this.UGrid.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.UGrid.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.UGrid.Location = new System.Drawing.Point(5, 154);
            this.UGrid.Margin = new System.Windows.Forms.Padding(6);
            this.UGrid.Name = "UGrid";
            this.UGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.UGrid.Size = new System.Drawing.Size(1222, 219);
            this.UGrid.TabIndex = 7;
            this.UGrid.Text = "مواد تشکیل دهنده";
            this.UGrid.AfterCellUpdate += new Infragistics.Win.UltraWinGrid.CellEventHandler(this.UGrid_AfterCellUpdate);
            this.UGrid.CellDataError += new Infragistics.Win.UltraWinGrid.CellDataErrorEventHandler(this.UGrid_CellDataError);
            this.UGrid.SummaryValueChanged += new Infragistics.Win.UltraWinGrid.SummaryValueChangedEventHandler(this.UGrid_SummaryValueChanged);
            this.UGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UGrid_KeyDown);
            // 
            // MnuGrid
            // 
            this.MnuGrid.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MnuGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuCopy,
            this.MnuPaste});
            this.MnuGrid.Name = "MnuGrid";
            this.MnuGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MnuGrid.Size = new System.Drawing.Size(171, 52);
            // 
            // MnuCopy
            // 
            this.MnuCopy.Name = "MnuCopy";
            this.MnuCopy.ShortcutKeys = System.Windows.Forms.Keys.F7;
            this.MnuCopy.Size = new System.Drawing.Size(170, 24);
            this.MnuCopy.Text = "کپی برداری";
            this.MnuCopy.Click += new System.EventHandler(this.MnuCopy_Click);
            // 
            // MnuPaste
            // 
            this.MnuPaste.Name = "MnuPaste";
            this.MnuPaste.ShortcutKeys = System.Windows.Forms.Keys.F8;
            this.MnuPaste.Size = new System.Drawing.Size(170, 24);
            this.MnuPaste.Text = "چسباندن";
            this.MnuPaste.Click += new System.EventHandler(this.MnuPaste_Click);
            // 
            // tblKolMavadTblRizBS
            // 
            this.tblKolMavadTblRizBS.DataMember = "Tbl_KolMavad_Tbl_Riz";
            this.tblKolMavadTblRizBS.DataSource = this.BsTblKolMavad;
            // 
            // cmbGroup
            // 
            this.cmbGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbGroup.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            this.cmbGroup.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.BsTblKolMavad, "Code_group", true));
            this.cmbGroup.DataSource = this.tblGroupBS;
            this.cmbGroup.DisplayMember = "Name_group";
            this.cmbGroup.Location = new System.Drawing.Point(939, 55);
            this.cmbGroup.Name = "cmbGroup";
            this.cmbGroup.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbGroup.Size = new System.Drawing.Size(165, 43);
            this.cmbGroup.TabIndex = 2;
            this.cmbGroup.ValueMember = "Code_group";
            this.cmbGroup.ValueChanged += new System.EventHandler(this.cmbGroup_ValueChanged);
            this.cmbGroup.Enter += new System.EventHandler(this.cmbType_Enter);
            this.cmbGroup.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCode_KeyDown);
            this.cmbGroup.Leave += new System.EventHandler(this.cmbType_Leave);
            // 
            // tblGroupBS
            // 
            this.tblGroupBS.DataMember = "Tbl_Group";
            this.tblGroupBS.DataSource = this.db_DataSetGTP;
            // 
            // cmbProduct
            // 
            this.cmbProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbProduct.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            this.cmbProduct.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.BsTblKolMavad, "Code_Product", true));
            this.cmbProduct.DataSource = this.TblProductTblGroupBS;
            this.cmbProduct.DisplayMember = "Name_product";
            this.cmbProduct.Location = new System.Drawing.Point(554, 52);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbProduct.Size = new System.Drawing.Size(254, 43);
            this.cmbProduct.TabIndex = 3;
            this.cmbProduct.ValueMember = "Code_product";
            this.cmbProduct.Enter += new System.EventHandler(this.cmbType_Enter);
            this.cmbProduct.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCode_KeyDown);
            this.cmbProduct.Leave += new System.EventHandler(this.cmbType_Leave);
            // 
            // TblProductTblGroupBS
            // 
            this.TblProductTblGroupBS.DataMember = "FK_Tbl_Product_Tbl_Group";
            this.TblProductTblGroupBS.DataSource = this.tblGroupBS;
            // 
            // ultraLabel1
            // 
            this.ultraLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraLabel1.Location = new System.Drawing.Point(1110, 58);
            this.ultraLabel1.Name = "ultraLabel1";
            this.ultraLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ultraLabel1.Size = new System.Drawing.Size(113, 39);
            this.ultraLabel1.TabIndex = 40;
            this.ultraLabel1.Text = "گروه محصول";
            // 
            // ultraLabel3
            // 
            this.ultraLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraLabel3.Location = new System.Drawing.Point(814, 55);
            this.ultraLabel3.Name = "ultraLabel3";
            this.ultraLabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ultraLabel3.Size = new System.Drawing.Size(81, 30);
            this.ultraLabel3.TabIndex = 40;
            this.ultraLabel3.Text = "نوع تولید";
            // 
            // ultraLabel5
            // 
            this.ultraLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraLabel5.Location = new System.Drawing.Point(1130, 11);
            this.ultraLabel5.Name = "ultraLabel5";
            this.ultraLabel5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ultraLabel5.Size = new System.Drawing.Size(59, 39);
            this.ultraLabel5.TabIndex = 42;
            this.ultraLabel5.Text = "تاریخ";
            // 
            // ultraLabel12
            // 
            this.ultraLabel12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraLabel12.Location = new System.Drawing.Point(726, 391);
            this.ultraLabel12.Margin = new System.Windows.Forms.Padding(2);
            this.ultraLabel12.Name = "ultraLabel12";
            this.ultraLabel12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ultraLabel12.Size = new System.Drawing.Size(81, 30);
            this.ultraLabel12.TabIndex = 50;
            this.ultraLabel12.Text = "جمع کل";
            // 
            // ultraLabel11
            // 
            this.ultraLabel11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraLabel11.Location = new System.Drawing.Point(937, 436);
            this.ultraLabel11.Margin = new System.Windows.Forms.Padding(2);
            this.ultraLabel11.Name = "ultraLabel11";
            this.ultraLabel11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ultraLabel11.Size = new System.Drawing.Size(81, 30);
            this.ultraLabel11.TabIndex = 51;
            this.ultraLabel11.Text = "هزینه کیسه";
            // 
            // ultraLabel9
            // 
            this.ultraLabel9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraLabel9.Location = new System.Drawing.Point(937, 391);
            this.ultraLabel9.Margin = new System.Windows.Forms.Padding(2);
            this.ultraLabel9.Name = "ultraLabel9";
            this.ultraLabel9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ultraLabel9.Size = new System.Drawing.Size(92, 30);
            this.ultraLabel9.TabIndex = 53;
            this.ultraLabel9.Text = "هزینه تولید";
            // 
            // ultraLabel8
            // 
            this.ultraLabel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraLabel8.Location = new System.Drawing.Point(1154, 436);
            this.ultraLabel8.Margin = new System.Windows.Forms.Padding(2);
            this.ultraLabel8.Name = "ultraLabel8";
            this.ultraLabel8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ultraLabel8.Size = new System.Drawing.Size(56, 30);
            this.ultraLabel8.TabIndex = 54;
            this.ultraLabel8.Text = "افت";
            // 
            // err
            // 
            this.err.BlinkRate = 300;
            this.err.ContainerControl = this;
            this.err.RightToLeft = true;
            // 
            // ultraLabel4
            // 
            this.ultraLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraLabel4.Location = new System.Drawing.Point(812, 109);
            this.ultraLabel4.Margin = new System.Windows.Forms.Padding(2);
            this.ultraLabel4.Name = "ultraLabel4";
            this.ultraLabel4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ultraLabel4.Size = new System.Drawing.Size(90, 30);
            this.ultraLabel4.TabIndex = 63;
            this.ultraLabel4.Text = "نام خریدار";
            // 
            // cmbSefaresh
            // 
            this.cmbSefaresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSefaresh.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            this.cmbSefaresh.AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.Contains;
            this.cmbSefaresh.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.BsTblKolMavad, "Type", true));
            valueListItem3.DataValue = ((short)(0));
            valueListItem3.DisplayText = "بر اساس فرمول شرکت";
            valueListItem4.DataValue = ((short)(1));
            valueListItem4.DisplayText = "بر اساس سفارش مشتری";
            this.cmbSefaresh.Items.AddRange(new Infragistics.Win.ValueListItem[] {
            valueListItem3,
            valueListItem4});
            this.cmbSefaresh.Location = new System.Drawing.Point(939, 103);
            this.cmbSefaresh.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSefaresh.Name = "cmbSefaresh";
            this.cmbSefaresh.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbSefaresh.Size = new System.Drawing.Size(165, 43);
            this.cmbSefaresh.TabIndex = 4;
            this.cmbSefaresh.ValueChanged += new System.EventHandler(this.cmbSefaresh_ValueChanged);
            this.cmbSefaresh.Enter += new System.EventHandler(this.cmbType_Enter);
            this.cmbSefaresh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCode_KeyDown);
            this.cmbSefaresh.Leave += new System.EventHandler(this.cmbType_Leave);
            // 
            // ultraLabel6
            // 
            this.ultraLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraLabel6.Location = new System.Drawing.Point(1108, 103);
            this.ultraLabel6.Margin = new System.Windows.Forms.Padding(2);
            this.ultraLabel6.Name = "ultraLabel6";
            this.ultraLabel6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ultraLabel6.Size = new System.Drawing.Size(108, 39);
            this.ultraLabel6.TabIndex = 66;
            this.ultraLabel6.Text = "نوع سفارش";
            // 
            // txtOft
            // 
            this.txtOft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOft.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsTblKolMavad, "Oft_Tolid", true));
            this.txtOft.Location = new System.Drawing.Point(1023, 430);
            this.txtOft.Name = "txtOft";
            this.txtOft.Size = new System.Drawing.Size(126, 43);
            this.txtOft.TabIndex = 13;
            this.txtOft.Enter += new System.EventHandler(this.txtOft_Enter);
            this.txtOft.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCode_KeyDown);
            this.txtOft.Leave += new System.EventHandler(this.txtOft_Leave);
            // 
            // txtTolid
            // 
            this.txtTolid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTolid.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsTblKolMavad, "Hazine_Tolid", true));
            this.txtTolid.Location = new System.Drawing.Point(807, 385);
            this.txtTolid.Name = "txtTolid";
            this.txtTolid.Size = new System.Drawing.Size(125, 43);
            this.txtTolid.TabIndex = 9;
            this.txtTolid.Enter += new System.EventHandler(this.txtOft_Enter);
            this.txtTolid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCode_KeyDown);
            this.txtTolid.Leave += new System.EventHandler(this.txtOft_Leave);
            // 
            // txtOther
            // 
            this.txtOther.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOther.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsTblKolMavad, "Hazine_other", true));
            this.txtOther.Location = new System.Drawing.Point(307, 385);
            this.txtOther.Name = "txtOther";
            this.txtOther.Size = new System.Drawing.Size(125, 43);
            this.txtOther.TabIndex = 11;
            this.txtOther.Enter += new System.EventHandler(this.txtOft_Enter);
            this.txtOther.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCode_KeyDown);
            this.txtOther.Leave += new System.EventHandler(this.txtOft_Leave);
            // 
            // txtKise
            // 
            this.txtKise.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKise.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsTblKolMavad, "Hazine_Kise", true));
            this.txtKise.Location = new System.Drawing.Point(807, 430);
            this.txtKise.Name = "txtKise";
            this.txtKise.Size = new System.Drawing.Size(125, 43);
            this.txtKise.TabIndex = 14;
            this.txtKise.Enter += new System.EventHandler(this.txtOft_Enter);
            this.txtKise.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCode_KeyDown);
            this.txtKise.Leave += new System.EventHandler(this.txtOft_Leave);
            // 
            // txtJamKol
            // 
            this.txtJamKol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtJamKol.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsTblKolMavad, "Jam", true));
            this.txtJamKol.Location = new System.Drawing.Point(598, 385);
            this.txtJamKol.Name = "txtJamKol";
            this.txtJamKol.ReadOnly = true;
            this.txtJamKol.Size = new System.Drawing.Size(125, 43);
            this.txtJamKol.TabIndex = 10;
            this.txtJamKol.Enter += new System.EventHandler(this.txtOft_Enter);
            this.txtJamKol.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCode_KeyDown);
            this.txtJamKol.Leave += new System.EventHandler(this.txtOft_Leave);
            // 
            // ultraLabel7
            // 
            this.ultraLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraLabel7.Font = new System.Drawing.Font("B Nazanin", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ultraLabel7.Location = new System.Drawing.Point(437, 481);
            this.ultraLabel7.Margin = new System.Windows.Forms.Padding(2);
            this.ultraLabel7.Name = "ultraLabel7";
            this.ultraLabel7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ultraLabel7.Size = new System.Drawing.Size(133, 30);
            this.ultraLabel7.TabIndex = 50;
            this.ultraLabel7.Text = "قیمت یک کیلو ";
            // 
            // txtVahed
            // 
            this.txtVahed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVahed.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsTblKolMavad, "Price_Amel", true));
            this.txtVahed.Location = new System.Drawing.Point(307, 475);
            this.txtVahed.Name = "txtVahed";
            this.txtVahed.ReadOnly = true;
            this.txtVahed.Size = new System.Drawing.Size(125, 43);
            this.txtVahed.TabIndex = 18;
            this.txtVahed.TabStop = false;
            this.txtVahed.Enter += new System.EventHandler(this.txtOft_Enter);
            this.txtVahed.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCode_KeyDown);
            this.txtVahed.Leave += new System.EventHandler(this.txtOft_Leave);
            // 
            // rpt1
            // 
            this.rpt1.NeedRefresh = false;
            this.rpt1.ReportResourceString = resources.GetString("rpt1.ReportResourceString");
            this.rpt1.Tag = null;
            this.rpt1.RegisterData(this.db_DataSetContent, "db_DataSetContent");
            // 
            // tbl_KolMavadTA
            // 
            this.tbl_KolMavadTA.ClearBeforeFill = true;
            // 
            // tbl_RizTA
            // 
            this.tbl_RizTA.ClearBeforeFill = true;
            // 
            // view_KolTA
            // 
            this.view_KolTA.ClearBeforeFill = true;
            // 
            // view_RizTA
            // 
            this.view_RizTA.ClearBeforeFill = true;
            // 
            // txtCode
            // 
            this.txtCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsTblKolMavad, "Code_kol", true));
            this.txtCode.Location = new System.Drawing.Point(1025, 178);
            this.txtCode.Name = "txtCode";
            this.txtCode.ReadOnly = true;
            this.txtCode.Size = new System.Drawing.Size(59, 43);
            this.txtCode.TabIndex = 67;
            this.txtCode.TextChanged += new System.EventHandler(this.txtCode_TextChanged);
            this.txtCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCode_KeyDown);
            // 
            // ultraLabel2
            // 
            this.ultraLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraLabel2.Location = new System.Drawing.Point(740, 436);
            this.ultraLabel2.Margin = new System.Windows.Forms.Padding(2);
            this.ultraLabel2.Name = "ultraLabel2";
            this.ultraLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ultraLabel2.Size = new System.Drawing.Size(56, 30);
            this.ultraLabel2.TabIndex = 52;
            this.ultraLabel2.Text = "تخفیف";
            // 
            // txtTakhfif
            // 
            this.txtTakhfif.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTakhfif.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsTblKolMavad, "Takhfif", true));
            this.txtTakhfif.Location = new System.Drawing.Point(598, 430);
            this.txtTakhfif.Name = "txtTakhfif";
            this.txtTakhfif.Size = new System.Drawing.Size(125, 43);
            this.txtTakhfif.TabIndex = 15;
            this.txtTakhfif.Enter += new System.EventHandler(this.txtOft_Enter);
            this.txtTakhfif.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCode_KeyDown);
            this.txtTakhfif.Leave += new System.EventHandler(this.txtOft_Leave);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            appearance4.Image = global::DamProducer.Properties.Resources.ok;
            this.btnSave.Appearance = appearance4;
            this.btnSave.ImageSize = new System.Drawing.Size(24, 24);
            this.btnSave.Location = new System.Drawing.Point(390, 104);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(137, 35);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "تایید";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // arzTextBox1
            // 
            this.arzTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.arzTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsTblKolMavad, "Price_Tak", true));
            this.arzTextBox1.Location = new System.Drawing.Point(27, 431);
            this.arzTextBox1.Name = "arzTextBox1";
            this.arzTextBox1.Size = new System.Drawing.Size(125, 43);
            this.arzTextBox1.TabIndex = 17;
            // 
            // ultraLabel13
            // 
            this.ultraLabel13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraLabel13.Location = new System.Drawing.Point(152, 437);
            this.ultraLabel13.Margin = new System.Windows.Forms.Padding(2);
            this.ultraLabel13.Name = "ultraLabel13";
            this.ultraLabel13.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ultraLabel13.Size = new System.Drawing.Size(151, 30);
            this.ultraLabel13.TabIndex = 69;
            this.ultraLabel13.Text = "قیمت تک فروشی";
            // 
            // ultraLabel14
            // 
            this.ultraLabel14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraLabel14.Location = new System.Drawing.Point(1141, 391);
            this.ultraLabel14.Margin = new System.Windows.Forms.Padding(2);
            this.ultraLabel14.Name = "ultraLabel14";
            this.ultraLabel14.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ultraLabel14.Size = new System.Drawing.Size(75, 30);
            this.ultraLabel14.TabIndex = 54;
            this.ultraLabel14.Text = "درصد ";
            // 
            // txtDarsad
            // 
            this.txtDarsad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDarsad.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsTblKolMavad, "DarsadOft", true));
            this.txtDarsad.Location = new System.Drawing.Point(1070, 385);
            this.txtDarsad.Name = "txtDarsad";
            this.txtDarsad.Size = new System.Drawing.Size(79, 43);
            this.txtDarsad.TabIndex = 8;
            this.txtDarsad.Enter += new System.EventHandler(this.txtOft_Enter);
            this.txtDarsad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDarsad_KeyDown);
            this.txtDarsad.Leave += new System.EventHandler(this.txtOft_Leave);
            // 
            // txtProt
            // 
            this.txtProt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsTblKolMavad, "Protein", true));
            this.txtProt.Location = new System.Drawing.Point(27, 385);
            this.txtProt.Name = "txtProt";
            this.txtProt.Size = new System.Drawing.Size(125, 43);
            this.txtProt.TabIndex = 12;
            this.txtProt.Enter += new System.EventHandler(this.txtOft_Enter);
            this.txtProt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCode_KeyDown);
            this.txtProt.Leave += new System.EventHandler(this.txtOft_Leave);
            // 
            // ultraLabel15
            // 
            this.ultraLabel15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraLabel15.Location = new System.Drawing.Point(171, 391);
            this.ultraLabel15.Margin = new System.Windows.Forms.Padding(2);
            this.ultraLabel15.Name = "ultraLabel15";
            this.ultraLabel15.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ultraLabel15.Size = new System.Drawing.Size(74, 30);
            this.ultraLabel15.TabIndex = 72;
            this.ultraLabel15.Text = "پروتئین";
            // 
            // TxtOtherlbl
            // 
            this.TxtOtherlbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            appearance3.BackColor = System.Drawing.Color.Gainsboro;
            this.TxtOtherlbl.Appearance = appearance3;
            this.TxtOtherlbl.BackColor = System.Drawing.Color.Gainsboro;
            this.TxtOtherlbl.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsTblKolMavad, "lblOther", true));
            this.TxtOtherlbl.Location = new System.Drawing.Point(439, 385);
            this.TxtOtherlbl.Name = "TxtOtherlbl";
            this.TxtOtherlbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtOtherlbl.Size = new System.Drawing.Size(140, 43);
            this.TxtOtherlbl.TabIndex = 73;
            // 
            // btnRefresh
            // 
            appearance2.Image = global::DamProducer.Properties.Resources.Product;
            this.btnRefresh.Appearance = appearance2;
            this.btnRefresh.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnRefresh.ImageSize = new System.Drawing.Size(28, 28);
            this.btnRefresh.Location = new System.Drawing.Point(11, 9);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(125, 48);
            this.btnRefresh.TabIndex = 74;
            this.btnRefresh.Text = "بارگذاری";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // chkStatus
            // 
            this.chkStatus.DataBindings.Add(new System.Windows.Forms.Binding("CheckedValue", this.BsTblKolMavad, "en", true));
            this.chkStatus.Location = new System.Drawing.Point(741, 12);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.Size = new System.Drawing.Size(175, 23);
            this.chkStatus.TabIndex = 1;
            this.chkStatus.Text = "وضعیت فعال بودن";
            // 
            // txtDarsadKarmozd
            // 
            this.txtDarsadKarmozd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDarsadKarmozd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsTblKolMavad, "DarsadKarmozd", true));
            this.txtDarsadKarmozd.Location = new System.Drawing.Point(307, 430);
            this.txtDarsadKarmozd.Name = "txtDarsadKarmozd";
            this.txtDarsadKarmozd.Size = new System.Drawing.Size(125, 43);
            this.txtDarsadKarmozd.TabIndex = 16;
            this.txtDarsadKarmozd.Enter += new System.EventHandler(this.txtOft_Enter);
            this.txtDarsadKarmozd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDarsad_KeyDown);
            this.txtDarsadKarmozd.Leave += new System.EventHandler(this.txtOft_Leave);
            // 
            // ultraLabel10
            // 
            this.ultraLabel10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraLabel10.Location = new System.Drawing.Point(439, 436);
            this.ultraLabel10.Margin = new System.Windows.Forms.Padding(2);
            this.ultraLabel10.Name = "ultraLabel10";
            this.ultraLabel10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ultraLabel10.Size = new System.Drawing.Size(131, 37);
            this.ultraLabel10.TabIndex = 76;
            this.ultraLabel10.Text = "کارمزد خریدار";
            // 
            // tbl_GroupTA
            // 
            this.tbl_GroupTA.ClearBeforeFill = true;
            // 
            // tbl_ProductTA
            // 
            this.tbl_ProductTA.ClearBeforeFill = true;
            // 
            // tbl_MatterTA
            // 
            this.tbl_MatterTA.ClearBeforeFill = true;
            // 
            // txtDate
            // 
            this.txtDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDate.Culture = new System.Globalization.CultureInfo("fa-IR");
            this.txtDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsTblKolMavad, "Date", true));
            this.txtDate.Location = new System.Drawing.Point(1004, 8);
            this.txtDate.Mask = "####/##/##";
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(100, 43);
            this.txtDate.TabIndex = 0;
            this.txtDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCode_KeyDown);
            // 
            // cmbKharidar
            // 
            this.cmbKharidar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            appearance5.BackColor2 = System.Drawing.Color.Gainsboro;
            this.cmbKharidar.Appearance = appearance5;
            this.cmbKharidar.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            this.cmbKharidar.AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.Contains;
            this.cmbKharidar.CalcManager = this.uCalcMgr;
            this.cmbKharidar.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.BsTblKolMavad, "Code_fro", true));
            this.cmbKharidar.DataMember = "View_Kharidar";
            this.cmbKharidar.DataSource = this.db_DataSetPerson;
            appearance6.BackColor = System.Drawing.SystemColors.Window;
            appearance6.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.cmbKharidar.DisplayLayout.Appearance = appearance6;
            this.cmbKharidar.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn;
            ultraGridColumn55.Header.VisiblePosition = 0;
            ultraGridColumn55.Hidden = true;
            ultraGridColumn56.Header.Caption = "نام";
            ultraGridColumn56.Header.VisiblePosition = 1;
            ultraGridColumn57.Header.Caption = "آدرس";
            ultraGridColumn57.Header.VisiblePosition = 2;
            ultraGridColumn58.Header.Caption = "کد ملی";
            ultraGridColumn58.Header.VisiblePosition = 3;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn55,
            ultraGridColumn56,
            ultraGridColumn57,
            ultraGridColumn58});
            this.cmbKharidar.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.cmbKharidar.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.cmbKharidar.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            appearance7.BackColor = System.Drawing.SystemColors.ActiveBorder;
            appearance7.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance7.BorderColor = System.Drawing.SystemColors.Window;
            this.cmbKharidar.DisplayLayout.GroupByBox.Appearance = appearance7;
            appearance8.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cmbKharidar.DisplayLayout.GroupByBox.BandLabelAppearance = appearance8;
            this.cmbKharidar.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            appearance9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            appearance9.BackColor2 = System.Drawing.SystemColors.Control;
            appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance9.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cmbKharidar.DisplayLayout.GroupByBox.PromptAppearance = appearance9;
            this.cmbKharidar.DisplayLayout.MaxColScrollRegions = 1;
            this.cmbKharidar.DisplayLayout.MaxRowScrollRegions = 1;
            appearance10.BackColor = System.Drawing.SystemColors.Window;
            appearance10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmbKharidar.DisplayLayout.Override.ActiveCellAppearance = appearance10;
            appearance11.BackColor = System.Drawing.SystemColors.Highlight;
            appearance11.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cmbKharidar.DisplayLayout.Override.ActiveRowAppearance = appearance11;
            this.cmbKharidar.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted;
            this.cmbKharidar.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
            appearance12.BackColor = System.Drawing.SystemColors.Window;
            this.cmbKharidar.DisplayLayout.Override.CardAreaAppearance = appearance12;
            appearance13.BorderColor = System.Drawing.Color.Silver;
            appearance13.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter;
            this.cmbKharidar.DisplayLayout.Override.CellAppearance = appearance13;
            this.cmbKharidar.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            this.cmbKharidar.DisplayLayout.Override.CellPadding = 0;
            appearance14.BackColor = System.Drawing.SystemColors.Control;
            appearance14.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance14.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
            appearance14.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance14.BorderColor = System.Drawing.SystemColors.Window;
            this.cmbKharidar.DisplayLayout.Override.GroupByRowAppearance = appearance14;
            appearance15.TextHAlignAsString = "Left";
            this.cmbKharidar.DisplayLayout.Override.HeaderAppearance = appearance15;
            this.cmbKharidar.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            this.cmbKharidar.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
            appearance16.BackColor = System.Drawing.Color.WhiteSmoke;
            appearance16.BorderColor = System.Drawing.Color.Silver;
            this.cmbKharidar.DisplayLayout.Override.RowAppearance = appearance16;
            this.cmbKharidar.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            appearance17.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cmbKharidar.DisplayLayout.Override.TemplateAddRowAppearance = appearance17;
            this.cmbKharidar.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.cmbKharidar.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.cmbKharidar.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.cmbKharidar.DisplayMember = "name_fro";
            this.cmbKharidar.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmbKharidar.Location = new System.Drawing.Point(554, 99);
            this.cmbKharidar.Margin = new System.Windows.Forms.Padding(2);
            this.cmbKharidar.Name = "cmbKharidar";
            this.cmbKharidar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbKharidar.Size = new System.Drawing.Size(254, 47);
            this.cmbKharidar.TabIndex = 5;
            this.cmbKharidar.ValueMember = "Code_fro";
            this.cmbKharidar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCode_KeyDown);
            // 
            // db_DataSetPerson
            // 
            this.db_DataSetPerson.DataSetName = "db_DataSetPerson";
            this.db_DataSetPerson.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // view_KharidarTAD
            // 
            this.view_KharidarTAD.ClearBeforeFill = true;
            // 
            // frmFContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1242, 586);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtDarsadKarmozd);
            this.Controls.Add(this.ultraLabel10);
            this.Controls.Add(this.chkStatus);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.TxtOtherlbl);
            this.Controls.Add(this.txtProt);
            this.Controls.Add(this.ultraLabel15);
            this.Controls.Add(this.txtDarsad);
            this.Controls.Add(this.arzTextBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtVahed);
            this.Controls.Add(this.txtJamKol);
            this.Controls.Add(this.txtKise);
            this.Controls.Add(this.txtTakhfif);
            this.Controls.Add(this.txtOther);
            this.Controls.Add(this.txtTolid);
            this.Controls.Add(this.txtOft);
            this.Controls.Add(this.cmbSefaresh);
            this.Controls.Add(this.ultraLabel6);
            this.Controls.Add(this.UComboMatter);
            this.Controls.Add(this.cmbKharidar);
            this.Controls.Add(this.ultraLabel4);
            this.Controls.Add(this.ultraLabel7);
            this.Controls.Add(this.ultraLabel12);
            this.Controls.Add(this.ultraLabel2);
            this.Controls.Add(this.ultraLabel11);
            this.Controls.Add(this.ultraLabel14);
            this.Controls.Add(this.ultraLabel9);
            this.Controls.Add(this.ultraLabel8);
            this.Controls.Add(this.ultraLabel5);
            this.Controls.Add(this.ultraLabel1);
            this.Controls.Add(this.cmbProduct);
            this.Controls.Add(this.cmbGroup);
            this.Controls.Add(this.bNavigator1);
            this.Controls.Add(this.UGrid);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.ultraLabel3);
            this.Controls.Add(this.ultraLabel13);
            this.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmFContent";
            this.Text = "فرمول محصولات";
            this.Load += new System.EventHandler(this.frmFContent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UComboMatter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uCalcMgr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMatterBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_DataSetGTP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bNavigator1)).EndInit();
            this.bNavigator1.ResumeLayout(false);
            this.bNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BsTblKolMavad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_DataSetContent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UGrid)).EndInit();
            this.MnuGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblKolMavadTblRizBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblGroupBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TblProductTblGroupBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSefaresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpt1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtOtherlbl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbKharidar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_DataSetPerson)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton BNavDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private Infragistics.Win.UltraWinGrid.UltraGrid UGrid;
        private Infragistics.Win.UltraWinCalcManager.UltraCalcManager uCalcMgr;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private Infragistics.Win.UltraWinEditors.UltraComboEditor cmbProduct;
        private Infragistics.Win.UltraWinEditors.UltraComboEditor cmbGroup;
        private Infragistics.Win.Misc.UltraLabel ultraLabel3;
        private Infragistics.Win.Misc.UltraLabel ultraLabel1;
        private Dset.db_DataSetContent db_DataSetContent;
        private System.Windows.Forms.BindingSource tblKolMavadTblRizBS;
        private Dset.db_DataSetContentTableAdapters.Tbl_RizTA tbl_RizTA;
        private Infragistics.Win.Misc.UltraLabel ultraLabel5;
        private Infragistics.Win.Misc.UltraLabel ultraLabel12;
        private Infragistics.Win.Misc.UltraLabel ultraLabel11;
        private Infragistics.Win.Misc.UltraLabel ultraLabel9;
        private Infragistics.Win.Misc.UltraLabel ultraLabel8;
        private System.Windows.Forms.ErrorProvider err;
        private Infragistics.Win.UltraWinGrid.UltraCombo cmbKharidar;
        private Infragistics.Win.Misc.UltraLabel ultraLabel4;
        private Infragistics.Win.UltraWinEditors.UltraComboEditor cmbSefaresh;
        private Infragistics.Win.Misc.UltraLabel ultraLabel6;
        private ArzTextBox.ArzTextBox txtOft;
        private ArzTextBox.ArzTextBox txtJamKol;
        private ArzTextBox.ArzTextBox txtKise;
        private ArzTextBox.ArzTextBox txtOther;
        private ArzTextBox.ArzTextBox txtTolid;
        private Infragistics.Win.Misc.UltraLabel ultraLabel7;
        private Dset.db_DataSetGTP db_DataSetGTP;
        private System.Windows.Forms.BindingSource tblGroupBS;
        private Dset.db_DataSetGTPTableAdapters.Tbl_GroupTA tbl_GroupTA;
        private System.Windows.Forms.BindingSource TblProductTblGroupBS;
        private Dset.db_DataSetGTPTableAdapters.Tbl_ProductTA tbl_ProductTA;
        private System.Windows.Forms.BindingSource tblMatterBS;
        private Dset.db_DataSetGTPTableAdapters.Tbl_MatterTA tbl_MatterTA;
        private ArzTextBox.ArzTextBox txtVahed;
        private Infragistics.Win.UltraWinGrid.UltraCombo UComboMatter;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton SearchStripButton;
        private System.Windows.Forms.BindingSource BsTblKolMavad;
        private Dset.db_DataSetContentTableAdapters.Tbl_KolMavadTA tbl_KolMavadTA;
        private Dset.db_DataSetContentTableAdapters.View_KolTA view_KolTA;
        private Dset.db_DataSetContentTableAdapters.View_RizTA view_RizTA;
        private FastReport.Report rpt1;
        private System.Windows.Forms.TextBox txtCode;
        private ArzTextBox.ArzTextBox txtTakhfif;
        private Infragistics.Win.Misc.UltraLabel ultraLabel2;
        private System.Windows.Forms.ToolStripDropDownButton PrintfmStripButton;
        private System.Windows.Forms.ToolStripMenuItem mnuPrintTonAll;
        private System.Windows.Forms.ToolStripMenuItem mnuPrintDarsad;
        private Infragistics.Win.Misc.UltraButton btnSave;
        private System.Windows.Forms.ToolStripButton CancelToolButton;
        private Infragistics.Win.Misc.UltraLabel ultraLabel13;
        private ArzTextBox.ArzTextBox arzTextBox1;
        private Infragistics.Win.Misc.UltraLabel ultraLabel14;
        private System.Windows.Forms.TextBox txtDarsad;
        private ArzTextBox.ArzTextBox txtProt;
        private Infragistics.Win.Misc.UltraLabel ultraLabel15;
        private System.Windows.Forms.ToolStripMenuItem MnuPrintTonH;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor TxtOtherlbl;
        private System.Windows.Forms.ContextMenuStrip MnuGrid;
        private System.Windows.Forms.ToolStripMenuItem MnuCopy;
        private System.Windows.Forms.ToolStripMenuItem MnuPaste;
        private Infragistics.Win.Misc.UltraButton btnRefresh;
        private Infragistics.Win.UltraWinEditors.UltraCheckEditor chkStatus;
        private System.Windows.Forms.TextBox txtDarsadKarmozd;
        private Infragistics.Win.Misc.UltraLabel ultraLabel10;
        private DateControlBT.PDateBox txtDate;
        private Dset.db_DataSetPerson db_DataSetPerson;
        private Dset.db_DataSetPersonTableAdapters.View_KharidarTAD view_KharidarTAD;
    }
}