/*
Universidad:UNED
I Cuatrimestre
Proyecto: AutoMarket
Descripción: Clase estática que almacena un arreglo de clientes y 
un contador para llevar el número de clientes almacenados.
Estudiante: Angie Angulo Chacón 
Fecha:22/02/2026
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Entidades;

namespace AccesoDatos
{
    public static class Datos_Clientes
    {   // Arreglo de clientes
        public static Cliente[] clientes = new Cliente[5];
        // Contador para llevar el número de clientes almacenados
        public static int contadorClientes = 0;
    
     
    }

}
