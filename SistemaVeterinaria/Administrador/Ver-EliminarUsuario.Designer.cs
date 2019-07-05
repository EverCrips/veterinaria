namespace SistemaVeterinaria.Administrador
{
    partial class Ver_EliminarUsuario
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
            this.MostrarDatos = new System.Windows.Forms.DataGridView();
            this.TextoCodigoTrabajador = new System.Windows.Forms.Label();
            this.CajaCodigoTrabajador = new System.Windows.Forms.TextBox();
            this.BotonModificar = new System.Windows.Forms.Button();
            this.BotonAtras = new System.Windows.Forms.Button();
            this.BotonEliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MostrarDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // MostrarDatos
            // 
            this.MostrarDatos.AllowUserToAddRows = false;
            this.MostrarDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MostrarDatos.BackgroundColor = System.Drawing.Color.LightSeaGreen;
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
            this.MostrarDatos.Location = new System.Drawing.Point(17, 73);
            this.MostrarDatos.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MostrarDatos.Name = "MostrarDatos";
            this.MostrarDatos.ReadOnly = true;
            this.MostrarDatos.RowHeadersVisible = false;
            this.MostrarDatos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MostrarDatos.Size = new System.Drawing.Size(1275, 297);
            this.MostrarDatos.TabIndex = 29;
            // 
            // TextoCodigoTrabajador
            // 
            this.TextoCodigoTrabajador.AutoSize = true;
            this.TextoCodigoTrabajador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(217)))), ((int)(((byte)(207)))));
            this.TextoCodigoTrabajador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextoCodigoTrabajador.Font = new System.Drawing.Font("ABeeZee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoCodigoTrabajador.Location = new System.Drawing.Point(17, 443);
            this.TextoCodigoTrabajador.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.TextoCodigoTrabajador.Name = "TextoCodigoTrabajador";
            this.TextoCodigoTrabajador.Size = new System.Drawing.Size(196, 26);
            this.TextoCodigoTrabajador.TabIndex = 35;
            this.TextoCodigoTrabajador.Text = "Código trabajador: ";
            // 
            // CajaCodigoTrabajador
            // 
            this.CajaCodigoTrabajador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.CajaCodigoTrabajador.Location = new System.Drawing.Point(287, 448);
            this.CajaCodigoTrabajador.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CajaCodigoTrabajador.MaxLength = 10;
            this.CajaCodigoTrabajador.Name = "CajaCodigoTrabajador";
            this.CajaCodigoTrabajador.Size = new System.Drawing.Size(245, 22);
            this.CajaCodigoTrabajador.TabIndex = 36;
            // 
            // BotonModificar
            // 
            this.BotonModificar.BackColor = System.Drawing.Color.Transparent;
            this.BotonModificar.BackgroundImage = global::SistemaVeterinaria.Properties.Resources.Editar_usuario_2;
            this.BotonModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BotonModificar.FlatAppearance.BorderSize = 0;
            this.BotonModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BotonModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BotonModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonModificar.Location = new System.Drawing.Point(753, 427);
            this.BotonModificar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.BotonModificar.Name = "BotonModificar";
            this.BotonModificar.Size = new System.Drawing.Size(100, 80);
            this.BotonModificar.TabIndex = 37;
            this.BotonModificar.UseVisualStyleBackColor = false;
            this.BotonModificar.Click += new System.EventHandler(this.BotonModificar_Click);
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
            this.BotonAtras.Location = new System.Drawing.Point(1185, 448);
            this.BotonAtras.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.BotonAtras.Name = "BotonAtras";
            this.BotonAtras.Size = new System.Drawing.Size(107, 94);
            this.BotonAtras.TabIndex = 34;
            this.BotonAtras.UseVisualStyleBackColor = false;
            this.BotonAtras.Click += new System.EventHandler(this.BotonAtras_Click);
            // 
            // BotonEliminar
            // 
            this.BotonEliminar.BackColor = System.Drawing.Color.Transparent;
            this.BotonEliminar.BackgroundImage = global::SistemaVeterinaria.Properties.Resources.Eliminar_Trabajador_2;
            this.BotonEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BotonEliminar.FlatAppearance.BorderSize = 0;
            this.BotonEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BotonEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BotonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonEliminar.Location = new System.Drawing.Point(581, 427);
            this.BotonEliminar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.BotonEliminar.Name = "BotonEliminar";
            this.BotonEliminar.Size = new System.Drawing.Size(100, 80);
            this.BotonEliminar.TabIndex = 33;
            this.BotonEliminar.UseVisualStyleBackColor = false;
            this.BotonEliminar.Click += new System.EventHandler(this.BotonEliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(217)))), ((int)(((byte)(207)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("ABeeZee", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(512, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 30);
            this.label1.TabIndex = 30;
            this.label1.Text = "Actuales Trabajadores";
            // 
            // Ver_EliminarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaVeterinaria.Properties.Resources.VER_ELIMINARUSUARIO;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1309, 558);
            this.Controls.Add(this.BotonModificar);
            this.Controls.Add(this.CajaCodigoTrabajador);
            this.Controls.Add(this.TextoCodigoTrabajador);
            this.Controls.Add(this.BotonAtras);
            this.Controls.Add(this.BotonEliminar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MostrarDatos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ver_EliminarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veterinaria Patagonia";
            this.Load += new System.EventHandler(this.Ver_EliminarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MostrarDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MostrarDatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BotonEliminar;
        private System.Windows.Forms.Button BotonAtras;
        private System.Windows.Forms.Label TextoCodigoTrabajador;
        private System.Windows.Forms.TextBox CajaCodigoTrabajador;
        private System.Windows.Forms.Button BotonModificar;
    }
}