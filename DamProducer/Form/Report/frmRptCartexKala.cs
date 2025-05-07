using FastReport;
using Infragistics.Win.UltraWinGrid;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DamProducer
{
    public partial class frmRptCartexKala : Form
    {
        public frmRptCartexKala()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string d1 = frmLogin.Year + "/01/01";
            string d2 = frmLogin.Year + "/12/30";
            string d0 = frmLogin.Year + "/01/01";
            err.Clear();
            if (UComboMatter.Value == null)
            {
                err.SetError(UComboMatter, "ورود اجباری می باشد");
                return;
            }

            if (function.AccDateInput(txtDate1.Text))
            {
                d1 = txtDate1.Text;
            }
            if (function.AccDateInput(txtDate2.Text))
            {
                d2 = txtDate2.Text;
            }

            m = 0;
            SqlConnection Con = new SqlConnection(DamProducer.Properties.Settings.Default.ConString);
            Con.Open();
            SqlDataAdapter DA = new SqlDataAdapter("", Con);
            DA.SelectCommand.CommandType = CommandType.StoredProcedure;
            if (Con.State == ConnectionState.Closed)
                Con.Open();
            DA.SelectCommand.Parameters.Clear();
            db_DataSetGTP.Cartex.Clear();
            if (UComboMatter.Value != null)
            {
                DA.SelectCommand.CommandText = "CartexKala";
                DA.SelectCommand.Parameters.AddWithValue("@CodeMatter", UComboMatter.Value);
                DA.SelectCommand.Parameters.AddWithValue("@PerDate", d0);
                DA.SelectCommand.Parameters.AddWithValue("@DateMin", d1);
                DA.SelectCommand.Parameters.AddWithValue("@DateMax", d2);

                DA.Fill(db_DataSetGTP.Cartex);
            }


            Con.Close();
            DA.Dispose();
            Con.Dispose();

        }

        private void frmCartexKala_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'db_DataSetGTP.Tbl_Matter' table. You can move, or remove it, as needed.
            this.tbl_MatterTA.Fill(this.db_DataSetGTP.Tbl_Matter);

        }
        decimal m = 0;
        private void UGrid_InitializeRow(object sender, Infragistics.Win.UltraWinGrid.InitializeRowEventArgs e)
        {
            UltraGridBand band = this.UGrid.DisplayLayout.Bands[0];
            decimal v = 0;
            decimal k = 0;
            if (e.Row.Band == band)
            {
                try { v = (decimal)e.Row.GetCellValue(band.Columns["MgVorood"]); }
                catch { v = 0; }
                try { k = (decimal)e.Row.GetCellValue(band.Columns["MgKhorooj"]); }
                catch { k = 0; }

                m = m + v - k;
                e.Row.Cells["Mandeh"].Value = m;


            }
            UGrid.UpdateData();
        }



        private void ultraButton1_Click(object sender, EventArgs e)
        {
            //UGrid.PrintPreview();
            string p = string.Empty;
            Report rep = new Report();
            DataTable dt = new DataTable();
            dt = function.UGridAllToDTable(UGrid.DisplayLayout);

            if (dt.Rows.Count > 0)
            {
                p = p + "از تاریخ: " + txtDate1.Text + " تا تاریخ : " + txtDate2.Text + "    نام جنس: " + UComboMatter.Text;
                rep.RegisterData(dt, "View_Cartex");
                rep.Load(Application.StartupPath + @"\Report\rptCartex.frx");
                rep.SetParameterValue("Parm1", p);
                rep.Show(this.MdiParent);
            }
            else
            {
                function.MBox("اطلاعاتی برای چاپ وجود ندارد", "هشدار", MessageBoxIcon.Information);
            }

        }


        private void txtDate1_KeyDown(object sender, KeyEventArgs e)
        {
            function.NextControl(sender, ref e);
        }
    }
}
