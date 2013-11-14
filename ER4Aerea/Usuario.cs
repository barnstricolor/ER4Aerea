using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ER4Aerea
{
    public class Usuario
    {

        private String nome;
        public Usuario(string nome) {
            this.nome = nome;
        }
        protected String getNome()
        {
            return nome;
        }

        protected void setNome(String nome)
        {
            this.nome = nome;
        }
    }
}
