namespace DamProducer
{
    partial class frmPishFaktor
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
            Infragistics.Win.ValueListItem valueListItem1 = new Infragistics.Win.ValueListItem();
            Infragistics.Win.ValueListItem valueListItem2 = new Infragistics.Win.ValueListItem();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("View_KolMavad", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn3 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Code_kol");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn4 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("cnt");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn5 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Date");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn6 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Hazine_other");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn7 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Hazine_Kise");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn8 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Hazine_Tolid");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn9 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Oft_Tolid");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn10 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Jam");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn11 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Code_fro");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn12 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("en");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn13 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Type");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn14 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Takhfif");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn15 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Price_Tak");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn16 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Price_Amel");
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPishFaktor));
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            this.ultraCalc1 = new Infragistics.Win.UltraWinCalcManager.UltraCalcManager(this.components);
            this.db_DataSetContent = new DamProducer.Dset.db_DataSetContent();
            this.txtCode = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.tblPishFaktorBS = new System.Windows.Forms.BindingSource(this.components);
            this.db_DataSetDarkhast = new DamProducer.Dset.db_DataSetDarkhast();
            this.cmbType = new Infragistics.Win.UltraWinEditors.UltraComboEditor();
            this.ultraLabel4 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel3 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel2 = new Infragistics.Win.Misc.UltraLabel();
            this.ubtnComite = new Infragistics.Win.Misc.UltraButton();
            this.cmbProduct = new Infragistics.Win.UltraWinGrid.UltraCombo();
            this.viewKolMavadBS = new System.Windows.Forms.BindingSource(this.components);
            this.bNav = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.printsfStripButton = new System.Windows.Forms.ToolStripButton();
            this.ultraLabel5 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel6 = new Infragistics.Win.Misc.UltraLabel();
            this.cmbNoe = new Infragistics.Win.UltraWinEditors.UltraComboEditor();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.UMBox = new Infragistics.Win.Misc.UltraGroupBox();
            this.VaznSefaresh = new System.Windows.Forms.TextBox();
            this.txtVKisesf = new System.Windows.Forms.TextBox();
            this.txtTakhfifKol = new ArzTextBox.ArzTextBox();
            this.txtjamTemp = new ArzTextBox.ArzTextBox();
            this.txtKol = new ArzTextBox.ArzTextBox();
            this.txtPvahed = new ArzTextBox.ArzTextBox();
            this.txtTkise = new ArzTextBox.ArzTextBox();
            this.ultraLabel12 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel15 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel9 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel11 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel8 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel14 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel13 = new Infragistics.Win.Misc.UltraLabel();
            this.txtTakhfif = new System.Windows.Forms.TextBox();
            this.txtKise = new System.Windows.Forms.TextBox();
            this.txtJamKol = new System.Windows.Forms.TextBox();
            this.txtOft = new System.Windows.Forms.TextBox();
            this.txtOther = new System.Windows.Forms.TextBox();
            this.txtTolid = new System.Windows.Forms.TextBox();
            this.ultraLabel7 = new Infragistics.Win.Misc.UltraLabel();
            this.lblCodeFk = new Infragistics.Win.Misc.UltraLabel();
            this.ultraButton1 = new Infragistics.Win.Misc.UltraButton();
            this.txtAdress = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.ultraLabel10 = new Infragistics.Win.Misc.UltraLabel();
            this.txtName = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.txtTel = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.ultraLabel16 = new Infragistics.Win.Misc.UltraLabel();
            this.txtMeliCode = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.ultraLabel17 = new Infragistics.Win.Misc.UltraLabel();
            this.tbl_NoeTA = new DamProducer.Dset.db_DataSetDarkhastTableAdapters.Tbl_NoeTA();
            this.view_KolMavadTA = new DamProducer.Dset.db_DataSetDarkhastTableAdapters.View_KolMavadTA();
            this.tbl_PishFaktorTA = new DamProducer.Dset.db_DataSetDarkhastTableAdapters.Tbl_PishFaktorTA();
            this.view_PishFaktorAD = new DamProducer.Dset.db_DataSetDarkhastTableAdapters.View_PishFaktorTA();
            this.txtDate = new DateControlBT.PDateBox();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCalc1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_DataSetContent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPishFaktorBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_DataSetDarkhast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewKolMavadBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bNav)).BeginInit();
            this.bNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbNoe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UMBox)).BeginInit();
            this.UMBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMeliCode)).BeginInit();
            this.SuspendLayout();
            // 
            // ultraCalc1
            // 
            this.ultraCalc1.ContainingControl = this;
            this.ultraCalc1.NamedReferences.AddRange(new object[] {
            new Infragistics.Win.UltraWinCalcManager.NamedReference("NamedReference 0", null, null, null)});
            // 
            // db_DataSetContent
            // 
            this.db_DataSetContent.DataSetName = "db_DataSetContent";
            this.db_DataSetContent.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtCode
            // 
            this.txtCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblPishFaktorBS, "Code_Darkhast", true));
            this.txtCode.Location = new System.Drawing.Point(1153, 1);
            this.txtCode.Margin = new System.Windows.Forms.Padding(2);
            this.txtCode.Name = "txtCode";
            this.txtCode.ReadOnly = true;
            this.txtCode.Size = new System.Drawing.Size(115, 38);
            this.txtCode.TabIndex = 0;
            this.txtCode.ValueChanged += new System.EventHandler(this.txtCode_ValueChanged);
            this.txtCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCode_KeyDown);
            // 
            // tblPishFaktorBS
            // 
            this.tblPishFaktorBS.DataMember = "Tbl_PishFaktor";
            this.tblPishFaktorBS.DataSource = this.db_DataSetDarkhast;
            // 
            // db_DataSetDarkhast
            // 
            this.db_DataSetDarkhast.DataSetName = "db_DataSetDarkhast";
            this.db_DataSetDarkhast.EnforceConstraints = false;
            this.db_DataSetDarkhast.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbType
            // 
            this.cmbType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbType.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            this.cmbType.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tblPishFaktorBS, "Type", true));
            valueListItem1.DataValue = ((short)(0));
            valueListItem1.DisplayText = "بر اساس فرمول شرکت";
            valueListItem2.DataValue = ((short)(1));
            valueListItem2.DisplayText = "بر اساس سفارشی مشتری";
            this.cmbType.Items.AddRange(new Infragistics.Win.ValueListItem[] {
            valueListItem1,
            valueListItem2});
            this.cmbType.Location = new System.Drawing.Point(1083, 93);
            this.cmbType.Margin = new System.Windows.Forms.Padding(2);
            this.cmbType.Name = "cmbType";
            this.cmbType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbType.Size = new System.Drawing.Size(185, 36);
            this.cmbType.TabIndex = 6;
            this.cmbType.Enter += new System.EventHandler(this.cmbType_Enter);
            this.cmbType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCode_KeyDown);
            this.cmbType.Leave += new System.EventHandler(this.cmbType_Leave);
            // 
            // ultraLabel4
            // 
            this.ultraLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraLabel4.Location = new System.Drawing.Point(1276, 52);
            this.ultraLabel4.Margin = new System.Windows.Forms.Padding(2);
            this.ultraLabel4.Name = "ultraLabel4";
            this.ultraLabel4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ultraLabel4.Size = new System.Drawing.Size(76, 30);
            this.ultraLabel4.TabIndex = 34;
            this.ultraLabel4.Text = "نام خریدار";
            // 
            // ultraLabel3
            // 
            this.ultraLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraLabel3.Location = new System.Drawing.Point(975, 96);
            this.ultraLabel3.Margin = new System.Windows.Forms.Padding(2);
            this.ultraLabel3.Name = "ultraLabel3";
            this.ultraLabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ultraLabel3.Size = new System.Drawing.Size(80, 30);
            this.ultraLabel3.TabIndex = 35;
            this.ultraLabel3.Text = "نوع محصول";
            // 
            // ultraLabel1
            // 
            this.ultraLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraLabel1.Location = new System.Drawing.Point(991, 10);
            this.ultraLabel1.Margin = new System.Windows.Forms.Padding(2);
            this.ultraLabel1.Name = "ultraLabel1";
            this.ultraLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ultraLabel1.Size = new System.Drawing.Size(48, 30);
            this.ultraLabel1.TabIndex = 36;
            this.ultraLabel1.Text = "تاریخ";
            // 
            // ultraLabel2
            // 
            this.ultraLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraLabel2.Location = new System.Drawing.Point(1268, 9);
            this.ultraLabel2.Margin = new System.Windows.Forms.Padding(2);
            this.ultraLabel2.Name = "ultraLabel2";
            this.ultraLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ultraLabel2.Size = new System.Drawing.Size(93, 30);
            this.ultraLabel2.TabIndex = 36;
            this.ultraLabel2.Text = "شماره سفارش";
            // 
            // ubtnComite
            // 
            this.ubtnComite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            appearance3.Image = global::DamProducer.Properties.Resources.ok;
            this.ubtnComite.Appearance = appearance3;
            this.ubtnComite.ImageSize = new System.Drawing.Size(28, 28);
            this.ubtnComite.Location = new System.Drawing.Point(246, 93);
            this.ubtnComite.Margin = new System.Windows.Forms.Padding(2);
            this.ubtnComite.Name = "ubtnComite";
            this.ubtnComite.Size = new System.Drawing.Size(125, 37);
            this.ubtnComite.TabIndex = 9;
            this.ubtnComite.Text = "تایید";
            this.ubtnComite.Click += new System.EventHandler(this.ubtnComite_Click);
            // 
            // cmbProduct
            // 
            this.cmbProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbProduct.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            this.cmbProduct.AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.Contains;
            this.cmbProduct.CalcManager = this.ultraCalc1;
            this.cmbProduct.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tblPishFaktorBS, "Code_kol", true));
            this.cmbProduct.DataSource = this.viewKolMavadBS;
            appearance4.BackColor = System.Drawing.SystemColors.Window;
            appearance4.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.cmbProduct.DisplayLayout.Appearance = appearance4;
            this.cmbProduct.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridColumn3.Header.Caption = "کد";
            ultraGridColumn3.Header.VisiblePosition = 0;
            ultraGridColumn3.Hidden = true;
            ultraGridColumn3.Width = 70;
            ultraGridColumn4.Header.Caption = "نوع جنس";
            ultraGridColumn4.Header.VisiblePosition = 1;
            ultraGridColumn4.Width = 109;
            ultraGridColumn5.Header.Caption = "تاریخ ثبت";
            ultraGridColumn5.Header.VisiblePosition = 2;
            ultraGridColumn5.Hidden = true;
            ultraGridColumn6.Header.VisiblePosition = 3;
            ultraGridColumn6.Hidden = true;
            ultraGridColumn7.Header.VisiblePosition = 4;
            ultraGridColumn7.Hidden = true;
            ultraGridColumn8.Header.VisiblePosition = 5;
            ultraGridColumn8.Hidden = true;
            ultraGridColumn9.Header.VisiblePosition = 6;
            ultraGridColumn9.Hidden = true;
            ultraGridColumn10.Header.VisiblePosition = 7;
            ultraGridColumn10.Hidden = true;
            ultraGridColumn11.Header.VisiblePosition = 8;
            ultraGridColumn11.Hidden = true;
            ultraGridColumn12.Header.VisiblePosition = 9;
            ultraGridColumn12.Hidden = true;
            ultraGridColumn13.Header.VisiblePosition = 10;
            ultraGridColumn13.Hidden = true;
            ultraGridColumn13.Width = 46;
            ultraGridColumn14.Header.VisiblePosition = 11;
            ultraGridColumn14.Hidden = true;
            ultraGridColumn14.Width = 85;
            ultraGridColumn15.Header.VisiblePosition = 12;
            ultraGridColumn15.Width = 65;
            ultraGridColumn16.Header.VisiblePosition = 13;
            ultraGridColumn16.Width = 73;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn3,
            ultraGridColumn4,
            ultraGridColumn5,
            ultraGridColumn6,
            ultraGridColumn7,
            ultraGridColumn8,
            ultraGridColumn9,
            ultraGridColumn10,
            ultraGridColumn11,
            ultraGridColumn12,
            ultraGridColumn13,
            ultraGridColumn14,
            ultraGridColumn15,
            ultraGridColumn16});
            this.cmbProduct.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.cmbProduct.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.cmbProduct.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            appearance5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            appearance5.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance5.BorderColor = System.Drawing.SystemColors.Window;
            this.cmbProduct.DisplayLayout.GroupByBox.Appearance = appearance5;
            appearance6.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cmbProduct.DisplayLayout.GroupByBox.BandLabelAppearance = appearance6;
            this.cmbProduct.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            appearance7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            appearance7.BackColor2 = System.Drawing.SystemColors.Control;
            appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance7.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cmbProduct.DisplayLayout.GroupByBox.PromptAppearance = appearance7;
            this.cmbProduct.DisplayLayout.MaxColScrollRegions = 1;
            this.cmbProduct.DisplayLayout.MaxRowScrollRegions = 1;
            appearance8.BackColor = System.Drawing.SystemColors.Window;
            appearance8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmbProduct.DisplayLayout.Override.ActiveCellAppearance = appearance8;
            appearance9.BackColor = System.Drawing.SystemColors.Highlight;
            appearance9.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cmbProduct.DisplayLayout.Override.ActiveRowAppearance = appearance9;
            this.cmbProduct.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted;
            this.cmbProduct.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
            appearance10.BackColor = System.Drawing.SystemColors.Window;
            this.cmbProduct.DisplayLayout.Override.CardAreaAppearance = appearance10;
            appearance11.BorderColor = System.Drawing.Color.Silver;
            appearance11.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter;
            this.cmbProduct.DisplayLayout.Override.CellAppearance = appearance11;
            this.cmbProduct.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            this.cmbProduct.DisplayLayout.Override.CellPadding = 0;
            appearance12.BackColor = System.Drawing.SystemColors.Control;
            appearance12.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance12.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
            appearance12.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance12.BorderColor = System.Drawing.SystemColors.Window;
            this.cmbProduct.DisplayLayout.Override.GroupByRowAppearance = appearance12;
            appearance13.TextHAlignAsString = "Left";
            this.cmbProduct.DisplayLayout.Override.HeaderAppearance = appearance13;
            this.cmbProduct.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            this.cmbProduct.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
            appearance14.BackColor = System.Drawing.Color.WhiteSmoke;
            appearance14.BorderColor = System.Drawing.Color.Silver;
            this.cmbProduct.DisplayLayout.Override.RowAppearance = appearance14;
            this.cmbProduct.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            appearance15.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cmbProduct.DisplayLayout.Override.TemplateAddRowAppearance = appearance15;
            this.cmbProduct.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.cmbProduct.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.cmbProduct.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.cmbProduct.DisplayMember = "cnt";
            this.cmbProduct.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmbProduct.Location = new System.Drawing.Point(721, 92);
            this.cmbProduct.Margin = new System.Windows.Forms.Padding(2);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbProduct.Size = new System.Drawing.Size(249, 39);
            this.cmbProduct.TabIndex = 7;
            this.cmbProduct.ValueMember = "Code_kol";
            this.cmbProduct.AfterCloseUp += new System.EventHandler(this.cmbProduct_AfterCloseUp);
            this.cmbProduct.BeforeDropDown += new System.ComponentModel.CancelEventHandler(this.cmbProduct_BeforeDropDown);
            this.cmbProduct.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbProduct_KeyDown);
            this.cmbProduct.Leave += new System.EventHandler(this.cmbProduct_Leave);
            // 
            // viewKolMavadBS
            // 
            this.viewKolMavadBS.DataMember = "View_KolMavad";
            this.viewKolMavadBS.DataSource = this.db_DataSetDarkhast;
            // 
            // bNav
            // 
            this.bNav.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bNav.BindingSource = this.tblPishFaktorBS;
            this.bNav.CountItem = this.bindingNavigatorCountItem;
            this.bNav.CountItemFormat = "از {0}";
            this.bNav.DeleteItem = null;
            this.bNav.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bNav.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bNav.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bNav.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bNav.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorDeleteItem,
            this.saveToolStripButton,
            this.toolStripSeparator1,
            this.printsfStripButton});
            this.bNav.Location = new System.Drawing.Point(0, 546);
            this.bNav.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bNav.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bNav.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bNav.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bNav.Name = "bNav";
            this.bNav.Padding = new System.Windows.Forms.Padding(0);
            this.bNav.PositionItem = this.bindingNavigatorPositionItem;
            this.bNav.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.bNav.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bNav.Size = new System.Drawing.Size(1363, 55);
            this.bNav.TabIndex = 41;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(83, 52);
            this.bindingNavigatorAddNewItem.Text = "اضافه کردن";
            this.bindingNavigatorAddNewItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bindingNavigatorAddNewItem.ToolTipText = "درج رکورد جدید";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(53, 52);
            this.bindingNavigatorCountItem.Text = "از {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(84, 52);
            this.bindingNavigatorMoveFirstItem.Text = "اولین رکورد";
            this.bindingNavigatorMoveFirstItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(43, 52);
            this.bindingNavigatorMovePreviousItem.Text = "قبلی";
            this.bindingNavigatorMovePreviousItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 55);
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
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 55);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(47, 52);
            this.bindingNavigatorMoveNextItem.Text = "بعدی";
            this.bindingNavigatorMoveNextItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
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
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 55);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(48, 52);
            this.bindingNavigatorDeleteItem.Text = "حذف";
            this.bindingNavigatorDeleteItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bindingNavigatorDeleteItem.ToolTipText = "حذف رکورد جاری";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(88, 52);
            this.saveToolStripButton.Text = "ذخیره کردن";
            this.saveToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.saveToolStripButton.ToolTipText = "ذخیره سازی اطلاعات موجود";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 55);
            // 
            // printsfStripButton
            // 
            this.printsfStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printsfStripButton.Image")));
            this.printsfStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printsfStripButton.Name = "printsfStripButton";
            this.printsfStripButton.Size = new System.Drawing.Size(116, 52);
            this.printsfStripButton.Text = "چاپ پیش فاکتور";
            this.printsfStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.printsfStripButton.ToolTipText = "چاپ جدول";
            this.printsfStripButton.Click += new System.EventHandler(this.printsfStripButton_Click);
            // 
            // ultraLabel5
            // 
            this.ultraLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraLabel5.Location = new System.Drawing.Point(1274, 95);
            this.ultraLabel5.Margin = new System.Windows.Forms.Padding(2);
            this.ultraLabel5.Name = "ultraLabel5";
            this.ultraLabel5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ultraLabel5.Size = new System.Drawing.Size(81, 30);
            this.ultraLabel5.TabIndex = 36;
            this.ultraLabel5.Text = "نوع سفارش";
            // 
            // ultraLabel6
            // 
            this.ultraLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraLabel6.Location = new System.Drawing.Point(739, 14);
            this.ultraLabel6.Margin = new System.Windows.Forms.Padding(2);
            this.ultraLabel6.Name = "ultraLabel6";
            this.ultraLabel6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ultraLabel6.Size = new System.Drawing.Size(67, 30);
            this.ultraLabel6.TabIndex = 36;
            this.ultraLabel6.Text = "نوع تولید";
            // 
            // cmbNoe
            // 
            this.cmbNoe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbNoe.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            this.cmbNoe.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tblPishFaktorBS, "Noe_Tolid", true));
            this.cmbNoe.DataMember = "Tbl_Noe";
            this.cmbNoe.DataSource = this.db_DataSetDarkhast;
            this.cmbNoe.DisplayMember = "Name_Noe";
            this.cmbNoe.Location = new System.Drawing.Point(505, 4);
            this.cmbNoe.Margin = new System.Windows.Forms.Padding(2);
            this.cmbNoe.Name = "cmbNoe";
            this.cmbNoe.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbNoe.Size = new System.Drawing.Size(219, 36);
            this.cmbNoe.TabIndex = 2;
            this.cmbNoe.ValueMember = "Code_Noe";
            this.cmbNoe.Enter += new System.EventHandler(this.cmbType_Enter);
            this.cmbNoe.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCode_KeyDown);
            this.cmbNoe.Leave += new System.EventHandler(this.cmbType_Leave);
            // 
            // err
            // 
            this.err.BlinkRate = 300;
            this.err.ContainerControl = this;
            this.err.RightToLeft = true;
            // 
            // UMBox
            // 
            this.UMBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            appearance2.BackColor = System.Drawing.Color.Silver;
            this.UMBox.Appearance = appearance2;
            this.UMBox.Controls.Add(this.VaznSefaresh);
            this.UMBox.Controls.Add(this.txtVKisesf);
            this.UMBox.Controls.Add(this.txtTakhfifKol);
            this.UMBox.Controls.Add(this.txtjamTemp);
            this.UMBox.Controls.Add(this.txtKol);
            this.UMBox.Controls.Add(this.txtPvahed);
            this.UMBox.Controls.Add(this.txtTkise);
            this.UMBox.Controls.Add(this.ultraLabel12);
            this.UMBox.Controls.Add(this.ultraLabel15);
            this.UMBox.Controls.Add(this.ultraLabel9);
            this.UMBox.Controls.Add(this.ultraLabel11);
            this.UMBox.Controls.Add(this.ultraLabel8);
            this.UMBox.Controls.Add(this.ultraLabel14);
            this.UMBox.Controls.Add(this.ultraLabel13);
            this.UMBox.Location = new System.Drawing.Point(0, 144);
            this.UMBox.Name = "UMBox";
            this.UMBox.Size = new System.Drawing.Size(1363, 283);
            this.UMBox.TabIndex = 42;
            // 
            // VaznSefaresh
            // 
            this.VaznSefaresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.VaznSefaresh.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblPishFaktorBS, "VaznSefaresh", true));
            this.VaznSefaresh.Location = new System.Drawing.Point(1122, 115);
            this.VaznSefaresh.Name = "VaznSefaresh";
            this.VaznSefaresh.ReadOnly = true;
            this.VaznSefaresh.Size = new System.Drawing.Size(122, 36);
            this.VaznSefaresh.TabIndex = 2;
            this.VaznSefaresh.TabStop = false;
            this.VaznSefaresh.Enter += new System.EventHandler(this.txtTkise_Enter);
            this.VaznSefaresh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVKisesf_KeyDown);
            this.VaznSefaresh.Leave += new System.EventHandler(this.txtVKise_Leave);
            // 
            // txtVKisesf
            // 
            this.txtVKisesf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVKisesf.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblPishFaktorBS, "VaznKiseSf", true));
            this.txtVKisesf.Location = new System.Drawing.Point(885, 61);
            this.txtVKisesf.Name = "txtVKisesf";
            this.txtVKisesf.Size = new System.Drawing.Size(125, 36);
            this.txtVKisesf.TabIndex = 1;
            this.txtVKisesf.Enter += new System.EventHandler(this.txtTkise_Enter);
            this.txtVKisesf.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVKisesf_KeyDown);
            this.txtVKisesf.Leave += new System.EventHandler(this.txtVKise_Leave);
            // 
            // txtTakhfifKol
            // 
            this.txtTakhfifKol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTakhfifKol.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblPishFaktorBS, "TakhfifKol", true));
            this.txtTakhfifKol.Location = new System.Drawing.Point(883, 165);
            this.txtTakhfifKol.Name = "txtTakhfifKol";
            this.txtTakhfifKol.Size = new System.Drawing.Size(127, 36);
            this.txtTakhfifKol.TabIndex = 5;
            this.txtTakhfifKol.Enter += new System.EventHandler(this.txtTkise_Enter);
            this.txtTakhfifKol.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCode_KeyDown);
            this.txtTakhfifKol.Leave += new System.EventHandler(this.txtVKise_Leave);
            // 
            // txtjamTemp
            // 
            this.txtjamTemp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtjamTemp.Location = new System.Drawing.Point(617, 115);
            this.txtjamTemp.Name = "txtjamTemp";
            this.txtjamTemp.ReadOnly = true;
            this.txtjamTemp.Size = new System.Drawing.Size(158, 36);
            this.txtjamTemp.TabIndex = 4;
            this.txtjamTemp.Enter += new System.EventHandler(this.txtTkise_Enter);
            this.txtjamTemp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCode_KeyDown);
            this.txtjamTemp.Leave += new System.EventHandler(this.txtVKise_Leave);
            // 
            // txtKol
            // 
            this.txtKol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKol.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblPishFaktorBS, "JamKol", true));
            this.txtKol.Location = new System.Drawing.Point(617, 168);
            this.txtKol.Name = "txtKol";
            this.txtKol.ReadOnly = true;
            this.txtKol.Size = new System.Drawing.Size(158, 36);
            this.txtKol.TabIndex = 6;
            this.txtKol.Enter += new System.EventHandler(this.txtTkise_Enter);
            this.txtKol.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCode_KeyDown);
            this.txtKol.Leave += new System.EventHandler(this.txtVKise_Leave);
            // 
            // txtPvahed
            // 
            this.txtPvahed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPvahed.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblPishFaktorBS, "Pvahed", true));
            this.txtPvahed.Location = new System.Drawing.Point(885, 112);
            this.txtPvahed.Name = "txtPvahed";
            this.txtPvahed.Size = new System.Drawing.Size(125, 36);
            this.txtPvahed.TabIndex = 3;
            this.txtPvahed.Enter += new System.EventHandler(this.txtTkise_Enter);
            this.txtPvahed.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCode_KeyDown);
            this.txtPvahed.Leave += new System.EventHandler(this.txtVKise_Leave);
            // 
            // txtTkise
            // 
            this.txtTkise.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTkise.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblPishFaktorBS, "TedadKiseSf", true));
            this.txtTkise.Location = new System.Drawing.Point(1122, 61);
            this.txtTkise.Name = "txtTkise";
            this.txtTkise.Size = new System.Drawing.Size(125, 36);
            this.txtTkise.TabIndex = 0;
            this.txtTkise.Enter += new System.EventHandler(this.txtTkise_Enter);
            this.txtTkise.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCode_KeyDown);
            this.txtTkise.Leave += new System.EventHandler(this.txtVKise_Leave);
            // 
            // ultraLabel12
            // 
            this.ultraLabel12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraLabel12.Location = new System.Drawing.Point(790, 118);
            this.ultraLabel12.Margin = new System.Windows.Forms.Padding(2);
            this.ultraLabel12.Name = "ultraLabel12";
            this.ultraLabel12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ultraLabel12.Size = new System.Drawing.Size(44, 30);
            this.ultraLabel12.TabIndex = 44;
            this.ultraLabel12.Text = "جمع";
            // 
            // ultraLabel15
            // 
            this.ultraLabel15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraLabel15.Location = new System.Drawing.Point(1252, 64);
            this.ultraLabel15.Margin = new System.Windows.Forms.Padding(2);
            this.ultraLabel15.Name = "ultraLabel15";
            this.ultraLabel15.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ultraLabel15.Size = new System.Drawing.Size(85, 30);
            this.ultraLabel15.TabIndex = 43;
            this.ultraLabel15.Text = "تعداد کیسه";
            // 
            // ultraLabel9
            // 
            this.ultraLabel9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraLabel9.Location = new System.Drawing.Point(779, 171);
            this.ultraLabel9.Margin = new System.Windows.Forms.Padding(2);
            this.ultraLabel9.Name = "ultraLabel9";
            this.ultraLabel9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ultraLabel9.Size = new System.Drawing.Size(74, 30);
            this.ultraLabel9.TabIndex = 44;
            this.ultraLabel9.Text = "جمع کل";
            // 
            // ultraLabel11
            // 
            this.ultraLabel11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraLabel11.Location = new System.Drawing.Point(1019, 168);
            this.ultraLabel11.Margin = new System.Windows.Forms.Padding(2);
            this.ultraLabel11.Name = "ultraLabel11";
            this.ultraLabel11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ultraLabel11.Size = new System.Drawing.Size(72, 30);
            this.ultraLabel11.TabIndex = 47;
            this.ultraLabel11.Text = "تخفیف -";
            // 
            // ultraLabel8
            // 
            this.ultraLabel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraLabel8.Location = new System.Drawing.Point(1011, 115);
            this.ultraLabel8.Margin = new System.Windows.Forms.Padding(2);
            this.ultraLabel8.Name = "ultraLabel8";
            this.ultraLabel8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ultraLabel8.Size = new System.Drawing.Size(84, 30);
            this.ultraLabel8.TabIndex = 46;
            this.ultraLabel8.Text = "قیمت واحد";
            // 
            // ultraLabel14
            // 
            this.ultraLabel14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraLabel14.Location = new System.Drawing.Point(1015, 64);
            this.ultraLabel14.Margin = new System.Windows.Forms.Padding(2);
            this.ultraLabel14.Name = "ultraLabel14";
            this.ultraLabel14.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ultraLabel14.Size = new System.Drawing.Size(76, 30);
            this.ultraLabel14.TabIndex = 47;
            this.ultraLabel14.Text = "وزن کیسه";
            // 
            // ultraLabel13
            // 
            this.ultraLabel13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraLabel13.Location = new System.Drawing.Point(1249, 115);
            this.ultraLabel13.Margin = new System.Windows.Forms.Padding(2);
            this.ultraLabel13.Name = "ultraLabel13";
            this.ultraLabel13.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ultraLabel13.Size = new System.Drawing.Size(90, 30);
            this.ultraLabel13.TabIndex = 48;
            this.ultraLabel13.Text = "مقدار سفارش";
            // 
            // txtTakhfif
            // 
            this.txtTakhfif.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblPishFaktorBS, "Takhfif", true));
            this.txtTakhfif.Location = new System.Drawing.Point(241, -1000);
            this.txtTakhfif.Name = "txtTakhfif";
            this.txtTakhfif.ReadOnly = true;
            this.txtTakhfif.Size = new System.Drawing.Size(67, 36);
            this.txtTakhfif.TabIndex = 44;
            // 
            // txtKise
            // 
            this.txtKise.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblPishFaktorBS, "Hazine_Kise", true));
            this.txtKise.Location = new System.Drawing.Point(240, -1000);
            this.txtKise.Name = "txtKise";
            this.txtKise.ReadOnly = true;
            this.txtKise.Size = new System.Drawing.Size(68, 36);
            this.txtKise.TabIndex = 43;
            // 
            // txtJamKol
            // 
            this.txtJamKol.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblPishFaktorBS, "Jam", true));
            this.txtJamKol.Location = new System.Drawing.Point(240, -1000);
            this.txtJamKol.Name = "txtJamKol";
            this.txtJamKol.ReadOnly = true;
            this.txtJamKol.Size = new System.Drawing.Size(68, 36);
            this.txtJamKol.TabIndex = 43;
            this.txtJamKol.TabStop = false;
            // 
            // txtOft
            // 
            this.txtOft.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblPishFaktorBS, "Oft_Tolid", true));
            this.txtOft.Location = new System.Drawing.Point(167, -1000);
            this.txtOft.Name = "txtOft";
            this.txtOft.ReadOnly = true;
            this.txtOft.Size = new System.Drawing.Size(67, 36);
            this.txtOft.TabIndex = 43;
            // 
            // txtOther
            // 
            this.txtOther.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblPishFaktorBS, "Other_Tolid", true));
            this.txtOther.Location = new System.Drawing.Point(167, -1000);
            this.txtOther.Name = "txtOther";
            this.txtOther.ReadOnly = true;
            this.txtOther.Size = new System.Drawing.Size(67, 36);
            this.txtOther.TabIndex = 43;
            // 
            // txtTolid
            // 
            this.txtTolid.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblPishFaktorBS, "Hazine_Tolid", true));
            this.txtTolid.Location = new System.Drawing.Point(167, -1000);
            this.txtTolid.Name = "txtTolid";
            this.txtTolid.ReadOnly = true;
            this.txtTolid.Size = new System.Drawing.Size(67, 36);
            this.txtTolid.TabIndex = 43;
            // 
            // ultraLabel7
            // 
            this.ultraLabel7.BorderStyleOuter = Infragistics.Win.UIElementBorderStyle.Dotted;
            this.ultraLabel7.Location = new System.Drawing.Point(11, 14);
            this.ultraLabel7.Margin = new System.Windows.Forms.Padding(2);
            this.ultraLabel7.Name = "ultraLabel7";
            this.ultraLabel7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ultraLabel7.Size = new System.Drawing.Size(135, 30);
            this.ultraLabel7.TabIndex = 57;
            this.ultraLabel7.Text = "شماره پیش فاکتور";
            // 
            // lblCodeFk
            // 
            this.lblCodeFk.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Dotted;
            this.lblCodeFk.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblPishFaktorBS, "CodeFaktor", true));
            this.lblCodeFk.Location = new System.Drawing.Point(11, 43);
            this.lblCodeFk.Margin = new System.Windows.Forms.Padding(2);
            this.lblCodeFk.Name = "lblCodeFk";
            this.lblCodeFk.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCodeFk.Size = new System.Drawing.Size(135, 30);
            this.lblCodeFk.TabIndex = 57;
            // 
            // ultraButton1
            // 
            appearance1.Image = global::DamProducer.Properties.Resources.search;
            this.ultraButton1.Appearance = appearance1;
            this.ultraButton1.ImageSize = new System.Drawing.Size(28, 28);
            this.ultraButton1.Location = new System.Drawing.Point(11, 77);
            this.ultraButton1.Margin = new System.Windows.Forms.Padding(2);
            this.ultraButton1.Name = "ultraButton1";
            this.ultraButton1.Size = new System.Drawing.Size(135, 55);
            this.ultraButton1.TabIndex = 58;
            this.ultraButton1.Text = "جست و جو";
            this.ultraButton1.Click += new System.EventHandler(this.ultraButton1_Click);
            // 
            // txtAdress
            // 
            this.txtAdress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAdress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblPishFaktorBS, "Address", true));
            this.txtAdress.Location = new System.Drawing.Point(505, 51);
            this.txtAdress.Margin = new System.Windows.Forms.Padding(2);
            this.txtAdress.MaxLength = 80;
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtAdress.Size = new System.Drawing.Size(465, 36);
            this.txtAdress.TabIndex = 4;
            this.txtAdress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCode_KeyDown);
            // 
            // ultraLabel10
            // 
            this.ultraLabel10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraLabel10.Location = new System.Drawing.Point(975, 55);
            this.ultraLabel10.Margin = new System.Windows.Forms.Padding(2);
            this.ultraLabel10.Name = "ultraLabel10";
            this.ultraLabel10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ultraLabel10.Size = new System.Drawing.Size(80, 30);
            this.ultraLabel10.TabIndex = 60;
            this.ultraLabel10.Text = "آدرس";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblPishFaktorBS, "Name_fro", true));
            this.txtName.Location = new System.Drawing.Point(1083, 49);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.MaxLength = 40;
            this.txtName.Name = "txtName";
            this.txtName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtName.Size = new System.Drawing.Size(185, 36);
            this.txtName.TabIndex = 3;
            this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCode_KeyDown);
            // 
            // txtTel
            // 
            this.txtTel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblPishFaktorBS, "Tel", true));
            this.txtTel.Location = new System.Drawing.Point(246, 51);
            this.txtTel.Margin = new System.Windows.Forms.Padding(2);
            this.txtTel.MaxLength = 12;
            this.txtTel.Name = "txtTel";
            this.txtTel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTel.Size = new System.Drawing.Size(168, 36);
            this.txtTel.TabIndex = 5;
            this.txtTel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCode_KeyDown);
            // 
            // ultraLabel16
            // 
            this.ultraLabel16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraLabel16.Location = new System.Drawing.Point(418, 55);
            this.ultraLabel16.Margin = new System.Windows.Forms.Padding(2);
            this.ultraLabel16.Name = "ultraLabel16";
            this.ultraLabel16.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ultraLabel16.Size = new System.Drawing.Size(60, 30);
            this.ultraLabel16.TabIndex = 62;
            this.ultraLabel16.Text = "تلفن";
            // 
            // txtMeliCode
            // 
            this.txtMeliCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMeliCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblPishFaktorBS, "MeliCode", true));
            this.txtMeliCode.Location = new System.Drawing.Point(418, 93);
            this.txtMeliCode.Margin = new System.Windows.Forms.Padding(2);
            this.txtMeliCode.MaxLength = 13;
            this.txtMeliCode.Name = "txtMeliCode";
            this.txtMeliCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtMeliCode.Size = new System.Drawing.Size(168, 36);
            this.txtMeliCode.TabIndex = 8;
            this.txtMeliCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCode_KeyDown);
            // 
            // ultraLabel17
            // 
            this.ultraLabel17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraLabel17.Location = new System.Drawing.Point(590, 97);
            this.ultraLabel17.Margin = new System.Windows.Forms.Padding(2);
            this.ultraLabel17.Name = "ultraLabel17";
            this.ultraLabel17.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ultraLabel17.Size = new System.Drawing.Size(78, 30);
            this.ultraLabel17.TabIndex = 64;
            this.ultraLabel17.Text = "کد ملی:";
            // 
            // tbl_NoeTA
            // 
            this.tbl_NoeTA.ClearBeforeFill = true;
            // 
            // view_KolMavadTA
            // 
            this.view_KolMavadTA.ClearBeforeFill = true;
            // 
            // tbl_PishFaktorTA
            // 
            this.tbl_PishFaktorTA.ClearBeforeFill = true;
            // 
            // view_PishFaktorAD
            // 
            this.view_PishFaktorAD.ClearBeforeFill = true;
            // 
            // txtDate
            // 
            this.txtDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDate.Culture = new System.Globalization.CultureInfo("fa-IR");
            this.txtDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblPishFaktorBS, "Date_Darkhast", true));
            this.txtDate.Location = new System.Drawing.Point(865, 4);
            this.txtDate.Mask = "####/##/##";
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(105, 36);
            this.txtDate.TabIndex = 1;
            this.txtDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCode_KeyDown);
            // 
            // frmPishFaktor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(1363, 601);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtMeliCode);
            this.Controls.Add(this.ultraLabel17);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.ultraLabel16);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtAdress);
            this.Controls.Add(this.ultraLabel10);
            this.Controls.Add(this.ultraButton1);
            this.Controls.Add(this.UMBox);
            this.Controls.Add(this.bNav);
            this.Controls.Add(this.ubtnComite);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.cmbProduct);
            this.Controls.Add(this.cmbNoe);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.ultraLabel4);
            this.Controls.Add(this.txtTolid);
            this.Controls.Add(this.txtOther);
            this.Controls.Add(this.ultraLabel3);
            this.Controls.Add(this.txtOft);
            this.Controls.Add(this.txtJamKol);
            this.Controls.Add(this.ultraLabel6);
            this.Controls.Add(this.txtKise);
            this.Controls.Add(this.ultraLabel2);
            this.Controls.Add(this.txtTakhfif);
            this.Controls.Add(this.ultraLabel5);
            this.Controls.Add(this.ultraLabel1);
            this.Controls.Add(this.lblCodeFk);
            this.Controls.Add(this.ultraLabel7);
            this.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmPishFaktor";
            this.Text = "پیش فاکتور";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSefaresh_FormClosed);
            this.Load += new System.EventHandler(this.frmDarkhast_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPishFaktor_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ultraCalc1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_DataSetContent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPishFaktorBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_DataSetDarkhast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewKolMavadBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bNav)).EndInit();
            this.bNav.ResumeLayout(false);
            this.bNav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbNoe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UMBox)).EndInit();
            this.UMBox.ResumeLayout(false);
            this.UMBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMeliCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtCode;
        private Infragistics.Win.UltraWinEditors.UltraComboEditor cmbType;
        private Infragistics.Win.Misc.UltraLabel ultraLabel4;
        private Infragistics.Win.Misc.UltraLabel ultraLabel3;
        private Infragistics.Win.Misc.UltraLabel ultraLabel1;
        private Infragistics.Win.Misc.UltraLabel ultraLabel2;
        private Infragistics.Win.Misc.UltraButton ubtnComite;
        private Dset.db_DataSetDarkhast db_DataSetDarkhast;
        private Infragistics.Win.UltraWinGrid.UltraCombo cmbProduct;
        private System.Windows.Forms.BindingNavigator bNav;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private Dset.db_DataSetContent db_DataSetContent;
        private Infragistics.Win.Misc.UltraLabel ultraLabel5;
        private Infragistics.Win.UltraWinCalcManager.UltraCalcManager ultraCalc1;
        private Infragistics.Win.UltraWinEditors.UltraComboEditor cmbNoe;
        private Infragistics.Win.Misc.UltraLabel ultraLabel6;
        private System.Windows.Forms.ToolStripButton printsfStripButton;
        private Dset.db_DataSetDarkhastTableAdapters.Tbl_NoeTA tbl_NoeTA;
        private System.Windows.Forms.BindingSource viewKolMavadBS;
        private Dset.db_DataSetDarkhastTableAdapters.View_KolMavadTA view_KolMavadTA;
        private System.Windows.Forms.ErrorProvider err;
        private Infragistics.Win.Misc.UltraGroupBox UMBox;
        private ArzTextBox.ArzTextBox txtKol;
        private ArzTextBox.ArzTextBox txtPvahed;
        private ArzTextBox.ArzTextBox txtTkise;
        private Infragistics.Win.Misc.UltraLabel ultraLabel15;
        private Infragistics.Win.Misc.UltraLabel ultraLabel9;
        private Infragistics.Win.Misc.UltraLabel ultraLabel8;
        private Infragistics.Win.Misc.UltraLabel ultraLabel14;
        private Infragistics.Win.Misc.UltraLabel ultraLabel13;
        private System.Windows.Forms.TextBox txtTolid;
        private System.Windows.Forms.TextBox txtOft;
        private System.Windows.Forms.TextBox txtOther;
        private System.Windows.Forms.TextBox txtKise;
        private System.Windows.Forms.TextBox txtJamKol;
        private System.Windows.Forms.TextBox txtTakhfif;
        private ArzTextBox.ArzTextBox txtTakhfifKol;
        private Infragistics.Win.Misc.UltraLabel ultraLabel11;
        private ArzTextBox.ArzTextBox txtjamTemp;
        private Infragistics.Win.Misc.UltraLabel ultraLabel12;
        private Infragistics.Win.Misc.UltraLabel lblCodeFk;
        private Infragistics.Win.Misc.UltraLabel ultraLabel7;
        private Infragistics.Win.Misc.UltraButton ultraButton1;
        private System.Windows.Forms.TextBox txtVKisesf;
        private System.Windows.Forms.TextBox VaznSefaresh;
        private System.Windows.Forms.BindingSource tblPishFaktorBS;
        private Dset.db_DataSetDarkhastTableAdapters.Tbl_PishFaktorTA tbl_PishFaktorTA;
        private Dset.db_DataSetDarkhastTableAdapters.View_PishFaktorTA view_PishFaktorAD;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtAdress;
        private Infragistics.Win.Misc.UltraLabel ultraLabel10;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtName;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtTel;
        private Infragistics.Win.Misc.UltraLabel ultraLabel16;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtMeliCode;
        private Infragistics.Win.Misc.UltraLabel ultraLabel17;
        private DateControlBT.PDateBox txtDate;
    }
}