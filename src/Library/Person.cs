using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Person
    {
        private int edad;
        private string nombre;
        
        public Person(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }
        public string GetNombre(string nombre)
        {
            return this.nombre;
        }
        public int GetEdad(int edad)
        {
            return this.edad;
        }

        public void SetEdad(int edad)
        {
            this.edad = edad;
        }
    }
}
