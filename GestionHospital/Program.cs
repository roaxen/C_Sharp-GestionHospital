using GestionHospital.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionHospital
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MenuPrincipal();
        }

        public static void MenuPrincipal() 
        {
            bool salir = false;

            Hospital hospital = new Hospital();
            while (!salir)
            {
                ConsoleMenuPrincipal();

                int opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1: 
                        hospital.addMedico(CrearMedico());
                        break;

                    case 2: 
                        AltaPaciente(hospital);
                        break;

                    case 3: 
                        hospital.ListarMedicos();
                        break;

                    case 4: 
                        ListarPacienteDeMedico(hospital);
                        break;

                    case 5: 
                        EliminarPaciente(hospital);
                        break;

                    case 6: 
                        hospital.ListarPersonasHospital();
                        break;

                    case 7:
                        salir = true;
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }

        private static void EliminarPaciente(Hospital hospital)
        {
            if (hospital.PersonalPaciente.Count() == 0)
                Console.WriteLine("No hay pacientes en el Hospital");
            else 
            {
                hospital.ListarPacientes();
                int posPaciente = int.Parse(Console.ReadLine());
                hospital.PersonalPaciente.RemoveAt(posPaciente);

            }
        }

        public static void ConsoleMenuPrincipal()
        {
            Console.WriteLine("\n--- MENÚ HOSPITAL ---");
            Console.WriteLine("1) Dar de alta un médico");
            Console.WriteLine("2) Dar de alta un paciente para un médico concreto");
            Console.WriteLine("3) Listar los médicos");
            Console.WriteLine("4) Listar los pacientes de un médico");
            Console.WriteLine("5) Eliminar a un paciente");
            Console.WriteLine("6) Ver la lista de personas presentes en el hospital");
            Console.WriteLine("7) Salir");
            Console.Write("Seleccione una opción: ");

        }


        public static Persona GenerarPersona()  
        {
            Persona persona = new Persona();

            Console.WriteLine("Informacion de Persona:");
            Console.WriteLine("\tNombre: ");
            persona.Nombre= Console.ReadLine();

            Console.WriteLine("\tApellido: ");
            persona.Apellido = Console.ReadLine();

            Console.WriteLine("\tEdad: ");
            persona.Edad = int.Parse(Console.ReadLine());

            Console.WriteLine("\tSexo:(0-Masculino\\1-Femenino\\2-Otros) ");
            persona.Sexo = int.Parse(Console.ReadLine());

            Console.WriteLine("\tDni: ");
            persona.Dni = Console.ReadLine();

            Console.WriteLine("\tTelefono: ");
            persona.Telefono = int.Parse(Console.ReadLine());

            return persona;
        }

        public static Medico CrearMedico() 
        {
          Persona persona = GenerarPersona();

            Console.WriteLine("\tInformacion Personal Medico :");
            Console.WriteLine("Numero Colegiado: ");
            int numeroColegiado = int.Parse(Console.ReadLine());

            Console.WriteLine("Especialidad: ");
            String especialidad = Console.ReadLine();

            return (new Medico(persona, numeroColegiado, especialidad));
        }

        public static Paciente CrearPaciente()
        {
            Persona persona = GenerarPersona();

            Console.WriteLine("\tInformacion Paciente :");
            Console.WriteLine("Numero Paciente: ");
            int numeroPaciente = int.Parse(Console.ReadLine());

            Console.WriteLine("Enfermedad: ");
            String enfermedad = Console.ReadLine();

            // MIRAR SI PONEMOS AQUI LA ASIGNACION DE PACIENTES O SE HACE EN OTRO LADO 
            return (new Paciente(persona, numeroPaciente, enfermedad));
        }

        public static void AltaPaciente(Hospital hospital) 
        {
            Paciente paciente = CrearPaciente();

            hospital.PersonalPaciente.Add(paciente);
            // a que medico quieres asignarlo 
            hospital.ListarNombreMedicos();
            //accion de asignar un medico 
            int posMedico = int.Parse(Console.ReadLine());
            
            hospital.PersonalMedico[posMedico].addPaciente(paciente);

        }

        public static void ListarPacienteDeMedico(Hospital hospital) 
        {
            Console.WriteLine("La lista de pacientes de que medico quieres consultar ? ");

            hospital.ListarNombreMedicos();
            int  posMedico = int.Parse(Console.ReadLine());
            hospital.PersonalMedico[posMedico].ListarPacientes();

        }
    }
}
