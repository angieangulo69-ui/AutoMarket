/*
Universidad:UNED
I Cuatrimestre
Proyecto: AutoMarket
Descripción: Ventana para el registro de vehículos, donde se pueden ingresar detalles 
como el ID, marca, modelo, año, precio, categoría y estado (nuevo o usado). Además, se 
muestra un DataGridView con los vehículos registrados. Se implementan validaciones para 
evitar registros duplicados, validar el año y el precio, y se limita el número de vehículos a 50.
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
using AutoMarket.Datos; // Asegúrate de incluir el espacio de nombres correcto para acceder a Datos_Vehiculo y RegistroCategoVehiculos    


namespace AutoMarket
{
    public partial class RegistroVehiculo : Form
    {

        
        public RegistroVehiculo()
        {
            InitializeComponent();
        }

        private void RegistroVehiculo_Load(object sender, EventArgs e)
        {
          
            // Ajuiste del GridView
            DGV_vehiculos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV_vehiculos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            // Evitar edición directa en el DataGridView
            DGV_vehiculos.ReadOnly = true;
            // Evitar que el usuario agregue filas directamente en el DataGridView
            DGV_vehiculos.AllowUserToAddRows = false;

            // Cargar categorías registradas
            for (int i = 0; i < Datos_Categorias.contador; i++)
            {
                comBox_categoria.Items.Add(Datos_Categorias.categorias[i]);
            }

            comBox_categoria.DisplayMember = "NombreCategoria";
        
        
            //Carga el combox
            combox_estado.Items.Add("Nuevo");
            combox_estado.Items.Add("Usado");
        }
        private void txt_idVehiculo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar campos vacíos
                if (txt_idVehiculo.Text == "" ||
                    txt_marca.Text == "" ||
                    txt_modelo.Text == "" ||
                    txt_anio.Text == "" ||
                    txt_precio.Text == "" ||
                    comBox_categoria.SelectedIndex == -1 ||
                    combox_estado.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe completar todos los campos.");
                    return;
                }

                if (Datos_Vehiculo.contadorVehiculos >= 50)
                {
                    MessageBox.Show("No se pueden registrar más vehículos.");
                    return;
                }
                //Toma datos ingresados
                int id = int.Parse(txt_idVehiculo.Text);
                string marca = txt_marca.Text;
                string modelo = txt_modelo.Text;
                int anio = int.Parse(txt_anio.Text);
                decimal precio = decimal.Parse(txt_precio.Text);

                // 🔹 Validar año
                if (anio < 1900 || anio > DateTime.Now.Year)
                {
                    MessageBox.Show("Ingrese un año válido.");
                    return;
                }

                // 🔹 Validar precio positivo
                if (precio <= 0)
                {
                    MessageBox.Show("El precio debe ser mayor a 0.");
                    return;
                }


                CategoriaVehiculo categoria = (CategoriaVehiculo)comBox_categoria.SelectedItem;
                char estado = combox_estado.Text == "Nuevo" ? 'N' : 'U';

                // Validar ID único
                for (int i = 0; i < Datos_Vehiculo.contadorVehiculos; i++)
                {
                    if (Datos_Vehiculo.vehiculos[i].IdVehiculo == id)
                    {
                        MessageBox.Show("El ID ya existe.");
                        return;
                    }
                }
                // Crear nuevo vehículo y agregarlo al arreglo
                Datos_Vehiculo.vehiculos[Datos_Vehiculo.contadorVehiculos] = new Vehiculo(id, marca, modelo, anio, precio, categoria, estado);
                Datos_Vehiculo.contadorVehiculos++;

                CargarGrid();
                LimpiarCampos();

                MessageBox.Show("Vehículo registrado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CargarGrid()
        {
            DGV_vehiculos.Rows.Clear();

            for (int i = 0; i < Datos_Vehiculo.contadorVehiculos; i++)
            {
                string estadoTexto = Datos_Vehiculo.vehiculos[i].Estado == 'N' ? "Nuevo" : "Usado";
                // Agrega una nueva fila al DataGridView con los datos del vehículo
                DGV_vehiculos.Rows.Add(
                    Datos_Vehiculo.vehiculos[i].IdVehiculo,
                    Datos_Vehiculo.vehiculos[i].Marca,
                    Datos_Vehiculo.vehiculos[i].Modelo,
                    Datos_Vehiculo.vehiculos[i].Anio,
                    Datos_Vehiculo.vehiculos[i].Precio.ToString("C",
                    new System.Globalization.CultureInfo("es-CR")),
                    Datos_Vehiculo.vehiculos[i].Categoria.NombreCategoria,
                    estadoTexto
                );
            }
        }
        private void LimpiarCampos()
        {// Limpia los campos de texto y resetea los ComboBox
            txt_idVehiculo.Clear();
            txt_marca.Clear();
            txt_modelo.Clear();
            txt_anio.Clear();
            txt_precio.Clear();
            comBox_categoria.SelectedIndex = -1;  // Deselecciona categoría
            combox_estado.SelectedIndex = -1;     // Deselecciona estado
            txt_idVehiculo.Focus(); // Devuelve el cursor al primer campo
        }

        private void DGV_vehiculos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            //Llamo a la ventana de registro
            Registros Registros = new Registros();
            Registros.Show();
            this.Close(); //Cierra la ventana actual
        }
    }
    }


