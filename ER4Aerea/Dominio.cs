using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ER4Aerea
{
    public class Dominio
    {
        public int id { get; set; }

        public override int GetHashCode()
        {
            if (this.id != 0)
                return this.id.GetHashCode();
            else
                return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (base.Equals(obj))
                return true;
            else if (obj is Dominio)
                return this.Equals((Dominio)obj);
            else
                return false;
            
        }

        public bool Equals(Dominio dominio) {
            if (dominio == null)
                return false;

            if (this == dominio)
                return true;

            if (this.id == 0 || dominio.id == 0)
                return false;

            return this.id.Equals(dominio.id);

        }

    }

}
