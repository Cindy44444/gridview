using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gridview
{
    internal class Acciones
    {
        List<Hijo> listahijo = new List<Hijo>
            {
            new Hijo("BEN10",13,155,"cafes","secundaria")
            };
        public List<Hijo> MostrarHijo()
        {
            return listahijo;
        }
    }
}
