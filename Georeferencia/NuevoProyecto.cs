﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Georeferencia
{
    public partial class NuevoProyecto : Form
    {
        public NuevoProyecto()
        {
            InitializeComponent();
        }

        private void btnGeoreferenciar_Click(object sender, EventArgs e)
        {
            ArchivosFinales etiquetadoImagenes = new ArchivosFinales();
            etiquetadoImagenes.Show();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
