/*
Universidad:UNED
I Cuatrimestre
Proyecto: AutoMarket
Descripción: Clase estática que almacena un arreglo de vendedores y 
un contador para llevar el número de vendedores registradas.    
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
    public static class Datos_Vendedor
    { // Arreglo de vendedores
        public static Vendedor[] vendedor = new Vendedor[20];
        // Contador para llevar el número de vendedores almacenados
        public static int contadorvendedor = 0;
        // Método para agregar un nuevo vendedor al arreglo,
        // con validaciones para el límite de vendedores y la identificación única
    }  
}

    







