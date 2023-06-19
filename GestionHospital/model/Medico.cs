using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionHospital.model
{
    public class Medico : Persona
    {
        private int numeroColegiado;
        private String especialidad;
        private List<Paciente> listaPacientes;

        public int NumeroColegiado { get => numeroColegiado; set => numeroColegiado = value; }
        public string Especialidad { get => especialidad; set => especialidad = value; }
        public List<Paciente> ListaPacientes { get => listaPacientes; set => listaPacientes = value; }

        public Medico() 
        {
        }

        public Medico(Persona persona, int numeroColegiado, string especialidad) : base(persona)
        {
            this.numeroColegiado = numeroColegiado;
            this.especialidad = especialidad;
            this.ListaPacientes = new List<Paciente>();
        }

        public Medico(string nombre, String apellido, int edad, int sexo, string dni, int telefono, int numeroColegiado, string especialidad) : base(nombre, apellido, edad, sexo, dni, telefono)
        {
            this.numeroColegiado = numeroColegiado;
            this.especialidad = especialidad;
            this.ListaPacientes = new List<Paciente>();
        }


        public override string ToString()
        {
            return "\nFicha Medico:\n\tNumero Colegiado: " + numeroColegiado + "\n\tEspecialidad: " + especialidad + "\n\tNumero de pacientes: " + listaPacientes.Count() + "\n"+base.ToString()+"\n";
        }


        public void ListarPacientes() 
        {
            if (listaPacientes.Count() != 0)
            {
                foreach (Paciente p in listaPacientes)
                {
                    Console.WriteLine(p.ToString());
                }
            }
            else 
                Console.WriteLine("Este Medico no teine pacientes asignados");

        }

        public void addPaciente(Paciente paciente)
        {
            listaPacientes.Add(paciente);
        }
    }
}
