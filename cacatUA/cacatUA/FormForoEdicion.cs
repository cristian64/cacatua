﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Libreria;

namespace cacatUA
{
    public partial class FormForoEdicion : InterfazForm
    {
        private ENHilo hilo;
        private ENCategoria categoria = null;
        private ENUsuario usuario = null;
        private FormForo formularioPadre = null;

        public FormForoEdicion(FormForo formularioPadre)
        {
            this.formularioPadre = formularioPadre;
            InitializeComponent();
        }

        public void CambiarSeleccionado(int id)
        {
            hilo = ENHilo.Obtener(id);
            if (hilo != null)
            {
                button_guardarCambios.Text = "Guardar cambios";
                button_descartarCambios.Text = "Descartar cambios";
                textBox_id.Text = hilo.Id.ToString();
                textBox_texto.Text = hilo.Texto;
                textBox_titulo.Text = hilo.Titulo;
                textBox_autor.Text = hilo.Autor.Usuario.ToString();
                textBox_categoria.Text = hilo.Categoria.NombreCompleto().ToString();
                dateTimePicker_fecha.Value = hilo.Fecha;
                textBox_respuestas.Text = hilo.NumRespuestas.ToString();
                linkLabel_respuestas.Enabled = true;
                errorProvider1.Clear();
                desactivarBotones();

                categoria = hilo.Categoria;
                usuario = hilo.Autor;
            }
            else
            {
                MessageBox.Show("No se puede cambiar al hilo nº " + id, "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CambiarNuevo()
        {
            hilo = null;
            categoria = null;
            usuario = null;
            button_guardarCambios.Text = "Crear";
            button_descartarCambios.Text = "Limpiar";
            textBox_id.Text = "";
            textBox_texto.Text = "";
            textBox_titulo.Text = "";
            textBox_autor.Text = "";
            textBox_categoria.Text = "";
            textBox_respuestas.Text = "";
            dateTimePicker_fecha.Value = DateTime.Now;
            linkLabel_respuestas.Enabled = false;
            errorProvider1.Clear();
            desactivarBotones();
        }

        public void CambiarNuevo2() // La diferencia con el anterior es que no restaura la categoría.
        {
            hilo = null;
            usuario = null;
            button_guardarCambios.Text = "Crear";
            button_descartarCambios.Text = "Limpiar";
            textBox_id.Text = "";
            textBox_texto.Text = "";
            textBox_titulo.Text = "";
            textBox_autor.Text = "";
            textBox_respuestas.Text = "";
            dateTimePicker_fecha.Value = DateTime.Now;
            linkLabel_respuestas.Enabled = false;
            errorProvider1.Clear();
            desactivarBotones();
        }

        public ENHilo Seleccionado
        {
            get { return hilo; }
            set { CambiarSeleccionado(value.Id); }
        }

        public bool ValidarFormulario()
        {
            bool correcto = true;
            string errorTitulo = "";
            string errorTexto = "";
            string errorCategoria = "";
            string errorUsuario = "";

            if (textBox_titulo.Text != "")
            {
                if (textBox_titulo.Text.Length > 200)
                {
                    errorTitulo = "El título no puede tener más de 200 caracteres.";
                }
            }
            else
            {
                errorTitulo = "Debes introducir un título.";
            }

            if (textBox_texto.Text != "")
            {
                if (textBox_titulo.Text.Length > 5000)
                {
                    errorTitulo = "El texto no puede tener más de 5000 caracteres.";
                }
            }
            else
            {
                errorTexto = "Debes introducir un texto.";
            }

            if (textBox_categoria.Text != "")
            {

            }
            else
            {
                correcto = false;
                errorCategoria = "Debes introducir una categoría.";
            }

            if (textBox_autor.Text != "")
            {
                ENUsuario usuario = ENUsuario.Obtener(textBox_autor.Text);
                if (usuario==null)
                {
                    correcto = false;
                    errorUsuario = "Este usuario no existe.";
                }
            }
            else
            {
                correcto = false;
                errorUsuario = "Debes introducir un autor.";
            }

            errorProvider1.SetError(textBox_titulo, errorTitulo);
            errorProvider1.SetError(textBox_texto, errorTexto);
            errorProvider1.SetError(textBox_categoria, errorCategoria);
            errorProvider1.SetError(textBox_autor, errorUsuario);

            return correcto;
        }

        private void button_guardarCambios_Click(object sender, EventArgs e)
        {
            if (ValidarFormulario())
            {
                ENHilo nuevo = new ENHilo();
                nuevo.Texto = textBox_texto.Text;
                nuevo.Titulo = textBox_titulo.Text;
                nuevo.Autor = ENUsuario.Obtener(textBox_autor.Text);
                nuevo.Categoria = categoria;
                nuevo.Fecha = dateTimePicker_fecha.Value;
                nuevo.NumRespuestas = 0;

                if (textBox_id.Text == "")
                {
                    if (nuevo.Guardar())
                    {
                        CambiarSeleccionado(nuevo.Id);
                        FormPanelAdministracion.Instancia.MensajeEstado("Hilo guardado correctamente.");
                        formularioPadre.ReiniciarResultados();
                    }
                    else
                    {
                        MessageBox.Show("No se puede guardar el hilo.", "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    nuevo.Id = int.Parse(textBox_id.Text);
                    nuevo.NumRespuestas = int.Parse(textBox_respuestas.Text);
                    if (nuevo.Actualizar())
                    {
                        desactivarBotones();
                        FormPanelAdministracion.Instancia.MensajeEstado("Hilo actualizado correctamente.");
                        formularioPadre.ActualizarResultados(nuevo);
                    }
                    else
                    {
                        MessageBox.Show("No se puede actualizar el hilo.", "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void formulario_Modificado(object sender, EventArgs e)
        {
            activarBotones();
        }

        private void activarBotones()
        {
            if(button_guardarCambios.Enabled == false)
                button_guardarCambios.Enabled = true;

            if (button_descartarCambios.Enabled == false)
                button_descartarCambios.Enabled = true;
        }

        private void desactivarBotones()
        {
            if (button_guardarCambios.Enabled == true)
                button_guardarCambios.Enabled = false;

            if (button_descartarCambios.Enabled == true)
                button_descartarCambios.Enabled = false;
        }

        private void button_descartarCambios_Click(object sender, EventArgs e)
        {
            if (textBox_id.Text == "")
            {
                CambiarNuevo();
            }
            else
            {
                CambiarSeleccionado (int.Parse(textBox_id.Text));
            }
        }

        private void button_seleccionarUsuario_Click(object sender, EventArgs e)
        {
            FormPanelAdministracion.Instancia.Apilar(new FormUsuarios(), "Seleccionando usuario", true, true, "Volver al panel anterior seleccionando el usuario actual", "Cancelar la selección y volver al panel anterior");
        }

        private void button_seleccionarCategoria_Click(object sender, EventArgs e)
        {
            FormPanelAdministracion.Instancia.Apilar(new FormCategorias(), "Seleccionando categoría", true, true, "Volver al panel anterior seleccionando la categoría actual", "Cancelar la selección y volver al panel anterior");
        }

        private void linkLabel_respuestas_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormPanelAdministracion.Instancia.Apilar(new FormForoRespuestas(hilo), "Respuestas del hilo nº "+textBox_id.Text, true, false, "Volver al hilo", "");
        }

        public override void Recibir(object objeto)
        {
            if (objeto != null)
            {
                if (objeto is ENCategoria)
                {
                    categoria = (ENCategoria)objeto;
                    textBox_categoria.Text = categoria.NombreCompleto();
                }
                else
                {
                    if (objeto is ENUsuario)
                    {
                        usuario = (ENUsuario)objeto;
                        textBox_autor.Text = usuario.Usuario;
                    }
                }
            }
        }
    }
}
