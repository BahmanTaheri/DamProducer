using System;
using System.Windows.Forms;
using FastReport;


namespace DamProducer
{
    public partial class frmResidKala : Form
    {
        public frmResidKala()
        {
            InitializeComponent();
        }

        private void frmResid_Load(object sender, EventArgs e)
        {

            string d1 = frmLogin.Year + "/00/00";
            string d2 = frmLogin.Year + "/99/99";
            this.view_MatterTA.Fill(this.db_DataSetResid.View_Matter);
            this.view_DriverTA.Fill(this.db_DataSetResid.View_Driver);
            this.view_PersonTA.Fill(this.db_DataSetResid.View_Person);
            this.tbl_ResidTA.Fill(this.db_DataSetResid.Tbl_Resid, d1, d2);
            this.tblResidBS.MoveLast();
        }






        private void btnSearch_Click(object sender, EventArgs e)
        {
            string s = "";
            int foundIndex = -1;
            if (function.InputBox("توجه", "شماره رسید جهت ویرایش وارد شود", ref s, function.DialogType.Numric, 0) == DialogResult.OK)
            {
                try
                {
                    foundIndex = tblResidBS.Find("Code_resid", s);
                }
                catch
                {
                    foundIndex = -1;
                }

                if (foundIndex > -1)
                    tblResidBS.Position = foundIndex;
                else
                {
                    //   not found
                    function.MBox("شماره رسید وارد شده در سیستم موجود نیست", "توجه", MessageBoxIcon.Error);

                }
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            //      try
            //     {
            this.Validate();
            this.tblResidBS.EndEdit();
            this.tbl_ResidTA.Update(this.db_DataSetResid.Tbl_Resid);
            this.tblResidRizTblResidBS.EndEdit();
            this.tbl_ResidRizTA.Update(this.db_DataSetResid.Tbl_ResidRiz);
            if (function.MsgBox("عملیات با موفقیت انجام شد آیا قصد ادامه عملیات را دارید", "توجه", MessageBoxIcon.Question) != DialogResult.OK)
            {
                Close();
            }

            //     }
            //     catch
            //     { }
        }





        private void UGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SendKeys.Send("{TAB}");
            }
        }



        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                view_ResidrRizTA.FillByCodeResid(db_DataSetResid.View_ResidrRiz, int.Parse(txtCode.Text));
                view_ResidTA.FillByCode(db_DataSetResid.View_Resid, int.Parse(txtCode.Text));
            }
            catch { }
            string pusr = frmLogin.userRow["Name_tahvil"].ToString();
            
            report1.Load(Application.StartupPath + @"\Report\rptResidAnbar.frx");
            report1.SetParameterValue("Puser", pusr);
            report1.Show(this.MdiParent);
            Application.OpenForms["PreviewForm"].Activate();
        }



        private void UGrid_SummaryValueChanged(object sender, Infragistics.Win.UltraWinGrid.SummaryValueChangedEventArgs e)
        {
            // decimal jamgrid = decimal.Parse(UGrid.Rows.SummaryValues["SumBedehi"].Value.ToString());
            // lblHF.Text=   FarsiLibrary.Utils.ToWords.ToString((long)jamgrid) + "  ریال";

        }

        private void txtCode_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.tbl_ResidRizTA.FillByCode(this.db_DataSetResid.Tbl_ResidRiz, int.Parse(txtCode.Text));
            }
            catch
            {

            }
        }

        private void UGrid_CellDataError(object sender, Infragistics.Win.UltraWinGrid.CellDataErrorEventArgs e)
        {
            e.RaiseErrorEvent = false;
            function.MBox("مقدار وارد شده مجاز نیست", "هشدار", MessageBoxIcon.Error);
        }

        private void txtNumBaskool_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                function.FocusCellGrid(UGrid, "vaznPor");
            }

        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            frmResid_Load(sender, e);
        }

        private void frmResidKala_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                saveToolStripButton_Click(sender, e);
            }
        }










    }
}
