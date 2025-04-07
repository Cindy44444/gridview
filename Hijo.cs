using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gridview
{
    internal class Hijo : Padre
    {
        public Hijo () { }
        public Hijo(string nombre, string edad, string estatura,string colorojos, string estudia)
        :base(nombre, edad, estatura)
        {
            this.colorojos = colorojos;
            this.estudia = estudia;
        }

        public string colorojos {  get; set; }
        public string estudia { get; set; }
    }
}
