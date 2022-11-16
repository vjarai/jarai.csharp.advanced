using System.Runtime.InteropServices;

namespace Optional.DllImport
{
    // https://learn.microsoft.com/en-us/dotnet/framework/interop/consuming-unmanaged-dll-functions
    public sealed class MessageBoxFassade
    {
    
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        private static extern int MessageBox(IntPtr hWnd, string text, string caption, uint type);

   
        public static void ShowMessageBox(string text, string title)
        {
            MessageBox(IntPtr.Zero, text, title, 0);
        }

    }
}