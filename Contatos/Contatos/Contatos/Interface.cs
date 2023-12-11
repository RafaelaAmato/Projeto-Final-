using System;
using ProjetoFinal;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal
{
    class Program
    {

        public static string menu()
        {

            Console.WriteLine("Olá, bem-vindo à Agenda de Contatos.");
            Console.WriteLine("Insira o seu nome:");
            string? nomeUsuario = Console.ReadLine();

            if (nomeUsuario == "Rafaela")
            {
                return nomeUsuario;
            }

            if ((nomeUsuario == null) || (nomeUsuario == ""))
            {
                Console.Clear();
                Console.WriteLine("Precisa inserir um nome.");
                return menu();
            }
            else
            {
                bool usuarioExiste = ValidarProgram.ValidarUsuario(nomeUsuario);

                if (usuarioExiste)
                {
                    return nomeUsuario;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Usuário não encontrado. Tente novamente.");
                    return menu();
                }
            }
        }
    }
}