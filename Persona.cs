using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlPersonas
{
    class Persona
    {
        //Campos 
        //Privados para cumplir con
        //el encapsulado

        string dpi;
        string nombre;
        string apellido;
        //Camel case
        DateTime fechaNacimiento;        

        //Encapsulado
        public String Dpi { get => dpi; set => dpi = value; }
        public String Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public DateTime FechaNacimiento { 
            get => fechaNacimiento; set => fechaNacimiento = value; 
        }

        //Métodos: Acciones que se realizan

        //Constructor de la clase:
        //Codigo que se ejecuta al crearse un objeto de esta clase
        //por ejemplo inicializar variables
        public Persona()
        {
            dpi = "";
            nombre = "";
            apellido = "";
            //inicializar con la fecha de hoy
            fechaNacimiento = DateTime.Now;
        }

        //Convierte la primera letra en mayuscula
        public void PrimeraMayuscula ()
        {            
            if (nombre.Length > 0) 
            {
                StringBuilder nombreMayuscula = new StringBuilder(nombre);
                nombreMayuscula[0] = Char.ToUpper(nombreMayuscula[0]);               
                nombre = nombreMayuscula.ToString();                
                
            }
            if (apellido.Length > 0)
            {
                StringBuilder apellidoMayuscula = new StringBuilder(apellido);
                apellidoMayuscula[0] = Char.ToUpper(apellidoMayuscula[0]);
                apellido = apellidoMayuscula.ToString();
            }
        }

        public int edad()

        {            
​            DateTime hoy = DateTime.Today;
         
            int edad = hoy.Year - fechaNacimiento.Year;
              
           if (fechaNacimiento.Month > hoy.Month)
            {
                --edad;
            }                
            
​            return edad;
​        }
        public int edadv2()
        {            
            DateTime hoy = DateTime.Now;            

            TimeSpan intervalo = hoy - fechaNacimiento;   
                        
            return (intervalo.Days / 365); ;
        }

        public void normalizaNombre()
        {
            string nombre2 = "";
            nombre = nombre.Trim();
            
            nombre2 += char.ToUpper(nombre[0]);
                        
            for (int x = 1; x < nombre.Length; x++)
            {
                if (nombre[x - 1] == ' ')
                {
                    if (char.IsLetter(nombre[x]) || char.IsWhiteSpace(nombre[x]))
                        nombre2 = nombre + char.ToUpper(nombre[x]);
                }
                else
                  if (char.IsLetter(nombre[x]) || char.IsWhiteSpace(nombre[x]))
                    nombre2 += nombre[x];
                // nombre2 = nombre2 + nombre[x]

            }            
        }

        public void normalizaNombrev2()
        {
            
            nombre = nombre.Trim();
            nombre = CultureInfo.InvariantCulture
                    .TextInfo.ToTitleCase(nombre);

        }


    }
}
