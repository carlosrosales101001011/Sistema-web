using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    //IdDistrito varchar(6) not null,
    //Descripcion varchar(45) not null,
    //IdProvincia varchar(4) not null,
    //idDepartamento varchar(2) not null,
    internal class Distrito
    {
        public string IdDistrito { get; set; }
        public string Descripcion { get; set; }
        public Provincia oProvincia { get; set; }
        public Departamento oDepartamento { get; set; }
    }
}
