using FastReport;
using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace DamProducer
{
    public partial class frmRptKharid : Form
    {
        public frmRptKharid()
        {
            InitializeComponent();
        }

        private void frmRptKharid_Load(object sender, EventArgs e)
        {
            NumberFormatInfo nf = new NumberFormatInfo();
            nf.NumberDecimalSeparator = ".";
            this.UGrid.DisplayLayout.Bands[0].Columns["vaznResid"].FormatInfo = nf;
            this.UGrid.DisplayLayout.Bands[0].Columns["vaznKhales"].FormatInfo = nf;
            //System.Globalization.CultureInfo.CreateSpecificCulture("ir");
            this.tbl_NoeResidTA.Fill(this.DataSetResid.Tbl_NoeResid);

            try
            {
                this.view_PersonTA.Fill(this.DataSetResid.View_Person);
                this.view_MatterTA.Fill(this.DataSetResid.View_Matter);
                // this.view_RptResidTableAdapter.Fill(this.db_DataSetResid.View_RptResid);
            }
            catch { }



        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string d1 = frmLogin.Year + "/01/01";
            string d2 = frmLogin.Year + "/12/30";
            int t1 = 0;
            int t2 = 5;
            int p1 = 0;
            int p2 = 1000000;
            int m1 = 0;
            int m2 = 1000000;

            if (function.AccDateInput(txtDate1.Text))
            {
                d1 = txtDate1.Text;
            }
            if (function.AccDateInput(txtDate2.Text))
            {
                d2 = txtDate2.Text;
            }
            if (cmbNoe.Value != null)
            {
                t1 = (int)cmbNoe.Value;
                t2 = (int)cmbNoe.Value;
            }
            if (cmbPrs.Value != null)
            {
                p1 = (int)cmbPrs.Value;
                p2 = p1;
            }

            if (CmbMater.Value != null)
            {
                m1 = (int)CmbMater.Value;
                m2 = m1;
            }

            try
            {
                this.view_RptResidTA.FillByMatterPerson(this.DataSetResid.View_RptResid, d1, d2, m1, m2, p1, p2, t1, t2);
            }

            catch { }
            /*
            try
            {
                if (radioPRS.Checked)
                {
                    if (cmbPrs.Value == null)
                    {
                        this.view_RptResidTA.FillByDate(this.DataSetResid.View_RptResid, d1, d2, t1, t2);
                    }
                    else
                    {
                        this.view_RptResidTA.FillByShakhsDate(this.DataSetResid.View_RptResid, (int)cmbPrs.Value, d1, d2, t1, t2);
                    }
                }
                else
                {
                    if (CmbMater.Value == null)
                    {
                        this.view_RptResidTA.FillByDate(this.DataSetResid.View_RptResid, d1, d2, t1, t2);
                    }
                    else
                    {
                        this.view_RptResidTA.FillByMtDate(this.DataSetResid.View_RptResid, d1, d2, (int)CmbMater.Value, t1, t2);
                    }
                }
            }
            catch { }
            */
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Report rep = new Report();
            DataTable dt = new DataTable();
            dt = function.UGridAllToDTable(UGrid.DisplayLayout);
            rep.Load(Application.StartupPath + @"\Report\rptKharid.frx");
            rep.RegisterData(dt, "View_RptResid");
            // rep.RegisterData((DataTable)DataSetResid.View_RptResid, "View_RptResid");
            rep.SetParameterValue("D1", txtDate1.Text);
            rep.SetParameterValue("D2", txtDate2.Text);
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

        private void btnPrintResid_Click(object sender, EventArgs e)
        {
            string where = "Code_resid=-1";
            Report rep = new Report();
            UGrid.UpdateData();
            DataTable dt = new DataTable();
            DataTable dtRiz = new DataTable();
            dt = function.UGridSelectToDTable(UGrid.DisplayLayout);
            foreach (DataRow row in dt.Rows)
            {
                where += " or Code_resid=" + row["code_resid"].ToString();
            }
            dt = function.SelectResid("View_Resid WHERE " + where);
            dtRiz = function.SelectResid("View_ResidrRiz WHERE " + where);

            if (dt.Rows.Count > 0)
            {
                rep.RegisterData(dt, "View_Resid");
                rep.RegisterData(dtRiz, "View_ResidrRiz");
                rep.Load(Application.StartupPath + @"\Report\rptResidAll.frx");
                rep.Show(this.MdiParent);
            }
        }

        private void CmbPRS_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
