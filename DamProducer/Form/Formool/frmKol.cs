using System;
using System.Windows.Forms;

namespace DamProducer
{
    public partial class frmKol : Form
    {
        public frmKol()
        {
            InitializeComponent();
        }

        private void frmKol_Load(object sender, EventArgs e)
        {
            this.tbl_ProductTA.Fill(this.db_DataSetGTP.Tbl_Product);
            this.tbl_GroupTA.Fill(this.db_DataSetGTP.Tbl_Group);
            this.tbl_KolMavadTA.FillByProduct(this.db_DataSetContent.Tbl_KolMavad);
        }

        private void UGridPers_DoubleClickRow(object sender, Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs e)
        {
            frmFContent frm = new frmFContent();
            frm.FrmType = frmFContent.FType.General;
            frm.fcode = (int)e.Row.Cells[0].Value;
            frm.ShowDialog();
            frm.Dispose();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtDate1.Text != "13__/__/__") && (txtDate2.Text != "13__/__/__"))
                {
                    this.tbl_KolMavadTA.FillByDate(this.db_DataSetContent.Tbl_KolMavad, txtDate1.Text, txtDate2.Text);
                }
            }
            catch { }
        }
    }
}
