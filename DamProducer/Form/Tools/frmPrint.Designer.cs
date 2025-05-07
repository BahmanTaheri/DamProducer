namespace DamProducer
{
    partial class frmPrint
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
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            this.fastPreview = new FastReport.Preview.PreviewControl();
            this.toolbox = new Infragistics.Win.Misc.UltraGroupBox();
            this.btnClose = new Infragistics.Win.Misc.UltraButton();
            this.btnPdf = new Infragistics.Win.Misc.UltraButton();
            this.btnPrintA5 = new Infragistics.Win.Misc.UltraButton();
            this.btnPrint = new Infragistics.Win.Misc.UltraButton();
            ((System.ComponentModel.ISupportInitialize)(this.toolbox)).BeginInit();
            this.toolbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // fastPreview
            // 
            this.fastPreview.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.fastPreview.Clouds = FastReport.PreviewClouds.None;
            this.fastPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fastPreview.Exports = ((FastReport.PreviewExports)((((((((((((((((((((((((FastReport.PreviewExports.PDFExport | FastReport.PreviewExports.RTFExport) 
            | FastReport.PreviewExports.HTMLExport) 
            | FastReport.PreviewExports.MHTExport) 
            | FastReport.PreviewExports.XMLExport) 
            | FastReport.PreviewExports.Excel2007Export) 
            | FastReport.PreviewExports.Excel2003Document) 
            | FastReport.PreviewExports.Word2007Export) 
            | FastReport.PreviewExports.PowerPoint2007Export) 
            | FastReport.PreviewExports.ODSExport) 
            | FastReport.PreviewExports.ODTExport) 
            | FastReport.PreviewExports.XPSExport) 
            | FastReport.PreviewExports.CSVExport) 
            | FastReport.PreviewExports.DBFExport) 
            | FastReport.PreviewExports.TextExport) 
            | FastReport.PreviewExports.ZplExport) 
            | FastReport.PreviewExports.ImageExport) 
            | FastReport.PreviewExports.XAMLExport) 
            | FastReport.PreviewExports.SVGExport) 
            | FastReport.PreviewExports.PPMLExport) 
            | FastReport.PreviewExports.PSExport) 
            | FastReport.PreviewExports.JsonExport) 
            | FastReport.PreviewExports.LaTeXExport) 
            | FastReport.PreviewExports.DxfExport)));
            this.fastPreview.Font = new System.Drawing.Font("Tahoma", 6.4F);
            this.fastPreview.Location = new System.Drawing.Point(0, 42);
            this.fastPreview.Margin = new System.Windows.Forms.Padding(2);
            this.fastPreview.Name = "fastPreview";
            this.fastPreview.PageOffset = new System.Drawing.Point(10, 10);
            this.fastPreview.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fastPreview.SaveInitialDirectory = null;
            this.fastPreview.Size = new System.Drawing.Size(834, 348);
            this.fastPreview.TabIndex = 0;
            this.fastPreview.ToolbarVisible = false;
            this.fastPreview.UIStyle = FastReport.Utils.UIStyle.Office2010Blue;
            // 
            // toolbox
            // 
            appearance1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.toolbox.Appearance = appearance1;
            this.toolbox.BorderStyle = Infragistics.Win.Misc.GroupBoxBorderStyle.None;
            this.toolbox.Controls.Add(this.btnClose);
            this.toolbox.Controls.Add(this.btnPdf);
            this.toolbox.Controls.Add(this.btnPrintA5);
            this.toolbox.Controls.Add(this.btnPrint);
            this.toolbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolbox.Location = new System.Drawing.Point(0, 0);
            this.toolbox.Margin = new System.Windows.Forms.Padding(2);
            this.toolbox.Name = "toolbox";
            this.toolbox.Size = new System.Drawing.Size(834, 42);
            this.toolbox.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            appearance2.Image = global::DamProducer.Properties.Resources.cancel;
            this.btnClose.Appearance = appearance2;
            this.btnClose.ImageSize = new System.Drawing.Size(24, 24);
            this.btnClose.Location = new System.Drawing.Point(375, 4);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(103, 34);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "خروج";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPdf
            // 
            this.btnPdf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            appearance3.Image = global::DamProducer.Properties.Resources.Save;
            this.btnPdf.Appearance = appearance3;
            this.btnPdf.ImageSize = new System.Drawing.Size(24, 24);
            this.btnPdf.Location = new System.Drawing.Point(481, 4);
            this.btnPdf.Margin = new System.Windows.Forms.Padding(2);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(103, 34);
            this.btnPdf.TabIndex = 5;
            this.btnPdf.Text = "ذخیره";
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // btnPrintA5
            // 
            this.btnPrintA5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            appearance4.Image = global::DamProducer.Properties.Resources.print;
            this.btnPrintA5.Appearance = appearance4;
            this.btnPrintA5.ImageSize = new System.Drawing.Size(24, 24);
            this.btnPrintA5.Location = new System.Drawing.Point(615, 4);
            this.btnPrintA5.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrintA5.Name = "btnPrintA5";
            this.btnPrintA5.Size = new System.Drawing.Size(103, 34);
            this.btnPrintA5.TabIndex = 5;
            this.btnPrintA5.Text = "چاپ A5";
            this.btnPrintA5.Click += new System.EventHandler(this.btnPrintA5_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            appearance5.Image = global::DamProducer.Properties.Resources.print;
            this.btnPrint.Appearance = appearance5;
            this.btnPrint.ImageSize = new System.Drawing.Size(24, 24);
            this.btnPrint.Location = new System.Drawing.Point(722, 4);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(103, 34);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "چاپ A4";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(834, 390);
            this.Controls.Add(this.fastPreview);
            this.Controls.Add(this.toolbox);
            this.Font = new System.Drawing.Font("B Nazanin", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "پیش نمایش";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.toolbox)).EndInit();
            this.toolbox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public FastReport.Preview.PreviewControl fastPreview;
        private Infragistics.Win.Misc.UltraGroupBox toolbox;
        private Infragistics.Win.Misc.UltraButton btnPrint;
        private Infragistics.Win.Misc.UltraButton btnClose;
        private Infragistics.Win.Misc.UltraButton btnPdf;
        private Infragistics.Win.Misc.UltraButton btnPrintA5;
    }
}