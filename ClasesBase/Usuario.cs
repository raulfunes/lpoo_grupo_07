﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Usuario
    {
        private int usu_ID;
        public int Usu_ID
        {
            get { return usu_ID; }
            set { usu_ID = value; }
        }

        private string usu_NombreUsuario;
        public string Usu_NombreUsuario
        {
            get { return usu_NombreUsuario; }
            set { usu_NombreUsuario = value; }
        }

        private string usu_Password;
        public string Usu_Password
        {
            get { return usu_Password; }
            set { usu_Password = value; }
        }

        private string usu_ApellidoNombre;
        public string Usu_ApellidoNombre
        {
            get { return usu_ApellidoNombre; }
            set { usu_ApellidoNombre = value; }
        }
       
        private int rol_codigo;
        public int Rol_codigo
        {
            get { return rol_codigo; }
            set { rol_codigo = value; }
        }



        public Usuario(string nombre, string password) {
            Usu_NombreUsuario = nombre;
            Usu_Password = password;
        }



    }

    
}
