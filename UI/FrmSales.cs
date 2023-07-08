using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppsControl_Inventario.UI
{
    public partial class FrmSales : Form
    {
        public FrmSales()
        {
            InitializeComponent();
        }

        private void FrmSales_Load(object sender, EventArgs e)
        {
            CmbCash.SelectedIndex = 0;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            FileStream fs; //Preparar un objeto que permita modificar el fichero
            StreamWriter writeFile; //Objeto para manejar la excritura en el fichero
            string line; //Variable por medio de la cual se tomaran los datos a escribir

            //Determinar donde se encuentra el directorio raiz de la aplicación
            string basePath = Directory.GetCurrentDirectory();
            //Definir la ruta en donde se va a crear el archivo
            string filePath = basePath.Replace(@"\bin\Debug", @"\file\AnnualSales.txt");
            //Crear el objeto para trabajar con el archivo
            fs = new FileStream(filePath, FileMode.Append);

            //Crear el objeto para la escritura en el archivo
            writeFile = new StreamWriter(fs);
            //Proceder con el guardado de los datos del formulario
            line = CmbCash.SelectedItem as string + ";";
            line += TxtQuarter1.Text + ";";
            line += TxtQuarter2.Text + ";";
            line += TxtQuarter3.Text + ";";
            line += TxtQuarter4.Text + ";";
            line += TxtTotal.Text + ";";
            line += TxtGoal.Text + ";";

            //Escribir en el archivo lo que se tiene capturado en la variable line
            writeFile.WriteLine(line.ToUpper()); //Pasar a mayuscula todo el texto
            writeFile.Close(); //Cerrar el archivo y escribir la salida

            //Hacer que el boton guardar no se pueda utilizar para no repetir duplicidad
            BtnSave.Enabled = false;
            //Mostrar la barra de progreso
            ProgBar.Visible = true; //Mandar a visulaizar la barra de progreso
            Load_ProgresBar();

            MessageBox.Show("Salida del producto registrada", "Registro de Salidas"
                , MessageBoxButtons.OK, MessageBoxIcon.Information);
        }//Fin de método

        private void Load_ProgresBar()
        {
            for (int i = 0; i <= 100; i++)
            {
                ProgBar.Value = i;
                ProgBar.Refresh();
                System.Threading.Thread.Sleep(30);//Establecer una pausa simulada
            }//Fin de la instrucción for
            ProgBar.Visible = false;
        }//Fin de método

        private void BtnExit_Click(object sender, EventArgs e)
        {
            FrmMenu frmMnu = new FrmMenu();
            frmMnu.Show();
            this.Close();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            CmbCash.SelectedIndex = 0;
            TxtQuarter1.Text = string.Empty;
            TxtQuarter2.Text = string.Empty;
            TxtQuarter3.Text = string.Empty;
            TxtQuarter4.Text = string.Empty;
            TxtTotal.Text = string.Empty;
            TxtGoal.Text = string.Empty;

            //Verificar si esta disponible el boton guardar
            if (!BtnSave.Enabled)
                BtnSave.Enabled = true;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            //Establecer la ruta base de ejecución de la aplicación
            string basePath = Directory.GetCurrentDirectory();
            string filePath = basePath.Replace(@"\bin\Debug", @"\file\AnnualSales.txt");
            //Establecer una variable de filtro de búsqueda
            string filtre; //filtro por el cual se debe buscar el archivo
            bool found = false; //Variable de control del ciclo
            //Definir el objeto para la manipulación del archivo
            StreamReader readFile = new StreamReader(filePath);
            //Indicar el filtro de la primera linea
            filtre = readFile.ReadLine();

            //Preparar los controles de texto para los datos recuperados
            TxtQuarter1.Text = string.Empty;
            TxtQuarter2.Text = string.Empty;
            TxtQuarter3.Text = string.Empty;
            TxtQuarter4.Text = string.Empty;
            TxtTotal.Text = string.Empty;
            TxtGoal.Text = string.Empty;

            //Iniciar la búsqueda del filtro
            while (!found && filtre != null)
            {
                string[] line = filtre.Split(';');
                if (line[0].Equals(CmbCash.SelectedItem as string))
                {
                    TxtQuarter1.Text = line[1];
                    TxtQuarter2.Text = line[2];
                    TxtQuarter3.Text = line[3];
                    TxtQuarter4.Text = line[4];
                    TxtTotal.Text = line[5];
                    TxtGoal.Text = line[6];
                    found = true; //tomar la bandera a true paara que se salga de la busqueda
                }//Fin condicional IF

                filtre = readFile.ReadLine();
            }//Fin de while
            readFile.Close(); //Cerrar el asrchivo
            if (!found)
            {
                MessageBox.Show("El producto especificado \n no se ha encontrado", "Buscar Producto",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }//Fin de condicional if
        }

        private void TxtQuarter4_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            MessageBox.Show("Hola");
        }

        private void TxtQuarter4_Leave(object sender, EventArgs e)
        {
            //Recoger los valores de las cajas de texto de los trimestres
            int suma; //Variable Acumuladora

            suma = int.Parse(TxtQuarter1.Text) + int.Parse(TxtQuarter2.Text) + 
                   int.Parse(TxtQuarter3.Text) + int.Parse(TxtQuarter4.Text);
            TxtTotal.Text += suma;            
        }
    }//Fin de clase

}//Fin de espacio de nombres
