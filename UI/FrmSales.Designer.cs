namespace AppsControl_Inventario.UI
{
    partial class FrmSales
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbCash = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtQuarter1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtQuarter2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtQuarter3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtQuarter4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtGoal = new System.Windows.Forms.TextBox();
            this.BtnNew = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.ProgBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppsControl_Inventario.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(54, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(49, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ventas x Trimestre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Caja";
            // 
            // CmbCash
            // 
            this.CmbCash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CmbCash.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbCash.FormattingEnabled = true;
            this.CmbCash.Items.AddRange(new object[] {
            "SELECCIONAR",
            "CAJA 1",
            "CAJA 2",
            "CAJA 3",
            "CAJA 4",
            "CAJA 5",
            "CAJA 6",
            "CAJA 7",
            "CAJA 8"});
            this.CmbCash.Location = new System.Drawing.Point(112, 239);
            this.CmbCash.Name = "CmbCash";
            this.CmbCash.Size = new System.Drawing.Size(159, 24);
            this.CmbCash.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Trimestre 1";
            // 
            // TxtQuarter1
            // 
            this.TxtQuarter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtQuarter1.Location = new System.Drawing.Point(112, 272);
            this.TxtQuarter1.Name = "TxtQuarter1";
            this.TxtQuarter1.Size = new System.Drawing.Size(159, 22);
            this.TxtQuarter1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Trimestre 2";
            // 
            // TxtQuarter2
            // 
            this.TxtQuarter2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtQuarter2.Location = new System.Drawing.Point(114, 307);
            this.TxtQuarter2.Name = "TxtQuarter2";
            this.TxtQuarter2.Size = new System.Drawing.Size(157, 22);
            this.TxtQuarter2.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Trimestre 3";
            // 
            // TxtQuarter3
            // 
            this.TxtQuarter3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtQuarter3.Location = new System.Drawing.Point(112, 340);
            this.TxtQuarter3.Name = "TxtQuarter3";
            this.TxtQuarter3.Size = new System.Drawing.Size(159, 22);
            this.TxtQuarter3.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 376);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Trimestre 4";
            // 
            // TxtQuarter4
            // 
            this.TxtQuarter4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtQuarter4.Location = new System.Drawing.Point(112, 373);
            this.TxtQuarter4.Name = "TxtQuarter4";
            this.TxtQuarter4.Size = new System.Drawing.Size(159, 22);
            this.TxtQuarter4.TabIndex = 11;
            this.TxtQuarter4.Leave += new System.EventHandler(this.TxtQuarter4_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(34, 410);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Total";
            // 
            // TxtTotal
            // 
            this.TxtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotal.Location = new System.Drawing.Point(112, 407);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(159, 22);
            this.TxtTotal.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(34, 443);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Obj. Ventas.";
            // 
            // TxtGoal
            // 
            this.TxtGoal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtGoal.Location = new System.Drawing.Point(112, 440);
            this.TxtGoal.Name = "TxtGoal";
            this.TxtGoal.Size = new System.Drawing.Size(159, 22);
            this.TxtGoal.TabIndex = 15;
            // 
            // BtnNew
            // 
            this.BtnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNew.Image = global::AppsControl_Inventario.Properties.Resources.ico_new32;
            this.BtnNew.Location = new System.Drawing.Point(60, 494);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(38, 38);
            this.BtnNew.TabIndex = 16;
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSave.Image = global::AppsControl_Inventario.Properties.Resources.btn_save32;
            this.BtnSave.Location = new System.Drawing.Point(112, 494);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(38, 38);
            this.BtnSave.TabIndex = 17;
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSearch.Image = global::AppsControl_Inventario.Properties.Resources.btn_lupa_busc32;
            this.BtnSearch.Location = new System.Drawing.Point(165, 494);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(38, 38);
            this.BtnSearch.TabIndex = 18;
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExit.Image = global::AppsControl_Inventario.Properties.Resources.ico_exit32;
            this.BtnExit.Location = new System.Drawing.Point(219, 494);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(38, 38);
            this.BtnExit.TabIndex = 19;
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // ProgBar
            // 
            this.ProgBar.Location = new System.Drawing.Point(60, 550);
            this.ProgBar.Name = "ProgBar";
            this.ProgBar.Size = new System.Drawing.Size(195, 23);
            this.ProgBar.TabIndex = 20;
            this.ProgBar.Visible = false;
            // 
            // FrmSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AppsControl_Inventario.Properties.Resources.Fondo_Movil;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(304, 624);
            this.Controls.Add(this.ProgBar);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnNew);
            this.Controls.Add(this.TxtGoal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtQuarter4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtQuarter3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtQuarter2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtQuarter1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CmbCash);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSales";
            this.Load += new System.EventHandler(this.FrmSales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbCash;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtQuarter1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtQuarter2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtQuarter3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtQuarter4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtGoal;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.ProgressBar ProgBar;
    }
}