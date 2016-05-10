using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Cliente
/// </summary>

namespace BD_Hotel
{
    public class Cliente
    {
		    public int clienteId { get; set; }
            public string documento { get; set; }
            public string nroDocumento { get; set; }
            public string nombres { get; set; }
            public string apellidos { get; set; }
            public string eMail { get; set; }
            public string pais { get; set; }
            public string ciudad { get; set; }
            public string telefono { get; set; }
            public string direccion { get; set; }
            public Cliente() { }
   }

}

