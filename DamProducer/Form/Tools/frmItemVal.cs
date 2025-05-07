using System;
using System.Windows.Forms;

namespace DamProducer
{
    public partial class frmItemVal : Form
    {
        public frmItemVal()
        {
            InitializeComponent();
        }

        private void frmItemVal_Load(object sender, EventArgs e)
        {
            this.tbl_ProductTA.Fill(this.db_DataSetGTP.Tbl_Product);
            this.tbl_ItemTA.Fill(this.db_DataSetGTP.Tbl_Item);
            this.tbl_ItemValTA.Fill(this.db_DataSetGTP.Tbl_ItemVal);



        }

        private void toolStripSave_Click(object sender, EventArgs e)
        {
            UGrid.Rows[UGrid.ActiveRow.Index].Update();
            this.TblItemValTblProductBS.EndEdit();
            this.tbl_ItemValTA.Update(this.db_DataSetGTP.Tbl_ItemVal);

        }

        private void UGrid_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Enter:
                    e.SuppressKeyPress = true;
                    SendKeys.Send("{TAB}");
                    break;
                case Keys.Delete:
                    e.SuppressKeyPress = true;
                    if (function.MsgBox("آیا میخواهید سطر جاری حذف شود؟", "توجه", MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        Infragistics.Win.UltraWinGrid.UltraGrid grd = (Infragistics.Win.UltraWinGrid.UltraGrid)sender;
                        //  grd.DeleteSelectedRows(false);
                        grd.Rows[grd.ActiveRow.Index].Delete(false);
                    }
                    break;
                default:
                    break;
            }
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            view_ItemValsTA.FillByCode(db_DataSetGTP.View_ItemVals, int.Parse(txtCode.Text));
            report1.Load(Application.StartupPath + @"\report\rptItemVal.frx");
            report1.Show(this.MdiParent);
        }
    }
}
