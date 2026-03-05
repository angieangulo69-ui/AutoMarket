/*
Universidad:UNED
I Cuatrimestre
Proyecto: AutoMarket
Descripción: Clase estática que almacena un arreglo de vendedores y 
un contador para llevar el número de vendedores registradas.    
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
    public static class Datos_Vendedor
    { // Arreglo de vendedores
        public static Vendedor[] vendedor = new Vendedor[20];
        // Contador para llevar el número de vendedores almacenados
        public static int contadorvendedor = 0;
        // Método para agregar un nuevo vendedor al arreglo,
        // con validaciones para el límite de vendedores y la identificación única
        public static bool AgregarVendedor(Vendedor nuevo)
        {
            if (contadorvendedor >= 20)
                return false;

            if (ExisteIdentificacion(nuevo.Identificacion))
                return false;

            vendedor[contadorvendedor] = nuevo;
            contadorvendedor++;
            return true;
        }
        // Método para verificar si una identificación ya existe en el arreglo de vendedores
        public static bool ExisteIdentificacion(string identificacion)
        {
            for (int i = 0; i < contadorvendedor; i++)
            {
                if (vendedor[i].Identificacion == identificacion)
                    return true;
            }
            return false;
        }
        // Método para obtener el arreglo de vendedores registrados
        public static Vendedor[] ObtenerVendedores()
        {
            return vendedor;
        }
        // Método para obtener la cantidad de vendedores registrados
        public static int ObtenerCantidad()
        {
            return contadorvendedor;
        }
    }
}

    







