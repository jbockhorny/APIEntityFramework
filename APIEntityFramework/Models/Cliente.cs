using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIEntityFramework.Models
{
    public class Cliente
    {
        /*public Cliente()
        {
            _contexto = new DbContexto();
        }
        public Cliente(DbContexto contexto)
        {
            _contexto = contexto;
        }
        */

        private static DbContexto _contexto = new DbContexto();
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }

        public void Salvar()
        {
            _contexto.Clientes.Add(this);
            _contexto.SaveChanges();
        }

        public static List<Cliente> Lista()
        {
           return  _contexto.Clientes.ToList();
        }
    }
}