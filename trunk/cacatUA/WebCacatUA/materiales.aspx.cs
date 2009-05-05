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
using System.Drawing;
using System.Xml.Linq;
using Libreria;

public partial class materiales : WebCacatUA.InterfazWeb
{
    private int cantidadPorPagina;
    public int CantidadPorPagina
    {
        get { return cantidadPorPagina; }
        set { cantidadPorPagina = value; }
    }

    private string propiedadOrdenar;
    public string PropiedadOrdenar
    {
        get { return propiedadOrdenar; }
        set { propiedadOrdenar = value; }
    }

    private int pagina;
    public int Pagina
    {
        get { return pagina; }
        set { pagina = value; }
    }

    private void Inicializar()
    {
        Label_cantidadPorPaginaAnterior.Visible = false;
        cantidadPorPagina = int.Parse(DropDownList_cantidadPorPagina.Text.ToString());
        propiedadOrdenar = DropDownList_propiedadesOrdenar.Text;
        pagina = int.Parse(DropDownList_pagina.Text.ToString());

        // Comprobamos si ha cambiado la cantidad por página
        if (int.Parse(Label_cantidadPorPaginaAnterior.Text) != cantidadPorPagina)
        {
            // Ha cambiado
            Label_cantidadPorPaginaAnterior.Text = cantidadPorPagina.ToString();
            pagina = 1;
            DropDownList_pagina.Text = "1";
        }

    }

    /// <summary>
    /// Para realizar una búsqueda se debe pasar el texto a buscar
    /// y la categoría donde realizar la búsqueda
    /// Se tienen que pasar dos parámetros: categoria y texto a buscar
    /// Si la categoría no existe, se hace una búsqueda a nivel global de materiales
    /// </summary>
    /// <returns></returns>
    private bool ComprobarBusqueda()
    {
        bool correcto = false;
        // Comprobamos si se le pasan los parámetros adecuados
        if (Request.Params["categoria"] != null && Request.Params["buscar"] != null)
        {
            // Realizamos la búsqueda
            BusquedaMaterial busqueda = new BusquedaMaterial();
            string filtroBusqueda = Request.Params["buscar"].ToString();
            busqueda.FiltroBusqueda = filtroBusqueda;

            int idCategoria = int.Parse(Request.Params["categoria"].ToString());
            ENCategoria categoria = ENCategoria.Obtener(idCategoria);
            busqueda.Categoria = categoria;

            RealizarBusqueda(busqueda);
            // Actualizamos las categorias
            ActualizarCategorias(busqueda.Categoria);
            // Actualizamos la navegación
            ActualizarNavegacion(busqueda.Categoria);
            // Actualizamos la búsqueda
            ActualizarBusqueda(busqueda.Categoria);

            correcto = true;
        }
        return correcto;
    }

    private bool ComprobarBusquedaUsuario()
    {
        bool correcto = false;
        // Comprobamos si se le pasan los parámetros adecuados
        if (Request.Params["usuario"] != null)
        {
            // Realizamos la búsqueda
            BusquedaMaterial busqueda = new BusquedaMaterial();
            ENUsuario usuario = ENUsuario.Obtener(int.Parse(Request.Params["usuario"].ToString()));
            busqueda.Usuario = usuario;

            RealizarBusqueda(busqueda);
            // Actualizamos las categorias
            ActualizarCategorias(busqueda.Categoria);
            // Actualizamos la navegación
            ActualizarNavegacion(busqueda.Categoria);
            // Actualizamos la búsqueda
            ActualizarBusqueda(busqueda.Categoria);

            correcto = true;
        }
        return correcto;
    }

