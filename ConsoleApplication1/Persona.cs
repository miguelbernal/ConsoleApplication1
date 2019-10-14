using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ConsoleApplication1
{
    public class Persona
    {
        private int id;
        private string nombre;
        private float estatura;
        private bool mayorEdad;

        public Persona()
        {
        }

        public Persona(int id, string nombre, float estatura, bool mayorEdad)
        {
            this.id = id;
            this.nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));
            this.estatura = estatura;
            this.mayorEdad = mayorEdad;
        }

        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }

        public float Estatura
        {
            get => estatura;
            set => estatura = value;
        }

        public bool MayorEdad
        {
            get => mayorEdad;
            set => mayorEdad = value;
        }

        public override string ToString()
        {
            Dictionary<string, dynamic> persona = new Dictionary<string, dynamic>();
            persona.Add("id",this.id); 
            persona.Add("nombre",this.nombre);
            persona.Add("estatura",this.estatura);
            persona.Add("mayorEdad",this.mayorEdad);
            return  JsonConvert.SerializeObject(persona);
        }
    }
}