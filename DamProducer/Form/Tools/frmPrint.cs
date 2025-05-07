using FastReport.Export.Pdf;
using System;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace DamProducer
{

    public partial class frmPrint : Form
    {
        public bool printed = false;
        public frmPrint()
        {
            InitializeComponent();
        }


        private void btnPrint_Click(object sender, EventArgs e)
        {
            
            fastPreview.Report.PrintSettings.PrintMode = FastReport.PrintMode.Scale;
            fastPreview.Report.PrintSettings.PrintOnSheetHeight = 210;
            fastPreview.Report.PrintSettings.PrintOnSheetWidth = 297;

            if (fastPreview.Print())
            {
                this.printed = true;
                this.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Title = "ذخیره";
            sf.Filter = "PDF Files (*.pdf) |*.pdf";
            sf.OverwritePrompt = true;
            sf.FileName = "Document";
            if (sf.ShowDialog() == DialogResult.OK)
            {
                // report1.Prepare();
                PDFExport pdf = new PDFExport();
                fastPreview.Report.Export(pdf, sf.FileName);
                this.printed = true;
                this.Close();
            }

        }

        private void btnPrintA5_Click(object sender, EventArgs e)
        {
            fastPreview.Report.PrintSettings.PrintMode = FastReport.PrintMode.Scale;
            
            fastPreview.Report.PrintSettings.PrintOnSheetHeight = 210;
            fastPreview.Report.PrintSettings.PrintOnSheetWidth = 148;
            if (fastPreview.Print())
            {
                this.printed = true;
                this.Close();
            }
        }
    }
}
