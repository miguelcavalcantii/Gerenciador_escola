namespace Gerenciador_de_Escola;

//Classe base com os dados comuns a todas as pessoas da escola
public class Pessoa
{
    public string nome { get; set; }
    public string email { get; set; }
    public string telefone { get; set; }
    public string cpf { get; set; }

    public Pessoa(string nome, string email, string telefone, string cpf)
    {
        this.nome = nome;
        this.email = email;
        this.telefone = telefone;
        this.cpf = cpf;
    }
}