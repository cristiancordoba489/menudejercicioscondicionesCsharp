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
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtevaluar_Click(object sender, EventArgs e)
        {
            Double numero;

            numero = double.Parse(txtnumero.Text);

            if (numero > 0)
            {

                LBLRESULTADO.Text = "P0SITIVO";

            }
            else if (numero < 0)
            {

                LBLRESULTADO.Text = "NEGATIVO";
            }
            else {

                LBLRESULTADO.Text = "NEUTRO - 0";
            
            }
            LBLRESULTADO.Visible = true;
        }

        private void pbsalir_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Dispose();
        }
    }
}
