/*
Universidad:UNED
I Cuatrimestre
Proyecto: AutoMarket
Descripción: Ventana para consultar los vehículos registrados, mostrando 
su ID, marca, modelo, año, precio, categoría y estado (disponible/vendido) 
en un DataGridView. Al cargar la ventana, se configura el DataGridView para
que las columnas se ajusten al tamaño del control, se establezca como de 
solo lectura y se evite que el usuario agreguefilas. Luego, se cargan los 
vehículos desde la clase Datos_Vehiculo y se muestran en el DataGridView.
Estudiante: Angie Angulo Chacón 
Fecha:22/02/2026
*/
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
    public partial class ConsultaVehiculos : Form
    {
        public ConsultaVehiculos()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Centrar la ventana al abrir
        }

        private void ConsultaVehiculos_Load(object sender, EventArgs e)
        {
            ConfigurarDataGridView();
            CargarComboBox();    // Cargar categorías en ComboBox para filtrar


        }
        public void ConfigurarDataGridView()
        {
            DGV_vehiculos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Ajustar columnas al tamaño del control
            DGV_vehiculos.ReadOnly = true; // Establecer como solo lectura
            DGV_vehiculos.AllowUserToAddRows = false; // Evitar que el usuario agregue filas
            DGV_vehiculos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_vehiculos.MultiSelect = false;
        }
        private void CargarGrid()
        {
            DGV_vehiculos.Rows.Clear();

            for (int i = 0; i < Datos_Vehiculo.contadorVehiculos; i++)
            {
                DGV_vehiculos.Rows.Add(
                    Datos_Vehiculo.vehiculos[i].IdVehiculo,
                    Datos_Vehiculo.vehiculos[i].Marca,
                    Datos_Vehiculo.vehiculos[i].Modelo,
                    Datos_Vehiculo.vehiculos[i].Anio,
                    Datos_Vehiculo.vehiculos[i].Precio,
                    Datos_Vehiculo.vehiculos[i].Categoria.NombreCategoria,
                    Datos_Vehiculo.vehiculos[i].Categoria.Descripcion,
                    Datos_Vehiculo.vehiculos[i].Estado == 'N' ? "Nuevo" : "Usado"
                );
            }
        }
        private void CargarComboBox()
        {
            comboBoxVehiculo.DataSource = null;
            List<string> listaCategorias = new List<string>();

            for (int i = 0; i < Datos_Categorias.contador; i++)
                listaCategorias.Add(Datos_Categorias.categorias[i].NombreCategoria);

            comboBoxVehiculo.DataSource = listaCategorias;
            comboBoxVehiculo.SelectedIndex = -1; // No seleccionar nada al inicio
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Llamo a la ventana principal del menu consultas
            Consulta MenuConsulta = new Consulta();
            MenuConsulta.Show();
            this.Close();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            //Salir de la aplicacion
            Application.Exit();
        }

        private void btnConsultraFiltro_Click(object sender, EventArgs e)
        {
            if (comboBoxVehiculo.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una categoría para filtrar.");
                return;
            }

            string categoriaSeleccionada = comboBoxVehiculo.Text;
            DGV_vehiculos.Rows.Clear();

            for (int i = 0; i < Datos_Vehiculo.contadorVehiculos; i++)
            {
                if (Datos_Vehiculo.vehiculos[i].Categoria.NombreCategoria == categoriaSeleccionada)
                {
                    DGV_vehiculos.Rows.Add(
                        Datos_Vehiculo.vehiculos[i].IdVehiculo,
                        Datos_Vehiculo.vehiculos[i].Marca,
                        Datos_Vehiculo.vehiculos[i].Modelo,
                        Datos_Vehiculo.vehiculos[i].Anio,
                        Datos_Vehiculo.vehiculos[i].Precio.ToString("C"),
                        Datos_Vehiculo.vehiculos[i].Categoria.NombreCategoria,
                        Datos_Vehiculo.vehiculos[i].Categoria.Descripcion,
                        Datos_Vehiculo.vehiculos[i].Estado == 'N' ? "Nuevo" : "Usado"
                    );
                }
            }
        }

        private void btn_consultaVehiculos_Click(object sender, EventArgs e)
        {
            CargarGrid();
            comboBoxVehiculo.SelectedIndex = -1; // Deseleccionar filtro
        }
    }
}

