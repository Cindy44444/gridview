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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

