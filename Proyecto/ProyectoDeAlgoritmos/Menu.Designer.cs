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
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.doubleBitmapControl1 = new BunifuAnimatorNS.DoubleBitmapControl();
            this.PanelAnimacion = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.controlEscritorio1 = new ProyectoDeAlgoritmos.controlEscritorio();
            this.controlSoldados2 = new ProyectoDeAlgoritmos.ControlSoldados();
            this.controlScarecrow2 = new ProyectoDeAlgoritmos.controlScarecrow();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.EscomImg = new System.Windows.Forms.PictureBox();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.BtnAll = new Bunifu.Framework.UI.BunifuFlatButton();
            this.EscritorioBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnScarecrow = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnSoldier = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EscomImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // doubleBitmapControl1
            // 
            this.PanelAnimacion.SetDecoration(this.doubleBitmapControl1, BunifuAnimatorNS.DecorationType.None);
            this.doubleBitmapControl1.Location = new System.Drawing.Point(415, 258);
            this.doubleBitmapControl1.Name = "doubleBitmapControl1";
            this.doubleBitmapControl1.Size = new System.Drawing.Size(8, 8);
            this.doubleBitmapControl1.TabIndex = 6;
            this.doubleBitmapControl1.Text = "doubleBitmapControl1";
            this.doubleBitmapControl1.Visible = false;
            // 
            // PanelAnimacion
            // 
            this.PanelAnimacion.AnimationType = BunifuAnimatorNS.AnimationType.HorizBlind;
            this.PanelAnimacion.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.PanelAnimacion.DefaultAnimation = animation1;
            this.PanelAnimacion.MaxAnimationTime = 3000;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.bunifuGradientPanel1);
            this.PanelAnimacion.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(25)))), ((int)(((byte)(41)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 532);
            this.panel1.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.controlEscritorio1);
            this.panel3.Controls.Add(this.controlSoldados2);
            this.panel3.Controls.Add(this.controlScarecrow2);
            this.PanelAnimacion.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Location = new System.Drawing.Point(209, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(853, 532);
            this.panel3.TabIndex = 18;
            this.panel3.TabStop = true;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // controlEscritorio1
            // 
            this.controlEscritorio1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PanelAnimacion.SetDecoration(this.controlEscritorio1, BunifuAnimatorNS.DecorationType.None);
            this.controlEscritorio1.Location = new System.Drawing.Point(0, 0);
            this.controlEscritorio1.Name = "controlEscritorio1";
            this.controlEscritorio1.Size = new System.Drawing.Size(853, 532);
            this.controlEscritorio1.TabIndex = 2;
            // 
            // controlSoldados2
            // 
            this.controlSoldados2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PanelAnimacion.SetDecoration(this.controlSoldados2, BunifuAnimatorNS.DecorationType.None);
            this.controlSoldados2.Location = new System.Drawing.Point(0, 0);
            this.controlSoldados2.Name = "controlSoldados2";
            this.controlSoldados2.Size = new System.Drawing.Size(853, 532);
            this.controlSoldados2.TabIndex = 1;
            // 
            // controlScarecrow2
            // 
            this.controlScarecrow2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PanelAnimacion.SetDecoration(this.controlScarecrow2, BunifuAnimatorNS.DecorationType.None);
            this.controlScarecrow2.Location = new System.Drawing.Point(0, 0);
            this.controlScarecrow2.Name = "controlScarecrow2";
            this.controlScarecrow2.Size = new System.Drawing.Size(853, 532);
            this.controlScarecrow2.TabIndex = 0;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.EscomImg);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuImageButton1);
            this.bunifuGradientPanel1.Controls.Add(this.BtnAll);
            this.bunifuGradientPanel1.Controls.Add(this.EscritorioBtn);
            this.bunifuGradientPanel1.Controls.Add(this.BtnScarecrow);
            this.bunifuGradientPanel1.Controls.Add(this.BtnSoldier);
            this.PanelAnimacion.SetDecoration(this.bunifuGradientPanel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.DarkBlue;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.Aquamarine;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.LightSkyBlue;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(210, 532);
            this.bunifuGradientPanel1.TabIndex = 18;
            this.bunifuGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuGradientPanel1_Paint);
            // 
            // EscomImg
            // 
            this.EscomImg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelAnimacion.SetDecoration(this.EscomImg, BunifuAnimatorNS.DecorationType.None);
            this.EscomImg.Image = ((System.Drawing.Image)(resources.GetObject("EscomImg.Image")));
            this.EscomImg.Location = new System.Drawing.Point(28, 361);
            this.EscomImg.Name = "EscomImg";
            this.EscomImg.Size = new System.Drawing.Size(156, 100);
            this.EscomImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.EscomImg.TabIndex = 16;
            this.EscomImg.TabStop = false;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimacion.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(0, 0);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(37, 35);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 11;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 2;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // BtnAll
            // 
            this.BtnAll.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(84)))), ((int)(((byte)(1)))));
            this.BtnAll.BackColor = System.Drawing.Color.Transparent;
            this.BtnAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAll.BorderRadius = 0;
            this.BtnAll.ButtonText = "Exit";
            this.BtnAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimacion.SetDecoration(this.BtnAll, BunifuAnimatorNS.DecorationType.None);
            this.BtnAll.DisabledColor = System.Drawing.Color.Gray;
            this.BtnAll.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnAll.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnAll.Iconimage")));
            this.BtnAll.Iconimage_right = null;
            this.BtnAll.Iconimage_right_Selected = null;
            this.BtnAll.Iconimage_Selected = null;
            this.BtnAll.IconMarginLeft = 10;
            this.BtnAll.IconMarginRight = 0;
            this.BtnAll.IconRightVisible = true;
            this.BtnAll.IconRightZoom = 0D;
            this.BtnAll.IconVisible = true;
            this.BtnAll.IconZoom = 50D;
            this.BtnAll.IsTab = true;
            this.BtnAll.Location = new System.Drawing.Point(0, 277);
            this.BtnAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnAll.Name = "BtnAll";
            this.BtnAll.Normalcolor = System.Drawing.Color.Transparent;
            this.BtnAll.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(84)))), ((int)(((byte)(1)))));
            this.BtnAll.OnHoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.BtnAll.selected = false;
            this.BtnAll.Size = new System.Drawing.Size(210, 60);
            this.BtnAll.TabIndex = 17;
            this.BtnAll.Text = "Exit";
            this.BtnAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnAll.Textcolor = System.Drawing.Color.White;
            this.BtnAll.TextFont = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAll.Click += new System.EventHandler(this.BtnAll_Click_1);
            // 
            // EscritorioBtn
            // 
            this.EscritorioBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(84)))), ((int)(((byte)(1)))));
            this.EscritorioBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(84)))), ((int)(((byte)(1)))));
            this.EscritorioBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EscritorioBtn.BorderRadius = 0;
            this.EscritorioBtn.ButtonText = "Desktop";
            this.EscritorioBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimacion.SetDecoration(this.EscritorioBtn, BunifuAnimatorNS.DecorationType.None);
            this.EscritorioBtn.DisabledColor = System.Drawing.Color.Gray;
            this.EscritorioBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(84)))), ((int)(((byte)(1)))));
            this.EscritorioBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.EscritorioBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("EscritorioBtn.Iconimage")));
            this.EscritorioBtn.Iconimage_right = null;
            this.EscritorioBtn.Iconimage_right_Selected = null;
            this.EscritorioBtn.Iconimage_Selected = null;
            this.EscritorioBtn.IconMarginLeft = 10;
            this.EscritorioBtn.IconMarginRight = 0;
            this.EscritorioBtn.IconRightVisible = true;
            this.EscritorioBtn.IconRightZoom = 0D;
            this.EscritorioBtn.IconVisible = true;
            this.EscritorioBtn.IconZoom = 50D;
            this.EscritorioBtn.IsTab = true;
            this.EscritorioBtn.Location = new System.Drawing.Point(0, 101);
            this.EscritorioBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EscritorioBtn.Name = "EscritorioBtn";
            this.EscritorioBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.EscritorioBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(84)))), ((int)(((byte)(1)))));
            this.EscritorioBtn.OnHoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.EscritorioBtn.selected = true;
            this.EscritorioBtn.Size = new System.Drawing.Size(210, 60);
            this.EscritorioBtn.TabIndex = 15;
            this.EscritorioBtn.Text = "Desktop";
            this.EscritorioBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EscritorioBtn.Textcolor = System.Drawing.Color.White;
            this.EscritorioBtn.TextFont = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EscritorioBtn.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // BtnScarecrow
            // 
            this.BtnScarecrow.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(84)))), ((int)(((byte)(1)))));
            this.BtnScarecrow.BackColor = System.Drawing.Color.Transparent;
            this.BtnScarecrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnScarecrow.BorderRadius = 0;
            this.BtnScarecrow.ButtonText = "Scarecrow";
            this.BtnScarecrow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimacion.SetDecoration(this.BtnScarecrow, BunifuAnimatorNS.DecorationType.None);
            this.BtnScarecrow.DisabledColor = System.Drawing.Color.Gray;
            this.BtnScarecrow.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnScarecrow.Iconimage = global::ProyectoDeAlgoritmos.Properties.Resources.crow;
            this.BtnScarecrow.Iconimage_right = null;
            this.BtnScarecrow.Iconimage_right_Selected = null;
            this.BtnScarecrow.Iconimage_Selected = null;
            this.BtnScarecrow.IconMarginLeft = 10;
            this.BtnScarecrow.IconMarginRight = 0;
            this.BtnScarecrow.IconRightVisible = true;
            this.BtnScarecrow.IconRightZoom = 0D;
            this.BtnScarecrow.IconVisible = true;
            this.BtnScarecrow.IconZoom = 50D;
            this.BtnScarecrow.IsTab = true;
            this.BtnScarecrow.Location = new System.Drawing.Point(0, 219);
            this.BtnScarecrow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnScarecrow.Name = "BtnScarecrow";
            this.BtnScarecrow.Normalcolor = System.Drawing.Color.Transparent;
            this.BtnScarecrow.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(84)))), ((int)(((byte)(1)))));
            this.BtnScarecrow.OnHoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.BtnScarecrow.selected = false;
            this.BtnScarecrow.Size = new System.Drawing.Size(210, 60);
            this.BtnScarecrow.TabIndex = 16;
            this.BtnScarecrow.Text = "Scarecrow";
            this.BtnScarecrow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnScarecrow.Textcolor = System.Drawing.Color.White;
            this.BtnScarecrow.TextFont = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnScarecrow.Click += new System.EventHandler(this.BtnScarecrow_Click);
            // 
            // BtnSoldier
            // 
            this.BtnSoldier.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(84)))), ((int)(((byte)(1)))));
            this.BtnSoldier.BackColor = System.Drawing.Color.Transparent;
            this.BtnSoldier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSoldier.BorderRadius = 0;
            this.BtnSoldier.ButtonText = "Soldier";
            this.BtnSoldier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimacion.SetDecoration(this.BtnSoldier, BunifuAnimatorNS.DecorationType.None);
            this.BtnSoldier.DisabledColor = System.Drawing.Color.Gray;
            this.BtnSoldier.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnSoldier.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnSoldier.Iconimage")));
            this.BtnSoldier.Iconimage_right = null;
            this.BtnSoldier.Iconimage_right_Selected = null;
            this.BtnSoldier.Iconimage_Selected = null;
            this.BtnSoldier.IconMarginLeft = 10;
            this.BtnSoldier.IconMarginRight = 0;
            this.BtnSoldier.IconRightVisible = true;
            this.BtnSoldier.IconRightZoom = 0D;
            this.BtnSoldier.IconVisible = true;
            this.BtnSoldier.IconZoom = 50D;
            this.BtnSoldier.IsTab = true;
            this.BtnSoldier.Location = new System.Drawing.Point(0, 160);
            this.BtnSoldier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnSoldier.Name = "BtnSoldier";
            this.BtnSoldier.Normalcolor = System.Drawing.Color.Transparent;
            this.BtnSoldier.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(84)))), ((int)(((byte)(1)))));
            this.BtnSoldier.OnHoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.BtnSoldier.selected = false;
            this.BtnSoldier.Size = new System.Drawing.Size(210, 60);
            this.BtnSoldier.TabIndex = 15;
            this.BtnSoldier.Text = "Soldier";
            this.BtnSoldier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnSoldier.Textcolor = System.Drawing.Color.White;
            this.BtnSoldier.TextFont = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSoldier.Click += new System.EventHandler(this.BtnSoldier_Click_2);
            // 
            // Menu
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1060, 532);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.doubleBitmapControl1);
            this.PanelAnimacion.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Menu_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EscomImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private BunifuAnimatorNS.DoubleBitmapControl doubleBitmapControl1;
        private BunifuAnimatorNS.BunifuTransition PanelAnimacion;
        public Bunifu.Framework.UI.BunifuFlatButton EscritorioBtn;
        public Bunifu.Framework.UI.BunifuFlatButton BtnScarecrow;
        public Bunifu.Framework.UI.BunifuFlatButton BtnSoldier;
        public Bunifu.Framework.UI.BunifuFlatButton BtnAll;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox EscomImg;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        public System.Windows.Forms.Panel panel3;
        private controlEscritorio controlEscritorio1;
        private ControlSoldados controlSoldados2;
        private controlScarecrow controlScarecrow2;
    }
}

