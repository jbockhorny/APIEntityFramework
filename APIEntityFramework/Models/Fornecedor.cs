using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIEntityFramework.Models
{
    public class Fornecedor
    {
        private static DbContexto _db = new DbContexto();

        public int Id { get; set; }
        public string Nome { get; set; }
        public string CNPJ { get; set; }

        public bool Salvar()
        {
            try
            {
                _db.Fornecedores.Add(this);
                _db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}