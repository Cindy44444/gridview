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
            new Hijo("BEN10","13","155","cafes","secundaria"),
            new Hijo("doralaexploradora","7","238","cafes","primaria"),
            new Hijo("peppa","3","245","negros","no estudia"),
            new Hijo("Thomas","8","168","negros","no estudia"),
            new Hijo("burbuja","5","130","azules","no estudia"),
            };
        Hijo a = new Hijo();
        public List<Hijo> MostrarHijo()
        {
            return listahijo;
        }
        public bool InsertarHijo(string nombre, string edad, string estatura, string colorojos, string estudia)
        {
            try
            {
                listahijo.Add(new Hijo(a.nombre = nombre, a.edad = edad, a.estatura = estatura, a.colorojos = colorojos, a.estudia = estudia));
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }
        public bool EliminarHijo (string nombre)
        {
            try
            {
                var objetoeliminar = listahijo.Find(x => x.nombre == nombre);
                if (objetoeliminar != null)
                {
                    listahijo.Remove(objetoeliminar);
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool ActualizarHijo(string nombre, string edad, string estatura, string colorojos, string estudia)
        {
            try
            {
                var objetoeliminar = listahijo.Find(x => x.nombre == nombre);
                objetoeliminar.nombre = nombre;
                objetoeliminar.edad = edad;
                objetoeliminar.estatura =estatura;
                objetoeliminar.colorojos = colorojos;
                objetoeliminar.estudia = estudia;
                return true;
            }
            catch(Exception)
            {
                return false ;
            }
        }

        internal bool EliminarHijo(object v)
        {
            throw new NotImplementedException();
        }
    }
}
