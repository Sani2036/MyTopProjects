namespace PL.PANTALLAS.GENERALES
{
    partial class Frm_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Principal));
            this.mnPrincipal = new System.Windows.Forms.MenuStrip();
            this.mniArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.mniSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.mniCatalogos = new System.Windows.Forms.ToolStripMenuItem();
            this.mniCat_Estados = new System.Windows.Forms.ToolStripMenuItem();
            this.mniCat_Marcas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnPrincipal
            // 
            this.mnPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.mnPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniArchivo,
            this.mniCatalogos});
            this.mnPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnPrincipal.Name = "mnPrincipal";
            this.mnPrincipal.Size = new System.Drawing.Size(945, 56);
            this.mnPrincipal.TabIndex = 1;
            this.mnPrincipal.Text = "menuStrip1";
            // 
            // mniArchivo
            // 
            this.mniArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniSalir});
            this.mniArchivo.ForeColor = System.Drawing.Color.White;
            this.mniArchivo.Image = ((System.Drawing.Image)(resources.GetObject("mniArchivo.Image")));
            this.mniArchivo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mniArchivo.Name = "mniArchivo";
            this.mniArchivo.Size = new System.Drawing.Size(108, 52);
            this.mniArchivo.Text = "Archivo";
            // 
            // mniSalir
            // 
            this.mniSalir.Image = ((System.Drawing.Image)(resources.GetObject("mniSalir.Image")));
            this.mniSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mniSalir.Name = "mniSalir";
            this.mniSalir.Size = new System.Drawing.Size(128, 54);
            this.mniSalir.Text = "Salir";
            this.mniSalir.Click += new System.EventHandler(this.mniSalir_Click);
            // 
            // mniCatalogos
            // 
            this.mniCatalogos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniCat_Estados,
            this.mniCat_Marcas});
            this.mniCatalogos.ForeColor = System.Drawing.Color.White;
            this.mniCatalogos.Image = ((System.Drawing.Image)(resources.GetObject("mniCatalogos.Image")));
            this.mniCatalogos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mniCatalogos.Name = "mniCatalogos";
            this.mniCatalogos.Size = new System.Drawing.Size(219, 52);
            this.mniCatalogos.Text = "Catálogos y Mantenimientos";
            // 
            // mniCat_Estados
            // 
            this.mniCat_Estados.Image = ((System.Drawing.Image)(resources.GetObject("mniCat_Estados.Image")));
            this.mniCat_Estados.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mniCat_Estados.Name = "mniCat_Estados";
            this.mniCat_Estados.Size = new System.Drawing.Size(212, 54);
            this.mniCat_Estados.Text = "Estados";
            this.mniCat_Estados.Click += new System.EventHandler(this.mniCat_Estados_Click);
            // 
            // mniCat_Marcas
            // 
            this.mniCat_Marcas.Image = ((System.Drawing.Image)(resources.GetObject("mniCat_Marcas.Image")));
            this.mniCat_Marcas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mniCat_Marcas.Name = "mniCat_Marcas";
            this.mniCat_Marcas.Size = new System.Drawing.Size(212, 54);
            this.mniCat_Marcas.Text = "Marcas";
            this.mniCat_Marcas.Click += new System.EventHandler(this.mniCat_Marcas_Click);
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(945, 610);
            this.Controls.Add(this.mnPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Examen Final - ISI-BSI-09 - 3er Cuatrimestre 2022 - Pantalla Principal";
            this.mnPrincipal.ResumeLayout(false);
            this.mnPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mniArchivo;
        private System.Windows.Forms.ToolStripMenuItem mniSalir;
        private System.Windows.Forms.ToolStripMenuItem mniCatalogos;
        private System.Windows.Forms.ToolStripMenuItem mniCat_Estados;
        private System.Windows.Forms.ToolStripMenuItem mniCat_Marcas;
    }
}