﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace cacatUA
{
    public partial class FormPeticiones : UserControl
    {
        public FormPeticiones()
        {
            InitializeComponent();
            anadirAlgunasPeticiones();
        }

        private void anadirAlgunasPeticiones()
        {
            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dataGridViewRecientes);
            fila.Cells[0].Value = "Nueva categoria";
            fila.Cells[1].Value = "Jose";
            dataGridViewRecientes.Rows.Add(fila);
            DataGridViewRow fila1 = new DataGridViewRow();
            fila1.CreateCells(dataGridViewRecientes);
            fila1.Cells[0].Value = "Error Descarga Material";
            fila1.Cells[1].Value = "Andres";
            dataGridViewRecientes.Rows.Add(fila1);
           

        }

        private void buttonUsuario_Click(object sender, EventArgs e)
        {
            /*Form1 form = new Form1();
            form.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            form.Size = new Size(900, 500);
            form.Show();*/
        }
        private void buttonMensajes_Click(object sender, EventArgs e)
        {
            /*Form1 form = new Form1();
            form.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            form.Size = new Size(900, 500);
            form.Show();*/
        }

        private void buttonRealizada_Click(object sender, EventArgs e)
        {
            if (dataGridViewRecientes.SelectedRows != null)
            {
                /*DataGridViewRow fila = new DataGridViewRow();
                fila.CreateCells(dataGridViewRecientes);
                dataGridViewRecientes.SelectedCells.ToString();*/


            }

        }
    }
}
