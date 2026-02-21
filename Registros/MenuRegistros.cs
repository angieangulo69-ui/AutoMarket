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

        private void btn_vehiculo_Click(object sender, EventArgs e)
        { //Llamo a la ventana de Registrar de vehiculos
            RegistroVehiculo Registro_Vehiculos = new RegistroVehiculo();
            Registro_Vehiculos.Show();
            this.Close(); //Cierra la ventana actual

        }

        private void btn_vendedor_Click(object sender, EventArgs e)
        {
            // Llamo a la ventana de  Registrar de vehiculos
            RegistrarVendedor Registro_Vendedores = new RegistrarVendedor();
            Registro_Vendedores.Show();
            this.Close(); //Cierra la ventana actual
        }

        private void btn_sucursal_Click(object sender, EventArgs e)
        { // Llamo a la ventana de  Registrarde sucursales
            RegistrarSucursal Registrar_Sucursales = new RegistrarSucursal();
            Registrar_Sucursales.Show();
            this.Close(); //Cierra la ventana actual

        }

        private void btn_cliente_Click(object sender, EventArgs e)
        {
            // Llamo a la ventana de Registrar de sucursales
            RegistroCliente Registrar_Clientes = new RegistroCliente();
            Registrar_Clientes.Show();
            this.Close(); //Cierra la ventana actual
        }

        private void btn_vehiculosSucursal_Click(object sender, EventArgs e)
        {
            // Llamo a la ventana de  Registrar de sucursales
            VehiculoSucursal Registrar_Vehiculo_Sucursal = new VehiculoSucursal();
            Registrar_Vehiculo_Sucursal.Show();
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
    }


    }
