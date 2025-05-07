using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using System;
using System.Drawing;
using System.Windows.Forms;


namespace DamProducer
{
    public partial class frmResidanbar : Form
    {
        public frmResidanbar()
        {
            InitializeComponent();
        }

        private void frmResid_Load(object sender, EventArgs e)
        {

            string d1 = frmLogin.Year + "/00/00";
            string d2 = frmLogin.Year + "/99/99";
            // TODO: This line of code loads data into the 'db_DataSetResid.View_Tahvil' table. You can move, or remove it, as needed.
            this.view_TahvilTA.Fill(this.db_DataSetResid.View_Tahvil);
            // TODO: This line of code loads data into the 'db_DataSetResid.View_Anbar' table. You can move, or remove it, as needed.
            this.view_AnbarTA.Fill(this.db_DataSetResid.View_Anbar);
            // TODO: This line of code loads data into the 'db_DataSetResid.View_Driver' table. You can move, or remove it, as needed.
            this.view_DriverTA.Fill(this.db_DataSetResid.View_Driver);
            // TODO: This line of code loads data into the 'db_DataSetResid.View_Person' table. You can move, or remove it, as needed.
            this.view_PersonTA.Fill(this.db_DataSetResid.View_Person);
            // TODO: This line of code loads data into the 'db_DataSetResid.View_Vahed' table. You can move, or remove it, as needed.
            this.view_VahedTA.Fill(this.db_DataSetResid.View_Vahed);
            // TODO: This line of code loads data into the 'db_DataSetResid.View_Matter' table. You can move, or remove it, as needed.
            this.view_MatterTA.Fill(this.db_DataSetResid.View_Matter);
            // TODO: This line of code loads data into the 'db_DataSetResid.Tbl_Resid' table. You can move, or remove it, as needed.
            this.tbl_ResidTA.Fill(this.db_DataSetResid.Tbl_Resid, d1, d2);
            // TODO: This line of code loads data into the 'db_DataSetResid.Tbl_NoeResid' table. You can move, or remove it, as needed.
            this.tbl_NoeResidTA.Fill(this.db_DataSetResid.Tbl_NoeResid);
            this.tblResidBS.MoveLast();

        }





        private void toolStripAdd_Click(object sender, EventArgs e)
        {
            CdResid.Text = tbl_ResidTA.MaxID().ToString();
            txtCode.Hide(); CdResid.Show();
            //   txtDateResid.Text = function.PerDate(DateTime.Now);
            //  DataRowView ck = (DataRowView)tblResidBindingSource.Current;
            //  ck["Date_resid"] = function.PerDate(DateTime.Now);
            cmbResidType.Focus();
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
            decimal hz;
            decimal hk;
            //    try
            //     {

            for (int i = 0; i < UGrid.Rows.Count; i++)
            {
                if (UGrid.Rows[i].Cells["Code_matter"].Text == string.Empty)
                {
                    UGrid.Rows[i].Delete(false);
                }
            }
            UGrid.Update();
            //      }
            //      catch { }*/

            if (NotError())
            {
                if (CdResid.Visible)
                {
                    CdResid.Hide(); txtCode.Show();
                    txtCode.Text = CdResid.Text;
                }
                decimal hazine = txtBargiri.IntValue + txtHaml.IntValue + txtOther.IntValue + txtTakhlie.IntValue - txtTakhfif.IntValue;
                decimal Jamvazn = decimal.Parse(UGrid.Rows.SummaryValues["SumVazn"].Value.ToString());

                try { hz = hazine / Jamvazn; }
                catch { hz = 0; }

                try
                {
                    foreach (Infragistics.Win.UltraWinGrid.UltraGridRow row in UGrid.Rows)
                    {
                        hk = Math.Round(decimal.Parse(row.Cells["Price_vahed"].Text) + hz, MidpointRounding.AwayFromZero);
                        row.Cells["Price_tamam"].Value = hk;
                        row.Update();
                    }
                }
                catch { }

                this.Validate();
                this.tblResidBS.EndEdit();
                this.tbl_ResidTA.Update(this.db_DataSetResid.Tbl_Resid);

                this.TblResidRizTblResidBS.EndEdit();
                this.tbl_ResidRizTA.Update(this.db_DataSetResid.Tbl_ResidRiz);
                string sd = txtDateResid.Text;
                string pd = function.PerDate(DateTime.Now);
                pd = pd.Substring(0, 4);
                sd = sd.Substring(0, 4);
                if (sd != pd)
                {
                    function.MBox("تاریخ وارد شده با تاریخ سیستم مغایرت دارد", "هشدار", MessageBoxIcon.Error);
                }
                if (function.MsgBox("عملیات با موفقیت انجام شد آیا قصد ادامه عملیات را دارید", "توجه", MessageBoxIcon.Question) != DialogResult.OK)
                {
                    Close();
                }
            }

        }





