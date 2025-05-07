using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DamProducer
{
    public partial class frmDarkhast : Form
    {
        public frmDarkhast()
        {
            InitializeComponent();
        }

        private void frmDarkhast_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'db_DataSetContent.View_Matter' table. You can move, or remove it, as needed.
            this.view_MatterTableAdapter.Fill(this.db_DataSetContent.View_Matter);
            // TODO: This line of code loads data into the 'db_DataSetDarkhast.Tbl_DarkhastRiz' table. You can move, or remove it, as needed.
            this.tbl_DarkhastRizTableAdapter.Fill(this.db_DataSetDarkhast.Tbl_DarkhastRiz);
            // TODO: This line of code loads data into the 'db_DataSetDarkhast.View_Kharidar' table. You can move, or remove it, as needed.
            this.view_KharidarTableAdapter.Fill(this.db_DataSetDarkhast.View_Kharidar);
            // TODO: This line of code loads data into the 'db_DataSetDarkhast.Tbl_Darkhast' table. You can move, or remove it, as needed.
            this.tbl_DarkhastTableAdapter.Fill(this.db_DataSetDarkhast.Tbl_Darkhast);
            // TODO: This line of code loads data into the 'db_DataSetDarkhast.View_KolMavad' table. You can move, or remove it, as needed.
            this.view_KolMavadTableAdapter.Fill(this.db_DataSetDarkhast.View_KolMavad);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            txtCode.Text = tbl_DarkhastTableAdapter.MaxIdDarkhast().ToString();
        }

        private void ubtnComite_Click(object sender, EventArgs e)
        {
           // if (cmbType.Value()==0) 
         //   {

               tblDarkhastBindingSource.EndEdit();
               tbl_DarkhastTableAdapter.Update(db_DataSetDarkhast.Tbl_Darkhast);

                UGrid.Selected.Rows.AddRange((Infragistics.Win.UltraWinGrid.UltraGridRow[])UGrid.Rows.All);
                UGrid.DeleteSelectedRows(false);
                tbl_RizTableAdapter.FillByCode(db_DataSetContent.Tbl_Riz, int.Parse(cmbProduct.Value.ToString()));
                int i = 0;
                foreach ( DataRow DRow  in db_DataSetContent.Tbl_Riz.Rows )
                {   
                    UGrid.DisplayLayout.Bands[0].AddNew();
                    UGrid.Rows[i].Cells["Code_matter"].Value = DRow["Code_matter"].ToString();
                    UGrid.Rows[i].Cells["meghdar"].Value = DRow["meghdar"].ToString();
                    UGrid.Rows[i].Update(); i++;
                }

         //   }

        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            TblDarkhastRizTblDarkhastBindingSource.EndEdit();
            tbl_DarkhastRizTableAdapter.Update(db_DataSetDarkhast.Tbl_DarkhastRiz);
        }

        private void txtCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }
    }
}
