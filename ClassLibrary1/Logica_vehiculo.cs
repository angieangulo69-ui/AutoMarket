using Entidades;
using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public static class Logica_vehiculo
    {
        public static bool Agregar(Vehiculo nuevo)
        {
            if (Datos_Vehiculo.contadorVehiculos >= 50)
                return false;

            Datos_Vehiculo.vehiculos[Datos_Vehiculo.contadorVehiculos] = nuevo;
            Datos_Vehiculo.contadorVehiculos++;
            
            return true;
        }

        public static int TotalRegistros()
        {
            return Datos_Vehiculo.contadorVehiculos;
        }

        public static Vehiculo Obtener(int posicion)
        {
            if (posicion >= 0 && posicion < Datos_Vehiculo.contadorVehiculos)
                return Datos_Vehiculo.vehiculos[posicion];

            return null;
        }
    }
}
