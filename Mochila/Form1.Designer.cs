namespace Mochila
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
            this.label19 = new System.Windows.Forms.Label();
            this.tbItems = new System.Windows.Forms.TextBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPoblacion = new System.Windows.Forms.TextBox();
            this.lbIndividuos = new System.Windows.Forms.ListBox();
            this.btnAdditems = new System.Windows.Forms.Button();
            this.lbGanancias = new System.Windows.Forms.ListBox();
            this.lbPesos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(224, 39);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(96, 13);
            this.label19.TabIndex = 44;
            this.label19.Text = "Items (Número par)";
            // 
            // tbItems
            // 
            this.tbItems.Location = new System.Drawing.Point(220, 65);
            this.tbItems.Name = "tbItems";
            this.tbItems.Size = new System.Drawing.Size(100, 20);
            this.tbItems.TabIndex = 43;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.Location = new System.Drawing.Point(808, 48);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(102, 48);
            this.btnIniciar.TabIndex = 42;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Población (Número par)";
            // 
            // tbPoblacion
            // 
            this.tbPoblacion.Location = new System.Drawing.Point(84, 65);
            this.tbPoblacion.Name = "tbPoblacion";
            this.tbPoblacion.Size = new System.Drawing.Size(100, 20);
            this.tbPoblacion.TabIndex = 40;
            // 
            // lbIndividuos
            // 
            this.lbIndividuos.FormattingEnabled = true;
            this.lbIndividuos.Location = new System.Drawing.Point(206, 139);
            this.lbIndividuos.Name = "lbIndividuos";
            this.lbIndividuos.Size = new System.Drawing.Size(91, 147);
            this.lbIndividuos.TabIndex = 39;
            // 
            // btnAdditems
            // 
            this.btnAdditems.Location = new System.Drawing.Point(341, 57);
            this.btnAdditems.Name = "btnAdditems";
            this.btnAdditems.Size = new System.Drawing.Size(75, 35);
            this.btnAdditems.TabIndex = 45;
            this.btnAdditems.Text = "Agregar Items";
            this.btnAdditems.UseVisualStyleBackColor = true;
            this.btnAdditems.Click += new System.EventHandler(this.btnAdditems_Click);
            // 
            // lbGanancias
            // 
            this.lbGanancias.FormattingEnabled = true;
            this.lbGanancias.Location = new System.Drawing.Point(109, 139);
            this.lbGanancias.Name = "lbGanancias";
            this.lbGanancias.Size = new System.Drawing.Size(91, 147);
            this.lbGanancias.TabIndex = 46;
            // 
            // lbPesos
            // 
            this.lbPesos.FormattingEnabled = true;
            this.lbPesos.Location = new System.Drawing.Point(12, 139);
            this.lbPesos.Name = "lbPesos";
            this.lbPesos.Size = new System.Drawing.Size(91, 147);
            this.lbPesos.TabIndex = 47;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 325);
            this.Controls.Add(this.lbPesos);
            this.Controls.Add(this.lbGanancias);
            this.Controls.Add(this.btnAdditems);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.tbItems);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbPoblacion);
            this.Controls.Add(this.lbIndividuos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tbItems;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPoblacion;
        private System.Windows.Forms.ListBox lbIndividuos;
        private System.Windows.Forms.Button btnAdditems;
        public System.Windows.Forms.ListBox lbPesos;
        public System.Windows.Forms.ListBox lbGanancias;
    }
}