    private bool ComprobarMostrarMaterialesCategoria()
    {
        bool correcto = false;
        if (Request.Params["categoria"] != null)
        {
            int idCategoria = int.Parse(Request.Params["categoria"].ToString());
            ENCategoria categoria = ENCategoria.Obtener(idCategoria);
            // Mostramos todos los materiales que hay en esa categoría
            BusquedaMaterial busqueda = new BusquedaMaterial();
            busqueda.Categoria = categoria;
            RealizarBusqueda(busqueda);

            // Actualizamos las categorias
            ActualizarCategorias(busqueda.Categoria);
            // Actualizamos la navegación
            ActualizarNavegacion(busqueda.Categoria);
            // Actualizamos la búsqueda
            ActualizarBusqueda(busqueda.Categoria);
            // Comprobamos si se puede crear un nuevo material
            comprobarNuevoMaterial(busqueda.Categoria);
            correcto = true;
        }
        return correcto;
    }

    void ActualizarBusqueda(ENCategoria categoria)
    {
        if (categoria != null)
        {
            Radio_materiales.Visible = true;
            Radio_categoria.Visible = true;
            Label_radioCategorias.Visible = true;
            Label_radioMateriales.Visible = true;
            Label_radioCategorias.Text = categoria.Nombre;
            Hidden_opcionBusqueda.Value = categoria.Id.ToString();
        }
        else
        {
            Radio_materiales.Visible = false;
            Radio_categoria.Visible = false;
            Label_radioCategorias.Visible = false;
            Label_radioMateriales.Visible = false;
        }
    }

    void ActualizarCategorias(ENCategoria categoria)
    {
        if (categoria == null)
        {
            // Mostramos las categorías superiores
            mostrarCategorias(ENCategoria.CategoriasSuperiores());
        }
        else
        {
            ArrayList hijos = categoria.ObtenerHijos();
            if (hijos.Count > 0)
                mostrarCategorias(hijos);
            else
            {
                // Mostramos las categorías del mismo nivel
                if (categoria.Padre != 0)
                    mostrarCategorias(ENCategoria.Obtener(categoria.Padre).ObtenerHijos());
                else
                    mostrarCategorias(ENCategoria.CategoriasSuperiores());
            }
        }
    }

