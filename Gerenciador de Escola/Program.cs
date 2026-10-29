using Gerenciador_de_Escola._02___Servico;

namespace Gerenciador_de_Escola;

class Program
{
    static void Main(string[] args)
    {
        string opcao;
        ServicoAlunos servicoAlunos = new ServicoAlunos();
        ServicoProfessores servicoProfessores = new ServicoProfessores();

        do
        {
            Console.WriteLine("=== MENU ===");
            Console.WriteLine("1 - Cadastrar Aluno");
            Console.WriteLine("2 - Consultar Aluno");
            Console.WriteLine("3 - Deletar Aluno");
            Console.WriteLine("4 - Cadastrar Professor");
            Console.WriteLine("5 - Consultar Professor");
            Console.WriteLine("6 - Deletar Professor");
            Console.WriteLine("0 - Sair");
            Console.Write("\nEscolha uma opção: ");
            
            opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    AdicionarAluno();
                    break;
                case "2":
                    ConsultarAluno();
                    break;
                case "3":
                    DeletarAluno();
                    break;
                case "4":
                    AdicionarProfessor();
                    break;
                case "5":
                    ConsultarProfessor();
                    break;
                case "6":
                    DeletarProfessor();
                    break;
                case "0":
                    Console.WriteLine("\nSaindo do programa...");
                    break;
                default:
                    Console.WriteLine("\nOpção inválida! Pressione ENTER para tentar novamente.");
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }
        } while (opcao != "0");

        void AdicionarAluno()
        {
            Console.WriteLine("Digite o nome do aluno: ");
            string nome = Console.ReadLine();
                    
            Console.WriteLine("Digite o Email: ");
            string email = Console.ReadLine();

            Console.WriteLine("Digite o Telefone: ");
            string telefone = Console.ReadLine();

            Console.WriteLine("Digite o CPF: ");
            string cpf = Console.ReadLine();

            Console.WriteLine("Digite a matrícula do aluno: ");
            int matricula = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Curso: ");
            string curso = Console.ReadLine();

            string msgRetorno = servicoAlunos.Adicionar(nome, email, telefone, cpf, matricula, curso);
            
            Console.WriteLine(msgRetorno);
        }
        
        void ConsultarAluno()
        {
            Console.WriteLine("Digite a matrícula do aluno: ");
            int matricula = int.Parse(Console.ReadLine());

            string msgRetorno = servicoAlunos.Consultar(matricula);
            Console.WriteLine(msgRetorno);
        }
        
        void DeletarAluno()
        {
            Console.WriteLine("Digite a matrícula do aluno: ");
            int matricula = int.Parse(Console.ReadLine());

            string msgRetorno = servicoAlunos.Deletar(matricula);
            
            Console.WriteLine(msgRetorno);
        }

        void AdicionarProfessor()
        {
            Console.WriteLine("Digite o nome do professor: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite o Email: ");
            string email = Console.ReadLine();

            Console.WriteLine("Digite o Telefone: ");
            string telefone = Console.ReadLine();

            Console.WriteLine("Digite o CPF: ");
            string cpf = Console.ReadLine();

            Console.WriteLine("Digite o id do professor: ");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a carga horária (em horas): ");
            int cargaHoraria = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a formação: ");
            string formacao = Console.ReadLine();

            string msgRetorno = servicoProfessores.Adicionar(nome, email, telefone, cpf, id, cargaHoraria, formacao);

            Console.WriteLine(msgRetorno);
        }

        void ConsultarProfessor()
        {
            Console.WriteLine("Digite o id do professor: ");
            int id = int.Parse(Console.ReadLine());

            string msgRetorno = servicoProfessores.Consultar(id);
            Console.WriteLine(msgRetorno);
        }

        void DeletarProfessor()
        {
            Console.WriteLine("Digite o id do professor: ");
            int id = int.Parse(Console.ReadLine());

            string msgRetorno = servicoProfessores.Deletar(id);

            Console.WriteLine(msgRetorno);
        }
    }
}