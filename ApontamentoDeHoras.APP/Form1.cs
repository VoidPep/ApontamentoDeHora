namespace ApontamentoDeHoras.APP;
public partial class Form1 : Form
{
    private bool _iniciado = false;
    private DateTime _dataAtual = DateTime.Now;
    private Thread _contadorThread;
    private TimeSpan _tempoDecorrido;

    public Form1()
    {
        Inicializar();
        CreateDataBase();
        VerificarInicioSalvo();
    }

    private void Inicializar()
    {
        InitializeComponent();
        buttonHoje_Click();
    }

    private void IniciarThreadDoTimer()
    {

    }

    private void OnForm_Load(object sender, EventArgs e)
    {

    }

    private void CreateDataBase()
    {


    }

    private void LancarHoras_Click(object sender, EventArgs e)
    {

    }

    private void DateTimePicker_ValueChanged(object sender, EventArgs e)
    {
        AtualizarDataAtual();
    }

    private void AtualizarDataAtual()
    {
        _dataAtual = dateTimePicker.Value;
    }

    private void ComecarOuPararContagem(object sender, EventArgs e)
    {
        if (!_iniciado)
        {
            Comecar(sender, e);
            return;
        }

        Parar(sender, e);
    }

    private void Comecar(object sender, EventArgs e)
    {
        if (!_iniciado)
        {
            _iniciado = true;
            Properties.Settings.Default.HorarioInicio = DateTime.Now.TimeOfDay;
            Properties.Settings.Default.Save();

            _contadorThread = new Thread(ContarTempo);
            _contadorThread.IsBackground = true;
            _contadorThread.Start();

            button_comecarOuParar.Text = "Parar";
            AlinharTextoDaContagemDeTempo();
        }

    }

    private void Parar(object sender, EventArgs e)
    {
        if (_iniciado)
        {
            _iniciado = false;
            _contadorThread?.Join();

            _tempoDecorrido = DateTime.Now.TimeOfDay - Properties.Settings.Default.HorarioInicio;
            contagemDeTempo.Text = _tempoDecorrido.ToString(@"hh\:mm\:ss");

            Properties.Settings.Default.HorarioInicio = TimeSpan.Zero;
            Properties.Settings.Default.Save();

            button_comecarOuParar.Text = "Começar";
            contagemDeTempo.Text = "00:00:00";
            AlinharTextoDaContagemDeTempo();
        }
    }

    private void buttonProximo_Click(object sender, EventArgs e)
    {
        dateTimePicker.Value = _dataAtual.Date.AddDays(1);
        AtualizarDataAtual();
    }

    private void buttonAnterior_Click(object sender, EventArgs e)
    {
        dateTimePicker.Value = _dataAtual.Date.AddDays(-1);
    }

    private void buttonHoje_Click(object sender, EventArgs e) => buttonHoje_Click();
    private void buttonHoje_Click()
    {
        dateTimePicker.Value = DateTime.Now;
        AtualizarDataAtual();
    }

    private void ContarTempo()
    {
        while (_iniciado)
        {
            Invoke(new Action(() =>
            {
                var tempoAtual = DateTime.Now.TimeOfDay - Properties.Settings.Default.HorarioInicio;
                contagemDeTempo.Text = tempoAtual.ToString(@"hh\:mm\:ss");
            }));
            Thread.Sleep(1000);
        }
    }

    private void VerificarInicioSalvo()
    {
        if (Properties.Settings.Default.HorarioInicio != TimeSpan.Zero)
        {
            _iniciado = true;
            _contadorThread = new Thread(ContarTempo);
            _contadorThread.IsBackground = true;
            _contadorThread.Start();
        }
    }
}
