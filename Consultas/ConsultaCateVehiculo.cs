/*
Universidad:UNED
I Cuatrimestre
Proyecto: AutoMarket
Descripción: Ventana para consultar las categorías de vehículos registradas,
mostrando su ID, nombre y descripción en un DataGridView. Al cargar la ventana,
se configura el DataGridView para que las columnas se ajusten al tamaño del 
control, se establezca como de solo lectura y se evite queel usuario agregue 
filas. Luego, se cargan las categorías desde la clase Datos_Categorias y se muestran en el DataGridView.
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
    public partial class ConsultaCateVehiculo : Form
    {
        public ConsultaCateVehiculo()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Centrar la ventana al abrir

        }

        private void ConsultaCateVehiculo_Load(object sender, EventArgs e)
        {
            ConfiguracionDataGrid();
            CargarGrid();
            CargarComboBox();
        }
        private void ConfiguracionDataGrid()
        {
            DGV_categorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV_categorias.ReadOnly = true;
            DGV_categorias.AllowUserToAddRows = false;
        }
        private void CargarGrid()
        {
            DGV_categorias.Rows.Clear();

            for (int i = 0; i < Datos_Categorias.contador; i++)
            {
                DGV_categorias.Rows.Add(
                    Datos_Categorias.categorias[i].IdCategoria,
                    Datos_Categorias.categorias[i].NombreCategoria,
                    Datos_Categorias.categorias[i].Descripcion                    
                );
            }
        }
        private void CargarComboBox()
        {
            comboBoxcategoria.DataSource = null;
            List<string> listaNombres = new List<string>();

            for (int i = 0; i < Datos_Categorias.contador; i++)
            {
                listaNombres.Add(Datos_Categorias.categorias[i].NombreCategoria);
            }

            comboBoxcategoria.DataSource = listaNombres;
            comboBoxcategoria.SelectedIndex = -1; // Para que no seleccione nada al inicio
        }

        private void comboBoxcategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            //Llamo a la ventana principal del menu de consultas
           Consulta MenuConsultas = new Consulta();
            MenuConsultas.Show();
            this.Close();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        { //Salir de la aplicacion
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CargarGrid(); // Simplemente recarga todas las categorías
            comboBoxcategoria.SelectedIndex = -1; // Deselecciona filtro
        }
        

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            if (comboBoxcategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una categoría para filtrar.");
                return;
            }

            string categoriaSeleccionada = comboBoxcategoria.Text;
            DGV_categorias.Rows.Clear();

            for (int i = 0; i < Datos_Categorias.contador; i++)
            {
                if (Datos_Categorias.categorias[i].NombreCategoria == categoriaSeleccionada)
                {
                    DGV_categorias.Rows.Add(
                        Datos_Categorias.categorias[i].IdCategoria,
                        Datos_Categorias.categorias[i].NombreCategoria,
                        Datos_Categorias.categorias[i].Descripcion
                    );
                }
            }
        }
    }
}
