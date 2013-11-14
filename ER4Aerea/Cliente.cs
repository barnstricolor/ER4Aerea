using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ER4Aerea
{
    public  class Cliente
    {
        private  int id { get; set; }
        private  string nome { get; set; }
        
        private  Boolean promocao { get; set; }
        private  string email { get; set; }
        private  string endereco { get; set; }
        private  int cpf { get; set; }
        private  Cidade cidade { get; set; }
        private  string rg { get; set; }
        private  string sexo { get; set; }
        private  DateTime nascimento { get; set; }
        private  int numero { get; set; }
        private  string bairro { get; set; }
        private  string cep { get; set; }
        private  string telefone { get; set; }
        private  string ccelular { get; set; }
        private  string fax { get; set; }
        private  string contato { get; set; }
        private  string telefoneContato { get; set; }

    
    
	    private Boolean especial = false;
	
	    private static float DESCONTO = (float) 0.3;

        public Cliente(String nome, Boolean especial)
        {
            this.nome = nome;
            this.especial = especial;
        }
        
        private Boolean isEspecial()
        {
		    return especial;
	    }


        private void setEspecial(Boolean especial)
        {
		    this.especial = especial;
	    }

	    public  float getDesconto() {
		    return (float) (especial == true ? DESCONTO : 0.0);
	    }

	    private  String getNome() {
		    return nome;
	    }

	    private  void setNome(String nome) {
		    this.nome = nome;
	    }
    }
    
}
