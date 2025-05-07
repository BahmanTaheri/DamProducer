namespace DamProducer
{
    partial class frmFastDriver
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
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            this.UGBox = new Infragistics.Win.Misc.UltraGroupBox();
            this.btnCancel = new Infragistics.Win.Misc.UltraButton();
            this.btnOK = new Infragistics.Win.Misc.UltraButton();
            this.ultraLabel8 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel5 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel2 = new Infragistics.Win.Misc.UltraLabel();
            this.txtMobile = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.txtCarNum = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.txtCode = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.txtName = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
            ((System.ComponentModel.ISupportInitialize)(this.UGBox)).BeginInit();
            this.UGBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMobile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCarNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).BeginInit();
            this.SuspendLayout();
            // 
            // UGBox
            // 
            this.UGBox.Controls.Add(this.btnCancel);
            this.UGBox.Controls.Add(this.btnOK);
            this.UGBox.Controls.Add(this.ultraLabel8);
            this.UGBox.Controls.Add(this.ultraLabel5);
            this.UGBox.Controls.Add(this.ultraLabel2);
            this.UGBox.Controls.Add(this.txtMobile);
            this.UGBox.Controls.Add(this.txtCarNum);
            this.UGBox.Controls.Add(this.txtCode);
            this.UGBox.Controls.Add(this.txtName);
            this.UGBox.Controls.Add(this.ultraLabel1);
            this.UGBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UGBox.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.UGBox.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.RightOutsideBorder;
            this.UGBox.Location = new System.Drawing.Point(0, 0);
            this.UGBox.Margin = new System.Windows.Forms.Padding(2);
            this.UGBox.Name = "UGBox";
            this.UGBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.UGBox.Size = new System.Drawing.Size(579, 323);
            this.UGBox.TabIndex = 53;
            this.UGBox.Text = "........................... مشخصات فردی ..............................";
            // 
            // btnCancel
            // 
            appearance9.Image = global::DamProducer.Properties.Resources.cancel;
            this.btnCancel.Appearance = appearance9;
            this.btnCancel.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Windows8Button;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ImageSize = new System.Drawing.Size(24, 24);
            this.btnCancel.Location = new System.Drawing.Point(43, 253);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(140, 41);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "انصراف";
            this.btnCancel.UseOsThemes = Infragistics.Win.DefaultableBoolean.False;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            appearance10.Image = global::DamProducer.Properties.Resources.ok;
            this.btnOK.Appearance = appearance10;
            this.btnOK.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Windows8Button;
            this.btnOK.ImageSize = new System.Drawing.Size(24, 24);
            this.btnOK.Location = new System.Drawing.Point(367, 253);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(140, 41);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "تایید";
            this.btnOK.UseOsThemes = Infragistics.Win.DefaultableBoolean.False;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // ultraLabel8
            // 
            this.ultraLabel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraLabel8.Location = new System.Drawing.Point(408, 191);
            this.ultraLabel8.Margin = new System.Windows.Forms.Padding(2);
            this.ultraLabel8.Name = "ultraLabel8";
            this.ultraLabel8.Size = new System.Drawing.Size(83, 30);
            this.ultraLabel8.TabIndex = 2;
            this.ultraLabel8.Text = "موبایل";
            // 
            // ultraLabel5
            // 
            this.ultraLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraLabel5.Location = new System.Drawing.Point(408, 81);
            this.ultraLabel5.Margin = new System.Windows.Forms.Padding(2);
            this.ultraLabel5.Name = "ultraLabel5";
            this.ultraLabel5.Size = new System.Drawing.Size(83, 30);
            this.ultraLabel5.TabIndex = 2;
            this.ultraLabel5.Text = "پلاک";
            // 
            // ultraLabel2
            // 
            this.ultraLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraLabel2.Location = new System.Drawing.Point(411, 136);
            this.ultraLabel2.Margin = new System.Windows.Forms.Padding(2);
            this.ultraLabel2.Name = "ultraLabel2";
            this.ultraLabel2.Size = new System.Drawing.Size(80, 30);
            this.ultraLabel2.TabIndex = 2;
            this.ultraLabel2.Text = "کد ملی";
            // 
            // txtMobile
            // 
            this.txtMobile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMobile.Location = new System.Drawing.Point(220, 181);
            this.txtMobile.Margin = new System.Windows.Forms.Padding(2);
            this.txtMobile.MaxLength = 15;
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMobile.Size = new System.Drawing.Size(180, 38);
            this.txtMobile.TabIndex = 3;
            // 
            // txtCarNum
            // 
            this.txtCarNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCarNum.Location = new System.Drawing.Point(220, 77);
            this.txtCarNum.Margin = new System.Windows.Forms.Padding(2);
            this.txtCarNum.MaxLength = 10;
            this.txtCarNum.Name = "txtCarNum";
            this.txtCarNum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCarNum.Size = new System.Drawing.Size(181, 38);
            this.txtCarNum.TabIndex = 1;
            // 
            // txtCode
            // 
            this.txtCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCode.Location = new System.Drawing.Point(220, 128);
            this.txtCode.Margin = new System.Windows.Forms.Padding(2);
            this.txtCode.MaxLength = 10;
            this.txtCode.Name = "txtCode";
            this.txtCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCode.Size = new System.Drawing.Size(180, 38);
            this.txtCode.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(87, 28);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.MaxLength = 100;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(314, 36);
            this.txtName.TabIndex = 0;
            // 
            // ultraLabel1
            // 
            this.ultraLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraLabel1.Location = new System.Drawing.Point(400, 27);
            this.ultraLabel1.Margin = new System.Windows.Forms.Padding(2);
            this.ultraLabel1.Name = "ultraLabel1";
            this.ultraLabel1.Size = new System.Drawing.Size(91, 30);
            this.ultraLabel1.TabIndex = 2;
            this.ultraLabel1.Text = "نام شخص";
            // 
            // frmFastDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(579, 323);
            this.Controls.Add(this.UGBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmFastDriver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.UGBox)).EndInit();
            this.UGBox.ResumeLayout(false);
            this.UGBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMobile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCarNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.Misc.UltraGroupBox UGBox;
        private Infragistics.Win.Misc.UltraButton btnCancel;
        private Infragistics.Win.Misc.UltraButton btnOK;
        private Infragistics.Win.Misc.UltraLabel ultraLabel8;
        private Infragistics.Win.Misc.UltraLabel ultraLabel5;
        private Infragistics.Win.Misc.UltraLabel ultraLabel2;
        public Infragistics.Win.UltraWinEditors.UltraTextEditor txtMobile;
        public Infragistics.Win.UltraWinEditors.UltraTextEditor txtCarNum;
        public Infragistics.Win.UltraWinEditors.UltraTextEditor txtCode;
        public Infragistics.Win.UltraWinEditors.UltraTextEditor txtName;
        private Infragistics.Win.Misc.UltraLabel ultraLabel1;
    }
}