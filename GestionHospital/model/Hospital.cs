using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionHospital.model
{
    public class Hospital
    {
        String nombre;

        List<Medico> personalMedico;
        List<Paciente> personalPaciente;

        public string Nombre { get => nombre; set => nombre = value; }
        public List<Medico> PersonalMedico { get => personalMedico; set => personalMedico = value; }

        public List<Paciente> PersonalPaciente { get => personalPaciente; set => personalPaciente = value; }
        public Hospital()
        {
            this.Nombre = "C# Salut";
            this.PersonalMedico = IniciarPersonalMedicoFijo();
            this.personalPaciente = new List<Paciente>();
        }

        public List<Medico> IniciarPersonalMedicoFijo()
        {
            List<Medico> listaMedicos = new List<Medico>();

            listaMedicos.Add(new Medico("Manuel", "Alvarez", 30, 0, "47776385K", 681062275, 256987134, "Cardiologo"));
            listaMedicos.Add(new Medico("Javier", "Alvarez", 22, 0, "45764820X", 684529822, 256987822, "Urologo"));
            listaMedicos.Add(new Medico("Vanesa", "Fernandez", 40, 1, "859547212k", 656789123, 102547896, "Ginecologa"));

            return listaMedicos;
        }

        public override string ToString()
        {
            return "Ficha Informacion del Hospital: " + Nombre + "\tTotal de personal: " + PersonalMedico.Count();
        }

        public void addMedico(Medico medico)
        {
            this.personalMedico.Add(medico);
        }

        public void ListarNombreMedicos()
        {
            int incremental = 0;
            foreach (Medico m in personalMedico) 
            {
                Console.WriteLine(incremental++ +") Nombre: "+m.Nombre+" "+m.Apellido+", Especialidad: "+m.Especialidad);
            
            }
        }

        public void ListarMedicos()
        {
            foreach (Medico m in personalMedico)
            {
                Console.WriteLine(m.ToString());

            }
        }

        public void ListarPacientes()
        {
            int incremental = 0;
            foreach (Paciente p in personalPaciente)
           
                Console.WriteLine(incremental++ + p.NombreCompleto());

        }

         public void ListarPersonasHospital()
        {
            Console.WriteLine("-- Medicos --");
            ListarMedicos();
            Console.WriteLine("-- Pacientes --");
            ListarPacientes();

        }


    }
}
