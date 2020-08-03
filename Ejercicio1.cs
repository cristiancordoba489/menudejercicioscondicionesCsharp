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
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }

        private void Btnevaluar_Click(object sender, EventArgs e)
        {
            double numero1, numero2;

            numero1 = double.Parse(txtnumero1.Text);
            numero2 = double.Parse(txtnumero1.Text);

            if (numero1 > numero2)
            {

                Lblresultado.Text = "El primer numero es el mayor";

            }
            else if (numero2> numero1) {

                Lblresultado.Text = "el segundo numero es mayor";

            }
            else  {

                Lblresultado.Text = "Los numeros son iguales";

            }


            //me muestra el  si es mayor despues de presionar el boton
            Lblresultado.Visible = true;
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            //para cuando le de salir me mande a la pantalla de inicio
            this.Dispose();
        }
    }
}
