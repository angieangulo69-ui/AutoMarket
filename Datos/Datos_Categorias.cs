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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMarket.Class;

namespace AutoMarket.Datos
{
    public static class Datos_Categorias
    {
        // Arrelgo de categorías de vehículos
        public static CategoriaVehiculo[] categorias = new CategoriaVehiculo[20];
        // Contador para llevar el número de categorías almacenadas
        public static int contador = 0;

          public static bool Agregar(CategoriaVehiculo nueva)
           {
            if (contador >= 20)
                return false;

            // Validar nombre único
            for (int i = 0; i < contador; i++)
            {
                if (categorias[i].NombreCategoria.ToLower() ==
                    nueva.NombreCategoria.ToLower())
                    return false;
            }

            categorias[contador] = nueva;
            contador++;
            return true;
        }

        public static int TotalRegistros()
        {
            return contador;
        }

        //buscar y devolver una categoría del arreglo según su posición.
        public static CategoriaVehiculo Obtener(int posicion)
        {
            if (posicion >= 0 && posicion < contador)
                return categorias[posicion];

            return null;
        }
    }
}
    

