using FastReport;
using System;
using System.Data;
using System.Windows.Forms;

namespace DamProducer
{
    public partial class frmRptFrooshKol : Form
    {
        public frmRptFrooshKol()
        {
            InitializeComponent();
        }

        private void ultraButton1_Click(object sender, EventArgs e)
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
            string p = string.Empty;
            Report rep = new Report();
            DataTable dt = new DataTable();
            dt = function.UGridSelectToDTable(UGrid.DisplayLayout);
            if (dt.Rows.Count == 0)
            {
                dt = function.UGridAllToDTable(UGrid.DisplayLayout);
            }

            if (dt.Rows.Count > 0)
            {
                p = p + "از تاریخ: " + d1 + " تا تاریخ : " + d2;
                rep.RegisterData(dt, "View_KolFroosh");
                rep.Load(Application.StartupPath + @"\Report\RptKolFroosh.frx");
                rep.SetParameterValue("Parm1", p);
                rep.Show(this.MdiParent);
            }
            else
            {
                function.MBox("اطلاعاتی برای چاپ وجود ندارد", "هشدار", MessageBoxIcon.Information);
            }

        }

        private void frmRptFrooshKol_Load(object sender, EventArgs e)
        {


            try
            {
                string d1 = frmLogin.Year + "/01/01";
                string d2 = frmLogin.Year + "/12/30";
                this.view_KolFrooshTA.FillByFroosh(this.db_DataSetDarkhast.View_KolFroosh, d1, d2);
            }
            catch { }
        }

        private void btnSearch_Click(object sender, EventArgs e)
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
            this.view_KolFrooshTA.FillByFroosh(this.db_DataSetDarkhast.View_KolFroosh, d1, d2);


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
