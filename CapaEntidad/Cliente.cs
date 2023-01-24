using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    //create table CLIENTE(
    //IdCliente int primary key identity,
    //Nombre varchar(500),
    //Apellidos varchar(100),
    //Correo varchar(100),
    //Clave varchar(100),
    //Reestablecer bit default 0,
    //FecRegistro datetime default getdate()
    //)
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Correo { get; set;}
        public string Clave { get; set; }
        public bool Reestablecer { get; set; }
    }
}
