using Infragistics.Win.UltraWinGrid;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace DamProducer
{
    public partial class frmFContent : Form
    {

        public UltraGridRow ClipboardRow;
        public int fcode = 0;
        public FType FrmType;
        public enum FType
        {
            General = 1,
            TestForm = 2,
        }
        public frmFContent()
        {
            InitializeComponent();
        }

        private void frmFContent_Load(object sender, EventArgs e)
        {

            this.view_KharidarTAD.Fill(this.db_DataSetPerson.View_Kharidar);
            this.tbl_MatterTA.Fill(this.db_DataSetGTP.Tbl_Matter);
            this.tbl_ProductTA.Fill(this.db_DataSetGTP.Tbl_Product);
            this.tbl_GroupTA.Fill(this.db_DataSetGTP.Tbl_Group);
            this.tbl_RizTA.Fill(this.db_DataSetContent.Tbl_Riz);

            if (FrmType == FType.TestForm) ///-----------------------------------------------=---
            {
                this.Text = "فرمول آزمایشی";
                SearchStripButton.Visible = false;
                tbl_KolMavadTA.FillByTest(db_DataSetContent.Tbl_KolMavad);
                //this.db_DataSetContent.Tbl_KolMavad.TypeColumn.DefaultValue = 2;
                cmbSefaresh.Value = 2;
                cmbSefaresh.Hide();
                ultraLabel6.Hide();

                if ((sender.GetType().Name != "ToolStripButton") && (sender.GetType().Name != "UltraButton"))
                {
                    UGrid.Top = UGrid.Top - 30;
                    UGrid.Height = UGrid.Height - 20;
                    btnSave.Top = btnSave.Top - 50;
                }
            }
            else     ///---------------====================-------------------------------------
            {
                this.Text = "فرمول محصولات";
                if (fcode == 0)
                {
                    this.tbl_KolMavadTA.FillByEn(this.db_DataSetContent.Tbl_KolMavad);
                }
                else
                {
                    SearchStripButton.Visible = false;
                    BNavDeleteItem.Enabled = false;
                    bindingNavigatorAddNewItem.Enabled = false;
                    btnSave.Visible = false;
                    this.tbl_KolMavadTA.FillByCodeKol(this.db_DataSetContent.Tbl_KolMavad, fcode);
                }

            }

            // -_-.-.-.-.-.-.-.-.-.-.-.-.-.-.-    غیر فعال کردن گرید   
            //  UGrid.DisplayLayout.Bands[0].Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.False; 


        }

        private bool NotError()
        {
            err.Clear();
            if (cmbGroup.Value == null)
            {
                err.SetError(cmbGroup, "'گروه را انتخاب کنید");
                cmbGroup.Focus();
                return false;
            }

            if (cmbProduct.Value == null)
            {
                err.SetError(cmbProduct, "نام کالا را انتخاب کنید");
                cmbProduct.Focus();
                return false;
            }
            if (FrmType == FType.General)
            {
                if (cmbSefaresh.Value == null)
                {
                    err.SetError(cmbSefaresh, " نوع فرمول را وارد کنید");
                    cmbSefaresh.Focus();
                    return false;
                }
            }

            /*    else if (((int)cmbSefaresh.Value==1) &&  (cmbKharidar.Value==null))
                {
                    errorProvider1.SetError(cmbKharidar, " نام خریدار را وارد کنید");
                    cmbKharidar.Focus();
                    return false;  
                }*/
            return true;

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string pass = string.Empty;
            if (FrmType == FType.General)
            {
                if (function.InputBox("توجه", "کلمه عبور را وارد نمایید", ref pass, function.DialogType.Pass, 0) == DialogResult.OK)
                    if (pass == frmLogin.userRow["Pass"].ToString())
                    {
                        if (NotError() && (function.MsgBox("در صورت تایید فرمول قبلی غیر فعال خواهد شد", "توجه", MessageBoxIcon.Warning) == DialogResult.OK))
                        {
                            this.Validate();
                            this.BsTblKolMavad.EndEdit();
                            this.tbl_KolMavadTA.Update(this.db_DataSetContent.Tbl_KolMavad);
                            UGrid.DisplayLayout.Bands[0].Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
                            try
                            {
                                if (cmbSefaresh.Value.ToString() == "0")
                                {
                                    this.tbl_KolMavadTA.DisableUpdateQuery((int)cmbProduct.Value, int.Parse(txtCode.Text), 0);
                                }
                                else
                                {
                                    this.tbl_KolMavadTA.DisableUpdateQueryKh((int)cmbProduct.Value, int.Parse(txtCode.Text), int.Parse(cmbKharidar.Value.ToString()));
                                }
                                function.FocusCellGrid(UGrid, "Code_matter");
                            }
                            catch { }
                        }
                    }
                    else
                        function.MBox("رمز عبور اشتباه می باشد", "هشدار", MessageBoxIcon.Error);
            }
            else
            {
                if (NotError())
                {
                    this.Validate();
                    this.BsTblKolMavad.EndEdit();
                    this.tbl_KolMavadTA.Update(this.db_DataSetContent.Tbl_KolMavad);
                    UGrid.DisplayLayout.Bands[0].Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
                    try
                    {
                        function.FocusCellGrid(UGrid, "Code_matter");
                    }
                    catch { }
                }
            }


        }



        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            string pass = string.Empty;
            UGrid.Update();
            if (FrmType == FType.General)
            {
                if (function.InputBox("توجه", "کلمه عبور را وارد نمایید", ref pass, function.DialogType.Pass, 0) == DialogResult.OK)
                    if (pass == frmLogin.userRow["Pass"].ToString())
                    {
                        if (NotError())
                        {

                            for (int i = 0; i < UGrid.Rows.Count; i++)
                            {
                                if (string.IsNullOrEmpty(UGrid.Rows[i].Cells["Code_matter"].Text))
                                {
                                    UGrid.Rows[i].Delete(false);
                                }
                            }
                            UGrid.Update();



                            if (decimal.Parse(UGrid.Rows.SummaryValues["SumVazn"].Value.ToString()) == 1000)

                            {
                                try { UGrid.Rows[UGrid.ActiveRow.Index].Update(); }

                                catch { }


                                Calc();
                                this.Validate();
                                this.BsTblKolMavad.EndEdit();
                                this.tbl_KolMavadTA.Update(db_DataSetContent.Tbl_KolMavad);
                                this.tblKolMavadTblRizBS.EndEdit();
                                this.tbl_RizTA.Update(db_DataSetContent.Tbl_Riz);

                                if (function.MsgBox("عملیات با موفقیت انجام شد آیا قصد ادامه عملیات را دارید", "توجه", MessageBoxIcon.Question) != DialogResult.OK)
                                {
                                    Close();
                                }

                            }
                            else
                            {
                                function.MBox("جمع کل مقادیر باید برابر 1000 کیلو(یک تن) باشد", "هشدار", MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                        function.MBox("رمز عبور اشتباه می باشد", "هشدار", MessageBoxIcon.Error);
            }
            else  //======================================================================================================
            {
                if (NotError())
                {
                    for (int i = 0; i < UGrid.Rows.Count; i++)
                    {
                        if (UGrid.Rows[i].Cells["Code_matter"].Text == string.Empty)
                        {
                            UGrid.Rows[i].Delete(false);
                        }
                    }
                    UGrid.Update();

                    if (decimal.Parse(UGrid.Rows.SummaryValues["SumVazn"].Value.ToString()) == 1000)
                    {
                        try { UGrid.Rows[UGrid.ActiveRow.Index].Update(); }
                        catch { }

                        Calc();
                        this.Validate();
                        this.BsTblKolMavad.EndEdit();
                        this.tbl_KolMavadTA.Update(db_DataSetContent.Tbl_KolMavad);
                        this.tblKolMavadTblRizBS.EndEdit();
                        this.tbl_RizTA.Update(db_DataSetContent.Tbl_Riz);

                        if (function.MsgBox("عملیات با موفقیت انجام شد آیا قصد ادامه عملیات را دارید", "توجه", MessageBoxIcon.Question) != DialogResult.OK)
                        {
                            Close();
                        }

                    }
                    else
                    {
                        function.MBox("جمع کل مقادیر باید برابر 1000 کیلو(یک تن) باشد", "هشدار", MessageBoxIcon.Error);
                    }
                }
            }




        }

        private void txtCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SendKeys.Send("{TAB}");
            }

        }

        private void Calc()
        {
            decimal jamgrid = 0;
            decimal dso = 1;
            decimal dk = 0;
            try
            {
                jamgrid = decimal.Parse(UGrid.Rows.SummaryValues["SumJam"].Value.ToString());
                dso = decimal.Parse(txtDarsad.Text);
                dk = decimal.Parse(txtDarsadKarmozd.Text);
            }
            catch { }

            txtOft.Text = Math.Round(jamgrid * dso / 100).ToString();
            decimal sjam;

            try { sjam = Convert.ToDecimal(UGrid.Rows.SummaryValues["SumJam"].Value.ToString()); }
            catch { sjam = 0; }
            decimal koljam = sjam + txtOft.IntValue + txtTolid.IntValue + txtKise.IntValue;
            txtJamKol.Text = koljam.ToString();

            decimal x = Math.Round(koljam / 1000, 0, 0) - txtTakhfif.IntValue + txtOther.IntValue;
            x = x + (x * dk / 100);
            txtVahed.Text = x.ToString();
        }




        private void UGrid_SummaryValueChanged(object sender, Infragistics.Win.UltraWinGrid.SummaryValueChangedEventArgs e)
        {
            //   decimal jamgrid = decimal.Parse(UGrid.Rows.SummaryValues["SumJam"].Value.ToString());

            Calc();
        }

        private void cmbType_Enter(object sender, EventArgs e)
        {
            Infragistics.Win.UltraWinEditors.UltraComboEditor cmb = (Infragistics.Win.UltraWinEditors.UltraComboEditor)sender;
            cmb.Appearance.BackColor = Color.PeachPuff;
        }

        private void cmbType_Leave(object sender, EventArgs e)
        {
            Infragistics.Win.UltraWinEditors.UltraComboEditor cmb = (Infragistics.Win.UltraWinEditors.UltraComboEditor)sender;
            cmb.Appearance.BackColor = Color.White;
        }


        private void txtOft_Leave(object sender, EventArgs e)
        {
            Calc();
            TextBox txt = (TextBox)sender;
            txt.BackColor = Color.White;
        }

        private void txtOft_Enter(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            txt.BackColor = Color.PeachPuff;
        }

        private void UGrid_CellDataError(object sender, Infragistics.Win.UltraWinGrid.CellDataErrorEventArgs e)
        {
            e.RaiseErrorEvent = false;
            function.MBox("مقدار وارد شده مجاز نیست", "هشدار", MessageBoxIcon.Error);
        }



        private void cmbSefaresh_ValueChanged(object sender, EventArgs e)
        {
            if (cmbSefaresh.Value != null)
            {
                if (cmbSefaresh.Value.ToString() == "0")
                {
                    btnSave.Left = cmbProduct.Left;
                    cmbKharidar.Hide();
                    ultraLabel4.Hide();

                }
                else if (cmbSefaresh.Value.ToString() == "1")
                {
                    btnSave.Left = cmbProduct.Left - btnSave.Width - 20;
                    cmbKharidar.Show();
                    ultraLabel4.Show();
                }
                else if (cmbSefaresh.Value.ToString() == "2")
                {
                    btnSave.Left = cmbProduct.Left - btnSave.Width - 20;
                    cmbKharidar.Hide();
                    ultraLabel4.Hide();
                }
                else
                {
                    btnSave.Left = cmbProduct.Left;
                    cmbKharidar.Hide();
                    ultraLabel4.Hide();
                }
            }


        }



        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            txtDate.Text = function.PerDate(DateTime.Now);
            if (FrmType == FType.TestForm) ///-----------------------------------------------=---
            {
                cmbSefaresh.Value = 2;
                cmbSefaresh.Enabled = false;
            }
            else
            {
                cmbSefaresh.Value = 0;
            }


        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal x = Convert.ToDecimal(txtJamKol.Text);
                x = Math.Round(x / 1000, 0, 0);
                txtVahed.Text = x.ToString();
            }
            catch { }
        }

        private void cmbGroup_ValueChanged(object sender, EventArgs e)
        {

            int foundIndex = -1;
            try
            {
                foundIndex = tblGroupBS.Find("Code_group", cmbGroup.Value.ToString());
            }
            catch
            {
                foundIndex = -1;
            }
            if (foundIndex > -1)
            {
                tblGroupBS.Position = foundIndex;
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmKol frm = new frmKol();
            frm.ShowDialog();
            frm.Dispose();
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

        private void mnuPrintTon_Click(object sender, EventArgs e)
        {
            view_KolTA.FillByCode(db_DataSetContent.View_Kol, int.Parse(txtCode.Text));
            view_RizTA.FillByCode(db_DataSetContent.View_Riz, int.Parse(txtCode.Text));
            rpt1.Load(Application.StartupPath + @"\report\rptFrmolKol.frx");
            if (fcode == 0)
            {
                rpt1.Show(this.MdiParent);
                Application.OpenForms["PreviewForm"].Activate();
            }
            else
            {
                rpt1.Show();
            }
        }


        private void mnuPrintDarsad_Click(object sender, EventArgs e)
        {
            view_KolTA.FillByCode(db_DataSetContent.View_Kol, int.Parse(txtCode.Text));
            view_RizTA.FillByCode(db_DataSetContent.View_Riz, int.Parse(txtCode.Text));

            rpt1.Load(Application.StartupPath + @"\report\rptFrmolKolDarsad.frx");
            if (fcode == 0)
            {
                rpt1.Show(this.MdiParent);
                Application.OpenForms["PreviewForm"].Activate();
            }
            else
            {
                rpt1.Show();

            }
        }



        private void CancelButton_Click(object sender, EventArgs e)
        {
            UGrid.PerformAction(UltraGridAction.UndoRow);
            /*
            string code = txtCode.Text;
            frmFContent_Load(sender, e);
            int foundIndex = -1;
            try
            {
                foundIndex = tblKolMavadBS.Find("Code_kol", code);
            }
            catch
            {
                foundIndex = -1;
            }
            
            if (foundIndex !=-1)
                tblKolMavadBS.Position = foundIndex;  */
        }


        private void UGrid_AfterCellUpdate(object sender, CellEventArgs e)
        {
            switch (e.Cell.Column.Key)
            {

                case "Code_matter":
                    //int x=tblMatterBS.Find("", UComboMatter.Value.ToString());
                    //DataRowView current = (DataRowView)tblMatterBS.Current;
                    //e.Cell.Row.Cells["Price_haml"].SelText = current["Price_haml"].ToString();
                    break;
            }
        }

        private void txtDarsad_KeyDown(object sender, KeyEventArgs e)
        {
            if (((e.KeyValue > 47) && (e.KeyValue < 58)) || ((e.KeyValue > 95) && (e.KeyValue < 106)) || (e.KeyValue == 190) || (e.KeyValue == 110) || (e.KeyData == Keys.Enter) || (e.KeyData == Keys.Delete) || (e.KeyData == Keys.Back) || (e.KeyData == Keys.Tab) || (e.KeyData == Keys.Decimal))
            {
                if (e.KeyData == Keys.Enter)
                {
                    e.SuppressKeyPress = true;
                    SendKeys.Send("{TAB}");
                }
                else
                {
                    e.SuppressKeyPress = false;
                }

            }
            else
            {
                e.SuppressKeyPress = true;
            }
        }

        private void MnuPrintTonH_Click(object sender, EventArgs e)
        {
            view_KolTA.FillByCode(db_DataSetContent.View_Kol, int.Parse(txtCode.Text));
            view_RizTA.FillByCode(db_DataSetContent.View_Riz, int.Parse(txtCode.Text));

            rpt1.Load(Application.StartupPath + @"\report\rptFrmolKolTon.frx");
            if (fcode == 0)
            {
                rpt1.Show(this.MdiParent);
                Application.OpenForms["PreviewForm"].Activate();
            }
            else
            {
                rpt1.Show();

            }
        }

        private void MnuCopy_Click(object sender, EventArgs e)
        {
            UGrid.PerformAction(UltraGridAction.Copy);
        }

        private void MnuPaste_Click(object sender, EventArgs e)
        {
            UGrid.PerformAction(UltraGridAction.Paste);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            frmFContent_Load(sender, e);
        }



        private void BNavDeleteItem_Click(object sender, EventArgs e)
        {
            if (function.MsgBox("آیا میخواهید فرمول جاری حذف شود؟", "توجه", MessageBoxIcon.Question) == DialogResult.OK)
            {
                DataRowView cr = (DataRowView)this.BsTblKolMavad.Current;
                int x = Convert.ToInt32(cr["code_kol"]);
                if ((int)tbl_KolMavadTA.ExitInDarkhast(x) == 0)
                {
                    this.BsTblKolMavad.RemoveCurrent();
                    this.BsTblKolMavad.EndEdit();
                    this.tbl_KolMavadTA.Update(this.db_DataSetContent.Tbl_KolMavad);
                }
                else
                {
                    function.MBox("امکان حذف وجود ندارد \n این فرمول در فروش سابقه دارد ", "توجه", MessageBoxIcon.Warning);
                }
            }
        }
    }
}
