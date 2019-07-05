namespace SistemaVeterinaria.Veterinario
{
    partial class Principal
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
            this.BotonAtras = new System.Windows.Forms.Button();
            this.TextoUsuario = new System.Windows.Forms.Label();
            this.BotonConsulta = new System.Windows.Forms.Button();
            this.BotonReceta = new System.Windows.Forms.Button();
            this.BotonVerRegistroVacunacion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BotonAtras
            // 
            this.BotonAtras.Font = new System.Drawing.Font("ABeeZee", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonAtras.Location = new System.Drawing.Point(525, 480);
            this.BotonAtras.Margin = new System.Windows.Forms.Padding(4);
            this.BotonAtras.Name = "BotonAtras";
            this.BotonAtras.Size = new System.Drawing.Size(244, 60);
            this.BotonAtras.TabIndex = 55;
            this.BotonAtras.Text = "Atras";
            this.BotonAtras.UseVisualStyleBackColor = true;
            // 
            // TextoUsuario
            // 
            this.TextoUsuario.AutoSize = true;
            this.TextoUsuario.Font = new System.Drawing.Font("ABeeZee", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoUsuario.Location = new System.Drawing.Point(12, 9);
            this.TextoUsuario.Name = "TextoUsuario";
            this.TextoUsuario.Size = new System.Drawing.Size(105, 28);
            this.TextoUsuario.TabIndex = 56;
            this.TextoUsuario.Text = "Usuario:";
            // 
            // BotonConsulta
            // 
            this.BotonConsulta.Font = new System.Drawing.Font("ABeeZee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonConsulta.Location = new System.Drawing.Point(286, 110);
            this.BotonConsulta.Name = "BotonConsulta";
            this.BotonConsulta.Size = new System.Drawing.Size(176, 95);
            this.BotonConsulta.TabIndex = 57;
            this.BotonConsulta.Text = "Consulta";
            this.BotonConsulta.UseVisualStyleBackColor = true;
            // 
            // BotonReceta
            // 
            this.BotonReceta.Font = new System.Drawing.Font("ABeeZee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonReceta.Location = new System.Drawing.Point(88, 302);
            this.BotonReceta.Name = "BotonReceta";
            this.BotonReceta.Size = new System.Drawing.Size(176, 95);
            this.BotonReceta.TabIndex = 58;
            this.BotonReceta.Text = "Receta";
            this.BotonReceta.UseVisualStyleBackColor = true;
            // 
            // BotonVerRegistroVacunacion
            // 
            this.BotonVerRegistroVacunacion.Font = new System.Drawing.Font("ABeeZee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonVerRegistroVacunacion.Location = new System.Drawing.Point(481, 302);
            this.BotonVerRegistroVacunacion.Name = "BotonVerRegistroVacunacion";
            this.BotonVerRegistroVacunacion.Size = new System.Drawing.Size(176, 95);
            this.BotonVerRegistroVacunacion.TabIndex = 59;
            this.BotonVerRegistroVacunacion.Text = "Registro Vacunación";
            this.BotonVerRegistroVacunacion.UseVisualStyleBackColor = true;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.BotonVerRegistroVacunacion);
            this.Controls.Add(this.BotonReceta);
            this.Controls.Add(this.BotonConsulta);
            this.Controls.Add(this.TextoUsuario);
            this.Controls.Add(this.BotonAtras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veterinaria Patagonia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BotonAtras;
        private System.Windows.Forms.Label TextoUsuario;
        private System.Windows.Forms.Button BotonConsulta;
        private System.Windows.Forms.Button BotonReceta;
        private System.Windows.Forms.Button BotonVerRegistroVacunacion;
    }
}