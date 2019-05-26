using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{    // se define la clase proceso como 
    //publica para que pueda ser reconocida por las otras clases
    public class Proceso
    {
        public double var1, var2, var3;  // variables para operadores y resultado

        public void Suma()
        {
            var3 = var1 + var2;
        }
        public void Resta()
        {
            var3 = var1 - var2;
        }
        public void Multi()
        {
            var3 = var1 * var2;
        }
        public void Divide()
        {
            var3 = var1 / var2;
        }

    }
}
