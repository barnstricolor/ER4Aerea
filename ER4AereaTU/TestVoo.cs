using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ER4Aerea;

namespace ER4AereaTU
{
    [TestClass]
    public class TestVoo
    {
        private Cliente cliente;
        //private Cliente clienteEspecial;
        //private Cidade rao;
        //private Cidade sao;
        //private Aviao boeing777;
        private Usuario usuario;
        private Voo raoSao;
        private Voo saoRao777;
        private Agencia agencia;
        private VooRepositorio vooRepositorio;
        [TestInitialize]
        public void setUpTest()
        {
            cliente = new Cliente("Cliente");
            new ClienteRepositorio().salvar(cliente);

            vooRepositorio = new VooRepositorio();
            raoSao = (Voo)vooRepositorio.obter(1);
            saoRao777 = (Voo)vooRepositorio.obter(2);

            UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
            usuario = new Usuario();
            usuario.nome = "Teste";
            usuario.login = "login";
            usuario.senha = "senha";
            usuarioRepositorio.salvar(usuario);

            agencia = new Agencia();
            agencia.addVoo(raoSao);
            agencia.addVoo(saoRao777);
        }

        [TestMethod]
        public void NovaReserva()
        {
            raoSao.novaReserva(cliente, 1, usuario);
            vooRepositorio.salvar(raoSao);
            raoSao = (Voo)vooRepositorio.obter(raoSao.id);
            Assert.IsTrue(raoSao.reservas.Count > 0);
        }
        [TestMethod]
        public void testaAgencia()
        {
            CidadeRepositorio cidadeRepositorio=new CidadeRepositorio();
            Agencia agencia = new Agencia();
            Cidade origem=(Cidade)cidadeRepositorio.obter(1);
            Cidade destino=(Cidade)cidadeRepositorio.obter(2);
            Assert.IsTrue(agencia.obterVoos(new DateTime(2013,11,18), origem, destino, 1).Count>0);

        }

    }
}