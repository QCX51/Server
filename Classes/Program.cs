using System;
using System.Threading;
using System.Windows.Forms;

static class Program
{
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException, true);
        AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(OnUnhandledException);

        using (Mutex mutex = new Mutex(true, Forms.Server.AppGuid, out bool IsNotRunning))
        {
            if (IsNotRunning)
            { Application.Run(new Forms.Server()); }
        }
    }

    /*
    public static byte[] StringToByteArray(string hex)
    {
        return Enumerable.Range(0, hex.Length)
                         .Where(x => x % 2 == 0)
                         .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                         .ToArray();
    }
    */

    private static void OnUnhandledException(object sender, UnhandledExceptionEventArgs EvtArgs)
    {
        Exception exception = EvtArgs.ExceptionObject as Exception;
        if (EvtArgs.IsTerminating) Classes.Protect.Stop();
        MessageBox.Show($"StackTrace:\n{exception.StackTrace}:\nMessage:\n{exception.Message}");
    }
}