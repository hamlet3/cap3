using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios_Cap3
{
    public partial class Form1 : Form
    {
        double numero;
        double resultado;
        double impuesto;
        int dia;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcesar1_Click(object sender, EventArgs e)
        {
            numero = double.Parse(txtNumero.Text);
            if (numero % 2 == 0)
            {
                labelResultado1.Text = "Este numero es par";
            }
            else
            {
                labelResultado1.Text = "Este numero es impar";
            }
        }

        private void comboBoxGradosRadiales_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxGradosRadiales.Text == "Grados")
            {
                labelTexto.Text = "Introducir Radiales";
            }
            if (comboBoxGradosRadiales.Text == "Radiales")
            {
                labelTexto.Text = "Introducir Grados";
            }

        }

        private void btnProcesar2_Click(object sender, EventArgs e)
        {
            if (comboBoxGradosRadiales.Text == "Radiales")
            {
                resultado = (double.Parse(txtCantidad.Text)*3.1416) / 180;
            }
            if (comboBoxGradosRadiales.Text == "Grados")
            {
                resultado = (double.Parse(txtCantidad.Text) * 180)/3.1416 ;
            }
            labelResultado2.Text = resultado.ToString();
        }

        private void tabImpuestos_Click(object sender, EventArgs e)
        {

        }

        private void btnProcesar3_Click(object sender, EventArgs e)
        {

            if(txtProducto.Text == "Medicina" || txtProducto.Text == "medicina")
            {
                impuesto = 0;
                
            }
            else
            {

                impuesto = double.Parse(txtValorProducto.Text);
                impuesto *= 0.10;

            }
            labelResultado3.Text = impuesto.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dia = int.Parse(txtNumeroDia.Text);
            switch (dia) {
                case 1:
                    labelResultado4.Text = "Domingo";
                    break;
                case 2:
                    labelResultado4.Text = "Lunes";
                    break;
                case 3:
                    labelResultado4.Text = "Martes";
                    break;
                case 4:
                    labelResultado4.Text = "Miercoles";
                    break;
                case 5:
                    labelResultado4.Text = "Jueves";
                    break;
                case 6:
                    labelResultado4.Text = "Viernes";
                    break;
                case 7:
                    labelResultado4.Text = "Sabado";
                    break;
                default :
                    labelResultado4.Text = "¡¡DEL 1 AL 7 DIJE!!";
                    break;
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
