namespace Semana8FRONT.Disenio
{
    partial class ConsultarCarreras
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
            this.ChckDeshabilitadas = new System.Windows.Forms.CheckBox();
            this.BtnMostrarTodo = new System.Windows.Forms.Button();
            this.DataGridCarreras = new System.Windows.Forms.DataGridView();
            this.Col_IdDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_AnioCursado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Cuatrimestre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Asignatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.But_Baja = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.LblAnio = new System.Windows.Forms.Label();
            this.BtnMostrar = new System.Windows.Forms.Button();
            this.lblCarreras = new System.Windows.Forms.Label();
            this.CbCarreras = new System.Windows.Forms.ComboBox();
            this.lblDetalles = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCarreras)).BeginInit();
            this.SuspendLayout();
            // 
            // ChckDeshabilitadas
            // 
            this.ChckDeshabilitadas.AutoSize = true;
            this.ChckDeshabilitadas.Location = new System.Drawing.Point(228, 424);
            this.ChckDeshabilitadas.Name = "ChckDeshabilitadas";
            this.ChckDeshabilitadas.Size = new System.Drawing.Size(216, 20);
            this.ChckDeshabilitadas.TabIndex = 16;
            this.ChckDeshabilitadas.Text = "Mostrar detalles dados de baja";
            this.ChckDeshabilitadas.UseVisualStyleBackColor = true;
            this.ChckDeshabilitadas.CheckedChanged += new System.EventHandler(this.ChckDeshabilitadas_CheckedChanged_1);
            // 
            // BtnMostrarTodo
            // 
            this.BtnMostrarTodo.Location = new System.Drawing.Point(30, 412);
            this.BtnMostrarTodo.Name = "BtnMostrarTodo";
            this.BtnMostrarTodo.Size = new System.Drawing.Size(146, 47);
            this.BtnMostrarTodo.TabIndex = 15;
            this.BtnMostrarTodo.Text = "Mostrar Todo";
            this.BtnMostrarTodo.UseVisualStyleBackColor = true;
            this.BtnMostrarTodo.Click += new System.EventHandler(this.BtnMostrarTodo_Click);
            // 
            // DataGridCarreras
            // 
            this.DataGridCarreras.AllowUserToAddRows = false;
            this.DataGridCarreras.AllowUserToDeleteRows = false;
            this.DataGridCarreras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridCarreras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_IdDetalle,
            this.Col_AnioCursado,
            this.Col_Cuatrimestre,
            this.Col_Asignatura,
            this.But_Baja});
            this.DataGridCarreras.Location = new System.Drawing.Point(228, 154);
            this.DataGridCarreras.Name = "DataGridCarreras";
            this.DataGridCarreras.ReadOnly = true;
            this.DataGridCarreras.RowHeadersWidth = 51;
            this.DataGridCarreras.RowTemplate.Height = 24;
            this.DataGridCarreras.Size = new System.Drawing.Size(726, 264);
            this.DataGridCarreras.TabIndex = 14;
            this.DataGridCarreras.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridCarreras_CellContentClick_1);
            // 
            // Col_IdDetalle
            // 
            this.Col_IdDetalle.HeaderText = "IdCarrera";
            this.Col_IdDetalle.MinimumWidth = 6;
            this.Col_IdDetalle.Name = "Col_IdDetalle";
            this.Col_IdDetalle.ReadOnly = true;
            this.Col_IdDetalle.Visible = false;
            this.Col_IdDetalle.Width = 40;
            // 
            // Col_AnioCursado
            // 
            this.Col_AnioCursado.HeaderText = "Año Cursado";
            this.Col_AnioCursado.MinimumWidth = 6;
            this.Col_AnioCursado.Name = "Col_AnioCursado";
            this.Col_AnioCursado.ReadOnly = true;
            this.Col_AnioCursado.Width = 125;
            // 
            // Col_Cuatrimestre
            // 
            this.Col_Cuatrimestre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Col_Cuatrimestre.HeaderText = "Cuatrimestre";
            this.Col_Cuatrimestre.MinimumWidth = 6;
            this.Col_Cuatrimestre.Name = "Col_Cuatrimestre";
            this.Col_Cuatrimestre.ReadOnly = true;
            this.Col_Cuatrimestre.Width = 111;
            // 
            // Col_Asignatura
            // 
            this.Col_Asignatura.FillWeight = 80F;
            this.Col_Asignatura.HeaderText = "Materia";
            this.Col_Asignatura.MinimumWidth = 6;
            this.Col_Asignatura.Name = "Col_Asignatura";
            this.Col_Asignatura.ReadOnly = true;
            this.Col_Asignatura.Width = 90;
            // 
            // But_Baja
            // 
            this.But_Baja.HeaderText = "Acciones";
            this.But_Baja.MinimumWidth = 6;
            this.But_Baja.Name = "But_Baja";
            this.But_Baja.ReadOnly = true;
            this.But_Baja.Text = "Dar de baja";
            this.But_Baja.UseColumnTextForButtonValue = true;
            this.But_Baja.Width = 73;
            // 
            // txtAnio
            // 
            this.txtAnio.Location = new System.Drawing.Point(30, 252);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(143, 22);
            this.txtAnio.TabIndex = 13;
            // 
            // LblAnio
            // 
            this.LblAnio.AutoSize = true;
            this.LblAnio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAnio.Location = new System.Drawing.Point(25, 214);
            this.LblAnio.Name = "LblAnio";
            this.LblAnio.Size = new System.Drawing.Size(54, 25);
            this.LblAnio.TabIndex = 12;
            this.LblAnio.Text = "Año:";
            // 
            // BtnMostrar
            // 
            this.BtnMostrar.Location = new System.Drawing.Point(30, 293);
            this.BtnMostrar.Name = "BtnMostrar";
            this.BtnMostrar.Size = new System.Drawing.Size(146, 47);
            this.BtnMostrar.TabIndex = 11;
            this.BtnMostrar.Text = "Filtrar";
            this.BtnMostrar.UseVisualStyleBackColor = true;
            this.BtnMostrar.Click += new System.EventHandler(this.BtnMostrar_Click);
            // 
            // lblCarreras
            // 
            this.lblCarreras.AutoSize = true;
            this.lblCarreras.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarreras.Location = new System.Drawing.Point(390, 40);
            this.lblCarreras.Name = "lblCarreras";
            this.lblCarreras.Size = new System.Drawing.Size(91, 26);
            this.lblCarreras.TabIndex = 10;
            this.lblCarreras.Text = "Carrera:";
            this.lblCarreras.Click += new System.EventHandler(this.lblCarreras_Click);
            // 
            // CbCarreras
            // 
            this.CbCarreras.FormattingEnabled = true;
            this.CbCarreras.Location = new System.Drawing.Point(487, 42);
            this.CbCarreras.Name = "CbCarreras";
            this.CbCarreras.Size = new System.Drawing.Size(188, 24);
            this.CbCarreras.TabIndex = 17;
            this.CbCarreras.SelectedIndexChanged += new System.EventHandler(this.CbCarreras_SelectedIndexChanged);
            // 
            // lblDetalles
            // 
            this.lblDetalles.AutoSize = true;
            this.lblDetalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalles.Location = new System.Drawing.Point(223, 125);
            this.lblDetalles.Name = "lblDetalles";
            this.lblDetalles.Size = new System.Drawing.Size(124, 26);
            this.lblDetalles.TabIndex = 18;
            this.lblDetalles.Text = "DETALLES";
            // 
            // ConsultarCarreras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 532);
            this.Controls.Add(this.lblDetalles);
            this.Controls.Add(this.CbCarreras);
            this.Controls.Add(this.ChckDeshabilitadas);
            this.Controls.Add(this.BtnMostrarTodo);
            this.Controls.Add(this.DataGridCarreras);
            this.Controls.Add(this.txtAnio);
            this.Controls.Add(this.LblAnio);
            this.Controls.Add(this.BtnMostrar);
            this.Controls.Add(this.lblCarreras);
            this.Name = "ConsultarCarreras";
            this.Text = "ConsultarCarreras";
            this.Load += new System.EventHandler(this.ConsultarCarreras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCarreras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ChckDeshabilitadas;
        private System.Windows.Forms.Button BtnMostrarTodo;
        private System.Windows.Forms.DataGridView DataGridCarreras;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.Label LblAnio;
        private System.Windows.Forms.Button BtnMostrar;
        private System.Windows.Forms.Label lblCarreras;
        private System.Windows.Forms.ComboBox CbCarreras;
        private System.Windows.Forms.Label lblDetalles;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_IdDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_AnioCursado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Cuatrimestre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Asignatura;
        private System.Windows.Forms.DataGridViewButtonColumn But_Baja;
    }
}