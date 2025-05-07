using System;
using System.Windows.Forms;

namespace DamProducer
{
    public partial class frmSelectYear : Form
    {
        public string yr;
        public frmSelectYear()
        {
            InitializeComponent();
        }

        private void ubtnComite_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmSelectYear_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_DataSetPerson.View_Year' table. You can move, or remove it, as needed.
            this.view_YearTA.Fill(this.db_DataSetPerson.View_Year);
            CmbYear.Text = frmLogin.Year;

        }

        private void frmSelectYear_FormClosed(object sender, FormClosedEventArgs e)
        {
            yr = CmbYear.Value.ToString();
        }
    }
}
