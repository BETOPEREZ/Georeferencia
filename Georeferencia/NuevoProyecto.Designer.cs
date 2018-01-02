namespace Georeferencia
{
    partial class NuevoProyecto
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnImagen = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.texImagen = new System.Windows.Forms.TextBox();
            this.texLog = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnGeoreferenciar = new System.Windows.Forms.Button();
            this.texResultados = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnProcesar);
            this.panel1.Controls.Add(this.comboBox3);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.btnImagen);
            this.panel1.Controls.Add(this.btnLog);
            this.panel1.Controls.Add(this.texImagen);
            this.panel1.Controls.Add(this.texLog);
            this.panel1.Location = new System.Drawing.Point(37, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(823, 250);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(51, 192);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(160, 50);
            this.btnProcesar.TabIndex = 7;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(471, 144);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 28);
            this.comboBox3.TabIndex = 6;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(302, 144);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 28);
            this.comboBox2.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(137, 144);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 4;
            // 
            // btnImagen
            // 
            this.btnImagen.Location = new System.Drawing.Point(614, 69);
            this.btnImagen.Name = "btnImagen";
            this.btnImagen.Size = new System.Drawing.Size(160, 50);
            this.btnImagen.TabIndex = 3;
            this.btnImagen.Text = "Imagen";
            this.btnImagen.UseVisualStyleBackColor = true;
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(614, 3);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(160, 50);
            this.btnLog.TabIndex = 2;
            this.btnLog.Text = "Log";
            this.btnLog.UseVisualStyleBackColor = true;
            // 
            // texImagen
            // 
            this.texImagen.Location = new System.Drawing.Point(51, 81);
            this.texImagen.Name = "texImagen";
            this.texImagen.Size = new System.Drawing.Size(512, 26);
            this.texImagen.TabIndex = 1;
            // 
            // texLog
            // 
            this.texLog.Location = new System.Drawing.Point(51, 15);
            this.texLog.Name = "texLog";
            this.texLog.Size = new System.Drawing.Size(512, 26);
            this.texLog.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnGeoreferenciar);
            this.panel2.Controls.Add(this.texResultados);
            this.panel2.Location = new System.Drawing.Point(37, 268);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(823, 301);
            this.panel2.TabIndex = 5;
            // 
            // btnGeoreferenciar
            // 
            this.btnGeoreferenciar.Location = new System.Drawing.Point(614, 247);
            this.btnGeoreferenciar.Name = "btnGeoreferenciar";
            this.btnGeoreferenciar.Size = new System.Drawing.Size(160, 50);
            this.btnGeoreferenciar.TabIndex = 1;
            this.btnGeoreferenciar.Text = "Georeferenciar";
            this.btnGeoreferenciar.UseVisualStyleBackColor = true;
            this.btnGeoreferenciar.Click += new System.EventHandler(this.btnGeoreferenciar_Click);
            // 
            // texResultados
            // 
            this.texResultados.Location = new System.Drawing.Point(26, 3);
            this.texResultados.Multiline = true;
            this.texResultados.Name = "texResultados";
            this.texResultados.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.texResultados.Size = new System.Drawing.Size(748, 231);
            this.texResultados.TabIndex = 0;
            // 
            // NuevoProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(908, 581);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "NuevoProyecto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NuevoProyecto";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnImagen;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.TextBox texImagen;
        private System.Windows.Forms.TextBox texLog;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnGeoreferenciar;
        private System.Windows.Forms.TextBox texResultados;
    }
}