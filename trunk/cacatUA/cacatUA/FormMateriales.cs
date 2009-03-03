﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace cacatUA
{
    public partial class FormMateriales : cacatUA.FormPanelAdministracion
    {
        public FormMateriales()
        {
            InitializeComponent();
            // Inicializamos las secciones
            comboBox_seccion.Items.Add("Ingeniería Informática");
            // Inicializamos las categorías
            comboBox_categoria.Items.Add("Primer Curso");
            comboBox_categoria.Items.Add("Segundo Curso");
            comboBox_categoria.Items.Add("Tercer Curso");
            comboBox_categoria.Items.Add("Cuarto Curso");
            comboBox_categoria.Items.Add("Quinto Curso");
            // Inicializamos las subcategorías
            comboBox_subcategoria.Items.Add("Algebra");
            comboBox_subcategoria.Items.Add("Informática Básica");
            comboBox_subcategoria.Items.Add("Matemática discreta");
            comboBox_subcategoria.Items.Add("Fundamentos de programación I");
            comboBox_subcategoria.Items.Add("Fundamentos de programación II");
            // Añadimos unos cuantos materiales
            crearMateriales();
        }

        private void crearMateriales()
        {
            for (int i = 0; i < 10; i++)
            {
                string nombre = "material" + i.ToString();
                string descripcion = "descripcion material " + i.ToString();
                string añadido = "01/01/2009";
                string valoracion = "5";
                DataGridViewRow fila = new DataGridViewRow();
                fila.CreateCells(dataGridView1);
                fila.Cells[0].Value = nombre;
                fila.Cells[1].Value = descripcion;
                fila.Cells[2].Value = añadido;
                fila.Cells[3].Value = valoracion;
                dataGridView1.Rows.Add(fila); 
            }
        }

        private void editarMaterial(object sender, EventArgs e)
        {
            FormMaterial formMaterial = new FormMaterial();
            formMaterial.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormMaterial formMaterial = new FormMaterial();
            formMaterial.Show();
        }

    }
}