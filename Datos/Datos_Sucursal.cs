/*
Universidad:UNED
I Cuatrimestre
Proyecto: AutoMarket
Descripción: Clase estática que almacena un arreglo de sucursales y
un contador para llevar el número de sucursales registradas.
Estudiante: Angie Angulo Chacón 
Fecha:22/02/2026
*/
using AutoMarket.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMarket.Datos
{
    public static class Datos_Sucursal
    { // Arreglo para almacenar sucursales
        public static Sucursal[] sucursales = new Sucursal[5];
        // Contador para llevar el número de sucursales almacenadas

       
        public static int contadorSucursal = 0; // Se inicializa en 0, ya que no hay sucursales registradas al inicio
        public static bool Agregar(Sucursal nueva)
        { // Verificar si el contador ha alcanzado el límite del arreglo
            if (contadorSucursal >= 5)
                return false;

            sucursales[contadorSucursal] = nueva;
            contadorSucursal++;
            return true;
        }

        public static int TotalRegistros()
        {// Retorna el número total de sucursales registradas
            return contadorSucursal;
        }

        public static Sucursal Obtener(int posicion)
        {// Verificar si la posición es válida antes de acceder al arreglo
            if (posicion >= 0 && posicion < contadorSucursal)
                return sucursales[posicion];

            return null;
        }
    }
}
