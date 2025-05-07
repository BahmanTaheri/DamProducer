using System;
using System.Data;
using System.Windows.Forms;

namespace DamProducer
{
    public partial class frmCntMatter : Form
    {
        public frmCntMatter()
        {
            InitializeComponent();
        }

        private void frmCntMatter_Load(object sender, EventArgs e)
        {
            this.tbl_MatterTaA.Fill(this.db_DSGTP.Tbl_Matter);
            this.tbl_RizTA.Fill(this.db_DSContent.Tbl_Riz);
            this.tbl_KolMavadTA.FillByMatter(this.db_DSContent.Tbl_KolMavad);

            function.FocusCellGrid(UGrid, "Code_matter");

        }



        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                UGrid.Rows[UGrid.ActiveRow.Index].Update();
            }
            catch { }

            for (int i = 0; i < UGrid.Rows.Count; i++)
            {
                if ((string.IsNullOrEmpty(UGrid.Rows[i].Cells["Code_matter"].Text)) || (UGrid.Rows[i].Cells["Code_matter"].Text == "0"))
                {
                    UGrid.Rows[i].Delete(false);
                }
            }
            UGrid.Update();


            foreach (Infragistics.Win.UltraWinGrid.UltraGridRow GRow in UGrid.Rows)
            {

                tblKolMavadBS.Position = GRow.Index;
                DataRowView current = (DataRowView)tblKolMavadBS.Current;
                current["Jam"] = Convert.ToDecimal(current["Hazine_other"]) * 1000;
                this.Validate();
                this.tblKolMavadBS.EndEdit();
                this.tbl_KolMavadTA.Update(this.db_DSContent.Tbl_KolMavad);

                if (tblKolMavadTblRizBS.List.Count == 0)
                {
                    this.tblKolMavadTblRizBS.AddNew();
                }
                UGridRiz.Rows[0].Cells["Price_vahed"].Value = current["Hazine_other"];
                UGridRiz.Rows[0].Cells["Code_matter"].Value = current["Code_matter"];
                UGridRiz.Rows[0].Cells["Meghdar"].Value = 1000;
                UGridRiz.Rows[0].Update();
            }


            this.tblKolMavadTblRizBS.EndEdit();
            this.tbl_RizTA.Update(this.db_DSContent.Tbl_Riz);
            if (function.MsgBox("عملیات با موفقیت انجام شد آیا قصد ادامه عملیات را دارید", "توجه", MessageBoxIcon.Question) != DialogResult.OK)
            {
                Close();
            }

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
    }
}
