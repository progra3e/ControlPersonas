using System;
using System.Collections.Generic;
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
            int mes = fechaNacimiento.Month;
            int año = fechaNacimiento.Year;

            //Calcular edad
            return 0;
        }

        public void normalizaNombre()
        { 
            //Hacer todo el proceso
            
        }
       

    }
}
