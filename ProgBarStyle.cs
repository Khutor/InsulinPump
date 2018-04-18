using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

//Tyler Clark
//Alexander Marquette

public class FixedProgressBar : ProgressBar
{
    public InsulinPump.Form1 Form1
    {
        get => default(InsulinPump.Form1);
        set
        {
        }
    }

    [DllImportAttribute("uxtheme.dll")]
    private static extern int SetWindowTheme(IntPtr hWnd, string appname, string idlist);

    protected override void OnHandleCreated(EventArgs e)
    {
        SetWindowTheme(this.Handle, "", "");
        base.OnHandleCreated(e);
    }
}