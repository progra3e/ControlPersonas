﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlPersonas
{
    public partial class Form1 : Form
    {
        //Clase  objeto
        //Instanciar la clase
        
        


        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //Clase objeto
        //Instanciar una clase:
        //Crear un objeto de esa clase
        Persona persona = new Persona();        

        private void buttonIngreso_Click(object sender, EventArgs e)
        {
            
            persona.Dpi = textBoxDpi.Text;
            persona.Nombre = textBoxNombre.Text;
            persona.Apellido = textBoxApellido.Text;
            persona.FechaNacimiento = dateTimePicker1.Value;
                        
        }

        //Muestra los datos en la pantalla
        private void Mostrar()
        {
            labelDpi.Text = persona.Dpi;
            labelNombre.Text = persona.Nombre;
            labelApellido.Text = persona.Apellido;
            labelFecha.Text = persona.FechaNacimiento.ToShortDateString();

            labelDpi.Visible = true;
            labelNombre.Visible = true;
            labelApellido.Visible = true;
            labelFecha.Visible = true;
        }

        private void buttonMostrar_Click(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void buttonPrimeraMayuscula_Click(object sender, EventArgs e)
        {
            //persona.PrimeraMayuscula();
            int edad = persona.edad();
            persona.normalizaNombre();
            labelNombre.Text = persona.Nombre;
            labelApellido.Text = persona.Apellido;

        }
    }
}
