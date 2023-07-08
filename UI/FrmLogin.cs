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
using static System.Runtime.CompilerServices.RuntimeHelpers;
using System.Xml.Linq;

namespace AppsControl_Inventario.UI
{
    public partial class FrmLogin : Form
    {
        bool isLogged = false; //Variable para determinar si se esta cumpliendo el proceso de login

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnAuth_Click(object sender, EventArgs e)
        {
            string filtre; //filtro por el cual se debe buscar el archivo
            bool found = false; //Variable de control del ciclo

            if (isLogged) //Si el campo usuario y clave tienen valor
            {
                //Establecer la ruta base de ejecución de la aplicación
                string basePath = Directory.GetCurrentDirectory();
                string filePath = basePath.Replace(@"\bin\Debug", @"\file\UserApps.txt");
                //Definir el objeto para la manipulación del archivo
                StreamReader readFile = new StreamReader(filePath);
                //Indicar la lectura de la primer linea del fichero
                filtre = readFile.ReadLine();
                //Iniciar la búsqueda del filtro
                while (!found && filtre != null)
                {
                    string[] line = filtre.Split(';');
                    if (line[0].Equals(TxtUsuario.Text) && line[1].Equals(TxtClave.Text))
                    {
                        //Si el usuario y la contraseña concuerda entonces indicar fin del ciclo y pase
                        found = true; //tomar la bandera a true paara que se salga de la busqueda
                    }//Fin de ciclo
                    //Si hay más linea que leer en el fichero y no concuerda la primer comparación
                    filtre = readFile.ReadLine();
                }//Fin de while
                readFile.Close(); //Cerrar el archivo luego que se ha salido del while
                //Si la bandera cambio a verdadero durante la búsqueda es que se encotro
                if (found)
                {
                    //Crear un elemento del formulario de producto que se mostrará
                    FrmMenu formMenu = new FrmMenu();
                    //Reiniciar nuevamente el valor de las cajas de texto en blanco el usuario ya inicio
                    TxtUsuario.Text = string.Empty;
                    TxtClave.Text = string.Empty;
                    //Cargar el formulario de menu
                    formMenu.Show();
                }
                else
                {
                    MessageBox.Show("El producto especificado \n no se ha encontrado", "Buscar Producto",
                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }//Fin de condicional if
            }//Fin If login valido
            
        }//Fin de BtnAutenticar

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void TxtUsuario_Validated(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtUsuario.Text))            
                isLogged = true;            
        }

        private void TxtClave_Validated(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty (TxtClave.Text))
                isLogged = true;
        }
    }//Fin de clase
}//Fin de espacio de nombres
