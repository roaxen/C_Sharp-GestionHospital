using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionHospital.model
{
    public class Persona
    {

        private String nombre;
        private String apellido;
        private int edad;
        private int sexo;
        private String dni;
        private String email;
        private int telefono;
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Edad { get => edad; set => edad = value; }
        public int Sexo { get => sexo; set => sexo = value; }
        public string Dni { get => dni; set => dni = value; }
        public string Email { get => email; set => email = value; }
        public int Telefono { get => telefono; set => telefono = value; }
     
        public Persona()
        {
            this.nombre = "desconoido";
        }
                          
        public Persona(string nombre, String apellido, int edad, int sexo, string dni, int telefono)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = sexo;
            this.dni = dni;
            this.email = nombre.ToLower() + "_" + apellido.ToLower()+"@gmail.com";
            this.telefono = telefono;
        }

        public Persona(Persona persona)
        {
            this.nombre = persona.nombre;
            this.apellido = persona.apellido;
            this.edad = persona.edad;
            this.sexo = persona.sexo;
            this.dni = persona.dni;
            this.email = persona.email;
            this.telefono = persona.telefono;
        }

        public override string ToString()
        {
            string sexoString = "Desconocido";
            if (sexo == 0)
                sexoString = "Hombre";
            else if (sexo == 1)
                sexoString = "Mujer";

            return "\nDatos Personales:\n\tDNI: " + dni + "\n\tNombre: " + nombre + "\n\tApellido: " + apellido + "\n\tEdad: " + edad + "\n\tSexo: "
                + sexoString + "\n\tEmail: " + email + "\n\tTelefono: " + telefono;
        }

        public string NombreCompleto() 
        {

            return nombre + " " + apellido;
        }
    }
}
