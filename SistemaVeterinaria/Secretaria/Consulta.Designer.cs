namespace SistemaVeterinaria.Secretaria
{
    partial class Consulta
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
            this.TextoMascota = new System.Windows.Forms.Label();
            this.CajaNombreMascota = new System.Windows.Forms.TextBox();
            this.BotonIngresarCliente = new System.Windows.Forms.Button();
            this.TextoCliente = new System.Windows.Forms.Label();
            this.CajaNombreCliente = new System.Windows.Forms.TextBox();
            this.BotonRegistrar = new System.Windows.Forms.Button();
            this.BotonAtras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(217)))), ((int)(((byte)(207)))));
            this.Titulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Titulo.Font = new System.Drawing.Font("ABeeZee", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(347, 11);
            this.Titulo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(193, 30);
            this.Titulo.TabIndex = 30;
            this.Titulo.Text = "Nueva Consulta";
            // 
            // TextoMascota
            // 
            this.TextoMascota.AutoSize = true;
            this.TextoMascota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(217)))), ((int)(((byte)(207)))));
            this.TextoMascota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextoMascota.Font = new System.Drawing.Font("ABeeZee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoMascota.Location = new System.Drawing.Point(61, 94);
            this.TextoMascota.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.TextoMascota.Name = "TextoMascota";
            this.TextoMascota.Size = new System.Drawing.Size(97, 26);
            this.TextoMascota.TabIndex = 40;
            this.TextoMascota.Text = "Mascota:";
            // 
            // CajaNombreMascota
            // 
            this.CajaNombreMascota.Location = new System.Drawing.Point(199, 98);
            this.CajaNombreMascota.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CajaNombreMascota.Name = "CajaNombreMascota";
            this.CajaNombreMascota.ReadOnly = true;
            this.CajaNombreMascota.Size = new System.Drawing.Size(352, 22);
            this.CajaNombreMascota.TabIndex = 42;
            // 
            // BotonIngresarCliente
            // 
            this.BotonIngresarCliente.BackColor = System.Drawing.Color.Transparent;
            this.BotonIngresarCliente.BackgroundImage = global::SistemaVeterinaria.Properties.Resources.Datos_Trabajador_2;
            this.BotonIngresarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BotonIngresarCliente.FlatAppearance.BorderSize = 0;
            this.BotonIngresarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BotonIngresarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BotonIngresarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonIngresarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonIngresarCliente.Location = new System.Drawing.Point(720, 81);
            this.BotonIngresarCliente.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.BotonIngresarCliente.Name = "BotonIngresarCliente";
            this.BotonIngresarCliente.Size = new System.Drawing.Size(156, 114);
            this.BotonIngresarCliente.TabIndex = 57;
            this.BotonIngresarCliente.UseVisualStyleBackColor = false;
            this.BotonIngresarCliente.Click += new System.EventHandler(this.BotonIngresarCliente_Click);
            // 
            // TextoCliente
            // 
            this.TextoCliente.AutoSize = true;
            this.TextoCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(217)))), ((int)(((byte)(207)))));
            this.TextoCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextoCliente.Font = new System.Drawing.Font("ABeeZee", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoCliente.Location = new System.Drawing.Point(61, 153);
            this.TextoCliente.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.TextoCliente.Name = "TextoCliente";
            this.TextoCliente.Size = new System.Drawing.Size(106, 32);
            this.TextoCliente.TabIndex = 58;
            this.TextoCliente.Text = "Cliente:";
            // 
            // CajaNombreCliente
            // 
            this.CajaNombreCliente.Location = new System.Drawing.Point(199, 158);
            this.CajaNombreCliente.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CajaNombreCliente.Name = "CajaNombreCliente";
            this.CajaNombreCliente.ReadOnly = true;
            this.CajaNombreCliente.Size = new System.Drawing.Size(352, 22);
            this.CajaNombreCliente.TabIndex = 59;
            // 
            // BotonRegistrar
            // 
            this.BotonRegistrar.BackColor = System.Drawing.Color.Transparent;
            this.BotonRegistrar.BackgroundImage = global::SistemaVeterinaria.Properties.Resources.Nueva_Consulta_2;
            this.BotonRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BotonRegistrar.FlatAppearance.BorderSize = 0;
            this.BotonRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BotonRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BotonRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonRegistrar.Location = new System.Drawing.Point(755, 276);
            this.BotonRegistrar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.BotonRegistrar.Name = "BotonRegistrar";
            this.BotonRegistrar.Size = new System.Drawing.Size(121, 81);
            this.BotonRegistrar.TabIndex = 60;
            this.BotonRegistrar.UseVisualStyleBackColor = false;
            this.BotonRegistrar.Click += new System.EventHandler(this.BotonRegistrar_Click);
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
            this.BotonAtras.Location = new System.Drawing.Point(16, 276);
            this.BotonAtras.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.BotonAtras.Name = "BotonAtras";
            this.BotonAtras.Size = new System.Drawing.Size(101, 81);
            this.BotonAtras.TabIndex = 61;
            this.BotonAtras.UseVisualStyleBackColor = false;
            this.BotonAtras.Click += new System.EventHandler(this.BotonAtras_Click);
            // 
            // Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaVeterinaria.Properties.Resources.Consulta;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(909, 373);
            this.Controls.Add(this.BotonAtras);
            this.Controls.Add(this.BotonRegistrar);
            this.Controls.Add(this.CajaNombreCliente);
            this.Controls.Add(this.TextoCliente);
            this.Controls.Add(this.BotonIngresarCliente);
            this.Controls.Add(this.CajaNombreMascota);
            this.Controls.Add(this.TextoMascota);
            this.Controls.Add(this.Titulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Consulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veterinaria Patagonia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Label TextoMascota;
        private System.Windows.Forms.TextBox CajaNombreMascota;
        private System.Windows.Forms.Button BotonIngresarCliente;
        private System.Windows.Forms.Label TextoCliente;
        private System.Windows.Forms.TextBox CajaNombreCliente;
        private System.Windows.Forms.Button BotonRegistrar;
        private System.Windows.Forms.Button BotonAtras;
    }
}