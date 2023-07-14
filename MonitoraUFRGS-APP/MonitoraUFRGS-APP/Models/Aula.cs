namespace MonitoraUFRGS_APP.Models
{
  public class Aula
  {
    // Atributos
    private int _idAula;
    private DateTime _horaInicio, _horaFinal;
    private string _disciplina;
    private bool _confirmado;
    private bool _remoto;
    private int _idMonitor;
    private int _idAluno;

    // Construtor
    public Aula() { }

    // Metodos
    /// <summary>
    /// Atribui esta aula a um monitor
    /// </summary>
    public void atribuirMonitor()
    {

    }
  }
}