        private void Cdresid_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SendKeys.Send("{TAB}");
            }

        }

        private bool NotError()
        {
            err.Clear();
            txtNumCar.Text = txtNumCar.Text.Trim();
            if (txtNumCar.TextLength < 13)
            {
                err.SetError(txtNumCar, "شماره ماشین را کامل وارد کنید");
                txtNumCar.Focus();
                return false;
            }

            if (cmbResidType.Value == null)
            {
                err.SetError(cmbResidType, "نوع رسید را انتخاب کنید");
                cmbResidType.Focus();
                return false;
            }
            if (txtDateResid.Text == "13__/__/__")
            {
                err.SetError(txtDateResid, "تاریخ رسید را وارد  کنید");
                txtDateResid.Focus();
                return false;
            }
            if (cmbFroshande.Value == null)
            {
                err.SetError(cmbFroshande, " نام فروشنده را انتخاب کنید در صورت نیاز به نام جدید کلید Insert را فشار دهید");
                cmbFroshande.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtCodeFak.Text))
            {
                err.SetError(txtCodeFak, "تاریخ بارنامه را وارد  کنید");
                txtCodeFak.Focus();
                return false;
            }

            if (txtDateFak.Text == "13__/__/__")
            {
                err.SetError(txtDateFak, "تاریخ فاکتور را وارد  کنید");
                txtDateFak.Focus();
                return false;
            }
            if (CmbDriver.Value == null)
            {
                err.SetError(CmbDriver, " نام راننده را انتخاب کنید در صورت نیاز به نام جدید کلید Insert را فشار دهید");
                CmbDriver.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtNumCar.Text))
            {
                err.SetError(txtNumCar, "تاریخ بارنامه را وارد  کنید");
                txtNumCar.Focus();
                return false;
            }

            if (cmbAnbar.Value == null)
            {
                err.SetError(cmbAnbar, " انبار را انتخاب کنید");
                cmbAnbar.Focus();
                return false;
            }
            if (cmbTahvil.Value == null)
            {
                err.SetError(cmbTahvil, " نام تحویل گیرنده را انتخاب کنید");
                cmbTahvil.Focus();
                return false;
            }

            return true;

        }

        private void ubtnComite_Click(object sender, EventArgs e)
        {
            if (NotError())
            {

                if (CdResid.Visible)
                {
                    CdResid.Hide(); txtCode.Show();
                    txtCode.Text = CdResid.Text;
                }
                this.Validate();
                this.tblResidBS.EndEdit();
                this.tbl_ResidTA.Update(this.db_DataSetResid.Tbl_Resid);
                // function.FocusCellGrid(UGrid, "Code_matter");  
                UGrid.Focus();
                // UGrid.PerformAction(UltraGridAction.EnterEditMode, false, false);

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
                        UGrid.DeleteSelectedRows(false);

                    }
                    break;
                default:
                    break;
            }


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

        private void UGrid_BeforeRowsDeleted(object sender, Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs e)
        {

            if (e.DisplayPromptMsg == true)
            {
                e.DisplayPromptMsg = false;
                if (function.MsgBox("آیا میخواهید سطر جاری حذف شود؟", "توجه", MessageBoxIcon.Question) == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }

        }

        private void cmbFroshande_KeyUp(object sender, KeyEventArgs e)
        {
            string s = string.Empty;
            if (e.KeyData == Keys.Insert)
            {
                if (function.InputBox("ورود", "نام فروشنده جدید را وارد کنید", ref s, function.DialogType.General, 0) == DialogResult.OK)
                {
                    s = s.Trim();
                    if (s != "")
                    {
                        int foundIndex;
                        try
                        {
                            foundIndex = viewPersonBS.Find("Name_fro", s);
                        }
                        catch
                        {
                            foundIndex = -1;
                        }
                        if (foundIndex == -1)
                        {
                            this.view_PersonTA.InsertQuery(s);
                            this.view_PersonTA.Fill(this.db_DataSetResid.View_Person);
                        }
                    }
                }
            }
        }

        private void CmbDriver_KeyUp(object sender, KeyEventArgs e)
        {
            string strCode = string.Empty;
            if ((e.KeyData == Keys.Insert) && (function.InputBox("ورود", "نام راننده جدید را وارد کنید", ref strCode, function.DialogType.General, 0) == DialogResult.OK))
            {
                strCode = strCode.Trim();
                if (strCode != "")
                {
                    int foundIndex;
                    try
                    {
                        foundIndex = viewDriverBS.Find("Name_fro", strCode);
                    }
                    catch
                    {
                        foundIndex = -1;
                    }
                    if (foundIndex == -1)
                    {
                        string nc = string.Empty;
                        function.InputBox("ورود", "شماره ماشین  را وارد کنید", ref nc, function.DialogType.General, 0);
                        this.view_DriverTA.InsertQuery(strCode, nc);
                        this.view_DriverTA.Fill(this.db_DataSetResid.View_Driver);
                    }

                }

                int fIndex;
                try
                {
                    fIndex = viewDriverBS.Find("Name_fro", strCode);
                }
                catch
                {
                    fIndex = -1;
                }
                if (fIndex != -1)
                {
                    viewDriverBS.Position = fIndex;
                }
            }
            if ((e.KeyData == Keys.F2) && (CmbDriver.Value != null))
            {

                strCode = CmbDriver.DisplayLayout.ActiveRow.Cells["Num_Car"].Value.ToString();

                if ((e.KeyData == Keys.F2) && (CmbDriver.Value != null))
                {

                    frmFastDriver frmFs = new frmFastDriver();
                    frmFs.txtCode.Text = CmbDriver.DisplayLayout.ActiveRow.Cells["Code_meli"].Value.ToString();

                    frmFs.txtName.Text = CmbDriver.DisplayLayout.ActiveRow.Cells["name_fro"].Value.ToString();
                    frmFs.txtCarNum.Text = CmbDriver.DisplayLayout.ActiveRow.Cells["Num_Car"].Value.ToString();
                    frmFs.txtMobile.Text = CmbDriver.DisplayLayout.ActiveRow.Cells["mobile"].Value.ToString();

                    if (frmFs.ShowDialog() == DialogResult.OK)
                        this.view_DriverTA.UpdateDriver(frmFs.txtCarNum.Text, frmFs.txtCode.Text, frmFs.txtName.Text, frmFs.txtMobile.Text, (int)CmbDriver.Value);
                    this.view_DriverTA.Fill(this.db_DataSetResid.View_Driver);
                }

                /*
                if (function.InputBox("ویرایش", "پلاک جدید را وارد کنید", ref strCode, function.DialogType.General, 0) == DialogResult.OK)
                    this.view_DriverTA.UpdatePlak(strCode, (int)CmbDriver.Value);
                this.view_DriverTA.Fill(this.db_DataSetResid.View_Driver); */
            }
        }


        private void txtHaml_Enter(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            txt.BackColor = Color.PeachPuff;
        }

        private void txtHaml_Leave(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            txt.BackColor = Color.White;
        }

        private void txtCodeFak_Enter(object sender, EventArgs e)
        {
            UltraTextEditor txt = (UltraTextEditor)sender;
            txt.BackColor = Color.PeachPuff;
        }

        private void txtCodeFak_Leave(object sender, EventArgs e)
        {
            UltraTextEditor txt = (UltraTextEditor)sender;
            txt.BackColor = Color.White;
        }

        private void cmbResidType_Enter(object sender, EventArgs e)
        {
            UltraComboEditor txt = (UltraComboEditor)sender;
            txt.BackColor = Color.PeachPuff;
        }

        private void cmbResidType_Leave(object sender, EventArgs e)
        {
            UltraComboEditor txt = (UltraComboEditor)sender;
            txt.BackColor = Color.White;
        }

        private void cmbFroshande_Enter(object sender, EventArgs e)
        {
            Infragistics.Win.UltraWinGrid.UltraCombo cmb = (Infragistics.Win.UltraWinGrid.UltraCombo)sender;
            cmb.Appearance.BackColor = Color.PeachPuff;
        }

        private void cmbFroshande_Leave(object sender, EventArgs e)
        {
            Infragistics.Win.UltraWinGrid.UltraCombo cmb = (Infragistics.Win.UltraWinGrid.UltraCombo)sender;
            cmb.Appearance.BackColor = Color.White;
        }

        private void toolStripDel_Click(object sender, EventArgs e)
        {
            if (function.MsgBox("آیا میخواهید رسید جاری را حذف نمایید", "توجه", MessageBoxIcon.Error) == DialogResult.OK)
            {

                tblResidBS.EndEdit();
                this.tbl_ResidTA.Update(db_DataSetResid.Tbl_Resid);
            }
            else
            {

            }

        }

        private void CdResid_ValueChanged(object sender, EventArgs e)
        {

        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {

            view_ResidrRizTA.FillByCodeResid(db_DataSetResid.View_ResidrRiz, int.Parse(txtCode.Text));
            view_ResidTA.FillByCode(db_DataSetResid.View_Resid, int.Parse(txtCode.Text));
            report1.Load(Application.StartupPath + @"\Report\rptResid.frx");
            report1.Show();
        }

        private void UGrid_DoubleClickRow(object sender, DoubleClickRowEventArgs e)
        {

        }

        private void UGrid_DoubleClickCell(object sender, DoubleClickCellEventArgs e)
        {
            //  function.MBox(e.Cell.Row.Index.ToString(), "", MessageBoxIcon.Error);
            //  function.MBox(e.Cell.Column.Key, "", MessageBoxIcon.Error);
        }

        private void txtDateResid_Leave(object sender, EventArgs e)
        {

        }

        private void cmbResidType_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CmbDriver_Leave(object sender, EventArgs e)
        {
            UltraCombo txt = (UltraCombo)sender;
            txt.Appearance.BackColor = Color.White;
            try
            {
                string s = CmbDriver.SelectedRow.GetCellText(CmbDriver.Rows.Band.Columns["Num_Car"]);
                txtNumCar.Text = s.Trim();
            }
            catch { }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            frmResid_Load(sender, e);
        }

        private void frmResidanbar_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.Control && e.KeyCode == Keys.S)
            {
                saveToolStripButton_Click(sender, e);
            }
        }














    }
}
