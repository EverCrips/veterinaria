namespace SistemaVeterinaria.Secretaria
{
    partial class VerCitas
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
            this.Titulo = new System.Windows.Forms.Label();
            this.CajaVerCitas = new System.Windows.Forms.ComboBox();
            this.TextoCitas = new System.Windows.Forms.Label();
            this.TextoCambiar = new System.Windows.Forms.Label();
            this.CajaCambiarEstadoCita = new System.Windows.Forms.TextBox();
            this.BotonCambiar = new System.Windows.Forms.Button();
            this.BotonAtras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MostrarDatos)).BeginInit();
            this.SuspendLayout();
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
            this.MostrarDatos.Location = new System.Drawing.Point(13, 76);
            this.MostrarDatos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MostrarDatos.Name = "MostrarDatos";
            this.MostrarDatos.ReadOnly = true;
            this.MostrarDatos.RowHeadersVisible = false;
            this.MostrarDatos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MostrarDatos.Size = new System.Drawing.Size(1156, 350);
            this.MostrarDatos.TabIndex = 31;
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(217)))), ((int)(((byte)(207)))));
            this.Titulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Titulo.Font = new System.Drawing.Font("ABeeZee", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(464, 9);
            this.Titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(205, 30);
            this.Titulo.TabIndex = 32;
            this.Titulo.Text = "Registro de Citas";
            // 
            // CajaVerCitas
            // 
            this.CajaVerCitas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CajaVerCitas.FormattingEnabled = true;
            this.CajaVerCitas.Location = new System.Drawing.Point(128, 433);
            this.CajaVerCitas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CajaVerCitas.Name = "CajaVerCitas";
            this.CajaVerCitas.Size = new System.Drawing.Size(172, 24);
            this.CajaVerCitas.TabIndex = 66;
            this.CajaVerCitas.SelectedIndexChanged += new System.EventHandler(this.CajaVerCitas_SelectedIndexChanged);
            // 
            // TextoCitas
            // 
            this.TextoCitas.AutoSize = true;
            this.TextoCitas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(217)))), ((int)(((byte)(207)))));
            this.TextoCitas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextoCitas.Font = new System.Drawing.Font("ABeeZee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoCitas.Location = new System.Drawing.Point(13, 430);
            this.TextoCitas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TextoCitas.Name = "TextoCitas";
            this.TextoCitas.Size = new System.Drawing.Size(102, 26);
            this.TextoCitas.TabIndex = 67;
            this.TextoCitas.Text = "Ver Citas:";
            // 
            // TextoCambiar
            // 
            this.TextoCambiar.AutoSize = true;
            this.TextoCambiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(217)))), ((int)(((byte)(207)))));
            this.TextoCambiar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextoCambiar.Font = new System.Drawing.Font("ABeeZee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoCambiar.Location = new System.Drawing.Point(319, 430);
            this.TextoCambiar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TextoCambiar.Name = "TextoCambiar";
            this.TextoCambiar.Size = new System.Drawing.Size(279, 26);
            this.TextoCambiar.TabIndex = 68;
            this.TextoCambiar.Text = "Cambiar estado a realizado:";
            // 
            // CajaCambiarEstadoCita
            // 
            this.CajaCambiarEstadoCita.Location = new System.Drawing.Point(604, 430);
            this.CajaCambiarEstadoCita.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CajaCambiarEstadoCita.MaxLength = 3000;
            this.CajaCambiarEstadoCita.Name = "CajaCambiarEstadoCita";
            this.CajaCambiarEstadoCita.Size = new System.Drawing.Size(156, 22);
            this.CajaCambiarEstadoCita.TabIndex = 69;
            this.CajaCambiarEstadoCita.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CajaCambiarEstadoCita_KeyPress);
            // 
            // BotonCambiar
            // 
            this.BotonCambiar.BackColor = System.Drawing.Color.Transparent;
            this.BotonCambiar.BackgroundImage = global::SistemaVeterinaria.Properties.Resources.block_realizado_21;
            this.BotonCambiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BotonCambiar.FlatAppearance.BorderSize = 0;
            this.BotonCambiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BotonCambiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BotonCambiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonCambiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonCambiar.Location = new System.Drawing.Point(769, 430);
            this.BotonCambiar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BotonCambiar.Name = "BotonCambiar";
            this.BotonCambiar.Size = new System.Drawing.Size(113, 59);
            this.BotonCambiar.TabIndex = 70;
            this.BotonCambiar.UseVisualStyleBackColor = false;
            this.BotonCambiar.Click += new System.EventHandler(this.BotonCambiar_Click);
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
            this.BotonAtras.Location = new System.Drawing.Point(1052, 444);
            this.BotonAtras.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BotonAtras.Name = "BotonAtras";
            this.BotonAtras.Size = new System.Drawing.Size(113, 94);
            this.BotonAtras.TabIndex = 62;
            this.BotonAtras.UseVisualStyleBackColor = false;
            this.BotonAtras.Click += new System.EventHandler(this.BotonAtras_Click);
            // 
            // VerCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaVeterinaria.Properties.Resources.VerCitas;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1181, 553);
            this.Controls.Add(this.BotonCambiar);
            this.Controls.Add(this.CajaCambiarEstadoCita);
            this.Controls.Add(this.TextoCambiar);
            this.Controls.Add(this.TextoCitas);
            this.Controls.Add(this.CajaVerCitas);
            this.Controls.Add(this.BotonAtras);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.MostrarDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VerCitas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veterinaria Patagonia";
            this.Load += new System.EventHandler(this.VerCitas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MostrarDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MostrarDatos;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Button BotonAtras;
        private System.Windows.Forms.ComboBox CajaVerCitas;
        private System.Windows.Forms.Label TextoCitas;
        private System.Windows.Forms.Label TextoCambiar;
        private System.Windows.Forms.TextBox CajaCambiarEstadoCita;
        private System.Windows.Forms.Button BotonCambiar;
    }
}