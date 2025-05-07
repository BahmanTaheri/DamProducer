namespace DamProducer
{
    partial class frmSelectYear
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
            this.ultraLabel3 = new Infragistics.Win.Misc.UltraLabel();
            this.CmbYear = new Infragistics.Win.UltraWinEditors.UltraComboEditor();
            this.db_DataSetPerson = new DamProducer.Dset.db_DataSetPerson();
            this.ubtnComite = new Infragistics.Win.Misc.UltraButton();
            this.view_YearTA = new DamProducer.Dset.db_DataSetPersonTableAdapters.View_YearTA();
            ((System.ComponentModel.ISupportInitialize)(this.CmbYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_DataSetPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // ultraLabel3
            // 
            this.ultraLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraLabel3.Location = new System.Drawing.Point(230, 34);
            this.ultraLabel3.Margin = new System.Windows.Forms.Padding(2);
            this.ultraLabel3.Name = "ultraLabel3";
            this.ultraLabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ultraLabel3.Size = new System.Drawing.Size(49, 30);
            this.ultraLabel3.TabIndex = 55;
            this.ultraLabel3.Text = "سال";
            // 
            // CmbYear
            // 
            this.CmbYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbYear.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.CmbYear.DataMember = "View_Year";
            this.CmbYear.DataSource = this.db_DataSetPerson;
            this.CmbYear.DisplayMember = "Year";
            this.CmbYear.Location = new System.Drawing.Point(25, 30);
            this.CmbYear.Margin = new System.Windows.Forms.Padding(2);
            this.CmbYear.Name = "CmbYear";
            this.CmbYear.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CmbYear.Size = new System.Drawing.Size(201, 36);
            this.CmbYear.TabIndex = 54;
            this.CmbYear.ValueMember = "Year";
            // 
            // db_DataSetPerson
            // 
            this.db_DataSetPerson.DataSetName = "db_DataSetPerson";
            this.db_DataSetPerson.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ubtnComite
            // 
            this.ubtnComite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            appearance1.Image = global::DamProducer.Properties.Resources.ok;
            this.ubtnComite.Appearance = appearance1;
            this.ubtnComite.ImageSize = new System.Drawing.Size(28, 28);
            this.ubtnComite.Location = new System.Drawing.Point(25, 89);
            this.ubtnComite.Margin = new System.Windows.Forms.Padding(2);
            this.ubtnComite.Name = "ubtnComite";
            this.ubtnComite.Size = new System.Drawing.Size(201, 37);
            this.ubtnComite.TabIndex = 56;
            this.ubtnComite.Text = "تایید";
            this.ubtnComite.Click += new System.EventHandler(this.ubtnComite_Click);
            // 
            // view_YearTA
            // 
            this.view_YearTA.ClearBeforeFill = true;
            // 
            // frmSelectYear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(290, 137);
            this.Controls.Add(this.ubtnComite);
            this.Controls.Add(this.ultraLabel3);
            this.Controls.Add(this.CmbYear);
            this.Font = new System.Drawing.Font("B Nazanin", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSelectYear";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "انتخاب سال";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSelectYear_FormClosed);
            this.Load += new System.EventHandler(this.frmSelectYear_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CmbYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_DataSetPerson)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Infragistics.Win.Misc.UltraLabel ultraLabel3;
        private Infragistics.Win.UltraWinEditors.UltraComboEditor CmbYear;
        private Infragistics.Win.Misc.UltraButton ubtnComite;
        private Dset.db_DataSetPerson db_DataSetPerson;
        private Dset.db_DataSetPersonTableAdapters.View_YearTA view_YearTA;
    }
}