using System;
using System.Windows.Forms;

namespace DamProducer
{
    public partial class frmBackup : Form
    {
        public frmBackup()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Title = "پشتيبان گيري";
            sf.Filter = "Bak Files (*.bak) |*.bak";
            sf.OverwritePrompt = true;
            sf.FileName = function.pdate(DateTime.Now);
            if (sf.ShowDialog() == DialogResult.OK)
            {
                txtsave.Text = sf.FileName;
                if (function.Execute("Backup Database db_Producer To Disk='" + sf.FileName + "'"))
                {
                    function.MBox("پشتيبان گيري با موفقيت انجام شد", "موفق", MessageBoxIcon.Information);
                }
                else
                {
                    function.MBox("خطا در پشتيبان گيري", "خطا", MessageBoxIcon.Error);
                }
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.FilterIndex = 1;
            op.Filter = "Bak Files (*.Bak) |*.bak";
            if (op.ShowDialog() == DialogResult.OK)
            {
                txtrestore.Text = op.FileName;
                if (function.Execute("USE db_Producer Alter Database db_Producer Set Single_User With Rollback IMMEDIATE  Restore Database db_Producer From Disk='" + op.FileName + "' With Replace  ALTER DATABASE db_Producer SET MULTI_USER WITH ROLLBACK IMMEDIATE"))
                {
                    function.MBox("بازگرداني با موفقيت انجام شد", "موفق", MessageBoxIcon.Information);
                }
                else
                {
                    function.MBox("خطا در بازيابي اطلاعات", "خطا", MessageBoxIcon.Error);
                }
            }
        }
    }
}
