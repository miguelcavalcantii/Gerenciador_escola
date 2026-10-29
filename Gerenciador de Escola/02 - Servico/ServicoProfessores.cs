using Gerenciador_de_Escola._03___Repositorio;

namespace Gerenciador_de_Escola._02___Servico;

//Classe responsável pelas regras de negócio dos professores
public class ServicoProfessores
{
    private RepositorioProfessores repositorio;

    public ServicoProfessores()
    {
        repositorio = new RepositorioProfessores();
    }

    public string Adicionar(string nome, string email, string telefone, string cpf, int id, int cargaHoraria, string formacao)
    {
        if (repositorio.Consultar(id) != null)
        {
            return $"Já existe um professor com o id {id}.\n";
        }

        if (repositorio.ConsultarPorCpf(cpf) != null)
        {
            return $"Já existe um professor com o CPF {cpf}.\n";
        }

        if (cargaHoraria <= 0)
        {
            return "A carga horária deve ser maior que zero.\n";
        }

        Professor professor = new Professor(nome, email, telefone, cpf, id, cargaHoraria, formacao);
        repositorio.Adicionar(professor);
        return $"✓ Professor '{nome}' cadastrado com sucesso!\n";
    }

    public string Consultar(int id)
    {
        Professor? professorConsultado = repositorio.Consultar(id);
        if (professorConsultado != null)
        {
            return FormatarProfessor(professorConsultado);
        }
        else
        {
            return "Professor não encontrado";
        }
    }

    public string Deletar(int id)
    {
        bool professorDeletado = repositorio.Deletar(id);

        if (professorDeletado)
        {
            return "Professor deletado com sucesso";
        }

        return "Professor não encontrado";
    }

    private string FormatarProfessor(Professor professor)
    {
        return $"Id: {professor.id}\n" +
               $"Nome: {professor.nome}\n" +
               $"Formação: {professor.formacao}\n" +
               $"Carga horária: {professor.cargaHoraria}h\n" +
               $"Email: {professor.email}\n" +
               $"Telefone: {professor.telefone}\n" +
               $"CPF: {professor.cpf}\n";
    }
}