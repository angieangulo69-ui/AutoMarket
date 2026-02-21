/*
Universidad:UNED
I Cuatrimestre
Proyecto: AutoMarket
Descripción: Clase que representa una persona, con propiedades para el ID, 
identificación, nombre completo y fecha de nacimiento.
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
   public class Persona
    { //Propiedades de la clase Persona
        public int Id { get; set; }
        public string Identificacion { get; set; }
        public string NombreCompleto { get; set; }
        public DateTime FechaNacimiento { get; set; }
        //Constructor de la clase Persona para inicializar las propiedades
        public Persona(int id, string identificacion, string nombre, DateTime fechaNacimiento)
        {
            Id = id;
            Identificacion = identificacion;
            NombreCompleto = nombre;
            FechaNacimiento = fechaNacimiento;
        }
        //Sobrescribe el método ToString para mostrar el nombre completo de la persona
        public override string ToString()
        {
            return NombreCompleto;
        }
        public virtual string ObtenerTipo()
        {
            return "Persona";
        }
    }
}
