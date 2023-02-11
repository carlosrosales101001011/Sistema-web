using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
        //create table PRODUCTO(
        //IdProducto int primary key identity,
        //Nombre varchar(500),
        //Descripcion varchar(500),
        //IdMarca int references MARCA(IdMarca),
        //IdCategoria int references CATEGORIA(IdCategoria),
        //Precio decimal (10, 2) default 0,
        //Stock int,
        //RutaImg varchar(100),
        //NombreImg varchar(100),
        //Activo bit default 1,

    public class Producto
    {
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set;}
        public Marca oMarca { get; set;}
        public Categoria oCategoria { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public string RutaImg { get; set; }
        public string NombreImg { get; set; }
        public bool Activo { get; set; }

        public string PrecioTexto { get; set; }
        //Para poner a la img un formato de base64
        public string Base64 { get; set; }




    }
}
