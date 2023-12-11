using ProjetoFinal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal.Model
{
    public class Contato
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Telefone { get; set; }
        public string? Email { get; set; }

        public override string ToString()
        {
            return $"Nome: {Nome}, Telefone: {Telefone}, Email: {Email}";
        }

    }
}