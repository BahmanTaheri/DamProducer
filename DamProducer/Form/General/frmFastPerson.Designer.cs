namespace DamProducer
{
    partial class frmFastPerson
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
            Infragistics.Win.ValueListItem valueListItem1 = new Infragistics.Win.ValueListItem();
            Infragistics.Win.ValueListItem valueListItem2 = new Infragistics.Win.ValueListItem();
            Infragistics.Win.ValueListItem valueListItem4 = new Infragistics.Win.ValueListItem();
            Infragistics.Win.ValueListItem valueListItem3 = new Infragistics.Win.ValueListItem();
            this.btnCancel = new Infragistics.Win.Misc.UltraButton();
            this.btnOK = new Infragistics.Win.Misc.UltraButton();
            this.UGBox = new Infragistics.Win.Misc.UltraGroupBox();
            this.CmbPtype = new Infragistics.Win.UltraWinEditors.UltraComboEditor();
            this.ultraLabel23 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel4 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel8 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel5 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel2 = new Infragistics.Win.Misc.UltraLabel();
            this.txtAdress = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.txtMobile = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.txtEco = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.txtPostCode = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.txtCode = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.txtName = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel6 = new Infragistics.Win.Misc.UltraLabel();
            ((System.ComponentModel.ISupportInitialize)(this.UGBox)).BeginInit();
            this.UGBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CmbPtype)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMobile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPostCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            appearance1.Image = global::DamProducer.Properties.Resources.cancel;
            this.btnCancel.Appearance = appearance1;
            this.btnCancel.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Windows8Button;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ImageSize = new System.Drawing.Size(24, 24);
            this.btnCancel.Location = new System.Drawing.Point(24, 317);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(140, 41);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "انصراف";
            this.btnCancel.UseOsThemes = Infragistics.Win.DefaultableBoolean.False;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            appearance2.Image = global::DamProducer.Properties.Resources.ok;
            this.btnOK.Appearance = appearance2;
            this.btnOK.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Windows8Button;
            this.btnOK.ImageSize = new System.Drawing.Size(24, 24);
            this.btnOK.Location = new System.Drawing.Point(490, 317);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(140, 41);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "تایید";
            this.btnOK.UseOsThemes = Infragistics.Win.DefaultableBoolean.False;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // UGBox
            // 
            this.UGBox.Controls.Add(this.CmbPtype);
            this.UGBox.Controls.Add(this.btnCancel);
            this.UGBox.Controls.Add(this.ultraLabel23);
            this.UGBox.Controls.Add(this.btnOK);
            this.UGBox.Controls.Add(this.ultraLabel4);
            this.UGBox.Controls.Add(this.ultraLabel8);
            this.UGBox.Controls.Add(this.ultraLabel5);
            this.UGBox.Controls.Add(this.ultraLabel2);
            this.UGBox.Controls.Add(this.txtAdress);
            this.UGBox.Controls.Add(this.txtMobile);
            this.UGBox.Controls.Add(this.txtEco);
            this.UGBox.Controls.Add(this.txtPostCode);
            this.UGBox.Controls.Add(this.txtCode);
            this.UGBox.Controls.Add(this.txtName);
            this.UGBox.Controls.Add(this.ultraLabel1);
            this.UGBox.Controls.Add(this.ultraLabel6);
            this.UGBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UGBox.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.UGBox.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.RightOutsideBorder;
            this.UGBox.Location = new System.Drawing.Point(0, 0);
            this.UGBox.Margin = new System.Windows.Forms.Padding(2);
            this.UGBox.Name = "UGBox";
            this.UGBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.UGBox.Size = new System.Drawing.Size(720, 380);
            this.UGBox.TabIndex = 52;
            this.UGBox.Text = "........................... مشخصات فردی ..............................";
            // 
            // CmbPtype
            // 
            this.CmbPtype.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbPtype.DisplayMember = "";
            this.CmbPtype.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            valueListItem1.DataValue = "11";
            valueListItem1.DisplayText = "حقیقی مصرف کننده";
            valueListItem2.DataValue = "14";
            valueListItem2.DisplayText = "حقیقی مشمول مالیات";
            valueListItem4.DataValue = "24";
            valueListItem4.DisplayText = "حقوقی غیردولتی";
            valueListItem3.DataValue = "34";
            valueListItem3.DisplayText = "حقوقی دولتی";
            this.CmbPtype.Items.AddRange(new Infragistics.Win.ValueListItem[] {
            valueListItem1,
            valueListItem2,
            valueListItem4,
            valueListItem3});
            this.CmbPtype.Location = new System.Drawing.Point(27, 84);
            this.CmbPtype.Margin = new System.Windows.Forms.Padding(2);
            this.CmbPtype.Name = "CmbPtype";
            this.CmbPtype.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CmbPtype.Size = new System.Drawing.Size(175, 36);
            this.CmbPtype.TabIndex = 2;
            this.CmbPtype.ValueMember = "";
            // 
            // ultraLabel23
            // 
            this.ultraLabel23.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraLabel23.Location = new System.Drawing.Point(217, 90);
            this.ultraLabel23.Margin = new System.Windows.Forms.Padding(2);
            this.ultraLabel23.Name = "ultraLabel23";
            this.ultraLabel23.Size = new System.Drawing.Size(96, 30);
            this.ultraLabel23.TabIndex = 19;
            this.ultraLabel23.Text = "نوع شخص";
            // 
            // ultraLabel4
            // 
            this.ultraLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraLabel4.Location = new System.Drawing.Point(585, 241);
            this.ultraLabel4.Margin = new System.Windows.Forms.Padding(2);
            this.ultraLabel4.Name = "ultraLabel4";
            this.ultraLabel4.Size = new System.Drawing.Size(80, 30);
            this.ultraLabel4.TabIndex = 2;
            this.ultraLabel4.Text = "آدرس ";
            // 
            // ultraLabel8
            // 
            this.ultraLabel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraLabel8.Location = new System.Drawing.Point(582, 197);
            this.ultraLabel8.Margin = new System.Windows.Forms.Padding(2);
            this.ultraLabel8.Name = "ultraLabel8";
            this.ultraLabel8.Size = new System.Drawing.Size(83, 30);
            this.ultraLabel8.TabIndex = 2;
            this.ultraLabel8.Text = "موبایل";
            // 
            // ultraLabel5
            // 
            this.ultraLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraLabel5.Location = new System.Drawing.Point(582, 87);
            this.ultraLabel5.Margin = new System.Windows.Forms.Padding(2);
            this.ultraLabel5.Name = "ultraLabel5";
            this.ultraLabel5.Size = new System.Drawing.Size(83, 30);
            this.ultraLabel5.TabIndex = 2;
            this.ultraLabel5.Text = "کد پستی";
            // 
            // ultraLabel2
            // 
            this.ultraLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraLabel2.Location = new System.Drawing.Point(585, 142);
            this.ultraLabel2.Margin = new System.Windows.Forms.Padding(2);
            this.ultraLabel2.Name = "ultraLabel2";
            this.ultraLabel2.Size = new System.Drawing.Size(80, 30);
            this.ultraLabel2.TabIndex = 2;
            this.ultraLabel2.Text = "کد ملی";
            // 
            // txtAdress
            // 
            this.txtAdress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAdress.Location = new System.Drawing.Point(25, 241);
            this.txtAdress.Margin = new System.Windows.Forms.Padding(2);
            this.txtAdress.MaxLength = 100;
            this.txtAdress.Multiline = true;
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(549, 38);
            this.txtAdress.TabIndex = 7;
            // 
            // txtMobile
            // 
            this.txtMobile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMobile.Location = new System.Drawing.Point(394, 187);
            this.txtMobile.Margin = new System.Windows.Forms.Padding(2);
            this.txtMobile.MaxLength = 15;
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMobile.Size = new System.Drawing.Size(180, 38);
            this.txtMobile.TabIndex = 5;
            // 
            // txtEco
            // 
            this.txtEco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEco.Location = new System.Drawing.Point(27, 134);
            this.txtEco.Margin = new System.Windows.Forms.Padding(2);
            this.txtEco.MaxLength = 14;
            this.txtEco.Name = "txtEco";
            this.txtEco.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEco.Size = new System.Drawing.Size(175, 38);
            this.txtEco.TabIndex = 4;
            // 
            // txtPostCode
            // 
            this.txtPostCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPostCode.Location = new System.Drawing.Point(394, 83);
            this.txtPostCode.Margin = new System.Windows.Forms.Padding(2);
            this.txtPostCode.MaxLength = 10;
            this.txtPostCode.Name = "txtPostCode";
            this.txtPostCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPostCode.Size = new System.Drawing.Size(181, 38);
            this.txtPostCode.TabIndex = 1;
            // 
            // txtCode
            // 
            this.txtCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCode.Location = new System.Drawing.Point(394, 134);
            this.txtCode.Margin = new System.Windows.Forms.Padding(2);
            this.txtCode.MaxLength = 10;
            this.txtCode.Name = "txtCode";
            this.txtCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCode.Size = new System.Drawing.Size(180, 38);
            this.txtCode.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(261, 34);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.MaxLength = 100;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(314, 36);
            this.txtName.TabIndex = 0;
            // 
            // ultraLabel1
            // 
            this.ultraLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraLabel1.Location = new System.Drawing.Point(574, 33);
            this.ultraLabel1.Margin = new System.Windows.Forms.Padding(2);
            this.ultraLabel1.Name = "ultraLabel1";
            this.ultraLabel1.Size = new System.Drawing.Size(91, 30);
            this.ultraLabel1.TabIndex = 2;
            this.ultraLabel1.Text = "نام شخص";
            // 
            // ultraLabel6
            // 
            this.ultraLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraLabel6.Location = new System.Drawing.Point(196, 142);
            this.ultraLabel6.Margin = new System.Windows.Forms.Padding(2);
            this.ultraLabel6.Name = "ultraLabel6";
            this.ultraLabel6.Size = new System.Drawing.Size(138, 30);
            this.ultraLabel6.TabIndex = 5;
            this.ultraLabel6.Text = "شماره اقتصادی";
            // 
            // frmFastPerson
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(720, 380);
            this.Controls.Add(this.UGBox);
            this.Font = new System.Drawing.Font("B Nazanin", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmFastPerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.UGBox)).EndInit();
            this.UGBox.ResumeLayout(false);
            this.UGBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CmbPtype)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMobile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPostCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Infragistics.Win.Misc.UltraButton btnCancel;
        private Infragistics.Win.Misc.UltraButton btnOK;
        private Infragistics.Win.Misc.UltraGroupBox UGBox;
        private Infragistics.Win.Misc.UltraLabel ultraLabel23;
        private Infragistics.Win.Misc.UltraLabel ultraLabel4;
        private Infragistics.Win.Misc.UltraLabel ultraLabel8;
        private Infragistics.Win.Misc.UltraLabel ultraLabel5;
        private Infragistics.Win.Misc.UltraLabel ultraLabel2;
        private Infragistics.Win.Misc.UltraLabel ultraLabel1;
        private Infragistics.Win.Misc.UltraLabel ultraLabel6;
        public Infragistics.Win.UltraWinEditors.UltraTextEditor txtName;
        public Infragistics.Win.UltraWinEditors.UltraComboEditor CmbPtype;
        public Infragistics.Win.UltraWinEditors.UltraTextEditor txtAdress;
        public Infragistics.Win.UltraWinEditors.UltraTextEditor txtMobile;
        public Infragistics.Win.UltraWinEditors.UltraTextEditor txtEco;
        public Infragistics.Win.UltraWinEditors.UltraTextEditor txtPostCode;
        public Infragistics.Win.UltraWinEditors.UltraTextEditor txtCode;
    }
}