using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ER4Aerea
{
    public class Cidade:Dominio
    {
        //public int id { get; set; }
        public string nome { get; set; }
        public string cep { get; set; }
        public Cidade(String nome)
        {
            /*if (string.IsNullOrEmpty(nome))
                throw new ArgumentException("Nome da cidade obrigatório!");*/
            this.nome = nome;
        }
        
    }
}
