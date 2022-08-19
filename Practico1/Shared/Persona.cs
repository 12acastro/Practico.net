using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    // internal class Persona
    public class Persona
    {
        public string Nombre { get; set; } = "-- Sin Nombre --";

        private string documento = "";
        public string Documento
        { 
            get { return documento; } 
            set {
                if (value.Length < 7)
                    throw new Exception("Formato de documento incorrecto.");
                else
                    documento = value.ToUpper();
                } 
        

        }
        public string Apellido = "-- Sin Apellido --";

        public DateTime FechaNacimiento;

    }
}
