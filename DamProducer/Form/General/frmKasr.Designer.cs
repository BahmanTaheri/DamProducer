namespace DamProducer
{
    partial class frmKasr
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
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Tbl_Kasr", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Code_Kasr");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn2 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Date");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn3 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Code_matter");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn4 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Vazn");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn5 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Type_Kasr");
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKasr));
            this.CmbMater = new Infragistics.Win.UltraWinEditors.UltraComboEditor();
            this.tblKasrBS = new System.Windows.Forms.BindingSource(this.components);
            this.db_DataSetGTP = new DamProducer.Dset.db_DataSetGTP();
            this.UType = new Infragistics.Win.UltraWinEditors.UltraComboEditor();
            this.UGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.bNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripDel = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.printButton = new System.Windows.Forms.ToolStripButton();
            this.ultraLabel2 = new Infragistics.Win.Misc.UltraLabel();
            this.CdResid = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel3 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel4 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel5 = new Infragistics.Win.Misc.UltraLabel();
            this.txtCodeFak = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.tbl_KasrTA = new DamProducer.Dset.db_DataSetGTPTableAdapters.Tbl_KasrTA();
            this.tbl_MatterTA = new DamProducer.Dset.db_DataSetGTPTableAdapters.Tbl_MatterTA();
            this.txtDate = new DateControlBT.PDateBox();
            ((System.ComponentModel.ISupportInitialize)(this.CmbMater)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKasrBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_DataSetGTP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bNavigator)).BeginInit();
            this.bNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CdResid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodeFak)).BeginInit();
            this.SuspendLayout();
            // 
            // CmbMater
            // 
            this.CmbMater.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbMater.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            this.CmbMater.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tblKasrBS, "Code_matter", true));
            this.CmbMater.DataMember = "Tbl_Matter";
            this.CmbMater.DataSource = this.db_DataSetGTP;
            this.CmbMater.DisplayMember = "Name_matter";
            this.CmbMater.Location = new System.Drawing.Point(442, 62);
            this.CmbMater.Margin = new System.Windows.Forms.Padding(2);
            this.CmbMater.Name = "CmbMater";
            this.CmbMater.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CmbMater.Size = new System.Drawing.Size(149, 36);
            this.CmbMater.TabIndex = 3;
            this.CmbMater.ValueMember = "Code_matter";
            this.CmbMater.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CdResid_KeyDown);
            // 
            // tblKasrBS
            // 
            this.tblKasrBS.DataMember = "Tbl_Kasr";
            this.tblKasrBS.DataSource = this.db_DataSetGTP;
            // 
            // db_DataSetGTP
            // 
            this.db_DataSetGTP.DataSetName = "db_DataSetGTP";
            this.db_DataSetGTP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // UType
            // 
            this.UType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UType.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            this.UType.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tblKasrBS, "Type_Kasr", true));
            this.UType.DisplayMember = "";
            valueListItem1.DataValue = ((short)(0));
            valueListItem1.DisplayText = "کسر از انبار";
            valueListItem2.DataValue = ((short)(1));
            valueListItem2.DisplayText = "اضافه کردن";
            this.UType.Items.AddRange(new Infragistics.Win.ValueListItem[] {
            valueListItem1,
            valueListItem2});
            this.UType.Location = new System.Drawing.Point(742, 62);
            this.UType.Margin = new System.Windows.Forms.Padding(2);
            this.UType.Name = "UType";
            this.UType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.UType.Size = new System.Drawing.Size(132, 36);
            this.UType.TabIndex = 2;
            this.UType.ValueMember = "";
            this.UType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CdResid_KeyDown);
            // 
            // UGrid
            // 
            this.UGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UGrid.DataSource = this.tblKasrBS;
            appearance1.BackColor = System.Drawing.SystemColors.Window;
            appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.UGrid.DisplayLayout.Appearance = appearance1;
            this.UGrid.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridColumn1.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn1.Header.Caption = "کد";
            ultraGridColumn1.Header.VisiblePosition = 0;
            ultraGridColumn1.Width = 84;
            ultraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn2.Header.Caption = "تاریخ";
            ultraGridColumn2.Header.VisiblePosition = 1;
            ultraGridColumn2.Width = 134;
            ultraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn3.EditorComponent = this.CmbMater;
            ultraGridColumn3.Header.Caption = "نام جنس";
            ultraGridColumn3.Header.VisiblePosition = 3;
            ultraGridColumn3.Width = 306;
            ultraGridColumn4.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn4.Format = "###,###,###,###.###";
            ultraGridColumn4.Header.Caption = "وزن";
            ultraGridColumn4.Header.VisiblePosition = 4;
            ultraGridColumn4.Width = 228;
            ultraGridColumn5.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn5.EditorComponent = this.UType;
            ultraGridColumn5.Header.Caption = "نوع ";
            ultraGridColumn5.Header.VisiblePosition = 2;
            ultraGridColumn5.Width = 145;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn1,
            ultraGridColumn2,
            ultraGridColumn3,
            ultraGridColumn4,
            ultraGridColumn5});
            ultraGridBand1.SummaryFooterCaption = "";
            this.UGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.UGrid.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.UGrid.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.True;
            this.UGrid.DisplayLayout.EmptyRowSettings.ShowEmptyRows = true;
            this.UGrid.DisplayLayout.EmptyRowSettings.Style = Infragistics.Win.UltraWinGrid.EmptyRowStyle.ExtendRowSelector;
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
            appearance10.TextHAlignAsString = "Left";
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
            this.UGrid.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand;
            this.UGrid.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.UGrid.Location = new System.Drawing.Point(4, 116);
            this.UGrid.Margin = new System.Windows.Forms.Padding(6);
            this.UGrid.Name = "UGrid";
            this.UGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.UGrid.Size = new System.Drawing.Size(948, 283);
            this.UGrid.TabIndex = 13;
            this.UGrid.Text = "شرح رسید";
            // 
            // bNavigator
            // 
            this.bNavigator.AddNewItem = this.toolStripAdd;
            this.bNavigator.BindingSource = this.tblKasrBS;
            this.bNavigator.CountItem = this.toolStripLabel1;
            this.bNavigator.CountItemFormat = "از {0}";
            this.bNavigator.DeleteItem = this.toolStripDel;
            this.bNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bNavigator.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.printButton});
            this.bNavigator.Location = new System.Drawing.Point(0, 401);
            this.bNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bNavigator.MoveNextItem = this.toolStripButton4;
            this.bNavigator.MovePreviousItem = this.toolStripButton3;
            this.bNavigator.Name = "bNavigator";
            this.bNavigator.Padding = new System.Windows.Forms.Padding(0);
            this.bNavigator.PositionItem = this.toolStripTextBox1;
            this.bNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.bNavigator.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bNavigator.Size = new System.Drawing.Size(958, 55);
            this.bNavigator.TabIndex = 29;
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
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 36);
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
            // toolStripSave
            // 
            this.toolStripSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSave.Image")));
            this.toolStripSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSave.Name = "toolStripSave";
            this.toolStripSave.Size = new System.Drawing.Size(88, 52);
            this.toolStripSave.Text = "ذخیره کردن";
            this.toolStripSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripSave.ToolTipText = "ذخیره سازی اطلاعات موجود";
            this.toolStripSave.Click += new System.EventHandler(this.toolStripSave_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 55);
            // 
            // printButton
            // 
            this.printButton.Image = ((System.Drawing.Image)(resources.GetObject("printButton.Image")));
            this.printButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(43, 52);
            this.printButton.Text = "چاپ";
            this.printButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.printButton.ToolTipText = "چاپ جدول";
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // ultraLabel2
            // 
            this.ultraLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraLabel2.Location = new System.Drawing.Point(592, 15);
            this.ultraLabel2.Margin = new System.Windows.Forms.Padding(2);
            this.ultraLabel2.Name = "ultraLabel2";
            this.ultraLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ultraLabel2.Size = new System.Drawing.Size(66, 30);
            this.ultraLabel2.TabIndex = 31;
            this.ultraLabel2.Text = "تاریخ ";
            // 
            // CdResid
            // 
            this.CdResid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CdResid.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblKasrBS, "Code_Kasr", true));
            this.CdResid.Location = new System.Drawing.Point(760, 11);
            this.CdResid.Margin = new System.Windows.Forms.Padding(2);
            this.CdResid.Name = "CdResid";
            this.CdResid.ReadOnly = true;
            this.CdResid.Size = new System.Drawing.Size(114, 38);
            this.CdResid.TabIndex = 0;
            this.CdResid.TabStop = false;
            this.CdResid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CdResid_KeyDown);
            // 
            // ultraLabel1
            // 
            this.ultraLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraLabel1.Location = new System.Drawing.Point(878, 15);
            this.ultraLabel1.Margin = new System.Windows.Forms.Padding(2);
            this.ultraLabel1.Name = "ultraLabel1";
            this.ultraLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ultraLabel1.Size = new System.Drawing.Size(56, 30);
            this.ultraLabel1.TabIndex = 33;
            this.ultraLabel1.Text = "شماره";
            // 
            // ultraLabel3
            // 
            this.ultraLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraLabel3.Location = new System.Drawing.Point(595, 65);
            this.ultraLabel3.Margin = new System.Windows.Forms.Padding(2);
            this.ultraLabel3.Name = "ultraLabel3";
            this.ultraLabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ultraLabel3.Size = new System.Drawing.Size(80, 30);
            this.ultraLabel3.TabIndex = 35;
            this.ultraLabel3.Text = "نام جنس";
            // 
            // ultraLabel4
            // 
            this.ultraLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraLabel4.Location = new System.Drawing.Point(878, 65);
            this.ultraLabel4.Margin = new System.Windows.Forms.Padding(2);
            this.ultraLabel4.Name = "ultraLabel4";
            this.ultraLabel4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ultraLabel4.Size = new System.Drawing.Size(48, 30);
            this.ultraLabel4.TabIndex = 37;
            this.ultraLabel4.Text = "نوع";
            // 
            // ultraLabel5
            // 
            this.ultraLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraLabel5.Location = new System.Drawing.Point(303, 65);
            this.ultraLabel5.Margin = new System.Windows.Forms.Padding(2);
            this.ultraLabel5.Name = "ultraLabel5";
            this.ultraLabel5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ultraLabel5.Size = new System.Drawing.Size(110, 30);
            this.ultraLabel5.TabIndex = 38;
            this.ultraLabel5.Text = "وزن کسر / اضاف";
            // 
            // txtCodeFak
            // 
            this.txtCodeFak.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodeFak.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblKasrBS, "Vazn", true));
            this.txtCodeFak.Location = new System.Drawing.Point(146, 61);
            this.txtCodeFak.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodeFak.Name = "txtCodeFak";
            this.txtCodeFak.Size = new System.Drawing.Size(155, 38);
            this.txtCodeFak.TabIndex = 4;
            this.txtCodeFak.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CdResid_KeyDown);
            // 
            // tbl_KasrTA
            // 
            this.tbl_KasrTA.ClearBeforeFill = true;
            // 
            // tbl_MatterTA
            // 
            this.tbl_MatterTA.ClearBeforeFill = true;
            // 
            // txtDate
            // 
            this.txtDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDate.Culture = new System.Globalization.CultureInfo("fa-IR");
            this.txtDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblKasrBS, "Date", true));
            this.txtDate.Location = new System.Drawing.Point(477, 12);
            this.txtDate.Mask = "####/##/##";
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(114, 36);
            this.txtDate.TabIndex = 1;
            this.txtDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CdResid_KeyDown);
            // 
            // frmKasr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(958, 456);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.ultraLabel5);
            this.Controls.Add(this.txtCodeFak);
            this.Controls.Add(this.ultraLabel4);
            this.Controls.Add(this.UType);
            this.Controls.Add(this.ultraLabel3);
            this.Controls.Add(this.CmbMater);
            this.Controls.Add(this.CdResid);
            this.Controls.Add(this.ultraLabel1);
            this.Controls.Add(this.ultraLabel2);
            this.Controls.Add(this.bNavigator);
            this.Controls.Add(this.UGrid);
            this.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmKasr";
            this.Text = "کسر و اضاف انبار";
            this.Load += new System.EventHandler(this.frmKasr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CmbMater)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKasrBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_DataSetGTP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bNavigator)).EndInit();
            this.bNavigator.ResumeLayout(false);
            this.bNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CdResid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodeFak)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Infragistics.Win.UltraWinGrid.UltraGrid UGrid;
        private System.Windows.Forms.BindingNavigator bNavigator;
        private System.Windows.Forms.ToolStripButton toolStripAdd;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripDel;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private Infragistics.Win.Misc.UltraLabel ultraLabel2;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor CdResid;
        private Infragistics.Win.Misc.UltraLabel ultraLabel1;
        private Infragistics.Win.UltraWinEditors.UltraComboEditor CmbMater;
        private Infragistics.Win.Misc.UltraLabel ultraLabel3;
        private Infragistics.Win.Misc.UltraLabel ultraLabel4;
        private Infragistics.Win.UltraWinEditors.UltraComboEditor UType;
        private Infragistics.Win.Misc.UltraLabel ultraLabel5;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtCodeFak;
        private Dset.db_DataSetGTP db_DataSetGTP;
        private System.Windows.Forms.BindingSource tblKasrBS;
        private Dset.db_DataSetGTPTableAdapters.Tbl_KasrTA tbl_KasrTA;
        private Dset.db_DataSetGTPTableAdapters.Tbl_MatterTA tbl_MatterTA;
        private System.Windows.Forms.ToolStripButton printButton;
        private DateControlBT.PDateBox txtDate;
    }
}