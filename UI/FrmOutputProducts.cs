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
using static System.Net.WebRequestMethods;

namespace AppsControl_Inventario.UI
{
    public partial class FrmOutputProducts : Form
    {
        public FrmOutputProducts()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            FileStream fs; //Preparar un objeto que permita modificar el fichero
            StreamWriter writeFile; //Objeto para manejar la excritura en el fichero
            string line; //Variable por medio de la cual se tomaran los datos a escribir

            //Determinar donde se encuentra el directorio raiz de la aplicación
            string basePath = Directory.GetCurrentDirectory();
            //Definir la ruta en donde se va a crear el archivo
            string filePath = basePath.Replace(@"\bin\Debug", @"\file\OutputProducts.txt");
            //Crear el objeto para trabajar con el archivo
            fs = new FileStream(filePath, FileMode.Append);

            //Crear el objeto para la escritura en el archivo
            writeFile = new StreamWriter(fs);
            //Proceder con el guardado de los datos del formulario
            line = TxtProductos.Text + ";"; //tomar el texto que esta en el control TxtCode            
            line += TxtUnits.Text + ";";
            line += TxtPrice.Text + ";";            
            line += CmbMonth.SelectedItem as string; //Tomar como cadena el valor del combo

            //Escribir en el archivo lo que se tiene capturado en la variable line
            writeFile.WriteLine(line.ToUpper()); //Pasar a mayuscula todo el texto
            writeFile.Close(); //Cerrar el archivo y escribir la salida

            //Hacer que el boton guardar no se pueda utilizar para no repetir duplicidad
            BtnSave.Enabled = false;
            //Mostrar la barra de progreso
            ProgBars.Visible = true; //Mandar a visulaizar la barra de progreso
            Load_ProgresBar();

            MessageBox.Show("Salida del producto registrada", "Registro de Salidas"
                , MessageBoxButtons.OK, MessageBoxIcon.Information);
        }//Fin de boton guardar

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            //Establecer la ruta base de ejecución de la aplicación
            string basePath = Directory.GetCurrentDirectory();
            string filePath = basePath.Replace(@"\bin\Debug", @"\file\OutputProducts.txt");
            //Establecer una variable de filtro de búsqueda
            string filtre; //filtro por el cual se debe buscar el archivo
            bool found = false; //Variable de control del ciclo
            //Definir el objeto para la manipulación del archivo
            StreamReader readFile = new StreamReader(filePath);
            //Indicar el filtro de la primera linea
            filtre = readFile.ReadLine();

            //Preparar los controles de texto para los datos recuperados
            TxtProductos.Text = string.Empty;            
            TxtUnits.Text = string.Empty;
            TxtPrice.Text = string.Empty;            
            CmbMonth.SelectedIndex = 0;

            //Iniciar la búsqueda del filtro
            while (!found && filtre != null)
            {
                string[] line = filtre.Split(';');
                if (line[0].Equals(TxtProductos.Text))
                {
                    TxtUnits.Text += line[1];
                    TxtPrice.Text += line[2];
                    CmbMonth.SelectedItem = line[3];
                    found = true; //tomar la bandera a true paara que se salga de la busqueda
                }

                filtre = readFile.ReadLine();
            }//Fin de while
            readFile.Close(); //Cerrar el asrchivo
            if (!found)
            {
                MessageBox.Show("El producto especificado \n no se ha encontrado", "Buscar Producto",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }//Fin de condicional if
        }//Fin de método

        private void BtnNew_Click(object sender, EventArgs e)
        {
            TxtProductos.Text = string.Empty;            
            TxtUnits.Text = string.Empty;
            TxtPrice.Text= string.Empty;
            CmbMonth.SelectedIndex=0;

            //Verificar si esta disponible el boton guardar
            if (!BtnSave.Enabled)
                BtnSave.Enabled = true;
        }//Fin de BtnNew
        private void BtnExit_Click(object sender, EventArgs e)
        {
            FrmMenu frmMnu = new FrmMenu();
            frmMnu.Show();
            this.Close();        
        }
        private void Load_ProgresBar()
        {
            for (int i = 0; i <= 100; i++)
            {
                ProgBars.Value = i;
                ProgBars.Refresh();
                System.Threading.Thread.Sleep(30);//Establecer una pausa simulada
            }//Fin de la instrucción for
            ProgBars.Visible = false;
        }//Fin de método

        private void FrmOutputProducts_Load(object sender, EventArgs e)
        {
           CmbMonth.SelectedIndex = 0;
        }

    }//Fin de la clase

}//Fin del espacio de nombre
