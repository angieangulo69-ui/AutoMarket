/*
Universidad:UNED
I Cuatrimestre
Proyecto: AutoMarket
Descripción: Ventana para el registro de clientes, donde se pueden
ingresar detalles como el ID, identificación, nombre completo, fecha
de nacimiento, fecha de registro y estado activo. Además, se muestra
un DataGridView con los clientes registrados. Se implementan validaciones para evitar 
registros duplicados, validar la fecha de nacimiento y se limita el número de clientes a 5.
Estudiante: Angie Angulo Chacón 
Fecha:22/02/2026
*/
using AutoMarket.Class;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoMarket.Datos;

namespace AutoMarket
{
    public partial class RegistroCliente : Form
    {    
        public RegistroCliente()
        {
            InitializeComponent();
        }
        
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Datos_Clientes.contadorClientes >= 5)
                {
                    MessageBox.Show("Solo se permiten 5 clientes.");
                    return;
                }
                // Validar campos vacíos
                if (txt_idcliente.Text == "" ||
                    mtxt_identificacion.Text == "" ||
                    txt_nombre.Text == "")
                {
                    MessageBox.Show("Debe completar todos los campos.");
                    return;
                }
                //Toma los datos registrados por el usuario y los asigna a variables
                int id = int.Parse(txt_idcliente.Text);
                string identificacion = mtxt_identificacion.Text;
                string nombre = txt_nombre.Text;
                DateTime fechaNacimiento = dateTime_nacimiento.Value;
                // Validar fecha de nacimiento
                if (fechaNacimiento > DateTime.Now)
                {
                    MessageBox.Show("La fecha de nacimiento no es válida.");
                    return;
                }
                DateTime fechaRegistro = dateTime_registro.Value;
                bool activo = check_activo.Checked;

                // Validar ID único
                for (int i = 0; i < Datos_Clientes.contadorClientes; i++)
                {
                    if (Datos_Clientes.clientes[i].Id == id)
                    {
                        MessageBox.Show("El ID ya existe.");
                        return;
                    }

                    if (Datos_Clientes.clientes[i].Identificacion == identificacion)
                    {
                        MessageBox.Show("La identificación ya existe.");
                        return;
                    }
                }
                // Crea un nuevo cliente y lo agrega al arreglo
                Datos_Clientes.clientes[Datos_Clientes.contadorClientes] = new Cliente(
                    id, identificacion, nombre,
                    fechaNacimiento, fechaRegistro, activo);
                
                // Incrementa el contador de clientes
                Datos_Clientes.contadorClientes++;

                CargarGrid();
                LimpiarCampos();

                MessageBox.Show("Cliente registrado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CargarGrid()
        {
            DGV_clientes.Rows.Clear();
            // Carga los clientes registrados en el DataGridView
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
        private void LimpiarCampos()
        {
            // Limpia los campos de entrada después de guardar un cliente
            txt_idcliente.Clear();
            mtxt_identificacion.Clear();
            txt_nombre.Clear();
            dateTime_nacimiento.Value = DateTime.Now;
            dateTime_registro.Value = DateTime.Now;
            check_activo.Checked = false;
            txt_idcliente.Focus(); // Coloca el cursor en el campo de ID para facilitar el ingreso del siguiente cliente
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            // Llamo a la ventana de registro
            Registros Registros = new Registros();
            Registros.Show();
            this.Close(); //Cierra la ventana actual
        }

        private void RegistroCliente_Load_1(object sender, EventArgs e)
        { // Configura el DataGridView para mostrar los clientes de manera ordenada
            DGV_clientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // Ajusta el tamaño de las filas para mostrar todo el contenido
            DGV_clientes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            // Configura el DataGridView para que no se puedan editar las celdas ni agregar filas directamente
            DGV_clientes.ReadOnly = true;
            DGV_clientes.AllowUserToAddRows = false;
            
        }
    }
}
