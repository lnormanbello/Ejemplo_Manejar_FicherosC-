namespace AppsControl_Inventario
{
    partial class FrmMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnSeller = new System.Windows.Forms.Button();
            this.BtnInputProducts = new System.Windows.Forms.Button();
            this.BtnOutProducts = new System.Windows.Forms.Button();
            this.BtnSale = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppsControl_Inventario.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(51, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BtnSeller
            // 
            this.BtnSeller.BackColor = System.Drawing.Color.Orange;
            this.BtnSeller.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSeller.FlatAppearance.BorderSize = 0;
            this.BtnSeller.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSeller.Image = global::AppsControl_Inventario.Properties.Resources.caja_vendedor;
            this.BtnSeller.Location = new System.Drawing.Point(41, 264);
            this.BtnSeller.Name = "BtnSeller";
            this.BtnSeller.Size = new System.Drawing.Size(62, 62);
            this.BtnSeller.TabIndex = 1;
            this.BtnSeller.UseVisualStyleBackColor = false;
            this.BtnSeller.Click += new System.EventHandler(this.BtnSeller_Click);
            // 
            // BtnInputProducts
            // 
            this.BtnInputProducts.BackColor = System.Drawing.Color.Orange;
            this.BtnInputProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnInputProducts.FlatAppearance.BorderSize = 0;
            this.BtnInputProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInputProducts.Image = global::AppsControl_Inventario.Properties.Resources.abastecer;
            this.BtnInputProducts.Location = new System.Drawing.Point(119, 264);
            this.BtnInputProducts.Name = "BtnInputProducts";
            this.BtnInputProducts.Size = new System.Drawing.Size(64, 64);
            this.BtnInputProducts.TabIndex = 2;
            this.BtnInputProducts.UseVisualStyleBackColor = false;
            this.BtnInputProducts.Click += new System.EventHandler(this.BtnInputProducts_Click);
            // 
            // BtnOutProducts
            // 
            this.BtnOutProducts.BackColor = System.Drawing.Color.Orange;
            this.BtnOutProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnOutProducts.FlatAppearance.BorderSize = 0;
            this.BtnOutProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOutProducts.Image = global::AppsControl_Inventario.Properties.Resources.bodega;
            this.BtnOutProducts.Location = new System.Drawing.Point(197, 264);
            this.BtnOutProducts.Name = "BtnOutProducts";
            this.BtnOutProducts.Size = new System.Drawing.Size(64, 64);
            this.BtnOutProducts.TabIndex = 3;
            this.BtnOutProducts.UseVisualStyleBackColor = false;
            this.BtnOutProducts.Click += new System.EventHandler(this.BtnOutProducts_Click);
            // 
            // BtnSale
            // 
            this.BtnSale.BackColor = System.Drawing.Color.Orange;
            this.BtnSale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSale.FlatAppearance.BorderSize = 0;
            this.BtnSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSale.Image = global::AppsControl_Inventario.Properties.Resources.car_shopping1;
            this.BtnSale.Location = new System.Drawing.Point(41, 353);
            this.BtnSale.Name = "BtnSale";
            this.BtnSale.Size = new System.Drawing.Size(64, 64);
            this.BtnSale.TabIndex = 4;
            this.BtnSale.UseVisualStyleBackColor = false;
            this.BtnSale.Click += new System.EventHandler(this.BtnSale_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.Orange;
            this.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Image = global::AppsControl_Inventario.Properties.Resources.btn_salir;
            this.BtnExit.Location = new System.Drawing.Point(119, 353);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(64, 64);
            this.BtnExit.TabIndex = 5;
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.BackgroundImage = global::AppsControl_Inventario.Properties.Resources.Fondo_Movil;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(300, 624);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnSale);
            this.Controls.Add(this.BtnOutProducts);
            this.Controls.Add(this.BtnInputProducts);
            this.Controls.Add(this.BtnSeller);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnSeller;
        private System.Windows.Forms.Button BtnInputProducts;
        private System.Windows.Forms.Button BtnOutProducts;
        private System.Windows.Forms.Button BtnSale;
        private System.Windows.Forms.Button BtnExit;
    }
}

