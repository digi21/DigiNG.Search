namespace Buscadores
{
    partial class FormularioPideCadena
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cadenaBuscar = new System.Windows.Forms.TextBox();
            this.coincidirMayúsculasMinúsculas = new System.Windows.Forms.CheckBox();
            this.sóloPalabrasCompletas = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar textos con la cadena";
            // 
            // cadenaBuscar
            // 
            this.cadenaBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cadenaBuscar.Location = new System.Drawing.Point(15, 26);
            this.cadenaBuscar.Name = "cadenaBuscar";
            this.cadenaBuscar.Size = new System.Drawing.Size(257, 20);
            this.cadenaBuscar.TabIndex = 1;
            // 
            // coincidirMayúsculasMinúsculas
            // 
            this.coincidirMayúsculasMinúsculas.AutoSize = true;
            this.coincidirMayúsculasMinúsculas.Location = new System.Drawing.Point(15, 53);
            this.coincidirMayúsculasMinúsculas.Name = "coincidirMayúsculasMinúsculas";
            this.coincidirMayúsculasMinúsculas.Size = new System.Drawing.Size(179, 17);
            this.coincidirMayúsculasMinúsculas.TabIndex = 2;
            this.coincidirMayúsculasMinúsculas.Text = "Coincidir mayúsculas minúsculas";
            this.coincidirMayúsculasMinúsculas.UseVisualStyleBackColor = true;
            // 
            // sóloPalabrasCompletas
            // 
            this.sóloPalabrasCompletas.AutoSize = true;
            this.sóloPalabrasCompletas.Location = new System.Drawing.Point(15, 77);
            this.sóloPalabrasCompletas.Name = "sóloPalabrasCompletas";
            this.sóloPalabrasCompletas.Size = new System.Drawing.Size(141, 17);
            this.sóloPalabrasCompletas.TabIndex = 3;
            this.sóloPalabrasCompletas.Text = "Sólo palabras completas";
            this.sóloPalabrasCompletas.UseVisualStyleBackColor = true;
            // 
            // FormularioPideCadena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 108);
            this.Controls.Add(this.sóloPalabrasCompletas);
            this.Controls.Add(this.coincidirMayúsculasMinúsculas);
            this.Controls.Add(this.cadenaBuscar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormularioPideCadena";
            this.Text = "FormularioPideCadena";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cadenaBuscar;
        private System.Windows.Forms.CheckBox coincidirMayúsculasMinúsculas;
        private System.Windows.Forms.CheckBox sóloPalabrasCompletas;
    }
}