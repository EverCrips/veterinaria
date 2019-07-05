namespace SistemaVeterinaria.Veterinario
{
    partial class PrincipalV
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
            this.BotonConsulta = new System.Windows.Forms.Button();
            this.BotonVerRegistroVacunacion = new System.Windows.Forms.Button();
            this.BotonReceta = new System.Windows.Forms.Button();
            this.BotonAtras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextoUsuario
            // 
            this.TextoUsuario.AutoSize = true;
            this.TextoUsuario.BackColor = System.Drawing.Color.Aqua;
            this.TextoUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextoUsuario.Font = new System.Drawing.Font("ABeeZee", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoUsuario.Location = new System.Drawing.Point(12, 9);
            this.TextoUsuario.Name = "TextoUsuario";
            this.TextoUsuario.Size = new System.Drawing.Size(107, 30);
            this.TextoUsuario.TabIndex = 56;
            this.TextoUsuario.Text = "Usuario:";
            // 
            // BotonConsulta
            // 
            this.BotonConsulta.BackColor = System.Drawing.Color.Transparent;
            this.BotonConsulta.BackgroundImage = global::SistemaVeterinaria.Properties.Resources.Nueva_Consulta_2;
            this.BotonConsulta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BotonConsulta.FlatAppearance.BorderSize = 0;
            this.BotonConsulta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BotonConsulta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BotonConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonConsulta.Location = new System.Drawing.Point(309, 50);
            this.BotonConsulta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BotonConsulta.Name = "BotonConsulta";
            this.BotonConsulta.Size = new System.Drawing.Size(176, 149);
            this.BotonConsulta.TabIndex = 57;
            this.BotonConsulta.UseVisualStyleBackColor = false;
            this.BotonConsulta.Click += new System.EventHandler(this.BotonConsulta_Click);
            // 
            // BotonVerRegistroVacunacion
            // 
            this.BotonVerRegistroVacunacion.BackColor = System.Drawing.Color.Transparent;
            this.BotonVerRegistroVacunacion.BackgroundImage = global::SistemaVeterinaria.Properties.Resources.Registro_Vacunas;
            this.BotonVerRegistroVacunacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BotonVerRegistroVacunacion.FlatAppearance.BorderSize = 0;
            this.BotonVerRegistroVacunacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BotonVerRegistroVacunacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BotonVerRegistroVacunacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonVerRegistroVacunacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonVerRegistroVacunacion.Location = new System.Drawing.Point(483, 274);
            this.BotonVerRegistroVacunacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BotonVerRegistroVacunacion.Name = "BotonVerRegistroVacunacion";
            this.BotonVerRegistroVacunacion.Size = new System.Drawing.Size(176, 149);
            this.BotonVerRegistroVacunacion.TabIndex = 59;
            this.BotonVerRegistroVacunacion.UseVisualStyleBackColor = false;
            this.BotonVerRegistroVacunacion.Click += new System.EventHandler(this.BotonVerRegistroVacunacion_Click);
            // 
            // BotonReceta
            // 
            this.BotonReceta.BackColor = System.Drawing.Color.Transparent;
            this.BotonReceta.BackgroundImage = global::SistemaVeterinaria.Properties.Resources.Receta_2;
            this.BotonReceta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BotonReceta.FlatAppearance.BorderSize = 0;
            this.BotonReceta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BotonReceta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BotonReceta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonReceta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonReceta.Location = new System.Drawing.Point(103, 274);
            this.BotonReceta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BotonReceta.Name = "BotonReceta";
            this.BotonReceta.Size = new System.Drawing.Size(173, 149);
            this.BotonReceta.TabIndex = 58;
            this.BotonReceta.UseVisualStyleBackColor = false;
            this.BotonReceta.Click += new System.EventHandler(this.BotonReceta_Click);
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
            this.BotonAtras.Location = new System.Drawing.Point(647, 442);
            this.BotonAtras.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BotonAtras.Name = "BotonAtras";
            this.BotonAtras.Size = new System.Drawing.Size(119, 96);
            this.BotonAtras.TabIndex = 55;
            this.BotonAtras.UseVisualStyleBackColor = false;
            this.BotonAtras.Click += new System.EventHandler(this.BotonAtras_Click);
            // 
            // PrincipalV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaVeterinaria.Properties.Resources.PrincipalV;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(781, 553);
            this.Controls.Add(this.BotonVerRegistroVacunacion);
            this.Controls.Add(this.BotonReceta);
            this.Controls.Add(this.BotonConsulta);
            this.Controls.Add(this.TextoUsuario);
            this.Controls.Add(this.BotonAtras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PrincipalV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veterinaria Patagonia";
            this.Load += new System.EventHandler(this.PrincipalV_Load);
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