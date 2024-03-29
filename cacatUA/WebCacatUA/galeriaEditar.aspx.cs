﻿using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;
using Libreria;

namespace WebCacatUA
{
    public partial class Formulario_web14 : InterfazWeb
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] != null && Request.Params["imagen"]!=null)
            {
                int id = int.Parse(Request.Params["imagen"].ToString());
                ENImagen img = ENImagen.Obtener(id);

                if (img.Usuario.Usuario == Session["usuario"].ToString())
                {
                    if(!Page.IsPostBack)
                    {
                        TextBox_tituloNuevaImagen.Text = img.Titulo;
                        TextBox_descripcionNuevaImagen.Text = img.Descripcion;
                    }
                }
                else
                {
                    Response.Redirect("/index.aspx");
                }

            }
            else
            {
                Response.Redirect("/index.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.Params["imagen"].ToString());
            ENImagen img = ENImagen.Obtener(id);

            if (TextBox_tituloNuevaImagen.Text != "" && TextBox_descripcionNuevaImagen.Text != "" && img!=null)
            {
                img.Titulo = TextBox_tituloNuevaImagen.Text;
                img.Descripcion = TextBox_descripcionNuevaImagen.Text;

                img.Actualizar();

                if (img.Titulo!=TextBox_tituloNuevaImagen.Text)
                {
                    Response.Redirect("/galeriaDetalle.aspx?imagen=" + Request.Params["imagen"].ToString());
                }

                Response.Redirect("/index.aspx");
                
            }
            
        }


        
    }
}
