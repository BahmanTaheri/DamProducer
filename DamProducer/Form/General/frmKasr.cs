using System;
using System.Windows.Forms;

namespace DamProducer
{
    public partial class frmKasr : Form
    {
        public frmKasr()
        {
            InitializeComponent();
        }

        private void frmKasr_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_DataSetGTP.Tbl_Matter' table. You can move, or remove it, as needed.
            this.tbl_MatterTA.Fill(this.db_DataSetGTP.Tbl_Matter);
            // TODO: This line of code loads data into the 'db_DataSetGTP.Tbl_Kasr' table. You can move, or remove it, as needed.
            this.tbl_KasrTA.Fill(this.db_DataSetGTP.Tbl_Kasr);


        }

        private void toolStripAdd_Click(object sender, EventArgs e)
        {
            txtDate.Text = function.PerDate(DateTime.Now);
            UType.Value = 0;
            UType.Focus();
        }

        private void CdResid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void toolStripSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblKasrBS.EndEdit();
            this.tbl_KasrTA.Update(this.db_DataSetGTP.Tbl_Kasr);
            function.MBox("ذخیره شد", "توجه", MessageBoxIcon.Information);
        }

        private void toolStripDel_Click(object sender, EventArgs e)
        {

        }

        private void printButton_Click(object sender, EventArgs e)
        {

        }
    }
}
