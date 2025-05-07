using FastReport;
using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace DamProducer
{
    public partial class frmMojodiAvalye : Form
    {
        public frmMojodiAvalye()
        {
            InitializeComponent();
        }


        private bool NotError()
        {
            this.err.Clear();
            if (!function.AccDateInput(this.txtDate.Text))
            {
                this.err.SetError(this.txtDate, " تاریخ را وارد کنید");
                this.txtDate.Focus();
                return false;
            }
            if (this.cmbAnbar.Value == null)
            {
                this.err.SetError(this.cmbAnbar, " انبار را انتخاب کنید");
                this.cmbAnbar.Focus();
                return false;
            }

            return true;
        }
        private void frmMojodiAvalye_Load(object sender, EventArgs e)
        {
            string d1 = frmLogin.Year + "/01/01";
            string d2 = frmLogin.Year + "/12/30";

            this.view_MatterTA.Fill(this.db_DataSetResid.View_Matter);
            this.view_AnbarTA.Fill(this.db_DataSetResid.View_Anbar);
            this.tbl_ResidTA.FillByMojodi(this.db_DataSetResid.Tbl_Resid, d1, d2);

        }

        private void toolStripAdd_Click(object sender, EventArgs e)
        {
            Cdresid.Text = tbl_ResidTA.MaxID().ToString();
            CdCode.Text = (1).ToString();
            txtDate.Text = function.PerDate(DateTime.Now);
        }

        private void ubtnComite_Click(object sender, EventArgs e)
        {

            if (NotError())
            {
                DataRowView current = (DataRowView)tbl_ResidBS.Current;
                current["Kharid"] = 0;
                this.Validate();
                this.tbl_ResidBS.EndEdit();
                this.tbl_ResidTA.Update(this.db_DataSetResid.Tbl_Resid);
                //  function.FocusCellGrid(UGrid, "Code_matter");
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            DataRowView current = (DataRowView)tbl_ResidBS.Current;
            current["Kharid"] = 0;
            //  UGrid.Rows[UGrid.ActiveRow.Index].Update();
            UGrid.UpdateData();
            this.Validate();
            this.tbl_ResidBS.EndEdit();
            this.tbl_ResidTA.Update(this.db_DataSetResid.Tbl_Resid);

            this.TblResidRizTblResidBS.EndEdit();
            this.tbl_ResidRizTA.Update(this.db_DataSetResid.Tbl_ResidRiz);
            if (function.MsgBox("عملیات با موفقیت انجام شد آیا قصد ادامه عملیات را دارید", "توجه", MessageBoxIcon.Question) != DialogResult.OK)
            {
                Close();
            }
        }

        private void UGrid_CellDataError(object sender, Infragistics.Win.UltraWinGrid.CellDataErrorEventArgs e)
        {
            e.RaiseErrorEvent = false;
            function.MBox("مقدار وارد شده مجاز نیست", "هشدار", MessageBoxIcon.Error);
        }

        private void UGrid_BeforeRowsDeleted(object sender, Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs e)
        {
            e.DisplayPromptMsg = false;
            if (function.MsgBox("آیا میخواهید سطر جاری حذف شود؟", "توجه", MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void Cdresid_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.tbl_ResidRizTA.FillByCode(this.db_DataSetResid.Tbl_ResidRiz, int.Parse(Cdresid.Text));
            }
            catch
            {

            }
        }

        private void UGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }

        }



        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            //UGrid.PrintPreview();
            Report rp = new Report();
            rp.RegisterData((DataTable)this.db_DataSetResid.Tbl_ResidRiz, "Tbl_ResidRiz");
            rp.RegisterData((DataTable)this.db_DataSetResid.View_Matter, "View_Matter");

            rp.Load(Application.StartupPath + @"\Report\rptMojoodiAvalye.frx");

            rp.SetParameterValue("PDate", txtDate.Text);
            rp.Show(this.MdiParent);
            Application.OpenForms["PreviewForm"].Activate();
        }

        private void UGrid_InitializePrintPreview(object sender, Infragistics.Win.UltraWinGrid.CancelablePrintPreviewEventArgs e)
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
            e.DefaultLogicalPageLayoutInfo.PageHeader = "موجودی اولیه";
            e.DefaultLogicalPageLayoutInfo.PageHeaderHeight = 70;
            e.DefaultLogicalPageLayoutInfo.PageHeaderAppearance.FontData.SizeInPoints = 20;
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

            e.PrintDocument.DocumentName = "کاردکس کالا";
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
            e.PrintLayout.Appearance.FontData.SizeInPoints = 12;
            /* for (int i = 0; i < cl.Count; i++)
             {

                 if (cl[i].Hidden == true)
                 {
                     e.PrintLayout.Bands[0].Columns[i].Hidden = true;
                 }
             }*/


            utPreviewDialog.Document = e.PrintDocument;

            utPreviewDialog.PreviewSettings.Zoom = 1;

            utPreviewDialog.StartPosition = FormStartPosition.CenterScreen;
            utPreviewDialog.WindowState = FormWindowState.Maximized;
            utPreviewDialog.ShowDialog(this);

            e.Cancel = true;
        }

        private void frmMojodiAvalye_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.Control && e.KeyCode == Keys.S)
            {
                saveToolStripButton_Click(sender, e);
            }
        }

        private void UGrid_InitializeLayout(object sender, InitializeLayoutEventArgs e)
        {

        }
    }
}
