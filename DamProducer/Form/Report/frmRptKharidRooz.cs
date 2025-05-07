using FastReport;
using System;
using System.Data;
using System.Windows.Forms;

namespace DamProducer
{
    public partial class frmRptKharidRooz : Form
    {
        public frmRptKharidRooz()
        {
            InitializeComponent();
        }

        private void frmRptKharid_Load(object sender, EventArgs e)
        {
            int t1 = 0;
            int t2 = 5;
            string d1 = frmLogin.Year + "/01/01";
            string d2 = frmLogin.Year + "/12/30";
            try
            {
                this.tbl_NoeResidTA.Fill(this.db_DataSetResid.Tbl_NoeResid);
                this.view_RptResidTA.FillByDate(this.db_DataSetResid.View_RptResid, d1, d2, t1, t2);
            }
            catch { }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string d1 = frmLogin.Year + "/01/01";
            string d2 = frmLogin.Year + "/12/30";
            int t1 = 0;
            int t2 = 5;
            if (function.AccDateInput(txtDate1.Text))
            {
                d1 = txtDate1.Text;
                d2 = txtDate1.Text;
            }
            try
            {
                if (cmbNoe.Value != null)
                {
                    t1 = (int)cmbNoe.Value;
                    t2 = (int)cmbNoe.Value;
                }
                this.view_RptResidTA.FillByDate(this.db_DataSetResid.View_RptResid, d1, d2, t1, t2);
            }
            catch { }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Report rep = new Report();
            rep.Load(Application.StartupPath + @"\Report\rptKharidRooz.frx");

            DataTable dt = new DataTable();
            dt = function.UGridAllToDTable(UGrid.DisplayLayout);
            rep.RegisterData(dt, "View_RptResid");

            rep.SetParameterValue("D1", txtDate1.Text);
            rep.Show(this.MdiParent);
        }

        private void txtDate1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void cmbNoe_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ultraLabel3_Click(object sender, EventArgs e)
        {

        }
    }
}
