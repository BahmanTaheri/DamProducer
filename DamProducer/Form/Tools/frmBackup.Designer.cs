namespace DamProducer
{
    partial class frmBackup
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
            this.btnsave = new Infragistics.Win.Misc.UltraButton();
            this.txtsave = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRestore = new Infragistics.Win.Misc.UltraButton();
            this.txtrestore = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtsave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtrestore)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsave
            // 
            this.btnsave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            appearance1.Image = global::DamProducer.Properties.Resources.backup;
            this.btnsave.Appearance = appearance1;
            this.btnsave.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Windows8Button;
            this.btnsave.ImageSize = new System.Drawing.Size(24, 24);
            this.btnsave.Location = new System.Drawing.Point(74, 39);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(155, 38);
            this.btnsave.TabIndex = 0;
            this.btnsave.Text = "پشتیبان گیری";
            this.btnsave.UseOsThemes = Infragistics.Win.DefaultableBoolean.False;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txtsave
            // 
            this.txtsave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtsave.Location = new System.Drawing.Point(235, 39);
            this.txtsave.Name = "txtsave";
            this.txtsave.ReadOnly = true;
            this.txtsave.Size = new System.Drawing.Size(368, 38);
            this.txtsave.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(609, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "نام فایل";
            // 
            // btnRestore
            // 
            this.btnRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            appearance2.Image = global::DamProducer.Properties.Resources.restore;
            this.btnRestore.Appearance = appearance2;
            this.btnRestore.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Windows8Button;
            this.btnRestore.ImageSize = new System.Drawing.Size(24, 24);
            this.btnRestore.Location = new System.Drawing.Point(74, 160);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(155, 38);
            this.btnRestore.TabIndex = 0;
            this.btnRestore.Text = "بازیابی پشتیبان";
            this.btnRestore.UseOsThemes = Infragistics.Win.DefaultableBoolean.False;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // txtrestore
            // 
            this.txtrestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtrestore.Location = new System.Drawing.Point(235, 160);
            this.txtrestore.Name = "txtrestore";
            this.txtrestore.ReadOnly = true;
            this.txtrestore.Size = new System.Drawing.Size(368, 38);
            this.txtrestore.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(609, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "نام فایل";
            // 
            // frmBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(693, 305);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtrestore);
            this.Controls.Add(this.txtsave);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.btnsave);
            this.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmBackup";
            this.Text = "ذخیره و بازیابی پشتیبان";
            ((System.ComponentModel.ISupportInitialize)(this.txtsave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtrestore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Infragistics.Win.Misc.UltraButton btnsave;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtsave;
        private System.Windows.Forms.Label label1;
        private Infragistics.Win.Misc.UltraButton btnRestore;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtrestore;
        private System.Windows.Forms.Label label2;
    }
}