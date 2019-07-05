namespace SistemaVeterinaria.Secretaria
{
    partial class VerConsultas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MostrarDatos = new System.Windows.Forms.DataGridView();
            this.Titulo = new System.Windows.Forms.Label();
            this.BotonAtras = new System.Windows.Forms.Button();
            this.TextoConsultas = new System.Windows.Forms.Label();
            this.CajaVerConsultas = new System.Windows.Forms.ComboBox();
            this.TextoCambiar = new System.Windows.Forms.Label();
            this.CajaCambiarEstadoConsulta = new System.Windows.Forms.TextBox();
            this.BotonCambiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MostrarDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // MostrarDatos
            // 
            this.MostrarDatos.AllowUserToAddRows = false;
            this.MostrarDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MostrarDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.MostrarDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MostrarDatos.DefaultCellStyle = dataGridViewCellStyle6;
            this.MostrarDatos.Location = new System.Drawing.Point(13, 74);
            this.MostrarDatos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MostrarDatos.Name = "MostrarDatos";
            this.MostrarDatos.ReadOnly = true;
            this.MostrarDatos.RowHeadersVisible = false;
            this.MostrarDatos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MostrarDatos.Size = new System.Drawing.Size(1156, 350);
            this.MostrarDatos.TabIndex = 30;
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(217)))), ((int)(((byte)(207)))));
            this.Titulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Titulo.Font = new System.Drawing.Font("ABeeZee", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(457, 9);
            this.Titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(260, 30);
            this.Titulo.TabIndex = 31;
            this.Titulo.Text = "Registro de Consultas";
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
            this.BotonAtras.Location = new System.Drawing.Point(1065, 455);
            this.BotonAtras.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BotonAtras.Name = "BotonAtras";
            this.BotonAtras.Size = new System.Drawing.Size(104, 84);
            this.BotonAtras.TabIndex = 63;
            this.BotonAtras.UseVisualStyleBackColor = false;
            this.BotonAtras.Click += new System.EventHandler(this.BotonAtras_Click);
            // 
            // TextoConsultas
            // 
            this.TextoConsultas.AutoSize = true;
            this.TextoConsultas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(217)))), ((int)(((byte)(207)))));
            this.TextoConsultas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextoConsultas.Font = new System.Drawing.Font("ABeeZee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoConsultas.Location = new System.Drawing.Point(13, 428);
            this.TextoConsultas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TextoConsultas.Name = "TextoConsultas";
            this.TextoConsultas.Size = new System.Drawing.Size(149, 26);
            this.TextoConsultas.TabIndex = 68;
            this.TextoConsultas.Text = "Ver Consultas:";
            // 
            // CajaVerConsultas
            // 
            this.CajaVerConsultas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CajaVerConsultas.FormattingEnabled = true;
            this.CajaVerConsultas.Location = new System.Drawing.Point(168, 431);
            this.CajaVerConsultas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CajaVerConsultas.Name = "CajaVerConsultas";
            this.CajaVerConsultas.Size = new System.Drawing.Size(172, 24);
            this.CajaVerConsultas.TabIndex = 69;
            this.CajaVerConsultas.SelectedIndexChanged += new System.EventHandler(this.CajaVerConsultas_SelectedIndexChanged);
            // 
            // TextoCambiar
            // 
            this.TextoCambiar.AutoSize = true;
            this.TextoCambiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(217)))), ((int)(((byte)(207)))));
            this.TextoCambiar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextoCambiar.Font = new System.Drawing.Font("ABeeZee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoCambiar.Location = new System.Drawing.Point(364, 428);
            this.TextoCambiar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TextoCambiar.Name = "TextoCambiar";
            this.TextoCambiar.Size = new System.Drawing.Size(279, 26);
            this.TextoCambiar.TabIndex = 70;
            this.TextoCambiar.Text = "Cambiar estado a realizado:";
            // 
            // CajaCambiarEstadoConsulta
            // 
            this.CajaCambiarEstadoConsulta.Location = new System.Drawing.Point(649, 431);
            this.CajaCambiarEstadoConsulta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CajaCambiarEstadoConsulta.MaxLength = 3000;
            this.CajaCambiarEstadoConsulta.Name = "CajaCambiarEstadoConsulta";
            this.CajaCambiarEstadoConsulta.Size = new System.Drawing.Size(156, 22);
            this.CajaCambiarEstadoConsulta.TabIndex = 71;
            this.CajaCambiarEstadoConsulta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CajaCambiarEstadoCita_KeyPress);
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
            this.BotonCambiar.Location = new System.Drawing.Point(815, 428);
            this.BotonCambiar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BotonCambiar.Name = "BotonCambiar";
            this.BotonCambiar.Size = new System.Drawing.Size(116, 82);
            this.BotonCambiar.TabIndex = 72;
            this.BotonCambiar.UseVisualStyleBackColor = false;
            this.BotonCambiar.Click += new System.EventHandler(this.BotonCambiar_Click);
            // 
            // VerConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaVeterinaria.Properties.Resources.VerConsulta;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1181, 553);
            this.Controls.Add(this.BotonCambiar);
            this.Controls.Add(this.CajaCambiarEstadoConsulta);
            this.Controls.Add(this.TextoCambiar);
            this.Controls.Add(this.CajaVerConsultas);
            this.Controls.Add(this.TextoConsultas);
            this.Controls.Add(this.BotonAtras);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.MostrarDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VerConsultas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veterinaria Patagonia";
            this.Load += new System.EventHandler(this.VerConsultas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MostrarDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MostrarDatos;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Button BotonAtras;
        private System.Windows.Forms.Label TextoConsultas;
        private System.Windows.Forms.ComboBox CajaVerConsultas;
        private System.Windows.Forms.Label TextoCambiar;
        private System.Windows.Forms.TextBox CajaCambiarEstadoConsulta;
        private System.Windows.Forms.Button BotonCambiar;
    }
}