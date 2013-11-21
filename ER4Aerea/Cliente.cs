using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ER4Aerea
{
    public  class Cliente:Dominio
    {
        //private  int id { get; set; }
        public  string nome { get; set; }      
        public string email { get; set; }
        public string endereco { get; set; }
        public string cpf { get; set; }
        public Cidade cidade { get; set; }
        public string sexo { get; set; }
        public int numero { get; set; }
        public string bairro { get; set; }
        public string cep { get; set; }
        public string telefone { get; set; }
        public string celular { get; set; }
        public string fax { get; set; }
        public string contato { get; set; }
        public string telefoneContato { get; set; }
        public string ocupacao { get; set; }
        public float renda { get; set; }
        public string especial { get; set; }
        public string promocao { get; set; }
        public string rg { get; set; }
        public float desconto { get; set; }

	    //private static float DESCONTO = (float) 0.3;

        public Cliente(String nome)
        {
            this.nome = nome;
        }
        
        public Boolean isEspecial()
        {
            if (this.especial == "S")
                return true;
            else
                return false;
	    }


        /*private void setEspecial(Boolean especial)
        {
		    this.especial = especial;
	    }*/

	    public  float getDesconto() {
		    return (float) (this.isEspecial() == true ? desconto : 0.0);
	    }

	    private  String getNome() {
		    return nome;
	    }

	    private  void setNome(String nome) {
		    this.nome = nome;
	    }
    }
    
}
