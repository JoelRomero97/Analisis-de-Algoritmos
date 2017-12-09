namespace ProyectoDeAlgoritmos
{
    partial class controlScarecrow
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(controlScarecrow));
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.seleccionScarecrow1 = new ProyectoDeAlgoritmos.seleccionScarecrow();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.InicioScarecrow = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(344, 259);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(140, 40);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "Scarecrow";
            this.bunifuCustomLabel1.Click += new System.EventHandler(this.bunifuCustomLabel1_Click);
            // 
            // seleccionScarecrow1
            // 
            this.seleccionScarecrow1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.seleccionScarecrow1.Location = new System.Drawing.Point(0, 0);
            this.seleccionScarecrow1.Name = "seleccionScarecrow1";
            this.seleccionScarecrow1.Size = new System.Drawing.Size(853, 532);
            this.seleccionScarecrow1.TabIndex = 11;
            this.seleccionScarecrow1.Visible = false;
            this.seleccionScarecrow1.Load += new System.EventHandler(this.seleccionScarecrow1_Load);
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(20, 507);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(794, 13);
            this.bunifuCustomLabel4.TabIndex = 23;
            this.bunifuCustomLabel4.Text = "Juan de Dios Bátiz, Ciudad de México,  ESCOM IPN © 2017                          " +
    "                Alan Ernesto González Barrios  |  Joel Mauricio Romero Gamarra  " +
    "|  René Zavala Pérez";
            // 
            // InicioScarecrow
            // 
            this.InicioScarecrow.ActiveBorderThickness = 1;
            this.InicioScarecrow.ActiveCornerRadius = 40;
            this.InicioScarecrow.ActiveFillColor = System.Drawing.Color.MediumBlue;
            this.InicioScarecrow.ActiveForecolor = System.Drawing.Color.White;
            this.InicioScarecrow.ActiveLineColor = System.Drawing.Color.MediumBlue;
            this.InicioScarecrow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.InicioScarecrow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("InicioScarecrow.BackgroundImage")));
            this.InicioScarecrow.ButtonText = "Iniciar";
            this.InicioScarecrow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InicioScarecrow.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InicioScarecrow.ForeColor = System.Drawing.Color.SeaGreen;
            this.InicioScarecrow.IdleBorderThickness = 1;
            this.InicioScarecrow.IdleCornerRadius = 40;
            this.InicioScarecrow.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.InicioScarecrow.IdleForecolor = System.Drawing.Color.MediumBlue;
            this.InicioScarecrow.IdleLineColor = System.Drawing.Color.MediumBlue;
            this.InicioScarecrow.Location = new System.Drawing.Point(309, 337);
            this.InicioScarecrow.Margin = new System.Windows.Forms.Padding(5);
            this.InicioScarecrow.Name = "InicioScarecrow";
            this.InicioScarecrow.Size = new System.Drawing.Size(212, 59);
            this.InicioScarecrow.TabIndex = 2;
            this.InicioScarecrow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.InicioScarecrow.Click += new System.EventHandler(this.InicioScarecrow_Click);
            // 
            // controlScarecrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.seleccionScarecrow1);
            this.Controls.Add(this.InicioScarecrow);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Name = "controlScarecrow";
            this.Size = new System.Drawing.Size(853, 532);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuThinButton2 InicioScarecrow;
        private seleccionScarecrow seleccionScarecrow1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
    }
}
