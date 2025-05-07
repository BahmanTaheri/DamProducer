using DamProducer.Dset;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace DamProducer
{
    public partial class frmBaskol : Form
    {
        public frmBaskol()
        {
            InitializeComponent();
        }

        private void frmBaskol_Load(object sender, EventArgs e)
        {
            this.db_DataSetDarkhast.Tbl_Darkhast.ExitDateColumn.DefaultValue = frmLogin.Year + "/##/##";
            // TODO: This line of code loads data into the 'db_DataSetPerson.Tbl_Co' table. You can move, or remove it, as needed.
            this.tbl_CoTA.Fill(this.db_DataSetPerson.Tbl_Co);
            // TODO: This line of code loads data into the 'db_DataSetGTP.Tbl_Bag' table. You can move, or remove it, as needed.
            this.tbl_BagTA.Fill(this.db_DataSetGTP.Tbl_Bag);
            //------------------------------------------------------------
            bool b = (bool)frmLogin.userRow["BsPrintBarnameh"];
            btnPrintBarnameh.Visible = b;
            b = (bool)frmLogin.userRow["BsPrintExit"];
            btnPrintExit.Visible = b;
            b = (bool)frmLogin.userRow["BsPrintFak"];
            btnPrintFak.Visible = b;
            b = (bool)frmLogin.userRow["BsPrintSPFak"];
            btnPrintSpFak.Visible = b;
            b = (bool)frmLogin.userRow["BsPrintFormol"];
            btnPrintFormol.Visible = b;
            b = (bool)frmLogin.userRow["BsPrintSef"];
            btnPrintSef.Visible = b;
            b = (bool)frmLogin.userRow["BsEdit"];
            btnEdit.Visible = b;
            b = (bool)frmLogin.userRow["BsPrintRiz"];
            btnPrintRizFak.Visible = b;

            //===========================================================
            this.view_DriverAD.Fill(this.db_DataSetDarkhast.View_Driver);
            this.view_KolMavadAD.Fill(this.db_DataSetDarkhast.View_KolMavad);
            this.view_KharidarAD.Fill(this.db_DataSetDarkhast.View_Kharidar);
            try
            {
                string d1 = frmLogin.Year + "/00/00";
                string d2 = frmLogin.Year + "/99/99";

                this.tbl_DarkhastAD.FillByChk(this.db_DataSetDarkhast.Tbl_Darkhast, d1, d2);
                this.tblDarkhastBS.MoveLast();

            }
            catch { }


        }



        private void UGrid_CellDataError(object sender, Infragistics.Win.UltraWinGrid.CellDataErrorEventArgs e)
        {
            e.RaiseErrorEvent = false;
            function.MBox("مقدار وارد شده مجاز نیست", "هشدار", MessageBoxIcon.Error);
        }

        bool error = true;
        private void saveButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblDarkhastBS.EndEdit();
            error = true;
            try
            {

                err.Clear();

                txtNumCar.Text = txtNumCar.Text.Trim();
                ToolStripButton xb = (ToolStripButton)sender;
                if ((xb.Name == saveButton.Name) && (txtNumCar.TextLength < 13))
                {
                    err.SetError(txtNumCar, "شماره ماشین را کامل وارد کنید");
                    txtNumCar.Focus();
                    return;
                }

                if ((!function.AccDateInput(txtDate.Text)) || (string.IsNullOrEmpty(txtDate.Text)))
                {
                    err.SetError(txtDate, "تاریخ را وارد کنید");
                    txtDate.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtVzBaskool.Text))
                {
                    err.SetError(txtVzBaskool, "وزن باسکول را وارد کنید");
                    txtVzBaskool.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtTKise.Text))
                {
                    err.SetError(txtTKise, "نباید بدون مقدار باشد");
                    txtVzBaskool.Focus();
                    return;
                }

                DataRowView current = (DataRowView)tblDarkhastBS.Current;
                current["Code_tahvil"] = (int)frmLogin.userRow["Code_tahvil"];
                int zd = 1;

                foreach (Infragistics.Win.UltraWinGrid.UltraGridRow GRow in UGridRiz.Rows)
                {
                    decimal x = Convert.ToDecimal(GRow.GetCellValue("meghdar").ToString());
                    decimal v = Convert.ToDecimal(txtVzBaskool.Text);
                    GRow.Cells["MeghdarOrg"].Value = Math.Round(zd * x * v / 1000, 3).ToString();
                    GRow.Update();
                }

                this.tbl_DarkhastAD.Update(current.Row);
                this.TblDarkhastRizTblDarkhastBS.EndEdit();
                this.tbl_DarkhastRizAD.Update(db_DataSetDarkhast.Tbl_DarkhastRiz);

                if (((ToolStripButton)sender) == saveButton)
                    function.MBox("اطلاعات  با موفقیت ثبت شد", "توجه", MessageBoxIcon.Information);

                error = false;
            }
            catch { }
        }

        private void btnPrintFak_Click(object sender, EventArgs e)
        {
            saveButton_Click(sender, e);
            if (!error)
            {
                DataRowView current = (DataRowView)tblDarkhastBS.Current;
                int x = 0;
                try
                {
                    x = (int)current["CodeFaktor"];
                }
                catch
                { }


                string qr = string.Empty;
                bool a = false;
                UGrid.UpdateData();
                db_DataSetDarkhast.View_Darkhast.Clear();
                foreach (UltraGridRow row in UGrid.DisplayLayout.Rows)
                {
                    if ((bool)row.Cells["select"].Value == true)
                    {
                        int code = (int)row.Cells["Code_Darkhast"].Value;
                        if (!a)
                        {
                            qr = qr + string.Format("(Code_Darkhast= {0}) ", code);
                            a = true;
                        }
                        else
                        {
                            qr = qr + string.Format("OR (Code_Darkhast= {0}) ", code);
                        }
                    }
                }
                if (!string.IsNullOrEmpty(qr))
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = DamProducer.Properties.Settings.Default.ConString; ;
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
#pragma warning disable CA2100 // Review SQL queries for security vulnerabilities
                    SqlDataAdapter DA = new SqlDataAdapter("SELECT * FROM View_Darkhast WHERE  " + qr, con);
#pragma warning restore CA2100 // Review SQL queries for security vulnerabilities
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    DA.Fill(db_DataSetDarkhast.View_Darkhast);
                    con.Close();
                    DA.Dispose();
                    con.Dispose();

                }
                if (db_DataSetDarkhast.View_Darkhast.Count == 0)
                {
                    try
                    {
                        view_DarkhastAD.FillByCodeFaktor(db_DataSetDarkhast.View_Darkhast, x);
                    }
                    catch { }
                }

                if (db_DataSetDarkhast.View_Darkhast.Count > 0)
                {
                    report1.Load(Application.StartupPath + @"\Report\rptFaktor.frx");
                    frmPrint frmPrintdlg = new frmPrint();
                    report1.Preview = frmPrintdlg.fastPreview;
                    report1.Show();
                    frmPrintdlg.ShowDialog();
                    if (frmPrintdlg.printed)
                    {
                        string d1 = frmLogin.Year + "/01/01";
                        string d2 = frmLogin.Year + "/12/30";
                        this.tbl_DarkhastAD.UpdatePrintEn(x);
                        this.tbl_DarkhastAD.FillByChk(this.db_DataSetDarkhast.Tbl_Darkhast, d1, d2);
                        this.tblDarkhastBS.MoveLast();
                    }
                }
            }
        }
        //==================================================================================================================


        private void UGrid_BeforeRowsDeleted(object sender, Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs e)
        {
            e.DisplayPromptMsg = false;
            if (function.MsgBox("آیا میخواهید سطر جاری حذف شود؟", "توجه", MessageBoxIcon.Question) == DialogResult.Cancel)
                e.Cancel = true;
        }

        private void cmbDriver_KeyUp(object sender, KeyEventArgs e)
        {
            string s = string.Empty;

            if (e.KeyData == Keys.Insert)
            {
                if (function.InputBox("ورود", "نام راننده جدید را وارد کنید", ref s, function.DialogType.General, 0) == DialogResult.OK)
                {
                    s = s.Trim();
                    if (!string.IsNullOrEmpty(s))
                    {
                        int foundIndex;
                        try
                        {
                            foundIndex = viewDriverBS.Find("Name_fro", s);
                        }
                        catch
                        {
                            foundIndex = -1;
                        }
                        if (foundIndex == -1)
                        {
                            string nc = string.Empty;
                            function.InputBox("ورود", "شماره ماشین  را وارد کنید", ref nc, function.DialogType.General, 0);
                            this.view_DriverAD.InsertQuery(s, nc);
                            this.view_DriverAD.Fill(this.db_DataSetDarkhast.View_Driver);
                        }
                    }
                }
            }
            if (e.KeyData == Keys.F2)
            {
                string x = cmbDriver.DisplayLayout.ActiveRow.Cells["Num_Car"].Value.ToString();
                if (function.InputBox("ورود", "شماره ماشین را بنویسید", ref x, function.DialogType.General, 0) == DialogResult.OK)
                    this.view_DriverAD.UpdateQuery(x, (int)cmbDriver.Value);
                this.view_DriverAD.Fill(this.db_DataSetDarkhast.View_Driver);
            }
        }

        private void btnPrintBarnameh_Click(object sender, EventArgs e)
        {
            bool flag = false;
            int idDarkhast = 0;
            saveButton_Click(sender, e);
            if (!error)
            {
                report1.Preview = null;
                string hname = "";
                int tk = 0;
                decimal vz = 0;
                DataRowView current = (DataRowView)tblDarkhastBS.Current;
                int x = 0;
                try
                {
                    x = (int)current["CodeFaktor"];
                }
                catch
                {
                    x = 0;
                }
                try
                {

                    this.view_DarkhastAD.FillByCodeFaktor(this.db_DataSetDarkhast.View_Darkhast, x);
                    foreach (DataRow DRow in db_DataSetDarkhast.View_Darkhast.Rows)
                    {
                        hname = hname + DRow["cnt"].ToString() + " - ";
                        tk = tk + (int)DRow["TedadKiseBs"];
                        vz = vz + (decimal)DRow["VaznBaskool"];
                        if ((int)DRow["TedadKiseBs"] == 0 || (decimal)DRow["VaznBaskool"] == 0)
                        {
                            idDarkhast = (int)DRow["Code_Darkhast"];
                            flag = true;
                        }
                    }
                }
                catch { }
                if (!flag)
                {
                    FastReport.Report rep = new FastReport.Report();
                    rep.RegisterData((DataTable)this.db_DataSetDarkhast.View_Darkhast, "View_Darkhast");
                    rep.RegisterData((DataTable)this.db_DataSetPerson.Tbl_Co, "Tbl_Co");
                    rep.Load(Application.StartupPath + @"\Report\rptBarnameh.frx");
                    rep.SetParameterValue("Pnames", hname);
                    rep.SetParameterValue("Ptk", tk);
                    rep.SetParameterValue("Pvazn", vz);
                    rep.Show(this.MdiParent);
                    Application.OpenForms["PreviewForm"].Activate();
                }
                else
                {
                    function.MBox("سفارش " + idDarkhast.ToString() + " دارای خطا میباشد", "توجه", MessageBoxIcon.Asterisk);
                }

            }
        }

        private void btnPrintExit_Click(object sender, EventArgs e)
        {
            DataRowView current = (DataRowView)tblDarkhastBS.Current;
            string etime = current["ExitTime"].ToString().Trim();
            if (string.IsNullOrEmpty(etime))
               current["ExitTime"] = (DateTime.Now).ToString("HH:mm");
            saveButton_Click(sender, e);
            bool flag = false;
            int idDarkhast = 0;
            if (!error)
            {
                report1.Preview = null;
                string hname = string.Empty;
                int tk = 0;
                string vz = string.Empty;
               // DataRowView current = (DataRowView)tblDarkhastBS.Current;
                int x = 0;
                try
                {
                    x = (int)current["CodeFaktor"];
                }
                catch
                {
                    x = 0;
                }
                try
                {

                    this.view_DarkhastAD.FillByCodeFaktor(this.db_DataSetDarkhast.View_Darkhast, x);
                    foreach (DataRow DRow in db_DataSetDarkhast.View_Darkhast.Rows)
                    {
                        hname = hname + DRow["cnt"].ToString() + " - ";
                        tk = tk + (int)DRow["TedadKiseBs"];
                        vz = vz + DRow["VaznBaskool"].ToString() + " - ";
                        if ((int)DRow["TedadKiseBs"] == 0 || (decimal)DRow["VaznBaskool"] == 0)
                        {
                            idDarkhast = (int)DRow["Code_Darkhast"];
                            flag = true;
                        }
                    }
                }
                catch { }
                if (!flag)
                {
                    report1.Load(Application.StartupPath + @"\Report\rptKhrooj.frx"); report1.SetParameterValue("Pnames", hname);
                    report1.SetParameterValue("Ptk", tk);
                    report1.SetParameterValue("Pvazn", vz);
                    report1.Show(this.MdiParent);
                    Application.OpenForms["PreviewForm"].Activate();
                }
                else
                {
                    function.MBox("سفارش " + idDarkhast.ToString() + " دارای خطا میباشد", "توجه", MessageBoxIcon.Asterisk);
                }
            }

        }

        private void txtCode_KeyDown(object sender, KeyEventArgs e)
        {
            function.NextControl(sender, ref e);
        }

        private void txtCode_ValueChanged(object sender, EventArgs e)
        {
            try
            {

                this.tbl_DarkhastRizAD.FillByCode(this.db_DataSetDarkhast.Tbl_DarkhastRiz, int.Parse(txtCode.Text));
            }
            catch { }
        }

        private void txtNBaskool_Leave(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            txt.BackColor = Color.White;
        }

        private void txtNBaskool_Enter(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            txt.BackColor = Color.PeachPuff;
        }

        private void txtComment_Enter(object sender, EventArgs e)
        {
            UltraTextEditor txt = (UltraTextEditor)sender;
            txt.Appearance.BackColor = Color.PeachPuff;

        }

        private void txtComment_Leave(object sender, EventArgs e)
        {

            UltraTextEditor txt = (UltraTextEditor)sender;
            txt.Appearance.BackColor = Color.White;
        }

        private void cmbDriver_Leave(object sender, EventArgs e)
        {
            UltraCombo txt = (UltraCombo)sender;
            txt.Appearance.BackColor = Color.White;
            try
            {
                string s = cmbDriver.SelectedRow.GetCellText(cmbDriver.Rows.Band.Columns["Num_Car"]);
                txtNumCar.Text = s;
            }
            catch { }

        }

        private void cmbDriver_Enter(object sender, EventArgs e)
        {
            UltraCombo txt = (UltraCombo)sender;
            txt.Appearance.BackColor = Color.PeachPuff;
        }

        private void btnPrintFormol_Click(object sender, EventArgs e)
        {
            report1.Preview = null;
            view_DarkhastAD.FillByCode(db_DataSetDarkhast.View_Darkhast, int.Parse(txtCode.Text));
            view_DarkhastRizAD.FillByCode(db_DataSetDarkhast.View_DarkhastRiz, int.Parse(txtCode.Text));
            report1.Load(Application.StartupPath + @"\report\rptFormol.frx");
            report1.SetParameterValue("cmb", true);
            report1.Show(this.MdiParent);
            Application.OpenForms["PreviewForm"].Activate();
        }

        private void btnPrintSef_Click(object sender, EventArgs e)
        {
            report1.Preview = null;
            DataRowView current = (DataRowView)tblDarkhastBS.Current;
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
                    view_DarkhastAD.FillByCodeFaktor(db_DataSetDarkhast.View_Darkhast, x);
                }
                finally
                {
                    report1.Load(Application.StartupPath + @"\report\rptSefareshBs.frx");
                    report1.Show(this.MdiParent);
                    Application.OpenForms["PreviewForm"].Activate();
                }


            }
        }

        private void txtVKisebs_KeyDown(object sender, KeyEventArgs e)
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

        private void btnPrintSpFak_Click(object sender, EventArgs e)
        {
            saveButton_Click(sender, e);
            string d1 = frmLogin.Year + "/01/01";
            string d2 = frmLogin.Year + "/12/30";
            int d = 0;
            if (!error)
            {

                DataRowView current = (DataRowView)tblDarkhastBS.Current;
                int xs = 0; int mx = 0; int x = 0;


                try { d = (int)current["Code_Darkhast"]; }

                catch { d = 0; }

                try { x = (int)current["CodeFaktor"]; }

                catch { x = 0; }

                try { xs = (int)current["CodeFaktorSP"]; }

                catch { xs = 0; }

                if (xs == 0)
                {
                    string v = tbl_DarkhastAD.MAXIDFaktorSP().ToString();
                    if ((function.InputBox("توجه", "شماره فاکتور ویژه را وارد کنید ", ref v, function.DialogType.Numric, 0) == DialogResult.OK) && (v != string.Empty))
                    {
                        mx = int.Parse(v);
                        string qr = string.Empty;
                        bool a = false;
                        UGrid.UpdateData();
                        db_DataSetDarkhast.View_Darkhast.Clear();
                        foreach (UltraGridRow row in UGrid.DisplayLayout.Rows)
                        {
                            if ((bool)row.Cells["select"].Value == true)
                            {
                                int code = (int)row.Cells["Code_Darkhast"].Value;
                                if (!a)
                                {
                                    qr += $"(Code_Darkhast= {code}) ";
                                    a = true;
                                }
                                else
                                {
                                    qr += $"OR (Code_Darkhast= {code}) ";
                                }
                            }
                        }
                        if (!string.IsNullOrEmpty(qr))
                        {
                            if (mx != 0)
                            {
                                bool unused = function.Execute(Query: string.Format("UPDATE Tbl_Darkhast SET CodeFaktorSP = {0} , PrintEn=1  WHERE " + qr, mx));
                            }
                        }
                    }
                    else
                    {
                        return;
                    }
                    view_DarkhastAD.FillByCodeFaktorSP(db_DataSetDarkhast.View_Darkhast, mx);
                }
                else
                {
                    view_DarkhastAD.FillByCodeFaktorSP(db_DataSetDarkhast.View_Darkhast, xs);
                }


                if (db_DataSetDarkhast.View_Darkhast.Count > 0)
                {
                    report1.Load(Application.StartupPath + @"\Report\rptFaktorSP.frx");
                    frmPrint frmPrintdlg = new frmPrint();
                    report1.Preview = frmPrintdlg.fastPreview;
                    report1.Show();
                    frmPrintdlg.ShowDialog();
                }

            }
            this.tbl_DarkhastAD.FillByChk(this.db_DataSetDarkhast.Tbl_Darkhast, d1, d2);
            int f = tblDarkhastBS.Find("Code_Darkhast", d);
            tblDarkhastBS.Position = f;

        }

       

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DataRowView current = (DataRowView)tblDarkhastBS.Current;
            int x = 0; int xs = 0; int d = 0;
            try { d = (int)current["Code_Darkhast"]; }
            catch { d = 0; }
            try { x = (int)current["CodeFaktor"]; }
            catch { x = 0; }
            try { xs = (int)current["CodeFaktorSP"]; }
            catch { xs = 0; }
            if (d != 0)
            {
                string v = tbl_DarkhastAD.MAXIDFaktorSP().ToString();
                if ((function.InputBox("توجه", "شماره ویرایش فاکتور ویژه را وارد کنید ش ق: " + xs.ToString(), ref v, function.DialogType.Numric, 0) == DialogResult.OK) && (v != string.Empty))
                {
                    tbl_DarkhastAD.UpdateFaktorSP(int.Parse(v), x);
                }
                else
                {
                    return;
                }
                string d1 = frmLogin.Year + "/01/01";
                string d2 = frmLogin.Year + "/12/30";
                this.tbl_DarkhastAD.FillByChk(this.db_DataSetDarkhast.Tbl_Darkhast, d1, d2);
                int f = tblDarkhastBS.Find("Code_Darkhast", d);
                tblDarkhastBS.Position = f;
            }



        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            frmBaskol_Load(null, null);
            /*
            for (int i =1; i <= tblDarkhastBS.Count; i++)
            {
                 tblDarkhastBS.MoveNext();
                if ((cmbProduct.Text == "مش پرواری1") || (cmbProduct.Text == "مش پرواری2") || (cmbProduct.Text == "پلت پرواری1") || (cmbProduct.Text == "پلت پرواری2"))
                {
                    saveButton_Click(sender, e);

                }
            }
            */
        }


        private void frmBaskol_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.Control && e.KeyCode == Keys.S)
            {
                saveButton_Click(sender, e);
            }
        }

        private void btnPrintRizFak_Click(object sender, EventArgs e)
        {

            report1.Preview = null;
            view_DarkhastAD.FillByCode(db_DataSetDarkhast.View_Darkhast, int.Parse(txtCode.Text));
            view_DarkhastRizAD.FillByCode(db_DataSetDarkhast.View_DarkhastRiz, int.Parse(txtCode.Text));
            report1.Load(Application.StartupPath + @"\report\rptFaktorJoz.frx");
            report1.Show(this.MdiParent);
            Application.OpenForms["PreviewForm"].Activate();
        }

        private void txtDate_Enter(object sender, EventArgs e)
        {

        }
    }
}
