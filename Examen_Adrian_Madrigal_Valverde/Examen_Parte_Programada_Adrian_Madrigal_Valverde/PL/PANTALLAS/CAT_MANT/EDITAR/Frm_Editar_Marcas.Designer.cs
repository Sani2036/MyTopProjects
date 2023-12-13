namespace PL.PANTALLAS.CAT_MANT.EDITAR
{
    partial class Frm_Editar_Marcas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Editar_Marcas));
            this.tls_Principal = new System.Windows.Forms.ToolStrip();
            this.tsbtn_Guardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtn_Salir = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.Cmb_Estados = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_DescripcionMarca = new System.Windows.Forms.TextBox();
            this.Txt_IdMarca = new System.Windows.Forms.TextBox();
            this.Lbl_Marca = new System.Windows.Forms.Label();
            this.Lbl_IdMarca = new System.Windows.Forms.Label();
            this.tls_Principal.SuspendLayout();
            this.SuspendLayout();
            // 
            // tls_Principal
            // 
            this.tls_Principal.BackColor = System.Drawing.Color.Transparent;
            this.tls_Principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtn_Guardar,
            this.toolStripLabel6,
            this.toolStripSeparator5,
            this.tsbtn_Salir,
            this.toolStripLabel5});
            this.tls_Principal.Location = new System.Drawing.Point(0, 0);
            this.tls_Principal.Name = "tls_Principal";
            this.tls_Principal.Size = new System.Drawing.Size(446, 55);
            this.tls_Principal.TabIndex = 32;
            this.tls_Principal.Text = "toolStrip1";
            // 
            // tsbtn_Guardar
            // 
            this.tsbtn_Guardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtn_Guardar.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_Guardar.Image")));
            this.tsbtn_Guardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtn_Guardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_Guardar.Name = "tsbtn_Guardar";
            this.tsbtn_Guardar.Size = new System.Drawing.Size(52, 52);
            this.tsbtn_Guardar.Text = "toolStripButton6";
            this.tsbtn_Guardar.Click += new System.EventHandler(this.tsbtn_Guardar_Click);
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.ForeColor = System.Drawing.Color.White;
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(49, 52);
            this.toolStripLabel6.Text = "Guardar";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 55);
            // 
            // tsbtn_Salir
            // 
            this.tsbtn_Salir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtn_Salir.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_Salir.Image")));
            this.tsbtn_Salir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtn_Salir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_Salir.Name = "tsbtn_Salir";
            this.tsbtn_Salir.Size = new System.Drawing.Size(52, 52);
            this.tsbtn_Salir.Text = "toolStripButton5";
            this.tsbtn_Salir.Click += new System.EventHandler(this.tsbtn_Salir_Click);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.ForeColor = System.Drawing.Color.White;
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(29, 52);
            this.toolStripLabel5.Text = "Salir";
            // 
            // Cmb_Estados
            // 
            this.Cmb_Estados.FormattingEnabled = true;
            this.Cmb_Estados.Location = new System.Drawing.Point(102, 172);
            this.Cmb_Estados.Name = "Cmb_Estados";
            this.Cmb_Estados.Size = new System.Drawing.Size(121, 21);
            this.Cmb_Estados.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(53, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Estado:";
            // 
            // Txt_DescripcionMarca
            // 
            this.Txt_DescripcionMarca.Location = new System.Drawing.Point(102, 126);
            this.Txt_DescripcionMarca.MaxLength = 25;
            this.Txt_DescripcionMarca.Name = "Txt_DescripcionMarca";
            this.Txt_DescripcionMarca.Size = new System.Drawing.Size(170, 20);
            this.Txt_DescripcionMarca.TabIndex = 36;
            // 
            // Txt_IdMarca
            // 
            this.Txt_IdMarca.Location = new System.Drawing.Point(102, 83);
            this.Txt_IdMarca.MaxLength = 1;
            this.Txt_IdMarca.Name = "Txt_IdMarca";
            this.Txt_IdMarca.Size = new System.Drawing.Size(100, 20);
            this.Txt_IdMarca.TabIndex = 35;
            // 
            // Lbl_Marca
            // 
            this.Lbl_Marca.AutoSize = true;
            this.Lbl_Marca.BackColor = System.Drawing.Color.White;
            this.Lbl_Marca.Location = new System.Drawing.Point(28, 129);
            this.Lbl_Marca.Name = "Lbl_Marca";
            this.Lbl_Marca.Size = new System.Drawing.Size(68, 13);
            this.Lbl_Marca.TabIndex = 34;
            this.Lbl_Marca.Text = "Desc Marca:";
            // 
            // Lbl_IdMarca
            // 
            this.Lbl_IdMarca.AutoSize = true;
            this.Lbl_IdMarca.BackColor = System.Drawing.Color.White;
            this.Lbl_IdMarca.Location = new System.Drawing.Point(44, 86);
            this.Lbl_IdMarca.Name = "Lbl_IdMarca";
            this.Lbl_IdMarca.Size = new System.Drawing.Size(52, 13);
            this.Lbl_IdMarca.TabIndex = 33;
            this.Lbl_IdMarca.Text = "Id Marca:";
            // 
            // Frm_Editar_Marcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(446, 274);
            this.Controls.Add(this.Cmb_Estados);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_DescripcionMarca);
            this.Controls.Add(this.Txt_IdMarca);
            this.Controls.Add(this.Lbl_Marca);
            this.Controls.Add(this.Lbl_IdMarca);
            this.Controls.Add(this.tls_Principal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Editar_Marcas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Marcas";
            this.Load += new System.EventHandler(this.Frm_Editar_Marcas_Load);
            this.tls_Principal.ResumeLayout(false);
            this.tls_Principal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tls_Principal;
        private System.Windows.Forms.ToolStripButton tsbtn_Guardar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tsbtn_Salir;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ComboBox Cmb_Estados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_DescripcionMarca;
        private System.Windows.Forms.TextBox Txt_IdMarca;
        private System.Windows.Forms.Label Lbl_Marca;
        private System.Windows.Forms.Label Lbl_IdMarca;
    }
}