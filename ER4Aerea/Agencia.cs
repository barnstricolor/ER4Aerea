using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ER4Aerea
{
    public class Agencia
    {
        private HashSet<Voo> voos = new HashSet<Voo>();

        public void addVoo(Voo voo)
        {
            this.voos.Add(voo);
        }

        public HashSet<Voo> obterVoos(DateTime dia, Cidade origem, Cidade destino, int qtdAssentos)
        {
            HashSet<Voo> result = new HashSet<Voo>();
		
		foreach (Voo voo in obterVoos()) 
			if (voo.atendeCondicao(dia, origem, destino, qtdAssentos))
				result.Add(voo);
		
		return result;
	}

        private HashSet<Voo> obterVoos()
        {
            VooRepositorio vooRepositorio = new VooRepositorio();
            HashSet<Voo> result=new HashSet<Voo>();

            foreach (Dominio dominio in vooRepositorio.obterTodos())
                result.Add((Voo)dominio);

            return result;
        }

        /*private HashSet<Voo> mesclar(HashSet<Voo> voos1, HashSet<Voo> voos2)
        {
            HashSet<Voo> result = new HashSet<Voo>();
		
		result.addAll(voos1);
		foreach (Voo voo in voos2) {
			if (!result.contains(voo))
				result.add(voo);
		}
		
		return result;
	}
        */
    }
}
