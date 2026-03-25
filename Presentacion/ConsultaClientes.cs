/*
Universidad:UNED
I Cuatrimestre
Proyecto: AutoMarket
Descripción: Ventana para consultar los clientes registrados, mostrando su ID, 
identificación, nombre completo, fecha de nacimiento, fecha de registro y estado
(activo/inactivo) en un DataGridView. Al cargar la ventana, se configura el 
DataGridView para que las columnas se ajusten al tamaño del control, se establezca 
como de solo lectura y se evite que el usuario agregue filas. Luego, se cargan los 
clientes desde la clase Datos_Clientes y se muestran en el DataGridView.
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
    public partial class ConsultaClientes : Form
    {
        public ConsultaClientes()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Centrar la ventana al abrir
        }

        private void ConsultaClientes_Load(object sender, EventArgs e)
        {
            ConfiguracionDataGrid();
            CargarComboBoxClientes();

        }
        private void CargarComboBoxClientes()
        {
            comboBoxCliente.DataSource = null;

            List<object> listaClientes = new List<object>();

            for (int i = 0; i < Datos_Clientes.contadorClientes; i++)
            {
                listaClientes.Add(new
                {
                    Id = Datos_Clientes.clientes[i].Id,
                    Nombre = Datos_Clientes.clientes[i].NombreCompleto
                });
            }

            comboBoxCliente.DataSource = listaClientes;
            comboBoxCliente.DisplayMember = "Nombre"; // Lo que se muestra
            comboBoxCliente.ValueMember = "Id";       // Lo que se guarda internamente
            comboBoxCliente.SelectedIndex = -1;
        }

        private void CargarGrid()
        {
            DGV_clientes.Rows.Clear();

            for (int i = 0; i < Datos_Clientes.contadorClientes; i++)
            {
                DGV_clientes.Rows.Add(
                    Datos_Clientes.clientes[i].Id,
                    Datos_Clientes.clientes[i].Identificacion,
                    Datos_Clientes.clientes[i].NombreCompleto,
                    Datos_Clientes.clientes[i].FechaNacimiento.ToShortDateString(),
                    Datos_Clientes.clientes[i].FechaRegistro.ToShortDateString(),
                    Datos_Clientes.clientes[i].Activo ? "Sí" : "No"
                );
            }
        }
        public void ConfiguracionDataGrid()
        {
            DGV_clientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV_clientes.ReadOnly = true;
            DGV_clientes.AllowUserToAddRows = false;
            DGV_clientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_clientes.MultiSelect = false;
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

        private void comboBoxVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
         

        private void btn_consultar_Click(object sender, EventArgs e)
        {                  
            CargarGrid();
            comboBoxCliente.SelectedIndex = -1;
        }

        private void btn_filtros_Click(object sender, EventArgs e)
        {

            if (comboBoxCliente.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un cliente para filtrar.");
                return;
            }

            int idSeleccionado = (int)comboBoxCliente.SelectedValue;

            DGV_clientes.Rows.Clear();

            for (int i = 0; i < Datos_Clientes.contadorClientes; i++)
            {
                if (Datos_Clientes.clientes[i].Id == idSeleccionado)
                {
                    DGV_clientes.Rows.Add(
                        Datos_Clientes.clientes[i].Id,
                        Datos_Clientes.clientes[i].Identificacion,
                        Datos_Clientes.clientes[i].NombreCompleto,
                        Datos_Clientes.clientes[i].FechaNacimiento.ToShortDateString(),
                        Datos_Clientes.clientes[i].FechaRegistro.ToShortDateString(),
                        Datos_Clientes.clientes[i].Activo ? "Activo" : "Inactivo"
                    );
                }
            }
        }
    }
}
