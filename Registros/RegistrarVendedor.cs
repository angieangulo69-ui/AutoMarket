/*
Universidad:UNED
I Cuatrimestre
Proyecto: AutoMarket
Descripción: Ventana para registrar vendedores, con validaciones para campos vacíos, 
formato de teléfono, ID único, fecha de nacimiento y fecha de ingreso. Al guardar,
muestra un mensaje de éxito y actualiza la tabla con los vendedores registrados.
Estudiante: Angie Angulo Chacón 
Fecha:22/02/2026
*/
using AutoMarket.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoMarket.Datos;

namespace AutoMarket
{
    public partial class RegistrarVendedor : Form
    {
        
        public RegistrarVendedor()
        {
            InitializeComponent();
        }
        public void RegistrarVendedor_Load(object sender, EventArgs e)
        { // Configura el DataGridView para mostrar los vendedores registrados
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
            Registros Registros = new Registros();
            Registros.Show();
            this.Close(); //Cierra la ventana actual
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            { // Validar límite de vendedores
                if (Datos_Vendedor.contadorvendedor >= 20)
                {
                    MessageBox.Show("Solo se permiten 20 vendedores.");
                    return;
                }
                // Validar campos obligatorios
                if (txt_idvendedor.Text == "" || txt_nombre.Text == "")
                {
                    MessageBox.Show("Debe completar todos los campos.");
                    return;
                }
                // Validar formato de teléfono e identificación
                if (!mtxt_id.MaskCompleted)
                {
                    MessageBox.Show("Complete correctamente la identificación.");
                    return;
                }

                if (!mtxt_telefono.MaskCompleted)
                {
                    MessageBox.Show("Complete correctamente el teléfono.");
                    return;
                }
                // Obtener datos del vendedor
                
                int id = int.Parse(txt_idvendedor.Text);
                string identificacion = mtxt_id.Text;
                string nombre = txt_nombre.Text;
                DateTime fechaNacimiento = dateTime_nacimiento.Value;
                DateTime fechaIngreso = dateTime_Ingreso.Value;                
                string telefono = mtxt_telefono.Text;


                // Validaciones 

                // Validar fecha de ingreso
                if (fechaIngreso.Date > DateTime.Now.Date)
                {
                    MessageBox.Show("La fecha de ingreso no puede ser mayor al día actual.");
                    return;
                }
                // Validar mayoría de edad
                int edad = DateTime.Now.Year - fechaNacimiento.Year;
                if (fechaNacimiento > DateTime.Now.AddYears(-edad))
                    edad--;

                if (edad < 18)
                {
                    MessageBox.Show("El vendedor debe ser mayor de edad.");
                    return;
                }
                // Validar ID e identificación únicos
                for (int i = 0; i < Datos_Vendedor.contadorvendedor; i++)
                {
                    if (Datos_Vendedor.vendedor[i].Id == id)
                    {
                        MessageBox.Show("El ID ya existe.");
                        return;
                    }

                    if (Datos_Vendedor.vendedor[i].Identificacion == identificacion)
                    {
                        MessageBox.Show("La identificación ya existe.");
                        return;
                    }
                }
                // Crear nuevo vendedor y almacenarlo

                Datos_Vendedor.vendedor[Datos_Vendedor.contadorvendedor] = new Vendedor(id, identificacion, nombre, fechaNacimiento, fechaIngreso, telefono);
                Datos_Vendedor.contadorvendedor++;

                // Actualizar el DataGridView y limpiar campos
                CargarGrid();
                LimpiarCampos();

                MessageBox.Show("Vendedor registrado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CargarGrid()
        { // Limpia el DataGridView antes de cargar los datos
            dataGridRegistroVendedor.Rows.Clear();

            for (int i = 0; i < Datos_Vendedor.contadorvendedor; i++)
            {
                dataGridRegistroVendedor.Rows.Add(
                    Datos_Vendedor.vendedor[i].Id,
                    Datos_Vendedor.vendedor[i].Identificacion,
                    Datos_Vendedor.vendedor[i].NombreCompleto,
                    Datos_Vendedor.vendedor[i].FechaNacimiento.ToShortDateString(),
                    Datos_Vendedor.vendedor[i].FechaIngreso.ToShortDateString(),
                    Datos_Vendedor.vendedor[i].Telefono
                );
            }
        }

        private void LimpiarCampos()
        { // Limpia los campos del formulario y restablece las fechas al valor predeterminado
            txt_idvendedor.Clear();
            mtxt_id.Clear();
            txt_nombre.Clear();
            mtxt_telefono.Clear();
            dateTime_nacimiento.Value = DateTime.Now;
            dateTime_Ingreso.Value = DateTime.Now;
            txt_idvendedor.Focus(); // Coloca el cursor en el campo ID para facilitar el ingreso del siguiente vendedor
        }
    }
}

