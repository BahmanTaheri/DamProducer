
// VBConversions Note: VB project level imports
// End of VB project level imports

using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace DamProducer
{
    public static class MessageBoxFa
    {
#pragma warning disable CA1707 // Identifiers should not contain underscores
        public delegate int CallBack_WinProc(int uMsg, int wParam, int lParam);
#pragma warning restore CA1707 // Identifiers should not contain underscores
#pragma warning disable CA1707 // Identifiers should not contain underscores
        public delegate int CallBack_EnumWinProc(int hWnd, int lParam);
#pragma warning restore CA1707 // Identifiers should not contain underscores

        [DllImport("user32.dll")] private static extern int GetWindowLong(int hwnd, int nIndex);
        [DllImport("kernel32.dll")] private static extern int GetCurrentThreadId();
        [DllImport("user32.dll")] private static extern int SetWindowsHookEx(int idHook, CallBack_WinProc lpfn, int hmod, int dwThreadId);
        [DllImport("user32.dll")] private static extern int UnhookWindowsHookEx(int hHook);
        [DllImport("user32.dll", CharSet = CharSet.Auto)] private static extern int SetWindowText(int hwnd, string lpString);
        [DllImport("user32.dll")] private static extern int EnumChildWindows(int hWndParent, CallBack_EnumWinProc lpEnumFunc, int lParam);
        [DllImport("user32.dll")] private static extern int GetClassName(int hwnd, StringBuilder lpClassName, int nMaxCount);

        static int TopCount;
        static int ButtonCount;
        private const int GWL_HINSTANCE = (-6);
        private const int HCBT_ACTIVATE = 5;
        private const int WH_CBT = 5;
        private static int hHook;
        static string strCaption1 = "";
        static string strCaption2 = "";
        static string strCaption3 = "";


        static public DialogResult Show(string Prompt, string Title, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton DefaultButton, MessageBoxOptions options/*, MsgBoxStyle m*/)
        {
            //
            int hInst = 0;
            int Thread = 0;
            TopCount = 0;
            ButtonCount = 0;
            if ((buttons) == MessageBoxButtons.AbortRetryIgnore)
            {
                strCaption1 = "رها کردن";
                strCaption2 = "کوشش مجدد";
                strCaption3 = "چشم پوشی";
            }
            else if ((buttons) == MessageBoxButtons.OK)
            {
                strCaption1 = "تایید";
            }
            else if ((buttons) == MessageBoxButtons.OKCancel)
            {
                strCaption1 = "تایید";
                strCaption2 = "لغو";
            }
            else if ((buttons) == MessageBoxButtons.RetryCancel)
            {
                strCaption1 = "کوشش مجدد";
                strCaption2 = "لغو";
            }
            else if ((buttons) == MessageBoxButtons.YesNo)
            {
                strCaption1 = "بله";
                strCaption2 = "خیر";
            }
            else if ((buttons) == MessageBoxButtons.YesNoCancel)
            {
                strCaption1 = "بله";
                strCaption2 = "خیر";
                strCaption3 = "لغو";
            }
            else if ((buttons) == MessageBoxButtons.OK)
            {
                strCaption1 = "تایید";
            }
            //If Title = "" Then Title = Application.ProductName
            CallBack_WinProc myWndProc = new CallBack_WinProc(WinProc);
            hInst = GetWindowLong(1, GWL_HINSTANCE);
            Thread = GetCurrentThreadId();
            hHook = SetWindowsHookEx(WH_CBT, myWndProc, hInst, Thread);
            return MessageBox.Show(Prompt, Title, buttons, icon, DefaultButton, options);

            //			return Interaction.MsgBox(Prompt, buttons + icon + DefaultButton + MsgBoxStyle.MsgBoxRight + options + m, Title);
        }

        private static int WinProc(int uMsg, int wParam, int lParam)
        {
            CallBack_EnumWinProc myEnumProc = new CallBack_EnumWinProc(EnumWinProc);
            if (uMsg == HCBT_ACTIVATE)
            {
                var unused = EnumChildWindows(wParam, myEnumProc, 0);
                var unused1 = UnhookWindowsHookEx(hHook);
            }
            return 0;
        }

        private static int EnumWinProc(int hWnd, int lParam)
        {
            StringBuilder strBuffer = new StringBuilder(256);
            TopCount++;
            _ = GetClassName(hWnd, strBuffer, strBuffer.Capacity);
            string ss = strBuffer.ToString();
            if (ss.ToUpper().StartsWith("BUTTON"))
            {
                ButtonCount++;
                switch (ButtonCount)
                {
                    case 1:
                        _ = SetWindowText(hWnd, strCaption1);
                        break;
                    case 2:
                        _ = SetWindowText(hWnd, strCaption2);
                        break;
                    case 3:
                        _ = SetWindowText(hWnd, strCaption3);
                        break;
                }
            }
            return ButtonCount;
        }
    }

}
