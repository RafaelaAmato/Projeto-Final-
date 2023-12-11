using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetoFinal.Context;
using ProjetoFinal.Model;

namespace ProjetoFinal
{
    class ValidarProgram
    {

        private static bool VerificarUsuario(string? nomeUsuario)
        {
            // Configurar e criar uma instância do contexto do EF Core
            using (var dbContext = new AgendaContext())
            {
                // Consultar o banco de dados em busca do usuário
                var usuario = dbContext.Usuarios.FirstOrDefault(e => e.Nome == nomeUsuario);

                // Verificar se o usuário foi encontrado
                if (usuario != null)
                {
                    return true; // Usuário encontrado
                }
                else
                {
                    return false;
                }
            }
        }
        public static bool ValidarUsuario(string? nomeUsuario)
        {
            return VerificarUsuario(nomeUsuario);
        }

    }
}