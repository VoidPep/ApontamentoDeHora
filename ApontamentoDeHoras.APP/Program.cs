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
        Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");
        Thread.CurrentThread.CurrentUICulture = new CultureInfo("pt-BR");

        ApplicationConfiguration.Initialize();
        Application.Run(new Form1());
    }
}