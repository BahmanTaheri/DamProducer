namespace DamProducer
{
    partial class frmItemVal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmItemVal));
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("FK_Tbl_ItemVal_Tbl_Product", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn6 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ID");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn7 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Code_product");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn3 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("id_item");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn8 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("value");
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
            this.CmbMater = new Infragistics.Win.UltraWinEditors.UltraComboEditor();
            this.tblItemBS = new System.Windows.Forms.BindingSource(this.components);
            this.db_DataSetGTP = new DamProducer.Dset.db_DataSetGTP();
            this.bNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripAdd = new System.Windows.Forms.ToolStripButton();
            this.tblProductBS = new System.Windows.Forms.BindingSource(this.components);
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
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ultraLabel5 = new Infragistics.Win.Misc.UltraLabel();
            this.txtCodeFak = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.UGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.TblItemValTblProductBS = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_ProductTA = new DamProducer.Dset.db_DataSetGTPTableAdapters.Tbl_ProductTA();
            this.tbl_ItemValTA = new DamProducer.Dset.db_DataSetGTPTableAdapters.Tbl_ItemValTA();
            this.tbl_ItemTA = new DamProducer.Dset.db_DataSetGTPTableAdapters.Tbl_ItemTA();
            this.report1 = new FastReport.Report();
            this.view_ItemValsTA = new DamProducer.Dset.db_DataSetGTPTableAdapters.View_ItemValsTA();
            this.txtCode = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            ((System.ComponentModel.ISupportInitialize)(this.CmbMater)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblItemBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_DataSetGTP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bNavigator)).BeginInit();
            this.bNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodeFak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TblItemValTblProductBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.report1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode)).BeginInit();
            this.SuspendLayout();
            // 
            // CmbMater
            // 
            this.CmbMater.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbMater.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.CmbMater.DataSource = this.tblItemBS;
            this.CmbMater.DisplayMember = "name";
            this.CmbMater.Location = new System.Drawing.Point(409, 158);
            this.CmbMater.Margin = new System.Windows.Forms.Padding(2);
            this.CmbMater.Name = "CmbMater";
            this.CmbMater.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CmbMater.Size = new System.Drawing.Size(373, 43);
            this.CmbMater.TabIndex = 33;
            this.CmbMater.ValueMember = "id_item";
            this.CmbMater.Visible = false;
            // 
            // tblItemBS
            // 
            this.tblItemBS.DataMember = "Tbl_Item";
            this.tblItemBS.DataSource = this.db_DataSetGTP;
            // 
            // db_DataSetGTP
            // 
            this.db_DataSetGTP.DataSetName = "db_DataSetGTP";
            this.db_DataSetGTP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bNavigator
            // 
            this.bNavigator.AddNewItem = this.toolStripAdd;
            this.bNavigator.BindingSource = this.tblProductBS;
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
            this.printToolStripButton});
            this.bNavigator.Location = new System.Drawing.Point(0, 463);
            this.bNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bNavigator.MoveNextItem = this.toolStripButton4;
            this.bNavigator.MovePreviousItem = this.toolStripButton3;
            this.bNavigator.Name = "bNavigator";
            this.bNavigator.Padding = new System.Windows.Forms.Padding(0);
            this.bNavigator.PositionItem = this.toolStripTextBox1;
            this.bNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.bNavigator.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bNavigator.Size = new System.Drawing.Size(847, 62);
            this.bNavigator.TabIndex = 29;
            // 
            // toolStripAdd
            // 
            this.toolStripAdd.Enabled = false;
            this.toolStripAdd.Image = ((System.Drawing.Image)(resources.GetObject("toolStripAdd.Image")));
            this.toolStripAdd.Name = "toolStripAdd";
            this.toolStripAdd.RightToLeftAutoMirrorImage = true;
            this.toolStripAdd.Size = new System.Drawing.Size(104, 59);
            this.toolStripAdd.Text = "اضافه کردن";
            this.toolStripAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripAdd.ToolTipText = "درج رکورد جدید";
            // 
            // tblProductBS
            // 
            this.tblProductBS.DataMember = "Tbl_Product";
            this.tblProductBS.DataSource = this.db_DataSetGTP;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(66, 59);
            this.toolStripLabel1.Text = "از {0}";
            this.toolStripLabel1.ToolTipText = "Total number of items";
            // 
            // toolStripDel
            // 
            this.toolStripDel.Enabled = false;
            this.toolStripDel.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDel.Image")));
            this.toolStripDel.Name = "toolStripDel";
            this.toolStripDel.RightToLeftAutoMirrorImage = true;
            this.toolStripDel.Size = new System.Drawing.Size(58, 59);
            this.toolStripDel.Text = "حذف";
            this.toolStripDel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripDel.ToolTipText = "حذف رکورد جاری";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(57, 59);
            this.bindingNavigatorMoveFirstItem.Text = "اولین";
            this.bindingNavigatorMoveFirstItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(53, 59);
            this.toolStripButton3.Text = "قبلی";
            this.toolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 62);
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
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 62);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(58, 59);
            this.toolStripButton4.Text = "بعدی";
            this.toolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
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
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 62);
            // 
            // toolStripSave
            // 
            this.toolStripSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSave.Image")));
            this.toolStripSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSave.Name = "toolStripSave";
            this.toolStripSave.Size = new System.Drawing.Size(110, 59);
            this.toolStripSave.Text = "ذخیره کردن";
            this.toolStripSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripSave.ToolTipText = "ذخیره سازی اطلاعات موجود";
            this.toolStripSave.Click += new System.EventHandler(this.toolStripSave_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 62);
            // 
            // printToolStripButton
            // 
            this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
            this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripButton.Name = "printToolStripButton";
            this.printToolStripButton.Size = new System.Drawing.Size(53, 59);
            this.printToolStripButton.Text = "چاپ";
            this.printToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.printToolStripButton.ToolTipText = "چاپ جدول";
            this.printToolStripButton.Click += new System.EventHandler(this.printToolStripButton_Click);
            // 
            // ultraLabel5
            // 
            this.ultraLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraLabel5.BorderStyleOuter = Infragistics.Win.UIElementBorderStyle.Solid;
            this.ultraLabel5.Location = new System.Drawing.Point(771, 8);
            this.ultraLabel5.Margin = new System.Windows.Forms.Padding(2);
            this.ultraLabel5.Name = "ultraLabel5";
            this.ultraLabel5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ultraLabel5.Size = new System.Drawing.Size(70, 35);
            this.ultraLabel5.TabIndex = 30;
            this.ultraLabel5.Text = "محصول";
            // 
            // txtCodeFak
            // 
            this.txtCodeFak.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodeFak.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblProductBS, "Name_product", true));
            this.txtCodeFak.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2003;
            this.txtCodeFak.Location = new System.Drawing.Point(448, 7);
            this.txtCodeFak.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodeFak.Name = "txtCodeFak";
            this.txtCodeFak.ReadOnly = true;
            this.txtCodeFak.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCodeFak.Size = new System.Drawing.Size(321, 43);
            this.txtCodeFak.TabIndex = 31;
            // 
            // UGrid
            // 
            this.UGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UGrid.DataSource = this.TblItemValTblProductBS;
            appearance1.BackColor = System.Drawing.SystemColors.Window;
            appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.UGrid.DisplayLayout.Appearance = appearance1;
            this.UGrid.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridColumn6.Header.VisiblePosition = 0;
            ultraGridColumn6.Hidden = true;
            ultraGridColumn6.Width = 72;
            ultraGridColumn7.Header.VisiblePosition = 1;
            ultraGridColumn7.Hidden = true;
            ultraGridColumn7.Width = 158;
            ultraGridColumn3.EditorComponent = this.CmbMater;
            ultraGridColumn3.Header.Caption = "نام آیتم";
            ultraGridColumn3.Header.VisiblePosition = 2;
            ultraGridColumn3.Width = 395;
            ultraGridColumn8.Header.Caption = "مقدار";
            ultraGridColumn8.Header.VisiblePosition = 3;
            ultraGridColumn8.Width = 381;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn6,
            ultraGridColumn7,
            ultraGridColumn3,
            ultraGridColumn8});
            ultraGridBand1.SummaryFooterCaption = "جمع فاکتور";
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
            this.UGrid.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.UGrid.Location = new System.Drawing.Point(6, 46);
            this.UGrid.Margin = new System.Windows.Forms.Padding(6);
            this.UGrid.Name = "UGrid";
            this.UGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.UGrid.Size = new System.Drawing.Size(836, 422);
            this.UGrid.TabIndex = 32;
            this.UGrid.Text = "شرح ";
            this.UGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UGrid_KeyDown);
            // 
            // TblItemValTblProductBS
            // 
            this.TblItemValTblProductBS.DataMember = "FK_Tbl_ItemVal_Tbl_Product";
            this.TblItemValTblProductBS.DataSource = this.tblProductBS;
            // 
            // tbl_ProductTA
            // 
            this.tbl_ProductTA.ClearBeforeFill = true;
            // 
            // tbl_ItemValTA
            // 
            this.tbl_ItemValTA.ClearBeforeFill = true;
            // 
            // tbl_ItemTA
            // 
            this.tbl_ItemTA.ClearBeforeFill = true;
            // 
            // report1
            // 
            this.report1.ReportResourceString = resources.GetString("report1.ReportResourceString");
            this.report1.RegisterData(this.db_DataSetGTP, "db_DataSetGTP");
            // 
            // view_ItemValsTA
            // 
            this.view_ItemValsTA.ClearBeforeFill = true;
            // 
            // txtCode
            // 
            this.txtCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblProductBS, "Code_product", true));
            this.txtCode.Location = new System.Drawing.Point(591, 76);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(100, 46);
            this.txtCode.TabIndex = 34;
            // 
            // frmItemVal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(847, 525);
            this.Controls.Add(this.CmbMater);
            this.Controls.Add(this.UGrid);
            this.Controls.Add(this.ultraLabel5);
            this.Controls.Add(this.txtCodeFak);
            this.Controls.Add(this.bNavigator);
            this.Controls.Add(this.txtCode);
            this.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "frmItemVal";
            this.Text = "آنالیز خوراک دام";
            this.Load += new System.EventHandler(this.frmItemVal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CmbMater)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblItemBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_DataSetGTP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bNavigator)).EndInit();
            this.bNavigator.ResumeLayout(false);
            this.bNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodeFak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TblItemValTblProductBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.report1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private Infragistics.Win.Misc.UltraLabel ultraLabel5;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtCodeFak;
        private Infragistics.Win.UltraWinGrid.UltraGrid UGrid;
        private Dset.db_DataSetGTP db_DataSetGTP;
        private System.Windows.Forms.BindingSource tblProductBS;
        private Dset.db_DataSetGTPTableAdapters.Tbl_ProductTA tbl_ProductTA;
        private System.Windows.Forms.BindingSource TblItemValTblProductBS;
        private Dset.db_DataSetGTPTableAdapters.Tbl_ItemValTA tbl_ItemValTA;
        private Infragistics.Win.UltraWinEditors.UltraComboEditor CmbMater;
        private System.Windows.Forms.BindingSource tblItemBS;
        private Dset.db_DataSetGTPTableAdapters.Tbl_ItemTA tbl_ItemTA;
        private FastReport.Report report1;
        private Dset.db_DataSetGTPTableAdapters.View_ItemValsTA view_ItemValsTA;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtCode;
    }
}