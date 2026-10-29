namespace Gerenciador_de_Escola;

//Aluno herda nome, email, telefone e cpf de Pessoa
public class Aluno : Pessoa
{
    public int matricula { get; set; }
    public string curso { get; set; }

    public Aluno(string nome, string email, string telefone, string cpf, int matricula, string curso)
        : base(nome, email, telefone, cpf)
    {
        this.matricula = matricula;
        this.curso = curso;
    }
}