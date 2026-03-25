/*
Universidad:UNED
I Cuatrimestre
Proyecto: AutoMarket
Descripción: Clase estática que almacena un arreglo de sucursales y
un contador para llevar el número de sucursales registradas.
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
    public static class Datos_Sucursal
    { // Arreglo para almacenar sucursales
        public static Sucursal[] sucursales = new Sucursal[5];
        // Contador para llevar el número de sucursales almacenadas
        public static int contadorSucursal = 0;
    }   
}
