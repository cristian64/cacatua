﻿using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace Libreria
{
    public class ENCategoria
    {
        private int id;
        private String nombre;
        private String descripcion;
        private int padre;

        public ENCategoria()
        {
            id = 0;
        }

        public ENCategoria(int id)
        {
            ENCategoria aux = ObtenerCategoria(id);
            if (aux != null)
            {
                this.id = aux.Id;
                nombre = aux.Nombre;
                descripcion = aux.Descripcion;
                padre = aux.Padre;
            }
            else
            {
                this.id = 0;
            }
        }

        public ENCategoria(int id, String nombre, String descripcion, int padre)
        {
            this.id = id;
            this.nombre = nombre;
            this.padre = padre;
            this.descripcion = descripcion;
        }

        public void Copiar(ENCategoria copia)
        {
            id = copia.Id;
            nombre = copia.Nombre;
            descripcion = copia.Descripcion;
            padre = copia.Padre;
        }

        public bool Guardar()
        {
            return CategoriaCAD.Instancia.crearCategoria(this);
        }

        public bool Actualizar()
        {
            return CategoriaCAD.Instancia.actualizarCategoria(this);
        }

        public bool Borrar() {
            return CategoriaCAD.Instancia.borrarCategoria(this);
        }

        public ArrayList obtenerHijos()
        {
            return CategoriaCAD.Instancia.obtenerHijosDe(this);
        }

        public ArrayList usuariosSuscritos()
        {
            return CategoriaCAD.Instancia.usuariosSuscritosA(this);
        }

        public int NumMateriales()
        {
            return CategoriaCAD.Instancia.NumMaterialesEn(this);
        }

        public int NumHilos()
        {
            return CategoriaCAD.Instancia.NumHilosEn(this);
        }


        //Metodos estaticos de categorias

        public static ENCategoria ObtenerCategoria(int id)
        {
            return CategoriaCAD.Instancia.obtenerCategoria(id);
        }

        public static ArrayList CategoriasSuperiores()
        {
            return CategoriaCAD.Instancia.obtenerCategoriasSuperiores();
        }

        public static int NumCategorias()
        {
            return CategoriaCAD.Instancia.NumCategorias();
        } 

        //Propiedades

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public String Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public int Padre
        {
            get { return padre; }
            set { padre = value; }
        }
    }
}