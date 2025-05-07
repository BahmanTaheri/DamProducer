using FastReport;
using System;
using System.Data;
using System.Windows.Forms;

namespace DamProducer
{
    public partial class frmRptFaktor : Form
    {
        public frmRptFaktor()
        {
            InitializeComponent();
        }

        private void frmRptFaktor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_DataSetDarkhast.View_Faktor' table. You can move, or remove it, as needed.
            this.view_FaktorTA.Fill(this.db_DataSetDarkhast.View_Faktor);
            this.view_KharidarTA.Fill(this.db_DataSetDarkhast.View_Kharidar);

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

            try
            {
                if (cmbKharidar.Value == null)
                {
                    this.view_FaktorTA.FillByD(this.db_DataSetDarkhast.View_Faktor, d1, d2);
                }
                else
                {
                    this.view_FaktorTA.FillByKharidar(this.db_DataSetDarkhast.View_Faktor, d1, d2, (int)cmbKharidar.Value);
                }

            }
            catch { }
        }

        private void ultraButton1_Click(object sender, EventArgs e)
        {
            Report rp = new Report();
            DataTable dt = new DataTable();
            dt = function.UGridAllToDTable(UGrid.DisplayLayout);
            rp.RegisterData(dt, "View_Faktor");
            // rp.RegisterData(this.db_DataSetDarkhast, "db_DataSetDarkhast");
            rp.Load(Application.StartupPath + @"\Report\rptFrooshFaktor.frx");

            rp.SetParameterValue("D1", txtDate1.Text);
            rp.SetParameterValue("D2", txtDate2.Text);
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
    }
}
