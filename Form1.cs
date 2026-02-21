using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* 
 *UNED - Ingeniería en Informatica 
 *Estudiante: Angie Angulo Chacon 
 * Fecha: 22/02/2026
 * Descripción: AutoMarket, que permite a los usuarios acceder a las 
 * funciones de registro y consulta de vehículos.
 
 */
namespace AutoMarket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            //Llamo a la ventana de registro
            Registros registrosForm = new Registros();
            registrosForm.Show(); // Asegúrate de que Registros hereda de Form
        }

        private void btn_salir_Click(object sender, EventArgs e)
        { //Salir de la aplicacion
            Application.Exit();
        }

        private void btn_Consultar_Click(object sender, EventArgs e)
        {
            //Llamo a la ventana de consultas
           Consulta Consultas = new Consulta();
            Consultas.Show();
        }
    }
}
