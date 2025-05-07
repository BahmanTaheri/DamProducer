using System;
using System.Windows.Forms;

namespace DamProducer
{
    public partial class frmReplac : Form
    {
        public string sfind;
        public string sreplace;
        public frmReplac()
        {
            InitializeComponent();
        }

        private void frmReplac_Load(object sender, EventArgs e)
        {
            this.view_KolMavadTA.FillByen(this.db_DataSetDarkhast.View_KolMavad);
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            sfind = cmbProduct.Text;
            sreplace = txtReplac.Text;
            // sfind = sfind.Trim();
            sreplace = sreplace.Trim();
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            sfind = string.Empty;
            Close();
        }
    }
}
