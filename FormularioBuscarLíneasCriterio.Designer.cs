namespace DigiNG.Search
{
    partial class FormularioBuscarLíneasCriterio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioBuscarLíneasCriterio));
            this.código = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.queEsténCerradas = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // código
            // 
            resources.ApplyResources(this.código, "código");
            this.código.Name = "código";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // queEsténCerradas
            // 
            resources.ApplyResources(this.queEsténCerradas, "queEsténCerradas");
            this.queEsténCerradas.Name = "queEsténCerradas";
            this.queEsténCerradas.UseVisualStyleBackColor = true;
            // 
            // FormularioBuscarLíneasCriterio
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.queEsténCerradas);
            this.Controls.Add(this.código);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormularioBuscarLíneasCriterio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox código;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox queEsténCerradas;
    }
}