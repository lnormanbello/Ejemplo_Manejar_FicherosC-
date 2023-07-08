using AppsControl_Inventario.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppsControl_Inventario
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void BtnInputProducts_Click(object sender, EventArgs e)
        {
            FrmInputProducts frmProducts = new FrmInputProducts();
            this.Close();
            frmProducts.Show();
        }

        private void BtnSale_Click(object sender, EventArgs e)
        {
            FrmSales frmSales = new FrmSales();
            this.Close();
            frmSales.Show();
        }

        private void BtnOutProducts_Click(object sender, EventArgs e)
        {
            FrmOutputProducts frmOut = new FrmOutputProducts();
            this.Close();
            frmOut.Show();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSeller_Click(object sender, EventArgs e)
        {
            
        }//Fin de método

    }//Fin de clase
}//Fin de Espacio de nombres
