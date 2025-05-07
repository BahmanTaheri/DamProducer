using System;
using System.Windows.Forms;




namespace DamProducer
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void MnuGroup_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmGroups"] == null)
            {
                frmGroups frm = new frmGroups();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                Application.OpenForms["frmGroups"].Activate();
            }
        }

        private void LockFunction()
        {
            frmLogin frm = new frmLogin();
            frm.ShowDialog();
            if (frmLogin.userValid)
            {     //-----  دسترسی ها اینجا اعمال شود -----
                statusbar.Panels["User"].Text = frmLogin.userRow["Name_tahvil"].ToString();
                statusbar.Panels["Year"].Text = "سال " + frmLogin.Year;
                if ((int)frmLogin.userRow["Code_tahvil"] == 1)
                    mnuReset.Enabled = true;
                else
                {
                    bool b = (bool)frmLogin.userRow["fGroup"];
                    MnuGroup.Enabled = b;
                    b = (bool)frmLogin.userRow["fPesron"];
                    MnuPers.Enabled = b;
                    b = (bool)frmLogin.userRow["fContent"];
                    mnuFormul.Enabled = b;
                    b = (bool)frmLogin.userRow["frmTestFormol"];
                    MnuTestFormol.Enabled = b;
                    b = (bool)frmLogin.userRow["fMojoodi"];
                    MnuMaval.Enabled = b;
                    b = (bool)frmLogin.userRow["fResid"];
                    MnuResid.Enabled = b;
                    b = (bool)frmLogin.userRow["fResidKala"];
                    MnuResidAnbar.Enabled = b;
                    b = (bool)frmLogin.userRow["fSefaresh"];
                    MnuDarkhast.Enabled = b;
                    b = (bool)frmLogin.userRow["fBaskool"];
                    MnuBaskol.Enabled = b;
                    b = (bool)frmLogin.userRow["fUser"];
                    MnuUsers.Enabled = b;
                    b = (bool)frmLogin.userRow["fCntmatter"];
                    Mnufcnt.Enabled = b;
                    b = (bool)frmLogin.userRow["fRfroosh"];
                    MnuRptFroosh.Enabled = b;
                    mnuFroosh.Enabled = b;
                    b = (bool)frmLogin.userRow["fRkharidar"];
                    MnuRptKharidar.Enabled = b;
                    b = (bool)frmLogin.userRow["fRproduct"];
                    MnuRptJens.Enabled = b;
                    b = (bool)frmLogin.userRow["fRkharid"];
                    MnuRptResid.Enabled = b;
                    b = (bool)frmLogin.userRow["fRanbar"];
                    MnuRptMojoodi.Enabled = b;
                    MnuRptMojoodiDate.Enabled = b;
                    b = (bool)frmLogin.userRow["fCartex"];
                    MnuCardex.Enabled = b;
                    b = (bool)frmLogin.userRow["fPishfaktor"];
                    MnuPishfaktor.Enabled = b;
                    b = (bool)frmLogin.userRow["fRFaktor"];
                    MnuRptFaktor.Enabled = b;
                    b = (bool)frmLogin.userRow["fBagResid"];
                    MnuKise.Enabled = b;
                    b = (bool)frmLogin.userRow["fBags"];
                    MnuBags.Enabled = b;
                    b = (bool)frmLogin.userRow["fBagKasr"];
                    MnuKasrKise.Enabled = b;
                    b = (bool)frmLogin.userRow["fRptKise"];
                    MnuRptKise.Enabled = b;
                    b = (bool)frmLogin.userRow["fRKharidRooz"];
                    MnuRptResidRooz.Enabled = b;
                    b = (bool)frmLogin.userRow["FRptKiseKharid"];
                    MnuRptKharidKise.Enabled = b;
                    b = (bool)frmLogin.userRow["frmBazgasht"];
                    MnuBazgasht.Enabled = b;
                    b = (bool)frmLogin.userRow["frmFrooshKol"];
                    MnuFrooshKol.Enabled = b;
                    b = (bool)frmLogin.userRow["frmMojodiAvalye"];
                    MnuMaval.Enabled = b;
                    MnuAvalKise.Enabled = b;
                    b = (bool)frmLogin.userRow["frmItemVal"];
                    mnuItrmVal.Enabled = b;
                    b = (bool)frmLogin.userRow["frmResidanbar"];
                    mnuresidanbargh.Enabled = b;
                    b = (bool)frmLogin.userRow["frmKasr"];
                    MnuAnbarKasr.Enabled = b;
                    b = (bool)frmLogin.userRow["frmBackup"];
                    mnuBakup.Enabled = b;
                    b = (bool)frmLogin.userRow["frmRptAmani"];
                    MnuRptAmani.Enabled = b;
                    b = (bool)frmLogin.userRow["frmRptCustomiz"];
                    mnuCustomizRpt.Enabled = b;
                    b = (bool)frmLogin.userRow["frmRptChangeCust"];
                    mnuArchiveRpt.Enabled = b;
                    b = (bool)frmLogin.userRow["frmDafaterMojoodi"];
                    MnuDaftar.Enabled = b;
                    b = (bool)frmLogin.userRow["frmEtehadieh"];
                    MnuEtehadie.Enabled = b;

                    mnuReset.Enabled = false;
                }

            }
            else
            {
                Application.Exit();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //-------------------- صفحه لاگین  ----------------------

            string sx = function.PerDate(DateTime.Now);
            statusbar.Panels["Date"].Text = sx;
            LockFunction();
            this.WindowState = FormWindowState.Maximized;
            System.Globalization.CultureInfo cinfo = new System.Globalization.CultureInfo("fa-ir");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(cinfo);

            /*------------------------- for win 10 ----------------------
            CultureInfo modified = new CultureInfo(Thread.CurrentThread.CurrentCulture.Name);
            Thread.CurrentThread.CurrentCulture = modified;
            var numberFormat = modified.NumberFormat;
            numberFormat.CurrencyDecimalDigits = 0;
            numberFormat.CurrencyDecimalSeparator = ".";
            numberFormat.CurrencyGroupSeparator = ",";                  */
        }


        private void mnuFormul_Click(object sender, EventArgs e)
        {


            frmFContent frm = new frmFContent();
            frm.FrmType = frmFContent.FType.General;
            frm.fcode = 0;
            frm.MdiParent = this;
            frm.Show();

        }

        private void MnuPers_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmPerson"] == null)
            {
                frmPerson frm = new frmPerson();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                Application.OpenForms["frmPerson"].Activate();
            }

        }

        private void MnuResid_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms["frmResid"] == null)
            {
                frmResid frm = new frmResid();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                Application.OpenForms["frmResid"].Activate();
            }
        }

        private void MnuResidAnbar_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmResidKala"] == null)
            {
                frmResidKala frm = new frmResidKala();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                Application.OpenForms["frmResidKala"].Activate();
            }
        }

        private void ultraExplorerBar1_ItemClick(object sender, Infragistics.Win.UltraWinExplorerBar.ItemEventArgs e)
        {

            switch (e.Item.Key)
            {
                case "00":
                    if (mnuresidanbargh.Enabled)
                        mnuresidanbargh_Click(null, null);
                    break;
                case "01":
                    if (MnuResid.Enabled)
                        MnuResid_Click(null, null);
                    break;

                case "02":
                    if (MnuResidAnbar.Enabled)
                        MnuResidAnbar_Click(null, null);
                    break;
                case "11":
                    if (MnuDarkhast.Enabled)
                        MnuDarkhast_Click(null, null);
                    break;
                case "12":
                    if (MnuBaskol.Enabled)
                        MnuBaskol_Click(null, null);
                    break;
                case "13":
                    if (MnuPishfaktor.Enabled)
                        MnuPishfaktor_Click(null, null);
                    break;
                case "21":
                    if (MnuRptFroosh.Enabled)
                        MnuFroosh_Click(null, null);
                    break;
                case "22":
                    if (MnuRptKharidar.Enabled)
                        MnuKharidar_Click(null, null);
                    break;
                case "23":
                    if (MnuRptJens.Enabled)
                        MnuRptJens_Click(null, null);
                    break;
                case "31":
                    if (MnuRptResid.Enabled)
                        MnuRptResid_Click(null, null);
                    break;
                case "41":
                    if (MnuRptMojoodi.Enabled)
                        MnuMojodi_Click(null, null);
                    break;
                default:
                    break;
            }
        }

        private void MnuDarkhast_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmSefaresh"] == null)
            {
                frmSefaresh frm = new frmSefaresh();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                Application.OpenForms["frmSefaresh"].Activate();
            }




        }

        private void MnuBaskol_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmBaskol"] == null)
            {
                frmBaskol frm = new frmBaskol();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                Application.OpenForms["frmBaskol"].Activate();
            }
        }

        private void MnuUsers_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmUsers"] == null)
            {
                frmUsers frm = new frmUsers();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                Application.OpenForms["frmUsers"].Activate();

            }
        }

        private void statusbar_PanelClick(object sender, Infragistics.Win.UltraWinStatusBar.PanelClickEventArgs e)
        {

            if (e.Panel.Key == "User")
            {
                LockFunction();
            }

            if (e.Panel.Key == "Year")
            {
                frmSelectYear frm = new frmSelectYear();
                frm.ShowDialog();
                frmLogin.Year = frm.yr;
                statusbar.Panels["Year"].Text = "سال " + frmLogin.Year;

            }
        }

        private void MnuFroosh_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmRptFrooshRooz"] == null)
            {
                frmRptFrooshRooz frm = new frmRptFrooshRooz();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                Application.OpenForms["frmRptFrooshRooz"].Activate();

            }

        }

        private void MnuKharidar_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmRptFrooshJens"] == null)
            {
                frmRptFrooshJens frm = new frmRptFrooshJens();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                Application.OpenForms["frmRptFrooshJens"].Activate();

            }

        }

        private void MnuRptJens_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmRptKharidar"] == null)
            {
                frmRptKharidar frm = new frmRptKharidar();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                Application.OpenForms["frmRptKharidar"].Activate();

            }

        }



        private void MnuMojodi_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmMojodi"] == null)
            {
                frmMojodi frm = new frmMojodi();
                frm.CMode = frmMojodi.CallModeEnum.ByYear;
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                Application.OpenForms["frmMojodi"].Activate();

            }

        }

        private void MnuMaval_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmMojodiAvalye"] == null)
            {
                frmMojodiAvalye frm = new frmMojodiAvalye();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                Application.OpenForms["frmMojodiAvalye"].Activate();

            }

        }

        private void Mnufcnt_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmCntMatter"] == null)
            {
                frmCntMatter frm = new frmCntMatter();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                Application.OpenForms["frmCntMatter"].Activate();
            }
        }

        private void MnuRptResid_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmRptKharid"] == null)
            {
                frmRptKharid frm = new frmRptKharid();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                Application.OpenForms["frmRptKharid"].Activate();

            }

        }



        private void mnuCustomizRpt_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmRptCustomiz"] == null)
            {
                frmRptCustomiz frm = new frmRptCustomiz();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                Application.OpenForms["frmRptCustomiz"].Activate();

            }

        }

        private void mnuArchiveRpt_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmRptChangeCust"] == null)
            {
                frmRptChangeCust frm = new frmRptChangeCust();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                Application.OpenForms["frmRptChangeCust"].Activate();

            }

        }

        private void mnuFroosh_Click_1(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmRptFroosh"] == null)
            {
                frmRptFroosh frm = new frmRptFroosh();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                Application.OpenForms["frmRptFroosh"].Activate();

            }

        }

        private void mnuItrmVal_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmItemVal"] == null)
            {
                frmItemVal frm = new frmItemVal();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                Application.OpenForms["frmItemVal"].Activate();

            }

        }

        private void mnuresidanbargh_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmResidanbar"] == null)
            {
                frmResidanbar frm = new frmResidanbar();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                Application.OpenForms["frmResidanbar"].Activate();

            }

        }

        private void mnuBakup_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmBackup"] == null)
            {
                frmBackup frm = new frmBackup();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                Application.OpenForms["frmBackup"].Activate();

            }

        }

        private void mnuClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            function.MBox("برنامه نویس: بهمن طاهری \n\n شماره تماس: 09166074284 \n\n Tah3ri@gmail.com ", "درباره ما", MessageBoxIcon.Information);
        }



        private void mnuReset_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmSetting"] == null)
            {
                frmSetting frm = new frmSetting();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                Application.OpenForms["frmSetting"].Activate();

            }
        }

        private void MnuAnbarKasr_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmKasr"] == null)
            {
                frmKasr frm = new frmKasr();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                Application.OpenForms["frmKasr"].Activate();

            }
        }

        private void MnuRptFaktor_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmRptFaktor"] == null)
            {
                frmRptFaktor frm = new frmRptFaktor();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                Application.OpenForms["frmRptFaktor"].Activate();

            }
        }

        private void MnuPishfaktor_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmPishFaktor"] == null)
            {
                frmPishFaktor frm = new frmPishFaktor();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                Application.OpenForms["frmPishFaktor"].Activate();

            }
        }

        private void MnuCardex_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmRptCartexKala"] == null)
            {
                frmRptCartexKala frm = new frmRptCartexKala();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                Application.OpenForms["frmRptCartexKala"].Activate();

            }

        }

        private void MnuKise_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmBagResid"] == null)
            {
                frmBagResid frm = new frmBagResid();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                Application.OpenForms["frmBagResid"].Activate();

            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (frmLogin.userValid)
            {
                if (function.MsgBox("آیا میخواهید از برنامه خارج شوید؟", "هشدار", MessageBoxIcon.Warning) == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }

        }

        private void MnuBags_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmBags"] == null)
            {
                frmBags frm = new frmBags();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                Application.OpenForms["frmBags"].Activate();

            }
        }

        private void MnuKasrKise_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmBagKasr"] == null)
            {
                frmBagKasr frm = new frmBagKasr();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                Application.OpenForms["frmBagKasr"].Activate();

            }
        }

        private void mnuRptKise_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmRptCartexKise"] == null)
            {
                frmRptCartexKise frm = new frmRptCartexKise();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                Application.OpenForms["frmRptCartexKise"].Activate();
            }
        }

        private void MnuRptResidRooz_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmRptKharidRooz"] == null)
            {
                frmRptKharidRooz frm = new frmRptKharidRooz();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                Application.OpenForms["frmRptKharidRooz"].Activate();

            }
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            string nday = DateTime.Now.DayOfWeek.ToString();
            string fname = Application.StartupPath + @"\AutoBK_" + nday + ".bak";
            System.IO.File.Delete(fname);
            string path = fname;
            function.Execute("Backup Database AccountingDB To Disk='" + path + "'");
        }

        private void MnuTestFormol_Click(object sender, EventArgs e)
        {

            frmFContent frm = new frmFContent();
            frm.FrmType = frmFContent.FType.TestForm;
            frm.fcode = 0;
            frm.MdiParent = this;
            frm.Show();

        }

        private void MnuRptKharidKise_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmRptKharidKise"] == null)
            {
                frmRptKharidKise frm = new frmRptKharidKise();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                Application.OpenForms["frmRptKharidKise"].Activate();

            }
        }

        private void MnuRptMojoodiDate_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmMojodi"] == null)
            {
                frmMojodi frm = new frmMojodi();
                frm.CMode = frmMojodi.CallModeEnum.ByDate;
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                Application.OpenForms["frmMojodi"].Activate();

            }
        }

        private void MnuBazgasht_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms["frmSefareshBazgasht"] == null)
            {
                frmSefareshBazgasht frm = new frmSefareshBazgasht();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                Application.OpenForms["frmSefareshBazgasht"].Activate();

            }
        }

        private void MnuFrooshKol_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmRptFrooshKol"] == null)
            {
                frmRptFrooshKol frm = new frmRptFrooshKol();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                Application.OpenForms["frmRptFrooshKol"].Activate();

            }
        }

        private void MnuRptAmani_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmRptAmani"] == null)
            {
                frmRptAmani frm = new frmRptAmani();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                Application.OpenForms["frmRptAmani"].Activate();

            }
        }

        private void MnuDaftar_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmDafaterMojoodi"] == null)
            {
                frmDafaterMojoodi frm = new frmDafaterMojoodi();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                Application.OpenForms["frmDafaterMojoodi"].Activate();

            }
        }

        private void MnuAvalKise_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmMojodiAvalye"] == null)
            {
                frmMojoodiAvalKise frm = new frmMojoodiAvalKise();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                Application.OpenForms["frmMojoodiAvalKise"].Activate();

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void MnuEtehadie_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms["frmRptEtehadieh"] == null)
            {
                frmRptEtehadieh frm = new frmRptEtehadieh();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                Application.OpenForms["frmRptEtehadieh"].Activate();

            }
        }
    }
}
