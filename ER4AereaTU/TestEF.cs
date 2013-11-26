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
            Entities2 e = new Entities2();
            List<CIDADE> lista = new List<CIDADE>();
            IQueryable<CIDADE> cidadeQuery = from cidade in e.CIDADE
                                                select cidade;
            Console.WriteLine("Cidades:");
            foreach (var c in cidadeQuery)
            {
                Console.WriteLine(c.NOM_CIDADE);
            }
        }


    }
}