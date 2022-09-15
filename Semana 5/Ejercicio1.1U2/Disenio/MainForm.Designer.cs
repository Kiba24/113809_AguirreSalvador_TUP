namespace Ejercicio1._1U2
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaCarreraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaAsignaturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carrerasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dsListado = new Ejercicio1._1U2.Reportes.DsListado();
            this.dsListadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsListado1 = new Ejercicio1._1U2.Reportes.DsListado();
            this.dTListadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dTListadoTableAdapter = new Ejercicio1._1U2.Reportes.DsListadoTableAdapters.DTListadoTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.LblReprotSimple = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblseparador = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsListadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsListado1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTListadoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.nuevoToolStripMenuItem,
            this.consultarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(914, 30);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(121, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaCarreraToolStripMenuItem,
            this.nuevaAsignaturaToolStripMenuItem});
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            // 
            // nuevaCarreraToolStripMenuItem
            // 
            this.nuevaCarreraToolStripMenuItem.Name = "nuevaCarreraToolStripMenuItem";
            this.nuevaCarreraToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.nuevaCarreraToolStripMenuItem.Text = "Nueva Carrera";
            this.nuevaCarreraToolStripMenuItem.Click += new System.EventHandler(this.nuevaCarreraToolStripMenuItem_Click);
            // 
            // nuevaAsignaturaToolStripMenuItem
            // 
            this.nuevaAsignaturaToolStripMenuItem.Name = "nuevaAsignaturaToolStripMenuItem";
            this.nuevaAsignaturaToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.nuevaAsignaturaToolStripMenuItem.Text = "Nueva Asignatura";
            this.nuevaAsignaturaToolStripMenuItem.Click += new System.EventHandler(this.nuevaAsignaturaToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.carrerasToolStripMenuItem});
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.consultarToolStripMenuItem.Text = "Consultar";
            // 
            // carrerasToolStripMenuItem
            // 
            this.carrerasToolStripMenuItem.Name = "carrerasToolStripMenuItem";
            this.carrerasToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.carrerasToolStripMenuItem.Text = "Carreras";
            this.carrerasToolStripMenuItem.Click += new System.EventHandler(this.carrerasToolStripMenuItem_Click);
            // 
            // dsListado
            // 
            this.dsListado.DataSetName = "DsListado";
            this.dsListado.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsListadoBindingSource
            // 
            this.dsListadoBindingSource.DataSource = this.dsListado;
            this.dsListadoBindingSource.Position = 0;
            // 
            // dsListado1
            // 
            this.dsListado1.DataSetName = "DsListado";
            this.dsListado1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dTListadoBindingSource
            // 
            this.dTListadoBindingSource.DataMember = "DTListado";
            this.dTListadoBindingSource.DataSource = this.dsListado1;
            // 
            // dTListadoTableAdapter
            // 
            this.dTListadoTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(356, 357);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 66);
            this.button2.TabIndex = 8;
            this.button2.Text = "GENERAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(356, 146);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 66);
            this.button3.TabIndex = 9;
            this.button3.Text = "GENERAR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // LblReprotSimple
            // 
            this.LblReprotSimple.AutoSize = true;
            this.LblReprotSimple.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblReprotSimple.Location = new System.Drawing.Point(147, 99);
            this.LblReprotSimple.Name = "LblReprotSimple";
            this.LblReprotSimple.Size = new System.Drawing.Size(582, 29);
            this.LblReprotSimple.TabIndex = 10;
            this.LblReprotSimple.Text = "LISTADO DE MATERIAS EMITIDAS (Rep. Simple)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(630, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "CANTIDAD DE MATERIAS TOTALES (Rep. Agrupado)";
            // 
            // lblseparador
            // 
            this.lblseparador.AutoSize = true;
            this.lblseparador.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblseparador.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblseparador.Location = new System.Drawing.Point(-43, 249);
            this.lblseparador.Name = "lblseparador";
            this.lblseparador.Size = new System.Drawing.Size(1155, 16);
            this.lblseparador.TabIndex = 12;
            this.lblseparador.Text = "_________________________________________________________________________________" +
    "________________________________________________________________________________" +
    "___";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 511);
            this.Controls.Add(this.lblseparador);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblReprotSimple);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Lista de Carreras";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsListadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsListado1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTListadoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaCarreraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaAsignaturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carrerasToolStripMenuItem;
        private System.Windows.Forms.BindingSource dsListadoBindingSource;
        private Reportes.DsListado dsListado;
        private Reportes.DsListado dsListado1;
        private System.Windows.Forms.BindingSource dTListadoBindingSource;
        private Reportes.DsListadoTableAdapters.DTListadoTableAdapter dTListadoTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label LblReprotSimple;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblseparador;
    }
}

