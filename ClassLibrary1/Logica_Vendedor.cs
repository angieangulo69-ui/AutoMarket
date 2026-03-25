using Entidades;
using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public  class Logica_Vendedor
    { 
        public bool AgregarVendedor(Vendedor nuevo)
    {
        if (Datos_Vendedor.contadorvendedor >= 20)
            return false;

        if (ExisteIdentificacion(nuevo.Identificacion))
            return false;

        Datos_Vendedor.vendedor[Datos_Vendedor.contadorvendedor] = nuevo;
        Datos_Vendedor.contadorvendedor++;
        return true;
    }
    // Método para verificar si una identificación ya existe en el arreglo de vendedores
    public static bool ExisteIdentificacion(string identificacion)
    {
        for (int i = 0; i < Datos_Vendedor.contadorvendedor; i++)
        {
            if (Datos_Vendedor.vendedor[i].Identificacion == identificacion)
                return true;
        }
        return false;
    }
    // Método para obtener el arreglo de vendedores registrados
    public static Vendedor[] ObtenerVendedores()
    {
        return Datos_Vendedor.vendedor;
    }
    // Método para obtener la cantidad de vendedores registrados
    public static int ObtenerCantidad()
    {
        return Datos_Vendedor.contadorvendedor;
    }
}
}
