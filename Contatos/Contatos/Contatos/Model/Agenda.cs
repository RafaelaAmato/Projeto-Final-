using ProjetoFinal.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace AgendaContatos
{
    public class Agenda
    {
        private List<Contato> Contatos;
        public Agenda()
        {
            Contatos = new List<Contato>();
            LoadContatos();
        }
        public void AdicionarContato(Contato contato)
        {
            Contatos.Add(contato);
            SaveContatos();
        }
        public Contato PesquisarContato(string nome)
        {
            return Contatos.Find(c => c.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
        }
        public void EditarContato(string nome, Contato novoContato)
        {
            Contato contatoExistente = PesquisarContato(nome);
            if (contatoExistente != null)
            {
                contatoExistente.Id = novoContato.Id;
                contatoExistente.Nome = novoContato.Nome;
                contatoExistente.Telefone = novoContato.Telefone;
                contatoExistente.Email = novoContato.Email;
                SaveContatos();
            }
            else
            {
                Console.WriteLine("Contato não encontrado.");
            }
        }
        public void ExcluirContato(string nome)
        {
            Contato contatoExistente = PesquisarContato(nome);

            if (contatoExistente != null)
            {
                Contatos.Remove(contatoExistente);
                SaveContatos();
            }
            else
            {
                Console.WriteLine("Contato não encontrado.");
            }
        }

        private void SaveContatos()
        {
            {
                BinaryFormatter formatter = new BinaryFormatter();
            }
        }

        private void LoadContatos()
        {
            {
                 BinaryFormatter formatter = new BinaryFormatter();
            
            }
        }

        public void ListarContatos()
        {
            foreach (var contato in Contatos)
            {
                Console.WriteLine(contato);
            }
        }
    }
}
