using FastReport;
using System;
using System.Data;
using System.Windows.Forms;

namespace DamProducer
{
    public partial class frmDafaterMojoodi : Form
    {
        public frmDafaterMojoodi()
        {
            InitializeComponent();
        }

        private void frmDafaterMojoodi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_DataSetDarkhast.Tbl_Daftar' table. You can move, or remove it, as needed.
            this.tbl_DaftarTA.Fill(this.db_DataSetDarkhast.Tbl_Daftar);
        }

        private void commit_Click(object sender, EventArgs e)
        {
            string d1 = frmLogin.Year + "/01/01"; ;
            string d2 = frmLogin.Year + "/12/30"; ;

            if (function.AccDateInput(txtDate1.Text))
                d1 = txtDate1.Text;
            if (function.AccDateInput(txtDate2.Text))
                d2 = txtDate2.Text;
            if (CmbDafater.Value == null)
            {
                CmbDafater.Focus();
                err.SetError(CmbDafater, "انتخاب دفتر فروش الزامیست");
                return;
            }
            view_MojoodiDafaterTA.FillByDaftarDate(db_DataSetContent.View_MojoodiDafater, d1, d2, (int)CmbDafater.Value);
        }

        private void CmbDafater_KeyDown(object sender, KeyEventArgs e)
        {
            function.NextControl(sender, ref e);
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Report rpt = new Report();
            string dx = string.Empty;
            rpt.Load(Application.StartupPath + @"\report\rptMojoodiDafater.frx");
            dx = "عنوان دفتر:  " + CmbDafater.Text + "                  از تاریخ   " + txtDate1.Text + "   تا   " + txtDate2.Text;
            dt = function.UGridAllToDTable(UGrid.DisplayLayout);
            rpt.RegisterData(dt, "View_MojoodiDafater");

            rpt.SetParameterValue("PDate", dx);
            rpt.Show(this.MdiParent);
            Application.OpenForms["PreviewForm"].Activate();
        }
    }
}
