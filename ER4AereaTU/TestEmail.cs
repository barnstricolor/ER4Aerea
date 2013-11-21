using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ER4Aerea;

namespace ER4AereaTU
{
    [TestClass]
    public class TestEmail
    {
        
        [TestInitialize]
        public void setup(){
           
        }

        [TestMethod]
        public void enviar()
        {
            Email email = new Email();
            email.enviar("rollan_paiva@hotmail.com");
        }
        
    }
}
