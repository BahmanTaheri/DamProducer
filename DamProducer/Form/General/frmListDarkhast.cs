using System;
using System.Data;
using System.Windows.Forms;

namespace DamProducer
{
    public partial class frmListDarkhast : Form
    {
        public int codefro = 0;
        public frmListDarkhast()
        {
            InitializeComponent();
        }

        private void frmListDarkhast_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_DataSetDarkhast.View_KolMavad' table. You can move, or remove it, as needed.
            this.view_KolMavadTA.Fill(this.db_DataSetDarkhast.View_KolMavad);

            if (codefro != 0)
            {
                this.tbl_DarkhastTA.FillByCodeNotChk(this.db_DataSetDarkhast.Tbl_Darkhast, codefro);
            }
            codefro = 0;
            // TODO: This line of code loads data into the 'db_DataSetDarkhast.Tbl_Darkhast' table. You can move, or remove it, as needed.
            //  this.tbl_DarkhastTableAdapter.Fill(this.db_DataSetDarkhast.Tbl_Darkhast);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (Infragistics.Win.UltraWinGrid.UltraGridRow GRow in UGrid.Rows)
            {
                bool x = Convert.ToBoolean(GRow.GetCellValue("CheckedSF").ToString());
                if (x)
                {
                    GRow.Cells["CodeFaktor"].Value = tbl_DarkhastTA.MaxIDFaktor();
                }
                GRow.Update();
            }
            this.Validate();
            this.tblDarkhastBS.EndEdit();
            this.tbl_DarkhastTA.Update(db_DataSetDarkhast.Tbl_Darkhast);
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
                DataRowView current = (DataRowView)tblDarkhastBS.Current;
                x = (int)current["CodeFaktor"];
            }
            catch
            {
                x = 0;
            }
            codefro = x;
        }

        private void UGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyData == Keys.Space) && (UGrid.ActiveRow.Index >= 0))
            {
                UGrid.Rows[UGrid.ActiveRow.Index].Cells["CheckedSF"].Value = !((bool)UGrid.Rows[UGrid.ActiveRow.Index].Cells["CheckedSF"].Value);
            }
        }
    }
}
