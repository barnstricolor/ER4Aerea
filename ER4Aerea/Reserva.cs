using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ER4Aerea
{
    public class Reserva:Dominio
    {

	    public Cliente cliente;
        public int assentos;
        public float preco;
        public Voo voo;
        public Usuario usuario;
	
	    public Reserva(Cliente cliente, int assentos, float preco, Voo voo, Usuario usuario) {
		    this.cliente = cliente;
		    this.assentos = assentos;
		    this.preco = preco;
		    this.voo = voo;
		    this.usuario = usuario;
	    }

    }
}
