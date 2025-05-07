using FastReport;
using System;
using System.Data;
using System.Windows.Forms;

namespace DamProducer
{
    public partial class frmRptEtehadieh : Form
    {
        public frmRptEtehadieh()
        {
            InitializeComponent();
        }

        private void frmRptEtehadieh_Load(object sender, EventArgs e)
        {
            string d1 = frmLogin.Year + "/01/01";
            string d2 = frmLogin.Year + "/12/30";

            this.view_KharidarTA.Fill(this.db_DataSetDarkhast.View_Kharidar);
            this.view_KolMavadTA.FillByen(this.db_DataSetDarkhast.View_KolMavad);
            try
            {

                this.view_DarkhastTA.FillByDateCode6(this.db_DataSetDarkhast.View_Darkhast, d1, d2, frmLogin.iEtehadie, string.Empty, string.Empty, string.Empty);
            }
            catch { }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(utxtNumberHavaleh.Text.Trim()))
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
                if (cmbKharidar.Value != null)
                    this.view_DarkhastTA.FillByEtehadie(db_DataSetDarkhast.View_Darkhast, d1, d2, frmLogin.iEtehadie, (int)cmbKharidar.Value, cmbProduct.Text);
                else
                    this.view_DarkhastTA.FillByDateCode6(db_DataSetDarkhast.View_Darkhast, d1, d2, frmLogin.iEtehadie, string.Empty, string.Empty, string.Empty);

            }
            else
            {
                view_DarkhastTA.FillByNHV(db_DataSetDarkhast.View_Darkhast, utxtNumberHavaleh.Text.Trim());
            }

        }

        private void ultraButton1_Click(object sender, EventArgs e)
        {
            Report rp = new Report();
            DataTable dt = new DataTable();
            dt = function.UGridAllToDTable(UGrid.DisplayLayout);
            rp.RegisterData(dt, "View_Darkhast");
            rp.Load(Application.StartupPath + @"\Report\rptFrooshEtehadie.frx");
            rp.SetParameterValue("D1", txtDate1.Text);
            rp.SetParameterValue("D2", txtDate2.Text);
            rp.SetParameterValue("Name", cmbKharidar.Text);
            rp.Show(this.MdiParent);
            Application.OpenForms["PreviewForm"].Activate();
        }

        private void txtDate1_KeyDown(object sender, KeyEventArgs e)
        {
            function.NextControl(sender, ref e);
        }

        private void ultraButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
