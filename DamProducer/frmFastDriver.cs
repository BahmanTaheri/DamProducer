using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DamProducer
{
    public partial class frmFastDriver : Form
    {
        public frmFastDriver()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            txtName.Text = txtName.Text.Trim();
            txtCarNum.Text = txtCarNum.Text.Trim();
            txtCode.Text = txtCode.Text.Trim();
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

            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
