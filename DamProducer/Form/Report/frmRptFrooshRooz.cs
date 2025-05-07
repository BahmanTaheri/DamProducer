using FastReport;
using System;
using System.Data;
using System.Windows.Forms;

namespace DamProducer
{
    public partial class frmRptFrooshRooz : Form
    {
        public frmRptFrooshRooz()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string d1 = frmLogin.Year + "/01/01";
            string d2 = frmLogin.Year + "/12/30";
            int t1 = 1;
            int t2 = 5;
            if (cmbNoe.Value != null)
            {
                t1 = (int)cmbNoe.Value;
                t2 = (int)cmbNoe.Value;
            }
            if (function.AccDateInput(txtDate1.Text))
            {
                d1 = txtDate1.Text;
                d2 = txtDate1.Text;
            }

            try
            {
                this.view_DarkhastTA.FillByDate(this.db_DataSetDarkhast.View_Darkhast, d1, d2, t1, t2, string.Empty, string.Empty, string.Empty, string.Empty);
            }
            catch { }
        }

        private void ultraButton1_Click(object sender, EventArgs e)
        {
            Report rp = new Report();
            DataTable dt = new DataTable();
            dt = function.UGridAllToDTable(UGrid.DisplayLayout);
            rp.RegisterData(dt, "View_Darkhast");

            rp.Load(Application.StartupPath + @"\Report\rptFrooshRooz.frx");
            rp.SetParameterValue("D1", txtDate1.Text);
            rp.Show(this.MdiParent);
            Application.OpenForms["PreviewForm"].Activate();
        }

        private void frmRptFrooshRooz_Load(object sender, EventArgs e)
        {
            int t1 = 1;
            int t2 = 5;
            string d1 = frmLogin.Year + "/01/01";
            string d2 = frmLogin.Year + "/12/30";
            this.tbl_PayTA.Fill(this.db_DataSetDarkhast.Tbl_Pay);
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
                e.SuppressKeyPress = true;
                SendKeys.Send("{TAB}");
            }
        }
    }
}
