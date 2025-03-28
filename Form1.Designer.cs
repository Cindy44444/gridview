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
            ((System.ComponentModel.ISupportInitialize)(this.gvnose)).BeginInit();
            this.SuspendLayout();
            // 
            // gvnose
            // 
            this.gvnose.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvnose.Location = new System.Drawing.Point(38, 46);
            this.gvnose.Name = "gvnose";
            this.gvnose.Size = new System.Drawing.Size(503, 66);
            this.gvnose.TabIndex = 0;
            // 
            // btnmostrar
            // 
            this.btnmostrar.Location = new System.Drawing.Point(192, 163);
            this.btnmostrar.Name = "btnmostrar";
            this.btnmostrar.Size = new System.Drawing.Size(191, 58);
            this.btnmostrar.TabIndex = 1;
            this.btnmostrar.Text = "Mostrar";
            this.btnmostrar.UseVisualStyleBackColor = true;
            this.btnmostrar.Click += new System.EventHandler(this.btnmostrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnmostrar);
            this.Controls.Add(this.gvnose);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gvnose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvnose;
        private System.Windows.Forms.Button btnmostrar;
    }
}

