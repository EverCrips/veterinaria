namespace SistemaVeterinaria
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.TextoID = new System.Windows.Forms.Label();
            this.TextoClave = new System.Windows.Forms.Label();
            this.CajaID = new System.Windows.Forms.TextBox();
            this.CajaClave = new System.Windows.Forms.TextBox();
            this.BotonSalir = new System.Windows.Forms.Button();
            this.BotonIngresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(377, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 1;
            // 
            // TextoID
            // 
            this.TextoID.AutoSize = true;
            this.TextoID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(217)))), ((int)(((byte)(203)))));
            this.TextoID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextoID.Font = new System.Drawing.Font("ABeeZee", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoID.Location = new System.Drawing.Point(71, 108);
            this.TextoID.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.TextoID.Name = "TextoID";
            this.TextoID.Size = new System.Drawing.Size(47, 32);
            this.TextoID.TabIndex = 3;
            this.TextoID.Text = "ID:";
            // 
            // TextoClave
            // 
            this.TextoClave.AutoSize = true;
            this.TextoClave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(217)))), ((int)(((byte)(203)))));
            this.TextoClave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextoClave.Font = new System.Drawing.Font("ABeeZee", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoClave.Location = new System.Drawing.Point(71, 194);
            this.TextoClave.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.TextoClave.Name = "TextoClave";
            this.TextoClave.Size = new System.Drawing.Size(98, 32);
            this.TextoClave.TabIndex = 4;
            this.TextoClave.Text = "CLAVE:";
            // 
            // CajaID
            // 
            this.CajaID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.CajaID.Location = new System.Drawing.Point(251, 117);
            this.CajaID.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CajaID.MaxLength = 10;
            this.CajaID.Name = "CajaID";
            this.CajaID.Size = new System.Drawing.Size(239, 22);
            this.CajaID.TabIndex = 5;
            // 
            // CajaClave
            // 
            this.CajaClave.Location = new System.Drawing.Point(251, 204);
            this.CajaClave.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CajaClave.Name = "CajaClave";
            this.CajaClave.PasswordChar = '*';
            this.CajaClave.Size = new System.Drawing.Size(239, 22);
            this.CajaClave.TabIndex = 6;
            this.CajaClave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CajaClave_KeyPress);
            // 
            // BotonSalir
            // 
            this.BotonSalir.BackColor = System.Drawing.Color.Transparent;
            this.BotonSalir.BackgroundImage = global::SistemaVeterinaria.Properties.Resources.Salir_del_programa_2;
            this.BotonSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BotonSalir.FlatAppearance.BorderSize = 0;
            this.BotonSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BotonSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BotonSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonSalir.Location = new System.Drawing.Point(17, 310);
            this.BotonSalir.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.BotonSalir.Name = "BotonSalir";
            this.BotonSalir.Size = new System.Drawing.Size(167, 108);
            this.BotonSalir.TabIndex = 8;
            this.BotonSalir.UseVisualStyleBackColor = false;
            this.BotonSalir.Click += new System.EventHandler(this.BotonSalir_Click);
            // 
            // BotonIngresar
            // 
            this.BotonIngresar.BackColor = System.Drawing.Color.Transparent;
            this.BotonIngresar.BackgroundImage = global::SistemaVeterinaria.Properties.Resources.Ingresar_2;
            this.BotonIngresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BotonIngresar.FlatAppearance.BorderSize = 0;
            this.BotonIngresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BotonIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BotonIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonIngresar.Location = new System.Drawing.Point(501, 108);
            this.BotonIngresar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.BotonIngresar.Name = "BotonIngresar";
            this.BotonIngresar.Size = new System.Drawing.Size(161, 119);
            this.BotonIngresar.TabIndex = 7;
            this.BotonIngresar.UseVisualStyleBackColor = false;
            this.BotonIngresar.Click += new System.EventHandler(this.BotonIngresar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaVeterinaria.Properties.Resources.LOGIN;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(909, 434);
            this.Controls.Add(this.BotonSalir);
            this.Controls.Add(this.BotonIngresar);
            this.Controls.Add(this.CajaClave);
            this.Controls.Add(this.CajaID);
            this.Controls.Add(this.TextoClave);
            this.Controls.Add(this.TextoID);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veterinaria Patagonia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TextoID;
        private System.Windows.Forms.Label TextoClave;
        private System.Windows.Forms.TextBox CajaID;
        private System.Windows.Forms.TextBox CajaClave;
        private System.Windows.Forms.Button BotonIngresar;
        private System.Windows.Forms.Button BotonSalir;
    }
}

