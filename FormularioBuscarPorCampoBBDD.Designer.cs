namespace Digi21Search
{
    partial class FormularioBuscarPorCampoBBDD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioBuscarPorCampoBBDD));
            this.sóloPalabrasCompletas = new System.Windows.Forms.CheckBox();
            this.coincidirMayúsculasMinúsculas = new System.Windows.Forms.CheckBox();
            this.cadenaBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.botónRefrescar = new System.Windows.Forms.Button();
            this.comboTablas = new System.Windows.Forms.ComboBox();
            this.comboCampos = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // sóloPalabrasCompletas
            // 
            this.sóloPalabrasCompletas.AutoSize = true;
            this.sóloPalabrasCompletas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.sóloPalabrasCompletas.Location = new System.Drawing.Point(15, 156);
            this.sóloPalabrasCompletas.Name = "sóloPalabrasCompletas";
            this.sóloPalabrasCompletas.Size = new System.Drawing.Size(141, 17);
            this.sóloPalabrasCompletas.TabIndex = 8;
            this.sóloPalabrasCompletas.Text = "Sólo palabras completas";
            this.sóloPalabrasCompletas.UseVisualStyleBackColor = true;
            // 
            // coincidirMayúsculasMinúsculas
            // 
            this.coincidirMayúsculasMinúsculas.AutoSize = true;
            this.coincidirMayúsculasMinúsculas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.coincidirMayúsculasMinúsculas.Location = new System.Drawing.Point(15, 133);
            this.coincidirMayúsculasMinúsculas.Name = "coincidirMayúsculasMinúsculas";
            this.coincidirMayúsculasMinúsculas.Size = new System.Drawing.Size(187, 17);
            this.coincidirMayúsculasMinúsculas.TabIndex = 7;
            this.coincidirMayúsculasMinúsculas.Text = "Coincidir mayúsculas y minúsculas";
            this.coincidirMayúsculasMinúsculas.UseVisualStyleBackColor = true;
            // 
            // cadenaBuscar
            // 
            this.cadenaBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cadenaBuscar.Location = new System.Drawing.Point(15, 107);
            this.cadenaBuscar.Name = "cadenaBuscar";
            this.cadenaBuscar.Size = new System.Drawing.Size(187, 20);
            this.cadenaBuscar.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(12, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Valor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Que enlacen con la tabla";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(12, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Campo";
            // 
            // botónRefrescar
            // 
            this.botónRefrescar.Image = ((System.Drawing.Image)(resources.GetObject("botónRefrescar.Image")));
            this.botónRefrescar.Location = new System.Drawing.Point(163, 25);
            this.botónRefrescar.Name = "botónRefrescar";
            this.botónRefrescar.Size = new System.Drawing.Size(39, 23);
            this.botónRefrescar.TabIndex = 3;
            this.botónRefrescar.UseVisualStyleBackColor = true;
            this.botónRefrescar.Click += new System.EventHandler(this.botónRefrescar_Click);
            // 
            // comboTablas
            // 
            this.comboTablas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTablas.FormattingEnabled = true;
            this.comboTablas.ItemHeight = 13;
            this.comboTablas.Location = new System.Drawing.Point(13, 25);
            this.comboTablas.Name = "comboTablas";
            this.comboTablas.Size = new System.Drawing.Size(140, 21);
            this.comboTablas.TabIndex = 10;
            this.comboTablas.SelectedIndexChanged += new System.EventHandler(this.comboTablas_SelectedIndexChanged);
            // 
            // comboCampos
            // 
            this.comboCampos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCampos.FormattingEnabled = true;
            this.comboCampos.ItemHeight = 13;
            this.comboCampos.Location = new System.Drawing.Point(15, 64);
            this.comboCampos.Name = "comboCampos";
            this.comboCampos.Size = new System.Drawing.Size(184, 21);
            this.comboCampos.TabIndex = 11;
            // 
            // FormularioBuscarPorCampoBBDD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 190);
            this.Controls.Add(this.comboCampos);
            this.Controls.Add(this.comboTablas);
            this.Controls.Add(this.botónRefrescar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sóloPalabrasCompletas);
            this.Controls.Add(this.coincidirMayúsculasMinúsculas);
            this.Controls.Add(this.cadenaBuscar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormularioBuscarPorCampoBBDD";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FormularioBuscarPorCampoBBDD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox sóloPalabrasCompletas;
        private System.Windows.Forms.CheckBox coincidirMayúsculasMinúsculas;
        private System.Windows.Forms.TextBox cadenaBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button botónRefrescar;
        private System.Windows.Forms.ComboBox comboTablas;
        private System.Windows.Forms.ComboBox comboCampos;
    }
}