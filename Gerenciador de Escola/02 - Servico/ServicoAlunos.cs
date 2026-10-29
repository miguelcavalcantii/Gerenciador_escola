using Gerenciador_de_Escola._03___Repositorio;

namespace Gerenciador_de_Escola._02___Servico;

//Classe responsável pelas regras de negócio dos alunos
public class ServicoAlunos
{
    private RepositorioAlunos repositorio;

    public ServicoAlunos()
    {
        repositorio = new RepositorioAlunos();
    }

    public string Adicionar(string nome, string email, string telefone, string cpf, int matricula, string curso)
    {
        if (repositorio.Consultar(matricula) != null)
        {
            return $"Já existe um aluno com a matrícula {matricula}.\n";
        }

        if (repositorio.ConsultarPorCpf(cpf) != null)
        {
            return $"Já existe um aluno com o CPF {cpf}.\n";
        }

        Aluno aluno = new Aluno(nome, email, telefone, cpf, matricula, curso);
        repositorio.Adicionar(aluno);
        return $"✓ Aluno '{nome}' cadastrado com sucesso!\n";
    }

    public string Consultar(int matricula)
    {
        Aluno? alunoConsultado = repositorio.Consultar(matricula);
        if (alunoConsultado != null)
        {
            return FormatarAluno(alunoConsultado);
        }
        else
        {
            return "Aluno não encontrado";
        }
    }

    public string Deletar(int matricula)
    {
        bool alunoDeletado = repositorio.Deletar(matricula);

        if (alunoDeletado)
        {
            return "Aluno deletado com sucesso";
        }

        return "Aluno não encontrado";
    }

    private string FormatarAluno(Aluno aluno)
    {
        return $"Matrícula: {aluno.matricula}\n" +
               $"Nome: {aluno.nome}\n" +
               $"Curso: {aluno.curso}\n" +
               $"Email: {aluno.email}\n" +
               $"Telefone: {aluno.telefone}\n" +
               $"CPF: {aluno.cpf}\n";
    }
}