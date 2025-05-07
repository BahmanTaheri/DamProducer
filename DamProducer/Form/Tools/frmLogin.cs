using System;
using System.Data;
using System.Windows.Forms;

namespace DamProducer
{
    public partial class frmLogin : Form
    {

        public frmLogin()
        {
            InitializeComponent();
        }
        public static DataRowView userRow;
        public static string Year;
        public static int iEtehadie = 2188;
        public static bool userValid;
        private void frmLogin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_DataSetPerson.View_Year' table. You can move, or remove it, as needed.

            userValid = false;
            this.tbl_TahvilTA.FillByUser(this.db_DSPerson.Tbl_Tahvil);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void btnEnter_Click(object sender, EventArgs e)
        {
            int ix = tblTahvilBS.Find("Code_tahvil", cmbUsers.Value);
            tblTahvilBS.Position = ix;
            userRow = (DataRowView)tblTahvilBS.Current;
            Year = view_YearTA.MaxYear();
            if ((cmbUsers.Value != null) && (userRow["Pass"].ToString() == txtpass.Text))
            {
                userValid = true;
                this.Close();
            }
            else
            {
                function.MBox("رمز عبور درست نیست", "توجه", MessageBoxIcon.Error);
            }
        }


        private void txtpass_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SendKeys.Send("{TAB}");
            }
        }


    }
}
