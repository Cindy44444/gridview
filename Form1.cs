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
            if (ACC.EliminarHijo(txteliminar.Text))
                MessageBox.Show("Eliminado con exito");
            else
                MessageBox.Show("Fallo al eliminara");
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (ACC.InsertarHijo(txbname2.Text, txbedad.Text, txbEstatura.Text, txbojos.Text, txbestudia.Text))
              MessageBox.Show("Agregado con exito");
            else
                MessageBox.Show("Fallo al agregado");
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (ACC.ActualizarHijo(txbname2.Text,txbedad.Text, txbEstatura.Text, txbojos.Text, txbestudia.Text))
            {
                MessageBox.Show("Actualizado con exito");
            }
            else
            {
                MessageBox.Show("fallo en actualizar");
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txbname2.Text = "";
            txbedad.Text = "";
            txbEstatura.Text = "";
            txbojos.Text = "";
            txbestudia.Text = "";
            txteliminar.Text = "";
            
        }
    }
}
