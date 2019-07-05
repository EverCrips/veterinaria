namespace SistemaVeterinaria.Secretaria
{
    partial class AñadirMascota
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TextoNombreMascota = new System.Windows.Forms.Label();
            this.Titulo = new System.Windows.Forms.Label();
            this.CajaNombreMascota = new System.Windows.Forms.TextBox();
            this.TextoCliente = new System.Windows.Forms.Label();
            this.CajaIdCliente = new System.Windows.Forms.TextBox();
            this.BotonAtras = new System.Windows.Forms.Button();
            this.BotonAñadirMascotaNuevacliente = new System.Windows.Forms.Button();
            this.MostrarDatos = new System.Windows.Forms.DataGridView();
            this.TextoCategoriaMascota = new System.Windows.Forms.Label();
            this.CajaCategoriaMascota = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.MostrarDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // TextoNombreMascota
            // 
            this.TextoNombreMascota.AutoSize = true;
            this.TextoNombreMascota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(217)))), ((int)(((byte)(207)))));
            this.TextoNombreMascota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextoNombreMascota.Font = new System.Drawing.Font("ABeeZee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoNombreMascota.Location = new System.Drawing.Point(13, 347);
            this.TextoNombreMascota.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TextoNombreMascota.Name = "TextoNombreMascota";
            this.TextoNombreMascota.Size = new System.Drawing.Size(187, 26);
            this.TextoNombreMascota.TabIndex = 60;
            this.TextoNombreMascota.Text = "*Nombre Mascota:";
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(217)))), ((int)(((byte)(207)))));
            this.Titulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Titulo.Font = new System.Drawing.Font("ABeeZee", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(295, 9);
            this.Titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(278, 30);
            this.Titulo.TabIndex = 61;
            this.Titulo.Text = "Añadir Mascota Cliente";
            // 
            // CajaNombreMascota
            // 
            this.CajaNombreMascota.Location = new System.Drawing.Point(223, 350);
            this.CajaNombreMascota.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CajaNombreMascota.Name = "CajaNombreMascota";
            this.CajaNombreMascota.Size = new System.Drawing.Size(265, 22);
            this.CajaNombreMascota.TabIndex = 62;
            // 
            // TextoCliente
            // 
            this.TextoCliente.AutoSize = true;
            this.TextoCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(217)))), ((int)(((byte)(207)))));
            this.TextoCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextoCliente.Font = new System.Drawing.Font("ABeeZee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoCliente.Location = new System.Drawing.Point(13, 299);
            this.TextoCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TextoCliente.Name = "TextoCliente";
            this.TextoCliente.Size = new System.Drawing.Size(117, 26);
            this.TextoCliente.TabIndex = 63;
            this.TextoCliente.Text = "*Id Cliente:";
            // 
            // CajaIdCliente
            // 
            this.CajaIdCliente.Location = new System.Drawing.Point(223, 302);
            this.CajaIdCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CajaIdCliente.Name = "CajaIdCliente";
            this.CajaIdCliente.Size = new System.Drawing.Size(265, 22);
            this.CajaIdCliente.TabIndex = 64;
            this.CajaIdCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CajaIdCliente_KeyPress);
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
            this.BotonAtras.Location = new System.Drawing.Point(13, 459);
            this.BotonAtras.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BotonAtras.Name = "BotonAtras";
            this.BotonAtras.Size = new System.Drawing.Size(105, 81);
            this.BotonAtras.TabIndex = 65;
            this.BotonAtras.UseVisualStyleBackColor = false;
            this.BotonAtras.Click += new System.EventHandler(this.BotonAtras_Click);
            // 
            // BotonAñadirMascotaNuevacliente
            // 
            this.BotonAñadirMascotaNuevacliente.BackColor = System.Drawing.Color.Transparent;
            this.BotonAñadirMascotaNuevacliente.BackgroundImage = global::SistemaVeterinaria.Properties.Resources.Agregar_Mascota_2;
            this.BotonAñadirMascotaNuevacliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BotonAñadirMascotaNuevacliente.FlatAppearance.BorderSize = 0;
            this.BotonAñadirMascotaNuevacliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BotonAñadirMascotaNuevacliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BotonAñadirMascotaNuevacliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonAñadirMascotaNuevacliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonAñadirMascotaNuevacliente.Location = new System.Drawing.Point(744, 448);
            this.BotonAñadirMascotaNuevacliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BotonAñadirMascotaNuevacliente.Name = "BotonAñadirMascotaNuevacliente";
            this.BotonAñadirMascotaNuevacliente.Size = new System.Drawing.Size(139, 103);
            this.BotonAñadirMascotaNuevacliente.TabIndex = 66;
            this.BotonAñadirMascotaNuevacliente.UseVisualStyleBackColor = false;
            this.BotonAñadirMascotaNuevacliente.Click += new System.EventHandler(this.BotonAñadirMascotaNuevacliente_Click);
            // 
            // MostrarDatos
            // 
            this.MostrarDatos.AllowUserToAddRows = false;
            this.MostrarDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MostrarDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.MostrarDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MostrarDatos.DefaultCellStyle = dataGridViewCellStyle2;
            this.MostrarDatos.Location = new System.Drawing.Point(13, 41);
            this.MostrarDatos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MostrarDatos.Name = "MostrarDatos";
            this.MostrarDatos.ReadOnly = true;
            this.MostrarDatos.RowHeadersVisible = false;
            this.MostrarDatos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MostrarDatos.Size = new System.Drawing.Size(856, 234);
            this.MostrarDatos.TabIndex = 67;
            // 
            // TextoCategoriaMascota
            // 
            this.TextoCategoriaMascota.AutoSize = true;
            this.TextoCategoriaMascota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(217)))), ((int)(((byte)(207)))));
            this.TextoCategoriaMascota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextoCategoriaMascota.Font = new System.Drawing.Font("ABeeZee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoCategoriaMascota.Location = new System.Drawing.Point(13, 395);
            this.TextoCategoriaMascota.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TextoCategoriaMascota.Name = "TextoCategoriaMascota";
            this.TextoCategoriaMascota.Size = new System.Drawing.Size(204, 26);
            this.TextoCategoriaMascota.TabIndex = 68;
            this.TextoCategoriaMascota.Text = "*Categoria Mascota:";
            // 
            // CajaCategoriaMascota
            // 
            this.CajaCategoriaMascota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CajaCategoriaMascota.FormattingEnabled = true;
            this.CajaCategoriaMascota.Location = new System.Drawing.Point(223, 395);
            this.CajaCategoriaMascota.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CajaCategoriaMascota.Name = "CajaCategoriaMascota";
            this.CajaCategoriaMascota.Size = new System.Drawing.Size(264, 24);
            this.CajaCategoriaMascota.TabIndex = 69;
            // 
            // AñadirMascota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaVeterinaria.Properties.Resources.AñadirMascota;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(883, 553);
            this.Controls.Add(this.CajaCategoriaMascota);
            this.Controls.Add(this.TextoCategoriaMascota);
            this.Controls.Add(this.MostrarDatos);
            this.Controls.Add(this.BotonAñadirMascotaNuevacliente);
            this.Controls.Add(this.BotonAtras);
            this.Controls.Add(this.CajaIdCliente);
            this.Controls.Add(this.TextoCliente);
            this.Controls.Add(this.CajaNombreMascota);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.TextoNombreMascota);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AñadirMascota";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veterinaria Patagonia";
            this.Load += new System.EventHandler(this.AñadirMascota_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MostrarDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TextoNombreMascota;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.TextBox CajaNombreMascota;
        private System.Windows.Forms.Label TextoCliente;
        private System.Windows.Forms.TextBox CajaIdCliente;
        private System.Windows.Forms.Button BotonAtras;
        private System.Windows.Forms.Button BotonAñadirMascotaNuevacliente;
        private System.Windows.Forms.DataGridView MostrarDatos;
        private System.Windows.Forms.Label TextoCategoriaMascota;
        private System.Windows.Forms.ComboBox CajaCategoriaMascota;
    }
}