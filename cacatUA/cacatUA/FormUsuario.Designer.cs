﻿namespace cacatUA
{
    partial class FormUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsuario));
            this.tabControl_usuario = new System.Windows.Forms.TabControl();
            this.tabPage_datos = new System.Windows.Forms.TabPage();
            this.checkBox_esAdmin = new System.Windows.Forms.CheckBox();
            this.dateTimePicker_fechaDeIngreso = new System.Windows.Forms.DateTimePicker();
            this.label_fechaDeIngreso = new System.Windows.Forms.Label();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.label_email = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox_nombre = new System.Windows.Forms.TextBox();
            this.label_datosDeUsuario = new System.Windows.Forms.Label();
            this.label_nombre = new System.Windows.Forms.Label();
            this.tabPage_firmas = new System.Windows.Forms.TabPage();
            this.radioButton_recibidasPorUsuario = new System.Windows.Forms.RadioButton();
            this.radioButton_realizadasPorUsuario = new System.Windows.Forms.RadioButton();
            this.dataGridView_firmas = new System.Windows.Forms.DataGridView();
            this.autorFirma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinatarioFirma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaFirma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker_fechaFirma = new System.Windows.Forms.DateTimePicker();
            this.button_buscarFirma = new System.Windows.Forms.Button();
            this.textBox_autorFirma = new System.Windows.Forms.TextBox();
            this.label_buscarFirmaPorAutor = new System.Windows.Forms.Label();
            this.label_buscarFirmaPorFecha = new System.Windows.Forms.Label();
            this.label_firmasDeUsuario = new System.Windows.Forms.Label();
            this.button_borrarFirma = new System.Windows.Forms.Button();
            this.button_editarFirma = new System.Windows.Forms.Button();
            this.tabPage_galeria = new System.Windows.Forms.TabPage();
            this.button_borrarGaleria = new System.Windows.Forms.Button();
            this.button_editarGaleria = new System.Windows.Forms.Button();
            this.dataGridView_galeria = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox_tituloGaleria = new System.Windows.Forms.TextBox();
            this.label_buscarGaleriaPorTitulo = new System.Windows.Forms.Label();
            this.dateTimePicker_fechaGaleria = new System.Windows.Forms.DateTimePicker();
            this.button_buscarGaleria = new System.Windows.Forms.Button();
            this.textBox_autorGaleria = new System.Windows.Forms.TextBox();
            this.label_buscarGaleriaPorAutor = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_fotosDeUsuario = new System.Windows.Forms.Label();
            this.tabPage_mensajes = new System.Windows.Forms.TabPage();
            this.button_borrarMensaje = new System.Windows.Forms.Button();
            this.button_editarMensaje = new System.Windows.Forms.Button();
            this.dataGridView_mensajes = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox_tituloMensaje = new System.Windows.Forms.TextBox();
            this.label_buscarMensajePorTitulo = new System.Windows.Forms.Label();
            this.dateTimePicker_fechaMensaje = new System.Windows.Forms.DateTimePicker();
            this.button_buscarMensaje = new System.Windows.Forms.Button();
            this.label_buscarMensajePorFecha = new System.Windows.Forms.Label();
            this.label_mensajesDeUsuario = new System.Windows.Forms.Label();
            this.tabPage_peticiones = new System.Windows.Forms.TabPage();
            this.button_borrarPeticion = new System.Windows.Forms.Button();
            this.button_editarPeticion = new System.Windows.Forms.Button();
            this.textBox_asuntoPeticion = new System.Windows.Forms.TextBox();
            this.label_buscarPeticionPorAsunto = new System.Windows.Forms.Label();
            this.button_buscarPeticion = new System.Windows.Forms.Button();
            this.dateTimePicker_fechaPeticion = new System.Windows.Forms.DateTimePicker();
            this.label_buscarPeticionPorFecha = new System.Windows.Forms.Label();
            this.dataGridView_peticiones = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_peticionesDeUsuario = new System.Windows.Forms.Label();
            this.tabPage_encuestas = new System.Windows.Forms.TabPage();
            this.textBox_asuntoEncuesta = new System.Windows.Forms.TextBox();
            this.label_buscarEncuestaPorAsunto = new System.Windows.Forms.Label();
            this.dataGridView_encuestas = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_buscarEncuesta = new System.Windows.Forms.Button();
            this.dateTimePicker_fechaEncuesta = new System.Windows.Forms.DateTimePicker();
            this.label_buscarEncuestaPorFecha = new System.Windows.Forms.Label();
            this.label_encuestasDeUsuario = new System.Windows.Forms.Label();
            this.button_borrarEncuesta = new System.Windows.Forms.Button();
            this.button_editarEncuesta = new System.Windows.Forms.Button();
            this.tabPage_enviarMensaje = new System.Windows.Forms.TabPage();
            this.textBox_enviarAlEmail = new System.Windows.Forms.TextBox();
            this.radioButton_enviarAlEmail = new System.Windows.Forms.RadioButton();
            this.radioButton_enviarComoPrivado = new System.Windows.Forms.RadioButton();
            this.button_enviarMensaje = new System.Windows.Forms.Button();
            this.label_enviarMensajeUsuario = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox_textoMensaje = new System.Windows.Forms.RichTextBox();
            this.button_cancelar = new System.Windows.Forms.Button();
            this.Edu = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_crear = new System.Windows.Forms.Button();
            this.tabControl_usuario.SuspendLayout();
            this.tabPage_datos.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPage_firmas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_firmas)).BeginInit();
            this.tabPage_galeria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_galeria)).BeginInit();
            this.tabPage_mensajes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_mensajes)).BeginInit();
            this.tabPage_peticiones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_peticiones)).BeginInit();
            this.tabPage_encuestas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_encuestas)).BeginInit();
            this.tabPage_enviarMensaje.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_usuario
            // 
            this.tabControl_usuario.Controls.Add(this.tabPage_datos);
            this.tabControl_usuario.Controls.Add(this.tabPage_firmas);
            this.tabControl_usuario.Controls.Add(this.tabPage_galeria);
            this.tabControl_usuario.Controls.Add(this.tabPage_mensajes);
            this.tabControl_usuario.Controls.Add(this.tabPage_peticiones);
            this.tabControl_usuario.Controls.Add(this.tabPage_encuestas);
            this.tabControl_usuario.Controls.Add(this.tabPage_enviarMensaje);
            this.tabControl_usuario.Location = new System.Drawing.Point(3, 3);
            this.tabControl_usuario.Name = "tabControl_usuario";
            this.tabControl_usuario.SelectedIndex = 0;
            this.tabControl_usuario.Size = new System.Drawing.Size(663, 305);
            this.tabControl_usuario.TabIndex = 34;
            // 
            // tabPage_datos
            // 
            this.tabPage_datos.Controls.Add(this.checkBox_esAdmin);
            this.tabPage_datos.Controls.Add(this.dateTimePicker_fechaDeIngreso);
            this.tabPage_datos.Controls.Add(this.label_fechaDeIngreso);
            this.tabPage_datos.Controls.Add(this.textBox_email);
            this.tabPage_datos.Controls.Add(this.label_email);
            this.tabPage_datos.Controls.Add(this.panel4);
            this.tabPage_datos.Controls.Add(this.textBox_nombre);
            this.tabPage_datos.Controls.Add(this.label_datosDeUsuario);
            this.tabPage_datos.Controls.Add(this.label_nombre);
            this.tabPage_datos.Location = new System.Drawing.Point(4, 22);
            this.tabPage_datos.Name = "tabPage_datos";
            this.tabPage_datos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_datos.Size = new System.Drawing.Size(655, 279);
            this.tabPage_datos.TabIndex = 0;
            this.tabPage_datos.Text = "Datos";
            this.tabPage_datos.UseVisualStyleBackColor = true;
            // 
            // checkBox_esAdmin
            // 
            this.checkBox_esAdmin.AutoSize = true;
            this.checkBox_esAdmin.Location = new System.Drawing.Point(214, 39);
            this.checkBox_esAdmin.Name = "checkBox_esAdmin";
            this.checkBox_esAdmin.Size = new System.Drawing.Size(102, 17);
            this.checkBox_esAdmin.TabIndex = 62;
            this.checkBox_esAdmin.Text = "es administrador";
            this.checkBox_esAdmin.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker_fechaDeIngreso
            // 
            this.dateTimePicker_fechaDeIngreso.Location = new System.Drawing.Point(104, 107);
            this.dateTimePicker_fechaDeIngreso.Name = "dateTimePicker_fechaDeIngreso";
            this.dateTimePicker_fechaDeIngreso.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_fechaDeIngreso.TabIndex = 60;
            // 
            // label_fechaDeIngreso
            // 
            this.label_fechaDeIngreso.AutoSize = true;
            this.label_fechaDeIngreso.Location = new System.Drawing.Point(4, 111);
            this.label_fechaDeIngreso.Name = "label_fechaDeIngreso";
            this.label_fechaDeIngreso.Size = new System.Drawing.Size(95, 13);
            this.label_fechaDeIngreso.TabIndex = 59;
            this.label_fechaDeIngreso.Text = "Fecha de ingreso: ";
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(64, 71);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(120, 20);
            this.textBox_email.TabIndex = 55;
            this.textBox_email.Text = "usuario@cacatua.org";
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Location = new System.Drawing.Point(5, 74);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(38, 13);
            this.label_email.TabIndex = 54;
            this.label_email.Text = "Email: ";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Location = new System.Drawing.Point(501, 20);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(116, 104);
            this.panel4.TabIndex = 53;
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(8, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(105, 92);
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // textBox_nombre
            // 
            this.textBox_nombre.Location = new System.Drawing.Point(64, 37);
            this.textBox_nombre.Name = "textBox_nombre";
            this.textBox_nombre.Size = new System.Drawing.Size(120, 20);
            this.textBox_nombre.TabIndex = 34;
            this.textBox_nombre.Text = "Edu";
            // 
            // label_datosDeUsuario
            // 
            this.label_datosDeUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label_datosDeUsuario.AutoSize = true;
            this.label_datosDeUsuario.BackColor = System.Drawing.Color.Transparent;
            this.label_datosDeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_datosDeUsuario.Location = new System.Drawing.Point(3, 3);
            this.label_datosDeUsuario.Name = "label_datosDeUsuario";
            this.label_datosDeUsuario.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label_datosDeUsuario.Size = new System.Drawing.Size(124, 20);
            this.label_datosDeUsuario.TabIndex = 33;
            this.label_datosDeUsuario.Text = "Datos de usuario: ";
            // 
            // label_nombre
            // 
            this.label_nombre.AutoSize = true;
            this.label_nombre.Location = new System.Drawing.Point(5, 40);
            this.label_nombre.Name = "label_nombre";
            this.label_nombre.Size = new System.Drawing.Size(50, 13);
            this.label_nombre.TabIndex = 32;
            this.label_nombre.Text = "Nombre: ";
            // 
            // tabPage_firmas
            // 
            this.tabPage_firmas.Controls.Add(this.radioButton_recibidasPorUsuario);
            this.tabPage_firmas.Controls.Add(this.radioButton_realizadasPorUsuario);
            this.tabPage_firmas.Controls.Add(this.dataGridView_firmas);
            this.tabPage_firmas.Controls.Add(this.dateTimePicker_fechaFirma);
            this.tabPage_firmas.Controls.Add(this.button_buscarFirma);
            this.tabPage_firmas.Controls.Add(this.textBox_autorFirma);
            this.tabPage_firmas.Controls.Add(this.label_buscarFirmaPorAutor);
            this.tabPage_firmas.Controls.Add(this.label_buscarFirmaPorFecha);
            this.tabPage_firmas.Controls.Add(this.label_firmasDeUsuario);
            this.tabPage_firmas.Controls.Add(this.button_borrarFirma);
            this.tabPage_firmas.Controls.Add(this.button_editarFirma);
            this.tabPage_firmas.Location = new System.Drawing.Point(4, 22);
            this.tabPage_firmas.Name = "tabPage_firmas";
            this.tabPage_firmas.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_firmas.Size = new System.Drawing.Size(655, 279);
            this.tabPage_firmas.TabIndex = 1;
            this.tabPage_firmas.Text = "Firmas";
            this.tabPage_firmas.UseVisualStyleBackColor = true;
            // 
            // radioButton_recibidasPorUsuario
            // 
            this.radioButton_recibidasPorUsuario.AutoSize = true;
            this.radioButton_recibidasPorUsuario.Location = new System.Drawing.Point(6, 60);
            this.radioButton_recibidasPorUsuario.Name = "radioButton_recibidasPorUsuario";
            this.radioButton_recibidasPorUsuario.Size = new System.Drawing.Size(127, 17);
            this.radioButton_recibidasPorUsuario.TabIndex = 67;
            this.radioButton_recibidasPorUsuario.Text = "Recibidas por usuario";
            this.radioButton_recibidasPorUsuario.UseVisualStyleBackColor = true;
            // 
            // radioButton_realizadasPorUsuario
            // 
            this.radioButton_realizadasPorUsuario.AutoSize = true;
            this.radioButton_realizadasPorUsuario.Checked = true;
            this.radioButton_realizadasPorUsuario.Location = new System.Drawing.Point(6, 33);
            this.radioButton_realizadasPorUsuario.Name = "radioButton_realizadasPorUsuario";
            this.radioButton_realizadasPorUsuario.Size = new System.Drawing.Size(132, 17);
            this.radioButton_realizadasPorUsuario.TabIndex = 66;
            this.radioButton_realizadasPorUsuario.TabStop = true;
            this.radioButton_realizadasPorUsuario.Text = "Realizadas por usuario";
            this.radioButton_realizadasPorUsuario.UseVisualStyleBackColor = true;
            // 
            // dataGridView_firmas
            // 
            this.dataGridView_firmas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_firmas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.autorFirma,
            this.destinatarioFirma,
            this.fechaFirma});
            this.dataGridView_firmas.Location = new System.Drawing.Point(217, 12);
            this.dataGridView_firmas.Name = "dataGridView_firmas";
            this.dataGridView_firmas.RowHeadersVisible = false;
            this.dataGridView_firmas.Size = new System.Drawing.Size(383, 253);
            this.dataGridView_firmas.TabIndex = 62;
            // 
            // autorFirma
            // 
            this.autorFirma.HeaderText = "Autor";
            this.autorFirma.Name = "autorFirma";
            this.autorFirma.Width = 150;
            // 
            // destinatarioFirma
            // 
            this.destinatarioFirma.HeaderText = "Destinatario";
            this.destinatarioFirma.Name = "destinatarioFirma";
            this.destinatarioFirma.Width = 130;
            // 
            // fechaFirma
            // 
            this.fechaFirma.HeaderText = "Fecha";
            this.fechaFirma.Name = "fechaFirma";
            // 
            // dateTimePicker_fechaFirma
            // 
            this.dateTimePicker_fechaFirma.Location = new System.Drawing.Point(6, 114);
            this.dateTimePicker_fechaFirma.Name = "dateTimePicker_fechaFirma";
            this.dateTimePicker_fechaFirma.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_fechaFirma.TabIndex = 61;
            // 
            // button_buscarFirma
            // 
            this.button_buscarFirma.Location = new System.Drawing.Point(58, 242);
            this.button_buscarFirma.Name = "button_buscarFirma";
            this.button_buscarFirma.Size = new System.Drawing.Size(75, 23);
            this.button_buscarFirma.TabIndex = 42;
            this.button_buscarFirma.Text = "Buscar";
            this.button_buscarFirma.UseVisualStyleBackColor = true;
            // 
            // textBox_autorFirma
            // 
            this.textBox_autorFirma.Location = new System.Drawing.Point(7, 169);
            this.textBox_autorFirma.Name = "textBox_autorFirma";
            this.textBox_autorFirma.Size = new System.Drawing.Size(159, 20);
            this.textBox_autorFirma.TabIndex = 41;
            this.textBox_autorFirma.Text = "Peter Mazinger Rufai";
            // 
            // label_buscarFirmaPorAutor
            // 
            this.label_buscarFirmaPorAutor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label_buscarFirmaPorAutor.AutoSize = true;
            this.label_buscarFirmaPorAutor.BackColor = System.Drawing.Color.Transparent;
            this.label_buscarFirmaPorAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_buscarFirmaPorAutor.Location = new System.Drawing.Point(3, 140);
            this.label_buscarFirmaPorAutor.Name = "label_buscarFirmaPorAutor";
            this.label_buscarFirmaPorAutor.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label_buscarFirmaPorAutor.Size = new System.Drawing.Size(106, 20);
            this.label_buscarFirmaPorAutor.TabIndex = 40;
            this.label_buscarFirmaPorAutor.Text = "Buscar por autor : ";
            // 
            // label_buscarFirmaPorFecha
            // 
            this.label_buscarFirmaPorFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label_buscarFirmaPorFecha.AutoSize = true;
            this.label_buscarFirmaPorFecha.BackColor = System.Drawing.Color.Transparent;
            this.label_buscarFirmaPorFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_buscarFirmaPorFecha.Location = new System.Drawing.Point(3, 84);
            this.label_buscarFirmaPorFecha.Name = "label_buscarFirmaPorFecha";
            this.label_buscarFirmaPorFecha.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label_buscarFirmaPorFecha.Size = new System.Drawing.Size(199, 20);
            this.label_buscarFirmaPorFecha.TabIndex = 35;
            this.label_buscarFirmaPorFecha.Text = "Buscar por fecha (dia / mes / año) : ";
            // 
            // label_firmasDeUsuario
            // 
            this.label_firmasDeUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label_firmasDeUsuario.AutoSize = true;
            this.label_firmasDeUsuario.BackColor = System.Drawing.Color.Transparent;
            this.label_firmasDeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_firmasDeUsuario.Location = new System.Drawing.Point(3, 3);
            this.label_firmasDeUsuario.Name = "label_firmasDeUsuario";
            this.label_firmasDeUsuario.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label_firmasDeUsuario.Size = new System.Drawing.Size(131, 20);
            this.label_firmasDeUsuario.TabIndex = 34;
            this.label_firmasDeUsuario.Text = "Firmas de usuario: ";
            // 
            // button_borrarFirma
            // 
            this.button_borrarFirma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_borrarFirma.FlatAppearance.BorderSize = 0;
            this.button_borrarFirma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_borrarFirma.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_borrarFirma.Image = global::cacatUA.Properties.Resources.close;
            this.button_borrarFirma.Location = new System.Drawing.Point(605, 69);
            this.button_borrarFirma.Name = "button_borrarFirma";
            this.button_borrarFirma.Size = new System.Drawing.Size(35, 35);
            this.button_borrarFirma.TabIndex = 65;
            this.button_borrarFirma.Tag = "Eliminar hilo seleccionado";
            this.button_borrarFirma.UseVisualStyleBackColor = true;
            // 
            // button_editarFirma
            // 
            this.button_editarFirma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_editarFirma.FlatAppearance.BorderSize = 0;
            this.button_editarFirma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_editarFirma.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_editarFirma.Image = global::cacatUA.Properties.Resources.tool;
            this.button_editarFirma.Location = new System.Drawing.Point(605, 28);
            this.button_editarFirma.Name = "button_editarFirma";
            this.button_editarFirma.Size = new System.Drawing.Size(35, 35);
            this.button_editarFirma.TabIndex = 64;
            this.button_editarFirma.Tag = "Modificar hilo seleccionado";
            this.button_editarFirma.UseVisualStyleBackColor = true;
            this.button_editarFirma.Click += new System.EventHandler(this.button_editarUsuarioFirma_Click);
            // 
            // tabPage_galeria
            // 
            this.tabPage_galeria.Controls.Add(this.button_borrarGaleria);
            this.tabPage_galeria.Controls.Add(this.button_editarGaleria);
            this.tabPage_galeria.Controls.Add(this.dataGridView_galeria);
            this.tabPage_galeria.Controls.Add(this.textBox_tituloGaleria);
            this.tabPage_galeria.Controls.Add(this.label_buscarGaleriaPorTitulo);
            this.tabPage_galeria.Controls.Add(this.dateTimePicker_fechaGaleria);
            this.tabPage_galeria.Controls.Add(this.button_buscarGaleria);
            this.tabPage_galeria.Controls.Add(this.textBox_autorGaleria);
            this.tabPage_galeria.Controls.Add(this.label_buscarGaleriaPorAutor);
            this.tabPage_galeria.Controls.Add(this.label6);
            this.tabPage_galeria.Controls.Add(this.label_fotosDeUsuario);
            this.tabPage_galeria.Location = new System.Drawing.Point(4, 22);
            this.tabPage_galeria.Name = "tabPage_galeria";
            this.tabPage_galeria.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_galeria.Size = new System.Drawing.Size(655, 279);
            this.tabPage_galeria.TabIndex = 2;
            this.tabPage_galeria.Text = "Galería";
            this.tabPage_galeria.UseVisualStyleBackColor = true;
            // 
            // button_borrarGaleria
            // 
            this.button_borrarGaleria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_borrarGaleria.FlatAppearance.BorderSize = 0;
            this.button_borrarGaleria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_borrarGaleria.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_borrarGaleria.Image = global::cacatUA.Properties.Resources.close;
            this.button_borrarGaleria.Location = new System.Drawing.Point(605, 69);
            this.button_borrarGaleria.Name = "button_borrarGaleria";
            this.button_borrarGaleria.Size = new System.Drawing.Size(35, 35);
            this.button_borrarGaleria.TabIndex = 72;
            this.button_borrarGaleria.Tag = "Eliminar hilo seleccionado";
            this.button_borrarGaleria.UseVisualStyleBackColor = true;
            // 
            // button_editarGaleria
            // 
            this.button_editarGaleria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_editarGaleria.FlatAppearance.BorderSize = 0;
            this.button_editarGaleria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_editarGaleria.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_editarGaleria.Image = global::cacatUA.Properties.Resources.tool;
            this.button_editarGaleria.Location = new System.Drawing.Point(605, 28);
            this.button_editarGaleria.Name = "button_editarGaleria";
            this.button_editarGaleria.Size = new System.Drawing.Size(35, 35);
            this.button_editarGaleria.TabIndex = 71;
            this.button_editarGaleria.Tag = "Modificar hilo seleccionado";
            this.button_editarGaleria.UseVisualStyleBackColor = true;
            this.button_editarGaleria.Click += new System.EventHandler(this.button_editarUsuarioGaleria_Click);
            // 
            // dataGridView_galeria
            // 
            this.dataGridView_galeria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_galeria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridView_galeria.Location = new System.Drawing.Point(217, 12);
            this.dataGridView_galeria.Name = "dataGridView_galeria";
            this.dataGridView_galeria.RowHeadersVisible = false;
            this.dataGridView_galeria.Size = new System.Drawing.Size(383, 253);
            this.dataGridView_galeria.TabIndex = 69;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Autor";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Título";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 130;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // textBox_tituloGaleria
            // 
            this.textBox_tituloGaleria.Location = new System.Drawing.Point(8, 170);
            this.textBox_tituloGaleria.Name = "textBox_tituloGaleria";
            this.textBox_tituloGaleria.Size = new System.Drawing.Size(159, 20);
            this.textBox_tituloGaleria.TabIndex = 68;
            this.textBox_tituloGaleria.Text = "El toro y la luna";
            // 
            // label_buscarGaleriaPorTitulo
            // 
            this.label_buscarGaleriaPorTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label_buscarGaleriaPorTitulo.AutoSize = true;
            this.label_buscarGaleriaPorTitulo.BackColor = System.Drawing.Color.Transparent;
            this.label_buscarGaleriaPorTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_buscarGaleriaPorTitulo.Location = new System.Drawing.Point(5, 139);
            this.label_buscarGaleriaPorTitulo.Name = "label_buscarGaleriaPorTitulo";
            this.label_buscarGaleriaPorTitulo.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label_buscarGaleriaPorTitulo.Size = new System.Drawing.Size(98, 20);
            this.label_buscarGaleriaPorTitulo.TabIndex = 67;
            this.label_buscarGaleriaPorTitulo.Text = "Buscar por título:";
            // 
            // dateTimePicker_fechaGaleria
            // 
            this.dateTimePicker_fechaGaleria.Location = new System.Drawing.Point(7, 57);
            this.dateTimePicker_fechaGaleria.Name = "dateTimePicker_fechaGaleria";
            this.dateTimePicker_fechaGaleria.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_fechaGaleria.TabIndex = 66;
            // 
            // button_buscarGaleria
            // 
            this.button_buscarGaleria.Location = new System.Drawing.Point(58, 242);
            this.button_buscarGaleria.Name = "button_buscarGaleria";
            this.button_buscarGaleria.Size = new System.Drawing.Size(75, 23);
            this.button_buscarGaleria.TabIndex = 65;
            this.button_buscarGaleria.Text = "Buscar";
            this.button_buscarGaleria.UseVisualStyleBackColor = true;
            // 
            // textBox_autorGaleria
            // 
            this.textBox_autorGaleria.Location = new System.Drawing.Point(8, 112);
            this.textBox_autorGaleria.Name = "textBox_autorGaleria";
            this.textBox_autorGaleria.Size = new System.Drawing.Size(159, 20);
            this.textBox_autorGaleria.TabIndex = 64;
            this.textBox_autorGaleria.Text = "Peter Mazinger Rufai";
            // 
            // label_buscarGaleriaPorAutor
            // 
            this.label_buscarGaleriaPorAutor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label_buscarGaleriaPorAutor.AutoSize = true;
            this.label_buscarGaleriaPorAutor.BackColor = System.Drawing.Color.Transparent;
            this.label_buscarGaleriaPorAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_buscarGaleriaPorAutor.Location = new System.Drawing.Point(4, 83);
            this.label_buscarGaleriaPorAutor.Name = "label_buscarGaleriaPorAutor";
            this.label_buscarGaleriaPorAutor.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label_buscarGaleriaPorAutor.Size = new System.Drawing.Size(106, 20);
            this.label_buscarGaleriaPorAutor.TabIndex = 63;
            this.label_buscarGaleriaPorAutor.Text = "Buscar por autor : ";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 27);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label6.Size = new System.Drawing.Size(199, 20);
            this.label6.TabIndex = 62;
            this.label6.Text = "Buscar por fecha (dia / mes / año) : ";
            // 
            // label_fotosDeUsuario
            // 
            this.label_fotosDeUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label_fotosDeUsuario.AutoSize = true;
            this.label_fotosDeUsuario.BackColor = System.Drawing.Color.Transparent;
            this.label_fotosDeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_fotosDeUsuario.Location = new System.Drawing.Point(3, 3);
            this.label_fotosDeUsuario.Name = "label_fotosDeUsuario";
            this.label_fotosDeUsuario.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label_fotosDeUsuario.Size = new System.Drawing.Size(122, 20);
            this.label_fotosDeUsuario.TabIndex = 46;
            this.label_fotosDeUsuario.Text = "Fotos de usuario: ";
            // 
            // tabPage_mensajes
            // 
            this.tabPage_mensajes.Controls.Add(this.button_borrarMensaje);
            this.tabPage_mensajes.Controls.Add(this.button_editarMensaje);
            this.tabPage_mensajes.Controls.Add(this.dataGridView_mensajes);
            this.tabPage_mensajes.Controls.Add(this.textBox_tituloMensaje);
            this.tabPage_mensajes.Controls.Add(this.label_buscarMensajePorTitulo);
            this.tabPage_mensajes.Controls.Add(this.dateTimePicker_fechaMensaje);
            this.tabPage_mensajes.Controls.Add(this.button_buscarMensaje);
            this.tabPage_mensajes.Controls.Add(this.label_buscarMensajePorFecha);
            this.tabPage_mensajes.Controls.Add(this.label_mensajesDeUsuario);
            this.tabPage_mensajes.Location = new System.Drawing.Point(4, 22);
            this.tabPage_mensajes.Name = "tabPage_mensajes";
            this.tabPage_mensajes.Size = new System.Drawing.Size(655, 279);
            this.tabPage_mensajes.TabIndex = 3;
            this.tabPage_mensajes.Text = "Mensajes";
            this.tabPage_mensajes.UseVisualStyleBackColor = true;
            // 
            // button_borrarMensaje
            // 
            this.button_borrarMensaje.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_borrarMensaje.FlatAppearance.BorderSize = 0;
            this.button_borrarMensaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_borrarMensaje.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_borrarMensaje.Image = global::cacatUA.Properties.Resources.close;
            this.button_borrarMensaje.Location = new System.Drawing.Point(605, 69);
            this.button_borrarMensaje.Name = "button_borrarMensaje";
            this.button_borrarMensaje.Size = new System.Drawing.Size(35, 35);
            this.button_borrarMensaje.TabIndex = 79;
            this.button_borrarMensaje.Tag = "Eliminar hilo seleccionado";
            this.button_borrarMensaje.UseVisualStyleBackColor = true;
            // 
            // button_editarMensaje
            // 
            this.button_editarMensaje.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_editarMensaje.FlatAppearance.BorderSize = 0;
            this.button_editarMensaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_editarMensaje.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_editarMensaje.Image = global::cacatUA.Properties.Resources.tool;
            this.button_editarMensaje.Location = new System.Drawing.Point(605, 28);
            this.button_editarMensaje.Name = "button_editarMensaje";
            this.button_editarMensaje.Size = new System.Drawing.Size(35, 35);
            this.button_editarMensaje.TabIndex = 78;
            this.button_editarMensaje.Tag = "Modificar hilo seleccionado";
            this.button_editarMensaje.UseVisualStyleBackColor = true;
            this.button_editarMensaje.Click += new System.EventHandler(this.button_editarUsuarioMensaje_Click);
            // 
            // dataGridView_mensajes
            // 
            this.dataGridView_mensajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_mensajes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataGridView_mensajes.Location = new System.Drawing.Point(217, 12);
            this.dataGridView_mensajes.Name = "dataGridView_mensajes";
            this.dataGridView_mensajes.RowHeadersVisible = false;
            this.dataGridView_mensajes.Size = new System.Drawing.Size(383, 253);
            this.dataGridView_mensajes.TabIndex = 76;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Autor";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Destinatario";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 130;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // textBox_tituloMensaje
            // 
            this.textBox_tituloMensaje.Location = new System.Drawing.Point(8, 114);
            this.textBox_tituloMensaje.Name = "textBox_tituloMensaje";
            this.textBox_tituloMensaje.Size = new System.Drawing.Size(159, 20);
            this.textBox_tituloMensaje.TabIndex = 75;
            this.textBox_tituloMensaje.Text = "El toro y la luna";
            // 
            // label_buscarMensajePorTitulo
            // 
            this.label_buscarMensajePorTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label_buscarMensajePorTitulo.AutoSize = true;
            this.label_buscarMensajePorTitulo.BackColor = System.Drawing.Color.Transparent;
            this.label_buscarMensajePorTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_buscarMensajePorTitulo.Location = new System.Drawing.Point(5, 83);
            this.label_buscarMensajePorTitulo.Name = "label_buscarMensajePorTitulo";
            this.label_buscarMensajePorTitulo.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label_buscarMensajePorTitulo.Size = new System.Drawing.Size(98, 20);
            this.label_buscarMensajePorTitulo.TabIndex = 74;
            this.label_buscarMensajePorTitulo.Text = "Buscar por título:";
            // 
            // dateTimePicker_fechaMensaje
            // 
            this.dateTimePicker_fechaMensaje.Location = new System.Drawing.Point(7, 60);
            this.dateTimePicker_fechaMensaje.Name = "dateTimePicker_fechaMensaje";
            this.dateTimePicker_fechaMensaje.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_fechaMensaje.TabIndex = 73;
            // 
            // button_buscarMensaje
            // 
            this.button_buscarMensaje.Location = new System.Drawing.Point(58, 242);
            this.button_buscarMensaje.Name = "button_buscarMensaje";
            this.button_buscarMensaje.Size = new System.Drawing.Size(75, 23);
            this.button_buscarMensaje.TabIndex = 72;
            this.button_buscarMensaje.Text = "Buscar";
            this.button_buscarMensaje.UseVisualStyleBackColor = true;
            // 
            // label_buscarMensajePorFecha
            // 
            this.label_buscarMensajePorFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label_buscarMensajePorFecha.AutoSize = true;
            this.label_buscarMensajePorFecha.BackColor = System.Drawing.Color.Transparent;
            this.label_buscarMensajePorFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_buscarMensajePorFecha.Location = new System.Drawing.Point(4, 30);
            this.label_buscarMensajePorFecha.Name = "label_buscarMensajePorFecha";
            this.label_buscarMensajePorFecha.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label_buscarMensajePorFecha.Size = new System.Drawing.Size(199, 20);
            this.label_buscarMensajePorFecha.TabIndex = 69;
            this.label_buscarMensajePorFecha.Text = "Buscar por fecha (dia / mes / año) : ";
            // 
            // label_mensajesDeUsuario
            // 
            this.label_mensajesDeUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label_mensajesDeUsuario.AutoSize = true;
            this.label_mensajesDeUsuario.BackColor = System.Drawing.Color.Transparent;
            this.label_mensajesDeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_mensajesDeUsuario.Location = new System.Drawing.Point(3, 3);
            this.label_mensajesDeUsuario.Name = "label_mensajesDeUsuario";
            this.label_mensajesDeUsuario.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label_mensajesDeUsuario.Size = new System.Drawing.Size(149, 20);
            this.label_mensajesDeUsuario.TabIndex = 46;
            this.label_mensajesDeUsuario.Text = "Mensajes de usuario: ";
            // 
            // tabPage_peticiones
            // 
            this.tabPage_peticiones.Controls.Add(this.button_borrarPeticion);
            this.tabPage_peticiones.Controls.Add(this.button_editarPeticion);
            this.tabPage_peticiones.Controls.Add(this.textBox_asuntoPeticion);
            this.tabPage_peticiones.Controls.Add(this.label_buscarPeticionPorAsunto);
            this.tabPage_peticiones.Controls.Add(this.button_buscarPeticion);
            this.tabPage_peticiones.Controls.Add(this.dateTimePicker_fechaPeticion);
            this.tabPage_peticiones.Controls.Add(this.label_buscarPeticionPorFecha);
            this.tabPage_peticiones.Controls.Add(this.dataGridView_peticiones);
            this.tabPage_peticiones.Controls.Add(this.label_peticionesDeUsuario);
            this.tabPage_peticiones.Location = new System.Drawing.Point(4, 22);
            this.tabPage_peticiones.Name = "tabPage_peticiones";
            this.tabPage_peticiones.Size = new System.Drawing.Size(655, 279);
            this.tabPage_peticiones.TabIndex = 4;
            this.tabPage_peticiones.Text = "Peticiones";
            this.tabPage_peticiones.UseVisualStyleBackColor = true;
            // 
            // button_borrarPeticion
            // 
            this.button_borrarPeticion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_borrarPeticion.FlatAppearance.BorderSize = 0;
            this.button_borrarPeticion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_borrarPeticion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_borrarPeticion.Image = global::cacatUA.Properties.Resources.close;
            this.button_borrarPeticion.Location = new System.Drawing.Point(605, 69);
            this.button_borrarPeticion.Name = "button_borrarPeticion";
            this.button_borrarPeticion.Size = new System.Drawing.Size(35, 35);
            this.button_borrarPeticion.TabIndex = 98;
            this.button_borrarPeticion.Tag = "Eliminar hilo seleccionado";
            this.button_borrarPeticion.UseVisualStyleBackColor = true;
            // 
            // button_editarPeticion
            // 
            this.button_editarPeticion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_editarPeticion.FlatAppearance.BorderSize = 0;
            this.button_editarPeticion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_editarPeticion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_editarPeticion.Image = global::cacatUA.Properties.Resources.tool;
            this.button_editarPeticion.Location = new System.Drawing.Point(605, 28);
            this.button_editarPeticion.Name = "button_editarPeticion";
            this.button_editarPeticion.Size = new System.Drawing.Size(35, 35);
            this.button_editarPeticion.TabIndex = 97;
            this.button_editarPeticion.Tag = "Modificar hilo seleccionado";
            this.button_editarPeticion.UseVisualStyleBackColor = true;
            this.button_editarPeticion.Click += new System.EventHandler(this.button_editarUsuarioPeticion_Click);
            // 
            // textBox_asuntoPeticion
            // 
            this.textBox_asuntoPeticion.Location = new System.Drawing.Point(6, 127);
            this.textBox_asuntoPeticion.Name = "textBox_asuntoPeticion";
            this.textBox_asuntoPeticion.Size = new System.Drawing.Size(159, 20);
            this.textBox_asuntoPeticion.TabIndex = 96;
            this.textBox_asuntoPeticion.Text = "El toro y la luna";
            // 
            // label_buscarPeticionPorAsunto
            // 
            this.label_buscarPeticionPorAsunto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label_buscarPeticionPorAsunto.AutoSize = true;
            this.label_buscarPeticionPorAsunto.BackColor = System.Drawing.Color.Transparent;
            this.label_buscarPeticionPorAsunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_buscarPeticionPorAsunto.Location = new System.Drawing.Point(3, 96);
            this.label_buscarPeticionPorAsunto.Name = "label_buscarPeticionPorAsunto";
            this.label_buscarPeticionPorAsunto.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label_buscarPeticionPorAsunto.Size = new System.Drawing.Size(109, 20);
            this.label_buscarPeticionPorAsunto.TabIndex = 95;
            this.label_buscarPeticionPorAsunto.Text = "Buscar por asunto:";
            // 
            // button_buscarPeticion
            // 
            this.button_buscarPeticion.Location = new System.Drawing.Point(58, 242);
            this.button_buscarPeticion.Name = "button_buscarPeticion";
            this.button_buscarPeticion.Size = new System.Drawing.Size(75, 23);
            this.button_buscarPeticion.TabIndex = 94;
            this.button_buscarPeticion.Text = "Buscar";
            this.button_buscarPeticion.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker_fechaPeticion
            // 
            this.dateTimePicker_fechaPeticion.Location = new System.Drawing.Point(6, 66);
            this.dateTimePicker_fechaPeticion.Name = "dateTimePicker_fechaPeticion";
            this.dateTimePicker_fechaPeticion.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_fechaPeticion.TabIndex = 93;
            // 
            // label_buscarPeticionPorFecha
            // 
            this.label_buscarPeticionPorFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label_buscarPeticionPorFecha.AutoSize = true;
            this.label_buscarPeticionPorFecha.BackColor = System.Drawing.Color.Transparent;
            this.label_buscarPeticionPorFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_buscarPeticionPorFecha.Location = new System.Drawing.Point(3, 36);
            this.label_buscarPeticionPorFecha.Name = "label_buscarPeticionPorFecha";
            this.label_buscarPeticionPorFecha.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label_buscarPeticionPorFecha.Size = new System.Drawing.Size(199, 20);
            this.label_buscarPeticionPorFecha.TabIndex = 92;
            this.label_buscarPeticionPorFecha.Text = "Buscar por fecha (dia / mes / año) : ";
            // 
            // dataGridView_peticiones
            // 
            this.dataGridView_peticiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_peticiones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dataGridView_peticiones.Location = new System.Drawing.Point(217, 12);
            this.dataGridView_peticiones.Name = "dataGridView_peticiones";
            this.dataGridView_peticiones.RowHeadersVisible = false;
            this.dataGridView_peticiones.Size = new System.Drawing.Size(383, 253);
            this.dataGridView_peticiones.TabIndex = 88;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Asunto";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 200;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 200;
            // 
            // label_peticionesDeUsuario
            // 
            this.label_peticionesDeUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label_peticionesDeUsuario.AutoSize = true;
            this.label_peticionesDeUsuario.BackColor = System.Drawing.Color.Transparent;
            this.label_peticionesDeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_peticionesDeUsuario.Location = new System.Drawing.Point(3, 3);
            this.label_peticionesDeUsuario.Name = "label_peticionesDeUsuario";
            this.label_peticionesDeUsuario.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label_peticionesDeUsuario.Size = new System.Drawing.Size(154, 20);
            this.label_peticionesDeUsuario.TabIndex = 46;
            this.label_peticionesDeUsuario.Text = "Peticiones de usuario: ";
            // 
            // tabPage_encuestas
            // 
            this.tabPage_encuestas.Controls.Add(this.textBox_asuntoEncuesta);
            this.tabPage_encuestas.Controls.Add(this.label_buscarEncuestaPorAsunto);
            this.tabPage_encuestas.Controls.Add(this.dataGridView_encuestas);
            this.tabPage_encuestas.Controls.Add(this.button_buscarEncuesta);
            this.tabPage_encuestas.Controls.Add(this.dateTimePicker_fechaEncuesta);
            this.tabPage_encuestas.Controls.Add(this.label_buscarEncuestaPorFecha);
            this.tabPage_encuestas.Controls.Add(this.label_encuestasDeUsuario);
            this.tabPage_encuestas.Controls.Add(this.button_borrarEncuesta);
            this.tabPage_encuestas.Controls.Add(this.button_editarEncuesta);
            this.tabPage_encuestas.Location = new System.Drawing.Point(4, 22);
            this.tabPage_encuestas.Name = "tabPage_encuestas";
            this.tabPage_encuestas.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_encuestas.Size = new System.Drawing.Size(655, 279);
            this.tabPage_encuestas.TabIndex = 6;
            this.tabPage_encuestas.Text = "Encuestas";
            this.tabPage_encuestas.UseVisualStyleBackColor = true;
            // 
            // textBox_asuntoEncuesta
            // 
            this.textBox_asuntoEncuesta.Location = new System.Drawing.Point(6, 125);
            this.textBox_asuntoEncuesta.Name = "textBox_asuntoEncuesta";
            this.textBox_asuntoEncuesta.Size = new System.Drawing.Size(159, 20);
            this.textBox_asuntoEncuesta.TabIndex = 91;
            this.textBox_asuntoEncuesta.Text = "El toro y la luna";
            // 
            // label_buscarEncuestaPorAsunto
            // 
            this.label_buscarEncuestaPorAsunto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label_buscarEncuestaPorAsunto.AutoSize = true;
            this.label_buscarEncuestaPorAsunto.BackColor = System.Drawing.Color.Transparent;
            this.label_buscarEncuestaPorAsunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_buscarEncuestaPorAsunto.Location = new System.Drawing.Point(3, 94);
            this.label_buscarEncuestaPorAsunto.Name = "label_buscarEncuestaPorAsunto";
            this.label_buscarEncuestaPorAsunto.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label_buscarEncuestaPorAsunto.Size = new System.Drawing.Size(109, 20);
            this.label_buscarEncuestaPorAsunto.TabIndex = 90;
            this.label_buscarEncuestaPorAsunto.Text = "Buscar por asunto:";
            // 
            // dataGridView_encuestas
            // 
            this.dataGridView_encuestas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_encuestas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn12});
            this.dataGridView_encuestas.Location = new System.Drawing.Point(217, 12);
            this.dataGridView_encuestas.Name = "dataGridView_encuestas";
            this.dataGridView_encuestas.RowHeadersVisible = false;
            this.dataGridView_encuestas.Size = new System.Drawing.Size(383, 253);
            this.dataGridView_encuestas.TabIndex = 87;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "Asunto";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 200;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 200;
            // 
            // button_buscarEncuesta
            // 
            this.button_buscarEncuesta.Location = new System.Drawing.Point(58, 242);
            this.button_buscarEncuesta.Name = "button_buscarEncuesta";
            this.button_buscarEncuesta.Size = new System.Drawing.Size(75, 23);
            this.button_buscarEncuesta.TabIndex = 86;
            this.button_buscarEncuesta.Text = "Buscar";
            this.button_buscarEncuesta.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker_fechaEncuesta
            // 
            this.dateTimePicker_fechaEncuesta.Location = new System.Drawing.Point(6, 64);
            this.dateTimePicker_fechaEncuesta.Name = "dateTimePicker_fechaEncuesta";
            this.dateTimePicker_fechaEncuesta.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_fechaEncuesta.TabIndex = 85;
            // 
            // label_buscarEncuestaPorFecha
            // 
            this.label_buscarEncuestaPorFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label_buscarEncuestaPorFecha.AutoSize = true;
            this.label_buscarEncuestaPorFecha.BackColor = System.Drawing.Color.Transparent;
            this.label_buscarEncuestaPorFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_buscarEncuestaPorFecha.Location = new System.Drawing.Point(3, 34);
            this.label_buscarEncuestaPorFecha.Name = "label_buscarEncuestaPorFecha";
            this.label_buscarEncuestaPorFecha.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label_buscarEncuestaPorFecha.Size = new System.Drawing.Size(199, 20);
            this.label_buscarEncuestaPorFecha.TabIndex = 84;
            this.label_buscarEncuestaPorFecha.Text = "Buscar por fecha (dia / mes / año) : ";
            // 
            // label_encuestasDeUsuario
            // 
            this.label_encuestasDeUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label_encuestasDeUsuario.AutoSize = true;
            this.label_encuestasDeUsuario.BackColor = System.Drawing.Color.Transparent;
            this.label_encuestasDeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_encuestasDeUsuario.Location = new System.Drawing.Point(3, 3);
            this.label_encuestasDeUsuario.Name = "label_encuestasDeUsuario";
            this.label_encuestasDeUsuario.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label_encuestasDeUsuario.Size = new System.Drawing.Size(153, 20);
            this.label_encuestasDeUsuario.TabIndex = 83;
            this.label_encuestasDeUsuario.Text = "Encuestas de usuario: ";
            // 
            // button_borrarEncuesta
            // 
            this.button_borrarEncuesta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_borrarEncuesta.FlatAppearance.BorderSize = 0;
            this.button_borrarEncuesta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_borrarEncuesta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_borrarEncuesta.Image = global::cacatUA.Properties.Resources.close;
            this.button_borrarEncuesta.Location = new System.Drawing.Point(605, 69);
            this.button_borrarEncuesta.Name = "button_borrarEncuesta";
            this.button_borrarEncuesta.Size = new System.Drawing.Size(35, 35);
            this.button_borrarEncuesta.TabIndex = 89;
            this.button_borrarEncuesta.Tag = "Eliminar hilo seleccionado";
            this.button_borrarEncuesta.UseVisualStyleBackColor = true;
            // 
            // button_editarEncuesta
            // 
            this.button_editarEncuesta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_editarEncuesta.FlatAppearance.BorderSize = 0;
            this.button_editarEncuesta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_editarEncuesta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_editarEncuesta.Image = global::cacatUA.Properties.Resources.tool;
            this.button_editarEncuesta.Location = new System.Drawing.Point(605, 28);
            this.button_editarEncuesta.Name = "button_editarEncuesta";
            this.button_editarEncuesta.Size = new System.Drawing.Size(35, 35);
            this.button_editarEncuesta.TabIndex = 88;
            this.button_editarEncuesta.Tag = "Modificar hilo seleccionado";
            this.button_editarEncuesta.UseVisualStyleBackColor = true;
            this.button_editarEncuesta.Click += new System.EventHandler(this.button_editarUsuarioEncuesta_Click);
            // 
            // tabPage_enviarMensaje
            // 
            this.tabPage_enviarMensaje.Controls.Add(this.textBox_enviarAlEmail);
            this.tabPage_enviarMensaje.Controls.Add(this.radioButton_enviarAlEmail);
            this.tabPage_enviarMensaje.Controls.Add(this.radioButton_enviarComoPrivado);
            this.tabPage_enviarMensaje.Controls.Add(this.button_enviarMensaje);
            this.tabPage_enviarMensaje.Controls.Add(this.label_enviarMensajeUsuario);
            this.tabPage_enviarMensaje.Controls.Add(this.button1);
            this.tabPage_enviarMensaje.Controls.Add(this.richTextBox_textoMensaje);
            this.tabPage_enviarMensaje.Location = new System.Drawing.Point(4, 22);
            this.tabPage_enviarMensaje.Name = "tabPage_enviarMensaje";
            this.tabPage_enviarMensaje.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_enviarMensaje.Size = new System.Drawing.Size(655, 279);
            this.tabPage_enviarMensaje.TabIndex = 5;
            this.tabPage_enviarMensaje.Text = "Enviar mensaje";
            this.tabPage_enviarMensaje.UseVisualStyleBackColor = true;
            // 
            // textBox_enviarAlEmail
            // 
            this.textBox_enviarAlEmail.Location = new System.Drawing.Point(324, 42);
            this.textBox_enviarAlEmail.Name = "textBox_enviarAlEmail";
            this.textBox_enviarAlEmail.Size = new System.Drawing.Size(120, 20);
            this.textBox_enviarAlEmail.TabIndex = 66;
            this.textBox_enviarAlEmail.Text = "usuario@cacatua.org";
            // 
            // radioButton_enviarAlEmail
            // 
            this.radioButton_enviarAlEmail.AutoSize = true;
            this.radioButton_enviarAlEmail.Location = new System.Drawing.Point(223, 44);
            this.radioButton_enviarAlEmail.Name = "radioButton_enviarAlEmail";
            this.radioButton_enviarAlEmail.Size = new System.Drawing.Size(95, 17);
            this.radioButton_enviarAlEmail.TabIndex = 65;
            this.radioButton_enviarAlEmail.Text = "Envíar al email";
            this.radioButton_enviarAlEmail.UseVisualStyleBackColor = true;
            // 
            // radioButton_enviarComoPrivado
            // 
            this.radioButton_enviarComoPrivado.AutoSize = true;
            this.radioButton_enviarComoPrivado.Checked = true;
            this.radioButton_enviarComoPrivado.Location = new System.Drawing.Point(38, 44);
            this.radioButton_enviarComoPrivado.Name = "radioButton_enviarComoPrivado";
            this.radioButton_enviarComoPrivado.Size = new System.Drawing.Size(124, 17);
            this.radioButton_enviarComoPrivado.TabIndex = 64;
            this.radioButton_enviarComoPrivado.TabStop = true;
            this.radioButton_enviarComoPrivado.Text = "Envíar como privado";
            this.radioButton_enviarComoPrivado.UseVisualStyleBackColor = true;
            // 
            // button_enviarMensaje
            // 
            this.button_enviarMensaje.Location = new System.Drawing.Point(292, 236);
            this.button_enviarMensaje.Name = "button_enviarMensaje";
            this.button_enviarMensaje.Size = new System.Drawing.Size(75, 23);
            this.button_enviarMensaje.TabIndex = 63;
            this.button_enviarMensaje.Text = "Enviar";
            this.button_enviarMensaje.UseVisualStyleBackColor = true;
            // 
            // label_enviarMensajeUsuario
            // 
            this.label_enviarMensajeUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label_enviarMensajeUsuario.AutoSize = true;
            this.label_enviarMensajeUsuario.BackColor = System.Drawing.Color.Transparent;
            this.label_enviarMensajeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_enviarMensajeUsuario.Location = new System.Drawing.Point(3, 3);
            this.label_enviarMensajeUsuario.Name = "label_enviarMensajeUsuario";
            this.label_enviarMensajeUsuario.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label_enviarMensajeUsuario.Size = new System.Drawing.Size(186, 20);
            this.label_enviarMensajeUsuario.TabIndex = 62;
            this.label_enviarMensajeUsuario.Text = "Enviar mensaje al usuario : ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(206, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(261, 23);
            this.button1.TabIndex = 60;
            this.button1.Text = "Enviar mensaje al usuario";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // richTextBox_textoMensaje
            // 
            this.richTextBox_textoMensaje.Location = new System.Drawing.Point(6, 80);
            this.richTextBox_textoMensaje.Name = "richTextBox_textoMensaje";
            this.richTextBox_textoMensaje.Size = new System.Drawing.Size(643, 150);
            this.richTextBox_textoMensaje.TabIndex = 59;
            this.richTextBox_textoMensaje.Text = "Por favor compórtate con tus mayores...";
            // 
            // button_cancelar
            // 
            this.button_cancelar.Location = new System.Drawing.Point(257, 314);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(66, 23);
            this.button_cancelar.TabIndex = 56;
            this.button_cancelar.Text = "Cancelar";
            this.button_cancelar.UseVisualStyleBackColor = true;
            // 
            // Edu
            // 
            this.Edu.FormattingEnabled = true;
            this.Edu.Location = new System.Drawing.Point(-223, 105);
            this.Edu.Name = "Edu";
            this.Edu.Size = new System.Drawing.Size(187, 147);
            this.Edu.TabIndex = 33;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(-223, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 20);
            this.textBox1.TabIndex = 32;
            this.textBox1.Text = "Edu";
            // 
            // button_crear
            // 
            this.button_crear.Location = new System.Drawing.Point(350, 314);
            this.button_crear.Name = "button_crear";
            this.button_crear.Size = new System.Drawing.Size(66, 23);
            this.button_crear.TabIndex = 57;
            this.button_crear.Text = "Crear";
            this.button_crear.UseVisualStyleBackColor = true;
            // 
            // FormUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 349);
            this.Controls.Add(this.button_crear);
            this.Controls.Add(this.tabControl_usuario);
            this.Controls.Add(this.Edu);
            this.Controls.Add(this.button_cancelar);
            this.Controls.Add(this.textBox1);
            this.Name = "FormUsuario";
            this.Text = "FormUsuario";
            this.tabControl_usuario.ResumeLayout(false);
            this.tabPage_datos.ResumeLayout(false);
            this.tabPage_datos.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPage_firmas.ResumeLayout(false);
            this.tabPage_firmas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_firmas)).EndInit();
            this.tabPage_galeria.ResumeLayout(false);
            this.tabPage_galeria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_galeria)).EndInit();
            this.tabPage_mensajes.ResumeLayout(false);
            this.tabPage_mensajes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_mensajes)).EndInit();
            this.tabPage_peticiones.ResumeLayout(false);
            this.tabPage_peticiones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_peticiones)).EndInit();
            this.tabPage_encuestas.ResumeLayout(false);
            this.tabPage_encuestas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_encuestas)).EndInit();
            this.tabPage_enviarMensaje.ResumeLayout(false);
            this.tabPage_enviarMensaje.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_usuario;
        private System.Windows.Forms.TabPage tabPage_datos;
        private System.Windows.Forms.Button button_cancelar;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox_nombre;
        private System.Windows.Forms.Label label_datosDeUsuario;
        private System.Windows.Forms.Label label_nombre;
        private System.Windows.Forms.TabPage tabPage_firmas;
        private System.Windows.Forms.TabPage tabPage_galeria;
        private System.Windows.Forms.Label label_fotosDeUsuario;
        private System.Windows.Forms.TabPage tabPage_mensajes;
        private System.Windows.Forms.Label label_mensajesDeUsuario;
        private System.Windows.Forms.TabPage tabPage_peticiones;
        private System.Windows.Forms.Label label_peticionesDeUsuario;
        private System.Windows.Forms.ListBox Edu;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label_fechaDeIngreso;
        private System.Windows.Forms.DateTimePicker dateTimePicker_fechaDeIngreso;
        private System.Windows.Forms.TabPage tabPage_enviarMensaje;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox_textoMensaje;
        private System.Windows.Forms.TabPage tabPage_encuestas;
        private System.Windows.Forms.Label label_enviarMensajeUsuario;
        private System.Windows.Forms.DataGridView dataGridView_firmas;
        private System.Windows.Forms.DateTimePicker dateTimePicker_fechaFirma;
        private System.Windows.Forms.Button button_buscarFirma;
        private System.Windows.Forms.TextBox textBox_autorFirma;
        private System.Windows.Forms.Label label_buscarFirmaPorAutor;
        private System.Windows.Forms.Label label_buscarFirmaPorFecha;
        private System.Windows.Forms.Label label_firmasDeUsuario;
        private System.Windows.Forms.Button button_editarFirma;
        private System.Windows.Forms.Button button_borrarFirma;
        private System.Windows.Forms.Button button_crear;
        private System.Windows.Forms.TextBox textBox_tituloGaleria;
        private System.Windows.Forms.Label label_buscarGaleriaPorTitulo;
        private System.Windows.Forms.DateTimePicker dateTimePicker_fechaGaleria;
        private System.Windows.Forms.Button button_buscarGaleria;
        private System.Windows.Forms.TextBox textBox_autorGaleria;
        private System.Windows.Forms.Label label_buscarGaleriaPorAutor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_enviarAlEmail;
        private System.Windows.Forms.RadioButton radioButton_enviarAlEmail;
        private System.Windows.Forms.RadioButton radioButton_enviarComoPrivado;
        private System.Windows.Forms.Button button_enviarMensaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn autorFirma;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinatarioFirma;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaFirma;
        private System.Windows.Forms.Button button_borrarGaleria;
        private System.Windows.Forms.Button button_editarGaleria;
        private System.Windows.Forms.DataGridView dataGridView_galeria;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox textBox_tituloMensaje;
        private System.Windows.Forms.Label label_buscarMensajePorTitulo;
        private System.Windows.Forms.DateTimePicker dateTimePicker_fechaMensaje;
        private System.Windows.Forms.Button button_buscarMensaje;
        private System.Windows.Forms.Label label_buscarMensajePorFecha;
        private System.Windows.Forms.Button button_borrarMensaje;
        private System.Windows.Forms.Button button_editarMensaje;
        private System.Windows.Forms.DataGridView dataGridView_mensajes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.RadioButton radioButton_recibidasPorUsuario;
        private System.Windows.Forms.RadioButton radioButton_realizadasPorUsuario;
        private System.Windows.Forms.TextBox textBox_asuntoEncuesta;
        private System.Windows.Forms.Label label_buscarEncuestaPorAsunto;
        private System.Windows.Forms.Button button_borrarEncuesta;
        private System.Windows.Forms.Button button_editarEncuesta;
        private System.Windows.Forms.DataGridView dataGridView_encuestas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.Button button_buscarEncuesta;
        private System.Windows.Forms.DateTimePicker dateTimePicker_fechaEncuesta;
        private System.Windows.Forms.Label label_buscarEncuestaPorFecha;
        private System.Windows.Forms.Label label_encuestasDeUsuario;
        private System.Windows.Forms.DataGridView dataGridView_peticiones;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.TextBox textBox_asuntoPeticion;
        private System.Windows.Forms.Label label_buscarPeticionPorAsunto;
        private System.Windows.Forms.Button button_buscarPeticion;
        private System.Windows.Forms.DateTimePicker dateTimePicker_fechaPeticion;
        private System.Windows.Forms.Label label_buscarPeticionPorFecha;
        private System.Windows.Forms.Button button_borrarPeticion;
        private System.Windows.Forms.Button button_editarPeticion;
        private System.Windows.Forms.CheckBox checkBox_esAdmin;
    }
}