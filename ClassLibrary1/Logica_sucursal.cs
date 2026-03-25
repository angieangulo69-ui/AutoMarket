using Entidades;
using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public static class Logica_sucursal
    {

        public static bool Agregar(Sucursal nueva)
        { // Verificar si el contador ha alcanzado el límite del arreglo
            if (Datos_Sucursal.contadorSucursal >= 5)
            { 
                return false;
            }
            Datos_Sucursal.sucursales[Datos_Sucursal.contadorSucursal] = nueva;
            Datos_Sucursal.contadorSucursal++;
            return true;
        }

        public static int TotalRegistros()
        {// Retorna el número total de sucursales registradas
            return Datos_Sucursal.contadorSucursal;
        }

        public static Sucursal Obtener(int posicion)
        {// Verificar si la posición es válida antes de acceder al arreglo
            if (posicion >= 0 && posicion < Datos_Sucursal.contadorSucursal)
                return Datos_Sucursal.sucursales[posicion];

            return null;
        }
    }
}
