namespace gridview
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
            this.gvnose = new System.Windows.Forms.DataGridView();
            this.btnmostrar = new System.Windows.Forms.Button();
            this.lbl2 = new System.Windows.Forms.Label();
            this.btn2 = new System.Windows.Forms.Button();
            this.txt11 = new System.Windows.Forms.TextBox();
            this.lbname2 = new System.Windows.Forms.Label();
            this.txbname2 = new System.Windows.Forms.TextBox();
            this.lbedad = new System.Windows.Forms.Label();
            this.txbedad = new System.Windows.Forms.TextBox();
            this.lbestatura = new System.Windows.Forms.Label();
            this.txbEstatura = new System.Windows.Forms.TextBox();
            this.lbojos = new System.Windows.Forms.Label();
            this.txbojos = new System.Windows.Forms.TextBox();
            this.lbestudia = new System.Windows.Forms.Label();
            this.txbestudia = new System.Windows.Forms.TextBox();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvnose)).BeginInit();
            this.SuspendLayout();
            // 
            // gvnose
            // 
            this.gvnose.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvnose.Location = new System.Drawing.Point(38, 46);
            this.gvnose.Name = "gvnose";
            this.gvnose.Size = new System.Drawing.Size(503, 170);
            this.gvnose.TabIndex = 0;
            // 
            // btnmostrar
            // 
            this.btnmostrar.Location = new System.Drawing.Point(189, 222);
            this.btnmostrar.Name = "btnmostrar";
            this.btnmostrar.Size = new System.Drawing.Size(191, 58);
            this.btnmostrar.TabIndex = 1;
            this.btnmostrar.Text = "Mostrar";
            this.btnmostrar.UseVisualStyleBackColor = true;
            this.btnmostrar.Click += new System.EventHandler(this.btnmostrar_Click);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(51, 328);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(44, 13);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "Nombre";
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(38, 370);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(78, 28);
            this.btn2.TabIndex = 3;
            this.btn2.Text = "Eliminar";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // txt11
            // 
            this.txt11.Location = new System.Drawing.Point(38, 344);
            this.txt11.Name = "txt11";
            this.txt11.Size = new System.Drawing.Size(78, 20);
            this.txt11.TabIndex = 4;
            // 
            // lbname2
            // 
            this.lbname2.AutoSize = true;
            this.lbname2.Location = new System.Drawing.Point(478, 222);
            this.lbname2.Name = "lbname2";
            this.lbname2.Size = new System.Drawing.Size(44, 13);
            this.lbname2.TabIndex = 5;
            this.lbname2.Text = "Nombre";
            // 
            // txbname2
            // 
            this.txbname2.Location = new System.Drawing.Point(481, 238);
            this.txbname2.Name = "txbname2";
            this.txbname2.Size = new System.Drawing.Size(78, 20);
            this.txbname2.TabIndex = 6;
            // 
            // lbedad
            // 
            this.lbedad.AutoSize = true;
            this.lbedad.Location = new System.Drawing.Point(478, 261);
            this.lbedad.Name = "lbedad";
            this.lbedad.Size = new System.Drawing.Size(32, 13);
            this.lbedad.TabIndex = 7;
            this.lbedad.Text = "Edad";
            // 
            // txbedad
            // 
            this.txbedad.Location = new System.Drawing.Point(481, 277);
            this.txbedad.Name = "txbedad";
            this.txbedad.Size = new System.Drawing.Size(78, 20);
            this.txbedad.TabIndex = 8;
            // 
            // lbestatura
            // 
            this.lbestatura.AutoSize = true;
            this.lbestatura.Location = new System.Drawing.Point(478, 300);
            this.lbestatura.Name = "lbestatura";
            this.lbestatura.Size = new System.Drawing.Size(46, 13);
            this.lbestatura.TabIndex = 9;
            this.lbestatura.Text = "Estatura";
            // 
            // txbEstatura
            // 
            this.txbEstatura.Location = new System.Drawing.Point(481, 316);
            this.txbEstatura.Name = "txbEstatura";
            this.txbEstatura.Size = new System.Drawing.Size(78, 20);
            this.txbEstatura.TabIndex = 10;
            // 
            // lbojos
            // 
            this.lbojos.AutoSize = true;
            this.lbojos.Location = new System.Drawing.Point(478, 339);
            this.lbojos.Name = "lbojos";
            this.lbojos.Size = new System.Drawing.Size(53, 13);
            this.lbojos.TabIndex = 11;
            this.lbojos.Text = "Color ojos";
            // 
            // txbojos
            // 
            this.txbojos.Location = new System.Drawing.Point(481, 355);
            this.txbojos.Name = "txbojos";
            this.txbojos.Size = new System.Drawing.Size(78, 20);
            this.txbojos.TabIndex = 12;
            // 
            // lbestudia
            // 
            this.lbestudia.AutoSize = true;
            this.lbestudia.Location = new System.Drawing.Point(478, 378);
            this.lbestudia.Name = "lbestudia";
            this.lbestudia.Size = new System.Drawing.Size(42, 13);
            this.lbestudia.TabIndex = 13;
            this.lbestudia.Text = "Estudia";
            // 
            // txbestudia
            // 
            this.txbestudia.Location = new System.Drawing.Point(481, 394);
            this.txbestudia.Name = "txbestudia";
            this.txbestudia.Size = new System.Drawing.Size(78, 20);
            this.txbestudia.TabIndex = 14;
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(444, 420);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(78, 28);
            this.btnagregar.TabIndex = 15;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(528, 420);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(78, 28);
            this.btnActualizar.TabIndex = 16;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(602, 46);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(78, 28);
            this.btnlimpiar.TabIndex = 17;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.txbestudia);
            this.Controls.Add(this.lbestudia);
            this.Controls.Add(this.txbojos);
            this.Controls.Add(this.lbojos);
            this.Controls.Add(this.txbEstatura);
            this.Controls.Add(this.lbestatura);
            this.Controls.Add(this.txbedad);
            this.Controls.Add(this.lbedad);
            this.Controls.Add(this.txbname2);
            this.Controls.Add(this.lbname2);
            this.Controls.Add(this.txt11);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.btnmostrar);
            this.Controls.Add(this.gvnose);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gvnose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvnose;
        private System.Windows.Forms.Button btnmostrar;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.TextBox txt11;
        private System.Windows.Forms.Label lbname2;
        private System.Windows.Forms.TextBox txbname2;
        private System.Windows.Forms.Label lbedad;
        private System.Windows.Forms.TextBox txbedad;
        private System.Windows.Forms.Label lbestatura;
        private System.Windows.Forms.TextBox txbEstatura;
        private System.Windows.Forms.Label lbojos;
        private System.Windows.Forms.TextBox txbojos;
        private System.Windows.Forms.Label lbestudia;
        private System.Windows.Forms.TextBox txbestudia;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnlimpiar;
    }
}

