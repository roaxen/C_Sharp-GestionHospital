namespace GestionHospital.model
{
    public class Paciente: Persona
    {
        int numeroPaciente;
        string enfermedad;

        public int NumeroPaciente { get => numeroPaciente; set => numeroPaciente = value; }
        public string Enfermedad { get => enfermedad; set => enfermedad = value; }

        public Paciente(Persona persona ) : base ( persona ) 
        {

        }

        public Paciente(Persona persona, int numeroPaciente, string enfermedad) : base(persona)
        {
            this.numeroPaciente=numeroPaciente;
            this.enfermedad=enfermedad;
        }

        public override string ToString()
        {
            return "\nFicha Paciente:\n\tNumero Paciente: " + numeroPaciente + "\nEnfermedad: " + enfermedad + "\n" + base.ToString() + "\n";
        }


    }
}