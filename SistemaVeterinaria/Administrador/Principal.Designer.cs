namespace SistemaVeterinaria.Administrador
{
    partial class Principal
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
            this.BotonCrearUsuario = new System.Windows.Forms.Button();
            this.TextoUsuario = new System.Windows.Forms.Label();
            this.BotonAtras = new System.Windows.Forms.Button();
            this.BotonVerEliminarUsuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BotonCrearUsuario
            // 
            this.BotonCrearUsuario.Font = new System.Drawing.Font("ABeeZee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonCrearUsuario.Location = new System.Drawing.Point(100, 181);
            this.BotonCrearUsuario.Name = "BotonCrearUsuario";
            this.BotonCrearUsuario.Size = new System.Drawing.Size(176, 95);
            this.BotonCrearUsuario.TabIndex = 0;
            this.BotonCrearUsuario.Text = "USUARIOS";
            this.BotonCrearUsuario.UseVisualStyleBackColor = true;
            // 
            // TextoUsuario
            // 
            this.TextoUsuario.AutoSize = true;
            this.TextoUsuario.Font = new System.Drawing.Font("ABeeZee", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoUsuario.Location = new System.Drawing.Point(12, 9);
            this.TextoUsuario.Name = "TextoUsuario";
            this.TextoUsuario.Size = new System.Drawing.Size(105, 28);
            this.TextoUsuario.TabIndex = 1;
            this.TextoUsuario.Text = "Usuario:";
            // 
            // BotonAtras
            // 
            this.BotonAtras.Font = new System.Drawing.Font("ABeeZee", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonAtras.Location = new System.Drawing.Point(525, 480);
            this.BotonAtras.Margin = new System.Windows.Forms.Padding(4);
            this.BotonAtras.Name = "BotonAtras";
            this.BotonAtras.Size = new System.Drawing.Size(244, 60);
            this.BotonAtras.TabIndex = 54;
            this.BotonAtras.Text = "Atras";
            this.BotonAtras.UseVisualStyleBackColor = true;
            // 
            // BotonVerEliminarUsuario
            // 
            this.BotonVerEliminarUsuario.Font = new System.Drawing.Font("ABeeZee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonVerEliminarUsuario.Location = new System.Drawing.Point(503, 181);
            this.BotonVerEliminarUsuario.Name = "BotonVerEliminarUsuario";
            this.BotonVerEliminarUsuario.Size = new System.Drawing.Size(176, 95);
            this.BotonVerEliminarUsuario.TabIndex = 55;
            this.BotonVerEliminarUsuario.Text = "USUARIOS";
            this.BotonVerEliminarUsuario.UseVisualStyleBackColor = true;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.BotonVerEliminarUsuario);
            this.Controls.Add(this.BotonAtras);
            this.Controls.Add(this.TextoUsuario);
            this.Controls.Add(this.BotonCrearUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veterinaria Patagonia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BotonCrearUsuario;
        private System.Windows.Forms.Label TextoUsuario;
        private System.Windows.Forms.Button BotonAtras;
        private System.Windows.Forms.Button BotonVerEliminarUsuario;
    }
}