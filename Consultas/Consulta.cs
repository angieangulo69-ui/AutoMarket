/*
Universidad:UNED
I Cuatrimestre
Proyecto: AutoMarket
Descripción: Clase que representa un cliente, con propiedades para el ID, identificación, 
nombre completo, fecha de nacimiento, fecha de registro y estado activo. Incluye un constructor 
para inicializar estas propiedades y un método ToString para mostrar la informacióndel cliente 
de manera legible. Esta clase se utilizará para gestionar los clientes del sistema,
con validaciones para campos vacíos, ID único y límite de registros.
Estudiante: Angie Angulo Chacón 
Fecha:22/02/2026
*/
using AutoMarket.Consultas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoMarket
{
    public partial class Consulta : Form
    {
        public Consulta()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Llamo a la ventana principal del menu
            Form1 Menu = new Form1();
           Menu.Show();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            //Salir de la aplicacion
            Application.Exit();
        }

        private void btn_cateVehiculo_Click(object sender, EventArgs e)
        {
            //Llamo a la ventana de consulta de categoria de vehiculos
            ConsultaCateVehiculo Consulta_CAtegoriaVehiculos = new ConsultaCateVehiculo();
            Consulta_CAtegoriaVehiculos.Show();
            this.Close(); //Cierra la ventana actual
        }

        private void btn_vehiculo_Click(object sender, EventArgs e)
        { //Llamo a la ventana de consulta de vehiculos
            ConsultaVehiculos Consulta_Vehiculos = new ConsultaVehiculos();
            Consulta_Vehiculos.Show();
            this.Close(); //Cierra la ventana actual

        }

        private void btn_vendedor_Click(object sender, EventArgs e)
        {
            // Llamo a la ventana de consulta de vehiculos
            ConsultaVendedores Consulta_Vendedores = new ConsultaVendedores();
            Consulta_Vendedores.Show();
            this.Close(); //Cierra la ventana actual
        }

        private void btn_sucursal_Click(object sender, EventArgs e)
        { // Llamo a la ventana de consulta de sucursales
            ConsultaSucursales Consulta_Sucursales = new ConsultaSucursales();
            Consulta_Sucursales.Show();
            this.Close(); //Cierra la ventana actual

        }

        private void btn_cliente_Click(object sender, EventArgs e)
        {
            // Llamo a la ventana de consulta de sucursales
            ConsultaClientes Consulta_Clientes = new ConsultaClientes();
            Consulta_Clientes.Show();
            this.Close(); //Cierra la ventana actual
        }

        private void btn_vehiculosSucursal_Click(object sender, EventArgs e)
        {
            // Llamo a la ventana de consulta de sucursales
            ConsultaVehiculoSucursal Consulta_Vehiculo_Sucursal = new ConsultaVehiculoSucursal();
            Consulta_Vehiculo_Sucursal.Show();
            this.Close(); //Cierra la ventana actual
        }
    }
    
}
