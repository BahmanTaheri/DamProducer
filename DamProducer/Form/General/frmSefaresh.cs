using FastReport;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace DamProducer
{



    public partial class frmSefaresh : Form
    {

        public frmSefaresh()
        {
            this.InitializeComponent();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            this.txtCode.Text = this.tbl_DarkhastAD.MaxIdDarkhast().ToString();
            this.txtDate.Text = function.PerDate(DateTime.Now);
            this.cmbType.Value = 0;
            this.cmbPay.Focus();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (function.MsgBox("از حذف این سفارش مطمئن هستید؟", "هشدار", MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                this.TblDarkhastBS.RemoveCurrent();
                this.TblDarkhastBS.EndEdit();
                this.tbl_DarkhastAD.Update(this.db_DataSetDarkhast.Tbl_Darkhast);
            }
        }

        private void btnSearechCode_Click(object sender, EventArgs e)
        {
            string str = "";
            int num = -1;
            if (function.InputBox("توجه", "شماره سفارش وارد شود", ref str, function.DialogType.Numric, 0) == DialogResult.OK)
            {
                try
                {
                    num = this.TblDarkhastBS.Find("Code_Darkhast", str);
                }
                catch
                {
                    num = -1;
                }
                if (num > -1)
                {
                    this.TblDarkhastBS.Position = num;
                }
                else
                {
                    function.MBox("شماره سفارش وارد شده در سیستم موجود نیست", "توجه", MessageBoxIcon.Hand);
                }
            }
        }

        private void calc()
        {
            decimal num = decimal.Parse(this.txtVKisesf.Text, CultureInfo.InvariantCulture);
            this.VaznSefaresh.Text = (num * this.txtTkise.IntValue).ToString();
            decimal num2 = this.txtPvahed.IntValue + this.txtHaml.IntValue - this.txtAmeliat.IntValue - this.txtTakhfif.IntValue;
            this.txtPHaml.Text = num2.ToString();
            num2 *= Convert.ToDecimal(this.VaznSefaresh.Text);
            this.txtjamTemp.Text = num2.ToString();
            this.txtKol.Text = (num2 - this.txtTakhfifKol.IntValue).ToString();
        }

        private void cmbDarsad_ValueChanged(object sender, EventArgs e)
        {
        }

        private void cmbFroshande_Enter(object sender, EventArgs e)
        {
            UltraCombo combo = (UltraCombo)sender;
            combo.Appearance.BackColor = Color.PeachPuff;
        }

        private void cmbFroshande_KeyUp(object sender, KeyEventArgs e)
        {

            string strCode = string.Empty;

            if ((e.KeyData == Keys.Insert) && (function.InputBox("ورود", "کد ملی را وارد کنید", ref strCode, function.DialogType.Numric, 10) == DialogResult.OK))
            {
                if (!string.IsNullOrEmpty(strCode))
                {
                    int num = -1;
                    try
                    {
                        num = this.viewKharidarBS.Find("Code_meli", strCode);
                    }
                    catch
                    {
                        num = -1;
                    }
                    if (num == -1)
                    {
                        frmFastPerson frmFs = new frmFastPerson();
                        frmFs.txtCode.Text = strCode;
                        if (frmFs.ShowDialog() == DialogResult.OK)
                        {

                            this.view_KharidarAD.InsertQuery(frmFs.txtName.Text, frmFs.txtCode.Text, frmFs.txtAdress.Text,
                                 frmFs.txtMobile.Text, frmFs.txtPostCode.Text, frmFs.txtEco.Text, frmFs.CmbPtype.Value.ToString());
                            this.view_KharidarAD.Fill(this.db_DataSetDarkhast.View_Kharidar);
                            num = this.viewKharidarBS.Find("Code_meli", strCode);
                        }


                    }
                    this.viewKharidarBS.Position = num;
                    DataRowView current = (DataRowView)this.viewKharidarBS.Current;
                    this.cmbKharidar.Value = (int)current["Code_fro"];
                }
            }




            if ((e.KeyData == Keys.F2) && (cmbKharidar.Value != null))
            {

                frmFastPerson frmFs = new frmFastPerson();
                frmFs.txtCode.Text = cmbKharidar.DisplayLayout.ActiveRow.Cells["Code_meli"].Value.ToString();
                frmFs.txtMobile.Text = cmbKharidar.DisplayLayout.ActiveRow.Cells["mobile"].Value.ToString();
                frmFs.txtName.Text = cmbKharidar.DisplayLayout.ActiveRow.Cells["name_fro"].Value.ToString();
                frmFs.txtAdress.Text = cmbKharidar.DisplayLayout.ActiveRow.Cells["Addres"].Value.ToString();
                frmFs.txtEco.Text = cmbKharidar.DisplayLayout.ActiveRow.Cells["EcoCode"].Value.ToString();
                frmFs.txtPostCode.Text = cmbKharidar.DisplayLayout.ActiveRow.Cells["PosteCode"].Value.ToString();
                frmFs.CmbPtype.Value = cmbKharidar.DisplayLayout.ActiveRow.Cells["PType"].Value;
                if (frmFs.ShowDialog() == DialogResult.OK)
                    this.view_KharidarAD.UpdateQuery(frmFs.txtName.Text, frmFs.txtCode.Text, frmFs.txtAdress.Text,
                                                      frmFs.txtMobile.Text, frmFs.txtPostCode.Text, frmFs.txtEco.Text,
                                                      frmFs.CmbPtype.Value.ToString(), (int)cmbKharidar.Value);
                this.view_KharidarAD.Fill(this.db_DataSetDarkhast.View_Kharidar);
            }
        }

        private void cmbFroshande_Leave(object sender, EventArgs e)
        {

            UltraCombo combo = (UltraCombo)sender;
            combo.Appearance.BackColor = Color.White;
            int num = -1;
            try
            {
                num = this.viewKharidarBS.Find("name_fro", this.cmbKharidar.Text);
            }
            catch
            {
                num = -1;
            }
            if (num > -1)
            {
                this.viewKharidarBS.Position = num;
            }
            DataRowView current = (DataRowView)this.viewKharidarBS.Current;
            bool flag = true;
            try
            {
                flag = (bool)current["en"];
            }
            catch
            {
                flag = true;
            }
            string ml = string.Empty;
            try
            {
                ml = current["Code_meli"].ToString().Trim();
            }
            catch
            {
                ml = "0";
            }



            if (string.IsNullOrEmpty(ml))
            {
                function.MBox("برای فرد انتخابی کد ملی ثبت نشده است", "توجه", MessageBoxIcon.Hand);
            }
            if (!(flag || (num <= -1)))
            {
                function.MBox("حساب مشتری مورد نظر مسدود شده است", "هشدار", MessageBoxIcon.Hand);
                this.cmbKharidar.Focus();
            }
        }


        int xpay = 0;
        private void cmbPay_ValueChanged(object sender, EventArgs e)
        {
            xpay = 0;
            if (cmbPay.Value != null)
                xpay = (int)cmbPay.Value;

            if (xpay == 7)
            {
                lblDafater.Show();
                CmbDafater.Show();
            }
            else if (xpay == 6)
            {
                lblDafater.Hide();
                CmbDafater.Hide();
            }
            else
            {
                lblDafater.Hide();
                CmbDafater.Hide();
            }
        }

        private void cmbProduct_AfterCloseUp(object sender, EventArgs e)
        {
            this.BSKolMavad.Filter = null;
        }

        private void cmbProduct_BeforeDropDown(object sender, CancelEventArgs e)
        {
            if (this.cmbType.Value.ToString() == "0")
            {
                this.BSKolMavad.Filter = "(en = 1) AND (Type=0) ";
            }
            else if (this.cmbKharidar.Value != null)
            {
                this.BSKolMavad.Filter = "(en = 1) AND (Type=1) ";
            }
            else
            {
                this.Err.SetError(this.cmbKharidar, "نام صاحب فرمول را وارد نمایید");
            }
        }

        private void cmbProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SendKeys.Send("{TAB}");
            }
            if ((e.KeyData == Keys.Up) || (e.KeyData == Keys.Down))
            {
                this.cmbProduct_BeforeDropDown(null, null);
            }
        }

        private void cmbProduct_Leave(object sender, EventArgs e)
        {
            this.cmbProduct_AfterCloseUp(null, null);

        }

        private void CmbType_Enter(object sender, EventArgs e)
        {
            UltraComboEditor editor = (UltraComboEditor)sender;
            editor.Appearance.BackColor = Color.PeachPuff;
        }

        private void cmbType_Leave(object sender, EventArgs e)
        {
            UltraComboEditor editor = (UltraComboEditor)sender;
            editor.Appearance.BackColor = Color.White;
        }



        private void frmDarkhast_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'db_DataSetDarkhast.Tbl_PrsAmel' table. You can move, or remove it, as needed.
            this.tbl_PrsAmelTA.Fill(this.db_DataSetDarkhast.Tbl_PrsAmel);
            // TODO: This line of code loads data into the 'db_DataSetDarkhast.Tbl_Daftar' table. You can move, or remove it, as needed.
            this.tbl_DaftarTA.Fill(this.db_DataSetDarkhast.Tbl_Daftar);


            this.tbl_PayAD.Fill(this.db_DataSetDarkhast.Tbl_Pay);
            this.view_KharidarAD.Fill(this.db_DataSetDarkhast.View_Kharidar);
            this.view_KolMavadAD.Fill(this.db_DataSetDarkhast.View_KolMavad);
            this.tbl_NoeAD.Fill(this.db_DataSetDarkhast.Tbl_Noe);
            try
            {
                string str = frmLogin.Year + "/01/01";
                string str2 = frmLogin.Year + "/12/30";
                this.tbl_DarkhastAD.Fill(this.db_DataSetDarkhast.Tbl_Darkhast, str, str2);
                this.TblDarkhastBS.MoveLast();
            }
            catch
            {
            }
        }

        private void frmSefaresh_FormClosed(object sender, FormClosedEventArgs e)
        {
            base.Dispose();
        }

        private void frmSefaresh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && (e.KeyCode == Keys.S))
            {
                this.saveToolStripButton_Click(sender, e);
            }
        }



        private void LockControl()
        {
            this.cmbKharidar.ReadOnly = true;
        }

        private void mnuBdarsadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.view_DarkhastAD.FillByCode(this.db_DataSetDarkhast.View_Darkhast, int.Parse(this.txtCode.Text));
            this.view_DarkhastRizAD.FillByCode(this.db_DataSetDarkhast.View_DarkhastRiz, int.Parse(this.txtCode.Text));
            this.rpt1.Load(Application.StartupPath + @"\report\rptFormol.frx");
            this.rpt1.SetParameterValue("cmb", true);
            this.rpt1.Show(base.MdiParent);
            Application.OpenForms["PreviewForm"].Activate();
        }

        private void mnuBtonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.view_DarkhastAD.FillByCode(this.db_DataSetDarkhast.View_Darkhast, int.Parse(this.txtCode.Text));
            this.view_DarkhastRizAD.FillByCode(this.db_DataSetDarkhast.View_DarkhastRiz, int.Parse(this.txtCode.Text));

            this.rpt1.Load(Application.StartupPath + @"\report\rptFormol.frx");
            this.rpt1.SetParameterValue("cmb", false);
            this.rpt1.Show(base.MdiParent);
            Application.OpenForms["PreviewForm"].Activate();
        }

        private bool NotError()
        {
            this.Err.Clear();
            if (!function.AccDateInput(this.txtDate.Text))
            {
                this.Err.SetError(this.txtDate, " تاریخ را وارد کنید");
                this.txtDate.Focus();
                return false;
            }
            if (this.cmbPay.Value == null)
            {
                this.Err.SetError(this.cmbPay, " نوع پرداخت را انتخاب کنید");
                this.cmbPay.Focus();
                return false;
            }
            if (this.cmbKharidar.Value == null)
            {
                this.Err.SetError(this.cmbKharidar, " نام خریدار را انتخاب کنید در صورت نیاز به نام جدید کلید Insert را فشار دهید");
                this.cmbKharidar.Focus();
                return false;
            }
            if (this.cmbType.Value == null)
            {
                this.Err.SetError(this.cmbType, " نوع فرمول تولید جنس را انتخاب کنید");
                this.cmbType.Focus();
                return false;
            }
            if (this.cmbNoe.Value == null)
            {
                this.Err.SetError(this.cmbNoe, " نوع جنس را انتخاب کنید");
                this.cmbNoe.Focus();
                return false;
            }
            if (this.cmbProduct.Value == null)
            {
                this.Err.SetError(this.cmbNoe, " نام جنس سفارش را وارد نمایید");
                this.cmbProduct.Focus();
                return false;
            }
            return true;
        }

        private void printsfStripButton_Click(object sender, EventArgs e)
        {
            DataRowView current = (DataRowView)this.TblDarkhastBS.Current;
            

            int codefro = 0;
            try
            {
                codefro = (int)current["CodeFaktor"];
            }
            catch
            {
                codefro = 0;
            }


            if (codefro != 0)
            {
                try
                {
                    this.view_DarkhastAD.FillByCodeFaktor(this.db_DataSetDarkhast.View_Darkhast, new int?(codefro));
                }
                finally
                {
                    if (((int)this.cmbPay.Value) == 1)
                    {
                        report1.Load(Application.StartupPath + @"\report\rptSefareshNaghdi.frx");
                    }
                    else
                    {
                        report1.Load(Application.StartupPath + @"\report\rptSefaresh.frx");
                    }
                    
                    if (chkPrintParm.Checked)
                        this.report1.SetParameterValue("Param", chkPrintParm.Text);
                    this.report1.SetParameterValue("PCMeli", ChkPrint.Checked);
                    this.report1.Show(base.MdiParent);
                    Application.OpenForms["PreviewForm"].Activate();
                }
            }
            else
            {
                frmListDarkhast darkhast = new frmListDarkhast { codefro = (int)cmbKharidar.Value };
                darkhast.ShowDialog();
                codefro = darkhast.codefro;
                if (codefro != 0)
                {
                    this.view_DarkhastAD.FillByCodeFaktor(this.db_DataSetDarkhast.View_Darkhast, new int?(codefro));
                    if (((int)this.cmbPay.Value) == 1)
                    {
                        this.rpt1.Load(Application.StartupPath + @"\report\rptSefareshNaghdi.frx");
                    }
                    else
                    {
                        this.rpt1.Load(Application.StartupPath + @"\report\rptSefaresh.frx");
                    }
                   
                    if (chkPrintParm.Checked)
                        this.rpt1.SetParameterValue("Param", chkPrintParm.Text);
                    this.rpt1.SetParameterValue("PCMeli", ChkPrint.Checked);
                    this.rpt1.Show(base.MdiParent);
                    Application.OpenForms["PreviewForm"].Activate();
                }

            }

            int position = this.TblDarkhastBS.Position;
            string str = frmLogin.Year + "/01/01";
            string str2 = frmLogin.Year + "/12/30";
            this.tbl_DarkhastAD.Fill(this.db_DataSetDarkhast.Tbl_Darkhast, str, str2);
            this.TblDarkhastBS.Position = position;

        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            this.view_DarkhastAD.FillByCode(this.db_DataSetDarkhast.View_Darkhast, int.Parse(this.txtCode.Text));
            this.view_DarkhastRizAD.FillByCode(this.db_DataSetDarkhast.View_DarkhastRiz, int.Parse(this.txtCode.Text));
            Report report = new Report();
           
            this.rpt1.Load(Application.StartupPath + @"\report\rptSefareshJoz.frx");
            this.rpt1.Show(base.MdiParent);
            Application.OpenForms["PreviewForm"].Activate();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            FarsiLibrary.Utils.PersianCalendar calendar = new FarsiLibrary.Utils.PersianCalendar();
            this.txtVKise_Leave(null, null);
            if (this.NotError())
            {
                if (this.txtVKisesf.Text == "0")
                {
                    this.Err.SetError(this.txtVKisesf, "  وزن کیسه را وارد نمایید");
                    this.txtVKisesf.Focus();
                }
                else if (this.txtTkise.IntValue == 0)
                {
                    this.Err.SetError(this.txtTkise, "  تعداد کیسه را وارد نمایید");
                    this.txtTkise.Focus();
                }
                else
                {
                    try
                    {
                        DataRowView current = (DataRowView)this.TblDarkhastBS.Current;


                        this.Validate();
                        this.TblDarkhastBS.EndEdit();
                        this.tbl_DarkhastAD.Update(current.Row);
                        this.TblDarkhastRizTblDarkhastBS.EndEdit();
                        this.tbl_DarkhastRizAD.Update(this.db_DataSetDarkhast.Tbl_DarkhastRiz);
                        string str2 = this.txtDate.Text;
                        string str3 = function.PerDate(DateTime.Now).Substring(0, 4);

                        if (str2.Substring(0, 4) != str3)
                        {
                            function.MBox("تاریخ وارد شده با تاریخ سیستم مغایرت دارد", "هشدار", MessageBoxIcon.Hand);
                        }
                        if (function.MsgBox("عملیات با موفقیت انجام شد آیا قصد ادامه عملیات را دارید", "توجه", MessageBoxIcon.Question) != DialogResult.OK)
                        {
                            base.Close();
                        }
                    }
                    catch { }
                }
            }
        }

        private void txtCode_KeyDown(object sender, KeyEventArgs e)
        {
            function.NextControl(sender, ref e);
        }

        private void txtCode_ValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCode.Text))
            {
                this.tbl_DarkhastRizAD.FillByCode(this.db_DataSetDarkhast.Tbl_DarkhastRiz, int.Parse(this.txtCode.Text));
                this.calc();

                cmbPay_ValueChanged(null, null);
            }
        }

        private void txtDate_Leave(object sender, EventArgs e)
        {
            TextBox box = (TextBox)sender;
            box.BackColor = Color.White;
        }

        private void txtTkise_Enter(object sender, EventArgs e)
        {
            TextBox box = (TextBox)sender;
            box.BackColor = Color.PeachPuff;
        }

        private void txtVKise_Leave(object sender, EventArgs e)
        {
            this.calc();
            TextBox box = (TextBox)sender;
            try
            {
                box.BackColor = Color.White;
            }
            catch
            {
            }
        }

        private void txtVKisesf_KeyDown(object sender, KeyEventArgs e)
        {
            if ((((((e.KeyValue > 0x2f) && (e.KeyValue < 0x3a)) || ((e.KeyValue > 0x5f) && (e.KeyValue < 0x6a))) || (((e.KeyValue == 190) || (e.KeyValue == 110)) || ((e.KeyData == Keys.Enter) || (e.KeyData == Keys.Delete)))) || ((e.KeyData == Keys.Back) || (e.KeyData == Keys.Tab))) || (e.KeyData == Keys.Decimal))
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

        private void ubtnComite_Click(object sender, EventArgs e)
        {
            if (this.NotError())
            {
                DataRowView current = (DataRowView)this.TblDarkhastBS.Current;
                current["Code_Sader"] = (int)frmLogin.userRow["Code_tahvil"];
                int num = Convert.ToInt32(this.cmbProduct.Value.ToString());
                int num2 = -1;
                num2 = this.BSKolMavad.Find("Code_kol", num.ToString());
                this.BSKolMavad.Position = num2;
                DataRowView view2 = (DataRowView)this.BSKolMavad.Current;
                //////////////////////// // this.txtTakhfif.Text = view2["Takhfif"].ToString();

                this.utxtNumberHavaleh.Text = utxtNumberHavaleh.Text.Trim();

                this.txtOft.Text = view2["Oft_Tolid"].ToString();
                this.txtTolid.Text = view2["Hazine_Tolid"].ToString();
                this.txtOther.Text = view2["Hazine_other"].ToString();
                this.txtKise.Text = view2["Hazine_Kise"].ToString();
                this.txtJamKol.Text = view2["Jam"].ToString();

                this.cmbProduct.Value = num;
                base.Validate();
                this.TblDarkhastBS.EndEdit();
                this.tbl_DarkhastAD.Update(current.Row);
                this.UGrid.Selected.Rows.AddRange((UltraGridRow[])this.UGrid.Rows.All);
                this.UGrid.DeleteSelectedRows(false);
                this.tbl_RizTableAD.FillByCode(this.db_DataSetContent.Tbl_Riz, new int?(num));
                int num3 = 0;
                foreach (DataRow row in this.db_DataSetContent.Tbl_Riz.Rows)
                {
                    this.UGrid.DisplayLayout.Bands[0].AddNew();
                    this.UGrid.Rows[num3].Cells["Code_matter"].Value = row["Code_matter"].ToString();
                    this.UGrid.Rows[num3].Cells["Price_vahed"].Value = row["Price_vahed"].ToString();
                    this.UGrid.Rows[num3].Cells["Price_haml"].Value = row["Price_haml"].ToString();
                    this.UGrid.Rows[num3].Cells["Price_takhlie"].Value = row["Price_takhlie"].ToString();
                    this.UGrid.Rows[num3].Cells["meghdar"].Value = row["meghdar"].ToString();
                    this.UGrid.Rows[this.UGrid.ActiveRow.Index].Update();
                    num3++;
                }

                decimal num4 = (decimal)(view2["Price_Amel"]);
                this.txtPvahed.Text = num4.ToString();
                this.txtKol.Text = (num4 * Convert.ToDecimal(this.VaznSefaresh.Text)).ToString();
                this.txtTkise.Focus();

            }
        }

        private void UGridKala_InitializeLayout(object sender, InitializeLayoutEventArgs e)
        {
            e.Layout.Bands[0].ColumnFilters["en"].FilterConditions.Add(FilterComparisionOperator.Equals, true);
        }

        private void ultraButton1_Click(object sender, EventArgs e)
        {
            string str = "";
            int num = -1;
            if (function.InputBox("توجه", "شماره فاکتور وارد شود", ref str, function.DialogType.Numric, 0) == DialogResult.OK)
            {
                try
                {
                    num = this.TblDarkhastBS.Find("CodeFaktor", str);
                }
                catch
                {
                    num = -1;
                }
                if (num > -1)
                {
                    this.TblDarkhastBS.Position = num;
                }
                else
                {
                    function.MBox("شماره فاکتور وارد شده در سیستم موجود نیست", "توجه", MessageBoxIcon.Hand);
                }
            }
        }

        private void UnLockControl()
        {
            this.cmbKharidar.ReadOnly = false;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            frmDarkhast_Load(sender, e);
            /*
            for (int i =1; i <= TblDarkhastBS.Count; i++)
            {
                TblDarkhastBS.MoveNext();
                if ((cmbProduct.Text == "مش پرواری1") || (cmbProduct.Text == "مش پرواری2") || (cmbProduct.Text == "پلت پرواری1") || (cmbProduct.Text == "پلت پرواری2"))
                {

                    ubtnComite_Click(sender, e);
                    saveToolStripButton_Click(sender, e);

                }
            }*/



        }

        private void PrintfmStripButton_Click(object sender, EventArgs e)
        {

        }

        private void MnuVaznToolStrip_Click(object sender, EventArgs e)
        {
            view_DarkhastAD.FillByCode(db_DataSetDarkhast.View_Darkhast, int.Parse(txtCode.Text));
            view_DarkhastRizAD.FillByCode(db_DataSetDarkhast.View_DarkhastRiz, int.Parse(txtCode.Text));

            rpt1.Load(Application.StartupPath + @"\report\rptFormolSefaresh.frx");
            rpt1.SetParameterValue("cmb", false);
            rpt1.Show(base.MdiParent);
            Application.OpenForms["PreviewForm"].Activate();
        }

        private void cmbProduct_TextChanged(object sender, EventArgs e)
        {
            string sx = this.cmbProduct.Text;
            UGridKala.DisplayLayout.Bands[0].ColumnFilters["cnt"].FilterConditions.Clear();
            UGridKala.DisplayLayout.Bands[0].ColumnFilters["cnt"].FilterConditions.Add(FilterComparisionOperator.Contains, sx);
        }



        private void PrintToNet_Click(object sender, EventArgs e)
        {

        }

        private void cmbKharidar_ValueChanged(object sender, EventArgs e)
        {

            if (cmbKharidar.Value != null)
            {
                if (cmbKharidar.Value.ToString() == frmLogin.iEtehadie.ToString())
                {
                    cmbTahvilgirandeh.ReadOnly = false;
                    utxtNumberHavaleh.ReadOnly = false;
                    //txtVaznHavale.ReadOnly = false;
                }
                else
                {
                    cmbTahvilgirandeh.ReadOnly = true;
                    utxtNumberHavaleh.ReadOnly = true;
                    //   txtVaznHavale.ReadOnly = true;
                    //  txtVaznHavale.Text = "";
                    utxtNumberHavaleh.Text = "";
                    cmbTahvilgirandeh.Text = "";
                }
            }
            else
            {
                cmbTahvilgirandeh.ReadOnly = true;
                utxtNumberHavaleh.ReadOnly = true;
                //  txtVaznHavale.ReadOnly = true;
                //  txtVaznHavale.Text = "";
                utxtNumberHavaleh.Text = "";
                cmbTahvilgirandeh.Text = "";
            }
        }

        private void cmbNoe_KeyDown(object sender, KeyEventArgs e)
        {
            function.NextControl(sender, ref e);

        }

        private void cmbTahvilgirandeh_KeyUp(object sender, KeyEventArgs e)
        {

            string strCode = string.Empty;

            if ((e.KeyData == Keys.Insert) && (function.InputBox("ورود", "کد ملی را وارد کنید", ref strCode, function.DialogType.Numric, 10) == DialogResult.OK))
            {
                if (!string.IsNullOrEmpty(strCode))
                {
                    int num = -1;
                    try
                    {
                        num = this.viewKharidarBS.Find("Code_meli", strCode);
                    }
                    catch
                    {
                        num = -1;
                    }
                    if (num == -1)
                    {
                        frmFastPerson frmFs = new frmFastPerson();
                        frmFs.txtCode.Text = strCode;
                        if (frmFs.ShowDialog() == DialogResult.OK)
                        {

                            this.view_KharidarAD.InsertQuery(frmFs.txtName.Text, frmFs.txtCode.Text, frmFs.txtAdress.Text,
                                 frmFs.txtMobile.Text, frmFs.txtPostCode.Text, frmFs.txtEco.Text, frmFs.CmbPtype.Value.ToString());
                            this.view_KharidarAD.Fill(this.db_DataSetDarkhast.View_Kharidar);
                            num = this.viewKharidarBS.Find("Code_meli", strCode);
                        }


                    }
                    this.viewKharidarBS.Position = num;
                    DataRowView current = (DataRowView)this.viewKharidarBS.Current;
                    this.cmbKharidar.Value = (int)current["Code_fro"];
                }
            }




            if ((e.KeyData == Keys.F2) && (cmbKharidar.Value != null))
            {

                frmFastPerson frmFs = new frmFastPerson();
                frmFs.txtCode.Text = cmbTahvilgirandeh.DisplayLayout.ActiveRow.Cells["Code_meli"].Value.ToString();
                frmFs.txtMobile.Text = cmbTahvilgirandeh.DisplayLayout.ActiveRow.Cells["mobile"].Value.ToString();
                frmFs.txtName.Text = cmbTahvilgirandeh.DisplayLayout.ActiveRow.Cells["name_fro"].Value.ToString();
                frmFs.txtAdress.Text = cmbTahvilgirandeh.DisplayLayout.ActiveRow.Cells["Addres"].Value.ToString();
                frmFs.txtEco.Text = cmbTahvilgirandeh.DisplayLayout.ActiveRow.Cells["EcoCode"].Value.ToString();
                frmFs.txtPostCode.Text = cmbTahvilgirandeh.DisplayLayout.ActiveRow.Cells["PosteCode"].Value.ToString();
                frmFs.CmbPtype.Value = cmbTahvilgirandeh.DisplayLayout.ActiveRow.Cells["PType"].Value;
                if (frmFs.ShowDialog() == DialogResult.OK)
                    this.view_KharidarAD.UpdateQuery(frmFs.txtName.Text, frmFs.txtCode.Text, frmFs.txtAdress.Text,
                                                      frmFs.txtMobile.Text, frmFs.txtPostCode.Text, frmFs.txtEco.Text,
                                                      frmFs.CmbPtype.Value.ToString(), (int)cmbTahvilgirandeh.Value);
                this.view_KharidarAD.Fill(this.db_DataSetDarkhast.View_Kharidar);
            }
        }

        private void Cmb_Amel_KeyDown(object sender, KeyEventArgs e)
        {
            function.NextControl(sender, ref e);
        }
    }

}


