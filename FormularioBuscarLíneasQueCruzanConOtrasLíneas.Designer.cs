namespace DigiNG.Search
{
    partial class FormularioBuscarLíneasQueCruzanConOtrasLíneas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioBuscarLíneasQueCruzanConOtrasLíneas));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.códigosLíneasSecundarias = new System.Windows.Forms.TextBox();
            this.botónBuscarCódigosSecundatios = new System.Windows.Forms.Button();
            this.códigosLíneasPrincipales = new System.Windows.Forms.TextBox();
            this.botónBuscarCódigosPrincipales = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // códigosLíneasSecundarias
            // 
            resources.ApplyResources(this.códigosLíneasSecundarias, "códigosLíneasSecundarias");
            this.códigosLíneasSecundarias.Name = "códigosLíneasSecundarias";
            // 
            // botónBuscarCódigosSecundatios
            // 
            resources.ApplyResources(this.botónBuscarCódigosSecundatios, "botónBuscarCódigosSecundatios");
            this.botónBuscarCódigosSecundatios.Name = "botónBuscarCódigosSecundatios";
            this.botónBuscarCódigosSecundatios.UseVisualStyleBackColor = true;
            this.botónBuscarCódigosSecundatios.Click += new System.EventHandler(this.botónBuscarCódigosSecundarios_Click);
            // 
            // códigosLíneasPrincipales
            // 
            resources.ApplyResources(this.códigosLíneasPrincipales, "códigosLíneasPrincipales");
            this.códigosLíneasPrincipales.ForeColor = System.Drawing.SystemColors.WindowText;
            this.códigosLíneasPrincipales.Name = "códigosLíneasPrincipales";
            // 
            // botónBuscarCódigosPrincipales
            // 
            resources.ApplyResources(this.botónBuscarCódigosPrincipales, "botónBuscarCódigosPrincipales");
            this.botónBuscarCódigosPrincipales.Name = "botónBuscarCódigosPrincipales";
            this.botónBuscarCódigosPrincipales.UseVisualStyleBackColor = true;
            this.botónBuscarCódigosPrincipales.Click += new System.EventHandler(this.botónBuscarCódigosPrincipales_Click);
            // 
            // FormularioBuscarLíneasQueCruzanConOtrasLíneas
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.botónBuscarCódigosPrincipales);
            this.Controls.Add(this.códigosLíneasPrincipales);
            this.Controls.Add(this.botónBuscarCódigosSecundatios);
            this.Controls.Add(this.códigosLíneasSecundarias);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormularioBuscarLíneasQueCruzanConOtrasLíneas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox códigosLíneasSecundarias;
        private System.Windows.Forms.Button botónBuscarCódigosSecundatios;
        private System.Windows.Forms.TextBox códigosLíneasPrincipales;
        private System.Windows.Forms.Button botónBuscarCódigosPrincipales;
    }
}