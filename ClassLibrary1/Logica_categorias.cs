using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using AccesoDatos;

namespace Logica
{
    public class Logica_categorias
    {
        public  bool Agregar(CategoriaVehiculo nueva)
        {
            if (Datos_Categorias.contadorCategorias >= 20)
            {
                return false;
            }
                // Validar nombre único
                for (int i = 0; i < Datos_Categorias.contadorCategorias; i++)
                {
                    if (Datos_Categorias.categorias[i].NombreCategoria.ToLower() ==
                           nueva.NombreCategoria.ToLower())
                        return false;
                }
                Datos_Categorias.categorias[Datos_Categorias.contadorCategorias] = nueva;
                Datos_Categorias.contadorCategorias++;

                return true;
            }
        

        public static int TotalRegistros()
        {
            return Datos_Categorias.contadorCategorias;
        }

        //buscar y devolver una categoría del arreglo según su posición.
        public static CategoriaVehiculo Obtener(int posicion)
        {
            if (posicion >= 0 && posicion < Datos_Categorias.contadorCategorias)
                return Datos_Categorias.categorias[posicion];

            return null;
        }
    }
}
