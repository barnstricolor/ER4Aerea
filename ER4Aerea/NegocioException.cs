using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ER4Aerea
{
    public class NegocioException:Exception
    {
        public NegocioException(string message):
            base(message){
        
        }
    }
}
