/*
 UNED
 I Cuatrimestre
 Proyecto: AutoMarkt
 Descripción: Ventana para el registro de categorías de vehículos, donde se 
pueden ingresar detalles como el ID, nombre y descripción de cada categoría. 
Además, se muestra un DataGridView con las categorías registradas. Se implementan 
validaciones para evitar registros duplicados y se limita el número de categorías a 20.
 Estudiante: Angie Angulo Chacon 
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
  
    public partial class RegistroCategoVehiculos : Form

    {
        public RegistroCategoVehiculos()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Centrar la ventana al abrir
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            //Llamo a la ventana de registro
            MenuRegistros Registros = new MenuRegistros();
            Registros.Show();
            Close(); //Cierra la ventana actual
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {      
            try
            {
                if (string.IsNullOrWhiteSpace(txt_nombre.Text) ||
                    string.IsNullOrWhiteSpace(txt_descripcion.Text))
                {
                    MessageBox.Show("Debe completar todos los campos.");
                    return;
                }

                CategoriaVehiculo nueva = new CategoriaVehiculo(
                    txt_nombre.Text.Trim(),
                    txt_descripcion.Text.Trim()
                );

                if (!Datos_Categorias.Agregar(nueva))
                {
                    MessageBox.Show("No se puede registrar la categoría (límite alcanzado o nombre repetido).");
                    return;
                }

                CargarGrid();
                LimpiarCampos();

                txt_categoria.Text = CategoriaVehiculo.ObtenerSiguienteId().ToString();

                MessageBox.Show("Categoría registrada correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        }
         

            private void LimpiarCampos()
            { // Limpiar los campos de texto después de guardar
               
                txt_nombre.Clear();
                txt_descripcion.Clear();
                txt_nombre.Focus();
            }
        
        
        private void CargarGrid()
        {   
            DGV_categorias.Rows.Clear();
            // Cargar las categorías registradas en el DataGridView
          for (int i = 0; i < Datos_Categorias.TotalRegistros(); i++)
            {
                DGV_categorias.Rows.Add(
                    Datos_Categorias.categorias[i].IdCategoria,
                    Datos_Categorias.categorias[i].NombreCategoria,
                    Datos_Categorias.categorias[i].Descripcion
                );
            }

        }

        private void RegistroCategoVehiculos_Load(object sender, EventArgs e)
        {
            ConfigurarGrid();
            txt_categoria.ReadOnly = true;
            txt_categoria.Text = CategoriaVehiculo.ObtenerSiguienteId().ToString();
            CargarGrid();

        }
        private void  ConfigurarGrid()
        {
            // Ajuiste del GridView
            DGV_categorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV_categorias.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DGV_categorias.ReadOnly = true;
            DGV_categorias.AllowUserToAddRows = false;
        }
        private void DGV_categorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_categoria_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
