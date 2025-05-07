using Infragistics.Win.UltraWinGrid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace DamProducer
{
    class function
    {
        //private const string DEF_BASIC_MESSAGEBOX = "BasicMessageBox";
        //private const string DEF_ADVBUTTON_MESSAGEBOX = "AdvancedButtonMessageBox";

        //-----------------------------------------------------------------------------------------
        public enum DialogType
        {
            General = 1, Numric = 2, Pass = 3
        }

        public static bool AccDateInput(string txt)
        {
            if (txt.Contains(" "))
                return false;
            else
                return true;
        }
        public static DialogResult InputBox(string title, string promptText, ref string value, DialogType DType, int Max)
        {
            Form form = new Form();
            form.Font = new Font("B Nazanin", 14, FontStyle.Regular);
            Label label = new Label();
            TextBox txtBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Text = promptText;
            txtBox.Text = value;

            buttonOk.Text = "تایید";
            buttonCancel.Text = "انصراف";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(20, 10, 372, 37);
            txtBox.SetBounds(12, 47, 372, 37);
            buttonOk.SetBounds(228, 95, 75, 37);
            buttonCancel.SetBounds(309, 95, 75, 37);

            label.AutoSize = true;
            txtBox.Anchor = txtBox.Anchor | AnchorStyles.Right;

            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.BackColor = Color.PowderBlue;
            form.ClientSize = new Size(400, 140);
            form.Controls.AddRange(new Control[] { label, txtBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;
            txtBox.MaxLength = Max;
            if (DType == DialogType.Numric)
            {
                txtBox.RightToLeft = RightToLeft.No;
                txtBox.KeyDown += new KeyEventHandler(NumKeyDown);
            }
            else if (DType == DialogType.Pass)
            {
                txtBox.PasswordChar = '*';
                txtBox.RightToLeft = RightToLeft.No;
            }
            else
            {
                txtBox.RightToLeft = RightToLeft.Yes;
            }

            DialogResult dialogResult = form.ShowDialog();
            value = txtBox.Text.Trim();
            form.Dispose();
            return dialogResult;
        }
        static void NumKeyDown(object sender, KeyEventArgs e)
        {
            if (Char.IsNumber((char)e.KeyCode) || (e.KeyData >= Keys.NumPad0 && e.KeyData <= Keys.NumPad9)
                || (e.KeyData == Keys.Enter) || (e.KeyData == Keys.Delete) || (e.KeyData == Keys.Back) || (e.KeyData == Keys.Tab))
            {
                e.SuppressKeyPress = false;
            }
            else
            {
                e.SuppressKeyPress = true;
            }
        }

        public static void MBox(string PromptText, string Title, MessageBoxIcon MIcon)
        {
            MessageBoxFa.Show(PromptText, Title, MessageBoxButtons.OK, MIcon, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
        }
        public static DialogResult MsgBox(string PromptText, string Title, MessageBoxIcon icon)
        {
            return MessageBoxFa.Show(PromptText, Title, MessageBoxButtons.OKCancel, icon, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
        }
        public static string PerDate(DateTime _date)
        {
            PersianCalendar pc = new PersianCalendar();
            StringBuilder sb = new StringBuilder();
            sb.Append(pc.GetYear(_date).ToString("0000"));
            sb.Append("/");
            sb.Append(pc.GetMonth(_date).ToString("00"));
            sb.Append("/");
            sb.Append(pc.GetDayOfMonth(_date).ToString("00"));
            return sb.ToString();
        }
        public static string pdate(DateTime _date)
        {
            PersianCalendar pc = new PersianCalendar();
            StringBuilder sb = new StringBuilder();
            sb.Append(pc.GetYear(_date).ToString("0000"));
            sb.Append(pc.GetMonth(_date).ToString("00"));
            sb.Append(pc.GetDayOfMonth(_date).ToString("00"));
            return sb.ToString();
        }

        public static bool CheckMcode(string _Mcode)
        {
            try
            {
                char[] chArray = _Mcode.ToCharArray();
                int[] numArray = new int[chArray.Length];
                for (int i = 0; i < chArray.Length; i++)
                {
                    numArray[i] = (int)char.GetNumericValue(chArray[i]);
                }
                switch (_Mcode)
                {
                    case "0000000000":
                    case "1111111111":
                    case "22222222222":
                    case "33333333333":
                    case "4444444444":
                    case "5555555555":
                    case "6666666666":
                    case "7777777777":
                    case "8888888888":
                    case "9999999999":
                        return false;
                }
                int num2 = numArray[9];
                int num3 = ((((((((numArray[0] * 10) + (numArray[1] * 9)) + (numArray[2] * 8)) + (numArray[3] * 7)) + (numArray[4] * 6)) + (numArray[5] * 5)) + (numArray[6] * 4)) + (numArray[7] * 3)) + (numArray[8] * 2);
                int num4 = num3 - ((num3 / 11) * 11);
                if ((((num4 == 0) && (num2 == num4)) || ((num4 == 1) && (num2 == 1))) || ((num4 > 1) && (num2 == Math.Abs((int)(num4 - 11)))))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }

        }
        public static void FocusCellGrid(UltraGrid UGrd, string CellName)
        {
            UltraGridCell aCell;
            aCell = UGrd.Rows[0].Cells[CellName];
            UGrd.ActiveCell = aCell;
            UGrd.Focus();
            UGrd.PerformAction(UltraGridAction.EnterEditMode, false, false);
        }




        public static bool Execute(string Query)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = DamProducer.Properties.Settings.Default.ConString;
            con.Open();
            SqlCommand cmd = new SqlCommand(Query, con);

            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {

                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public static DataTable ExecuteWithTable(string Parm)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = DamProducer.Properties.Settings.Default.ConString; ;
            con.Open();
            SqlCommand cmd = new SqlCommand();
            using (SqlDataAdapter DA = new SqlDataAdapter(Parm, con))
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                DataTable dt = new DataTable();
                DA.Fill(dt);

                con.Close();
                DA.Dispose();
                con.Dispose();
                return dt;
            }
        }

        public static DataTable SelectResid(string Parm)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = DamProducer.Properties.Settings.Default.ConString; ;
            con.Open();
            SqlCommand cmd = new SqlCommand();
            String q = "SELECT * FROM " + Parm;
            using (SqlDataAdapter DA = new SqlDataAdapter(q, con))
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                DataTable Dt = new DataTable();
                DA.Fill(Dt);

                con.Close();
                DA.Dispose();
                con.Dispose();
                return Dt;
            }
        }

        public static DataTable UGridSelectToDTable(UltraGridLayout UltraDisplay)
        {
            UltraGridBand band = UltraDisplay.Bands[0];

            DataTable dt = new DataTable();
            foreach (UltraGridColumn gridColumn in band.Columns)
            {
                dt.Columns.Add(gridColumn.Key, gridColumn.DataType);
            }

            foreach (UltraGridRow row in UltraDisplay.Rows)
            {
                if ((bool)row.Cells["select"].Value == true)
                {
                    List<object> cellValues = new List<object>(row.Cells.Count);
                    foreach (UltraGridCell cell in row.Cells)
                    {
                        cellValues.Add(cell.Value);
                    }
                    dt.Rows.Add(cellValues.ToArray());
                }
            }
            return dt;

        }

        public static DataTable UGridAllToDTable(UltraGridLayout UltraDisplay)
        {
            UltraGridBand band = UltraDisplay.Bands[0];

            DataTable dt = new DataTable();
            foreach (UltraGridColumn gridColumn in band.Columns)
            {
                dt.Columns.Add(gridColumn.Key, gridColumn.DataType);
            }
            //    (UltraGridRow row in UltraDisplay.Rows)
            foreach (UltraGridRow row in UltraDisplay.Rows.OfType<UltraGridRow>().Where(r => !r.IsFilteredOut).ToArray())
            {

                List<object> cellValues = new List<object>(row.Cells.Count);
                foreach (UltraGridCell cell in row.Cells)
                {
                    cellValues.Add(cell.Value);
                }
                dt.Rows.Add(cellValues.ToArray());
            }
            return dt;

        }

        public static void NextControl(object sender, ref KeyEventArgs e)
        {
            if ((e.KeyData == Keys.Enter))
            {
                e.SuppressKeyPress = true;
                SendKeys.Send("{TAB}");
            }
            if ((e.KeyCode == Keys.Enter && e.Modifiers == Keys.Shift))
            {
                e.SuppressKeyPress = true;
                SendKeys.Send("+{TAB}");    // + = shift  ^ = ctrl  % = Alt
            }
        }

    }
}
