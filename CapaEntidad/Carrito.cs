﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
        //create table CARRITO(
        //IdCarrito int primary key identity,
        //IdCliente int references CLIENTE,
        //IdProducto int references PRODUCTO,
        //Cantidad int ,
        //)
        //go

    public class Carrito
    {

        public int IdCarrito { get; set; }
        public Cliente oCliente { get; set; }
        public Producto oProducto { get; set; }
        public int Cantidad { get; set; }
    }
}

