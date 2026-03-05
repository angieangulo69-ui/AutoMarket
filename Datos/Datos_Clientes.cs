/*
Universidad:UNED
I Cuatrimestre
Proyecto: AutoMarket
Descripción: Clase estática que almacena un arreglo de clientes y 
un contador para llevar el número de clientes almacenados.
Estudiante: Angie Angulo Chacón 
Fecha:22/02/2026
*/
using AutoMarket.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AutoMarket.Datos
{
    public static class Datos_Clientes
    {   // Arreglo de clientes
        public static Cliente[] clientes = new Cliente[5];
        // Contador para llevar el número de clientes almacenados
        public static int contadorClientes = 0;
    
     public static bool Agregar(Cliente nuevo)
        {
            if (contadorClientes >= 5)
                return false;

            // Validar identificación única
            for (int i = 0; i < contadorClientes; i++)
            {
                if (clientes[i].Identificacion == nuevo.Identificacion)
                    return false;
            }

            clientes[contadorClientes] = nuevo;
            contadorClientes++;
            return true;
        }

        public static int TotalRegistros()
        {
            return contadorClientes;
        }

        public static Cliente Obtener(int posicion)
        {
            if (posicion >= 0 && posicion < contadorClientes)
                return clientes[posicion];

            return null;
        }
    }

}
