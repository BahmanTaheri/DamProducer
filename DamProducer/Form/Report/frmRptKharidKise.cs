using FastReport;
using System;
using System.Data;
using System.Windows.Forms;

namespace DamProducer
{
    public partial class frmRptKharidKise : Form
    {
        public frmRptKharidKise()
        {
            InitializeComponent();
        }

        private void frmRptKharidKise_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_DataSetResid.View_Person' table. You can move, or remove it, as needed.
            this.view_PersonTA.Fill(this.db_DataSetResid.View_Person);

            string d1 = frmLogin.Year + "/01/01";
            string d2 = frmLogin.Year + "/12/30";
            this.view_BagsTA.FillByDate(this.db_DataSetGTP.View_Bags, d1, d2);



        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            CmbPRS.Text = CmbPRS.Text.Trim();
            string d1 = frmLogin.Year + "/01/01";
            string d2 = frmLogin.Year + "/12/30";
            if (function.AccDateInput(txtDate1.Text)) { d1 = txtDate1.Text; }
            if (function.AccDateInput(txtDate2.Text)) { d2 = txtDate2.Text; }

            if (string.IsNullOrEmpty(CmbPRS.Text))
            {
                this.view_BagsTA.FillByDate(this.db_DataSetGTP.View_Bags, d1, d2);
            }
            else
            {
                this.view_BagsTA.FillByPerson(this.db_DataSetGTP.View_Bags, d1, d2, (int)CmbPRS.Value);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Report rep = new Report();
            rep.Load(Application.StartupPath + @"\Report\rptKharidKise.frx");

            DataTable dt = new DataTable();
            dt = function.UGridAllToDTable(UGrid.DisplayLayout);
            rep.RegisterData(dt, "View_Bags");
            // rep.RegisterData((DataTable)this.db_DataSetGTP.View_Bags, "View_Bags");
            rep.SetParameterValue("D1", txtDate1.Text);
            rep.SetParameterValue("D2", txtDate2.Text);
            rep.Show(this.MdiParent);
        }

        private void txtDate1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SendKeys.Send("{TAB}");
            }
        }
    }
}
