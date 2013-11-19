using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ER4Aerea
{
    public class Usuario:Dominio
    {

        public string nome{get;set;}
        public string login { get; set; }
        public string senha { get; set; }  
        public string endereco { get; set; }
        public string cpf { get; set; }  

    }
}
