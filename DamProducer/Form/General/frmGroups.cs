using System;
using System.Windows.Forms;

namespace DamProducer
{
    public partial class frmGroups : Form
    {
        public frmGroups()
        {
            InitializeComponent();
        }

        private void frmGroups_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_DataSetGTP.Tbl_Bag' table. You can move, or remove it, as needed.
            this.tbl_BagTA.Fill(this.db_DataSetGTP.Tbl_Bag);
            // TODO: This line of code loads data into the 'db_DataSetGTP.Tbl_Noe' table. You can move, or remove it, as needed.
            this.tbl_NoeTA.FillBy(this.db_DataSetGTP.Tbl_Noe);


            this.tbl_GroupTA.Fill(this.db_DataSetGTP.Tbl_Group);
            this.tbl_ProductTA.Fill(this.db_DataSetGTP.Tbl_Product);
            this.tbl_MatterTA.Fill(this.db_DataSetGTP.Tbl_Matter);

            this.tbl_ItemTA.Fill(this.db_DataSetGTP.Tbl_Item);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            tblGroupBS.EndEdit();
            tbl_GroupTA.Update(db_DataSetGTP.Tbl_Group);

            TblProductTblGroupBS.EndEdit();
            tbl_ProductTA.Update(db_DataSetGTP.Tbl_Product);

            tblMatterBS.EndEdit();
            tbl_MatterTA.Update(db_DataSetGTP.Tbl_Matter);

            tblItemBS.EndEdit();
            tbl_ItemTA.Update(db_DataSetGTP.Tbl_Item);

            tblNoeBS.EndEdit();
            tbl_NoeTA.Update(db_DataSetGTP.Tbl_Noe);

            tblBagBS.EndEdit();
            tbl_BagTA.Update(db_DataSetGTP.Tbl_Bag);

            if (function.MsgBox("عملیات با موفقیت انجام شد آیا قصد ادامه عملیات را دارید", "توجه", MessageBoxIcon.Question) != DialogResult.OK)
            {
                Close();
            }
        }

        private void UGridGroup_KeyDown(object sender, KeyEventArgs e)
        {

            switch (e.KeyData)
            {
                case Keys.Enter:
                    e.SuppressKeyPress = true;
                    SendKeys.Send("{TAB}");
                    break;
                case Keys.Delete:
                    //------------
                    e.SuppressKeyPress = true;
                    break;
                default:

                    break;
            }
        }
    }
}
