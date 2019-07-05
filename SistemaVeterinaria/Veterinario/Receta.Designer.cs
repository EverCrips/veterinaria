namespace SistemaVeterinaria.Veterinario
{
    partial class Receta
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
            this.Titulo = new System.Windows.Forms.Label();
            this.TextoDescripcionReceta = new System.Windows.Forms.Label();
            this.CajaDescripcionReceta = new System.Windows.Forms.TextBox();
            this.TextoNombreMascota = new System.Windows.Forms.Label();
            this.TextoIdMascota = new System.Windows.Forms.Label();
            this.CajaNombreMascota = new System.Windows.Forms.TextBox();
            this.CajaIdMascota = new System.Windows.Forms.TextBox();
            this.BotonImprimir = new System.Windows.Forms.Button();
            this.BotonCrearReceta = new System.Windows.Forms.Button();
            this.BotonAtras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(217)))), ((int)(((byte)(207)))));
            this.Titulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Titulo.Font = new System.Drawing.Font("ABeeZee", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(223, 9);
            this.Titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(91, 30);
            this.Titulo.TabIndex = 33;
            this.Titulo.Text = "Receta";
            // 
            // TextoDescripcionReceta
            // 
            this.TextoDescripcionReceta.AutoSize = true;
            this.TextoDescripcionReceta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(217)))), ((int)(((byte)(207)))));
            this.TextoDescripcionReceta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextoDescripcionReceta.Font = new System.Drawing.Font("ABeeZee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoDescripcionReceta.Location = new System.Drawing.Point(212, 167);
            this.TextoDescripcionReceta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TextoDescripcionReceta.Name = "TextoDescripcionReceta";
            this.TextoDescripcionReceta.Size = new System.Drawing.Size(118, 26);
            this.TextoDescripcionReceta.TabIndex = 46;
            this.TextoDescripcionReceta.Text = "Descripción";
            // 
            // CajaDescripcionReceta
            // 
            this.CajaDescripcionReceta.Location = new System.Drawing.Point(13, 196);
            this.CajaDescripcionReceta.Margin = new System.Windows.Forms.Padding(4);
            this.CajaDescripcionReceta.MaxLength = 200;
            this.CajaDescripcionReceta.Multiline = true;
            this.CajaDescripcionReceta.Name = "CajaDescripcionReceta";
            this.CajaDescripcionReceta.Size = new System.Drawing.Size(556, 121);
            this.CajaDescripcionReceta.TabIndex = 47;
            // 
            // TextoNombreMascota
            // 
            this.TextoNombreMascota.AutoSize = true;
            this.TextoNombreMascota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(217)))), ((int)(((byte)(207)))));
            this.TextoNombreMascota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextoNombreMascota.Font = new System.Drawing.Font("ABeeZee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoNombreMascota.Location = new System.Drawing.Point(32, 57);
            this.TextoNombreMascota.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TextoNombreMascota.Name = "TextoNombreMascota";
            this.TextoNombreMascota.Size = new System.Drawing.Size(178, 26);
            this.TextoNombreMascota.TabIndex = 48;
            this.TextoNombreMascota.Text = "Nombre Mascota:";
            // 
            // TextoIdMascota
            // 
            this.TextoIdMascota.AutoSize = true;
            this.TextoIdMascota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(217)))), ((int)(((byte)(207)))));
            this.TextoIdMascota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextoIdMascota.Font = new System.Drawing.Font("ABeeZee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoIdMascota.Location = new System.Drawing.Point(32, 103);
            this.TextoIdMascota.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TextoIdMascota.Name = "TextoIdMascota";
            this.TextoIdMascota.Size = new System.Drawing.Size(121, 26);
            this.TextoIdMascota.TabIndex = 61;
            this.TextoIdMascota.Text = "Id Mascota:";
            // 
            // CajaNombreMascota
            // 
            this.CajaNombreMascota.Location = new System.Drawing.Point(216, 59);
            this.CajaNombreMascota.Margin = new System.Windows.Forms.Padding(4);
            this.CajaNombreMascota.Name = "CajaNombreMascota";
            this.CajaNombreMascota.ReadOnly = true;
            this.CajaNombreMascota.Size = new System.Drawing.Size(265, 22);
            this.CajaNombreMascota.TabIndex = 62;
            // 
            // CajaIdMascota
            // 
            this.CajaIdMascota.Location = new System.Drawing.Point(216, 107);
            this.CajaIdMascota.Margin = new System.Windows.Forms.Padding(4);
            this.CajaIdMascota.Name = "CajaIdMascota";
            this.CajaIdMascota.ReadOnly = true;
            this.CajaIdMascota.Size = new System.Drawing.Size(265, 22);
            this.CajaIdMascota.TabIndex = 63;
            // 
            // BotonImprimir
            // 
            this.BotonImprimir.BackColor = System.Drawing.Color.Transparent;
            this.BotonImprimir.BackgroundImage = global::SistemaVeterinaria.Properties.Resources.Imprimir_2;
            this.BotonImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BotonImprimir.FlatAppearance.BorderSize = 0;
            this.BotonImprimir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BotonImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BotonImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonImprimir.Location = new System.Drawing.Point(387, 325);
            this.BotonImprimir.Margin = new System.Windows.Forms.Padding(4);
            this.BotonImprimir.Name = "BotonImprimir";
            this.BotonImprimir.Size = new System.Drawing.Size(80, 63);
            this.BotonImprimir.TabIndex = 64;
            this.BotonImprimir.UseVisualStyleBackColor = false;
            this.BotonImprimir.Click += new System.EventHandler(this.BotonImprimir_Click);
            // 
            // BotonCrearReceta
            // 
            this.BotonCrearReceta.BackColor = System.Drawing.Color.Transparent;
            this.BotonCrearReceta.BackgroundImage = global::SistemaVeterinaria.Properties.Resources.Receta_2;
            this.BotonCrearReceta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BotonCrearReceta.FlatAppearance.BorderSize = 0;
            this.BotonCrearReceta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BotonCrearReceta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BotonCrearReceta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonCrearReceta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonCrearReceta.Location = new System.Drawing.Point(492, 325);
            this.BotonCrearReceta.Margin = new System.Windows.Forms.Padding(4);
            this.BotonCrearReceta.Name = "BotonCrearReceta";
            this.BotonCrearReceta.Size = new System.Drawing.Size(79, 63);
            this.BotonCrearReceta.TabIndex = 60;
            this.BotonCrearReceta.UseVisualStyleBackColor = false;
            this.BotonCrearReceta.Click += new System.EventHandler(this.BotonCrearReceta_Click);
            // 
            // BotonAtras
            // 
            this.BotonAtras.BackColor = System.Drawing.Color.Transparent;
            this.BotonAtras.BackgroundImage = global::SistemaVeterinaria.Properties.Resources.Volver_2;
            this.BotonAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BotonAtras.FlatAppearance.BorderSize = 0;
            this.BotonAtras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BotonAtras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BotonAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonAtras.Location = new System.Drawing.Point(16, 325);
            this.BotonAtras.Margin = new System.Windows.Forms.Padding(4);
            this.BotonAtras.Name = "BotonAtras";
            this.BotonAtras.Size = new System.Drawing.Size(76, 63);
            this.BotonAtras.TabIndex = 59;
            this.BotonAtras.UseVisualStyleBackColor = false;
            this.BotonAtras.Click += new System.EventHandler(this.BotonAtras_Click);
            // 
            // Receta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaVeterinaria.Properties.Resources.Receta;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(581, 402);
            this.Controls.Add(this.BotonImprimir);
            this.Controls.Add(this.CajaIdMascota);
            this.Controls.Add(this.CajaNombreMascota);
            this.Controls.Add(this.TextoIdMascota);
            this.Controls.Add(this.BotonCrearReceta);
            this.Controls.Add(this.BotonAtras);
            this.Controls.Add(this.TextoNombreMascota);
            this.Controls.Add(this.CajaDescripcionReceta);
            this.Controls.Add(this.TextoDescripcionReceta);
            this.Controls.Add(this.Titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Receta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veterinaria Patagonia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Label TextoDescripcionReceta;
        private System.Windows.Forms.TextBox CajaDescripcionReceta;
        private System.Windows.Forms.Label TextoNombreMascota;
        private System.Windows.Forms.Button BotonAtras;
        private System.Windows.Forms.Button BotonCrearReceta;
        private System.Windows.Forms.Label TextoIdMascota;
        private System.Windows.Forms.TextBox CajaIdMascota;
        private System.Windows.Forms.TextBox CajaNombreMascota;
        private System.Windows.Forms.Button BotonImprimir;
    }
}