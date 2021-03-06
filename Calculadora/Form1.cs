﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*  WRITTEN AND DIRECTED BY ALVARO GARCIA HERRERO.
 *  Calculadura que suma, resta, divide, multiplica, x al cuadrado y al cubo
 * hace porcentajes y tiene un boton de limpiar los números de la consola.
 * Cuando se quiere hacer una operacion con solo un número(raiz cuadrada...)
 * Se pulsa el numero, luego el icono de raiz y luego el "=" :D.
 */
namespace Calculadora
{
    public partial class Form1 : Form
    {
        //aquí declaro las variables de instancia

        //operando1 guardará el primer número
        double operando1 = 0;
        //en el string operación guardo la operación
        //que ha sido pulsada
        String operacion = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void numeros(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            if (label1.Text == "0")
            {
                label1.Text = boton.Text;
            }
            else
            {
                label1.Text = label1.Text + boton.Text;
            }
        }

        private void operaciones(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            operacion = boton.Text;
            operando1 = Convert.ToDouble(label1.Text);
            label1.Text = "0";  
        }

        private void igual(object sender, EventArgs e)
        {
            double operando2 = Convert.ToDouble(label1.Text);
            double resultado = 0;
            if (operacion == "+")
            {
                resultado = operando1 + operando2;
            }
            else if (operacion == "-")
            {
                resultado = operando1 - operando2;
            }
            else if (operacion == "*")
            {
                resultado = operando1 * operando2;
            }
            else if (operacion == "/")
            {
                resultado = operando1 / operando2;
            }
            else if(operacion == "X²")
            {
                resultado = operando1 * operando1;
            }
            else if (operacion == "X³")
            {
                resultado = operando1 * operando1 * operando1;
            }
            else if (operacion == "%")
            {
                resultado = operando1 * operando2;
                resultado /= 100;
            }
            else if (operacion == "√")
            {
                resultado = Math.Sqrt(operando1);
            }
            label1.Text = Convert.ToString(resultado);
        }

        private void borrar(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            label1.Text = "0";
        }
    }
}
