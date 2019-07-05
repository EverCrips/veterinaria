namespace SistemaVeterinaria.Secretaria
{
    partial class VerClientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MostrarDatos = new System.Windows.Forms.DataGridView();
            this.Titulo = new System.Windows.Forms.Label();
            this.TextoCliente = new System.Windows.Forms.Label();
            this.CajaIdCliente = new System.Windows.Forms.TextBox();
            this.TextoIdMascota = new System.Windows.Forms.Label();
            this.CajaIdMascota = new System.Windows.Forms.TextBox();
            this.BotonAñadirMascota = new System.Windows.Forms.Button();
            this.BotonNuevoCliente = new System.Windows.Forms.Button();
            this.BotonAtras = new System.Windows.Forms.Button();
            this.BotonSeleccionarCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MostrarDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // MostrarDatos
            // 
            this.MostrarDatos.AllowUserToAddRows = false;
            this.MostrarDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MostrarDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.MostrarDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MostrarDatos.DefaultCellStyle = dataGridViewCellStyle4;
            this.MostrarDatos.Location = new System.Drawing.Point(13, 62);
            this.MostrarDatos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MostrarDatos.Name = "MostrarDatos";
            this.MostrarDatos.ReadOnly = true;
            this.MostrarDatos.RowHeadersVisible = false;
            this.MostrarDatos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MostrarDatos.Size = new System.Drawing.Size(856, 206);
            this.MostrarDatos.TabIndex = 32;
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(217)))), ((int)(((byte)(207)))));
            this.Titulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Titulo.Font = new System.Drawing.Font("ABeeZee", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(323, 9);
            this.Titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(203, 30);
            this.Titulo.TabIndex = 33;
            this.Titulo.Text = "Registro Clientes";
            // 
            // TextoCliente
            // 
            this.TextoCliente.AutoSize = true;
            this.TextoCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(217)))), ((int)(((byte)(207)))));
            this.TextoCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextoCliente.Font = new System.Drawing.Font("ABeeZee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoCliente.Location = new System.Drawing.Point(13, 295);
            this.TextoCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TextoCliente.Name = "TextoCliente";
            this.TextoCliente.Size = new System.Drawing.Size(108, 26);
            this.TextoCliente.TabIndex = 45;
            this.TextoCliente.Text = "Id Cliente:";
            // 
            // CajaIdCliente
            // 
            this.CajaIdCliente.Location = new System.Drawing.Point(144, 299);
            this.CajaIdCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CajaIdCliente.Name = "CajaIdCliente";
            this.CajaIdCliente.Size = new System.Drawing.Size(265, 22);
            this.CajaIdCliente.TabIndex = 46;
            this.CajaIdCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CajaIdCliente_KeyPress);
            // 
            // TextoIdMascota
            // 
            this.TextoIdMascota.AutoSize = true;
            this.TextoIdMascota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(217)))), ((int)(((byte)(207)))));
            this.TextoIdMascota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextoIdMascota.Font = new System.Drawing.Font("ABeeZee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoIdMascota.Location = new System.Drawing.Point(13, 345);
            this.TextoIdMascota.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TextoIdMascota.Name = "TextoIdMascota";
            this.TextoIdMascota.Size = new System.Drawing.Size(121, 26);
            this.TextoIdMascota.TabIndex = 63;
            this.TextoIdMascota.Text = "Id Mascota:";
            // 
            // CajaIdMascota
            // 
            this.CajaIdMascota.Location = new System.Drawing.Point(144, 347);
            this.CajaIdMascota.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CajaIdMascota.Name = "CajaIdMascota";
            this.CajaIdMascota.Size = new System.Drawing.Size(265, 22);
            this.CajaIdMascota.TabIndex = 64;
            this.CajaIdMascota.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CajaIdMascota_KeyPress);
            // 
            // BotonAñadirMascota
            // 
            this.BotonAñadirMascota.BackColor = System.Drawing.Color.Transparent;
            this.BotonAñadirMascota.BackgroundImage = global::SistemaVeterinaria.Properties.Resources.Agregar_Mascota_2;
            this.BotonAñadirMascota.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BotonAñadirMascota.FlatAppearance.BorderSize = 0;
            this.BotonAñadirMascota.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BotonAñadirMascota.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BotonAñadirMascota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonAñadirMascota.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonAñadirMascota.Location = new System.Drawing.Point(629, 274);
            this.BotonAñadirMascota.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BotonAñadirMascota.Name = "BotonAñadirMascota";
            this.BotonAñadirMascota.Size = new System.Drawing.Size(103, 76);
            this.BotonAñadirMascota.TabIndex = 61;
            this.BotonAñadirMascota.UseVisualStyleBackColor = false;
            this.BotonAñadirMascota.Click += new System.EventHandler(this.BotonAñadirMascota_Click);
            // 
            // BotonNuevoCliente
            // 
            this.BotonNuevoCliente.BackColor = System.Drawing.Color.Transparent;
            this.BotonNuevoCliente.BackgroundImage = global::SistemaVeterinaria.Properties.Resources.Agregar_Cliente_3;
            this.BotonNuevoCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BotonNuevoCliente.FlatAppearance.BorderSize = 0;
            this.BotonNuevoCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BotonNuevoCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BotonNuevoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonNuevoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonNuevoCliente.Location = new System.Drawing.Point(776, 274);
            this.BotonNuevoCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BotonNuevoCliente.Name = "BotonNuevoCliente";
            this.BotonNuevoCliente.Size = new System.Drawing.Size(92, 76);
            this.BotonNuevoCliente.TabIndex = 59;
            this.BotonNuevoCliente.UseVisualStyleBackColor = false;
            this.BotonNuevoCliente.Click += new System.EventHandler(this.BotonNuevoCliente_Click);
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
            this.BotonAtras.Location = new System.Drawing.Point(16, 375);
            this.BotonAtras.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BotonAtras.Name = "BotonAtras";
            this.BotonAtras.Size = new System.Drawing.Size(80, 64);
            this.BotonAtras.TabIndex = 58;
            this.BotonAtras.UseVisualStyleBackColor = false;
            this.BotonAtras.Click += new System.EventHandler(this.BotonAtras_Click);
            // 
            // BotonSeleccionarCliente
            // 
            this.BotonSeleccionarCliente.BackColor = System.Drawing.Color.Transparent;
            this.BotonSeleccionarCliente.BackgroundImage = global::SistemaVeterinaria.Properties.Resources.Agregar_2;
            this.BotonSeleccionarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BotonSeleccionarCliente.FlatAppearance.BorderSize = 0;
            this.BotonSeleccionarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BotonSeleccionarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BotonSeleccionarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonSeleccionarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonSeleccionarCliente.Location = new System.Drawing.Point(419, 299);
            this.BotonSeleccionarCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BotonSeleccionarCliente.Name = "BotonSeleccionarCliente";
            this.BotonSeleccionarCliente.Size = new System.Drawing.Size(105, 70);
            this.BotonSeleccionarCliente.TabIndex = 57;
            this.BotonSeleccionarCliente.UseVisualStyleBackColor = false;
            this.BotonSeleccionarCliente.Click += new System.EventHandler(this.BotonSeleccionarCliente_Click);
            // 
            // VerClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaVeterinaria.Properties.Resources.VerCliente;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(883, 453);
            this.Controls.Add(this.CajaIdMascota);
            this.Controls.Add(this.TextoIdMascota);
            this.Controls.Add(this.BotonAñadirMascota);
            this.Controls.Add(this.BotonNuevoCliente);
            this.Controls.Add(this.BotonAtras);
            this.Controls.Add(this.BotonSeleccionarCliente);
            this.Controls.Add(this.CajaIdCliente);
            this.Controls.Add(this.TextoCliente);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.MostrarDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VerClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veterinaria Patagonia";
            this.Load += new System.EventHandler(this.VerClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MostrarDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MostrarDatos;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Label TextoCliente;
        private System.Windows.Forms.TextBox CajaIdCliente;
        private System.Windows.Forms.Button BotonSeleccionarCliente;
        private System.Windows.Forms.Button BotonAtras;
        private System.Windows.Forms.Button BotonNuevoCliente;
        private System.Windows.Forms.Button BotonAñadirMascota;
        private System.Windows.Forms.Label TextoIdMascota;
        private System.Windows.Forms.TextBox CajaIdMascota;
    }
}