namespace FifoLifo
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
            this.lstCOLA = new System.Windows.Forms.ListBox();
            this.btnAddCola = new System.Windows.Forms.Button();
            this.BtnElimCola = new System.Windows.Forms.Button();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.lstPila = new System.Windows.Forms.ListBox();
            this.ElimPila = new System.Windows.Forms.Button();
            this.btnAddPila = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstCOLA
            // 
            this.lstCOLA.FormattingEnabled = true;
            this.lstCOLA.ItemHeight = 16;
            this.lstCOLA.Location = new System.Drawing.Point(69, 93);
            this.lstCOLA.Name = "lstCOLA";
            this.lstCOLA.Size = new System.Drawing.Size(192, 260);
            this.lstCOLA.TabIndex = 0;
            // 
            // btnAddCola
            // 
            this.btnAddCola.Location = new System.Drawing.Point(53, 359);
            this.btnAddCola.Name = "btnAddCola";
            this.btnAddCola.Size = new System.Drawing.Size(111, 47);
            this.btnAddCola.TabIndex = 1;
            this.btnAddCola.Text = "Aniadir a la cola";
            this.btnAddCola.UseVisualStyleBackColor = true;
            this.btnAddCola.Click += new System.EventHandler(this.btnAddCola_Click);
            // 
            // BtnElimCola
            // 
            this.BtnElimCola.Location = new System.Drawing.Point(170, 359);
            this.BtnElimCola.Name = "BtnElimCola";
            this.BtnElimCola.Size = new System.Drawing.Size(112, 47);
            this.BtnElimCola.TabIndex = 2;
            this.BtnElimCola.Text = "Eliminar cola";
            this.BtnElimCola.UseVisualStyleBackColor = true;
            this.BtnElimCola.Click += new System.EventHandler(this.BtnElimCola_Click_1);
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(301, 151);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(100, 22);
            this.txtAdd.TabIndex = 3;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(321, 124);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(59, 24);
            this.lblValor.TabIndex = 4;
            this.lblValor.Text = "Valor:";
            // 
            // lstPila
            // 
            this.lstPila.FormattingEnabled = true;
            this.lstPila.ItemHeight = 16;
            this.lstPila.Location = new System.Drawing.Point(439, 93);
            this.lstPila.Name = "lstPila";
            this.lstPila.Size = new System.Drawing.Size(192, 260);
            this.lstPila.TabIndex = 5;
            // 
            // ElimPila
            // 
            this.ElimPila.Location = new System.Drawing.Point(536, 359);
            this.ElimPila.Name = "ElimPila";
            this.ElimPila.Size = new System.Drawing.Size(112, 47);
            this.ElimPila.TabIndex = 7;
            this.ElimPila.Text = "Eliminar Pila";
            this.ElimPila.UseVisualStyleBackColor = true;
            this.ElimPila.Click += new System.EventHandler(this.ElimPila_Click);
            // 
            // btnAddPila
            // 
            this.btnAddPila.Location = new System.Drawing.Point(419, 359);
            this.btnAddPila.Name = "btnAddPila";
            this.btnAddPila.Size = new System.Drawing.Size(111, 47);
            this.btnAddPila.TabIndex = 6;
            this.btnAddPila.Text = "Aniadir a la Pila";
            this.btnAddPila.UseVisualStyleBackColor = true;
            this.btnAddPila.Click += new System.EventHandler(this.btnAddPila_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 450);
            this.Controls.Add(this.ElimPila);
            this.Controls.Add(this.btnAddPila);
            this.Controls.Add(this.lstPila);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.txtAdd);
            this.Controls.Add(this.BtnElimCola);
            this.Controls.Add(this.btnAddCola);
            this.Controls.Add(this.lstCOLA);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCOLA;
        private System.Windows.Forms.Button btnAddCola;
        private System.Windows.Forms.Button BtnElimCola;
        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.ListBox lstPila;
        private System.Windows.Forms.Button ElimPila;
        private System.Windows.Forms.Button btnAddPila;
    }
}

