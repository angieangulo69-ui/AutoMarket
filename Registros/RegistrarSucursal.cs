/*
Universidad:UNED
I Cuatrimestre
Proyecto: AutoMarket
Descripción: Ventana para registrar sucursales, con validaciones para campos vacíos, 
formato de teléfono, ID único y límite de sucursales. Permite seleccionar un vendedor
encargado de una lista desplegable. Al guardar, muestra un mensaje de éxito y actualiza 
la tabla con las sucursales registradas.
Estudiante: Angie Angulo Chacón 
Fecha:22/02/2026
*/
using AutoMarket.Class;
using AutoMarket.Datos;
using AutoMarket.Registros;
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
    public partial class RegistrarSucursal : Form
    {
        
        public RegistrarSucursal()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Centrar la ventana al abrir
        }

        private void RegistrarSucursal_Load(object sender, EventArgs e)
        {   // Verificar si hay vendedores registrados
            MessageBox.Show("Cantidad vendedores: " + Datos_Vendedor.contadorvendedor);
            DataGried_Sucursales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // Ajusta el tamaño de las filas automáticamente
            DataGried_Sucursales.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells; 
            // Evita que el usuario edite las celdas
            DataGried_Sucursales.ReadOnly = true;
            // Evita que el usuario seleccione filas completas
            DataGried_Sucursales.AllowUserToAddRows = false;
            
            CargarVendedores(); // Carga los vendedores en el comboBox al cargar la ventana
        }
        private void CargarVendedores()
        {
            // Limpia el comboBox antes de cargar los vendedores
            comboBox_encargado.DataSource = null;

            if (Datos_Vendedor.contadorvendedor > 0)
            {
                List<Vendedor> lista = new List<Vendedor>();

                for (int i = 0; i < Datos_Vendedor.contadorvendedor; i++)
                {
                    lista.Add(Datos_Vendedor.vendedor[i]);
                }

                comboBox_encargado.DataSource = lista; 
                comboBox_encargado.DisplayMember = "NombreCompleto";
            }
        }
        private void comboBox_encargado_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        { 
            try
            {  // Validar límite de sucursales
                if (Datos_Sucursal.contadorSucursal >= 5)
                {
                    MessageBox.Show("Solo se permiten 5 sucursales.");
                    return;
                }
                // Validar campos vacíos
                if (txt_idsucursal.Text == "" ||
                    txt_nombre.Text == "" ||
                    txt_direccion.Text == "")
                {
                    MessageBox.Show("Debe completar todos los campos.");
                    return;
                }
                // Validar formato de teléfono
                if (!mtb_telefono.MaskCompleted)
                {
                    MessageBox.Show("Complete correctamente el teléfono.");
                    return;
                }
                // Validar selección de vendedor
                if (comboBox_encargado.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar un vendedor encargado.");
                    return;
                }
                // Validar formato numérico del ID
                int id = int.Parse(txt_idsucursal.Text);

                // Validar ID único
                for (int i = 0; i < Datos_Sucursal.contadorSucursal; i++)
                {
                    if (Datos_Sucursal.sucursales[i].IdSucursal == id)
                    {
                        MessageBox.Show("El ID ya existe.");
                        return;
                    }
                }
                // Obtener datos del formulario
                string nombre = txt_nombre.Text;
                string direccion = txt_direccion.Text;
                string telefono = mtb_telefono.Text;
                bool activo = check_activo.Checked;

                // Obtener vendedor seleccionado
                Vendedor vendedorSeleccionado = (Vendedor)comboBox_encargado.SelectedItem;

                // Crear nueva sucursal y agregarla al arreglo
                Datos_Sucursal.sucursales[Datos_Sucursal.contadorSucursal] = new Sucursal(
                    id, nombre, direccion,
                    telefono, vendedorSeleccionado, activo);

                Datos_Sucursal.contadorSucursal++;

                CargarGrid();
                LimpiarCampos();

                MessageBox.Show("Sucursal registrada correctamente.");
                comboBox_encargado.DataSource = null;
                CargarVendedores();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LimpiarCampos()
        { // Limpia los campos del formulario
            txt_idsucursal.Clear();
            txt_nombre.Clear();
            txt_direccion.Clear();
            mtb_telefono.Clear();
            comboBox_encargado.SelectedIndex = -1;
            check_activo.Checked = false;
            txt_idsucursal.Focus(); // Coloca el cursor en el campo ID para facilitar el ingreso de la siguiente sucursal
        }
        
        private void CargarGrid()
        {
            DataGried_Sucursales.Rows.Clear();
            // Carga las sucursales registradas en el DataGridView
            for (int i = 0; i < Datos_Sucursal.contadorSucursal; i++)
            {
                DataGried_Sucursales.Rows.Add(
                    Datos_Sucursal.sucursales[i].IdSucursal,
                    Datos_Sucursal.sucursales[i].Nombre,
                    Datos_Sucursal.sucursales[i].Direccion,
                    Datos_Sucursal.sucursales[i].Telefono,
                    Datos_Sucursal.sucursales[i].VendedorEncargado.NombreCompleto,
                    Datos_Sucursal.sucursales[i].Activo ? "Sí" : "No"
                );
            }
        }

        private void comboBox_encargado_Click(object sender, EventArgs e)
        {
            CargarVendedores();
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            // Llamo a la ventana de registro
            MenuRegistros Registros = new MenuRegistros();
            Registros.Show();
            this.Close(); //Cierra la ventana actual
        }
    }
}
