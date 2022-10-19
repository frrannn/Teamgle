namespace Project
{
    partial class Form4
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Liga = new System.Windows.Forms.Label();
            this.Fundacion = new System.Windows.Forms.Label();
            this.Escudo = new System.Windows.Forms.PictureBox();
            this.Mensajefin = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Titulos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Escudo)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(234, 152);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(256, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Project.Properties.Resources.image_93;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(520, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 50);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(577, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::Project.Properties.Resources.image_97;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(43, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 45);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Liga
            // 
            this.Liga.Location = new System.Drawing.Point(78, 313);
            this.Liga.Name = "Liga";
            this.Liga.Size = new System.Drawing.Size(93, 24);
            this.Liga.TabIndex = 4;
            // 
            // Fundacion
            // 
            this.Fundacion.Location = new System.Drawing.Point(272, 313);
            this.Fundacion.Name = "Fundacion";
            this.Fundacion.Size = new System.Drawing.Size(81, 23);
            this.Fundacion.TabIndex = 5;
            this.Fundacion.Visible = false;
            // 
            // Escudo
            // 
            this.Escudo.Location = new System.Drawing.Point(638, 313);
            this.Escudo.Name = "Escudo";
            this.Escudo.Size = new System.Drawing.Size(100, 50);
            this.Escudo.TabIndex = 7;
            this.Escudo.TabStop = false;
            // 
            // Mensajefin
            // 
            this.Mensajefin.AutoSize = true;
            this.Mensajefin.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Mensajefin.Location = new System.Drawing.Point(335, 46);
            this.Mensajefin.Name = "Mensajefin";
            this.Mensajefin.Size = new System.Drawing.Size(0, 13);
            this.Mensajefin.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label2.Location = new System.Drawing.Point(237, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Escribe aqui el nommbre del equipo";
            // 
            // Titulos
            // 
            this.Titulos.Location = new System.Drawing.Point(469, 313);
            this.Titulos.Name = "Titulos";
            this.Titulos.Size = new System.Drawing.Size(77, 24);
            this.Titulos.TabIndex = 6;
            this.Titulos.Visible = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project.Properties.Resources.Group_337;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Mensajefin);
            this.Controls.Add(this.Escudo);
            this.Controls.Add(this.Titulos);
            this.Controls.Add(this.Fundacion);
            this.Controls.Add(this.Liga);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.DoubleBuffered = true;
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Escudo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label Liga;
        private System.Windows.Forms.Label Fundacion;
        private System.Windows.Forms.PictureBox Escudo;
        private System.Windows.Forms.Label Mensajefin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Titulos;
    }
}