using DamProducer.Dset;
using FastReport;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace DamProducer
{



    public partial class frmSefareshBazgasht : Form
    {

        public frmSefareshBazgasht()
        {
            this.InitializeComponent();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            // this.txtCode.Text = this.tbl_DarkhastAD.MaxIdDarkhast().ToString();
            this.txtDate.Text = function.PerDate(DateTime.Now);
            this.txtCodeDarkhast.Value = 0;
            txtCodeDarkhast_Leave(null, null);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (function.MsgBox("از حذف این سفارش مطمئن هستید؟", "هشدار", MessageBoxIcon.Exclamation) == DialogResult.OK)
            {

                this.tbl_DarkhastRizAD.UpdateZero(int.Parse(txtCodeDarkhast.Text));
                this.tbl_BazgashtBS.RemoveCurrent();
                this.tbl_BazgashtBS.EndEdit();
                this.tbl_BazgashtTA.Update(this.db_DataSetDarkhast.Tbl_Bazgasht);
            }
        }

        private void btnSearechCode_Click(object sender, EventArgs e)
        {

        }

        private void calc()
        {
            decimal num = 0;
            if (txtVKisesf.Text == "")
                txtVKisesf.Text = "0";

            try { num = decimal.Parse(txtVKisesf.Text, CultureInfo.InvariantCulture); }
            catch
            {
                string s = this.txtVKisesf.Text;
                s = s.Remove(s.Length - 3, 3);
                num = decimal.Parse(s);
            }

            this.txtVaznSefaresh.Text = (num * this.txtTkise.IntValue).ToString();
            decimal num2 = this.txtPvahed.IntValue - this.txtAmeli.IntValue;
            num2 *= Convert.ToDecimal(this.txtVaznSefaresh.Text);
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


        private void cmbProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SendKeys.Send("{TAB}");
            }
        }


        private void cmbType_Enter(object sender, EventArgs e)
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

            this.tbl_BazgashtTA.Fill(this.db_DataSetDarkhast.Tbl_Bazgasht);
            this.view_KharidarAD.Fill(this.db_DataSetDarkhast.View_Kharidar);
            this.view_KolMavadAD.Fill(this.db_DataSetDarkhast.View_KolMavad);
            try
            {
                string str = frmLogin.Year + "/01/01";
                string str2 = frmLogin.Year + "/12/30";
                this.TblDarkhastBS.MoveLast();
            }
            catch
            {
            }
            txtCodeDarkhast_Leave(null, null);
        }

        private void frmSefareshBazgasht_FormClosed(object sender, FormClosedEventArgs e)
        {
            base.Dispose();
        }

        private void frmSefareshBazgasht_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && (e.KeyCode == Keys.S))
            {
                this.saveToolStripButton_Click(sender, e);
            }
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

            return true;
        }

        private void printsfStripButton_Click(object sender, EventArgs e)
        {
            Report rep = new Report();
            view_BazgashtTA.FillByCode(this.db_DataSetDarkhast.View_Bazgasht, int.Parse(txtCodeBazgasht.Text));
            rep.RegisterData((DataTable)this.db_DataSetDarkhast.View_Bazgasht, "View_Bazgasht");
            rep.Load(Application.StartupPath + @"\Report\rptBazgasht.frx");
            rep.Show(this.MdiParent);

        }


        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            FarsiLibrary.Utils.PersianCalendar calendar = new FarsiLibrary.Utils.PersianCalendar();
            this.txtVKise_Leave(null, null);
            if (this.NotError())
            {
                if (cmbKharidar != null)
                {
                    this.txtTkise.Focus();

                }
                else
                {

                    this.txtCodeDarkhast.Focus();
                    return;
                }
                /*  if (this.txtVKisesf.Text == "0")
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
                      {*/
                DataRowView current = (DataRowView)this.tbl_BazgashtBS.Current;

                string str2 = this.txtDate.Text;
                string str3 = function.PerDate(DateTime.Now).Substring(0, 4);
                foreach (Infragistics.Win.UltraWinGrid.UltraGridRow GRow in UGrid.Rows)
                {
                    decimal x = Convert.ToDecimal(GRow.GetCellValue("meghdar").ToString());
                    decimal v = Convert.ToDecimal(txtVaznSefaresh.Text);
                    GRow.Cells["MeghdarBaz"].Value = Math.Round(x * v / 1000, 3).ToString();
                    GRow.Update();
                }
                this.Validate();
                this.tbl_BazgashtBS.EndEdit();
                this.tbl_BazgashtTA.Update(current.Row);
                this.TblDarkhastRizTblDarkhastBS.EndEdit();
                this.tbl_DarkhastRizAD.Update(db_DataSetDarkhast.Tbl_DarkhastRiz);

                if (str2.Substring(0, 4) != str3)
                {
                    function.MBox("تاریخ وارد شده با تاریخ سیستم مغایرت دارد", "هشدار", MessageBoxIcon.Hand);
                }
                if (function.MsgBox("عملیات با موفقیت انجام شد آیا قصد ادامه عملیات را دارید", "توجه", MessageBoxIcon.Question) != DialogResult.OK)
                {
                    base.Close();
                }
                //    } catch  { }
                // }
            }
        }

        private void txtCode_KeyDown(object sender, KeyEventArgs e)
        {
            function.NextControl(sender, ref e);
        }

        private void txtCode_ValueChanged(object sender, EventArgs e)
        {

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

        private void UGridKala_InitializeLayout(object sender, InitializeLayoutEventArgs e)
        {
            e.Layout.Bands[0].ColumnFilters["en"].FilterConditions.Add(FilterComparisionOperator.Equals, true);
        }



        private void txtCodeDarkhast_Leave(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtCodeDarkhast.Text))
            {
                try
                {
                    this.tbl_DarkhastAD.FillByCodeDar(this.db_DataSetDarkhast.Tbl_Darkhast, int.Parse(txtCodeDarkhast.Text));
                    this.tbl_DarkhastRizAD.FillByCode(this.db_DataSetDarkhast.Tbl_DarkhastRiz, int.Parse(this.txtCodeDarkhast.Text));
                }
                catch
                {
                }
            }
            this.calc();
        }

        private void txtCodeDarkhast_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ultraLabel7_Click(object sender, EventArgs e)
        {

        }

        private void ubtnComite_Click(object sender, EventArgs e)
        {
            txtTkise.Text = db_DataSetDarkhast.Tbl_Darkhast.Rows[0]["TedadKiseBs"].ToString();
            txtVKisesf.Text = db_DataSetDarkhast.Tbl_Darkhast.Rows[0]["VaznKiseBs"].ToString();
            txtVaznSefaresh.Text = db_DataSetDarkhast.Tbl_Darkhast.Rows[0]["VaznBaskool"].ToString();
            txtTakhfifKol.Text = db_DataSetDarkhast.Tbl_Darkhast.Rows[0]["TakhfifKol"].ToString();
            txtAmeli.Text = db_DataSetDarkhast.Tbl_Darkhast.Rows[0]["Ameliat"].ToString();
            txtPvahed.Text = db_DataSetDarkhast.Tbl_Darkhast.Rows[0]["Pvahed"].ToString();
            if (cmbKharidar != null)
            {
                this.txtTkise.Focus();
            }
            else
            {
                this.txtCodeDarkhast.Focus();
            }


        }

        private void txtCodeBazgasht_TextChanged(object sender, EventArgs e)
        {
            txtCodeDarkhast_Leave(null, null);
        }

    }

}


