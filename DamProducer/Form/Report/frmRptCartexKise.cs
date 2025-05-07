using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace DamProducer
{
    public partial class frmRptCartexKise : Form
    {
        public frmRptCartexKise()
        {
            InitializeComponent();
        }

        private void ultraButton1_Click(object sender, EventArgs e)
        {
            UGrid.PrintPreview();
        }

        private void frmReportKise_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_DataSetGTP.Tbl_Bag' table. You can move, or remove it, as needed.
            this.tbl_BagTA.Fill(this.db_DataSetGTP.Tbl_Bag);

        }
        decimal m = 0;
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string d1 = frmLogin.Year + "/01/01"; ;
            string d2 = frmLogin.Year + "/12/30"; ;
            string d0 = frmLogin.Year + "/01/01";

            err.Clear();
            if (UComboMatter.Value == null)
            {
                err.SetError(UComboMatter, "ورود اجباری می باشد");
                return;
            }

            if (function.AccDateInput(txtDate1.Text))
            {
                d1 = txtDate1.Text;
            }

            if (function.AccDateInput(txtDate2.Text))
            {
                d2 = txtDate2.Text;
            }

            m = 0;
            SqlConnection Con = new SqlConnection(DamProducer.Properties.Settings.Default.ConString);
            Con.Open();
            SqlDataAdapter DA = new SqlDataAdapter("", Con);
            DA.SelectCommand.CommandType = CommandType.StoredProcedure;
            if (Con.State == ConnectionState.Closed)
                Con.Open();
            DA.SelectCommand.Parameters.Clear();
            db_DataSetGTP.Cartex.Clear();
            if (UComboMatter.Value != null)
            {
                DA.SelectCommand.CommandText = "CartexKise";
                DA.SelectCommand.Parameters.AddWithValue("@CodeBag", (int)UComboMatter.Value);
                DA.SelectCommand.Parameters.AddWithValue("@DateMin", d1);
                DA.SelectCommand.Parameters.AddWithValue("@DateMax", d2);

                DA.Fill(db_DataSetGTP.CartexKise);
            }


            Con.Close();
            DA.Dispose();
            Con.Dispose();
        }

        private void txtDate1_KeyDown(object sender, KeyEventArgs e)
        {
            function.NextControl(sender, ref e);
        }

        private void UGrid_InitializeRow(object sender, InitializeRowEventArgs e)
        {
            UltraGridBand band = this.UGrid.DisplayLayout.Bands[0];
            decimal v = 0;
            decimal k = 0;
            if (e.Row.Band == band)
            {
                try { v = (decimal)e.Row.GetCellValue(band.Columns["Voroodi"]); }
                catch { v = 0; }
                try { k = (decimal)e.Row.GetCellValue(band.Columns["Khorooji"]); }
                catch { k = 0; }

                m = m + v - k;
                e.Row.Cells["Mandeh"].Value = m;


            }
            UGrid.UpdateData();
        }

        private void UGrid_InitializePrintPreview(object sender, CancelablePrintPreviewEventArgs e)
        {
            //' Set the zomm level to 100 % in the print preview.
            e.PrintPreviewSettings.Zoom = 1.0;

            //' Set the location and size of the print preview dialog.
            e.PrintPreviewSettings.DialogLeft = SystemInformation.WorkingArea.X;
            e.PrintPreviewSettings.DialogTop = SystemInformation.WorkingArea.Y;
            e.PrintPreviewSettings.DialogWidth = SystemInformation.WorkingArea.Width;
            e.PrintPreviewSettings.DialogHeight = SystemInformation.WorkingArea.Height;
            e.PrintPreviewSettings.DialogCaption = "لیست کلی ";

            //' Horizontally fit everything in a signle page.
            e.DefaultLogicalPageLayoutInfo.FitWidthToPages = 1;

            // ' Set up the header and the footer.
            e.DefaultLogicalPageLayoutInfo.PageHeader = "کاردکس کیسه";
            e.DefaultLogicalPageLayoutInfo.PageHeaderHeight = 70;
            e.DefaultLogicalPageLayoutInfo.PageHeaderAppearance.FontData.SizeInPoints = 25;
            e.DefaultLogicalPageLayoutInfo.PageHeaderAppearance.FontData.Name = "B Nazanin";
            e.DefaultLogicalPageLayoutInfo.PageHeaderAppearance.FontData.Bold = Infragistics.Win.DefaultableBoolean.True;
            e.DefaultLogicalPageLayoutInfo.PageHeaderAppearance.TextHAlign = HAlign.Center;
            e.DefaultLogicalPageLayoutInfo.PageHeaderBorderStyle = UIElementBorderStyle.Solid;

            // ' Use <#> token in the string to designate page numbers.
            e.DefaultLogicalPageLayoutInfo.PageFooter = "صفحه: <#>";
            e.DefaultLogicalPageLayoutInfo.PageFooterHeight = 40;
            e.DefaultLogicalPageLayoutInfo.PageFooterAppearance.TextHAlign = HAlign.Center;
            e.DefaultLogicalPageLayoutInfo.PageFooterAppearance.FontData.Italic = DefaultableBoolean.False;
            e.DefaultLogicalPageLayoutInfo.PageFooterBorderStyle = UIElementBorderStyle.Solid;
            //  ' Set the ClippingOverride to Yes.;
            e.DefaultLogicalPageLayoutInfo.ClippingOverride = ClippingOverride.Yes;

            //  ' Set the document name through the PrintDocument which returns a PrintDocument object.

            e.PrintDocument.DocumentName = "کاردکس کیسه";
            e.PrintDocument.DefaultPageSettings.Landscape = false;
            e.PrintDocument.DefaultPageSettings.Margins.Bottom = 50;
            e.PrintDocument.DefaultPageSettings.Margins.Top = 50;
            e.PrintDocument.DefaultPageSettings.Margins.Right = 100;
            e.PrintDocument.DefaultPageSettings.Margins.Left = 100;
            e.PrintLayout.Appearance.BackColor = Color.White;
            e.PrintLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard;
            e.PrintLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            e.PrintLayout.Override.RowAlternateAppearance.BackColor = Color.Gainsboro;
            e.PrintLayout.Bands[0].RowLayoutStyle = RowLayoutStyle.None;

            // e.PrintLayout.Bands[0].UseRowLayout = false;
            e.PrintLayout.AutoFitStyle = AutoFitStyle.ExtendLastColumn;
            e.PrintLayout.Appearance.FontData.Bold = DefaultableBoolean.False;
            e.PrintLayout.Appearance.FontData.SizeInPoints = 20;
        }


    }
}
