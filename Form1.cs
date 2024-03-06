using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP_Ejercicio_7
{
    public partial class Form1 : Form
    {
        private object txt_Nota1;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            int nota1, nota2, nota3, nota4, promedio;
            string situacion;

            nota1 = int.Parse(txt_Not1.Text);
            nota2 = int.Parse(txt_Nota2.Text);
            nota3 = int.Parse(txt_Nota3.Text);
            nota4 = int.Parse(txt_Nota4.Text);

            promedio = (nota1 + nota2 + nota3 + nota4) / 4;


            if (promedio >= 70)
            {
                situacion = "Aprobado";
                txt_Situacion.ForeColor = Color.Green;
            }
            else
            {
                situacion = "Reprobado";
                txt_Situacion.ForeColor = Color.Red;
            }


            txt_Promedio.Text = promedio.ToString();
            txt_Situacion.Text = situacion;
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_Not1.Clear();
            txt_Nota2.Clear();
            txt_Nota3.Clear();
            txt_Nota4.Text = string.Empty;
            txt_Promedio.Clear();
            txt_Situacion.Clear();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
