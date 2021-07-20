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

        //Miembro constructor parametrizado es decir que se construye a base de parámetros
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
            if (edad == 1)
            {
                Console.WriteLine("Hola, soy {0} {1} y tengo {2} año de edad. Mi color de ojos es {3}", primerNombre, apellido, edad , colorOjos);
            }
            else
            {
                Console.WriteLine("Hola, soy {0} {1} y tengo {2} años de edad. Mi color de ojos es {3}", primerNombre, apellido, edad, colorOjos);
            }
            
        }
    }
}
