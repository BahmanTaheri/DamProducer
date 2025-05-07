using Infragistics.Win.UltraWinGrid;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DamProducer
{
    public partial class frmSelectMVD : Form
    {
        public List<string> SParam = new List<string>();
        public List<string> SParamNotOther = new List<string>();

        public frmSelectMVD()
        {
            InitializeComponent();
        }

        private void frmSelectMVD_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_DataSetDarkhast.View_KolMavad' table. You can move, or remove it, as needed.
            this.view_KolMavadTA.FillByCnt(this.db_DataSetDarkhast.View_KolMavad);

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmSelectMVD_FormClosing(object sender, FormClosingEventArgs e)
        {
            SParam.Clear();
            SParamNotOther.Clear();
            foreach (UltraGridRow row in UGrid.DisplayLayout.Rows)
                if ((bool)row.Cells["select"].Value == true)
                {
                    SParam.Add(row.Cells["cnt"].Value.ToString());
                    if ((bool)row.Cells["other"].Value == false)
                        SParamNotOther.Add(row.Cells["cnt"].Value.ToString());
                }






            // SParam.Add(row.Cells["Code_kol"].Value.ToString());
        }
    }
}
