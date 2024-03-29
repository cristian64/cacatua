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
    public partial class peticion : InterfazWeb
    {
        ENUsuario usuario;

        protected void Page_Load(object sender, EventArgs e)
        {
            extraerParametros();
            if (usuario == null)
            {
                Panel_peticion.Visible = false;
                Label_peticion.Visible = true;
            }
        }

        protected void Button_enviar_Click(object sender, EventArgs e)
        {
            if (TextBox_Peticion.Text != "" && TextBox_Asunto.Text != "" && usuario != null)
            {
                ENPeticion peticion = new ENPeticion();
                peticion.Usuario = usuario;
                peticion.Asunto = TextBox_Asunto.Text;
                peticion.Texto = TextBox_Peticion.Text;
                peticion.Guardar();
                Response.Redirect("confirmacion.aspx?peticion=ok");
            }
            else
            {
                Label error = new Label();
                error.Text = Resources.I18N.PeticionError;
                error.ForeColor = System.Drawing.Color.Red;
                Panel_mensaje.Controls.Add(error);
            }
        }

        private void extraerParametros()
        {
            String u = (String)Session["usuario"];
            if (u != null)
            {
                usuario = ENUsuario.Obtener(u);
            }
        }
    }
}
