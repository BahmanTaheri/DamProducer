using FastReport;
using System;
using System.Data;
using System.Windows.Forms;

namespace DamProducer
{
    public partial class frmMojoodiAvalKise : Form
    {
        public frmMojoodiAvalKise()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblBagResidBindingSource.EndEdit();
            this.tbl_BagResidTA.Update(this.db_DataSetGTP.Tbl_BagResid);
            function.MBox("ذخیره شد", "توجه", MessageBoxIcon.Information);
        }

        private void frmMojoodiAvalKise_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_DataSetGTP1.Tbl_Bag' table. You can move, or remove it, as needed.

            string d1 = frmLogin.Year + "/01/01";
            string d2 = frmLogin.Year + "/12/30";
            this.tbl_BagResidTA.FillByMojoodi(db_DataSetGTP.Tbl_BagResid, d1, d2);
            this.tbl_BagTA.Fill(this.db_DataSetGTP.Tbl_Bag);
            db_DataSetGTP.Tbl_BagResid.MojoodiAvalyeColumn.DefaultValue = 1;
            db_DataSetGTP.Tbl_BagResid.CommentColumn.DefaultValue = "موجودی اول دوره";
            db_DataSetGTP.Tbl_BagResid.DateColumn.DefaultValue = function.PerDate(DateTime.Now);
        }

        private void PrintToolStripButton_Click(object sender, EventArgs e)
        {
            Report rp = new Report();
            rp.RegisterData((DataTable)this.db_DataSetGTP.Tbl_Bag, "Tbl_Bag");
            rp.RegisterData((DataTable)this.db_DataSetGTP.Tbl_BagResid, "Tbl_BagResid");
            rp.Load(Application.StartupPath + @"\Report\rptMojoodiAvalyeKise.frx");
            rp.Show(this.MdiParent);
            Application.OpenForms["PreviewForm"].Activate();
        }

        private void UGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }
    }
}
