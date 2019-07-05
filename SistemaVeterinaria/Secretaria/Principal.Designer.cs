namespace SistemaVeterinaria.Secretaria
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
            this.BotonCrearCita = new System.Windows.Forms.Button();
            this.BotonCrearConsulta = new System.Windows.Forms.Button();
            this.TextoUsuario = new System.Windows.Forms.Label();
            this.BotonAtras = new System.Windows.Forms.Button();
            this.BotonVerConsultas = new System.Windows.Forms.Button();
            this.BotonVerCita = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BotonCrearCita
            // 
            this.BotonCrearCita.Font = new System.Drawing.Font("ABeeZee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonCrearCita.Location = new System.Drawing.Point(468, 98);
            this.BotonCrearCita.Name = "BotonCrearCita";
            this.BotonCrearCita.Size = new System.Drawing.Size(176, 95);
            this.BotonCrearCita.TabIndex = 1;
            this.BotonCrearCita.Text = "Nueva Cita";
            this.BotonCrearCita.UseVisualStyleBackColor = true;
            // 
            // BotonCrearConsulta
            // 
            this.BotonCrearConsulta.Font = new System.Drawing.Font("ABeeZee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonCrearConsulta.Location = new System.Drawing.Point(125, 98);
            this.BotonCrearConsulta.Name = "BotonCrearConsulta";
            this.BotonCrearConsulta.Size = new System.Drawing.Size(176, 95);
            this.BotonCrearConsulta.TabIndex = 2;
            this.BotonCrearConsulta.Text = "Nueva consulta";
            this.BotonCrearConsulta.UseVisualStyleBackColor = true;
            // 
            // TextoUsuario
            // 
            this.TextoUsuario.AutoSize = true;
            this.TextoUsuario.Font = new System.Drawing.Font("ABeeZee", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoUsuario.Location = new System.Drawing.Point(12, 9);
            this.TextoUsuario.Name = "TextoUsuario";
            this.TextoUsuario.Size = new System.Drawing.Size(105, 28);
            this.TextoUsuario.TabIndex = 3;
            this.TextoUsuario.Text = "Usuario:";
            // 
            // BotonAtras
            // 
            this.BotonAtras.Font = new System.Drawing.Font("ABeeZee", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonAtras.Location = new System.Drawing.Point(525, 445);
            this.BotonAtras.Margin = new System.Windows.Forms.Padding(4);
            this.BotonAtras.Name = "BotonAtras";
            this.BotonAtras.Size = new System.Drawing.Size(244, 60);
            this.BotonAtras.TabIndex = 55;
            this.BotonAtras.Text = "Atras";
            this.BotonAtras.UseVisualStyleBackColor = true;
            // 
            // BotonVerConsultas
            // 
            this.BotonVerConsultas.Font = new System.Drawing.Font("ABeeZee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonVerConsultas.Location = new System.Drawing.Point(125, 280);
            this.BotonVerConsultas.Name = "BotonVerConsultas";
            this.BotonVerConsultas.Size = new System.Drawing.Size(176, 95);
            this.BotonVerConsultas.TabIndex = 56;
            this.BotonVerConsultas.Text = "Nueva consulta";
            this.BotonVerConsultas.UseVisualStyleBackColor = true;
            // 
            // BotonVerCita
            // 
            this.BotonVerCita.Font = new System.Drawing.Font("ABeeZee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonVerCita.Location = new System.Drawing.Point(468, 280);
            this.BotonVerCita.Name = "BotonVerCita";
            this.BotonVerCita.Size = new System.Drawing.Size(176, 95);
            this.BotonVerCita.TabIndex = 57;
            this.BotonVerCita.Text = "Nueva Cita";
            this.BotonVerCita.UseVisualStyleBackColor = true;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 518);
            this.Controls.Add(this.BotonVerCita);
            this.Controls.Add(this.BotonVerConsultas);
            this.Controls.Add(this.BotonAtras);
            this.Controls.Add(this.TextoUsuario);
            this.Controls.Add(this.BotonCrearConsulta);
            this.Controls.Add(this.BotonCrearCita);
            this.Font = new System.Drawing.Font("ABeeZee", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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

        private System.Windows.Forms.Button BotonCrearCita;
        private System.Windows.Forms.Button BotonCrearConsulta;
        private System.Windows.Forms.Label TextoUsuario;
        private System.Windows.Forms.Button BotonAtras;
        private System.Windows.Forms.Button BotonVerConsultas;
        private System.Windows.Forms.Button BotonVerCita;
    }
}