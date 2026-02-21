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
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            //Llamo a la ventana de registro
            Registros Registros = new Registros();
            Registros.Show();
            this.Close(); //Cierra la ventana actual
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try

            {  if (Datos_Categorias.contador >= 20)
                {
                    MessageBox.Show("No se pueden registrar más de 20 categorías.");
                    return;
                }
                // Validar campos vacíos
                int id = int.Parse(txt_categoria.Text);
                string nombre = txt_nombre.Text;
                string descripcion = txt_descripcion.Text;

                // Validar ID único
                for (int i = 0; i < Datos_Categorias.contador; i++)
                {
                    if (Datos_Categorias.categorias[i].IdCategoria == id)
                    {
                        MessageBox.Show("El ID ya existe.");
                        return;
                    }
                }
                // Crear nueva categoría y agregar al arreglo
                Datos_Categorias.categorias[Datos_Categorias.contador] = new CategoriaVehiculo(id, nombre, descripcion);
                Datos_Categorias.contador++;

                CargarGrid();
                LimpiarCampos();
            }
            catch (FormatException)
            {
                MessageBox.Show("El ID debe ser un número entero.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
         

            private void LimpiarCampos()
        { // Limpiar los campos de texto después de guardar
            txt_categoria.Clear();
                txt_nombre.Clear();
                txt_descripcion.Clear();
        }
        
        private void CargarGrid()
        {   
            DGV_categorias.Rows.Clear();
            // Cargar las categorías registradas en el DataGridView
            for (int i = 0; i < Datos_Categorias.contador; i++)
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
            // Ajuiste del GridView
            DGV_categorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV_categorias.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DGV_categorias.ReadOnly = true;
            DGV_categorias.AllowUserToAddRows = false;
        }

        private void DGV_categorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
