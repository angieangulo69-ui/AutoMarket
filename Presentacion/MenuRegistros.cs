/*
Universidad:UNED
I Cuatrimestre
Proyecto: AutoMarket
Descripción: Ventana principal del menú de registros, que permite acceder a diferentes 
formularios para registrar categorías de vehículos, vehículos, vendedores, sucursales, 
clientes y asociar vehículos a sucursales. Incluye botones para navegar entre las ventanas y 
salir de la aplicación. Al hacer clic en cada botón,se abre la ventana correspondiente y 
se cierra la ventana actual para mantener una navegación fluida.
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

namespace AutoMarket.Registros
{
    public partial class MenuRegistros : Form
    {
        public MenuRegistros()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Centrar la ventana al abrir
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
            //Llamo a la ventana de  Registrar de categoria de vehiculos
            RegistroCategoVehiculos RegistroCategoVehiculos = new RegistroCategoVehiculos();
            RegistroCategoVehiculos.Show();
            this.Close(); //Cierra la ventana actual
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            //Llamo a la ventana principal del menu
            Form1 Menu = new Form1();
            Menu.Show();
        }

        private void btn_salir_Click_1(object sender, EventArgs e)
        {
            //Salir de la aplicacion
            Application.Exit();
        }

        private void btn_vehiculo_Click_1(object sender, EventArgs e)
        {
            //Llamo a la ventana de Registrar de vehiculos
            RegistroVehiculo Registro_Vehiculos = new RegistroVehiculo();
            Registro_Vehiculos.Show();
            this.Close(); //Cierra la ventana actual
        }

        private void btn_vendedor_Click_1(object sender, EventArgs e)
        {
            // Llamo a la ventana de  Registrar de vehiculos
            RegistrarVendedor Registro_Vendedores = new RegistrarVendedor();
            Registro_Vendedores.Show();
            this.Close(); //Cierra la ventana actual
        }

        private void btn_sucursal_Click_1(object sender, EventArgs e)
        {
            // Llamo a la ventana de  Registrarde sucursales
            RegistrarSucursal Registrar_Sucursales = new RegistrarSucursal();
            Registrar_Sucursales.Show();
            this.Close(); //Cierra la ventana actual
        }

        private void btn_cliente_Click_1(object sender, EventArgs e)
        {
            // Llamo a la ventana de Registrar de sucursales
            RegistroCliente Registrar_Clientes = new RegistroCliente();
            Registrar_Clientes.Show();
            this.Close(); //Cierra la ventana actual
        }

        private void btn_vehiculosSucursal_Click_1(object sender, EventArgs e)
        {
            // Llamo a la ventana de  Registrar de sucursales
            Asociar_VehiculoSucursal Registrar_Vehiculo_Sucursal = new Asociar_VehiculoSucursal();
            Registrar_Vehiculo_Sucursal.Show();
            this.Close(); //Cierra la ventana actual
        }

        private void MenuRegistros_Load(object sender, EventArgs e)
        {

        }
    }
}
