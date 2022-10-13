
namespace WindowsFormsApp1
{
    partial class Form1
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
            this.Liga = new System.Windows.Forms.Label();
            this.titulos = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Escudo = new System.Windows.Forms.PictureBox();
            this.NombreEq = new System.Windows.Forms.TextBox();
            this.Fundacion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Escudo)).BeginInit();
            this.SuspendLayout();
            // 
            // Liga
            // 
            this.Liga.AutoSize = true;
            this.Liga.Location = new System.Drawing.Point(69, 311);
            this.Liga.Name = "Liga";
            this.Liga.Size = new System.Drawing.Size(35, 13);
            this.Liga.TabIndex = 5;
            this.Liga.Text = "label1";
            this.Liga.Click += new System.EventHandler(this.Liga_Click);
            // 
            // titulos
            // 
            this.titulos.AutoSize = true;
            this.titulos.Location = new System.Drawing.Point(484, 311);
            this.titulos.Name = "titulos";
            this.titulos.Size = new System.Drawing.Size(35, 13);
            this.titulos.TabIndex = 7;
            this.titulos.Text = "label3";
            this.titulos.Click += new System.EventHandler(this.titulos_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.pantalla_de_juego;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(1, 1, 3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(877, 485);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Escudo
            // 
            this.Escudo.Location = new System.Drawing.Point(678, 311);
            this.Escudo.Name = "Escudo";
            this.Escudo.Size = new System.Drawing.Size(135, 109);
            this.Escudo.TabIndex = 10;
            this.Escudo.TabStop = false;
            // 
            // NombreEq
            // 
            this.NombreEq.AccessibleName = "NombreEq";
            this.NombreEq.Location = new System.Drawing.Point(391, 132);
            this.NombreEq.Name = "NombreEq";
            this.NombreEq.Size = new System.Drawing.Size(327, 20);
            this.NombreEq.TabIndex = 11;
            this.NombreEq.TextChanged += new System.EventHandler(this.NombreEq_TextChanged);
            // 
            // Fundacion
            // 
            this.Fundacion.AccessibleName = "Fundacion";
            this.Fundacion.AutoSize = true;
            this.Fundacion.Location = new System.Drawing.Point(273, 310);
            this.Fundacion.Name = "Fundacion";
            this.Fundacion.Size = new System.Drawing.Size(35, 13);
            this.Fundacion.TabIndex = 12;
            this.Fundacion.Text = "label1";
            this.Fundacion.Click += new System.EventHandler(this.Fundacion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 529);
            this.Controls.Add(this.Fundacion);
            this.Controls.Add(this.NombreEq);
            this.Controls.Add(this.Escudo);
            this.Controls.Add(this.titulos);
            this.Controls.Add(this.Liga);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Escudo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Liga;
        private System.Windows.Forms.Label titulos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Escudo;
        private System.Windows.Forms.TextBox NombreEq;
        private System.Windows.Forms.Label Fundacion;
    }
}

