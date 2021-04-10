using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    class Inquilino
    {
        int inq_Codigo;

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
        string inq_Teledono;

        public string Inq_Teledono
        {
            get { return inq_Teledono; }
            set { inq_Teledono = value; }
        }
    }
}
