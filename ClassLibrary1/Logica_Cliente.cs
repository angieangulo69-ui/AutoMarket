using Entidades;
using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Logica_Cliente

    {
        public static bool Agregar(Cliente nuevo)
        {
            if (Datos_Clientes.ObtenerCantidad() >= 5)
                return false;

            // Validar identificación única
            for (int i = 0; i < Datos_Clientes.contadorClientes; i++)
            {
                if (Datos_Clientes.clientes[i].Identificacion == nuevo.Identificacion)
                    return false;
            }

            Datos_Clientes.clientes[Datos_Clientes.contadorClientes] = nuevo;
            Datos_Clientes.contadorClientes++;
            return true;
        }

        public static int TotalRegistros()
        {
            return Datos_Clientes.contadorClientes;
        }

        public static Cliente Obtener(int posicion)
        {
            if (posicion >= 0 && posicion < Datos_Clientes.ObtenerCantidad())
                return Datos_Clientes.clientes[posicion];

            return null;
        }
    }
}
