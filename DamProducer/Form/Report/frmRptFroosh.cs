using FastReport;
using System;
using System.Data;
using System.Windows.Forms;

namespace DamProducer
{
    public partial class frmRptFroosh : Form
    {
        public frmRptFroosh()
        {
            InitializeComponent();
        }

        private void frmRptFroosh_Load(object sender, EventArgs e)
        {
            try
            {
                this.tbl_PrsAmelTA.Fill(this.db_DsDarkhast.Tbl_PrsAmel);
                this.view_KharidarTA.Fill(this.db_DsDarkhast.View_Kharidar);
                this.view_CityTA.Fill(this.db_DsDarkhast.View_City);
                
            }   catch { }
            try 
            {
                this.tbl_DaftarTA.Fill(this.db_DsDarkhast.Tbl_Daftar);
                this.tbl_PayTA.Fill(this.db_DsDarkhast.Tbl_Pay);
            } catch { }
           
            try
            {
                int t1 = 1;
                int t2 = 5;
                string d1 = frmLogin.Year + "/01/01"; ;
                string d2 = frmLogin.Year + "/12/30"; ;
                this.view_DarkhastTA.FillByDate(this.db_DsDarkhast.View_Darkhast, d1, d2, t1, t2, string.Empty, string.Empty, string.Empty, string.Empty);
            }
            catch { }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string ct = string.Empty;
            string amel = string.Empty;
            string kharid = string.Empty;
            string thv = string.Empty;
            string d1 = frmLogin.Year + "/01/01";
            string d2 = frmLogin.Year + "/12/30";
            int t1 = 1;
            int t2 = 5;
            int cb = 0;
            if (cmbKharidar.Value != null)
            {
                kharid = cmbKharidar.Text.Trim();
            }

            if (CmbAmel.Value != null)
            {
                amel = CmbAmel.Text.Trim();
            }

            if (CmbTahvil.Value != null)
            {
                thv = CmbTahvil.Text.Trim();
            }
            if (CmbCity.Value != null)
            {
                ct = CmbCity.Text.Trim();
            }
            if (cmbNoe.Value != null)
            {
                t1 = (int)cmbNoe.Value;
                t2 = (int)cmbNoe.Value;
            }
            if (CmbDafater.Value != null)
            {
                cb = (int)CmbDafater.Value;
            }
            if (function.AccDateInput(txtDate1.Text))
            {
                d1 = txtDate1.Text;
            }
            if (function.AccDateInput(txtDate2.Text))
            {
                d2 = txtDate2.Text;
            }
            if (t1 < 6)
                this.view_DarkhastTA.FillByDate(this.db_DsDarkhast.View_Darkhast, d1, d2, t1, t2, ct, thv, kharid, amel);
            else if (t1 == 6)
                this.view_DarkhastTA.FillByDateCode6(this.db_DsDarkhast.View_Darkhast, d1, d2, cb, ct, thv, amel);
            else if (t1 == 7)
                this.view_DarkhastTA.FillByDateCode7(this.db_DsDarkhast.View_Darkhast, d1, d2, cb, ct, thv, amel);
        }

        private void ultraButton1_Click(object sender, EventArgs e)
        {
            Report rp = new Report();
            string p=string.Empty;
            if (cmbNoe.Value != null)
                p += "  نوع فروش : " + cmbNoe.Text;
            if (CmbDafater.Visible == true)
                p += "   عنوان نمایندگی:  " + CmbDafater.Text;
            if (CmbAmel.Value != null)
                p += "    نام عامل:   " + CmbAmel.Text;
            if (CmbCity.Value != null)
                if (CmbCity.Value != null)
                p += "   نام شهر:   " + CmbCity.Text;

            DataTable dt = new DataTable();
            dt = function.UGridAllToDTable(UGrid.DisplayLayout);
            rp.RegisterData(dt, "View_Darkhast");
            //rp.RegisterData((DataTable)this.db_DsDarkhast.View_Darkhast, "View_Darkhast");
            rp.Load(Application.StartupPath + @"\Report\rptFroosh.frx");
            rp.SetParameterValue("D1", txtDate1.Text);
            rp.SetParameterValue("D2", txtDate2.Text);
            rp.SetParameterValue("P", p);
            rp.Show(this.MdiParent);
            Application.OpenForms["PreviewForm"].Activate();
        }

        private void txtDate1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }



        private void cmbNoe_ValueChanged(object sender, EventArgs e)
        {
            if (cmbNoe.Value != null)
            {
                if (((int)cmbNoe.Value > 5) && ((int)cmbNoe.Value < 8))
                {
                    CmbDafater.Show();
                    lblDafater.Show();
                }

                else
                {
                    CmbDafater.Hide();
                    lblDafater.Hide();
                }


            }
        }

        private void BtnPrint902_Click(object sender, EventArgs e)
        {
            Report rp = new Report();
            DataTable dt = new DataTable();
            dt = function.UGridAllToDTable(UGrid.DisplayLayout);
            rp.RegisterData(dt, "View_Darkhast");
            rp.Load(Application.StartupPath + @"\Report\rptForm902.frx");
            rp.Show(this.MdiParent);
            try
            {
                Application.OpenForms["PreviewForm"].Activate();
            }
            catch { }

        }

        private void BtnPrint9022_Click(object sender, EventArgs e)
        {
            Report rp = new Report();
            DataTable dt = function.UGridAllToDTable(UGrid.DisplayLayout);
            rp.RegisterData(dt, "View_Darkhast");

            rp.Load(Application.StartupPath + @"\Report\rptForm9022.frx");
            rp.SetParameterValue("Param1", CmbCity.Text);
            rp.Show(this.MdiParent);
            try
            {
                Application.OpenForms["PreviewForm"].Activate();
            }
            catch { }
        }
    }
}
