using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ER4Aerea
{
    public class Reserva
    {

	    private Cliente cliente;
	    private int assentos;
	    private float preco;
	    private Voo voo;
	    private Usuario usuario;
	
	    public Reserva(Cliente cliente, int assentos, float preco, Voo voo, Usuario usuario) {
		    this.cliente = cliente;
		    this.assentos = assentos;
		    this.preco = preco;
		    this.voo = voo;
		    this.usuario = usuario;
	    }

	    public int getAssentos() {
		    return assentos;
	    }
	
	    public float getPreco(){
		    return this.preco;
	    }
	
    }
}
