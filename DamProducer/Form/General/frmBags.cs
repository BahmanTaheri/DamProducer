using System;
using System.Windows.Forms;

namespace DamProducer
{
    public partial class frmBags : Form
    {
        public frmBags()
        {
            InitializeComponent();
        }

        private void frmBags_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_DataSetResid.View_Person' table. You can move, or remove it, as needed.
            this.view_PersonTA.Fill(this.db_DataSetResid.View_Person);
            this.tbl_BagTA.Fill(this.db_DataSetGTP.Tbl_Bag);
            string d1 = frmLogin.Year + "/00/00";
            string d2 = frmLogin.Year + "/99/99";
            this.tbl_BagResidTA.FillByResid(this.db_DataSetGTP.Tbl_BagResid, d1, d2);

        }

        private void toolStripSave_Click(object sender, EventArgs e)
        {

            this.Validate();
            this.tblBagResidBS.EndEdit();
            this.tbl_BagResidTA.Update(this.db_DataSetGTP.Tbl_BagResid);
            function.MBox("ذخیره شد", "توجه", MessageBoxIcon.Information);


        }

        private void CdResid_KeyDown(object sender, KeyEventArgs e)
        {
            function.NextControl(sender, ref e);
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            view_BagsTA.FillByCode(db_DataSetGTP.View_Bags, int.Parse(CdResid.Text));
            rpt.Load(Application.StartupPath + @"\Report\rptBagResid.frx");
            rpt.Show(this.MdiParent);
            Application.OpenForms["PreviewForm"].Activate();
        }

        private void frmBags_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.Control && e.KeyCode == Keys.S)
            {
                toolStripSave_Click(sender, e);
            }
        }

        private void toolStripAdd_Click(object sender, EventArgs e)
        {
            txtDate.Text = function.PerDate(DateTime.Now);
        }

        private void cmbFroshande_KeyUp(object sender, KeyEventArgs e)
        {
            string s = string.Empty;
            if (e.KeyData == Keys.Insert)
            {
                if (function.InputBox("ورود", "نام فروشنده جدید را وارد کنید", ref s, function.DialogType.General, 0) == DialogResult.OK)
                {
                    s = s.Trim();
                    if (!string.IsNullOrEmpty(s))
                    {
                        this.view_PersonTA.InsertQuery(s);
                        this.view_PersonTA.Fill(this.db_DataSetResid.View_Person);
                    }
                }
            }
        }


    }
}
