/*
Universidad:UNED
I Cuatrimestre
Proyecto: AutoMarket
Descripción: Clase estática que almacena un arreglo de categorías de vehículos y 
un contador para llevar el número de categorías almacenadas. Esta clase se utiliza 
para gestionar las categorías de vehículos en el sistema.
Estudiante: Angie Angulo Chacón 
Fecha:22/02/2026
*/
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AccesoDatos
{
    public static class Datos_Categorias
    {
        // Arrelgo de categorías de vehículos
        public static CategoriaVehiculo[] categorias = new CategoriaVehiculo[20];
        // Contador para llevar el número de categorías almacenadas
        public static int contadorCategorias = 0;

         
    }
}
    

