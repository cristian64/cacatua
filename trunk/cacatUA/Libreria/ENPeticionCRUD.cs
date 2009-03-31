﻿using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace Libreria
{
    public class ENPeticionCRUD
    {
        private int id;
        private string asunto;
        private string texto;
        private int usuario;
        private DateTime fecha;
        private bool contestada;

        public ENPeticionCRUD()
        {
            id = 0;
            asunto = "";
            texto = "";
            contestada = false;
        }

        public ENPeticionCRUD(int i,string a,string t,bool c,int u)
        {
            id = i;
            asunto = a;
            texto = t;
            contestada = c;
            usuario = u;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Asunto
        {
            get { return asunto; }
            set { asunto = value; }
        }
        public string Texto
        {
            get { return texto; }
            set { texto = value; }
        }
        public int Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        public bool Contestada
        {
            get { return contestada; }
            set { contestada = true; }
        }

        public ArrayList getSinContestar()
        {
            return PeticionCAD.getSinContestar();
        }

        public ArrayList getContestadas()
        {
            return PeticionCAD.getContestadas();
        }
    }
}
