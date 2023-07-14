namespace MonitoraUFRGS_APP.Models
{
  public class Aluno
  {
    // Atributos
    private int _idAluno;
    private string _nome;
    private string _curso;
    private List<string> _disciplinasMatriculadas;

    // Construtor
    public Aluno() { }

    // Metodos
    /// <summary>
    /// Faz uma requisição para marcar uma aula de monitoria.
    /// </summary>
    /// <param name="horario">Horário da aula</param>
    /// <param name="disciplina">Disciplina desejada</param>
    /// <param name="remoto">Aula remota (true) ou presencial (false)</param>
    public void requisitarAula(DateTime horario, string disciplina, bool remoto)
    {

    }

    /// <summary>
    /// Cancela uma aula que foi confirmada ou não.
    /// </summary>
    /// <param name="idAula">Identificador da aula</param>
    public void cancelarAulaAluno(int idAula)
    {

    }
  }
}
