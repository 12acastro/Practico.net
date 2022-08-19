using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared;

namespace Practico1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona [] personas = new Persona[20];
            Console.WriteLine("Mi Primera App");
            int i=0;
            do
            {
                try
                {
                    Console.WriteLine("Nueva Persona");
                    Persona per = new Persona();
                    Console.WriteLine("Nombre: ");
                    per.Nombre = Console.ReadLine();
                    Console.WriteLine("Apellido: ");
                    per.Apellido = Console.ReadLine();
                    Console.WriteLine("Documento: ");
                    per.Documento = Console.ReadLine();
                    Console.WriteLine("Fecha Nacimiento: ");
                    Console.WriteLine("Dia: ");
                    string dia = Console.ReadLine();
                    Console.WriteLine("Mes: ");
                    string mes = Console.ReadLine();
                    Console.WriteLine("Anio: ");
                    string anio = Console.ReadLine();
                    per.FechaNacimiento = new DateTime(Int32.Parse(anio), Int32.Parse(mes), Int32.Parse(dia)); 
                    


                    Console.WriteLine("Persona");
                    Console.WriteLine("     Nombre: " + per.Nombre);
                    Console.WriteLine("     Documento: " + per.Documento);
                    
                    personas[i] = per;
                    i++;
                }
                catch(Exception ex)
                {
                    Console.WriteLine("ERROR: "+ ex.Message);
                }
            }

            while (!Console.ReadLine().Equals("EXIT"));

            for(int e =0; e<i; e++)
            {
                for(int j = i - 1;j>=e; j--)
                {
                    if (personas[j - 1].FechaNacimiento > personas[j].FechaNacimiento){
                        Persona p = personas[j - 1];
                        personas[j - 1] = personas[j];
                        personas[j] = p;
                    }
                }
            }

            for (int l = 0; l < i; l++)
            {
                Console.WriteLine(personas[l].Nombre + " " + personas[l].Apellido +" FN: " + personas[l].FechaNacimiento);
            }





        }
    }
}
