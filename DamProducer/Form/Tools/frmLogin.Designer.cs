namespace DamProducer
{
    partial class frmLogin
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
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.cmbUsers = new Infragistics.Win.UltraWinEditors.UltraComboEditor();
            this.tblTahvilBS = new System.Windows.Forms.BindingSource(this.components);
            this.db_DSPerson = new DamProducer.Dset.db_DataSetPerson();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpass = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.btnEnter = new Infragistics.Win.Misc.UltraButton();
            this.btnClose = new Infragistics.Win.Misc.UltraButton();
            this.tbl_TahvilTA = new DamProducer.Dset.db_DataSetPersonTableAdapters.Tbl_TahvilTA();
            this.view_YearTA = new DamProducer.Dset.db_DataSetPersonTableAdapters.View_YearTA();
            ((System.ComponentModel.ISupportInitialize)(this.cmbUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTahvilBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_DSPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpass)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbUsers
            // 
            this.cmbUsers.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            this.cmbUsers.DataSource = this.tblTahvilBS;
            this.cmbUsers.DisplayMember = "Name_tahvil";
            this.cmbUsers.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2013;
            this.cmbUsers.Location = new System.Drawing.Point(35, 29);
            this.cmbUsers.Margin = new System.Windows.Forms.Padding(4);
            this.cmbUsers.Name = "cmbUsers";
            this.cmbUsers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbUsers.Size = new System.Drawing.Size(241, 43);
            this.cmbUsers.TabIndex = 0;
            this.cmbUsers.ValueMember = "Code_tahvil";
            this.cmbUsers.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtpass_KeyDown);
            // 
            // tblTahvilBS
            // 
            this.tblTahvilBS.DataMember = "Tbl_Tahvil";
            this.tblTahvilBS.DataSource = this.db_DSPerson;
            // 
            // db_DSPerson
            // 
            this.db_DSPerson.DataSetName = "db_DataSetPerson";
            this.db_DSPerson.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(300, 30);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(105, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "نام کاربری:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(307, 95);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(94, 38);
            this.label2.TabIndex = 4;
            this.label2.Text = "رمز عبور:";
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(35, 87);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(241, 46);
            this.txtpass.TabIndex = 1;
            this.txtpass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtpass_KeyDown);
            // 
            // btnEnter
            // 
            appearance1.Image = global::DamProducer.Properties.Resources.ok;
            this.btnEnter.Appearance = appearance1;
            this.btnEnter.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Windows8Button;
            this.btnEnter.ImageSize = new System.Drawing.Size(32, 32);
            this.btnEnter.Location = new System.Drawing.Point(254, 154);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(128, 41);
            this.btnEnter.TabIndex = 2;
            this.btnEnter.Text = "تایید";
            this.btnEnter.UseOsThemes = Infragistics.Win.DefaultableBoolean.False;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnClose
            // 
            appearance2.Image = global::DamProducer.Properties.Resources.cancel;
            this.btnClose.Appearance = appearance2;
            this.btnClose.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Windows8Button;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.ImageSize = new System.Drawing.Size(32, 32);
            this.btnClose.Location = new System.Drawing.Point(35, 154);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(129, 41);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "خروج";
            this.btnClose.UseOsThemes = Infragistics.Win.DefaultableBoolean.False;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tbl_TahvilTA
            // 
            this.tbl_TahvilTA.ClearBeforeFill = true;
            // 
            // view_YearTA
            // 
            this.view_YearTA.ClearBeforeFill = true;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(425, 221);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbUsers);
            this.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ورود";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTahvilBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_DSPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Infragistics.Win.UltraWinEditors.UltraComboEditor cmbUsers;
        private Dset.db_DataSetPerson db_DSPerson;
        private System.Windows.Forms.BindingSource tblTahvilBS;
        private Dset.db_DataSetPersonTableAdapters.Tbl_TahvilTA tbl_TahvilTA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtpass;
        private Infragistics.Win.Misc.UltraButton btnEnter;
        private Infragistics.Win.Misc.UltraButton btnClose;
        private Dset.db_DataSetPersonTableAdapters.View_YearTA view_YearTA;
    }
}