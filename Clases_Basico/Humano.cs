using System;
namespace Clases_Basico
{
    public class Humano
    {

            //Miembro variable
        private string primerNombre;
        private string apellido;
        private string colorOjos;
        private int edad;

        //Miembro constructor
        public Humano(string primerNombre, string apellido, string colorOjos, int edad)
        {

            this.primerNombre = primerNombre;
            //this hace referencia de la variable local del constructor
            this.apellido = apellido;
            this.colorOjos = colorOjos;
            this.edad = edad;

        }
        
        //Miembro método
        public void presentarme()
        {
            Console.WriteLine("Hola, soy {0} {1} {2} {3}" , primerNombre, apellido, colorOjos,edad);
        }
    }
}
