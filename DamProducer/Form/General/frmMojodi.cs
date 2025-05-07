using FastReport;
using System;
using System.Data;
using System.Windows.Forms;

namespace DamProducer
{
    public partial class frmMojodi : Form
    {
        public enum CallModeEnum
        {
            ByYear = 1,
            ByDate = 2,
        }

        public CallModeEnum CMode;
        public frmMojodi()
        {
            InitializeComponent();
        }

        private void frmMojodi_Load(object sender, EventArgs e)
        {
            if (CMode == CallModeEnum.ByYear)
            {
                this.view_MojoodiTA.FillByYEAR(this.db_DataSetContent.View_Mojoodi, frmLogin.Year);
                ultraLabel1.Hide();
                ultraLabel2.Hide();
                txtDate1.Hide();
                txtDate2.Hide();
                commit.Hide();
                UGrid.Top = 10;
                UGrid.Height = UGrid.Height;
                UGrid.DisplayLayout.Bands[0].Columns["select"].Hidden = true;
            }
            else
            {

                btnReload.Hide();
            }

        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Report rpt = new Report();
            string dx = string.Empty;
            rpt.Load(Application.StartupPath + @"\report\rptMojoodi.frx");
            if (CMode == CallModeEnum.ByYear)
            {
                dx = function.PerDate(DateTime.Now);
                rpt.RegisterData((DataTable)db_DataSetContent.View_Mojoodi, "View_Mojoodi");
            }
            else
            {
                dx = txtDate1.Text + " تا " + txtDate2.Text;
                dt = function.UGridSelectToDTable(UGrid.DisplayLayout);
                if (dt.Rows.Count == 0)
                {
                    dt = function.UGridAllToDTable(UGrid.DisplayLayout);
                }
                rpt.RegisterData(dt, "View_Mojoodi");
            }
            rpt.SetParameterValue("PDate", dx);
            rpt.Show(this.MdiParent);
            Application.OpenForms["PreviewForm"].Activate();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            frmMojodi_Load(sender, e);
        }


        private void commit_Click(object sender, EventArgs e)
        {
            string d1 = frmLogin.Year + "/01/01"; ;
            string d2 = frmLogin.Year + "/12/30"; ;

            if (function.AccDateInput(txtDate1.Text))
            {
                d1 = txtDate1.Text;
            }
            if (function.AccDateInput(txtDate2.Text))
            {
                d2 = txtDate2.Text;
            }
            this.view_MojoodiTA.FillByDate(this.db_DataSetContent.View_Mojoodi, d1, d2);
        }

        private void txtDate1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void btnPrintExport_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Report rpt = new Report();
            string dx = string.Empty;
            rpt.Load(Application.StartupPath + @"\report\rptExport.frx");
            if (CMode == CallModeEnum.ByYear)
            {
                dx = function.PerDate(DateTime.Now);
                rpt.RegisterData((DataTable)db_DataSetContent.View_Mojoodi, "View_Mojoodi");
            }
            else
            {
                dx = txtDate1.Text + " تا " + txtDate2.Text;
                dt = function.UGridSelectToDTable(UGrid.DisplayLayout);
                if (dt.Rows.Count == 0)
                {
                    dt = function.UGridAllToDTable(UGrid.DisplayLayout);
                }
                rpt.RegisterData(dt, "View_Mojoodi");
            }
            rpt.SetParameterValue("PDate", dx);
            rpt.Show(this.MdiParent);
            Application.OpenForms["PreviewForm"].Activate();
        }
    }
}
