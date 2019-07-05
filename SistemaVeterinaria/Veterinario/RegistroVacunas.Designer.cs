namespace SistemaVeterinaria.Veterinario
{
    partial class RegistroVacunas
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
            this.TextoIdVacuna = new System.Windows.Forms.Label();
            this.CajaIdVacuna = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CajaVerRegistroVacunas = new System.Windows.Forms.ComboBox();
            this.BotonNuevaVacuna = new System.Windows.Forms.Button();
            this.BotonCambiarEstadoVacuna = new System.Windows.Forms.Button();
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
            this.MostrarDatos.Location = new System.Drawing.Point(13, 62);
            this.MostrarDatos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MostrarDatos.Name = "MostrarDatos";
            this.MostrarDatos.ReadOnly = true;
            this.MostrarDatos.RowHeadersVisible = false;
            this.MostrarDatos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MostrarDatos.Size = new System.Drawing.Size(856, 206);
            this.MostrarDatos.TabIndex = 33;
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(217)))), ((int)(((byte)(207)))));
            this.Titulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Titulo.Font = new System.Drawing.Font("ABeeZee", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(317, 9);
            this.Titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(209, 30);
            this.Titulo.TabIndex = 34;
            this.Titulo.Text = "Registro Vacunas";
            // 
            // TextoIdVacuna
            // 
            this.TextoIdVacuna.AutoSize = true;
            this.TextoIdVacuna.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(217)))), ((int)(((byte)(207)))));
            this.TextoIdVacuna.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextoIdVacuna.Font = new System.Drawing.Font("ABeeZee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoIdVacuna.Location = new System.Drawing.Point(293, 283);
            this.TextoIdVacuna.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TextoIdVacuna.Name = "TextoIdVacuna";
            this.TextoIdVacuna.Size = new System.Drawing.Size(112, 26);
            this.TextoIdVacuna.TabIndex = 62;
            this.TextoIdVacuna.Text = "Id Vacuna:";
            // 
            // CajaIdVacuna
            // 
            this.CajaIdVacuna.Location = new System.Drawing.Point(419, 283);
            this.CajaIdVacuna.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CajaIdVacuna.Name = "CajaIdVacuna";
            this.CajaIdVacuna.Size = new System.Drawing.Size(192, 22);
            this.CajaIdVacuna.TabIndex = 63;
            this.CajaIdVacuna.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CajaIdVacuna_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(217)))), ((int)(((byte)(207)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("ABeeZee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 283);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 26);
            this.label1.TabIndex = 65;
            this.label1.Text = "Ver:";
            // 
            // CajaVerRegistroVacunas
            // 
            this.CajaVerRegistroVacunas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CajaVerRegistroVacunas.FormattingEnabled = true;
            this.CajaVerRegistroVacunas.Location = new System.Drawing.Point(69, 287);
            this.CajaVerRegistroVacunas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CajaVerRegistroVacunas.Name = "CajaVerRegistroVacunas";
            this.CajaVerRegistroVacunas.Size = new System.Drawing.Size(187, 24);
            this.CajaVerRegistroVacunas.TabIndex = 67;
            this.CajaVerRegistroVacunas.SelectedIndexChanged += new System.EventHandler(this.CajaVerRegistroVacunas_SelectedIndexChanged);
            // 
            // BotonNuevaVacuna
            // 
            this.BotonNuevaVacuna.BackColor = System.Drawing.Color.Transparent;
            this.BotonNuevaVacuna.BackgroundImage = global::SistemaVeterinaria.Properties.Resources.Nueva_Vacuna_2;
            this.BotonNuevaVacuna.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BotonNuevaVacuna.FlatAppearance.BorderSize = 0;
            this.BotonNuevaVacuna.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BotonNuevaVacuna.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BotonNuevaVacuna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonNuevaVacuna.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonNuevaVacuna.Location = new System.Drawing.Point(771, 276);
            this.BotonNuevaVacuna.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BotonNuevaVacuna.Name = "BotonNuevaVacuna";
            this.BotonNuevaVacuna.Size = new System.Drawing.Size(97, 85);
            this.BotonNuevaVacuna.TabIndex = 64;
            this.BotonNuevaVacuna.UseVisualStyleBackColor = false;
            this.BotonNuevaVacuna.Click += new System.EventHandler(this.BotonNuevaVacuna_Click);
            // 
            // BotonCambiarEstadoVacuna
            // 
            this.BotonCambiarEstadoVacuna.BackColor = System.Drawing.Color.Transparent;
            this.BotonCambiarEstadoVacuna.BackgroundImage = global::SistemaVeterinaria.Properties.Resources.block_realizado_21;
            this.BotonCambiarEstadoVacuna.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BotonCambiarEstadoVacuna.FlatAppearance.BorderSize = 0;
            this.BotonCambiarEstadoVacuna.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BotonCambiarEstadoVacuna.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BotonCambiarEstadoVacuna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonCambiarEstadoVacuna.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonCambiarEstadoVacuna.Location = new System.Drawing.Point(620, 276);
            this.BotonCambiarEstadoVacuna.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BotonCambiarEstadoVacuna.Name = "BotonCambiarEstadoVacuna";
            this.BotonCambiarEstadoVacuna.Size = new System.Drawing.Size(89, 85);
            this.BotonCambiarEstadoVacuna.TabIndex = 61;
            this.BotonCambiarEstadoVacuna.UseVisualStyleBackColor = false;
            this.BotonCambiarEstadoVacuna.Click += new System.EventHandler(this.BotonCambiarEstadoVacuna_Click);
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
            this.BotonAtras.Location = new System.Drawing.Point(19, 372);
            this.BotonAtras.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BotonAtras.Name = "BotonAtras";
            this.BotonAtras.Size = new System.Drawing.Size(87, 66);
            this.BotonAtras.TabIndex = 60;
            this.BotonAtras.UseVisualStyleBackColor = false;
            this.BotonAtras.Click += new System.EventHandler(this.BotonAtras_Click);
            // 
            // RegistroVacunas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaVeterinaria.Properties.Resources.RegistroVacunas;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(883, 453);
            this.Controls.Add(this.CajaVerRegistroVacunas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BotonNuevaVacuna);
            this.Controls.Add(this.CajaIdVacuna);
            this.Controls.Add(this.TextoIdVacuna);
            this.Controls.Add(this.BotonCambiarEstadoVacuna);
            this.Controls.Add(this.BotonAtras);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.MostrarDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegistroVacunas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veterinaria Patagonia";
            this.Load += new System.EventHandler(this.RegistroVacunas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MostrarDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MostrarDatos;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Button BotonAtras;
        private System.Windows.Forms.Button BotonCambiarEstadoVacuna;
        private System.Windows.Forms.Label TextoIdVacuna;
        private System.Windows.Forms.TextBox CajaIdVacuna;
        private System.Windows.Forms.Button BotonNuevaVacuna;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CajaVerRegistroVacunas;
    }
}