using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EjemplomenuejercicioCondiciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Pb1_Click(object sender, EventArgs e)
        {
            //que es lo que queremos abrir
            Ejercicio1 ejercicio1 = new Ejercicio1();
            ejercicio1.Show();
            //para que se oculte la pantalla principal y solo el "ejercicio 1"
            this.Hide();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            //me permite cerrar todo el programa y que no quede abierto en el programa

            Application.Exit();
        }
    }
}
