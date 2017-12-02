namespace ProyectoDeAlgoritmos
{
    partial class ControlSoldados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlSoldados));
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.IniciarSoldados = new Bunifu.Framework.UI.BunifuThinButton2();
            this.seleccionarSoldados1 = new ProyectoDeAlgoritmos.seleccionarSoldados();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(354, 259);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(111, 40);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Soldiers";
            // 
            // IniciarSoldados
            // 
            this.IniciarSoldados.ActiveBorderThickness = 1;
            this.IniciarSoldados.ActiveCornerRadius = 40;
            this.IniciarSoldados.ActiveFillColor = System.Drawing.Color.MediumBlue;
            this.IniciarSoldados.ActiveForecolor = System.Drawing.Color.White;
            this.IniciarSoldados.ActiveLineColor = System.Drawing.Color.MediumBlue;
            this.IniciarSoldados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.IniciarSoldados.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("IniciarSoldados.BackgroundImage")));
            this.IniciarSoldados.ButtonText = "Iniciar";
            this.IniciarSoldados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IniciarSoldados.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IniciarSoldados.ForeColor = System.Drawing.Color.SeaGreen;
            this.IniciarSoldados.IdleBorderThickness = 1;
            this.IniciarSoldados.IdleCornerRadius = 40;
            this.IniciarSoldados.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.IniciarSoldados.IdleForecolor = System.Drawing.Color.MediumBlue;
            this.IniciarSoldados.IdleLineColor = System.Drawing.Color.MediumBlue;
            this.IniciarSoldados.Location = new System.Drawing.Point(309, 337);
            this.IniciarSoldados.Margin = new System.Windows.Forms.Padding(5);
            this.IniciarSoldados.Name = "IniciarSoldados";
            this.IniciarSoldados.Size = new System.Drawing.Size(212, 59);
            this.IniciarSoldados.TabIndex = 1;
            this.IniciarSoldados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.IniciarSoldados.Click += new System.EventHandler(this.IniciarSoldados_Click);
            // 
            // seleccionarSoldados1
            // 
            this.seleccionarSoldados1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.seleccionarSoldados1.Location = new System.Drawing.Point(0, 0);
            this.seleccionarSoldados1.Name = "seleccionarSoldados1";
            this.seleccionarSoldados1.Size = new System.Drawing.Size(853, 532);
            this.seleccionarSoldados1.TabIndex = 2;
            this.seleccionarSoldados1.Visible = false;
            this.seleccionarSoldados1.Load += new System.EventHandler(this.seleccionarSoldados1_Load);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(20, 507);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(794, 13);
            this.bunifuCustomLabel2.TabIndex = 23;
            this.bunifuCustomLabel2.Text = "Juan de Dios Bátiz, Ciudad de México,  ESCOM IPN © 2017                          " +
    "                Alan Ernesto González Barrios  |  Joel Mauricio Romero Gamarra  " +
    "|  René Zavala Pérez";
            // 
            // ControlSoldados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.seleccionarSoldados1);
            this.Controls.Add(this.IniciarSoldados);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Name = "ControlSoldados";
            this.Size = new System.Drawing.Size(853, 532);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        public Bunifu.Framework.UI.BunifuThinButton2 IniciarSoldados;
        private seleccionarSoldados seleccionarSoldados1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
    }
}
