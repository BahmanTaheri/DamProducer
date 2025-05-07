using FastReport;
using System;
using System.Data;
using System.Windows.Forms;


namespace DamProducer
{
    public partial class frmPerson : Form
    {
        public frmPerson()
        {
            InitializeComponent();
        }

        private void frmPerson_Load(object sender, EventArgs e)
        {




            this.tbl_CoTA.Fill(this.db_DataSetPerson.Tbl_Co);
            this.tbl_BankTA.Fill(this.db_DataSetPerson.Tbl_Bank);
            this.tbl_TahvilTA.Fill(this.db_DataSetPerson.Tbl_Tahvil);
            this.tbl_MahiatTA.Fill(this.db_DataSetPerson.Tbl_Mahiat);
            this.tbl_NoFalyatTA.Fill(this.db_DataSetPerson.Tbl_NoFalyat);
            //    this.tbl_NoHamkariTableAdapter.Fill(this.db_DataSetPerson.Tbl_NoHamkari);
            this.tbl_PersonTA.FillByNoAdmin(this.db_DataSetPerson.Tbl_Person);
            bindingNavigatorPositionItem_TextChanged(null, null);

            //------------------------------------------------------------
            bool b = (bool)frmLogin.userRow["Lockperson"];
            this.UGridPers.DisplayLayout.Bands[0].Columns["en"].Hidden = !b;


        }
        private bool NoEmpty()
        {
            txtName.Text = txtName.Text.Trim();
            txtNumCar.Text = txtNumCar.Text.Trim();
            txtMobile.Text = txtMobile.Text.Trim();

            if (string.IsNullOrEmpty(txtName.Text))
            {
                err.SetError(txtName, "نام وارد شود");
                return false;
            }
            if (CmbMahiat.Value == null)
            {
                err.SetError(CmbMahiat, "نوع مشخص شود");
                return false;
            }
            return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            this.Validate();
            try
            {
                this.tblPersonBs.EndEdit();
                this.tbl_PersonTA.Update(((DataRowView)this.tblPersonBs.Current).Row);
            }
            catch { }
            try
            {
                this.tblTahvilBS.EndEdit();
                this.tbl_TahvilTA.Update(this.db_DataSetPerson.Tbl_Tahvil);
            }
            catch { }

            try
            {
                this.tblBankBS.EndEdit();
                this.tbl_BankTA.Update(this.db_DataSetPerson.Tbl_Bank);
            }
            catch { }

            // try
            //   {
            tx1.Text = tx1.Text.Trim();
            tx2.Text = tx2.Text.Trim();
            tx3.Text = tx3.Text.Trim();
            tx4.Text = tx4.Text.Trim();
            tx5.Text = tx5.Text.Trim();
            tx6.Text = tx6.Text.Trim();
            tx7.Text = tx7.Text.Trim();
            tx8.Text = tx8.Text.Trim();
            tx9.Text = tx9.Text.Trim();
            tx10.Text = tx10.Text.Trim();
            tx11.Text = tx11.Text.Trim();
            txtzarf1.Text = txtzarf1.Text.Trim();
            txtzarf2.Text = txtzarf2.Text.Trim();
            txtzarf3.Text = txtzarf3.Text.Trim();

            this.tbl_CoBS.EndEdit();
            this.tbl_CoTA.Update(((DataRowView)this.tbl_CoBS.Current).Row);
            /*   }
               catch { }*/
            try
            {
                this.tblMahiatBS.EndEdit();
                this.tbl_MahiatTA.Update(this.db_DataSetPerson.Tbl_Mahiat);
            }
            catch { }

            try
            {
                this.tblNoFalyatBS.EndEdit();
                this.tbl_NoFalyatTA.Update(this.db_DataSetPerson.Tbl_NoFalyat);
            }
            catch { }

            if ((!function.CheckMcode(txtCode.Text)) && (txtCode.MaxLength == 10))
            {
                function.MBox("کد ملی اشتباه ثبت شده اصلاح کنید", "توجه", MessageBoxIcon.Error);
                txtCode.Focus();

            }
            else
            {

                if (function.MsgBox("عملیات با موفقیت انجام شد آیا قصد ادامه عملیات را دارید", "توجه", MessageBoxIcon.Question) != DialogResult.OK)
                {
                    Close();
                }
            }



        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SendKeys.Send("{TAB}");
            }
        }


