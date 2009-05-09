﻿using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using Libreria;

namespace WebCacatUA
{
    public partial class edicionencuesta : InterfazWeb
    {
        ENEncuesta encuesta;

        protected void Page_Load(object sender, EventArgs e)
        {
            String id = (String)Request["id"];
            if (id != null)
            {
                int idEnc = int.Parse(id);
                CargarEncuesta(ENEncuesta.Obtener(idEnc));
            }
        }

        private void CargarEncuesta(ENEncuesta e)
        {
            encuesta = e;
            String codigo;
            int i = 0;

            codigo = "Editando encuesta: <br/>";
            codigo += "Pregunta: " + encuesta.Pregunta;

            foreach (OpcionEncuesta opc in encuesta.Opciones())
            {
                i++;
                TableRow fila = new TableRow();

                TableCell c1 = new TableCell();
                c1.CssClass = "celda_encuestas";
                Label l1 = new Label();
                l1.Text = "Opcion " + i.ToString() + ": ";
                c1.Controls.Add(l1);

                TableCell c2 = new TableCell();
                c2.CssClass = "celda_encuestas";
                TextBox t1 = new TextBox();
                t1.Text = opc.Opcion;
                c2.Controls.Add(t1);

                TableCell c3 = new TableCell();
                c3.CssClass = "celda_encuestas";
                Button b1 = new Button();
                b1.ID = opc.Id.ToString();
                b1.Text = "Quitar";
                b1.Click += new System.EventHandler(Button_borraropcion_Click);
                c3.Controls.Add(b1);

                fila.Controls.Add(c1);
                fila.Controls.Add(c2);
                fila.Controls.Add(c3);


                Table_encuesta.Controls.Add(fila);
            }

            if (i > 0)
            {
                Button_guardar.Visible = true;
            }

            Label_Texto.Text = codigo;

        }

        protected void Button_crearopcion_Click(object sender, EventArgs e)
        {
            if (TextBox_crearopcion.Text == "")
            {
                //Alert
            }
            else
            {
                OpcionEncuesta nOpcion = new OpcionEncuesta();
                nOpcion.Opcion = TextBox_crearopcion.Text;
                nOpcion.Encuesta = encuesta;
                ENEncuesta.CrearOpcion(nOpcion);
                Response.Redirect("editarencuesta.aspx?id=" + encuesta.Id);
            }
        }

        protected void Button_borraropcion_Click(object sender, EventArgs e)
        {
            Button pulsado = (Button)sender;
            try
            {
                int idopcion = int.Parse(pulsado.ID.ToString());
                ENEncuesta.BorrarOpcion(ENEncuesta.ObtenerOpcion(idopcion));

            }
            catch (Exception) { }

            Response.Redirect("editarencuesta.aspx?id=" + encuesta.Id);
        }

        protected void Button_guardar_Click(object sender, EventArgs e)
        {

        }
    }
}
