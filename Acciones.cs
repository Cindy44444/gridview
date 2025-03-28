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
            new Hijo("BEN10",13,155,"cafes","secundaria"),
            new Hijo("doralaexploradora",7,238,"cafes","primaria"),
            new Hijo("peppa",3,245,"negros","no estudia"),
            new Hijo("Thomas",8,168,"negros","no estudia"),
            new Hijo("burbuja",5,130,"azules","no estudia"),
            };
        public List<Hijo> MostrarHijo()
        {
            return listahijo;
        }
    }
}
