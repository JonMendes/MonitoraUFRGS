namespace MonitoraUFRGS_APP.Models
{
  public class Monitor
  {
    // Atributos
    private int _idAluno;
    private string _nome;
    private string _curso;
    private string _disciplinaMonitoria;
    private List<Tuple<DateTime, DateTime>> _horariosDisponiveis;
    private int _idOrientador;

    // Construtor
    public Monitor() { }

    // Metodos
    /// <summary>
    /// Confirma uma aula que foi requisitada por um aluno.
    /// </summary>
    /// <param name="idAula">Identificador da aula</param>
    public void confirmarAula(int idAula)
    {

    }

    /// <summary>
    /// Cancela uma aula que foi requisitada por um aluno.
    /// </summary>
    /// <param name="idAula">Identificador da aula</param>
    public void cancelarAulaMonitor(int idAula)
    {

    }
  }
}
