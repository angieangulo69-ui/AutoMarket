/*
Universidad:UNED
I Cuatrimestre
Proyecto: AutoMarket
Descripción: Clase que representa una categoría de vehículo, con propiedades para el ID, nombre 
y descripción de la categoría. Incluye un constructor para inicializar estas propiedades y un 
método ToString para mostrar la información de la categoría de manera legible.
Estudiante: Angie Angulo Chacón 
Fecha:22/02/2026
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AutoMarket.Class
{
    public class CategoriaVehiculo
    { //Propiedades de la clase
        public int IdCategoria { get; set; }
        public string NombreCategoria { get; set; }
        public string Descripcion { get; set; }

        public CategoriaVehiculo(int id, string nombre, string descripcion)
        {
            //Constructor de la clase
            IdCategoria = id;
            NombreCategoria = nombre;
            Descripcion = descripcion;
        }
        public override string ToString()
        { //Sobrescribe el método ToString para mostrar el nombre y la descripción de la categoría
            return NombreCategoria + " - " + Descripcion;
        }
    }
}
