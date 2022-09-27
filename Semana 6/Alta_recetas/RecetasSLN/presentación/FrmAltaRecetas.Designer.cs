namespace RecetasSLN.presentación
{
    partial class FrmAltaRecetas
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtChef = new System.Windows.Forms.TextBox();
            this.CbIngrediente = new System.Windows.Forms.ComboBox();
            this.cbReceta = new System.Windows.Forms.ComboBox();
            this.NumCantidad = new System.Windows.Forms.NumericUpDown();
            this.dgvIngredientes = new System.Windows.Forms.DataGridView();
            this.Col_Ingrediente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblChef = new System.Windows.Forms.Label();
            this.lblTipoRec = new System.Windows.Forms.Label();
            this.lblReceta = new System.Windows.Forms.Label();
            this.lblTotalIng = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredientes)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(177, 107);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(331, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // txtChef
            // 
            this.txtChef.Location = new System.Drawing.Point(177, 135);
            this.txtChef.Name = "txtChef";
            this.txtChef.Size = new System.Drawing.Size(331, 22);
            this.txtChef.TabIndex = 2;
            // 
            // CbIngrediente
            // 
            this.CbIngrediente.FormattingEnabled = true;
            this.CbIngrediente.Location = new System.Drawing.Point(42, 242);
            this.CbIngrediente.Name = "CbIngrediente";
            this.CbIngrediente.Size = new System.Drawing.Size(211, 24);
            this.CbIngrediente.TabIndex = 4;
            // 
            // cbReceta
            // 
            this.cbReceta.FormattingEnabled = true;
            this.cbReceta.Location = new System.Drawing.Point(177, 163);
            this.cbReceta.Name = "cbReceta";
            this.cbReceta.Size = new System.Drawing.Size(193, 24);
            this.cbReceta.TabIndex = 3;
            // 
            // NumCantidad
            // 
            this.NumCantidad.Location = new System.Drawing.Point(259, 242);
            this.NumCantidad.Name = "NumCantidad";
            this.NumCantidad.Size = new System.Drawing.Size(237, 22);
            this.NumCantidad.TabIndex = 5;
            // 
            // dgvIngredientes
            // 
            this.dgvIngredientes.AllowUserToAddRows = false;
            this.dgvIngredientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIngredientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_Ingrediente,
            this.Col_Cantidad});
            this.dgvIngredientes.Location = new System.Drawing.Point(31, 272);
            this.dgvIngredientes.Name = "dgvIngredientes";
            this.dgvIngredientes.RowHeadersWidth = 51;
            this.dgvIngredientes.RowTemplate.Height = 24;
            this.dgvIngredientes.Size = new System.Drawing.Size(588, 150);
            this.dgvIngredientes.TabIndex = 7;
            // 
            // Col_Ingrediente
            // 
            this.Col_Ingrediente.HeaderText = "Ingrediente";
            this.Col_Ingrediente.MinimumWidth = 6;
            this.Col_Ingrediente.Name = "Col_Ingrediente";
            this.Col_Ingrediente.Width = 125;
            // 
            // Col_Cantidad
            // 
            this.Col_Cantidad.HeaderText = "Cantidad";
            this.Col_Cantidad.MinimumWidth = 6;
            this.Col_Cantidad.Name = "Col_Cantidad";
            this.Col_Cantidad.Width = 125;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(217, 481);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(92, 31);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(315, 481);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(92, 31);
            this.BtnCancelar.TabIndex = 9;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(502, 240);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(102, 24);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(112, 107);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 16);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblChef
            // 
            this.lblChef.AutoSize = true;
            this.lblChef.Location = new System.Drawing.Point(134, 138);
            this.lblChef.Name = "lblChef";
            this.lblChef.Size = new System.Drawing.Size(37, 16);
            this.lblChef.TabIndex = 0;
            this.lblChef.Text = "Chef:";
            // 
            // lblTipoRec
            // 
            this.lblTipoRec.AutoSize = true;
            this.lblTipoRec.Location = new System.Drawing.Point(67, 166);
            this.lblTipoRec.Name = "lblTipoRec";
            this.lblTipoRec.Size = new System.Drawing.Size(104, 16);
            this.lblTipoRec.TabIndex = 0;
            this.lblTipoRec.Text = "Tipo de Receta:";
            // 
            // lblReceta
            // 
            this.lblReceta.AutoSize = true;
            this.lblReceta.Font = new System.Drawing.Font("Lucida Sans Unicode", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceta.Location = new System.Drawing.Point(191, 27);
            this.lblReceta.Name = "lblReceta";
            this.lblReceta.Size = new System.Drawing.Size(31, 31);
            this.lblReceta.TabIndex = 0;
            this.lblReceta.Text = "0";
            this.lblReceta.Click += new System.EventHandler(this.lblReceta_Click);
            // 
            // lblTotalIng
            // 
            this.lblTotalIng.AutoSize = true;
            this.lblTotalIng.Location = new System.Drawing.Point(590, 425);
            this.lblTotalIng.Name = "lblTotalIng";
            this.lblTotalIng.Size = new System.Drawing.Size(14, 16);
            this.lblTotalIng.TabIndex = 0;
            this.lblTotalIng.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(447, 425);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total de Ingredientes:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 31);
            this.label2.TabIndex = 10;
            this.label2.Text = "RECETA #:";
            // 
            // FrmAltaRecetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 520);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTotalIng);
            this.Controls.Add(this.lblReceta);
            this.Controls.Add(this.lblTipoRec);
            this.Controls.Add(this.lblChef);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dgvIngredientes);
            this.Controls.Add(this.NumCantidad);
            this.Controls.Add(this.cbReceta);
            this.Controls.Add(this.CbIngrediente);
            this.Controls.Add(this.txtChef);
            this.Controls.Add(this.txtNombre);
            this.Name = "FrmAltaRecetas";
            this.Text = "E";
            this.Load += new System.EventHandler(this.FrmAltaRecetas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtChef;
        private System.Windows.Forms.ComboBox CbIngrediente;
        private System.Windows.Forms.ComboBox cbReceta;
        private System.Windows.Forms.NumericUpDown NumCantidad;
        private System.Windows.Forms.DataGridView dgvIngredientes;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblChef;
        private System.Windows.Forms.Label lblTipoRec;
        private System.Windows.Forms.Label lblReceta;
        private System.Windows.Forms.Label lblTotalIng;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Ingrediente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Cantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}