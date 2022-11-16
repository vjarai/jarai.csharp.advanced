using System.Runtime.InteropServices;

namespace Optional.DllImport
{
    public sealed class MessageBoxFassade
    {
    
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        private static extern int MessageBox(IntPtr hWnd, string text, string caption, uint type);

   
        public static void ShowMessageBox(string caption, string text)
        {
            MessageBox(IntPtr.Zero, caption, text, 0);
        }

    }
}