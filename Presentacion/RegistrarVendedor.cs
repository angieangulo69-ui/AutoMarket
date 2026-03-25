/*
Universidad:UNED
I Cuatrimestre
Proyecto: AutoMarket
Descripción:    Ventana para registrar vendedores, con validaciones para campos vacíos,
formato de teléfono, ID único y límite de vendedores. Permite ingresar la fecha de
nacimiento y fecha de ingreso, con validación de mayoría de edad y fecha de ingreso no 
mayor al día actual. Al guardar, muestra un mensaje de éxito y actualiza la tabla con 
los vendedores registrados.
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
    public partial class RegistrarVendedor : Form
    {
        public RegistrarVendedor()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Centrar la ventana al abrir
        }
        
        private void ConfigurarDataGridView()
        {
            // Configura el DataGridView para mostrar los vendedores registrados
            dataGridRegistroVendedor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // Ajusta el tamaño de las filas automáticamente
            dataGridRegistroVendedor.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            // Evita que el usuario edite las celdas
            dataGridRegistroVendedor.ReadOnly = true;
            // Evita que el usuario seleccione filas completas
            dataGridRegistroVendedor.AllowUserToAddRows = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dateTime_nacimiento_ValueChanged(object sender, EventArgs e)
        {

        }
    
       
        private void btn_atras_Click(object sender, EventArgs e)
        {
            // Llamo a la ventana de registro
            MenuRegistros Registros = new MenuRegistros();
            Registros.Show();
            this.Close(); //Cierra la ventana actual
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {    // Validar campos vacíos y formato de teléfono e ID
                if (string.IsNullOrWhiteSpace(txt_nombre.Text) || !mtxt_id.MaskCompleted || !mtxt_telefono.MaskCompleted)
                {
                    MessageBox.Show("Debe completar todos los campos correctamente.");
                    return;
                }

                string identificacion = mtxt_id.Text;
                string nombre = txt_nombre.Text;
                string telefono = mtxt_telefono.Text;
                DateTime fechaNacimiento = dateTime_nacimiento.Value;
                DateTime fechaIngreso = dateTime_Ingreso.Value;
                

                // Validar mayoría de edad
                int edad = DateTime.Now.Year - fechaNacimiento.Year;
                if (fechaNacimiento > DateTime.Now.AddYears(-edad))
                    edad--;

                if (edad < 18)
                {
                    MessageBox.Show("El vendedor debe ser mayor de edad.");
                    return;
                }
                // Validar fecha de ingreso no mayor al día actual
                if (fechaIngreso.Date > DateTime.Now.Date)
                {
                    MessageBox.Show("La fecha de ingreso no puede ser mayor al día actual.");
                    return;
                }
                // Validar ID único
                Vendedor nuevo = new Vendedor( identificacion,nombre,fechaNacimiento, fechaIngreso,telefono);

                if (!Datos_Vendedor.AgregarVendedor(nuevo))
                {
                    MessageBox.Show("No se pudo registrar el vendedor. Puede estar lleno el cupo o la identificación ya existe.");
                    return;
                }

                txt_idvendedor.Text = nuevo.Id.ToString();

                CargarGrid();
                LimpiarCampos();

                MessageBox.Show("Vendedor registrado correctamente.");
                txt_idvendedor.Text = Persona.ObtenerSiguienteId().ToString(); // Actualiza el próximo ID disponible después de registrar un vendedor
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
        private void CargarGrid()
        { // Carga los vendedores registrados en el DataGridView
            dataGridRegistroVendedor.Rows.Clear();

            Vendedor[] lista = Datos_Vendedor.ObtenerVendedores();
            int cantidad = Datos_Vendedor.ObtenerCantidad();

            for (int i = 0; i < cantidad; i++)
            {
                dataGridRegistroVendedor.Rows.Add(
                    lista[i].Id,
                    lista[i].Identificacion,
                    lista[i].NombreCompleto,
                    lista[i].FechaNacimiento.ToShortDateString(),
                    lista[i].FechaIngreso.ToShortDateString(),
                    lista[i].Telefono
                );
            }
        }

        private void LimpiarCampos()
        { // Limpia los campos del formulario y restablece las fechas al valor predeterminado
            
            mtxt_id.Clear();
            txt_nombre.Clear();
            mtxt_telefono.Clear();
            dateTime_nacimiento.Value = DateTime.Now;
            dateTime_Ingreso.Value = DateTime.Now;
            txt_nombre.Focus(); // Coloca el cursor en el campo nombre para facilitar el ingreso del siguiente vendedor
        }

        private void RegistrarVendedor_Load_1(object sender, EventArgs e)

        {
            ConfigurarDataGridView();
            txt_idvendedor.ReadOnly = true; // El campo de ID es de solo lectura
            txt_idvendedor.Text = Persona.ObtenerSiguienteId().ToString(); // Muestra el próximo ID disponible al cargar la ventana
             CargarGrid(); // Carga los vendedores registrados al iniciar la ventana
        }

    }
}

