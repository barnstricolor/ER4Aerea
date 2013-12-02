using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ER4Aerea;
using ER4Aerea.Model;

namespace ER4AereaTU
{
    [TestClass]
    public class TestEF
    {
        
        [TestMethod]
        public void ef()
        {
            AviaoController controller = new AviaoController();
            controller.testeEF();
        }


    }
}