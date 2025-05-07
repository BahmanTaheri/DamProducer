using FastReport;
using System;
using System.Data;
using System.Windows.Forms;

namespace DamProducer
{
    public partial class frmRptChangeCust : Form
    {
        public frmRptChangeCust()
        {
            InitializeComponent();
        }

        private void UbtnReplace_Click(object sender, EventArgs e)
        {

        }

        private void frmRptChangeCust_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_DataSetDarkhast.Tbl_Co' table. You can move, or remove it, as needed.
            this.tbl_CoTA.Fill(this.db_DataSetDarkhast.Tbl_Co);
            // TODO: This line of code loads data into the 'db_DataSetDarkhast.View_RPTRiz' table. You can move, or remove it, as needed.
            this.view_RPTRizTA.Fill(this.db_DataSetDarkhast.View_RPTRiz);

            this.tbl_RPTTA.Fill(this.db_DataSetDarkhast.Tbl_RPT);
            this.tbl_RPTRizTA.Fill(this.db_DataSetDarkhast.Tbl_RPTRiz);
            this.tbl_RPTBS.MoveLast();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_RPTBS.EndEdit();
            this.tbl_RPTTA.Update(this.db_DataSetDarkhast.Tbl_RPT);
            this.TblRPTRizTblRPTBS.EndEdit();
            this.tbl_RPTRizTA.Update(this.db_DataSetDarkhast.Tbl_RPTRiz);
            function.MBox("ذخیره شد", "توجه", MessageBoxIcon.Information);
        }

        private void SearchReplacButton_Click(object sender, EventArgs e)
        {
            frmReplac frm = new frmReplac();
            frm.ShowDialog();
            if (!string.IsNullOrEmpty(frm.sfind))
            {
                foreach (Infragistics.Win.UltraWinGrid.UltraGridRow GRow in UGrid.Rows)
                {
                    if (GRow.Cells["cnt"].Text == frm.sfind)
                    {
                        GRow.Cells["cnt"].Value = frm.sreplace;
                    }
                    GRow.Update();
                }
            }
            frm.Dispose();
        }



