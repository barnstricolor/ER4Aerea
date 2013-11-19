using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ER4Aerea;

namespace ER4AereaTU
{
    [TestClass]
    public class TestReserva
    {
/*	    private Cliente cliente;
	    private Cliente clienteEspecial;	
	    private Cidade rao;
	    private Cidade sao;	
	    private Aviao boeing777;	
	    private Usuario usuario;	
	    private Voo raoSao777;

        [TestInitialize]
	    public void setUpTest(){
		    cliente = new Cliente("Cliente", false);
		    clienteEspecial = new Cliente("Especial", true);
		    rao = new Cidade("Ribeirão Preto","14100");
		    sao = new Cidade("São Paulo","14098");
		    boeing777 = new Aviao("Boeing 777", 5);
		    raoSao777 = new Voo(boeing777, rao, sao, new DateTime(), 100f);
            usuario = new Usuario("Teste");
	    }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        //[ExpectedException(typeof(Exception),"Assentos insuficientes.")]
        public void assentos(){
		    Assert.AreNotEqual(40, raoSao777.assentosDisponiveis());

		    this.raoSao777.novaReserva(cliente, 10, usuario);
            Assert.AreNotEqual(40, raoSao777.assentosDisponiveis());

		    raoSao777.novaReserva(clienteEspecial, 30, usuario);
            Assert.AreNotEqual(10, raoSao777.assentosDisponiveis());
	    }
        
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void assentosInsuficientes(){
		    raoSao777.novaReserva(cliente, 60, usuario);
	    }
        [TestMethod]
        [ExpectedException(typeof(Exception))]
	    public void preco(){
		    Reserva reservaNormal = raoSao777.novaReserva(cliente, 10, usuario);
            Assert.IsTrue(100 == reservaNormal.getPreco(), "Preço cheio 100,00");
		    Reserva reservaEspecial = raoSao777.novaReserva(clienteEspecial, 30, usuario);
		    Assert.AreEqual(70f , reservaEspecial.getPreco());

        }*/
    }
}