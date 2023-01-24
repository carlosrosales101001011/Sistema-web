using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    //    create table PROVINCIA(
    //IdProvincia varchar(4) not null,
    //Descripcion varchar(45) not null,
    //idDepartamento varchar(2) not null,
    internal class Provincia
    {
        public string IdProvincia { get; set; }
        public string Descripcion { get; set; }
        public Departamento oDepartamento { get; set; }
    }
}
