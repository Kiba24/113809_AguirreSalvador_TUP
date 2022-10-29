namespace Semana8FRONT.Disenio
{
    partial class NuevaCarrera
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
            this.lblNuevaCarrera = new System.Windows.Forms.Label();
            this.lblNombreCarrera = new System.Windows.Forms.Label();
            this.TxtNombreCarrera = new System.Windows.Forms.TextBox();
            this.BtnAgregarCarrera = new System.Windows.Forms.Button();
            this.TxtAnioCursa = new System.Windows.Forms.TextBox();
            this.lblAnioCursado = new System.Windows.Forms.Label();
            this.RbtSemestre1 = new System.Windows.Forms.RadioButton();
            this.RbtSemestre2 = new System.Windows.Forms.RadioButton();
            this.DataGridDetalles = new System.Windows.Forms.DataGridView();
            this.Col_IdDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_AnioCursado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Cuatrimestre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Asignatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.But_Baja = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnAgregarDetalle = new System.Windows.Forms.Button();
            this.LblMaterias = new System.Windows.Forms.Label();
            this.cbMaterias = new System.Windows.Forms.ComboBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.Separator = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNuevaCarrera
            // 
            this.lblNuevaCarrera.AutoSize = true;
            this.lblNuevaCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevaCarrera.Location = new System.Drawing.Point(182, 21);
            this.lblNuevaCarrera.Name = "lblNuevaCarrera";
            this.lblNuevaCarrera.Size = new System.Drawing.Size(288, 26);
            this.lblNuevaCarrera.TabIndex = 2;
            this.lblNuevaCarrera.Text = "CREAR NUEVA CARRERA";
            this.lblNuevaCarrera.Click += new System.EventHandler(this.lblCarreras_Click);
            // 
            // lblNombreCarrera
            // 
            this.lblNombreCarrera.AutoSize = true;
            this.lblNombreCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCarrera.Location = new System.Drawing.Point(116, 80);
            this.lblNombreCarrera.Name = "lblNombreCarrera";
            this.lblNombreCarrera.Size = new System.Drawing.Size(78, 20);
            this.lblNombreCarrera.TabIndex = 5;
            this.lblNombreCarrera.Text = "Nombre: ";
            // 
            // TxtNombreCarrera
            // 
            this.TxtNombreCarrera.Location = new System.Drawing.Point(209, 81);
            this.TxtNombreCarrera.Name = "TxtNombreCarrera";
            this.TxtNombreCarrera.Size = new System.Drawing.Size(194, 22);
            this.TxtNombreCarrera.TabIndex = 6;
            // 
            // BtnAgregarCarrera
            // 
            this.BtnAgregarCarrera.Location = new System.Drawing.Point(292, 597);
            this.BtnAgregarCarrera.Name = "BtnAgregarCarrera";
            this.BtnAgregarCarrera.Size = new System.Drawing.Size(133, 50);
            this.BtnAgregarCarrera.TabIndex = 7;
            this.BtnAgregarCarrera.Text = "Agregar";
            this.BtnAgregarCarrera.UseVisualStyleBackColor = true;
            this.BtnAgregarCarrera.Click += new System.EventHandler(this.BtnAgregarCarrera_Click);
            // 
            // TxtAnioCursa
            // 
            this.TxtAnioCursa.Location = new System.Drawing.Point(209, 129);
            this.TxtAnioCursa.Name = "TxtAnioCursa";
            this.TxtAnioCursa.Size = new System.Drawing.Size(194, 22);
            this.TxtAnioCursa.TabIndex = 8;
            // 
            // lblAnioCursado
            // 
            this.lblAnioCursado.AutoSize = true;
            this.lblAnioCursado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnioCursado.Location = new System.Drawing.Point(83, 129);
            this.lblAnioCursado.Name = "lblAnioCursado";
            this.lblAnioCursado.Size = new System.Drawing.Size(111, 20);
            this.lblAnioCursado.TabIndex = 9;
            this.lblAnioCursado.Text = "Año Cursado:";
            this.lblAnioCursado.Click += new System.EventHandler(this.label1_Click);
            // 
            // RbtSemestre1
            // 
            this.RbtSemestre1.AutoSize = true;
            this.RbtSemestre1.Location = new System.Drawing.Point(487, 81);
            this.RbtSemestre1.Name = "RbtSemestre1";
            this.RbtSemestre1.Size = new System.Drawing.Size(96, 20);
            this.RbtSemestre1.TabIndex = 12;
            this.RbtSemestre1.TabStop = true;
            this.RbtSemestre1.Text = "Semestre 1";
            this.RbtSemestre1.UseVisualStyleBackColor = true;
            // 
            // RbtSemestre2
            // 
            this.RbtSemestre2.AutoSize = true;
            this.RbtSemestre2.Location = new System.Drawing.Point(487, 120);
            this.RbtSemestre2.Name = "RbtSemestre2";
            this.RbtSemestre2.Size = new System.Drawing.Size(96, 20);
            this.RbtSemestre2.TabIndex = 13;
            this.RbtSemestre2.TabStop = true;
            this.RbtSemestre2.Text = "Semestre 2";
            this.RbtSemestre2.UseVisualStyleBackColor = true;
            // 
            // DataGridDetalles
            // 
            this.DataGridDetalles.AllowUserToAddRows = false;
            this.DataGridDetalles.AllowUserToDeleteRows = false;
            this.DataGridDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_IdDetalle,
            this.Col_AnioCursado,
            this.Col_Cuatrimestre,
            this.Col_Asignatura,
            this.But_Baja});
            this.DataGridDetalles.Location = new System.Drawing.Point(118, 304);
            this.DataGridDetalles.Name = "DataGridDetalles";
            this.DataGridDetalles.ReadOnly = true;
            this.DataGridDetalles.RowHeadersWidth = 51;
            this.DataGridDetalles.RowTemplate.Height = 24;
            this.DataGridDetalles.Size = new System.Drawing.Size(500, 264);
            this.DataGridDetalles.TabIndex = 15;
            this.DataGridDetalles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridCarreras_CellContentClick);
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
            // BtnAgregarDetalle
            // 
            this.BtnAgregarDetalle.Location = new System.Drawing.Point(464, 254);
            this.BtnAgregarDetalle.Name = "BtnAgregarDetalle";
            this.BtnAgregarDetalle.Size = new System.Drawing.Size(131, 24);
            this.BtnAgregarDetalle.TabIndex = 16;
            this.BtnAgregarDetalle.Text = "Agregar Detalle";
            this.BtnAgregarDetalle.UseVisualStyleBackColor = true;
            this.BtnAgregarDetalle.Click += new System.EventHandler(this.BtnAgregarDetalle_Click);
            // 
            // LblMaterias
            // 
            this.LblMaterias.AutoSize = true;
            this.LblMaterias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMaterias.Location = new System.Drawing.Point(115, 258);
            this.LblMaterias.Name = "LblMaterias";
            this.LblMaterias.Size = new System.Drawing.Size(70, 20);
            this.LblMaterias.TabIndex = 17;
            this.LblMaterias.Text = "Materia:";
            // 
            // cbMaterias
            // 
            this.cbMaterias.FormattingEnabled = true;
            this.cbMaterias.Location = new System.Drawing.Point(191, 254);
            this.cbMaterias.Name = "cbMaterias";
            this.cbMaterias.Size = new System.Drawing.Size(234, 24);
            this.cbMaterias.TabIndex = 18;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 659);
            this.splitter1.TabIndex = 19;
            this.splitter1.TabStop = false;
            // 
            // Separator
            // 
            this.Separator.AutoSize = true;
            this.Separator.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Separator.Location = new System.Drawing.Point(9, 199);
            this.Separator.Name = "Separator";
            this.Separator.Size = new System.Drawing.Size(711, 16);
            this.Separator.TabIndex = 20;
            this.Separator.Text = "---------------------------------------------------------------------------------" +
    "--------------------------------------------------------------------------------" +
    "---------------";
            this.Separator.Click += new System.EventHandler(this.Separator_Click);
            // 
            // NuevaCarrera
            // 
            this.AcceptButton = this.BtnAgregarCarrera;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 659);
            this.Controls.Add(this.Separator);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.cbMaterias);
            this.Controls.Add(this.LblMaterias);
            this.Controls.Add(this.BtnAgregarDetalle);
            this.Controls.Add(this.DataGridDetalles);
            this.Controls.Add(this.RbtSemestre2);
            this.Controls.Add(this.RbtSemestre1);
            this.Controls.Add(this.lblAnioCursado);
            this.Controls.Add(this.TxtAnioCursa);
            this.Controls.Add(this.BtnAgregarCarrera);
            this.Controls.Add(this.TxtNombreCarrera);
            this.Controls.Add(this.lblNombreCarrera);
            this.Controls.Add(this.lblNuevaCarrera);
            this.Name = "NuevaCarrera";
            this.Text = "Agregar nueva Carrera";
            this.Load += new System.EventHandler(this.NuevaCarrera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridDetalles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNuevaCarrera;
        private System.Windows.Forms.Label lblNombreCarrera;
        private System.Windows.Forms.TextBox TxtNombreCarrera;
        private System.Windows.Forms.Button BtnAgregarCarrera;
        private System.Windows.Forms.TextBox TxtAnioCursa;
        private System.Windows.Forms.Label lblAnioCursado;
        private System.Windows.Forms.RadioButton RbtSemestre1;
        private System.Windows.Forms.RadioButton RbtSemestre2;
        private System.Windows.Forms.DataGridView DataGridDetalles;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_IdDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_AnioCursado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Cuatrimestre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Asignatura;
        private System.Windows.Forms.DataGridViewButtonColumn But_Baja;
        private System.Windows.Forms.Button BtnAgregarDetalle;
        private System.Windows.Forms.Label LblMaterias;
        private System.Windows.Forms.ComboBox cbMaterias;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label Separator;
    }
}