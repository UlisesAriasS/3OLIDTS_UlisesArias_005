using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3OLIDTS_UlisesArias_005
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Obtener los datos de la\os Textbox
            string nombres = tbNombre.Text;
            string apellidos = tbApellido.Text;
            string edad = tbEdad.Text;
            string estatura = tbEstatura.Text;
            string telefono = tbTelefono.Text;
            
            //Obtener el genero selecionado
            string genero = "";
            if (rbHombre.Checked)
            {
                genero = "Hombre";
            }
            else if (rbMujer.Checked)
            {
                genero = "Mujer";
            }
            //Crear una cadena de los datos 
            string datos = $"Nombres: {nombres}\r\nApellidos: {apellidos}\r\nTelefono: {telefono} kg\r\nEstatura: {estatura} cm\r\nEdad: {edad} años\r\nGénero: {genero}";
            
            //Guardar los datos en un archivo de texto
            string rutaArchivo = "C:/Users/Chauk/OneDrive/Escritorio/Tareas 3ro/Programacion avanzada/Proyectos/datos.txt";
            //File.WriteliAllText(rutaArchivo, datos);
            //Verificar si el archivo ya existe 
            bool archivoExiste = File.Exists(rutaArchivo);

            using (StreamWriter writer = new StreamWriter(rutaArchivo, true))
            {
                if(archivoExiste)
                {
                    //Si el archivo existe, añadir un separador antes del nuevo registro
                    writer.WriteLine();
                }
                writer.WriteLine(datos);



            }

            //Mostrar un mensaje con los datos capturados
            MessageBox.Show("Datos guardados con éxitos:\n\n" + datos, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            //Limpiar los controles despues de guardar 
            tbNombre.Clear();
            tbApellido.Clear();
            tbEstatura.Clear();
            tbTelefono.Clear();
            tbEdad.Clear();
            rbHombre.Checked = false;
            rbMujer.Checked = false;

        }
    }
}
