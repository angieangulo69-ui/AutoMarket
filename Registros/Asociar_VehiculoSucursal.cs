/*
Universidad:UNED
I Cuatrimestre
Proyecto: AutoMarket
Descripción:Ventana para asociar vehículos a sucursales, permitiendo 
seleccionar una sucursal activa, un vehículo registrado y especificar 
la cantidad. Al guardar la asociación, se valida que no se exceda el 
límite de registros, que se hayan seleccionado todos los campos y que
la cantidad sea un número válido. Luego, se almacena la asociación en 
la clase Datos_VehiculosSucursal y se actualiza el DataGridView para 
mostrarlas asociaciones actuales. También incluye opciones para regresar 
al menú principal o salir de la aplicación.
Estudiante: Angie Angulo Chacón 
Fecha:22/02/2026
*/
using AutoMarket.Class;
using AutoMarket.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoMarket.Consultas
{
    public partial class Asociar_VehiculoSucursal : Form
    {
        public Asociar_VehiculoSucursal()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Centrar la ventana al abrir
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_atras_Click(object sender, EventArgs e)
        {

        }

        private void ConsultaVehiculoSucursal_Load(object sender, EventArgs e)
        {
            ConfigurarGrid();
            CargarSucursalesActivas();
            CargarVehiculos();
        }
        // Carga solo las sucursales activas en el comboBox
        private void CargarSucursalesActivas()
        {
            comboBox_sucursal.DataSource = null;

            List<Sucursal> lista = new List<Sucursal>();

            for (int i = 0; i < Datos_Sucursal.contadorSucursal; i++)
            {
                if (Datos_Sucursal.sucursales[i].Activo)
                {
                    lista.Add(Datos_Sucursal.sucursales[i]);
                }
            }

            comboBox_sucursal.DataSource = lista;
            comboBox_sucursal.DisplayMember = "Nombre";
        
        }
        // Carga el DataGridView con las asociaciones actuales entre vehículos y sucursales
        private void CargarGrid()
        {
            dataGridViewSucrusal_Vehiculo.Rows.Clear();

            for (int i = 0; i < Datos_VehiculosSucursal.contador; i++)
            {
                dataGridViewSucrusal_Vehiculo.Rows.Add(
                    Datos_VehiculosSucursal.registros[i].Sucursal.Nombre,
                    Datos_VehiculosSucursal.registros[i].Vehiculo.Modelo,
                    Datos_VehiculosSucursal.registros[i].Cantidad
                );
            }

        }
        // Carga los vehículos registrados en el comboBox para asociar con las sucursales
        private void CargarVehiculos()
        {
            comboBox_Vehiculo.DataSource = null;
            List<Vehiculo> lista = new List<Vehiculo>();

            for (int i = 0; i < Datos_Vehiculo.contadorVehiculos; i++)
                lista.Add(Datos_Vehiculo.vehiculos[i]);

            comboBox_Vehiculo.DataSource = lista;
            comboBox_Vehiculo.DisplayMember = "Modelo";
        }
        // Configura el DataGridView para mostrar las asociaciones de manera clara
        // y evitar modificaciones directas por parte del usuario
        private void ConfigurarGrid()
        {
            dataGridViewSucrusal_Vehiculo.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.Fill;

            dataGridViewSucrusal_Vehiculo.ReadOnly = true;
            dataGridViewSucrusal_Vehiculo.AllowUserToAddRows = false;
        }
        // Maneja el evento de clic en el botón "Guardar" para asociar un vehículo a una sucursal
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Datos_VehiculosSucursal.contador >= 100)
                {
                    MessageBox.Show("Límite máximo alcanzado.");
                    return;
                }

                if (comboBox_sucursal.SelectedItem == null ||
                    comboBox_Vehiculo.SelectedItem == null ||
                    txt_cantidad.Text == "")
                {
                    MessageBox.Show("Complete todos los campos.");
                    return;
                }

                int cantidad = int.Parse(txt_cantidad.Text);

                Sucursal sucursal = (Sucursal)comboBox_sucursal.SelectedItem;
                Vehiculo vehiculo = (Vehiculo)comboBox_Vehiculo.SelectedItem;
                // Crea una nueva asociación entre el vehículo y la sucursal, y la guarda en Datos_VehiculosSucursal
                Datos_VehiculosSucursal.registros[Datos_VehiculosSucursal.contador] =
                    new Vehiculo_Sucursal(sucursal, vehiculo, cantidad);

                Datos_VehiculosSucursal.contador++;

                MessageBox.Show("Asociación guardada correctamente.");

                CargarGrid();
                txt_cantidad.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // Regresar al Menú para volver a la ventana principal del menú
        private void button2_Click(object sender, EventArgs e)
        {
            //Llamo a la ventana principal del menu
            Form1 Menu = new Form1();
            Menu.Show();
        }
        // Salir de la aplicación
        private void button1_Click(object sender, EventArgs e)
        {
            //Salir de la aplicacion
            Application.Exit();
        }

        private void comboBox_sucursal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}


