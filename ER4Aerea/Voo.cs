using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace ER4Aerea
{
    public class Voo:Dominio
    {
        public Aviao aviao { get; set; }
        public Cidade origem { get; set; }
        public Cidade destino { get; set; }
        public DateTime partida { get; set; }
        public float preco { get; set; }
        public DateTime chegada { get; set; }
        public HashSet<Reserva> reservas = new HashSet<Reserva>();
        public string promocao { get; set; }
	    public Voo(Aviao aviao, Cidade origem, Cidade destino, DateTime partida, float preco){
		    this.aviao = aviao;
		    this.origem = origem;
		    this.destino = destino;
	        this.partida = partida;
		    this.preco = preco;
	    }	
	
	    public Reserva novaReserva(Cliente cliente, int assentos, Usuario usuario){
		
		    if (!temDisponibilidade(assentos))			
			    throw new Exception ("Assentos insuficientes.");
		
		    Reserva reserva = new Reserva(cliente, assentos, calcularPreco(cliente.getDesconto()), this, usuario); 
		
		    reservas.Add(reserva);
		
		    return reserva;
	
	    }	
	
	    private float calcularPreco(float perDesconto){
		
		    return preco * (1 - perDesconto);
	
	    }
	
	    private Boolean temDisponibilidade(int assentos){
		
		    return assentosDisponiveis() - assentos >= 0;
	
	    }
	
	
	    public int assentosDisponiveis(){
		
		    return aviao.getAssentos() - assentosReservados();
	
	    }
	
	
	    private int assentosReservados(){
		
		    int result = 0;
		
		    foreach (Reserva reserva in reservas)
			    result += reserva.getAssentos(); 
		
			    return result;
	
		}

        public Boolean parteNaData(DateTime date)
        {
            return this.partida.Day.Equals(date.Day) &&
                this.partida.Month.Equals(date.Month) && 
                this.partida.Year.Equals(date.Year);
        }

        public Boolean mesmaOrigemDestino(Cidade origem, Cidade destino)
        {
            return origem.Equals(this.origem) && destino.Equals(this.destino);
        }

        public Boolean atendeCondicao(DateTime dia, Cidade origem, Cidade destino,
                int qtdAssentos)
        {
            return this.parteNaData(dia) &&
                    this.temDisponibilidade(qtdAssentos) &&
                    this.mesmaOrigemDestino(origem, destino);
        }
    }
}
