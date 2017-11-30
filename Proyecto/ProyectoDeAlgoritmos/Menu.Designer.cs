namespace ProyectoDeAlgoritmos
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.AnalisisGre = new System.Windows.Forms.Label();
            this.BtnAll = new System.Windows.Forms.Button();
            this.DesarrGre = new System.Windows.Forms.Label();
            this.ScareAndSol = new System.Windows.Forms.Label();
            this.doubleBitmapControl1 = new BunifuAnimatorNS.DoubleBitmapControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnEscritorio = new System.Windows.Forms.Button();
            this.BtnSoldier = new System.Windows.Forms.Button();
            this.BtnScarecrow = new System.Windows.Forms.Button();
            this.EquipoJava = new System.Windows.Forms.Label();
            this.EscomImg = new System.Windows.Forms.PictureBox();
            this.IPNimg = new System.Windows.Forms.PictureBox();
            this.Salida = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EscomImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IPNimg)).BeginInit();
            this.SuspendLayout();
            // 
            // AnalisisGre
            // 
            this.AnalisisGre.AutoSize = true;
            this.AnalisisGre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(25)))), ((int)(((byte)(41)))));
            this.AnalisisGre.Font = new System.Drawing.Font("Century Schoolbook", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnalisisGre.ForeColor = System.Drawing.Color.White;
            this.AnalisisGre.Location = new System.Drawing.Point(391, 9);
            this.AnalisisGre.Name = "AnalisisGre";
            this.AnalisisGre.Size = new System.Drawing.Size(360, 28);
            this.AnalisisGre.TabIndex = 0;
            this.AnalisisGre.Text = "Analisis de Algoritmos Greedy.";
            this.AnalisisGre.Click += new System.EventHandler(this.label1_Click);
            // 
            // BtnAll
            // 
            this.BtnAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(25)))), ((int)(((byte)(41)))));
            this.BtnAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAll.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAll.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAll.ForeColor = System.Drawing.Color.White;
            this.BtnAll.Location = new System.Drawing.Point(-1, 347);
            this.BtnAll.Name = "BtnAll";
            this.BtnAll.Size = new System.Drawing.Size(147, 115);
            this.BtnAll.TabIndex = 2;
            this.BtnAll.Text = "All";
            this.BtnAll.UseVisualStyleBackColor = false;
            this.BtnAll.Click += new System.EventHandler(this.BtnAll_Click);
            // 
            // DesarrGre
            // 
            this.DesarrGre.AutoSize = true;
            this.DesarrGre.Font = new System.Drawing.Font("Century Schoolbook", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DesarrGre.ForeColor = System.Drawing.Color.White;
            this.DesarrGre.Location = new System.Drawing.Point(323, 165);
            this.DesarrGre.Name = "DesarrGre";
            this.DesarrGre.Size = new System.Drawing.Size(517, 56);
            this.DesarrGre.TabIndex = 3;
            this.DesarrGre.Text = "Desarrollo interactivo de algoritmos Greedy.\r\nCon problemas de Espantapajaros y S" +
    "oldados\r\n";
            this.DesarrGre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ScareAndSol
            // 
            this.ScareAndSol.AutoSize = true;
            this.ScareAndSol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(25)))), ((int)(((byte)(41)))));
            this.ScareAndSol.Font = new System.Drawing.Font("Century Schoolbook", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScareAndSol.ForeColor = System.Drawing.Color.White;
            this.ScareAndSol.Location = new System.Drawing.Point(430, 96);
            this.ScareAndSol.Name = "ScareAndSol";
            this.ScareAndSol.Size = new System.Drawing.Size(263, 28);
            this.ScareAndSol.TabIndex = 5;
            this.ScareAndSol.Text = "Scarecrow and Soldier";
            this.ScareAndSol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ScareAndSol.Click += new System.EventHandler(this.label3_Click);
            // 
            // doubleBitmapControl1
            // 
            this.doubleBitmapControl1.Location = new System.Drawing.Point(367, 249);
            this.doubleBitmapControl1.Name = "doubleBitmapControl1";
            this.doubleBitmapControl1.Size = new System.Drawing.Size(8, 8);
            this.doubleBitmapControl1.TabIndex = 6;
            this.doubleBitmapControl1.Text = "doubleBitmapControl1";
            this.doubleBitmapControl1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnEscritorio);
            this.panel1.Controls.Add(this.BtnSoldier);
            this.panel1.Controls.Add(this.BtnAll);
            this.panel1.Controls.Add(this.BtnScarecrow);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(25)))), ((int)(((byte)(41)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(147, 461);
            this.panel1.TabIndex = 7;
            // 
            // BtnEscritorio
            // 
            this.BtnEscritorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(25)))), ((int)(((byte)(41)))));
            this.BtnEscritorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEscritorio.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnEscritorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEscritorio.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEscritorio.ForeColor = System.Drawing.Color.White;
            this.BtnEscritorio.Image = global::ProyectoDeAlgoritmos.Properties.Resources.blue_home_house_12608;
            this.BtnEscritorio.Location = new System.Drawing.Point(-1, -1);
            this.BtnEscritorio.Name = "BtnEscritorio";
            this.BtnEscritorio.Size = new System.Drawing.Size(147, 116);
            this.BtnEscritorio.TabIndex = 8;
            this.BtnEscritorio.Text = "Desktop";
            this.BtnEscritorio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnEscritorio.UseVisualStyleBackColor = false;
            this.BtnEscritorio.Click += new System.EventHandler(this.button3_Click);
            // 
            // BtnSoldier
            // 
            this.BtnSoldier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(25)))), ((int)(((byte)(41)))));
            this.BtnSoldier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSoldier.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnSoldier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSoldier.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSoldier.ForeColor = System.Drawing.Color.White;
            this.BtnSoldier.Image = global::ProyectoDeAlgoritmos.Properties.Resources.Soldado1;
            this.BtnSoldier.Location = new System.Drawing.Point(-1, 114);
            this.BtnSoldier.Name = "BtnSoldier";
            this.BtnSoldier.Size = new System.Drawing.Size(147, 120);
            this.BtnSoldier.TabIndex = 8;
            this.BtnSoldier.Text = "Soldier";
            this.BtnSoldier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnSoldier.UseVisualStyleBackColor = false;
            this.BtnSoldier.Click += new System.EventHandler(this.BtnSoldier_Click);
            // 
            // BtnScarecrow
            // 
            this.BtnScarecrow.AutoSize = true;
            this.BtnScarecrow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(25)))), ((int)(((byte)(41)))));
            this.BtnScarecrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnScarecrow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnScarecrow.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnScarecrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnScarecrow.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnScarecrow.ForeColor = System.Drawing.Color.White;
            this.BtnScarecrow.Image = global::ProyectoDeAlgoritmos.Properties.Resources.scarecrow_576497_6401;
            this.BtnScarecrow.Location = new System.Drawing.Point(-1, 230);
            this.BtnScarecrow.Name = "BtnScarecrow";
            this.BtnScarecrow.Size = new System.Drawing.Size(147, 119);
            this.BtnScarecrow.TabIndex = 1;
            this.BtnScarecrow.Text = "Scarecrow";
            this.BtnScarecrow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnScarecrow.UseVisualStyleBackColor = false;
            this.BtnScarecrow.Click += new System.EventHandler(this.Iniciar_Click);
            // 
            // EquipoJava
            // 
            this.EquipoJava.AutoSize = true;
            this.EquipoJava.Font = new System.Drawing.Font("Century Schoolbook", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EquipoJava.ForeColor = System.Drawing.Color.White;
            this.EquipoJava.Location = new System.Drawing.Point(459, 274);
            this.EquipoJava.Name = "EquipoJava";
            this.EquipoJava.Size = new System.Drawing.Size(225, 28);
            this.EquipoJava.TabIndex = 8;
            this.EquipoJava.Text = "Equipo: Java-limos";
            // 
            // EscomImg
            // 
            this.EscomImg.Image = global::ProyectoDeAlgoritmos.Properties.Resources.escom;
            this.EscomImg.Location = new System.Drawing.Point(764, 322);
            this.EscomImg.Name = "EscomImg";
            this.EscomImg.Size = new System.Drawing.Size(160, 113);
            this.EscomImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.EscomImg.TabIndex = 10;
            this.EscomImg.TabStop = false;
            // 
            // IPNimg
            // 
            this.IPNimg.Image = ((System.Drawing.Image)(resources.GetObject("IPNimg.Image")));
            this.IPNimg.Location = new System.Drawing.Point(153, 0);
            this.IPNimg.Name = "IPNimg";
            this.IPNimg.Size = new System.Drawing.Size(160, 114);
            this.IPNimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.IPNimg.TabIndex = 9;
            this.IPNimg.TabStop = false;
            // 
            // Salida
            // 
            this.Salida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(25)))), ((int)(((byte)(41)))));
            this.Salida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Salida.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Salida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Salida.Image = global::ProyectoDeAlgoritmos.Properties.Resources.tache_1;
            this.Salida.Location = new System.Drawing.Point(939, -1);
            this.Salida.Name = "Salida";
            this.Salida.Size = new System.Drawing.Size(32, 38);
            this.Salida.TabIndex = 11;
            this.Salida.UseVisualStyleBackColor = true;
            this.Salida.Click += new System.EventHandler(this.Salida_Click);
            // 
            // Menu
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(25)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(970, 461);
            this.Controls.Add(this.Salida);
            this.Controls.Add(this.EscomImg);
            this.Controls.Add(this.IPNimg);
            this.Controls.Add(this.EquipoJava);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.doubleBitmapControl1);
            this.Controls.Add(this.ScareAndSol);
            this.Controls.Add(this.DesarrGre);
            this.Controls.Add(this.AnalisisGre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Menu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EscomImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IPNimg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AnalisisGre;
        private System.Windows.Forms.Button BtnAll;
        private System.Windows.Forms.Label DesarrGre;
        private System.Windows.Forms.Label ScareAndSol;
        private BunifuAnimatorNS.DoubleBitmapControl doubleBitmapControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnSoldier;
        private System.Windows.Forms.Label EquipoJava;
        private System.Windows.Forms.PictureBox IPNimg;
        private System.Windows.Forms.PictureBox EscomImg;
        private System.Windows.Forms.Button Salida;
        public System.Windows.Forms.Button BtnEscritorio;
        public System.Windows.Forms.Button BtnScarecrow;
    }
}