        private void UGridPers_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Enter:
                    e.SuppressKeyPress = true;
                    SendKeys.Send("{TAB}");
                    break;
                case Keys.Delete:
                    e.SuppressKeyPress = true;
                    bindingNavigatorDeleteItem_Click(sender, e);
                    /* if (function.MsgBox("آیا میخواهید سطر جاری حذف شود؟", "توجه", MessageBoxIcon.Question) == DialogResult.OK)
                     {
                         Infragistics.Win.UltraWinGrid.UltraGrid grd = (Infragistics.Win.UltraWinGrid.UltraGrid)sender;
                         grd.Rows[grd.ActiveRow.Index].Delete(false);
                     }*/
                    break;
                default:
                    break;
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (function.MsgBox("آیا میخواهید سطر جاری حذف شود؟", "توجه", MessageBoxIcon.Question) == DialogResult.OK)
            {
                DataRowView cr = (DataRowView)this.tblPersonBs.Current;
                int x = Convert.ToInt32(cr["code_fro"]);
                if (((int)tbl_PersonTA.ExistInDarkhast(x) == 0) && ((int)tbl_PersonTA.ExistInResid(x) == 0))
                {
                    this.tblPersonBs.RemoveCurrent();
                    this.tblPersonBs.EndEdit();
                    this.tbl_PersonTA.Update(this.db_DataSetPerson.Tbl_Person);
                }
                else
                {
                    function.MBox("امکان حذف وجود ندارد \n این فرد در خرید یا فروش سابقه دارد ", "توجه", MessageBoxIcon.Warning);
                }
            }

        }

        private void bindingNavigatorPositionItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorPositionItem_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(bindingNavigatorPositionItem.Text) == 0)
            {
                bindingNavigatorDeleteItem.Enabled = false;

                txtName.Enabled = false;
                txtCode.Enabled = false;
                txtMobile.Enabled = false;
                txtNumCar.Enabled = false;
                txtAdress1.Enabled = false;
                txtTel.Enabled = false;
                CmbMahiat.Enabled = false;
            }
            else
            {
                bindingNavigatorDeleteItem.Enabled = true;
                txtName.Enabled = true;
                txtCode.Enabled = true;
                txtMobile.Enabled = true;
                txtNumCar.Enabled = true;
                txtAdress1.Enabled = true;
                txtTel.Enabled = true;
                CmbMahiat.Enabled = true;
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            txtName.Focus();
        }





        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.tbl_PersonTA.FillByNoAdmin(this.db_DataSetPerson.Tbl_Person);
        }

        private void CmbType_Pers_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(CmbType_Pers.SelectedItem.DataValue) < 15)
                    txtCode.MaxLength = 10;
                else
                    txtCode.MaxLength = 11;
            }
            catch
            { }
        }

        private void printToolStripButton_Click_1(object sender, EventArgs e)
        {
            UGridPers.UpdateData();
            DataTable dt = new DataTable();
            dt = function.UGridSelectToDTable(UGridPers.DisplayLayout);
            Report rep = new Report();
            if (dt.Rows.Count == 0)
            {
                dt = function.UGridAllToDTable(UGridPers.DisplayLayout);
            }
            rep.RegisterData(dt, "Tbl_Person");
            rep.RegisterData((DataTable)db_DataSetPerson.Tbl_Mahiat, "Tbl_Mahiat");
            rep.Load(Application.StartupPath + @"\Report\RptPerson.frx");
            rep.Show(this.MdiParent);
        }
    }
}
