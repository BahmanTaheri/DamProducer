using System;
using System.Data;
using System.Windows.Forms;

namespace DamProducer
{
    public partial class frmListPishFk : Form
    {
        public int codefro = 0;
        public frmListPishFk()
        {
            InitializeComponent();
        }

        private void frmListDarkhast_Load(object sender, EventArgs e)
        {

            this.view_KolMavadTA.Fill(this.db_DataSetDarkhast.View_KolMavad);

            //            if (codefro != 0)
            //         {
            this.tbl_PishFaktorTA.FillByNotChk(this.db_DataSetDarkhast.Tbl_PishFaktor);
            //       }
            //     codefro = 0;


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (Infragistics.Win.UltraWinGrid.UltraGridRow GRow in UGrid.Rows)
            {
                bool x = Convert.ToBoolean(GRow.GetCellValue("CheckedSF").ToString());
                if (x)
                {
                    GRow.Cells["CodeFaktor"].Value = tbl_PishFaktorTA.MaxPishFaktor();
                }
                GRow.Update();
            }
            this.Validate();
            this.tblPishFaktorBS.EndEdit();
            this.tbl_PishFaktorTA.Update(db_DataSetDarkhast.Tbl_PishFaktor);
            function.MBox("ثبت نهایی انجام شد", "توجه", MessageBoxIcon.Information);
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmListDarkhast_Leave(object sender, EventArgs e)
        {

        }

        private void frmListDarkhast_FormClosing(object sender, FormClosingEventArgs e)
        {
            int x = 0;
            try
            {
                DataRowView current = (DataRowView)tblPishFaktorBS.Current;
                x = (int)current["CodeFaktor"];
            }
            catch
            {
                x = 0;
            }
            codefro = x;
        }
    }
}
