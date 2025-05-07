using Infragistics.Win.UltraWinGrid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DamProducer
{
    public partial class frmRptCustomiz : Form
    {
        public List<string> CParam = new List<string>();
        public frmRptCustomiz()
        {
            InitializeComponent();
        }

        private void frmRptCustomiz_Load(object sender, EventArgs e)
        {
            try
            {
                this.view_DarkhastTA.Fill(this.db_DataSetDarkhast.View_Darkhast);
            }
            catch { }
        }


        private void UbtnPrint_Click(object sender, EventArgs e)
        {
            int c = CParam.Count;
            for (int i = c; i < 7; i++)
                CParam.Add(string.Empty);
            //string PdNow=function.PerDate(DateTime.Now);
            this.view_DarkhastTA.InsertRpt(txtDate1.Text, txtDate2.Text, string.Empty, CParam[0], CParam[1], CParam[2], CParam[3], CParam[4], CParam[5], CParam[6]);
            int index = (int)this.view_DarkhastTA.MaxRptID();
            foreach (UltraGridRow GRow in UGrid.DisplayLayout.Rows.OfType<UltraGridRow>().Where(r => !r.IsFilteredOut).ToArray())
            {

                int code = 0;
                decimal vazn = 0;
                decimal Pv = 0;
                try
                {
                    code = (int)GRow.Cells["CodeFaktor"].Value;
                }
                catch { }
                try
                {
                    vazn = (decimal)GRow.Cells["VaznBaskool"].Value;
                }
                catch { }
                try
                {
                    Pv = (decimal)GRow.Cells["Pvahed"].Value;
                }
                catch { }



                this.view_DarkhastTA.InsertQuery(index, code, GRow.Cells["ExitDate"].Text.ToString(), GRow.Cells["name_fro"].Text.ToString(),
                    GRow.Cells["cnt"].Text.ToString(), Pv, vazn, GRow.Cells["mobile"].Text.ToString(), GRow.Cells["Code_meli"].Text.ToString(),
                    GRow.Cells["Addres"].Text.ToString(), GRow.Cells["Name_falyat"].Text.ToString(),
                    GRow.Cells["Num_Car"].Text.ToString(), GRow.Cells["CodeFaktor"].Text.ToString(),
                    GRow.Cells["Name_falyat"].Text.ToString(), GRow.Cells["ZarfTarh"].Text.ToString(),
                    GRow.Cells["ShenaseYekta"].Text.ToString());
            }
            frmRptChangeCust frm = new frmRptChangeCust();
            frm.ShowDialog();
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            int t1 = 1;
            int t2 = 5;
            string d1 = frmLogin.Year + "/01/01"; ;
            string d2 = frmLogin.Year + "/12/30"; ;
            if (function.AccDateInput(txtDate1.Text))
            {
                d1 = txtDate1.Text;
            }
            if (function.AccDateInput(txtDate2.Text))
            {
                d2 = txtDate2.Text;
            }
            this.view_DarkhastTA.FillByDate(this.db_DataSetDarkhast.View_Darkhast, d1, d2, t1, t2, string.Empty, string.Empty, string.Empty, string.Empty);
            frmSelectMVD frm = new frmSelectMVD();
            frm.ShowDialog();
            CParam = frm.SParamNotOther;
            UGrid.DisplayLayout.Bands[0].Override.RowFilterMode = RowFilterMode.AllRowsInBand;
            UGrid.DisplayLayout.Bands[0].ColumnFilters["cnt"].FilterConditions.Clear();
            foreach (string sp in frm.SParam)
                UGrid.DisplayLayout.Bands[0].ColumnFilters["cnt"].FilterConditions.Add(FilterComparisionOperator.Equals, sp);

            UGrid.DisplayLayout.Bands[0].ColumnFilters["cnt"].LogicalOperator = FilterLogicalOperator.Or;


        }

        private void txtDate1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SendKeys.Send("{TAB}");
            }
        }
    }
}
