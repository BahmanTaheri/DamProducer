using FastReport;
using System;
using System.Data;
using System.Windows.Forms;

namespace DamProducer
{
    public partial class frmRptAmani : Form
    {
        public frmRptAmani()
        {
            InitializeComponent();
        }

        private void frmRptAmani_Load(object sender, EventArgs e)
        {
            this.view_PersonTA.Fill(this.db_DataSetResid.View_Person);


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string d1 = frmLogin.Year + "/01/01";
            string d2 = frmLogin.Year + "/12/30";


            if (function.AccDateInput(txtDate1.Text))
            {
                d1 = txtDate1.Text;
            }
            if (function.AccDateInput(txtDate2.Text))
            {
                d2 = txtDate2.Text;
            }

            this.view_AmaniTA.FillByDate(this.db_DataSetResid.View_Amani, d1, d2);

        }

        private void ultraButton1_Click(object sender, EventArgs e)
        {
            string p = string.Empty;
            Report rep = new Report();
            DataTable dt = new DataTable();
            dt = function.UGridAllToDTable(UGrid.DisplayLayout);

            if (dt.Rows.Count > 0)
            {
                p = p + "از تاریخ: " + txtDate1.Text + " تا تاریخ : " + txtDate2.Text;// + "    نام جنس: " + UComboMatter.Text;
                rep.RegisterData(dt, "View_Amani");
                rep.Load(Application.StartupPath + @"\Report\rptAmani.frx");
                rep.SetParameterValue("Parm1", p);
                rep.Show(this.MdiParent);
            }
            else
            {
                function.MBox("اطلاعاتی برای چاپ وجود ندارد", "هشدار", MessageBoxIcon.Information);
            }
        }

        private void txtDate2_KeyDown(object sender, KeyEventArgs e)
        {
            function.NextControl(sender, ref e);
        }
    }
}
