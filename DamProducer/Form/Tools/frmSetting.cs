using System;
using System.Windows.Forms;

namespace DamProducer
{
    public partial class frmSetting : Form
    {
        public frmSetting()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string s = string.Empty;
            function.InputBox("توجه", "رمز مدیر را وارد کنید", ref s, function.DialogType.General, 0);
            if (frmLogin.userRow["Pass"].ToString() == s)
            {


                if (Check1.Checked)
                {
                    s = "DELETE FROM Tbl_Person WHERE Code_fro>1";
                    function.Execute(s);
                    s = "DBCC CHECKIDENT (Tbl_Person, RESEED, 1)";
                    function.Execute(s);
                }
                if (Check2.Checked)
                {
                    s = "DELETE FROM Tbl_Resid";
                    function.Execute(s);
                    s = "DELETE FROM Tbl_ResidRiz";
                    function.Execute(s);
                    s = "DBCC CHECKIDENT (Tbl_ResidRiz, RESEED, 0)";
                    function.Execute(s);
                }
                if (Check3.Checked)
                {
                    s = "DELETE FROM Tbl_Darkhast";
                    function.Execute(s);
                    s = "DELETE FROM Tbl_DarkhastRiz";
                    function.Execute(s);
                    s = "DBCC CHECKIDENT (Tbl_DarkhastRiz, RESEED, 0)";
                    function.Execute(s);
                }
                if (Check4.Checked)
                {
                    s = "DELETE FROM Tbl_Pardakht";
                    function.Execute(s);
                    s = "DELETE FROM Tbl_Chek";
                    function.Execute(s);
                    s = "DBCC CHECKIDENT (Tbl_Pardakht, RESEED, 0)";
                    function.Execute(s);
                    s = "DBCC CHECKIDENT (Tbl_Chek, RESEED, 0)";
                    function.Execute(s);
                }
                if (Check5.Checked)
                {
                    s = "DELETE FROM Tbl_Group WHERE Code_group>0";
                    function.Execute(s);
                    s = "DBCC CHECKIDENT (Tbl_Group, RESEED, 0)";
                    function.Execute(s);
                    s = "DBCC CHECKIDENT (Tbl_Product, RESEED, 0)";
                    function.Execute(s);
                    s = "DBCC CHECKIDENT (Tbl_ItemVal, RESEED, 0)";
                    function.Execute(s);
                }
                if (Check6.Checked)
                {
                    s = "DELETE FROM Tbl_KolMavad";
                    function.Execute(s);
                    s = "DELETE FROM Tbl_Riz";
                    function.Execute(s);
                    s = "DBCC CHECKIDENT (Tbl_KolMavad, RESEED, 0)";
                    function.Execute(s);
                    s = "DBCC CHECKIDENT (Tbl_Riz, RESEED, 0)";
                    function.Execute(s);
                }
                if (Check7.Checked)
                {
                    s = "DELETE FROM Tbl_Matter";
                    function.Execute(s);
                    s = "DBCC CHECKIDENT (Tbl_Matter, RESEED, 0)";
                }
                function.MBox("عملیات با موفقیت انجام شد", "توجه", MessageBoxIcon.Information);
            }
            else
            {
                function.MBox("کلمه  عبور وارد شده صحیح نیست", "هشدار", MessageBoxIcon.Error);
            }
        }
    }
}
