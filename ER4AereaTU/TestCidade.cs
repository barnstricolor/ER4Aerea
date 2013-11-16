using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ER4Aerea;

namespace ER4AereaTU
{
    [TestClass]
    public class TestCidade
    {
        CidadeRepositorio cidadeDAO = new CidadeRepositorio();
        
        [TestInitialize]
        public void setup(){
            Bd bd=Bd.Instance;
        }

        [TestMethod]
        public void TestCidadeDAO()
        {
            Cidade cidade=new Cidade("CIDADE NOVA","14100");
            
            cidade.cep = "14100";
            cidadeDAO.salvar(cidade);

            Assert.IsTrue(cidade.id > 0);

            cidade.nome = "Cidade Alterada";
            cidadeDAO.salvar(cidade);
            cidade = (Cidade)cidadeDAO.obter(cidade.id);
            Assert.AreEqual("Cidade Alterada",cidade.nome);
            
            cidadeDAO.excluir (cidade.id);
            cidade = (Cidade)cidadeDAO.obter(cidade.id);

            Assert.IsTrue(cidade==null);

        }
        public void TestCidadeObter()
        {
            ER4Aerea.Cidade cidade;
            cidade = (Cidade)cidadeDAO.obter(1);
            Assert.IsTrue(cidade.id==1);
        }
    }
}
