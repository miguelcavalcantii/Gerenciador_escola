namespace Gerenciador_de_Escola._03___Repositorio;

//Classe responsável em armazenar os professores em memória
public class RepositorioProfessores
{
    private List<Professor> listaProfessores = new List<Professor>();

    //CREATE - Adicionar novo Professor
    public void Adicionar(Professor professor)
    {
        listaProfessores.Add(professor);
    }

    //READ - Consultar Professor pelo id
    public Professor? Consultar(int id)
    {
        return listaProfessores.Find(professor => professor.id == id);
    }

    //READ - Consultar Professor pelo CPF
    public Professor? ConsultarPorCpf(string cpf)
    {
        return listaProfessores.Find(professor => professor.cpf == cpf);
    }

    //DELETE - Remover Professor pelo id
    public bool Deletar(int id)
    {
        Professor? professorDeletado = Consultar(id);
        if (professorDeletado != null)
        {
            return listaProfessores.Remove(professorDeletado);
        }

        return false;
    }
}