namespace Georeferencia
{
    partial class Menu
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
            this.btnNuevoProyecto = new System.Windows.Forms.Button();
            this.btnProyectoExistente = new System.Windows.Forms.Button();
            this.lblAyuda = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNuevoProyecto
            // 
            this.btnNuevoProyecto.Location = new System.Drawing.Point(262, 130);
            this.btnNuevoProyecto.Name = "btnNuevoProyecto";
            this.btnNuevoProyecto.Size = new System.Drawing.Size(370, 75);
            this.btnNuevoProyecto.TabIndex = 0;
            this.btnNuevoProyecto.Text = "Nuevo Proyecto";
            this.btnNuevoProyecto.UseVisualStyleBackColor = true;
            this.btnNuevoProyecto.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnProyectoExistente
            // 
            this.btnProyectoExistente.Location = new System.Drawing.Point(262, 275);
            this.btnProyectoExistente.Name = "btnProyectoExistente";
            this.btnProyectoExistente.Size = new System.Drawing.Size(370, 75);
            this.btnProyectoExistente.TabIndex = 1;
            this.btnProyectoExistente.Text = "Proyecto Existente";
            this.btnProyectoExistente.UseVisualStyleBackColor = true;
            // 
            // lblAyuda
            // 
            this.lblAyuda.AutoSize = true;
            this.lblAyuda.Location = new System.Drawing.Point(750, 448);
            this.lblAyuda.Name = "lblAyuda";
            this.lblAyuda.Size = new System.Drawing.Size(54, 20);
            this.lblAyuda.TabIndex = 2;
            this.lblAyuda.Text = "Ayuda";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 504);
            this.Controls.Add(this.lblAyuda);
            this.Controls.Add(this.btnProyectoExistente);
            this.Controls.Add(this.btnNuevoProyecto);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNuevoProyecto;
        private System.Windows.Forms.Button btnProyectoExistente;
        private System.Windows.Forms.Label lblAyuda;
    }
}