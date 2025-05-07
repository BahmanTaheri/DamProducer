using FastReport;
using System;
using System.Data;
using System.Windows.Forms;

namespace DamProducer
{
    public partial class frmRptKharidar : Form
    {
        public frmRptKharidar()
        {
            InitializeComponent();
        }

        private void ultraButton1_Click(object sender, EventArgs e)
        {
            Report rep = new Report();
            DataTable dt = new DataTable();
            dt = function.UGridAllToDTable(UGrid.DisplayLayout);
            rep.Load(Application.StartupPath + @"\Report\rptFrooshKharidar.frx");
            rep.RegisterData(dt, "View_Darkhast");
            rep.SetParameterValue("D1", txtDate1.Text);
            rep.SetParameterValue("D2", txtDate2.Text);
            rep.SetParameterValue("Name", cmbProduct.Text);
            rep.Show(this.MdiParent);
            Application.OpenForms["PreviewForm"].Activate();
        }

        private void frmRptKharidar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_DataSetDarkhast.View_KolMavad' table. You can move, or remove it, as needed.
            this.view_KolMavadTA.FillByen(this.db_DataSetDarkhast.View_KolMavad);
            int t1 = 1;
            int t2 = 5;

            try
            {
                string d1 = frmLogin.Year + "/01/01"; ;
                string d2 = frmLogin.Year + "/12/30"; ;
                this.view_DarkhastTA.FillByDate(this.db_DataSetDarkhast.View_Darkhast, d1, d2, t1, t2, string.Empty, string.Empty, string.Empty, string.Empty);
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

            if (cmbProduct.Value == null)
            {
                err.SetError(cmbProduct, "نام خریدار را وارد کنید");
                return;
            }
            else
            {
                err.Clear();
                try
                {
                    this.view_DarkhastTA.FillByDateCodePrd(this.db_DataSetDarkhast.View_Darkhast, d1, d2, cmbProduct.Text);
                }
                catch { }
            }
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
