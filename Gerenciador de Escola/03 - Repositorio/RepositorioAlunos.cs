namespace Gerenciador_de_Escola._03___Repositorio;

//Classe responsável em armazenar os alunos em memória
public class RepositorioAlunos
{
    private List<Aluno> listaAlunos = new List<Aluno>();

    //CREATE - Adicionar novo Aluno
    public void Adicionar(Aluno aluno)
    {
        listaAlunos.Add(aluno);
    }

    //READ - Consultar Aluno pela matrícula
    public Aluno? Consultar(int matricula)
    {
        return listaAlunos.Find(aluno => aluno.matricula == matricula);
    }

    //READ - Consultar Aluno pelo CPF
    public Aluno? ConsultarPorCpf(string cpf)
    {
        return listaAlunos.Find(aluno => aluno.cpf == cpf);
    }

    //DELETE - Remover Aluno pela matrícula
    public bool Deletar(int matricula)
    {
        Aluno? alunoDeletado = Consultar(matricula);
        if (alunoDeletado != null)
        {
            return listaAlunos.Remove(alunoDeletado);
        }

        return false;
    }
}