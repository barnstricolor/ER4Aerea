using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ER4Aerea;

namespace ER4AereaTU
{
    [TestClass]
    public class TestTwitter
    {
        
        [TestInitialize]
        public void setup(){
           
        }

        [TestMethod]
        public void postar()
        {
            Twitter twitter = new Twitter();
            twitter.postar("Teste");
        }
        
    }
}
