using System;
using System.Windows.Forms;

namespace Jarai.CSharp.Async.Winforms
{
    internal class BusyIndicator : IDisposable
    {
        private readonly Form _form;
        private readonly Cursor _oldCursor;

        public BusyIndicator(Form form)
        {
            _form = form;
            _oldCursor = Cursor.Current;

            Cursor.Current = Cursors.WaitCursor;
            _form.UseWaitCursor = true;
        }


        public void Dispose()
        {
            _form.UseWaitCursor = false;
            Cursor.Current = _oldCursor;
        }
    }
}