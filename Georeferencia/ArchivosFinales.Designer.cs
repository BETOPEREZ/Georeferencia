namespace Georeferencia
{
    partial class ArchivosFinales
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
            this.btnAbrirFolder = new System.Windows.Forms.Button();
            this.lblSalir = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAbrirFolder
            // 
            this.btnAbrirFolder.Location = new System.Drawing.Point(197, 152);
            this.btnAbrirFolder.Name = "btnAbrirFolder";
            this.btnAbrirFolder.Size = new System.Drawing.Size(520, 70);
            this.btnAbrirFolder.TabIndex = 0;
            this.btnAbrirFolder.Text = "Abrir Folder";
            this.btnAbrirFolder.UseVisualStyleBackColor = true;
            // 
            // lblSalir
            // 
            this.lblSalir.AutoSize = true;
            this.lblSalir.Location = new System.Drawing.Point(774, 394);
            this.lblSalir.Name = "lblSalir";
            this.lblSalir.Size = new System.Drawing.Size(40, 20);
            this.lblSalir.TabIndex = 1;
            this.lblSalir.Text = "Salir";
            this.lblSalir.Click += new System.EventHandler(this.lblSalir_Click);
            // 
            // ArchivosFinales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 447);
            this.Controls.Add(this.lblSalir);
            this.Controls.Add(this.btnAbrirFolder);
            this.Name = "ArchivosFinales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EtiquetadoImagenes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAbrirFolder;
        private System.Windows.Forms.Label lblSalir;
    }
}