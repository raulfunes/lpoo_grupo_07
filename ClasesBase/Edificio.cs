using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Edificio
    {
        int cont = 0;
        int edif_Codigo;
        public int Edif_Codigo
        {
            get { return edif_Codigo; }
            set { edif_Codigo = value; }
        }

        string edif_Nombre;
        public string Edif_Nombre
        {
            get { return edif_Nombre; }
            set { edif_Nombre = value; }
        }

        string edif_Direccion;
        public string Edif_Direccion
        {
            get { return edif_Direccion; }
            set { edif_Direccion = value; }
        }

        string edif_Administrador;
        public string Edif_Administrador
        {
            get { return edif_Administrador; }
            set { edif_Administrador = value; }
        }

        string edif_Telefono;
        public string Edif_Telefono
        {
            get { return edif_Telefono; }
            set { edif_Telefono = value; }
        }
  

        public Edificio(string nombre, string direccion, string administrador, string telefono){
            Edif_Codigo += cont;
            cont++;
            Edif_Nombre = nombre;
            Edif_Direccion = direccion;
            Edif_Administrador = administrador;
            Edif_Telefono = telefono;
        }

    }
}
