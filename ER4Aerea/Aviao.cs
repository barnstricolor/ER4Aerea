using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ER4Aerea
{
    public class Aviao:Dominio
    {
        public string modelo { get; set; }
        public int assentos { get; set; }

        public Aviao(string modelo, int assentos) {
            this.modelo = modelo;
            this.assentos = assentos;
        }
    }
}
