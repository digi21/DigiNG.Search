namespace Buscadores
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
            this.código = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.queEsténCerradas = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // código
            // 
            this.código.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.código.Location = new System.Drawing.Point(55, 12);
            this.código.Name = "código";
            this.código.Size = new System.Drawing.Size(100, 20);
            this.código.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Código";
            // 
            // queEsténCerradas
            // 
            this.queEsténCerradas.AutoSize = true;
            this.queEsténCerradas.Location = new System.Drawing.Point(15, 38);
            this.queEsténCerradas.Name = "queEsténCerradas";
            this.queEsténCerradas.Size = new System.Drawing.Size(119, 17);
            this.queEsténCerradas.TabIndex = 4;
            this.queEsténCerradas.Text = "Que estén cerradas";
            this.queEsténCerradas.UseVisualStyleBackColor = true;
            // 
            // FormularioBuscarLíneasCriterio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 71);
            this.Controls.Add(this.queEsténCerradas);
            this.Controls.Add(this.código);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormularioBuscarLíneasCriterio";
            this.Text = "FormularioBuscarLíneasCriterio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox código;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox queEsténCerradas;
    }
}