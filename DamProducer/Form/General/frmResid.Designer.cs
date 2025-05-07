namespace DamProducer
{
    partial class frmResid
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
            Infragistics.Win.Appearance appearance27 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand3 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_Tbl_ResidRiz_Tbl_Resid", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn29 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Code_rz");
            Infragistics.Win.Appearance appearance28 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn30 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Code_resid");
            Infragistics.Win.Appearance appearance29 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn31 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Code_matter");
            Infragistics.Win.Appearance appearance30 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn32 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Code_vahed");
            Infragistics.Win.Appearance appearance31 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn33 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Zarfiat_vahed");
            Infragistics.Win.Appearance appearance32 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn34 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Tedad");
            Infragistics.Win.Appearance appearance33 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn36 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Darsad_oft");
            Infragistics.Win.Appearance appearance34 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn37 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("vaznPor");
            Infragistics.Win.Appearance appearance35 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn38 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("vaznKhali");
            Infragistics.Win.Appearance appearance36 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn39 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Tax");
            Infragistics.Win.Appearance appearance37 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn40 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Price_tamam");
            Infragistics.Win.Appearance appearance38 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn41 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Price_vahed");
            Infragistics.Win.Appearance appearance39 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn35 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Takhfif");
            Infragistics.Win.Appearance appearance40 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn6 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("PriceORG");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn42 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("vazn", 0);
            Infragistics.Win.Appearance appearance41 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn43 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("jamkol", 1);
            Infragistics.Win.Appearance appearance42 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn5 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("جمع", 2);
            Infragistics.Win.UltraWinGrid.SummarySettings summarySettings1 = new Infragistics.Win.UltraWinGrid.SummarySettings("SumVazn", Infragistics.Win.UltraWinGrid.SummaryType.Sum, null, "vazn", 0, false, "FK_Tbl_ResidRiz_Tbl_Resid", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "vazn", 0, false);
            Infragistics.Win.Appearance appearance43 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.SummarySettings summarySettings2 = new Infragistics.Win.UltraWinGrid.SummarySettings("SumJam", Infragistics.Win.UltraWinGrid.SummaryType.Sum, null, "jamkol", 1, false, "FK_Tbl_ResidRiz_Tbl_Resid", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "jamkol", 1, false);
            Infragistics.Win.Appearance appearance44 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.SummarySettings summarySettings3 = new Infragistics.Win.UltraWinGrid.SummarySettings("TakhfifK", Infragistics.Win.UltraWinGrid.SummaryType.Formula, "[SumTakhfif()] /  [SumVazn()]", null, -1, false, null, -1, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "Takhfif", 12, true);
            Infragistics.Win.Appearance appearance45 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.SummarySettings summarySettings4 = new Infragistics.Win.UltraWinGrid.SummarySettings("SumTakhfif", Infragistics.Win.UltraWinGrid.SummaryType.Sum, null, "Takhfif", 12, true, "FK_Tbl_ResidRiz_Tbl_Resid", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "vaznPor", 7, true);
            Infragistics.Win.Appearance appearance46 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.SummarySettings summarySettings5 = new Infragistics.Win.UltraWinGrid.SummarySettings("SumTax", Infragistics.Win.UltraWinGrid.SummaryType.Sum, null, "Tax", 9, true, "FK_Tbl_ResidRiz_Tbl_Resid", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "vaznKhali", 8, true);
            Infragistics.Win.Appearance appearance47 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.SummarySettings summarySettings6 = new Infragistics.Win.UltraWinGrid.SummarySettings("TaxK", Infragistics.Win.UltraWinGrid.SummaryType.Formula, "[SumTax()] /  [SumVazn()]", null, -1, false, null, -1, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "Tax", 9, true);
            Infragistics.Win.Appearance appearance48 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance49 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance50 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance51 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance52 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance53 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance54 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance55 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance56 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance57 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance58 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance59 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance60 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance61 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance62 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance14 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand2 = new Infragistics.Win.UltraWinGrid.UltraGridBand("View_Person", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn14 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Code_fro");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn15 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("name_fro", -1, null, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, false);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn16 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Addres");
            Infragistics.Win.Appearance appearance15 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance16 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance17 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance18 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance19 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance20 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance21 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance22 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance23 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance24 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance25 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance26 = new Infragistics.Win.Appearance();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResid));
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("View_Driver", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn47 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Code_fro");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn127 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("name_fro");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn128 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Addres");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn54 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Num_Car");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn53 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("mobile", 0);
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
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            this.CmbMater = new Infragistics.Win.UltraWinEditors.UltraComboEditor();
            this.db_DataSetResid = new DamProducer.Dset.db_DataSetResid();
            this.cmbVahed = new Infragistics.Win.UltraWinEditors.UltraComboEditor();
            this.ultraCalc1 = new Infragistics.Win.UltraWinCalcManager.UltraCalcManager(this.components);
            this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
            this.UGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.TblResidRizTblResidBS = new System.Windows.Forms.BindingSource(this.components);
            this.tblResidBS = new System.Windows.Forms.BindingSource(this.components);
            this.ultraLabel2 = new Infragistics.Win.Misc.UltraLabel();
            this.cmbResidType = new Infragistics.Win.UltraWinEditors.UltraComboEditor();
            this.ultraLabel3 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel4 = new Infragistics.Win.Misc.UltraLabel();
            this.cmbFroshande = new Infragistics.Win.UltraWinGrid.UltraCombo();
            this.viewPersonBS = new System.Windows.Forms.BindingSource(this.components);
            this.txtCodeFak = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.ultraLabel5 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel6 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel7 = new Infragistics.Win.Misc.UltraLabel();
            this.txtNumCar = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.ultraLabel8 = new Infragistics.Win.Misc.UltraLabel();
            this.cmbAnbar = new Infragistics.Win.UltraWinEditors.UltraComboEditor();
            this.cmbTahvil = new Infragistics.Win.UltraWinEditors.UltraComboEditor();
            this.ultraLabel9 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel10 = new Infragistics.Win.Misc.UltraLabel();
            this.btnSearch = new Infragistics.Win.Misc.UltraButton();
            this.ultraLabel11 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel12 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel13 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel14 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel15 = new Infragistics.Win.Misc.UltraLabel();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripDel = new System.Windows.Forms.ToolStripButton();
            this.bNavigatorResid = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.CmbDriver = new Infragistics.Win.UltraWinGrid.UltraCombo();
            this.viewDriverBS = new System.Windows.Forms.BindingSource(this.components);
            this.ubtnComite = new Infragistics.Win.Misc.UltraButton();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtCode = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.CdResid = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.txtHaml = new ArzTextBox.ArzTextBox();
            this.txtBargiri = new ArzTextBox.ArzTextBox();
            this.txtTakhlie = new ArzTextBox.ArzTextBox();
            this.txtOther = new ArzTextBox.ArzTextBox();
            this.txtTakhfif = new ArzTextBox.ArzTextBox();
            this.tbl_ResidTA = new DamProducer.Dset.db_DataSetResidTableAdapters.Tbl_ResidTA();
            this.view_MatterTA = new DamProducer.Dset.db_DataSetResidTableAdapters.View_MatterTA();
            this.view_AnbarTA = new DamProducer.Dset.db_DataSetResidTableAdapters.View_AnbarTA();
            this.tbl_ResidRizTA = new DamProducer.Dset.db_DataSetResidTableAdapters.Tbl_ResidRizTA();
            this.view_VahedTA = new DamProducer.Dset.db_DataSetResidTableAdapters.View_VahedTA();
            this.view_PersonTA = new DamProducer.Dset.db_DataSetResidTableAdapters.View_PersonTA();
            this.view_DriverTA = new DamProducer.Dset.db_DataSetResidTableAdapters.View_DriverTA();
            this.view_TahvilTA = new DamProducer.Dset.db_DataSetResidTableAdapters.View_TahvilTA();
            this.view_ResidTA = new DamProducer.Dset.db_DataSetResidTableAdapters.View_ResidTA();
            this.view_ResidrRizTA = new DamProducer.Dset.db_DataSetResidTableAdapters.View_ResidrRizTA();
            this.rpt1 = new FastReport.Report();
            this.btnReload = new Infragistics.Win.Misc.UltraButton();
            this.tbl_NoeResidTA = new DamProducer.Dset.db_DataSetResidTableAdapters.Tbl_NoeResidTA();
            this.txtHamlK = new ArzTextBox.ArzTextBox();
            this.txtBargiriK = new ArzTextBox.ArzTextBox();
            this.txtTakhlieK = new ArzTextBox.ArzTextBox();
            this.txtOtherK = new ArzTextBox.ArzTextBox();
            this.ultraLabel16 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel17 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel18 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel19 = new Infragistics.Win.Misc.UltraLabel();
            this.txtDateResid = new DateControlBT.PDateBox();
            this.txtDateFak = new DateControlBT.PDateBox();
            ((System.ComponentModel.ISupportInitialize)(this.CmbMater)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_DataSetResid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbVahed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCalc1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TblResidRizTblResidBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblResidBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbResidType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFroshande)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewPersonBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodeFak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAnbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTahvil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bNavigatorResid)).BeginInit();
            this.bNavigatorResid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CmbDriver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewDriverBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CdResid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpt1)).BeginInit();
            this.SuspendLayout();
            // 
            // CmbMater
            // 
            this.CmbMater.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbMater.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.CmbMater.DataMember = "View_Matter";
            this.CmbMater.DataSource = this.db_DataSetResid;
            this.CmbMater.DisplayMember = "Name_matter";
            this.CmbMater.Location = new System.Drawing.Point(1056, 359);
            this.CmbMater.Margin = new System.Windows.Forms.Padding(2);
            this.CmbMater.Name = "CmbMater";
            this.CmbMater.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CmbMater.Size = new System.Drawing.Size(245, 36);
            this.CmbMater.TabIndex = 13;
            this.CmbMater.ValueMember = "Code_matter";
            this.CmbMater.Visible = false;
            this.CmbMater.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cdresid_KeyDown);
            // 
            // db_DataSetResid
            // 
            this.db_DataSetResid.DataSetName = "db_DataSetResid";
            this.db_DataSetResid.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbVahed
            // 
            this.cmbVahed.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            this.cmbVahed.DataMember = "View_Vahed";
            this.cmbVahed.DataSource = this.db_DataSetResid;
            this.cmbVahed.DisplayMember = "Name_vahed";
            this.cmbVahed.Location = new System.Drawing.Point(703, 359);
            this.cmbVahed.Margin = new System.Windows.Forms.Padding(2);
            this.cmbVahed.Name = "cmbVahed";
            this.cmbVahed.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbVahed.Size = new System.Drawing.Size(92, 36);
            this.cmbVahed.TabIndex = 14;
            this.cmbVahed.ValueMember = "Code_vahed";
            this.cmbVahed.Visible = false;
            // 
            // ultraCalc1
            // 
            this.ultraCalc1.ContainingControl = this;
            this.ultraCalc1.NamedReferences.AddRange(new object[] {
            new Infragistics.Win.UltraWinCalcManager.NamedReference("NamedReference 0", null, null, null)});
            // 
            // ultraLabel1
            // 
            this.ultraLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraLabel1.Location = new System.Drawing.Point(1254, 12);
            this.ultraLabel1.Margin = new System.Windows.Forms.Padding(2);
            this.ultraLabel1.Name = "ultraLabel1";
            this.ultraLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ultraLabel1.Size = new System.Drawing.Size(100, 30);
            this.ultraLabel1.TabIndex = 4;
            this.ultraLabel1.Text = "شماره رسید";
            // 
            // UGrid
            // 
            this.UGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UGrid.CalcManager = this.ultraCalc1;
            this.UGrid.DataSource = this.TblResidRizTblResidBS;
            appearance27.BackColor = System.Drawing.SystemColors.Window;
            appearance27.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.UGrid.DisplayLayout.Appearance = appearance27;
            this.UGrid.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            appearance28.TextHAlignAsString = "Center";
            ultraGridColumn29.Header.Appearance = appearance28;
            ultraGridColumn29.Header.VisiblePosition = 2;
            ultraGridColumn29.Hidden = true;
            appearance29.TextHAlignAsString = "Center";
            ultraGridColumn30.Header.Appearance = appearance29;
            ultraGridColumn30.Header.VisiblePosition = 3;
            ultraGridColumn30.Hidden = true;
            ultraGridColumn31.EditorComponent = this.CmbMater;
            appearance30.TextHAlignAsString = "Center";
            ultraGridColumn31.Header.Appearance = appearance30;
            ultraGridColumn31.Header.Caption = "نام کالا";
            ultraGridColumn31.Header.VisiblePosition = 0;
            ultraGridColumn31.Width = 227;
            ultraGridColumn32.EditorComponent = this.cmbVahed;
            appearance31.TextHAlignAsString = "Center";
            ultraGridColumn32.Header.Appearance = appearance31;
            ultraGridColumn32.Header.Caption = "واحد";
            ultraGridColumn32.Header.VisiblePosition = 1;
            ultraGridColumn32.Hidden = true;
            ultraGridColumn32.Width = 78;
            ultraGridColumn33.Format = "###,###,####.#";
            appearance32.TextHAlignAsString = "Center";
            ultraGridColumn33.Header.Appearance = appearance32;
            ultraGridColumn33.Header.Caption = "وزن بارنامه";
            ultraGridColumn33.Header.VisiblePosition = 4;
            ultraGridColumn33.Width = 123;
            appearance33.TextHAlignAsString = "Center";
            ultraGridColumn34.Header.Appearance = appearance33;
            ultraGridColumn34.Header.Caption = "تعداد";
            ultraGridColumn34.Header.VisiblePosition = 5;
            ultraGridColumn34.Hidden = true;
            ultraGridColumn34.Width = 127;
            appearance34.TextHAlignAsString = "Center";
            ultraGridColumn36.Header.Appearance = appearance34;
            ultraGridColumn36.Header.Caption = "درصد افت";
            ultraGridColumn36.Header.VisiblePosition = 10;
            ultraGridColumn36.Hidden = true;
            ultraGridColumn36.MaxWidth = 80;
            ultraGridColumn36.Width = 80;
            appearance35.TextHAlignAsString = "Center";
            ultraGridColumn37.Header.Appearance = appearance35;
            ultraGridColumn37.Header.VisiblePosition = 8;
            ultraGridColumn37.Hidden = true;
            appearance36.TextHAlignAsString = "Center";
            ultraGridColumn38.Header.Appearance = appearance36;
            ultraGridColumn38.Header.VisiblePosition = 9;
            ultraGridColumn38.Hidden = true;
            ultraGridColumn39.Format = "n0";
            appearance37.TextHAlignAsString = "Center";
            ultraGridColumn39.Header.Appearance = appearance37;
            ultraGridColumn39.Header.Caption = "ارزش افزوده";
            ultraGridColumn39.Header.VisiblePosition = 12;
            ultraGridColumn39.Width = 131;
            ultraGridColumn40.Format = "n0";
            appearance38.TextHAlignAsString = "Center";
            ultraGridColumn40.Header.Appearance = appearance38;
            ultraGridColumn40.Header.Caption = "قیمت تمام شده";
            ultraGridColumn40.Header.VisiblePosition = 16;
            ultraGridColumn40.Width = 142;
            ultraGridColumn41.Format = "n0";
            appearance39.TextHAlignAsString = "Center";
            ultraGridColumn41.Header.Appearance = appearance39;
            ultraGridColumn41.Header.Caption = "قیمت واحد";
            ultraGridColumn41.Header.VisiblePosition = 7;
            ultraGridColumn41.Width = 105;
            ultraGridColumn35.Format = "n0";
            appearance40.TextHAlignAsString = "Center";
            ultraGridColumn35.Header.Appearance = appearance40;
            ultraGridColumn35.Header.Caption = "تخفیف";
            ultraGridColumn35.Header.VisiblePosition = 13;
            ultraGridColumn35.Width = 138;
            ultraGridColumn6.Format = "n0";
            ultraGridColumn6.Header.Caption = "قیمت اصل";
            ultraGridColumn6.Header.VisiblePosition = 14;
            ultraGridColumn6.Width = 135;
            ultraGridColumn42.Format = "";
            ultraGridColumn42.Formula = "[Tedad] *  [Zarfiat_vahed]";
            appearance41.TextHAlignAsString = "Center";
            ultraGridColumn42.Header.Appearance = appearance41;
            ultraGridColumn42.Header.Caption = "وزن";
            ultraGridColumn42.Header.VisiblePosition = 6;
            ultraGridColumn42.Hidden = true;
            ultraGridColumn42.Width = 129;
            ultraGridColumn43.Format = "n0";
            ultraGridColumn43.Formula = "[vazn] * [Price_vahed] -  [Takhfif]+ [Tax]";
            appearance42.TextHAlignAsString = "Center";
            ultraGridColumn43.Header.Appearance = appearance42;
            ultraGridColumn43.Header.Caption = "جمع کل";
            ultraGridColumn43.Header.VisiblePosition = 15;
            ultraGridColumn43.Width = 157;
            ultraGridColumn5.Format = "n0";
            ultraGridColumn5.Formula = "[vazn] * [Price_vahed]";
            ultraGridColumn5.Header.VisiblePosition = 11;
            ultraGridColumn5.Width = 142;
            ultraGridBand3.Columns.AddRange(new object[] {
            ultraGridColumn29,
            ultraGridColumn30,
            ultraGridColumn31,
            ultraGridColumn32,
            ultraGridColumn33,
            ultraGridColumn34,
            ultraGridColumn36,
            ultraGridColumn37,
            ultraGridColumn38,
            ultraGridColumn39,
            ultraGridColumn40,
            ultraGridColumn41,
            ultraGridColumn35,
            ultraGridColumn6,
            ultraGridColumn42,
            ultraGridColumn43,
            ultraGridColumn5});
            ultraGridBand3.Override.SummaryFooterCaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            summarySettings1.DisplayFormat = "{0}";
            summarySettings1.GroupBySummaryValueAppearance = appearance43;
            summarySettings1.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed;
            summarySettings2.DisplayFormat = "{0:###,###,###,###}";
            summarySettings2.GroupBySummaryValueAppearance = appearance44;
            summarySettings2.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed;
            summarySettings3.DisplayFormat = "{0:###,###,###}";
            summarySettings3.GroupBySummaryValueAppearance = appearance45;
            summarySettings4.DisplayFormat = "{0}";
            summarySettings4.GroupBySummaryValueAppearance = appearance46;
            summarySettings5.GroupBySummaryValueAppearance = appearance47;
            summarySettings6.DisplayFormat = "{0:###,###,###}";
            summarySettings6.GroupBySummaryValueAppearance = appearance48;
            ultraGridBand3.Summaries.AddRange(new Infragistics.Win.UltraWinGrid.SummarySettings[] {
            summarySettings1,
            summarySettings2,
            summarySettings3,
            summarySettings4,
            summarySettings5,
            summarySettings6});
            ultraGridBand3.SummaryFooterCaption = "جمع فاکتور";
            this.UGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand3);
            this.UGrid.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.UGrid.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.True;
            this.UGrid.DisplayLayout.EmptyRowSettings.ShowEmptyRows = true;
            this.UGrid.DisplayLayout.EmptyRowSettings.Style = Infragistics.Win.UltraWinGrid.EmptyRowStyle.ExtendRowSelector;
            appearance49.BackColor = System.Drawing.SystemColors.ActiveBorder;
            appearance49.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance49.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance49.BorderColor = System.Drawing.SystemColors.Window;
            this.UGrid.DisplayLayout.GroupByBox.Appearance = appearance49;
            appearance50.ForeColor = System.Drawing.SystemColors.GrayText;
            this.UGrid.DisplayLayout.GroupByBox.BandLabelAppearance = appearance50;
            this.UGrid.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            appearance51.BackColor = System.Drawing.SystemColors.ControlLightLight;
            appearance51.BackColor2 = System.Drawing.SystemColors.Control;
            appearance51.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance51.ForeColor = System.Drawing.SystemColors.GrayText;
            this.UGrid.DisplayLayout.GroupByBox.PromptAppearance = appearance51;
            this.UGrid.DisplayLayout.MaxColScrollRegions = 1;
            this.UGrid.DisplayLayout.MaxRowScrollRegions = 1;
            appearance52.BackColor = System.Drawing.Color.PeachPuff;
            appearance52.ForeColor = System.Drawing.SystemColors.ControlText;
            this.UGrid.DisplayLayout.Override.ActiveCellAppearance = appearance52;
            appearance53.BackColor = System.Drawing.Color.PeachPuff;
            appearance53.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.UGrid.DisplayLayout.Override.ActiveRowAppearance = appearance53;
            this.UGrid.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.UGrid.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.UGrid.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.UGrid.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            this.UGrid.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted;
            this.UGrid.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
            appearance54.BackColor = System.Drawing.SystemColors.Window;
            this.UGrid.DisplayLayout.Override.CardAreaAppearance = appearance54;
            appearance55.BorderColor = System.Drawing.Color.Silver;
            appearance55.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter;
            this.UGrid.DisplayLayout.Override.CellAppearance = appearance55;
            this.UGrid.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            this.UGrid.DisplayLayout.Override.CellPadding = 0;
            this.UGrid.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow;
            appearance56.BackColor = System.Drawing.SystemColors.Control;
            appearance56.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance56.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
            appearance56.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance56.BorderColor = System.Drawing.SystemColors.Window;
            this.UGrid.DisplayLayout.Override.GroupByRowAppearance = appearance56;
            appearance57.TextHAlignAsString = "Center";
            this.UGrid.DisplayLayout.Override.HeaderAppearance = appearance57;
            this.UGrid.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
            appearance58.BackColor = System.Drawing.SystemColors.Info;
            this.UGrid.DisplayLayout.Override.RowAlternateAppearance = appearance58;
            appearance59.BackColor = System.Drawing.SystemColors.Window;
            appearance59.BorderColor = System.Drawing.Color.Silver;
            this.UGrid.DisplayLayout.Override.RowAppearance = appearance59;
            this.UGrid.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.SeparateElement;
            this.UGrid.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex;
            this.UGrid.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.True;
            this.UGrid.DisplayLayout.Override.RowSizing = Infragistics.Win.UltraWinGrid.RowSizing.Fixed;
            this.UGrid.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Single;
            this.UGrid.DisplayLayout.Override.SummaryDisplayArea = ((Infragistics.Win.UltraWinGrid.SummaryDisplayAreas)((Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed | Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.RootRowsFootersOnly)));
            appearance60.BackColor = System.Drawing.Color.Gainsboro;
            this.UGrid.DisplayLayout.Override.SummaryFooterAppearance = appearance60;
            appearance61.BackColor = System.Drawing.Color.Gainsboro;
            this.UGrid.DisplayLayout.Override.SummaryFooterCaptionAppearance = appearance61;
            appearance62.BackColor = System.Drawing.SystemColors.ControlLight;
            this.UGrid.DisplayLayout.Override.TemplateAddRowAppearance = appearance62;
            this.UGrid.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.UGrid.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.UGrid.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand;
            this.UGrid.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.UGrid.Location = new System.Drawing.Point(4, 184);
            this.UGrid.Margin = new System.Windows.Forms.Padding(6);
            this.UGrid.Name = "UGrid";
            this.UGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.UGrid.Size = new System.Drawing.Size(1351, 366);
            this.UGrid.TabIndex = 12;
            this.UGrid.Text = "شرح رسید";
            this.UGrid.AfterCellUpdate += new Infragistics.Win.UltraWinGrid.CellEventHandler(this.UGrid_AfterCellUpdate);
            this.UGrid.BeforeRowsDeleted += new Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventHandler(this.UGrid_BeforeRowsDeleted);
            this.UGrid.CellDataError += new Infragistics.Win.UltraWinGrid.CellDataErrorEventHandler(this.UGrid_CellDataError);
            this.UGrid.DoubleClickCell += new Infragistics.Win.UltraWinGrid.DoubleClickCellEventHandler(this.UGrid_DoubleClickCell);
            this.UGrid.Enter += new System.EventHandler(this.UGrid_Enter);
            this.UGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UGrid_KeyDown);
            // 
            // TblResidRizTblResidBS
            // 
            this.TblResidRizTblResidBS.DataMember = "FK_Tbl_ResidRiz_Tbl_Resid";
            this.TblResidRizTblResidBS.DataSource = this.tblResidBS;
            // 
            // tblResidBS
            // 
            this.tblResidBS.DataMember = "Tbl_Resid";
            this.tblResidBS.DataSource = this.db_DataSetResid;
            // 
            // ultraLabel2
            // 
            this.ultraLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraLabel2.Location = new System.Drawing.Point(655, 14);
            this.ultraLabel2.Margin = new System.Windows.Forms.Padding(2);
            this.ultraLabel2.Name = "ultraLabel2";
            this.ultraLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ultraLabel2.Size = new System.Drawing.Size(80, 30);
            this.ultraLabel2.TabIndex = 4;
            this.ultraLabel2.Text = "تاریخ رسید";
            // 
            // cmbResidType
            // 
            this.cmbResidType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbResidType.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            this.cmbResidType.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tblResidBS, "Type_resid", true));
            this.cmbResidType.DataMember = "Tbl_NoeResid";
            this.cmbResidType.DataSource = this.db_DataSetResid;
            this.cmbResidType.DisplayMember = "Pay";
            this.cmbResidType.Location = new System.Drawing.Point(774, 10);
            this.cmbResidType.Margin = new System.Windows.Forms.Padding(2);
            this.cmbResidType.Name = "cmbResidType";
            this.cmbResidType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbResidType.Size = new System.Drawing.Size(155, 36);
            this.cmbResidType.TabIndex = 2;
            this.cmbResidType.ValueMember = "id";
            this.cmbResidType.Enter += new System.EventHandler(this.cmbResidType_Enter);
            this.cmbResidType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cdresid_KeyDown);
            this.cmbResidType.Leave += new System.EventHandler(this.cmbResidType_Leave);
            // 
            // ultraLabel3
            // 
            this.ultraLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraLabel3.Location = new System.Drawing.Point(929, 13);
            this.ultraLabel3.Margin = new System.Windows.Forms.Padding(2);
            this.ultraLabel3.Name = "ultraLabel3";
            this.ultraLabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ultraLabel3.Size = new System.Drawing.Size(86, 30);
            this.ultraLabel3.TabIndex = 4;
            this.ultraLabel3.Text = "نوع رسید";
            // 
            // ultraLabel4
            // 
            this.ultraLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraLabel4.Location = new System.Drawing.Point(1245, 56);
            this.ultraLabel4.Margin = new System.Windows.Forms.Padding(2);
            this.ultraLabel4.Name = "ultraLabel4";
            this.ultraLabel4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ultraLabel4.Size = new System.Drawing.Size(101, 30);
            this.ultraLabel4.TabIndex = 4;
            this.ultraLabel4.Text = "فروشنده";
            // 
            // cmbFroshande
            // 
            this.cmbFroshande.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFroshande.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            this.cmbFroshande.AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.Contains;
            this.cmbFroshande.CalcManager = this.ultraCalc1;
            this.cmbFroshande.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tblResidBS, "Code_fro", true));
            this.cmbFroshande.DataSource = this.viewPersonBS;
            appearance14.BackColor = System.Drawing.SystemColors.Window;
            appearance14.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.cmbFroshande.DisplayLayout.Appearance = appearance14;
            this.cmbFroshande.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn;
            ultraGridColumn14.Header.VisiblePosition = 0;
            ultraGridColumn14.Hidden = true;
            ultraGridColumn15.Header.VisiblePosition = 1;
            ultraGridColumn15.Width = 274;
            ultraGridColumn16.Header.VisiblePosition = 2;
            ultraGridBand2.Columns.AddRange(new object[] {
            ultraGridColumn14,
            ultraGridColumn15,
            ultraGridColumn16});
            this.cmbFroshande.DisplayLayout.BandsSerializer.Add(ultraGridBand2);
            this.cmbFroshande.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.cmbFroshande.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            appearance15.BackColor = System.Drawing.SystemColors.ActiveBorder;
            appearance15.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance15.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance15.BorderColor = System.Drawing.SystemColors.Window;
            this.cmbFroshande.DisplayLayout.GroupByBox.Appearance = appearance15;
            appearance16.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cmbFroshande.DisplayLayout.GroupByBox.BandLabelAppearance = appearance16;
            this.cmbFroshande.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            appearance17.BackColor = System.Drawing.SystemColors.ControlLightLight;
            appearance17.BackColor2 = System.Drawing.SystemColors.Control;
            appearance17.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance17.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cmbFroshande.DisplayLayout.GroupByBox.PromptAppearance = appearance17;
            this.cmbFroshande.DisplayLayout.MaxColScrollRegions = 1;
            this.cmbFroshande.DisplayLayout.MaxRowScrollRegions = 1;
            appearance18.BackColor = System.Drawing.SystemColors.Window;
            appearance18.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmbFroshande.DisplayLayout.Override.ActiveCellAppearance = appearance18;
            appearance19.BackColor = System.Drawing.SystemColors.Highlight;
            appearance19.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cmbFroshande.DisplayLayout.Override.ActiveRowAppearance = appearance19;
            this.cmbFroshande.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted;
            this.cmbFroshande.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
            appearance20.BackColor = System.Drawing.SystemColors.Window;
            this.cmbFroshande.DisplayLayout.Override.CardAreaAppearance = appearance20;
            appearance21.BorderColor = System.Drawing.Color.Silver;
            appearance21.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter;
            this.cmbFroshande.DisplayLayout.Override.CellAppearance = appearance21;
            this.cmbFroshande.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            this.cmbFroshande.DisplayLayout.Override.CellPadding = 0;
            appearance22.BackColor = System.Drawing.SystemColors.Control;
            appearance22.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance22.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
            appearance22.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance22.BorderColor = System.Drawing.SystemColors.Window;
            this.cmbFroshande.DisplayLayout.Override.GroupByRowAppearance = appearance22;
            appearance23.TextHAlignAsString = "Left";
            this.cmbFroshande.DisplayLayout.Override.HeaderAppearance = appearance23;
            this.cmbFroshande.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            this.cmbFroshande.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
            appearance24.BackColor = System.Drawing.SystemColors.Window;
            appearance24.BorderColor = System.Drawing.Color.Silver;
            this.cmbFroshande.DisplayLayout.Override.RowAppearance = appearance24;
            this.cmbFroshande.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            appearance25.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cmbFroshande.DisplayLayout.Override.TemplateAddRowAppearance = appearance25;
            this.cmbFroshande.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.cmbFroshande.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.cmbFroshande.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.cmbFroshande.DisplayMember = "name_fro";
            this.cmbFroshande.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmbFroshande.Location = new System.Drawing.Point(1056, 52);
            this.cmbFroshande.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFroshande.Name = "cmbFroshande";
            this.cmbFroshande.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbFroshande.Size = new System.Drawing.Size(209, 39);
            this.cmbFroshande.TabIndex = 4;
            this.cmbFroshande.ValueMember = "Code_fro";
            this.cmbFroshande.Enter += new System.EventHandler(this.cmbFroshande_Enter);
            this.cmbFroshande.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cdresid_KeyDown);
            this.cmbFroshande.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cmbFroshande_KeyUp);
            this.cmbFroshande.Leave += new System.EventHandler(this.cmbFroshande_Leave);
            // 
            // viewPersonBS
            // 
            this.viewPersonBS.DataMember = "View_Person";
            this.viewPersonBS.DataSource = this.db_DataSetResid;
            // 
            // txtCodeFak
            // 
            this.txtCodeFak.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodeFak.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblResidBS, "Code_faktor", true));
            this.txtCodeFak.Location = new System.Drawing.Point(773, 52);
            this.txtCodeFak.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodeFak.MaxLength = 15;
            this.txtCodeFak.Name = "txtCodeFak";
            this.txtCodeFak.Size = new System.Drawing.Size(155, 38);
            this.txtCodeFak.TabIndex = 5;
            this.txtCodeFak.Enter += new System.EventHandler(this.txtCodeFak_Enter);
            this.txtCodeFak.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cdresid_KeyDown);
            this.txtCodeFak.Leave += new System.EventHandler(this.txtCodeFak_Leave);
            // 
            // ultraLabel5
            // 
            this.ultraLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraLabel5.Location = new System.Drawing.Point(901, 56);
            this.ultraLabel5.Margin = new System.Windows.Forms.Padding(2);
            this.ultraLabel5.Name = "ultraLabel5";
            this.ultraLabel5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ultraLabel5.Size = new System.Drawing.Size(126, 30);
            this.ultraLabel5.TabIndex = 4;
            this.ultraLabel5.Text = "شماره بارنامه";
            // 
            // ultraLabel6
            // 
            this.ultraLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraLabel6.Location = new System.Drawing.Point(655, 56);
            this.ultraLabel6.Margin = new System.Windows.Forms.Padding(2);
            this.ultraLabel6.Name = "ultraLabel6";
            this.ultraLabel6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ultraLabel6.Size = new System.Drawing.Size(81, 30);
            this.ultraLabel6.TabIndex = 4;
            this.ultraLabel6.Text = "تاریخ بارنامه";
            // 
            // ultraLabel7
            // 
            this.ultraLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraLabel7.Location = new System.Drawing.Point(1254, 99);
            this.ultraLabel7.Margin = new System.Windows.Forms.Padding(2);
            this.ultraLabel7.Name = "ultraLabel7";
            this.ultraLabel7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ultraLabel7.Size = new System.Drawing.Size(92, 30);
            this.ultraLabel7.TabIndex = 4;
            this.ultraLabel7.Text = "نام راننده";
            // 
            // txtNumCar
            // 
            this.txtNumCar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            appearance26.TextHAlignAsString = "Right";
            this.txtNumCar.Appearance = appearance26;
            this.txtNumCar.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblResidBS, "Number_car", true));
            this.txtNumCar.Location = new System.Drawing.Point(737, 95);
            this.txtNumCar.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumCar.MaxLength = 20;
            this.txtNumCar.Name = "txtNumCar";
            this.txtNumCar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNumCar.Size = new System.Drawing.Size(192, 36);
            this.txtNumCar.TabIndex = 8;
            this.txtNumCar.Enter += new System.EventHandler(this.txtCodeFak_Enter);
            this.txtNumCar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cdresid_KeyDown);
            this.txtNumCar.Leave += new System.EventHandler(this.txtCodeFak_Leave);
            // 
            // ultraLabel8
            // 
            this.ultraLabel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraLabel8.Location = new System.Drawing.Point(901, 99);
            this.ultraLabel8.Margin = new System.Windows.Forms.Padding(2);
            this.ultraLabel8.Name = "ultraLabel8";
            this.ultraLabel8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ultraLabel8.Size = new System.Drawing.Size(125, 30);
            this.ultraLabel8.TabIndex = 4;
            this.ultraLabel8.Text = "شماره ماشین";
            // 
            // cmbAnbar
            // 
            this.cmbAnbar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbAnbar.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            this.cmbAnbar.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tblResidBS, "Code_anbar", true));
            this.cmbAnbar.DataMember = "View_Anbar";
            this.cmbAnbar.DataSource = this.db_DataSetResid;
            this.cmbAnbar.DisplayMember = "Name_anbar";
            this.cmbAnbar.Location = new System.Drawing.Point(1056, 138);
            this.cmbAnbar.Margin = new System.Windows.Forms.Padding(2);
            this.cmbAnbar.Name = "cmbAnbar";
            this.cmbAnbar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbAnbar.Size = new System.Drawing.Size(209, 36);
            this.cmbAnbar.TabIndex = 9;
            this.cmbAnbar.ValueMember = "Code_anbar";
            this.cmbAnbar.Enter += new System.EventHandler(this.cmbResidType_Enter);
            this.cmbAnbar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cdresid_KeyDown);
            this.cmbAnbar.Leave += new System.EventHandler(this.cmbResidType_Leave);
            // 
            // cmbTahvil
            // 
            this.cmbTahvil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTahvil.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            this.cmbTahvil.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tblResidBS, "Code_tahvil", true));
            this.cmbTahvil.DataMember = "View_Tahvil";
            this.cmbTahvil.DataSource = this.db_DataSetResid;
            this.cmbTahvil.DisplayMember = "Name_tahvil";
            this.cmbTahvil.Location = new System.Drawing.Point(774, 138);
            this.cmbTahvil.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTahvil.Name = "cmbTahvil";
            this.cmbTahvil.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbTahvil.Size = new System.Drawing.Size(155, 36);
            this.cmbTahvil.TabIndex = 10;
            this.cmbTahvil.ValueMember = "Code_tahvil";
            this.cmbTahvil.Enter += new System.EventHandler(this.cmbResidType_Enter);
            this.cmbTahvil.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cdresid_KeyDown);
            this.cmbTahvil.Leave += new System.EventHandler(this.cmbResidType_Leave);
            // 
            // ultraLabel9
            // 
            this.ultraLabel9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraLabel9.Location = new System.Drawing.Point(1269, 142);
            this.ultraLabel9.Margin = new System.Windows.Forms.Padding(2);
            this.ultraLabel9.Name = "ultraLabel9";
            this.ultraLabel9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ultraLabel9.Size = new System.Drawing.Size(77, 30);
            this.ultraLabel9.TabIndex = 4;
            this.ultraLabel9.Text = "نام انبار";
            // 
            // ultraLabel10
            // 
            this.ultraLabel10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraLabel10.Location = new System.Drawing.Point(929, 149);
            this.ultraLabel10.Margin = new System.Windows.Forms.Padding(2);
            this.ultraLabel10.Name = "ultraLabel10";
            this.ultraLabel10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ultraLabel10.Size = new System.Drawing.Size(98, 30);
            this.ultraLabel10.TabIndex = 4;
            this.ultraLabel10.Text = "نام گیرنده";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(1056, 8);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(92, 37);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.TabStop = false;
            this.btnSearch.Text = "جست و جو";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // ultraLabel11
            // 
            this.ultraLabel11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraLabel11.Location = new System.Drawing.Point(1245, 582);
            this.ultraLabel11.Margin = new System.Windows.Forms.Padding(2);
            this.ultraLabel11.Name = "ultraLabel11";
            this.ultraLabel11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ultraLabel11.Size = new System.Drawing.Size(107, 31);
            this.ultraLabel11.TabIndex = 4;
            this.ultraLabel11.Text = "هزینه حمل";
            // 
            // ultraLabel12
            // 
            this.ultraLabel12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraLabel12.Location = new System.Drawing.Point(980, 582);
            this.ultraLabel12.Margin = new System.Windows.Forms.Padding(2);
            this.ultraLabel12.Name = "ultraLabel12";
            this.ultraLabel12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ultraLabel12.Size = new System.Drawing.Size(127, 30);
            this.ultraLabel12.TabIndex = 4;
            this.ultraLabel12.Text = "هزینه بارگیری";
            // 
            // ultraLabel13
            // 
            this.ultraLabel13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraLabel13.Location = new System.Drawing.Point(737, 582);
            this.ultraLabel13.Margin = new System.Windows.Forms.Padding(2);
            this.ultraLabel13.Name = "ultraLabel13";
            this.ultraLabel13.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ultraLabel13.Size = new System.Drawing.Size(104, 30);
            this.ultraLabel13.TabIndex = 4;
            this.ultraLabel13.Text = "هزینه تخلیه";
            // 
            // ultraLabel14
            // 
            this.ultraLabel14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraLabel14.Location = new System.Drawing.Point(477, 582);
            this.ultraLabel14.Margin = new System.Windows.Forms.Padding(2);
            this.ultraLabel14.Name = "ultraLabel14";
            this.ultraLabel14.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ultraLabel14.Size = new System.Drawing.Size(108, 30);
            this.ultraLabel14.TabIndex = 4;
            this.ultraLabel14.Text = "سایر هزینه ها";
            // 
            // ultraLabel15
            // 
            this.ultraLabel15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraLabel15.Location = new System.Drawing.Point(260, 582);
            this.ultraLabel15.Margin = new System.Windows.Forms.Padding(2);
            this.ultraLabel15.Name = "ultraLabel15";
            this.ultraLabel15.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ultraLabel15.Size = new System.Drawing.Size(67, 30);
            this.ultraLabel15.TabIndex = 4;
            this.ultraLabel15.Text = "تخفیف";
            this.ultraLabel15.Visible = false;
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
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 36);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Current position";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(53, 52);
            this.toolStripLabel1.Text = "از {0}";
            this.toolStripLabel1.ToolTipText = "Total number of items";
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
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 55);
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
            // toolStripDel
            // 
            this.toolStripDel.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDel.Image")));
            this.toolStripDel.Name = "toolStripDel";
            this.toolStripDel.RightToLeftAutoMirrorImage = true;
            this.toolStripDel.Size = new System.Drawing.Size(48, 52);
            this.toolStripDel.Text = "حذف";
            this.toolStripDel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripDel.ToolTipText = "حذف رکورد جاری";
            this.toolStripDel.Click += new System.EventHandler(this.toolStripDel_Click);
            // 
            // bNavigatorResid
            // 
            this.bNavigatorResid.AddNewItem = this.toolStripAdd;
            this.bNavigatorResid.BindingSource = this.tblResidBS;
            this.bNavigatorResid.CountItem = this.toolStripLabel1;
            this.bNavigatorResid.CountItemFormat = "از {0}";
            this.bNavigatorResid.DeleteItem = this.toolStripDel;
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
            this.toolStripDel,
            this.toolStripSave,
            this.toolStripSeparator4,
            this.printToolStripButton});
            this.bNavigatorResid.Location = new System.Drawing.Point(0, 691);
            this.bNavigatorResid.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bNavigatorResid.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bNavigatorResid.MoveNextItem = this.toolStripButton4;
            this.bNavigatorResid.MovePreviousItem = this.toolStripButton3;
            this.bNavigatorResid.Name = "bNavigatorResid";
            this.bNavigatorResid.Padding = new System.Windows.Forms.Padding(0);
            this.bNavigatorResid.PositionItem = this.toolStripTextBox1;
            this.bNavigatorResid.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.bNavigatorResid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bNavigatorResid.Size = new System.Drawing.Size(1359, 55);
            this.bNavigatorResid.TabIndex = 28;
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
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(92, 52);
            this.bindingNavigatorMoveLastItem.Text = "آخرین رکورد";
            this.bindingNavigatorMoveLastItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSave
            // 
            this.toolStripSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSave.Image")));
            this.toolStripSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSave.Name = "toolStripSave";
            this.toolStripSave.Size = new System.Drawing.Size(88, 52);
            this.toolStripSave.Text = "ذخیره کردن";
            this.toolStripSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripSave.ToolTipText = "ذخیره سازی اطلاعات موجود";
            this.toolStripSave.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 55);
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
            // CmbDriver
            // 
            this.CmbDriver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbDriver.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            this.CmbDriver.AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.Contains;
            this.CmbDriver.CalcManager = this.ultraCalc1;
            this.CmbDriver.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tblResidBS, "Code_driver", true));
            this.CmbDriver.DataSource = this.viewDriverBS;
            appearance2.BackColor = System.Drawing.SystemColors.Window;
            appearance2.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.CmbDriver.DisplayLayout.Appearance = appearance2;
            this.CmbDriver.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn;
            ultraGridColumn47.Header.VisiblePosition = 2;
            ultraGridColumn127.Header.VisiblePosition = 0;
            ultraGridColumn128.Header.VisiblePosition = 1;
            ultraGridColumn54.Header.VisiblePosition = 3;
            ultraGridColumn53.Header.Caption = "موبایل";
            ultraGridColumn53.Header.VisiblePosition = 4;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn47,
            ultraGridColumn127,
            ultraGridColumn128,
            ultraGridColumn54,
            ultraGridColumn53});
            this.CmbDriver.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.CmbDriver.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.CmbDriver.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            appearance3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            appearance3.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance3.BorderColor = System.Drawing.SystemColors.Window;
            this.CmbDriver.DisplayLayout.GroupByBox.Appearance = appearance3;
            appearance4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.CmbDriver.DisplayLayout.GroupByBox.BandLabelAppearance = appearance4;
            this.CmbDriver.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            appearance5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            appearance5.BackColor2 = System.Drawing.SystemColors.Control;
            appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance5.ForeColor = System.Drawing.SystemColors.GrayText;
            this.CmbDriver.DisplayLayout.GroupByBox.PromptAppearance = appearance5;
            this.CmbDriver.DisplayLayout.MaxColScrollRegions = 1;
            this.CmbDriver.DisplayLayout.MaxRowScrollRegions = 1;
            appearance6.BackColor = System.Drawing.SystemColors.Window;
            appearance6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CmbDriver.DisplayLayout.Override.ActiveCellAppearance = appearance6;
            appearance7.BackColor = System.Drawing.SystemColors.Highlight;
            appearance7.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CmbDriver.DisplayLayout.Override.ActiveRowAppearance = appearance7;
            this.CmbDriver.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted;
            this.CmbDriver.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
            appearance8.BackColor = System.Drawing.SystemColors.Window;
            this.CmbDriver.DisplayLayout.Override.CardAreaAppearance = appearance8;
            appearance9.BorderColor = System.Drawing.Color.Silver;
            appearance9.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter;
            this.CmbDriver.DisplayLayout.Override.CellAppearance = appearance9;
            this.CmbDriver.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            this.CmbDriver.DisplayLayout.Override.CellPadding = 0;
            appearance10.BackColor = System.Drawing.SystemColors.Control;
            appearance10.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance10.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
            appearance10.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance10.BorderColor = System.Drawing.SystemColors.Window;
            this.CmbDriver.DisplayLayout.Override.GroupByRowAppearance = appearance10;
            appearance11.TextHAlignAsString = "Left";
            this.CmbDriver.DisplayLayout.Override.HeaderAppearance = appearance11;
            this.CmbDriver.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            this.CmbDriver.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
            appearance12.BackColor = System.Drawing.SystemColors.Window;
            appearance12.BorderColor = System.Drawing.Color.Silver;
            this.CmbDriver.DisplayLayout.Override.RowAppearance = appearance12;
            this.CmbDriver.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            appearance13.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CmbDriver.DisplayLayout.Override.TemplateAddRowAppearance = appearance13;
            this.CmbDriver.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.CmbDriver.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.CmbDriver.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.CmbDriver.DisplayMember = "name_fro";
            this.CmbDriver.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.CmbDriver.Location = new System.Drawing.Point(1056, 95);
            this.CmbDriver.Margin = new System.Windows.Forms.Padding(2);
            this.CmbDriver.Name = "CmbDriver";
            this.CmbDriver.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CmbDriver.Size = new System.Drawing.Size(209, 39);
            this.CmbDriver.TabIndex = 7;
            this.CmbDriver.ValueMember = "Code_fro";
            this.CmbDriver.Enter += new System.EventHandler(this.cmbFroshande_Enter);
            this.CmbDriver.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cdresid_KeyDown);
            this.CmbDriver.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CmbDriver_KeyUp);
            this.CmbDriver.Leave += new System.EventHandler(this.CmbDriver_Leave);
            // 
            // viewDriverBS
            // 
            this.viewDriverBS.DataMember = "View_Driver";
            this.viewDriverBS.DataSource = this.db_DataSetResid;
            // 
            // ubtnComite
            // 
            this.ubtnComite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            appearance1.Image = global::DamProducer.Properties.Resources.ok;
            this.ubtnComite.Appearance = appearance1;
            this.ubtnComite.ImageSize = new System.Drawing.Size(24, 24);
            this.ubtnComite.Location = new System.Drawing.Point(542, 140);
            this.ubtnComite.Margin = new System.Windows.Forms.Padding(2);
            this.ubtnComite.Name = "ubtnComite";
            this.ubtnComite.Size = new System.Drawing.Size(185, 36);
            this.ubtnComite.TabIndex = 11;
            this.ubtnComite.Text = "تایید";
            this.ubtnComite.Click += new System.EventHandler(this.ubtnComite_Click);
            // 
            // err
            // 
            this.err.ContainerControl = this;
            this.err.RightToLeft = true;
            // 
            // txtCode
            // 
            this.txtCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCode.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tblResidBS, "Code_resid", true));
            this.txtCode.Location = new System.Drawing.Point(1152, 7);
            this.txtCode.Margin = new System.Windows.Forms.Padding(2);
            this.txtCode.Name = "txtCode";
            this.txtCode.ReadOnly = true;
            this.txtCode.Size = new System.Drawing.Size(114, 38);
            this.txtCode.TabIndex = 0;
            this.txtCode.TabStop = false;
            this.txtCode.ValueChanged += new System.EventHandler(this.txtCode_ValueChanged);
            // 
            // CdResid
            // 
            this.CdResid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CdResid.Location = new System.Drawing.Point(1151, 8);
            this.CdResid.Margin = new System.Windows.Forms.Padding(2);
            this.CdResid.Name = "CdResid";
            this.CdResid.ReadOnly = true;
            this.CdResid.Size = new System.Drawing.Size(114, 38);
            this.CdResid.TabIndex = 0;
            this.CdResid.TabStop = false;
            this.CdResid.Visible = false;
            this.CdResid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cdresid_KeyDown);
            // 
            // txtHaml
            // 
            this.txtHaml.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHaml.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblResidBS, "Price_haml", true));
            this.txtHaml.Location = new System.Drawing.Point(1112, 576);
            this.txtHaml.Name = "txtHaml";
            this.txtHaml.Size = new System.Drawing.Size(125, 36);
            this.txtHaml.TabIndex = 13;
            this.txtHaml.Enter += new System.EventHandler(this.txtHaml_Enter);
            this.txtHaml.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cdresid_KeyDown);
            this.txtHaml.Leave += new System.EventHandler(this.txtHaml_Leave);
            // 
            // txtBargiri
            // 
            this.txtBargiri.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBargiri.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblResidBS, "Price_bargiri", true));
            this.txtBargiri.Location = new System.Drawing.Point(850, 576);
            this.txtBargiri.Name = "txtBargiri";
            this.txtBargiri.Size = new System.Drawing.Size(125, 36);
            this.txtBargiri.TabIndex = 14;
            this.txtBargiri.Enter += new System.EventHandler(this.txtHaml_Enter);
            this.txtBargiri.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cdresid_KeyDown);
            this.txtBargiri.Leave += new System.EventHandler(this.txtHaml_Leave);
            // 
            // txtTakhlie
            // 
            this.txtTakhlie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTakhlie.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblResidBS, "Price_takhlye", true));
            this.txtTakhlie.Location = new System.Drawing.Point(599, 576);
            this.txtTakhlie.Name = "txtTakhlie";
            this.txtTakhlie.Size = new System.Drawing.Size(125, 36);
            this.txtTakhlie.TabIndex = 15;
            this.txtTakhlie.Enter += new System.EventHandler(this.txtHaml_Enter);
            this.txtTakhlie.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cdresid_KeyDown);
            this.txtTakhlie.Leave += new System.EventHandler(this.txtHaml_Leave);
            // 
            // txtOther
            // 
            this.txtOther.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOther.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblResidBS, "Price_other", true));
            this.txtOther.Location = new System.Drawing.Point(338, 576);
            this.txtOther.Name = "txtOther";
            this.txtOther.Size = new System.Drawing.Size(125, 36);
            this.txtOther.TabIndex = 16;
            this.txtOther.Enter += new System.EventHandler(this.txtHaml_Enter);
            this.txtOther.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cdresid_KeyDown);
            this.txtOther.Leave += new System.EventHandler(this.txtHaml_Leave);
            // 
            // txtTakhfif
            // 
            this.txtTakhfif.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTakhfif.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblResidBS, "Takhfif", true));
            this.txtTakhfif.Location = new System.Drawing.Point(130, 576);
            this.txtTakhfif.Name = "txtTakhfif";
            this.txtTakhfif.Size = new System.Drawing.Size(125, 36);
            this.txtTakhfif.TabIndex = 17;
            this.txtTakhfif.Visible = false;
            this.txtTakhfif.Enter += new System.EventHandler(this.txtHaml_Enter);
            this.txtTakhfif.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cdresid_KeyDown);
            this.txtTakhfif.Leave += new System.EventHandler(this.txtHaml_Leave);
            // 
            // tbl_ResidTA
            // 
            this.tbl_ResidTA.ClearBeforeFill = true;
            // 
            // view_MatterTA
            // 
            this.view_MatterTA.ClearBeforeFill = true;
            // 
            // view_AnbarTA
            // 
            this.view_AnbarTA.ClearBeforeFill = true;
            // 
            // tbl_ResidRizTA
            // 
            this.tbl_ResidRizTA.ClearBeforeFill = true;
            // 
            // view_VahedTA
            // 
            this.view_VahedTA.ClearBeforeFill = true;
            // 
            // view_PersonTA
            // 
            this.view_PersonTA.ClearBeforeFill = true;
            // 
            // view_DriverTA
            // 
            this.view_DriverTA.ClearBeforeFill = true;
            // 
            // view_TahvilTA
            // 
            this.view_TahvilTA.ClearBeforeFill = true;
            // 
            // view_ResidTA
            // 
            this.view_ResidTA.ClearBeforeFill = true;
            // 
            // view_ResidrRizTA
            // 
            this.view_ResidrRizTA.ClearBeforeFill = true;
            // 
            // rpt1
            // 
            this.rpt1.NeedRefresh = false;
            this.rpt1.ReportResourceString = resources.GetString("rpt1.ReportResourceString");
            this.rpt1.Tag = null;
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(11, 12);
            this.btnReload.Margin = new System.Windows.Forms.Padding(2);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(151, 38);
            this.btnReload.TabIndex = 31;
            this.btnReload.Text = "بارگزاری مجدد";
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // tbl_NoeResidTA
            // 
            this.tbl_NoeResidTA.ClearBeforeFill = true;
            // 
            // txtHamlK
            // 
            this.txtHamlK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHamlK.Location = new System.Drawing.Point(1112, 625);
            this.txtHamlK.Name = "txtHamlK";
            this.txtHamlK.ReadOnly = true;
            this.txtHamlK.Size = new System.Drawing.Size(125, 36);
            this.txtHamlK.TabIndex = 13;
            this.txtHamlK.Enter += new System.EventHandler(this.txtHaml_Enter);
            this.txtHamlK.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cdresid_KeyDown);
            this.txtHamlK.Leave += new System.EventHandler(this.txtHaml_Leave);
            // 
            // txtBargiriK
            // 
            this.txtBargiriK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBargiriK.Location = new System.Drawing.Point(850, 625);
            this.txtBargiriK.Name = "txtBargiriK";
            this.txtBargiriK.ReadOnly = true;
            this.txtBargiriK.Size = new System.Drawing.Size(125, 36);
            this.txtBargiriK.TabIndex = 14;
            this.txtBargiriK.Enter += new System.EventHandler(this.txtHaml_Enter);
            this.txtBargiriK.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cdresid_KeyDown);
            this.txtBargiriK.Leave += new System.EventHandler(this.txtHaml_Leave);
            // 
            // txtTakhlieK
            // 
            this.txtTakhlieK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTakhlieK.Location = new System.Drawing.Point(599, 625);
            this.txtTakhlieK.Name = "txtTakhlieK";
            this.txtTakhlieK.ReadOnly = true;
            this.txtTakhlieK.Size = new System.Drawing.Size(125, 36);
            this.txtTakhlieK.TabIndex = 15;
            this.txtTakhlieK.Enter += new System.EventHandler(this.txtHaml_Enter);
            this.txtTakhlieK.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cdresid_KeyDown);
            this.txtTakhlieK.Leave += new System.EventHandler(this.txtHaml_Leave);
            // 
            // txtOtherK
            // 
            this.txtOtherK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOtherK.Location = new System.Drawing.Point(338, 625);
            this.txtOtherK.Name = "txtOtherK";
            this.txtOtherK.ReadOnly = true;
            this.txtOtherK.Size = new System.Drawing.Size(125, 36);
            this.txtOtherK.TabIndex = 15;
            this.txtOtherK.Enter += new System.EventHandler(this.txtHaml_Enter);
            this.txtOtherK.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cdresid_KeyDown);
            this.txtOtherK.Leave += new System.EventHandler(this.txtHaml_Leave);
            // 
            // ultraLabel16
            // 
            this.ultraLabel16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraLabel16.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ultraLabel16.Location = new System.Drawing.Point(1231, 632);
            this.ultraLabel16.Margin = new System.Windows.Forms.Padding(2);
            this.ultraLabel16.Name = "ultraLabel16";
            this.ultraLabel16.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ultraLabel16.Size = new System.Drawing.Size(121, 31);
            this.ultraLabel16.TabIndex = 4;
            this.ultraLabel16.Text = "هزینه حمل هر کیلو";
            // 
            // ultraLabel17
            // 
            this.ultraLabel17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraLabel17.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ultraLabel17.Location = new System.Drawing.Point(959, 632);
            this.ultraLabel17.Margin = new System.Windows.Forms.Padding(2);
            this.ultraLabel17.Name = "ultraLabel17";
            this.ultraLabel17.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ultraLabel17.Size = new System.Drawing.Size(148, 31);
            this.ultraLabel17.TabIndex = 4;
            this.ultraLabel17.Text = "هزینه بارگیری هر کیلو";
            // 
            // ultraLabel18
            // 
            this.ultraLabel18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraLabel18.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ultraLabel18.Location = new System.Drawing.Point(718, 632);
            this.ultraLabel18.Margin = new System.Windows.Forms.Padding(2);
            this.ultraLabel18.Name = "ultraLabel18";
            this.ultraLabel18.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ultraLabel18.Size = new System.Drawing.Size(127, 31);
            this.ultraLabel18.TabIndex = 4;
            this.ultraLabel18.Text = "هزینه تخلیه هر کیلو";
            // 
            // ultraLabel19
            // 
            this.ultraLabel19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraLabel19.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ultraLabel19.Location = new System.Drawing.Point(468, 632);
            this.ultraLabel19.Margin = new System.Windows.Forms.Padding(2);
            this.ultraLabel19.Name = "ultraLabel19";
            this.ultraLabel19.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ultraLabel19.Size = new System.Drawing.Size(117, 30);
            this.ultraLabel19.TabIndex = 4;
            this.ultraLabel19.Text = "سایر هزینه هر کیلو";
            // 
            // txtDateResid
            // 
            this.txtDateResid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDateResid.Culture = new System.Globalization.CultureInfo("fa-IR");
            this.txtDateResid.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblResidBS, "Date_resid", true));
            this.txtDateResid.Location = new System.Drawing.Point(542, 9);
            this.txtDateResid.Mask = "####/##/##";
            this.txtDateResid.Name = "txtDateResid";
            this.txtDateResid.Size = new System.Drawing.Size(105, 36);
            this.txtDateResid.TabIndex = 3;
            this.txtDateResid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cdresid_KeyDown);
            // 
            // txtDateFak
            // 
            this.txtDateFak.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDateFak.Culture = new System.Globalization.CultureInfo("fa-IR");
            this.txtDateFak.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblResidBS, "Date_faktor", true));
            this.txtDateFak.Location = new System.Drawing.Point(542, 52);
            this.txtDateFak.Mask = "####/##/##";
            this.txtDateFak.Name = "txtDateFak";
            this.txtDateFak.Size = new System.Drawing.Size(105, 36);
            this.txtDateFak.TabIndex = 6;
            this.txtDateFak.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cdresid_KeyDown);
            // 
            // frmResid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1359, 746);
            this.Controls.Add(this.txtDateFak);
            this.Controls.Add(this.txtDateResid);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.txtTakhfif);
            this.Controls.Add(this.txtOther);
            this.Controls.Add(this.txtOtherK);
            this.Controls.Add(this.txtTakhlieK);
            this.Controls.Add(this.txtTakhlie);
            this.Controls.Add(this.txtBargiriK);
            this.Controls.Add(this.txtBargiri);
            this.Controls.Add(this.txtHamlK);
            this.Controls.Add(this.txtHaml);
            this.Controls.Add(this.CdResid);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.bNavigatorResid);
            this.Controls.Add(this.ubtnComite);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.CmbDriver);
            this.Controls.Add(this.cmbFroshande);
            this.Controls.Add(this.cmbVahed);
            this.Controls.Add(this.cmbTahvil);
            this.Controls.Add(this.CmbMater);
            this.Controls.Add(this.cmbAnbar);
            this.Controls.Add(this.cmbResidType);
            this.Controls.Add(this.ultraLabel4);
            this.Controls.Add(this.ultraLabel10);
            this.Controls.Add(this.ultraLabel9);
            this.Controls.Add(this.ultraLabel7);
            this.Controls.Add(this.ultraLabel19);
            this.Controls.Add(this.ultraLabel14);
            this.Controls.Add(this.ultraLabel13);
            this.Controls.Add(this.ultraLabel12);
            this.Controls.Add(this.ultraLabel15);
            this.Controls.Add(this.ultraLabel18);
            this.Controls.Add(this.ultraLabel17);
            this.Controls.Add(this.ultraLabel16);
            this.Controls.Add(this.ultraLabel11);
            this.Controls.Add(this.ultraLabel6);
            this.Controls.Add(this.ultraLabel2);
            this.Controls.Add(this.ultraLabel1);
            this.Controls.Add(this.txtNumCar);
            this.Controls.Add(this.txtCodeFak);
            this.Controls.Add(this.UGrid);
            this.Controls.Add(this.ultraLabel8);
            this.Controls.Add(this.ultraLabel3);
            this.Controls.Add(this.ultraLabel5);
            this.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmResid";
            this.Text = "رسید کالا";
            this.Load += new System.EventHandler(this.frmResid_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmResid_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.CmbMater)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_DataSetResid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbVahed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCalc1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TblResidRizTblResidBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblResidBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbResidType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFroshande)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewPersonBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodeFak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAnbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTahvil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bNavigatorResid)).EndInit();
            this.bNavigatorResid.ResumeLayout(false);
            this.bNavigatorResid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CmbDriver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewDriverBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CdResid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpt1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Infragistics.Win.Misc.UltraLabel ultraLabel1;
        private Infragistics.Win.UltraWinGrid.UltraGrid UGrid;
        private Infragistics.Win.Misc.UltraLabel ultraLabel2;
        private Infragistics.Win.UltraWinEditors.UltraComboEditor cmbResidType;
        private Infragistics.Win.Misc.UltraLabel ultraLabel3;
        private Infragistics.Win.UltraWinEditors.UltraComboEditor cmbVahed;
        private Infragistics.Win.Misc.UltraLabel ultraLabel4;
        private Infragistics.Win.UltraWinGrid.UltraCombo cmbFroshande;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtCodeFak;
        private Infragistics.Win.Misc.UltraLabel ultraLabel5;
        private Infragistics.Win.Misc.UltraLabel ultraLabel6;
        private Infragistics.Win.Misc.UltraLabel ultraLabel7;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtNumCar;
        private Infragistics.Win.Misc.UltraLabel ultraLabel8;
        private Infragistics.Win.UltraWinEditors.UltraComboEditor cmbAnbar;
        private Infragistics.Win.UltraWinEditors.UltraComboEditor cmbTahvil;
        private Infragistics.Win.Misc.UltraLabel ultraLabel9;
        private Infragistics.Win.Misc.UltraLabel ultraLabel10;
        private Infragistics.Win.Misc.UltraButton btnSearch;
        private Infragistics.Win.Misc.UltraLabel ultraLabel14;
        private Infragistics.Win.Misc.UltraLabel ultraLabel13;
        private Infragistics.Win.Misc.UltraLabel ultraLabel12;
        private Infragistics.Win.Misc.UltraLabel ultraLabel15;
        private Infragistics.Win.Misc.UltraLabel ultraLabel11;
        private Dset.db_DataSetResid db_DataSetResid;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripAdd;
        private System.Windows.Forms.ToolStripButton toolStripDel;
        private System.Windows.Forms.BindingNavigator bNavigatorResid;
        private System.Windows.Forms.BindingSource tblResidBS;
        private Dset.db_DataSetResidTableAdapters.Tbl_ResidTA tbl_ResidTA;
        private Dset.db_DataSetResidTableAdapters.View_MatterTA view_MatterTA;
        private Dset.db_DataSetResidTableAdapters.View_VahedTA view_VahedTA;
        private System.Windows.Forms.BindingSource viewPersonBS;
        private Dset.db_DataSetResidTableAdapters.View_PersonTA view_PersonTA;
        private Infragistics.Win.UltraWinGrid.UltraCombo CmbDriver;
        private System.Windows.Forms.BindingSource viewDriverBS;
        private Dset.db_DataSetResidTableAdapters.View_DriverTA view_DriverTA;
        private Dset.db_DataSetResidTableAdapters.View_AnbarTA view_AnbarTA;
        private Dset.db_DataSetResidTableAdapters.View_TahvilTA view_TahvilTA;
        private System.Windows.Forms.ToolStripButton toolStripSave;
        private Infragistics.Win.UltraWinCalcManager.UltraCalcManager ultraCalc1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.BindingSource TblResidRizTblResidBS;
        private Dset.db_DataSetResidTableAdapters.Tbl_ResidRizTA tbl_ResidRizTA;
        private Infragistics.Win.UltraWinEditors.UltraComboEditor CmbMater;
        private Infragistics.Win.Misc.UltraButton ubtnComite;
        private System.Windows.Forms.ErrorProvider err;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtCode;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor CdResid;
        private ArzTextBox.ArzTextBox txtTakhfif;
        private ArzTextBox.ArzTextBox txtOther;
        private ArzTextBox.ArzTextBox txtTakhlie;
        private ArzTextBox.ArzTextBox txtBargiri;
        private ArzTextBox.ArzTextBox txtHaml;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private Dset.db_DataSetResidTableAdapters.View_ResidTA view_ResidTA;
        private Dset.db_DataSetResidTableAdapters.View_ResidrRizTA view_ResidrRizTA;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private FastReport.Report rpt1;
        private Infragistics.Win.Misc.UltraButton btnReload;
        private Dset.db_DataSetResidTableAdapters.Tbl_NoeResidTA tbl_NoeResidTA;
        private ArzTextBox.ArzTextBox txtOtherK;
        private ArzTextBox.ArzTextBox txtTakhlieK;
        private ArzTextBox.ArzTextBox txtBargiriK;
        private ArzTextBox.ArzTextBox txtHamlK;
        private Infragistics.Win.Misc.UltraLabel ultraLabel17;
        private Infragistics.Win.Misc.UltraLabel ultraLabel16;
        private Infragistics.Win.Misc.UltraLabel ultraLabel19;
        private Infragistics.Win.Misc.UltraLabel ultraLabel18;
        private DateControlBT.PDateBox txtDateFak;
        private DateControlBT.PDateBox txtDateResid;
    }
}