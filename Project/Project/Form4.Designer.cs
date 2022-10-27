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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.RowEq = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Liga = new System.Windows.Forms.Label();
            this.Fundacion = new System.Windows.Forms.Label();
            this.Escudo = new System.Windows.Forms.PictureBox();
            this.Mensajefin = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Titulos = new System.Windows.Forms.Label();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.equiposFacilesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tEAMGLEDataSet = new Project.TEAMGLEDataSet();
            this.equiposFacilesTableAdapter = new Project.TEAMGLEDataSetTableAdapters.EquiposFacilesTableAdapter();
            this.datagrid = new System.Windows.Forms.DataGridView();
            this.Puntaje = new System.Windows.Forms.Label();
            this.CantAciertos = new System.Windows.Forms.Label();
            this.CantError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Escudo)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.equiposFacilesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEAMGLEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
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
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(516, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 50);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RowEq
            // 
            this.RowEq.Location = new System.Drawing.Point(580, 29);
            this.RowEq.Name = "RowEq";
            this.RowEq.Size = new System.Drawing.Size(75, 78);
            this.RowEq.TabIndex = 2;
            this.RowEq.Click += new System.EventHandler(this.RowEq_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
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
            this.Liga.Location = new System.Drawing.Point(53, 313);
            this.Liga.Name = "Liga";
            this.Liga.Size = new System.Drawing.Size(128, 50);
            this.Liga.TabIndex = 4;
            this.Liga.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Liga.Click += new System.EventHandler(this.Liga_Click);
            // 
            // Fundacion
            // 
            this.Fundacion.Location = new System.Drawing.Point(250, 313);
            this.Fundacion.Name = "Fundacion";
            this.Fundacion.Size = new System.Drawing.Size(123, 65);
            this.Fundacion.TabIndex = 5;
            this.Fundacion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Fundacion.Visible = false;
            this.Fundacion.Click += new System.EventHandler(this.Fundacion_Click);
            // 
            // Escudo
            // 
            this.Escudo.Location = new System.Drawing.Point(638, 313);
            this.Escudo.Name = "Escudo";
            this.Escudo.Size = new System.Drawing.Size(100, 50);
            this.Escudo.TabIndex = 7;
            this.Escudo.TabStop = false;
            this.Escudo.Visible = false;
            this.Escudo.Click += new System.EventHandler(this.Escudo_Click);
            // 
            // Mensajefin
            // 
            this.Mensajefin.AutoSize = true;
            this.Mensajefin.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Mensajefin.Location = new System.Drawing.Point(335, 46);
            this.Mensajefin.Name = "Mensajefin";
            this.Mensajefin.Size = new System.Drawing.Size(0, 13);
            this.Mensajefin.TabIndex = 8;
            this.Mensajefin.Click += new System.EventHandler(this.Mensajefin_Click);
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
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Titulos
            // 
            this.Titulos.Location = new System.Drawing.Point(441, 313);
            this.Titulos.Name = "Titulos";
            this.Titulos.Size = new System.Drawing.Size(133, 65);
            this.Titulos.TabIndex = 6;
            this.Titulos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Titulos.Visible = false;
            this.Titulos.Click += new System.EventHandler(this.Titulos_Click);
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(800, 25);
            this.fillByToolStrip.TabIndex = 12;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // equiposFacilesBindingSource
            // 
            this.equiposFacilesBindingSource.DataMember = "EquiposFaciles";
            this.equiposFacilesBindingSource.DataSource = this.tEAMGLEDataSet;
            // 
            // tEAMGLEDataSet
            // 
            this.tEAMGLEDataSet.DataSetName = "TEAMGLEDataSet";
            this.tEAMGLEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // equiposFacilesTableAdapter
            // 
            this.equiposFacilesTableAdapter.ClearBeforeFill = true;
            // 
            // datagrid
            // 
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid.Location = new System.Drawing.Point(26, 28);
            this.datagrid.Name = "datagrid";
            this.datagrid.Size = new System.Drawing.Size(548, 106);
            this.datagrid.TabIndex = 13;
            this.datagrid.Visible = false;
            this.datagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_CellContentClick);
            // 
            // Puntaje
            // 
            this.Puntaje.AutoSize = true;
            this.Puntaje.Location = new System.Drawing.Point(703, 46);
            this.Puntaje.Name = "Puntaje";
            this.Puntaje.Size = new System.Drawing.Size(0, 13);
            this.Puntaje.TabIndex = 14;
            this.Puntaje.Click += new System.EventHandler(this.label1_Click);
            // 
            // CantAciertos
            // 
            this.CantAciertos.AutoSize = true;
            this.CantAciertos.Location = new System.Drawing.Point(703, 78);
            this.CantAciertos.Name = "CantAciertos";
            this.CantAciertos.Size = new System.Drawing.Size(0, 13);
            this.CantAciertos.TabIndex = 15;
            this.CantAciertos.Click += new System.EventHandler(this.label3_Click);
            // 
            // CantError
            // 
            this.CantError.AutoSize = true;
            this.CantError.Location = new System.Drawing.Point(703, 107);
            this.CantError.Name = "CantError";
            this.CantError.Size = new System.Drawing.Size(0, 13);
            this.CantError.TabIndex = 16;
            this.CantError.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CantError);
            this.Controls.Add(this.CantAciertos);
            this.Controls.Add(this.Puntaje);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Mensajefin);
            this.Controls.Add(this.Escudo);
            this.Controls.Add(this.Titulos);
            this.Controls.Add(this.Fundacion);
            this.Controls.Add(this.Liga);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.RowEq);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.datagrid);
            this.DoubleBuffered = true;
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Escudo)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.equiposFacilesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEAMGLEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label RowEq;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label Liga;
        private System.Windows.Forms.Label Fundacion;
        private System.Windows.Forms.PictureBox Escudo;
        private System.Windows.Forms.Label Mensajefin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Titulos;
        private TEAMGLEDataSet tEAMGLEDataSet;
        private System.Windows.Forms.BindingSource equiposFacilesBindingSource;
        private TEAMGLEDataSetTableAdapters.EquiposFacilesTableAdapter equiposFacilesTableAdapter;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.DataGridView datagrid;
        private System.Windows.Forms.Label Puntaje;
        private System.Windows.Forms.Label CantAciertos;
        private System.Windows.Forms.Label CantError;
    }
}