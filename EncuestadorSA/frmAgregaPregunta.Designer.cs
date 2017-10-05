namespace EncuestadorSA
{
    partial class frmAgregaPregunta
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
            this.lblPregunta = new System.Windows.Forms.Label();
            this.txtPregunta = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblTipoPregunta = new System.Windows.Forms.Label();
            this.cmbDataTipoPregunta = new System.Windows.Forms.ComboBox();
            this.lblNota = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPregunta
            // 
            this.lblPregunta.AutoSize = true;
            this.lblPregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPregunta.Location = new System.Drawing.Point(12, 34);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(475, 26);
            this.lblPregunta.TabIndex = 2;
            this.lblPregunta.Text = "Ingresar la descripción de la pregunta a realizar:";
            // 
            // txtPregunta
            // 
            this.txtPregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPregunta.Location = new System.Drawing.Point(17, 75);
            this.txtPregunta.Name = "txtPregunta";
            this.txtPregunta.Size = new System.Drawing.Size(724, 32);
            this.txtPregunta.TabIndex = 5;
            this.txtPregunta.UseSystemPasswordChar = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(213, 205);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(219, 37);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(522, 205);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(219, 37);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblTipoPregunta
            // 
            this.lblTipoPregunta.AutoSize = true;
            this.lblTipoPregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoPregunta.Location = new System.Drawing.Point(12, 136);
            this.lblTipoPregunta.Name = "lblTipoPregunta";
            this.lblTipoPregunta.Size = new System.Drawing.Size(331, 26);
            this.lblTipoPregunta.TabIndex = 9;
            this.lblTipoPregunta.Text = "Ingresar el Número de Encuesta:";
            // 
            // cmbDataTipoPregunta
            // 
            this.cmbDataTipoPregunta.DropDownHeight = 200;
            this.cmbDataTipoPregunta.DropDownWidth = 250;
            this.cmbDataTipoPregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDataTipoPregunta.FormattingEnabled = true;
            this.cmbDataTipoPregunta.IntegralHeight = false;
            this.cmbDataTipoPregunta.Items.AddRange(new object[] {
            "Valor",
            "Campo Abierto"});
            this.cmbDataTipoPregunta.Location = new System.Drawing.Point(349, 136);
            this.cmbDataTipoPregunta.Name = "cmbDataTipoPregunta";
            this.cmbDataTipoPregunta.Size = new System.Drawing.Size(262, 28);
            this.cmbDataTipoPregunta.TabIndex = 10;
            this.cmbDataTipoPregunta.Text = "Selecciona un tipo de pregunta..";
            // 
            // lblNota
            // 
            this.lblNota.AutoSize = true;
            this.lblNota.Location = new System.Drawing.Point(488, 43);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(123, 13);
            this.lblNota.TabIndex = 11;
            this.lblNota.Text = "(Máximo 250 caracteres)";
            // 
            // frmAgregaPregunta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 254);
            this.Controls.Add(this.lblNota);
            this.Controls.Add(this.cmbDataTipoPregunta);
            this.Controls.Add(this.lblTipoPregunta);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtPregunta);
            this.Controls.Add(this.lblPregunta);
            this.Name = "frmAgregaPregunta";
            this.Text = "AgregaPregunta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPregunta;
        private System.Windows.Forms.TextBox txtPregunta;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblTipoPregunta;
        private System.Windows.Forms.ComboBox cmbDataTipoPregunta;
        private System.Windows.Forms.Label lblNota;
    }
}