using FastReport;
using System;
using System.Data;
using System.Windows.Forms;

namespace DamProducer
{
    public partial class frmRptFrooshJens : Form
    {
        public frmRptFrooshJens()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string d1 = frmLogin.Year + "/01/01";
            string d2 = frmLogin.Year + "/12/30";

            if (function.AccDateInput(txtDate1.Text))
            {
                d1 = txtDate1.Text;
            }
            if (function.AccDateInput(txtDate2.Text))
            {
                d2 = txtDate2.Text;
            }

            if (cmbKharidar.Value == null)
            {
                err.SetError(cmbKharidar, "نام خریدار را وارد کنید");
                return;
            }
            else
            {
                err.Clear();
                try
                {
                    this.view_DarkhastTA.FillByDateCodeKh(this.db_DataSetDarkhast.View_Darkhast, d1, d2, (int)cmbKharidar.Value, cmbProduct.Text);
                }
                catch { }
            }

        }

        private void ultraButton1_Click(object sender, EventArgs e)
        {
            Report rp = new Report();
            DataTable dt = new DataTable();
            dt = function.UGridAllToDTable(UGrid.DisplayLayout);
            rp.RegisterData(dt, "View_Darkhast");
            //rp.RegisterData((DataTable)this.db_DataSetDarkhast.View_Darkhast, "View_Darkhast");
            rp.Load(Application.StartupPath + @"\Report\rptFrooshJens.frx");
            rp.SetParameterValue("D1", txtDate1.Text);
            rp.SetParameterValue("D2", txtDate2.Text);
            rp.SetParameterValue("Name", cmbKharidar.Text);
            rp.Show(this.MdiParent);
            Application.OpenForms["PreviewForm"].Activate();
        }

        private void frmRptFrooshJens_Load(object sender, EventArgs e)
        {
            string d1 = frmLogin.Year + "/01/01";
            string d2 = frmLogin.Year + "/12/30";
            int t1 = 1;
            int t2 = 5;

            this.view_KharidarTA.Fill(this.db_DataSetDarkhast.View_Kharidar);
            this.view_KolMavadTA.FillByen(this.db_DataSetDarkhast.View_KolMavad);
            try
            {

                this.view_DarkhastTA.FillByDate(this.db_DataSetDarkhast.View_Darkhast, d1, d2, t1, t2, string.Empty, string.Empty, string.Empty, string.Empty);
            }
            catch { }
        }

        private void txtDate1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void UGrid_InitializeLayout(object sender, Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs e)
        {

        }
    }
}
