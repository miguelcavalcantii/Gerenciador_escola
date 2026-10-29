namespace Gerenciador_de_Escola;

//Professor herda nome, email, telefone e cpf de Pessoa
public class Professor : Pessoa
{
    public int id { get; set; }
    public int cargaHoraria { get; set; }
    public string formacao { get; set; }

    public Professor(string nome, string email, string telefone, string cpf, int id, int cargaHoraria, string formacao)
        : base(nome, email, telefone, cpf)
    {
        this.id = id;
        this.cargaHoraria = cargaHoraria;
        this.formacao = formacao;
    }
}