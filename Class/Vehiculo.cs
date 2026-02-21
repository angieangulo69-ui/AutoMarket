/*
Universidad: UNED
I Cuatrimestre
Proyecto: AutoMarket
Descripción: Clase que representa un vehículo, con propiedades para el ID,
marca, modelo, año, precio, categoría y estado (nuevo o usado).
Estudiante: Angie Angulo Chacon 
Fecha:22/02/2026
*/
using AutoMarket.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMarket
{
   public  class Vehiculo
    { //Propiedades de la clase Vehiculo
        public int IdVehiculo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Anio { get; set; }
        public decimal Precio { get; set; }
        public CategoriaVehiculo Categoria { get; set; }
        public char Estado { get; set; }

        //Constructor de la clase Vehiculo para inicializar las propiedades, con validación para el estado
        public Vehiculo(int id, string marca, string modelo, int anio,
                        decimal precio, CategoriaVehiculo categoria, char estado)
        {
            if (estado != 'N' && estado != 'U')
                throw new ArgumentException("Estado inválido. Debe ser 'N' (Nuevo) o 'U' (Usado).");

            IdVehiculo = id;
            Marca = marca;
            Modelo = modelo;
            Anio = anio;
            Precio = precio;
            Categoria = categoria;
            Estado = estado;
        }
        //Sobrescribe el método ToString para mostrar la marca, modelo y año del vehículo
        public override string ToString()
        {
            return Marca + " " + Modelo + " (" + Anio + ")";
        }

    }

}

