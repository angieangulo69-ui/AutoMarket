
/*
Universidad:UNED
I Cuatrimestre
Proyecto: AutoMarket
Descripción: Clase estática que almacena un arreglo de vehículos y un contador para llevar 
el número de vehículos almacenados. Esta clase se utiliza para gestionar los vehículos en el sistema.
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
    public static class Datos_Vehiculo
    {   // Arreglo de vehículos
        public static Vehiculo[] vehiculos = new Vehiculo[50];
        // Contador para llevar el número de vehículos almacenados
        public static int contadorVehiculos = 0;
    }
}




