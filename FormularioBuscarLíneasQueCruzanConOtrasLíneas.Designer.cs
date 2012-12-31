namespace Buscadores
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
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar líneas con código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Que se crucen con líneas con código";
            // 
            // códigosLíneasSecundarias
            // 
            this.códigosLíneasSecundarias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.códigosLíneasSecundarias.Location = new System.Drawing.Point(11, 209);
            this.códigosLíneasSecundarias.Multiline = true;
            this.códigosLíneasSecundarias.Name = "códigosLíneasSecundarias";
            this.códigosLíneasSecundarias.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.códigosLíneasSecundarias.Size = new System.Drawing.Size(259, 111);
            this.códigosLíneasSecundarias.TabIndex = 3;
            // 
            // botónBuscarCódigosSecundatios
            // 
            this.botónBuscarCódigosSecundatios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botónBuscarCódigosSecundatios.Location = new System.Drawing.Point(195, 326);
            this.botónBuscarCódigosSecundatios.Name = "botónBuscarCódigosSecundatios";
            this.botónBuscarCódigosSecundatios.Size = new System.Drawing.Size(75, 23);
            this.botónBuscarCódigosSecundatios.TabIndex = 4;
            this.botónBuscarCódigosSecundatios.Text = "&Añadir...";
            this.botónBuscarCódigosSecundatios.UseVisualStyleBackColor = true;
            this.botónBuscarCódigosSecundatios.Click += new System.EventHandler(this.botónBuscarCódigosSecundarios_Click);
            // 
            // códigosLíneasPrincipales
            // 
            this.códigosLíneasPrincipales.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.códigosLíneasPrincipales.ForeColor = System.Drawing.SystemColors.WindowText;
            this.códigosLíneasPrincipales.Location = new System.Drawing.Point(11, 35);
            this.códigosLíneasPrincipales.Multiline = true;
            this.códigosLíneasPrincipales.Name = "códigosLíneasPrincipales";
            this.códigosLíneasPrincipales.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.códigosLíneasPrincipales.Size = new System.Drawing.Size(259, 111);
            this.códigosLíneasPrincipales.TabIndex = 5;
            // 
            // botónBuscarCódigosPrincipales
            // 
            this.botónBuscarCódigosPrincipales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botónBuscarCódigosPrincipales.Location = new System.Drawing.Point(195, 152);
            this.botónBuscarCódigosPrincipales.Name = "botónBuscarCódigosPrincipales";
            this.botónBuscarCódigosPrincipales.Size = new System.Drawing.Size(75, 23);
            this.botónBuscarCódigosPrincipales.TabIndex = 6;
            this.botónBuscarCódigosPrincipales.Text = "&Añadir...";
            this.botónBuscarCódigosPrincipales.UseVisualStyleBackColor = true;
            this.botónBuscarCódigosPrincipales.Click += new System.EventHandler(this.botónBuscarCódigosPrincipales_Click);
            // 
            // FormularioBuscarLíneasQueCruzanConOtrasLíneas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 363);
            this.Controls.Add(this.botónBuscarCódigosPrincipales);
            this.Controls.Add(this.códigosLíneasPrincipales);
            this.Controls.Add(this.botónBuscarCódigosSecundatios);
            this.Controls.Add(this.códigosLíneasSecundarias);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormularioBuscarLíneasQueCruzanConOtrasLíneas";
            this.Text = "FormularioBuscarLíneasQueCruzanConOtrasLíneas";
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