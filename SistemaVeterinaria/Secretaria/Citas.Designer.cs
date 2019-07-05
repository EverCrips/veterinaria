namespace SistemaVeterinaria.Secretaria
{
    partial class Citas
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
            this.TextoFecha = new System.Windows.Forms.Label();
            this.CajaDescripcion = new System.Windows.Forms.TextBox();
            this.CajaFecha = new System.Windows.Forms.DateTimePicker();
            this.TextoDescri = new System.Windows.Forms.Label();
            this.TextoCliente = new System.Windows.Forms.Label();
            this.CajaNombreCliente = new System.Windows.Forms.TextBox();
            this.BotonInsertarCliente = new System.Windows.Forms.Button();
            this.BotonAtras = new System.Windows.Forms.Button();
            this.BotonRegistrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(217)))), ((int)(((byte)(207)))));
            this.Titulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Titulo.Font = new System.Drawing.Font("ABeeZee", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(332, 11);
            this.Titulo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(138, 30);
            this.Titulo.TabIndex = 31;
            this.Titulo.Text = "Nueva Cita";
            // 
            // TextoFecha
            // 
            this.TextoFecha.AutoSize = true;
            this.TextoFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(217)))), ((int)(((byte)(207)))));
            this.TextoFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextoFecha.Font = new System.Drawing.Font("ABeeZee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoFecha.Location = new System.Drawing.Point(35, 156);
            this.TextoFecha.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.TextoFecha.Name = "TextoFecha";
            this.TextoFecha.Size = new System.Drawing.Size(73, 26);
            this.TextoFecha.TabIndex = 32;
            this.TextoFecha.Text = "Fecha:";
            // 
            // CajaDescripcion
            // 
            this.CajaDescripcion.BackColor = System.Drawing.Color.White;
            this.CajaDescripcion.Location = new System.Drawing.Point(17, 272);
            this.CajaDescripcion.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CajaDescripcion.MaxLength = 40;
            this.CajaDescripcion.Multiline = true;
            this.CajaDescripcion.Name = "CajaDescripcion";
            this.CajaDescripcion.Size = new System.Drawing.Size(873, 178);
            this.CajaDescripcion.TabIndex = 40;
            // 
            // CajaFecha
            // 
            this.CajaFecha.CustomFormat = "d-MMM-yyyy hh:mm:ss";
            this.CajaFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.CajaFecha.Location = new System.Drawing.Point(259, 158);
            this.CajaFecha.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CajaFecha.Name = "CajaFecha";
            this.CajaFecha.Size = new System.Drawing.Size(352, 22);
            this.CajaFecha.TabIndex = 41;
            // 
            // TextoDescri
            // 
            this.TextoDescri.AutoSize = true;
            this.TextoDescri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(217)))), ((int)(((byte)(207)))));
            this.TextoDescri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextoDescri.Font = new System.Drawing.Font("ABeeZee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoDescri.Location = new System.Drawing.Point(379, 238);
            this.TextoDescri.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.TextoDescri.Name = "TextoDescri";
            this.TextoDescri.Size = new System.Drawing.Size(118, 26);
            this.TextoDescri.TabIndex = 43;
            this.TextoDescri.Text = "Descripción";
            // 
            // TextoCliente
            // 
            this.TextoCliente.AutoSize = true;
            this.TextoCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(217)))), ((int)(((byte)(207)))));
            this.TextoCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextoCliente.Font = new System.Drawing.Font("ABeeZee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoCliente.Location = new System.Drawing.Point(35, 97);
            this.TextoCliente.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.TextoCliente.Name = "TextoCliente";
            this.TextoCliente.Size = new System.Drawing.Size(162, 26);
            this.TextoCliente.TabIndex = 44;
            this.TextoCliente.Text = "Nombre cliente:";
            // 
            // CajaNombreCliente
            // 
            this.CajaNombreCliente.Location = new System.Drawing.Point(259, 102);
            this.CajaNombreCliente.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CajaNombreCliente.Name = "CajaNombreCliente";
            this.CajaNombreCliente.ReadOnly = true;
            this.CajaNombreCliente.Size = new System.Drawing.Size(352, 22);
            this.CajaNombreCliente.TabIndex = 45;
            // 
            // BotonInsertarCliente
            // 
            this.BotonInsertarCliente.BackColor = System.Drawing.Color.Transparent;
            this.BotonInsertarCliente.BackgroundImage = global::SistemaVeterinaria.Properties.Resources.Datos_Trabajador_21;
            this.BotonInsertarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BotonInsertarCliente.FlatAppearance.BorderSize = 0;
            this.BotonInsertarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BotonInsertarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BotonInsertarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonInsertarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonInsertarCliente.Location = new System.Drawing.Point(641, 100);
            this.BotonInsertarCliente.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.BotonInsertarCliente.Name = "BotonInsertarCliente";
            this.BotonInsertarCliente.Size = new System.Drawing.Size(117, 84);
            this.BotonInsertarCliente.TabIndex = 57;
            this.BotonInsertarCliente.UseVisualStyleBackColor = false;
            this.BotonInsertarCliente.Click += new System.EventHandler(this.BotonInsertarCliente_Click);
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
            this.BotonAtras.Location = new System.Drawing.Point(17, 460);
            this.BotonAtras.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.BotonAtras.Name = "BotonAtras";
            this.BotonAtras.Size = new System.Drawing.Size(120, 89);
            this.BotonAtras.TabIndex = 55;
            this.BotonAtras.UseVisualStyleBackColor = false;
            this.BotonAtras.Click += new System.EventHandler(this.BotonAtras_Click);
            // 
            // BotonRegistrar
            // 
            this.BotonRegistrar.BackColor = System.Drawing.Color.Transparent;
            this.BotonRegistrar.BackgroundImage = global::SistemaVeterinaria.Properties.Resources.Registrar_Cita_2;
            this.BotonRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BotonRegistrar.FlatAppearance.BorderSize = 0;
            this.BotonRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BotonRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BotonRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonRegistrar.Location = new System.Drawing.Point(772, 460);
            this.BotonRegistrar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.BotonRegistrar.Name = "BotonRegistrar";
            this.BotonRegistrar.Size = new System.Drawing.Size(120, 89);
            this.BotonRegistrar.TabIndex = 54;
            this.BotonRegistrar.UseVisualStyleBackColor = false;
            this.BotonRegistrar.Click += new System.EventHandler(this.BotonRegistrar_Click);
            // 
            // Citas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaVeterinaria.Properties.Resources.Citas;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(909, 558);
            this.Controls.Add(this.BotonInsertarCliente);
            this.Controls.Add(this.BotonAtras);
            this.Controls.Add(this.BotonRegistrar);
            this.Controls.Add(this.CajaNombreCliente);
            this.Controls.Add(this.TextoCliente);
            this.Controls.Add(this.TextoDescri);
            this.Controls.Add(this.CajaFecha);
            this.Controls.Add(this.CajaDescripcion);
            this.Controls.Add(this.TextoFecha);
            this.Controls.Add(this.Titulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Citas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veterinaria Patagonia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Label TextoFecha;
        private System.Windows.Forms.TextBox CajaDescripcion;
        private System.Windows.Forms.DateTimePicker CajaFecha;
        private System.Windows.Forms.Label TextoDescri;
        private System.Windows.Forms.Label TextoCliente;
        private System.Windows.Forms.TextBox CajaNombreCliente;
        private System.Windows.Forms.Button BotonRegistrar;
        private System.Windows.Forms.Button BotonAtras;
        private System.Windows.Forms.Button BotonInsertarCliente;
    }
}