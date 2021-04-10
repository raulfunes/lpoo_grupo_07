using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Inquilino
    {
        int inq_Codigo;
        int cont = 0;

        public int Inq_Codigo
        {
            get { return inq_Codigo; }
            set { inq_Codigo = value; }
        }
        string inq_Apellido;

        public string Inq_Apellido
        {
            get { return inq_Apellido; }
            set { inq_Apellido = value; }
        }
        string inq_Nombre;

        public string Inq_Nombre
        {
            get { return inq_Nombre; }
            set { inq_Nombre = value; }
        }
        string inq_Telefono;

        public string Inq_Telefono
        {
            get { return inq_Telefono; }
            set { inq_Telefono = value; }
        }


        public Inquilino(string apellido, string nombre, string telefono){
            Inq_Codigo += cont;
            cont++;
            Inq_Apellido = apellido;
            Inq_Nombre = nombre;
            Inq_Telefono = telefono;
        }
    }
}
