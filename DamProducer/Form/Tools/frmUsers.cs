using System;
using System.Windows.Forms;


namespace DamProducer
{
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
        }



        private void frmUsers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_DataSetPerson.Tbl_Tahvil' table. You can move, or remove it, as needed.
            this.tbl_TahvilTA.FillByEnable(this.db_DSPerson.Tbl_Tahvil);

        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtpass.Text))
            {
                this.tbl_TahvilBS.EndEdit();
                this.tbl_TahvilTA.Update(this.db_DSPerson.Tbl_Tahvil);
                if (function.MsgBox("عملیات با موفقیت انجام شد آیا قصد ادامه عملیات را دارید", "توجه", MessageBoxIcon.Question) != DialogResult.OK)
                {
                    Close();
                }
            }
            else
            {

                function.MBox("رمز عبور را وارد کنید", "هشدار", MessageBoxIcon.Error);
            }

        }





    }
}
