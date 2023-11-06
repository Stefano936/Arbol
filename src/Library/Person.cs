using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Person
    {
        public int Age { get; set; } // Cambiar "internal set" a "set"
        private string nombre;

        public Person(string nombre, int edad)
        {
            this.nombre = nombre;
            this.Age = edad; // Establecer la propiedad Age correctamente
        }

        public string GetNombre()
        {
            return this.nombre;
        }

        public int GetEdad()
        {
            return this.Age; // Cambiar this.edad a this.Age
        }

        public void SetEdad(int edad)
        {
            this.Age = edad; // Cambiar this.edad a this.Age
        }
    }
}
