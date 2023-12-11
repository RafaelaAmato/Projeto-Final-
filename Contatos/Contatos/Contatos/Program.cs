using ProjetoFinal.Model;
using System;

namespace AgendaContatos
{
    class Program
    {
        static void Main(string[] args)
        {
            Agenda agenda = new Agenda();
            Console.WriteLine("Olá, bem-vindo à Agenda de Contatos.");
       
            while (true)
            {
                Console.WriteLine("\n=== Agenda de Contatos ===");
                Console.WriteLine("O que deseja fazer?");
                Console.WriteLine("1 - Adicionar Contato");
                Console.WriteLine("2 - Pesquisar Contato");
                Console.WriteLine("3 - Editar Contato");
                Console.WriteLine("4 - Excluir Contato");
                Console.WriteLine("5 - Listar Contatos");
                Console.WriteLine("0 - Sair");

                Console.Write("Escolha uma opção: ");
                string escolha = Console.ReadLine();

                switch (escolha)
                {
                    case "1":
                        AdicionarContato(agenda);
                        break;
                    case "2":
                        PesquisarContato(agenda);
                        break;
                    case "3":
                        EditarContato(agenda);
                        break;
                    case "4":
                        ExcluirContato(agenda);
                        break;
                    case "5":
                        ListarContatos(agenda);
                        break;
                    case "0":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }

        static void AdicionarContato(Agenda agenda)
        {
            Contato novoContato = new Contato();

            Console.Write("Nome: ");
            novoContato.Nome = Console.ReadLine();

            Console.Write("Telefone: ");
            novoContato.Telefone = Console.ReadLine();

            Console.Write("Email: ");
            novoContato.Email = Console.ReadLine();

            agenda.AdicionarContato(novoContato);
            Console.WriteLine("Contato adicionado com sucesso!");
        }

        static void PesquisarContato(Agenda agenda)
        {
            Console.Write("Digite o nome do contato a ser pesquisado: ");
            string nome = Console.ReadLine();

            Contato contatoEncontrado = agenda.PesquisarContato(nome);

            if (contatoEncontrado != null)
            {
                Console.WriteLine("Contato encontrado:");
                Console.WriteLine(contatoEncontrado);
            }
            else
            {
                Console.WriteLine("Contato não encontrado.");
            }
        }

        static void EditarContato(Agenda agenda)
        {
            Console.Write("Digite o nome do contato a ser editado: ");
            string nome = Console.ReadLine();

            Contato novoContato = new Contato();

            Console.Write("Novo nome: ");
            novoContato.Nome = Console.ReadLine();

            Console.Write("Novo telefone: ");
            novoContato.Telefone = Console.ReadLine();

            Console.Write("Novo email: ");
            novoContato.Email = Console.ReadLine();

            agenda.EditarContato(nome, novoContato);
            Console.WriteLine("Contato editado com sucesso!");
        }

        static void ExcluirContato(Agenda agenda)
        {
            Console.Write("Digite o nome do contato a ser excluído: ");
            string nome = Console.ReadLine();

            agenda.ExcluirContato(nome);
            Console.WriteLine("Contato excluído com sucesso!");
        }

        static void ListarContatos(Agenda agenda)
        {
            Console.WriteLine("\n=== Lista de Contatos ===");
            agenda.ListarContatos();
        }
    }
}
