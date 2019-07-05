namespace SistemaVeterinaria.Secretaria
{
    partial class PrincipalS
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
            this.TextoUsuario = new System.Windows.Forms.Label();
            this.BotonVerCita = new System.Windows.Forms.Button();
            this.BotonVerConsultas = new System.Windows.Forms.Button();
            this.BotonAtras = new System.Windows.Forms.Button();
            this.BotonCrearConsulta = new System.Windows.Forms.Button();
            this.BotonCrearCita = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextoUsuario
            // 
            this.TextoUsuario.AutoSize = true;
            this.TextoUsuario.BackColor = System.Drawing.Color.Aqua;
            this.TextoUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextoUsuario.Font = new System.Drawing.Font("ABeeZee", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoUsuario.Location = new System.Drawing.Point(16, 11);
            this.TextoUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TextoUsuario.Name = "TextoUsuario";
            this.TextoUsuario.Size = new System.Drawing.Size(107, 30);
            this.TextoUsuario.TabIndex = 3;
            this.TextoUsuario.Text = "Usuario:";
            // 
            // BotonVerCita
            // 
            this.BotonVerCita.BackColor = System.Drawing.Color.Transparent;
            this.BotonVerCita.BackgroundImage = global::SistemaVeterinaria.Properties.Resources.Ver_Citas_2;
            this.BotonVerCita.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BotonVerCita.FlatAppearance.BorderSize = 0;
            this.BotonVerCita.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BotonVerCita.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BotonVerCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonVerCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonVerCita.Location = new System.Drawing.Point(859, 352);
            this.BotonVerCita.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BotonVerCita.Name = "BotonVerCita";
            this.BotonVerCita.Size = new System.Drawing.Size(168, 151);
            this.BotonVerCita.TabIndex = 57;
            this.BotonVerCita.UseVisualStyleBackColor = false;
            this.BotonVerCita.Click += new System.EventHandler(this.BotonVerCita_Click);
            // 
            // BotonVerConsultas
            // 
            this.BotonVerConsultas.BackColor = System.Drawing.Color.Transparent;
            this.BotonVerConsultas.BackgroundImage = global::SistemaVeterinaria.Properties.Resources.Datos_Trabajador_2;
            this.BotonVerConsultas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BotonVerConsultas.FlatAppearance.BorderSize = 0;
            this.BotonVerConsultas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BotonVerConsultas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BotonVerConsultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonVerConsultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonVerConsultas.Location = new System.Drawing.Point(21, 352);
            this.BotonVerConsultas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BotonVerConsultas.Name = "BotonVerConsultas";
            this.BotonVerConsultas.Size = new System.Drawing.Size(160, 151);
            this.BotonVerConsultas.TabIndex = 56;
            this.BotonVerConsultas.UseVisualStyleBackColor = false;
            this.BotonVerConsultas.Click += new System.EventHandler(this.BotonVerConsultas_Click);
            // 
            // BotonAtras
            // 
            this.BotonAtras.BackColor = System.Drawing.Color.Transparent;
            this.BotonAtras.BackgroundImage = global::SistemaVeterinaria.Properties.Resources.Cerrar_Session_2;
            this.BotonAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BotonAtras.FlatAppearance.BorderSize = 0;
            this.BotonAtras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BotonAtras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BotonAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonAtras.Location = new System.Drawing.Point(931, 540);
            this.BotonAtras.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.BotonAtras.Name = "BotonAtras";
            this.BotonAtras.Size = new System.Drawing.Size(96, 81);
            this.BotonAtras.TabIndex = 55;
            this.BotonAtras.UseVisualStyleBackColor = false;
            this.BotonAtras.Click += new System.EventHandler(this.BotonAtras_Click);
            // 
            // BotonCrearConsulta
            // 
            this.BotonCrearConsulta.BackColor = System.Drawing.Color.Transparent;
            this.BotonCrearConsulta.BackgroundImage = global::SistemaVeterinaria.Properties.Resources.Nueva_Consulta_2;
            this.BotonCrearConsulta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BotonCrearConsulta.FlatAppearance.BorderSize = 0;
            this.BotonCrearConsulta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BotonCrearConsulta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BotonCrearConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonCrearConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonCrearConsulta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BotonCrearConsulta.Location = new System.Drawing.Point(21, 95);
            this.BotonCrearConsulta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BotonCrearConsulta.Name = "BotonCrearConsulta";
            this.BotonCrearConsulta.Size = new System.Drawing.Size(160, 143);
            this.BotonCrearConsulta.TabIndex = 2;
            this.BotonCrearConsulta.UseVisualStyleBackColor = false;
            this.BotonCrearConsulta.Click += new System.EventHandler(this.BotonCrearConsulta_Click);
            // 
            // BotonCrearCita
            // 
            this.BotonCrearCita.BackColor = System.Drawing.Color.Transparent;
            this.BotonCrearCita.BackgroundImage = global::SistemaVeterinaria.Properties.Resources.Agendar_Cita_2;
            this.BotonCrearCita.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BotonCrearCita.Cursor = System.Windows.Forms.Cursors.Default;
            this.BotonCrearCita.FlatAppearance.BorderSize = 0;
            this.BotonCrearCita.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BotonCrearCita.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BotonCrearCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonCrearCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonCrearCita.Location = new System.Drawing.Point(859, 95);
            this.BotonCrearCita.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BotonCrearCita.Name = "BotonCrearCita";
            this.BotonCrearCita.Size = new System.Drawing.Size(168, 143);
            this.BotonCrearCita.TabIndex = 1;
            this.BotonCrearCita.UseVisualStyleBackColor = false;
            this.BotonCrearCita.Click += new System.EventHandler(this.BotonCrearCita_Click);
            // 
            // PrincipalS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaVeterinaria.Properties.Resources.PRINCIPAL_SECRETARIA;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1043, 638);
            this.Controls.Add(this.BotonVerCita);
            this.Controls.Add(this.BotonVerConsultas);
            this.Controls.Add(this.BotonAtras);
            this.Controls.Add(this.TextoUsuario);
            this.Controls.Add(this.BotonCrearConsulta);
            this.Controls.Add(this.BotonCrearCita);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PrincipalS";
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