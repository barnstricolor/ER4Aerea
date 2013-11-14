using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace ER4Aerea
{
    public class Voo
    {
        public DateTime chegada { get; set; }

        private Aviao aviao { get; set; }
        private Cidade origem { get; set; }
        private Cidade destino { get; set; }
        private DateTime partida { get; set; }
        private float preco { get; set; }
        private HashSet<Reserva> reservas = new HashSet<Reserva>();
	
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
		
		    return assentosDisponiveis() - assentos > 0;
	
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
	
        public OleDbDataReader listar()
        {
            Bd persistencia = Bd.Instance;
            
            OleDbDataReader dr; 
            string str;

            str = "Select 'Ida' Tipo,'De: '||C.NOM_CIDADE De,' Para: '||D.NOM_CIDADE Para,VAL_PRECO Valor,E.NOM_MODELO Avião,E.QTD_ASSENTO Assento"; 
            str +=" from CAD_VOO A,CAD_TRECHO B,CAD_CIDADE C,CAD_CIDADE D,CAD_AVIAO E";
            str +=" Where A.ID_TRECHO = B.ID_TRECHO";
            str += " And B.ID_ORIGEM = C.ID_CIDADE";
            str += " And B.ID_DESTINO = D.ID_CIDADE";
            str += " And A.ID_AVIAO = E.ID_AVIAO";
            //if (origem > 0)                str+=" And B.ID_ORIGEM = " + origem;
            //if (destino > 0)                str += " And B.ID_DESTINO = " + destino;
            if (partida!=null)
                str += " And A.DAT_PARTIDA = TO_DATE(" + persistencia.aspas(partida.ToString()) + ",'DD/MM/YYYY HH24:MI:SS')";
            //if (chegada!= null)
                //str += " And A.DAT_CHEGADA <= TO_DATE(" + persistencia.aspas(chegada.ToString()) + ",'DD/MM/YYYY HH24:MI:SS')";
            str += " Union ";
            str += "Select 'Volta' Tipo,'De: '||C.NOM_CIDADE De,' Para: '||D.NOM_CIDADE Para,VAL_PRECO Valor,E.NOM_MODELO Avião,E.QTD_ASSENTO Assento";
            str += " from CAD_VOO A,CAD_TRECHO B,CAD_CIDADE C,CAD_CIDADE D,CAD_AVIAO E";
            str += " Where A.ID_TRECHO = B.ID_TRECHO";
            str += " And B.ID_ORIGEM = C.ID_CIDADE";
            str += " And B.ID_DESTINO = D.ID_CIDADE";
            str += " And A.ID_AVIAO = E.ID_AVIAO";
            //if (destino > 0)                str += " And B.ID_ORIGEM = " + destino;
            //if (origem > 0)                str += " And B.ID_DESTINO = " + origem;
            if (chegada != null)
                str += " And A.DAT_PARTIDA = TO_DATE(" + persistencia.aspas(chegada.ToString()) + ",'DD/MM/YYYY HH24:MI:SS')";
            //if (partida != null)
                //str += " And A.DAT_CHEGADA <= TO_DATE(" + persistencia.aspas(partida.ToString()) + ",'DD/MM/YYYY HH24:MI:SS')";
            
            dr = persistencia.obterQuery(str);
            //dr.Close();

            return dr;
        
        }

    }
}
