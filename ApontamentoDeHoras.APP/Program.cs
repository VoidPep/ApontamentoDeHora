using System.Globalization;

namespace ApontamentoDeHoras.APP;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        AppDomain.CurrentDomain.SetData("DataDirectory", AppDomain.CurrentDomain.BaseDirectory);

        Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");
        Thread.CurrentThread.CurrentUICulture = new CultureInfo("pt-BR");

        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        ApplicationConfiguration.Initialize();
        Application.Run(new MainForm());
    }
}