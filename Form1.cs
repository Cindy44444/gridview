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
            gvnose.DataSource = null;
            gvnose.DataSource = ACC.MostrarHijo();
            
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (ACC.EliminarHijo(txt11.Text))
                MessageBox.Show("Eliminado con exito");
            else
                MessageBox.Show("Fallo al eliminara");
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (ACC.InsertarHijo(txbname2.Text, Convert.ToInt32(txbedad.Text), Convert.ToInt32(txbEstatura.Text), txbojos.Text, txbestudia.Text)
              MessageBox.Show("Agregado con exito");
            else
                MessageBox.Show("Fallo al agregado");
        }
    }
}
