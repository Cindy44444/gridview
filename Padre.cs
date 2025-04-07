using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gridview
{
    internal class Padre
    {
        public Padre() { }

        public Padre(string nombre, string edad, string estatura)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.estatura = estatura;
        }

        public string nombre { get; set; }
        public string edad { get; set; }
        public string estatura { get; set; }
        

    }
}