    private void ActualizarNavegacion(ENCategoria categoria)
    {
        Label_ruta.Controls.Clear();
        HyperLink link = new HyperLink();
        link.Text = "materiales";
        link.NavigateUrl = "materiales.aspx?categoria=0";
        Label_ruta.Controls.Add(link);
        if (categoria != null)
            añadirRuta(categoria);

        if (categoria == null)
            Hidden_idCategoria.Value = "0";
        else
            Hidden_idCategoria.Value = categoria.Id.ToString();
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            Inicializar();
            // Comprobamos si tenemos que realizar una búsqueda
            bool resultado = ComprobarBusqueda();
            if (resultado == false)
            {
                // Comprobamos si tenemos que mostrar los materiales de una categoría
                resultado = ComprobarMostrarMaterialesCategoria();
                if (resultado == false)
                {
                    // Comprobamos si se trata de mostrar todos los materiales de un usuario
                    resultado = ComprobarBusquedaUsuario();
                    if (resultado == false)
                        Response.Redirect("materiales.aspx?categoria=0");
                }
            }
        }
        catch (Exception ex)
        {
            Response.Write(ex.ToString());
        }
    }

    private void RealizarBusqueda(BusquedaMaterial busqueda)
    {
        Panel_contenido.Controls.Clear();
        HtmlTable tabla = new HtmlTable();
        tabla.ID = "tabla_materiales";
        bool ascendente = false;

        ArrayList materiales = ENMaterial.Obtener(propiedadOrdenar, ascendente,
            pagina, cantidadPorPagina, busqueda);

        if (materiales.Count > 0)
        {
            foreach (ENMaterial material in materiales)
            {
                HtmlTableRow fila = new HtmlTableRow();
                HtmlTableCell celda = new HtmlTableCell();
                Control control = Page.LoadControl("materialBusqueda.ascx");
                WebCacatUA.materialBusqueda control_material = (WebCacatUA.materialBusqueda)control;
                control_material.inicializar(material);
                celda.Controls.Add(control_material);
                fila.Cells.Add(celda);
                // Cambiamos el color de la fila
                if (tabla.Rows.Count % 2 == 0)
                    fila.BgColor = "#dcd9cd";
                else
                    fila.BgColor = Color.White.Name;
                tabla.Rows.Add(fila);
            }
            Panel_contenido.Controls.Add(tabla);
            ActualizarPaginacion(busqueda.NumResultados);
        }
        else
        {
            Label_resultados.Text = "No hay ningún resultado";
            ordenar_materiales.Visible = false;
            paginacion_materiales.Visible = false;
        }
    }

    /// <summary>
    /// Comprobamos si hay que activar el botón de nuevo material o no.
    /// Sólo se permite crear materiales si se está en una categoría que
    /// es un nodo hoja, es decir, no tiene descendientes.
    /// </summary>
    /// <param name="categoria"></param>
    private void comprobarNuevoMaterial(ENCategoria categoria)
    {
        if (categoria != null)
        {
            // Comprobamos si tiene descendientes
            if (categoria.ObtenerHijos().Count == 0)
            {
                // Establecemos la url cuando se pulse el botón
                //Button_nuevoMaterial.PostBackUrl = "nuevoMaterial.aspx?categoria=" + categoria.Id;
                Control control = Page.LoadControl("nuevoMaterial.ascx");
                WebCacatUA.nuevoMaterial1 control_material = (WebCacatUA.nuevoMaterial1)control;
                Panel_nuevoMaterial.Controls.Add(control_material);
            }
        }
    }

    public void ActualizarPaginacion(int totalResultados)
    {
        if (totalResultados > 0)
        {
            int paginas = (int)Math.Ceiling(totalResultados / (float)CantidadPorPagina);
            // Añadimos las páginas al combo box
            string paginaActual = pagina.ToString();
            DropDownList_pagina.Items.Clear();
            for (int i = 1; i <= paginas; i++)
                DropDownList_pagina.Items.Add(i.ToString());
            DropDownList_pagina.Text = paginaActual;

            int inicial = (pagina - 1) * CantidadPorPagina + 1;
            int final = inicial - 1 + CantidadPorPagina;
            if (final > totalResultados) final = totalResultados;

            Label_resultados.Text = "Resultados " + inicial + " a " + final + " de " + totalResultados;

            if (DropDownList_pagina.Text == "1")
                Button_anterior.Enabled = false;
            else
                Button_anterior.Enabled = true;

            if (DropDownList_pagina.Text == paginas.ToString())
                Button_siguiente.Enabled = false;
            else
                Button_siguiente.Enabled = true;
        }
    }

    private void mostrarCategorias(ArrayList categorias)
    {
        Panel_categorias.Controls.Clear();
        HtmlTable tabla = new HtmlTable();
        foreach (ENCategoria categoria in categorias)
        {
            HtmlTableRow fila = new HtmlTableRow();
            fila.Align = "left";
            HtmlTableCell celda = new HtmlTableCell();
            HyperLink link = new HyperLink();
            link.Text = categoria.Nombre;
            link.NavigateUrl = "materiales.aspx?categoria=" + categoria.Id.ToString();
            link.CssClass = "linkCategoria";
            celda.Controls.Add(link);
            fila.Cells.Add(celda);
            if (tabla.Rows.Count % 2 == 0)
                fila.BgColor = "#dcd9cd";
            else
                fila.BgColor = Color.White.Name;

            tabla.Rows.Add(fila);
        }
        Panel_categorias.Controls.Add(tabla);
    }

    private void añadirRuta(ENCategoria categoria)
    {
        // Añadimos primero la ruta del padre
        ENCategoria padre = ENCategoria.Obtener(categoria.Padre);
        if (padre != null)
        {
            // Obtenemos la ruta del padre
            añadirRuta(padre);
        }
        // Hemos llegado a la raíz
        Label label = new Label();
        label.Text = " > ";
        Label_ruta.Controls.Add(label);
        HyperLink link = new HyperLink();
        link.Text = categoria.Nombre;
        link.NavigateUrl = "materiales.aspx?categoria=" + categoria.Id.ToString();
        Label_ruta.Controls.Add(link);
    }
}
