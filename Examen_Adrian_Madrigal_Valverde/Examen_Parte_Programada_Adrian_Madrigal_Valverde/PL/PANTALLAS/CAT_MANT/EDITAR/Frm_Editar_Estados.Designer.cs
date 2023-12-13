namespace PL.PANTALLAS.CAT_MANT.EDITAR
{
    partial class Frm_Editar_Estados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Editar_Estados));
            this.tsbtn_Guardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtn_Salir = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.tls_Principal = new System.Windows.Forms.ToolStrip();
            this.Txt_DescripcionEstado = new System.Windows.Forms.TextBox();
            this.Txt_IdEstado = new System.Windows.Forms.TextBox();
            this.Lbl_Estado = new System.Windows.Forms.Label();
            this.Lbl_IdEstado = new System.Windows.Forms.Label();
            this.tls_Principal.SuspendLayout();
            this.SuspendLayout();
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
            this.tls_Principal.Size = new System.Drawing.Size(442, 55);
            this.tls_Principal.TabIndex = 25;
            this.tls_Principal.Text = "toolStrip1";
            // 
            // Txt_DescripcionEstado
            // 
            this.Txt_DescripcionEstado.Location = new System.Drawing.Point(105, 149);
            this.Txt_DescripcionEstado.MaxLength = 25;
            this.Txt_DescripcionEstado.Name = "Txt_DescripcionEstado";
            this.Txt_DescripcionEstado.Size = new System.Drawing.Size(170, 20);
            this.Txt_DescripcionEstado.TabIndex = 35;
            // 
            // Txt_IdEstado
            // 
            this.Txt_IdEstado.Location = new System.Drawing.Point(105, 106);
            this.Txt_IdEstado.MaxLength = 1;
            this.Txt_IdEstado.Name = "Txt_IdEstado";
            this.Txt_IdEstado.Size = new System.Drawing.Size(100, 20);
            this.Txt_IdEstado.TabIndex = 34;
            // 
            // Lbl_Estado
            // 
            this.Lbl_Estado.AutoSize = true;
            this.Lbl_Estado.BackColor = System.Drawing.Color.White;
            this.Lbl_Estado.Location = new System.Drawing.Point(31, 152);
            this.Lbl_Estado.Name = "Lbl_Estado";
            this.Lbl_Estado.Size = new System.Drawing.Size(71, 13);
            this.Lbl_Estado.TabIndex = 33;
            this.Lbl_Estado.Text = "Desc Estado:";
            // 
            // Lbl_IdEstado
            // 
            this.Lbl_IdEstado.AutoSize = true;
            this.Lbl_IdEstado.BackColor = System.Drawing.Color.White;
            this.Lbl_IdEstado.Location = new System.Drawing.Point(47, 109);
            this.Lbl_IdEstado.Name = "Lbl_IdEstado";
            this.Lbl_IdEstado.Size = new System.Drawing.Size(55, 13);
            this.Lbl_IdEstado.TabIndex = 32;
            this.Lbl_IdEstado.Text = "Id Estado:";
            // 
            // Frm_Editar_Estados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(442, 283);
            this.Controls.Add(this.Txt_DescripcionEstado);
            this.Controls.Add(this.Txt_IdEstado);
            this.Controls.Add(this.Lbl_Estado);
            this.Controls.Add(this.Lbl_IdEstado);
            this.Controls.Add(this.tls_Principal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Editar_Estados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Estados";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Editar_Estados_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Editar_Estados_Load);
            this.tls_Principal.ResumeLayout(false);
            this.tls_Principal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton tsbtn_Guardar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tsbtn_Salir;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStrip tls_Principal;
        private System.Windows.Forms.TextBox Txt_DescripcionEstado;
        private System.Windows.Forms.TextBox Txt_IdEstado;
        private System.Windows.Forms.Label Lbl_Estado;
        private System.Windows.Forms.Label Lbl_IdEstado;
    }
}