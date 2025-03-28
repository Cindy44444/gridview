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
        public Padre(string nombre, int edad, int estatura)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.estatura = estatura;
        }

        public string nombre { get; set; }
        public int edad { get; set; }
        public int estatura { get; set; }
        

    }
}
