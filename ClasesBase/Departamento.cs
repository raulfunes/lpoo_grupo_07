using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Departamento
    {
        int dpto_Codigo;
        public int Dpto_Codigo
        {
            get { return dpto_Codigo; }
            set { dpto_Codigo = value; }
        }

        int edif_Codigo;
        public int Edif_Codigo
        {
            get { return edif_Codigo; }
            set { edif_Codigo = value; }
        }

        string dpto_Tipo;
        public string Dpto_Tipo
        {
            get { return dpto_Tipo; }
            set { dpto_Tipo = value; }
        }

        int dpto_Numero;
        public int Dpto_Numero
        {
            get { return dpto_Numero; }
            set { dpto_Numero = value; }
        }

        int dpto_Piso;
        public int Dpto_Piso
        {
            get { return dpto_Piso; }
            set { dpto_Piso = value; }
        }

        int dpto_Ambientes;
        public int Dpto_Ambientes
        {
            get { return dpto_Ambientes; }
            set { dpto_Ambientes = value; }
        }

        int dpto_Bath;
        public int Dpto_Bath
        {
            get { return dpto_Bath; }
            set { dpto_Bath = value; }
        }

        string dpto_Disposicion;
        public string Dpto_Disposicion
        {
            get { return dpto_Disposicion; }
            set { dpto_Disposicion = value; }
        }

        float dpto_Precio;
        public float Dpto_Precio
        {
            get { return dpto_Precio; }
            set { dpto_Precio = value; }
        }

        public Departamento(int codigo, string tipo, int numero, int piso, int ambiente, int bath, string disposicion, float precio) {
            Edif_Codigo = codigo;
            Dpto_Tipo = tipo;
            Dpto_Numero = numero;
            Dpto_Piso = piso;
            Dpto_Ambientes = ambiente;
            Dpto_Bath = bath;
            Dpto_Disposicion = disposicion;
            Dpto_Precio = precio;
        }
    }
}
