using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace DamProducer
{
    public partial class frmPishFaktor : Form
    {
        public frmPishFaktor()
        {
            InitializeComponent();
        }


        private void frmDarkhast_Load(object sender, EventArgs e)
        {

            this.view_KolMavadTA.Fill(this.db_DataSetDarkhast.View_KolMavad);
            this.tbl_NoeTA.Fill(this.db_DataSetDarkhast.Tbl_Noe);
            try
            {
                this.tbl_PishFaktorTA.Fill(this.db_DataSetDarkhast.Tbl_PishFaktor);
                this.tblPishFaktorBS.MoveLast();
            }
            catch
            {
            }

        }

        private bool NotError()
        {
            err.Clear();
            if (txtDate.Text == "13__/__/__")
            {
                err.SetError(txtDate, " تاریخ را وارد کنید");
                txtDate.Focus();
                return false;
            }

            if (txtName.Value == null)
            {
                err.SetError(txtName, " نام خریدار را انتخاب کنید در صورت نیاز به نام جدید کلید Insert را فشار دهید");
                txtName.Focus();
                return false;
            }
            if (cmbType.Value == null)
            {
                err.SetError(cmbType, " نوع فرمول تولید جنس را انتخاب کنید");
                cmbType.Focus();
                return false;
            }
            if (cmbNoe.Value == null)
            {
                err.SetError(cmbNoe, " نوع جنس را انتخاب کنید");
                cmbNoe.Focus();
                return false;
            }
            if (cmbProduct.Value == null)
            {
                err.SetError(cmbNoe, " نام جنس سفارش را وارد نمایید");
                cmbProduct.Focus();
                return false;
            }



            return true;
        }
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            txtCode.Text = tbl_PishFaktorTA.MaxIDPish().ToString();
            txtDate.Text = function.PerDate(DateTime.Now);
            cmbType.Value = 0;
            cmbNoe.Focus();

        }

        private void ubtnComite_Click(object sender, EventArgs e)
        {

            if (NotError())
            {
                DataRowView current = (DataRowView)tblPishFaktorBS.Current;
                current["Code_Sader"] = (int)frmLogin.userRow["Code_tahvil"];


                int pid = Convert.ToInt32(cmbProduct.Value.ToString());

                int foundIndex = -1;
                foundIndex = viewKolMavadBS.Find("Code_kol", pid.ToString());
                viewKolMavadBS.Position = foundIndex;
                DataRowView currentk = (DataRowView)viewKolMavadBS.Current;

                txtOft.Text = currentk["Oft_Tolid"].ToString();
                txtTolid.Text = currentk["Hazine_Tolid"].ToString();
                txtOther.Text = currentk["Hazine_other"].ToString();
                txtKise.Text = currentk["Hazine_Kise"].ToString();
                txtTakhfif.Text = currentk["Takhfif"].ToString();
                txtJamKol.Text = currentk["Jam"].ToString();
                cmbProduct.Value = pid;
                this.Validate();
                this.tblPishFaktorBS.EndEdit();
                this.tbl_PishFaktorTA.Update(current.Row);
                decimal x = Convert.ToDecimal(txtJamKol.Text);
                x = Math.Round(x / 1000, 0, 0);
                if (txtOther.Text != x.ToString())
                    x = x - Convert.ToDecimal(txtTakhfif.Text) + Convert.ToDecimal(txtOther.Text);
                txtPvahed.Text = x.ToString();
                x = x * (Convert.ToDecimal(VaznSefaresh.Text));
                txtKol.Text = x.ToString();
                txtTkise.Focus();
            }

        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            FarsiLibrary.Utils.PersianCalendar calendar = new FarsiLibrary.Utils.PersianCalendar();
            txtVKise_Leave(null, null);
            if (NotError())
            {
                if (txtVKisesf.Text == "0")
                {
                    err.SetError(txtVKisesf, "  وزن کیسه را وارد نمایید");
                    txtVKisesf.Focus();
                    return;
                }
                if (txtTkise.IntValue == 0)
                {
                    err.SetError(txtTkise, "  تعداد کیسه را وارد نمایید");
                    txtTkise.Focus();
                    return;
                }
                try
                {
                    DataRowView current = (DataRowView)tblPishFaktorBS.Current;

                    this.Validate();
                    this.tblPishFaktorBS.EndEdit();
                    this.tbl_PishFaktorTA.Update(current.Row);
                    string sd = txtDate.Text;
                    string pnd = function.PerDate(DateTime.Now);
                    pnd = pnd.Substring(0, 4);
                    sd = sd.Substring(0, 4);
                    if (sd != pnd)
                    {
                        function.MBox("تاریخ وارد شده با تاریخ سیستم مغایرت دارد", "هشدار", MessageBoxIcon.Error);

                    }
                    if (function.MsgBox("عملیات با موفقیت انجام شد آیا قصد ادامه عملیات را دارید", "توجه", MessageBoxIcon.Question) != DialogResult.OK)
                    {
                        Close();
                    }
                }
                catch
                {

                }


            }

        }

        private void txtCode_KeyDown(object sender, KeyEventArgs e)
        {
            function.NextControl(null, ref e);
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
        private void calc()
        {
            decimal a = 0;
            try
            {
                a = decimal.Parse(txtVKisesf.Text, CultureInfo.InvariantCulture);
            }
            catch { }

            VaznSefaresh.Text = (a * txtTkise.IntValue).ToString();
            decimal x = txtPvahed.IntValue;
            x = x * Convert.ToDecimal(VaznSefaresh.Text);
            txtjamTemp.Text = x.ToString();
            x = x - txtTakhfifKol.IntValue;
            txtKol.Text = x.ToString();
        }

        private void txtCode_ValueChanged(object sender, EventArgs e)
        {
            calc();
        }









        private void cmbProduct_BeforeDropDown(object sender, CancelEventArgs e)
        {
            if (cmbType.Value.ToString() == "0")
            {
                this.viewKolMavadBS.Filter = "(en = 1) AND (Type=0)";

            }
            else
            {
                if (txtName.Value != null)
                {
                    this.viewKolMavadBS.Filter = "(en = 1) AND (Type=1)";
                    // OR (Code_kol=" + cmbProduct.Value.ToString() + ")";
                }
            }
        }

        private void cmbProduct_AfterCloseUp(object sender, EventArgs e)
        {
            this.viewKolMavadBS.Filter = null;
        }






        private void txtVKise_Leave(object sender, EventArgs e)
        {
            calc();
            TextBox txt = (TextBox)sender;
            try { txt.BackColor = Color.White; }
            catch { }

        }

        private void cmbPay_ValueChanged(object sender, EventArgs e)
        {
            /*try
            {
                if ((cmbPay.Value.ToString() == "1") && (cmbPay.Value != null))
                {
                    txtPvahed.ReadOnly = false;
                }
                else
                {
                    txtPvahed.ReadOnly = false;
                }
            }
            catch { txtPvahed.ReadOnly = false;  }*/
        }

        private void txtTkise_Enter(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            txt.BackColor = Color.PeachPuff;
        }

        private void txtDate_Leave(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            txt.BackColor = Color.White;
        }



        private void cmbDarsad_ValueChanged(object sender, EventArgs e)
        {

        }



        private void frmSefaresh_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
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
                cmbProduct_BeforeDropDown(null, null);
            }
        }

        private void cmbProduct_Leave(object sender, EventArgs e)
        {
            cmbProduct_AfterCloseUp(null, null);
        }

        private void ultraButton1_Click(object sender, EventArgs e)
        {
            string s = "";
            int foundIndex = -1;
            if (function.InputBox("توجه", "شماره فاکتور وارد شود", ref s, function.DialogType.Numric, 0) == DialogResult.OK)
            {
                try
                {
                    foundIndex = tblPishFaktorBS.Find("CodeFaktor", s);
                }
                catch
                {
                    foundIndex = -1;
                }

                if (foundIndex > -1)
                    tblPishFaktorBS.Position = foundIndex;
                else
                {
                    //   not found
                    function.MBox("شماره فاکتور وارد شده در سیستم موجود نیست", "توجه", MessageBoxIcon.Error);
                }
            }
        }

        private void btnSearechCode_Click(object sender, EventArgs e)
        {

        }

        private void txtVKisesf_KeyDown(object sender, KeyEventArgs e)
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

        private void printsfStripButton_Click(object sender, EventArgs e)
        {
            FastReport.Report rpt = new FastReport.Report();

            DataRowView current = (DataRowView)tblPishFaktorBS.Current;
            int x = 0;
            try
            {
                x = (int)current["CodeFaktor"];
            }
            catch
            {
                x = 0;
            }
            if (x != 0)
            {
                try
                {
                    view_PishFaktorAD.FillByCodeFaktor(db_DataSetDarkhast.View_PishFaktor, x);
                }
                catch { }
                rpt.Load(Application.StartupPath + @"\report\rptPishFaktor.frx");
                rpt.RegisterData((DataTable)db_DataSetDarkhast.View_PishFaktor, "View_PishFaktor");
                rpt.Show(this.MdiParent);
                Application.OpenForms["PreviewForm"].Activate();
            }
            else
            {
                frmListPishFk frm = new frmListPishFk();
                //  frm.codefro = (int)cmbKharidar.Value;
                frm.ShowDialog();
                //x = frm.codefro;
                //       if (txtName.Text != "")
                //     {


                //   }
                int foundIndex = tblPishFaktorBS.Position;
                this.tbl_PishFaktorTA.Fill(this.db_DataSetDarkhast.Tbl_PishFaktor);
                tblPishFaktorBS.Position = foundIndex;
                x = int.Parse(lblCodeFk.Text);
                view_PishFaktorAD.FillByCodeFaktor(db_DataSetDarkhast.View_PishFaktor, x);
                rpt.RegisterData((DataTable)db_DataSetDarkhast.View_PishFaktor, "View_PishFaktor");
                rpt.Load(Application.StartupPath + @"\report\rptPishFaktor.frx");
                rpt.Show(this.MdiParent);
                Application.OpenForms["PreviewForm"].Activate();
                //  rpt.Dispose();
                //   function.MsgBox("سفارش ثبت نهایی نشده است", "توجه");
            }

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (function.MsgBox("از حذف این سفارش مطمئن هستید؟", "هشدار", MessageBoxIcon.Warning) == DialogResult.OK)
            {
                tblPishFaktorBS.RemoveCurrent();
                tblPishFaktorBS.EndEdit();
                this.tbl_PishFaktorTA.Update(db_DataSetDarkhast.Tbl_PishFaktor);
            }
        }

        private void frmPishFaktor_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.Control && e.KeyCode == Keys.S)
            {
                saveToolStripButton_Click(sender, e);
            }
        }



    }
}
