namespace Buscadores
{
    partial class FormularioPideCódigoYCadena
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
            this.sóloPalabrasCompletas = new System.Windows.Forms.CheckBox();
            this.coincidirMayúsculasMinúsculas = new System.Windows.Forms.CheckBox();
            this.cadenaBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.código = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sóloPalabrasCompletas
            // 
            this.sóloPalabrasCompletas.AutoSize = true;
            this.sóloPalabrasCompletas.Location = new System.Drawing.Point(14, 116);
            this.sóloPalabrasCompletas.Name = "sóloPalabrasCompletas";
            this.sóloPalabrasCompletas.Size = new System.Drawing.Size(141, 17);
            this.sóloPalabrasCompletas.TabIndex = 6;
            this.sóloPalabrasCompletas.Text = "Sólo palabras completas";
            this.sóloPalabrasCompletas.UseVisualStyleBackColor = true;
            // 
            // coincidirMayúsculasMinúsculas
            // 
            this.coincidirMayúsculasMinúsculas.AutoSize = true;
            this.coincidirMayúsculasMinúsculas.Location = new System.Drawing.Point(14, 92);
            this.coincidirMayúsculasMinúsculas.Name = "coincidirMayúsculasMinúsculas";
            this.coincidirMayúsculasMinúsculas.Size = new System.Drawing.Size(179, 17);
            this.coincidirMayúsculasMinúsculas.TabIndex = 5;
            this.coincidirMayúsculasMinúsculas.Text = "Coincidir mayúsculas minúsculas";
            this.coincidirMayúsculasMinúsculas.UseVisualStyleBackColor = true;
            // 
            // cadenaBuscar
            // 
            this.cadenaBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cadenaBuscar.Location = new System.Drawing.Point(14, 65);
            this.cadenaBuscar.Name = "cadenaBuscar";
            this.cadenaBuscar.Size = new System.Drawing.Size(171, 20);
            this.cadenaBuscar.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Con la cadena";
            // 
            // código
            // 
            this.código.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.código.Location = new System.Drawing.Point(14, 25);
            this.código.Name = "código";
            this.código.Size = new System.Drawing.Size(171, 20);
            this.código.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Con el código";
            // 
            // FormularioPideCódigoYCadena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(197, 145);
            this.Controls.Add(this.código);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sóloPalabrasCompletas);
            this.Controls.Add(this.coincidirMayúsculasMinúsculas);
            this.Controls.Add(this.cadenaBuscar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormularioPideCódigoYCadena";
            this.Text = "FormularioPideCódigoYCadena";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox sóloPalabrasCompletas;
        private System.Windows.Forms.CheckBox coincidirMayúsculasMinúsculas;
        private System.Windows.Forms.TextBox cadenaBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox código;
        private System.Windows.Forms.Label label2;
    }
}