        private void txtCode_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.tbl_RPTRizTA.FillByCode(this.db_DataSetDarkhast.Tbl_RPTRiz, int.Parse(txtCode.Text));
            }
            catch
            {
            }
        }

        private void PrintfmStripButton_Click(object sender, EventArgs e)
        {
            Report rpt = new Report();
            DataTable dt = new DataTable();
            string title = "شرح گزارش:  " + txtComment.Text + "          " + " از تاریخ:  " + txtDate1.Text + "   " + " تا تاریخ:  " + txtDate2.Text;
            dt = function.UGridAllToDTable(UGrid.DisplayLayout);
            rpt.RegisterData(dt, "Tbl_RPTRiz");
            rpt.Load(Application.StartupPath + @"\report\rptCustom.frx");
            rpt.SetParameterValue("Param", title);
            rpt.Show();

            /* string x=txtCode.Text;
            this.tbl_RPTTA.FillByCode(this.db_DataSetDarkhast.Tbl_RPT, int.Parse(x));*/
            //-------------------------------------------
            /*   this.tbl_RPTTA.Fill(this.db_DataSetDarkhast.Tbl_RPT);
             int fx=this.tbl_RPTBS.Find("ID_Report",x);
             this.tbl_RPTBS.Position = fx;*/
        }

        private void txtComment_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void UGrid_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Enter:
                    e.SuppressKeyPress = true;
                    SendKeys.Send("{TAB}");
                    break;
                case Keys.Delete:
                    e.SuppressKeyPress = true;
                    if (function.MsgBox("آیا میخواهید سطر جاری حذف شود؟", "توجه", MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        UGrid.DeleteSelectedRows(false);

                    }
                    break;
                default:
                    break;
            }
        }



        /*
        string qr=string.Empty;
        qr = "SELECT dbo.Tbl_RPTRiz.ID, dbo.Tbl_RPTRiz.ID_Report, dbo.Tbl_RPTRiz.Code_Darkhast," +
            " dbo.Tbl_RPTRiz.Date_Khorooj, dbo.Tbl_RPTRiz.name_fro, dbo.Tbl_RPTRiz.cnt, dbo.Tbl_RPTRiz.Pvahed, dbo.Tbl_RPTRiz.VaznBaskool," +
            " dbo.Tbl_RPTRiz.TypeFalyat, dbo.Tbl_RPTRiz.City, dbo.Tbl_RPTRiz.Tel, dbo.Tbl_RPTRiz.CodeMeli, dbo.Tbl_RPTRiz.NumCar," +
            " dbo.Tbl_RPTRiz.NumBaskool, dbo.Tbl_RPTRiz.NoeTarh, dbo.Tbl_RPTRiz.ZarfTarh, dbo.Tbl_RPTRiz.ShenaseYekta," +
            "VMX.a1, VMX.a2, VMX.a3, VMX.a4, VMX.a5, VMX.a6, VMX.a7, VMX.a8, VMX.a9, VMX.a10, VMX.a11, VMX.a12, VMX.other " +
            "FROM     dbo.Tbl_RPTRiz " +
            "LEFT OUTER JOIN    (" +
            " SELECT ID," +
            " ISNULL(MAX(CASE WHEN cnt = '" + c1 + "' THEN VaznBaskool END),0) AS a1," +
            " ISNULL(MAX(CASE WHEN cnt = '" + c1 + "' THEN VaznBaskool END), 0) AS a2," +
            " ISNULL(MAX(CASE WHEN cnt = '" + c1 + "' THEN VaznBaskool END), 0) AS a3," +
            " ISNULL(MAX(CASE WHEN cnt = '" + c1 + "' THEN VaznBaskool END), 0) AS a4," +
            " ISNULL(MAX(CASE WHEN cnt = '" + c1 + "' THEN VaznBaskool END), 0) AS a5," +
            " ISNULL(MAX(CASE WHEN cnt = '" + c1 + "' THEN VaznBaskool END), 0) AS a6," +
            " ISNULL(MAX(CASE WHEN cnt = '" + c1 + "' THEN VaznBaskool END), 0) AS a7," +
            " ISNULL(MAX(CASE WHEN cnt = '" + c1 + "' THEN VaznBaskool END), 0) AS a8," +
            " ISNULL(MAX(CASE WHEN cnt = '" + c1 + "' THEN VaznBaskool END), 0) AS a9, " +
            " ISNULL(MAX(CASE WHEN cnt = '" + c1 + "' THEN VaznBaskool END), 0) AS a10, " +
            " ISNULL(MAX(CASE WHEN cnt = '" + c1 + "' THEN VaznBaskool END), 0) AS a11, " +
            " ISNULL(MAX(CASE WHEN cnt = '" + c1 + "' THEN VaznBaskool END), 0) AS a12, " +
            " ISNULL(MAX(CASE WHEN cnt = '" + c1 + "' THEN VaznBaskool END), 0) AS other " +
            " FROM dbo.Tbl_RPTRiz " +
            " GROUP BY ID) VMX ON dbo.Tbl_RPTRiz.ID = VMX.ID " +
            " WHERE ID_Report = "+id ;
        DataTable dt = new DataTable();
        dt=function.ExecuteWithTable(qr);   */

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Report rpt = new Report();
            string title = "شرح گزارش:  " + txtComment.Text + "          " + " از تاریخ:  " + txtDate1.Text + "   " + " تا تاریخ:  " + txtDate2.Text;
            // dt = function.UGridAllToDTable(UGrid.DisplayLayout);
            DataRowView current = (DataRowView)this.tbl_RPTBS.Current;
            int xid = (int)current["ID_Report"];
            string c1 = current["c1"].ToString();
            string c2 = current["c2"].ToString();
            string c3 = current["c3"].ToString();
            string c4 = current["c4"].ToString();
            string c5 = current["c5"].ToString();
            string c6 = current["c6"].ToString();
            string c7 = current["c7"].ToString();

            this.view_RPTRizTA.FillByIDParam(db_DataSetDarkhast.View_RPTRiz, xid, c1, c2, c3, c4, c5, c6, c7);
            rpt.RegisterData((DataTable)db_DataSetDarkhast.Tbl_Co, "Tbl_Co");
            rpt.RegisterData((DataTable)db_DataSetDarkhast.View_RPTRiz, "View_RPTRiz");

            rpt.Load(Application.StartupPath + @"\report\rptCustom2.frx");

            rpt.SetParameterValue("c1", c1);
            rpt.SetParameterValue("c2", c2);
            rpt.SetParameterValue("c3", c3);
            rpt.SetParameterValue("c4", c4);
            rpt.SetParameterValue("c5", c5);
            rpt.SetParameterValue("c6", c6);
            rpt.SetParameterValue("c7", c7);
            rpt.SetParameterValue("Param", title);
            rpt.Show();
        }
    }
}
