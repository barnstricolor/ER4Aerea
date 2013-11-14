using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ER4Aerea;

namespace ER4AereaTU
{
    [TestClass]
    public class TestAviao
    {
        AviaoRepositorio aviaoDAO = new AviaoRepositorio();
        
        [TestInitialize]
        public void setup(){
            Bd bd=Bd.Instance;
        }

        [TestMethod]
        public void TestAviaoDAO()
        {
            Aviao aviao=new Aviao("747",5);
            
            aviaoDAO.salvar(aviao);

            Assert.IsTrue(aviao.id > 0);

            aviao.modelo = "Boing";
            aviaoDAO.salvar(aviao);

            aviao = (Aviao)aviaoDAO.obter(aviao.id);
            Assert.AreEqual("Boing", aviao.modelo);
            
            /*aviaoDAO.excluir (aviao.id);
            aviao = (Aviao)aviaoDAO.obter(aviao.id);

            Assert.IsTrue(aviao==null);*/

        }
        public void TestAviaoObter()
        {
            Aviao aviao;
            aviao = (Aviao)aviaoDAO.obter(1);
            Assert.IsTrue(aviao.id==1);
        }
    }
}
