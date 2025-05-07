using System;
using System.Windows.Forms;

namespace DamProducer
{
    public partial class frmFastPerson : Form
    {
        public frmFastPerson()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            txtName.Text = txtName.Text.Trim();
            txtPostCode.Text = txtPostCode.Text.Trim();
            txtCode.Text = txtCode.Text.Trim();
            txtEco.Text = txtEco.Text.Trim();
            txtAdress.Text = txtAdress.Text.Trim();
            txtMobile.Text = txtMobile.Text.Trim();
            if (string.IsNullOrEmpty(txtName.Text))
            {
                txtName.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtCode.Text))
            {
                txtName.Focus();
                return;
            }
            if ((!function.CheckMcode(txtCode.Text)) && (txtCode.MaxLength == 10))
            {
                function.MBox("کد ملی اشتباه ثبت شده اصلاح کنید", "توجه", MessageBoxIcon.Error);
                txtCode.Focus();
                return;

            }
            if (string.IsNullOrEmpty(CmbPtype.Text))
            {
                CmbPtype.Focus();
                return;
            }
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
