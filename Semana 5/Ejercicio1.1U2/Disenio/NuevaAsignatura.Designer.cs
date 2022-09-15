namespace Ejercicio1._1U2.Disenio
{
    partial class NuevaAsignatura
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
            this.LblNuevaAsign = new System.Windows.Forms.Label();
            this.LblNombreAsign = new System.Windows.Forms.Label();
            this.BtnAgregarAsign = new System.Windows.Forms.Button();
            this.TextMateria = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblNuevaAsign
            // 
            this.LblNuevaAsign.AutoSize = true;
            this.LblNuevaAsign.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNuevaAsign.Location = new System.Drawing.Point(66, 54);
            this.LblNuevaAsign.Name = "LblNuevaAsign";
            this.LblNuevaAsign.Size = new System.Drawing.Size(322, 26);
            this.LblNuevaAsign.TabIndex = 4;
            this.LblNuevaAsign.Text = "CREAR NUEVA ASIGNATURA";
            // 
            // LblNombreAsign
            // 
            this.LblNombreAsign.AutoSize = true;
            this.LblNombreAsign.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreAsign.Location = new System.Drawing.Point(86, 159);
            this.LblNombreAsign.Name = "LblNombreAsign";
            this.LblNombreAsign.Size = new System.Drawing.Size(73, 20);
            this.LblNombreAsign.TabIndex = 15;
            this.LblNombreAsign.Text = "Nombre:";
            // 
            // BtnAgregarAsign
            // 
            this.BtnAgregarAsign.Location = new System.Drawing.Point(168, 244);
            this.BtnAgregarAsign.Name = "BtnAgregarAsign";
            this.BtnAgregarAsign.Size = new System.Drawing.Size(133, 50);
            this.BtnAgregarAsign.TabIndex = 14;
            this.BtnAgregarAsign.Text = "Agregar";
            this.BtnAgregarAsign.UseVisualStyleBackColor = true;
            this.BtnAgregarAsign.Click += new System.EventHandler(this.BtnAgregarAsign_Click);
            // 
            // TextMateria
            // 
            this.TextMateria.Location = new System.Drawing.Point(179, 159);
            this.TextMateria.Name = "TextMateria";
            this.TextMateria.Size = new System.Drawing.Size(194, 22);
            this.TextMateria.TabIndex = 13;
            // 
            // NuevaAsignatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 358);
            this.Controls.Add(this.LblNombreAsign);
            this.Controls.Add(this.BtnAgregarAsign);
            this.Controls.Add(this.TextMateria);
            this.Controls.Add(this.LblNuevaAsign);
            this.Name = "NuevaAsignatura";
            this.Text = "NuevaAsignatura";
            this.Load += new System.EventHandler(this.NuevaAsignatura_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNuevaAsign;
        private System.Windows.Forms.Label LblNombreAsign;
        private System.Windows.Forms.Button BtnAgregarAsign;
        private System.Windows.Forms.TextBox TextMateria;
    }
}