/*
Universidad:UNED
I Cuatrimestre
Proyecto: AutoMarket
Descripción: Clase que representa un vendedor, que hereda de la clase Persona y agrega propiedades específicas
Estudiante: Angie Angulo Chacón 
Fecha:22/02/2026
*/using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMarket.Class
{
    // La clase Vendedor hereda de la clase Persona y agrega propiedades específicas
    // para un vendedor, como la fecha de ingreso y el teléfono.
    public class Vendedor : Persona
    {
        public DateTime FechaIngreso { get; set; }
        public string Telefono { get; set; }

        // Constructor de la clase Vendedor que llama al constructor de la clase base (Persona)
        public Vendedor(int id, string identificacion, string nombre,
                      DateTime fechaNacimiento, DateTime fechaIngreso, string telefono)
          : base(id, identificacion, nombre, fechaNacimiento)
        {
            FechaIngreso = fechaIngreso;
            Telefono = telefono;
        }
        // Sobrescribe el método ToString para mostrar el nombre completo del vendedor junto con su rol
        public override string ToString()
        {
            return NombreCompleto + " - Vendedor";
        }
        public override string ObtenerTipo()
        {
            return "Vendedor";
        }
    }
}
    

