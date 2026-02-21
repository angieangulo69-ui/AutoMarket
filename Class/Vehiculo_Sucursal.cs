/*
Universidad:UNED
I Cuatrimestre
Proyecto: AutoMarket
Descripción:
Estudiante: Angie Angulo Chacón 
Fecha:22/02/2026
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AutoMarket.Class
{
    public class Vehiculo_Sucursal
    {
        public Sucursal Sucursal { get; set; }
        public Vehiculo Vehiculo { get; set; }
        public int Cantidad { get; set; }

        public Vehiculo_Sucursal(Sucursal sucursal, Vehiculo vehiculo, int cantidad)
        {
            if (!sucursal.Activo)
                throw new ArgumentException("No se pueden asociar vehículos a sucursales inactivas.");

            if (cantidad <= 0)
                throw new ArgumentException("La cantidad debe ser mayor que cero.");

            Sucursal = sucursal;
            Vehiculo = vehiculo;
            Cantidad = cantidad;
        }
    }
}
