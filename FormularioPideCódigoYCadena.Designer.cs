namespace DigiNG.Search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioPideCódigoYCadena));
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
            resources.ApplyResources(this.sóloPalabrasCompletas, "sóloPalabrasCompletas");
            this.sóloPalabrasCompletas.Name = "sóloPalabrasCompletas";
            this.sóloPalabrasCompletas.UseVisualStyleBackColor = true;
            // 
            // coincidirMayúsculasMinúsculas
            // 
            resources.ApplyResources(this.coincidirMayúsculasMinúsculas, "coincidirMayúsculasMinúsculas");
            this.coincidirMayúsculasMinúsculas.Name = "coincidirMayúsculasMinúsculas";
            this.coincidirMayúsculasMinúsculas.UseVisualStyleBackColor = true;
            // 
            // cadenaBuscar
            // 
            resources.ApplyResources(this.cadenaBuscar, "cadenaBuscar");
            this.cadenaBuscar.Name = "cadenaBuscar";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // código
            // 
            resources.ApplyResources(this.código, "código");
            this.código.Name = "código";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // FormularioPideCódigoYCadena
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.código);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sóloPalabrasCompletas);
            this.Controls.Add(this.coincidirMayúsculasMinúsculas);
            this.Controls.Add(this.cadenaBuscar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormularioPideCódigoYCadena";
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