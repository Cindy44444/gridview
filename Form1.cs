using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gridview
{
    public partial class Form1 : Form
    {
        Acciones ACC = new Acciones();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            
            gvnose.DataSource = ACC.MostrarHijo();
            gvnose.DataSource = null;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (ACC.EliminarHijo(txt11.Text))
                MessageBox.Show("Eliminado con exito");
            else
                MessageBox.Show("Fallo al eliminara");
        }
    }
}
