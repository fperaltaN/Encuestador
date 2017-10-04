namespace EncuestadorSA
{
    partial class frmPrincipal
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
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encuestaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaEncuestaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultadosEncuestaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.crearToolStripMenuItem,
            this.exportarToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(1792, 24);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "c";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.encuestaToolStripMenuItem});
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.abrirToolStripMenuItem.Text = "Abrir";
            // 
            // encuestaToolStripMenuItem
            // 
            this.encuestaToolStripMenuItem.Name = "encuestaToolStripMenuItem";
            this.encuestaToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.encuestaToolStripMenuItem.Text = "Encuesta";
            this.encuestaToolStripMenuItem.Click += new System.EventHandler(this.encuestaToolStripMenuItem_Click);
            // 
            // crearToolStripMenuItem
            // 
            this.crearToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaEncuestaToolStripMenuItem});
            this.crearToolStripMenuItem.Name = "crearToolStripMenuItem";
            this.crearToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.crearToolStripMenuItem.Text = "Crear";
            // 
            // nuevaEncuestaToolStripMenuItem
            // 
            this.nuevaEncuestaToolStripMenuItem.Name = "nuevaEncuestaToolStripMenuItem";
            this.nuevaEncuestaToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.nuevaEncuestaToolStripMenuItem.Text = "Nueva Encuesta";
            this.nuevaEncuestaToolStripMenuItem.Click += new System.EventHandler(this.nuevaEncuestaToolStripMenuItem_Click);
            // 
            // exportarToolStripMenuItem
            // 
            this.exportarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resultadosEncuestaToolStripMenuItem});
            this.exportarToolStripMenuItem.Name = "exportarToolStripMenuItem";
            this.exportarToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.exportarToolStripMenuItem.Text = "Exportar";
            // 
            // resultadosEncuestaToolStripMenuItem
            // 
            this.resultadosEncuestaToolStripMenuItem.Name = "resultadosEncuestaToolStripMenuItem";
            this.resultadosEncuestaToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.resultadosEncuestaToolStripMenuItem.Text = "Resultados Encuesta";
            this.resultadosEncuestaToolStripMenuItem.Click += new System.EventHandler(this.resultadosEncuestaToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1792, 772);
            this.Controls.Add(this.menuStripMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "frmPrincipal";
            this.Text = "Encuestador SA";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem crearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaEncuestaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encuestaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resultadosEncuestaToolStripMenuItem;
    }
}

