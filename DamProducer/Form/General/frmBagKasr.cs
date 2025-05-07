using FastReport;
using System;
using System.Data;
using System.Windows.Forms;

namespace DamProducer
{
    public partial class frmBagKasr : Form
    {
        public frmBagKasr()
        {
            InitializeComponent();
        }



        private void toolStripSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblBagResidBS.EndEdit();
            this.tbl_BagResidTA.Update(this.db_DataSetGTP.Tbl_BagResid);
            function.MBox("ذخیره شد", "توجه", MessageBoxIcon.Information);
        }

        private void frmBagKasr_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_DataSetGTP.Tbl_Bag' table. You can move, or remove it, as needed.

            this.tbl_BagTA.Fill(this.db_DataSetGTP.Tbl_Bag);
            // TODO: This line of code loads data into the 'db_DataSetGTP.Tbl_BagResid' table. You can move, or remove it, as needed.
            string d1 = frmLogin.Year + "/00/00";
            string d2 = frmLogin.Year + "/99/99";
            this.tbl_BagResidTA.FillByKasr(this.db_DataSetGTP.Tbl_BagResid, d1, d2);
        }

        private void CdResid_KeyDown(object sender, KeyEventArgs e)
        {
            function.NextControl(sender, ref e);
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            string d1 = frmLogin.Year + "/00/00";
            string d2 = frmLogin.Year + "/99/99";
            this.tbl_BagResidTA.FillByKasr(this.db_DataSetGTP.Tbl_BagResid, d1, d2);
            Report rep = new Report();
            rep.Load(Application.StartupPath + @"\Report\rptBagKasr.frx");
            rep.RegisterData((DataTable)this.db_DataSetGTP.Tbl_BagResid, "Tbl_BagResid");
            rep.Show(this.MdiParent);
        }
    }
}
