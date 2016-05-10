using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de ClienteBLL
/// </summary>
namespace BD_Hotel.BLL
{

    public class ClienteBLL
    {
	    public  ClienteBLL()
	    {
		    //
		    // TODO: Agregar aquí la lógica del constructor
		    //
	    }

        public static List<Cliente> GetCliente()
        {
            ClienteDSTableAdapters.ClienteTableAdapter adapter = new ClienteDSTableAdapters.ClienteTableAdapter();
            ClienteDS.ClienteDataTable table = adapter.GetCliente();

            List<Cliente> list = new List<Cliente>();
            foreach (var row in table)
            {
                Cliente obj = getClienteFromRow(row);
                list.Add(obj);
            }
            return list;
        }
        public static Cliente getClienteFromRow(ClienteDS.ClienteRow row)
        {
            Cliente objt = new Cliente()
            {
                clienteId= row.clienteId,
                documento = row.documento,
                nroDocumento =row.nroDocumento,
                nombres = row.nombres,
                apellidos = row.apellidos,
                eMail = row.eMail,
                pais = row.pais,
                ciudad = row.ciudad,
                telefono = row.telefono,
                direccion = row.direccion
            };
            return objt;
        }

        public static void EliminarCliente(int ClienteId)
        {
            if (ClienteId <= 0)
                throw new ArgumentException("El id de la Cliente no puede ser menor o igual que cero");
            ClienteDSTableAdapters.ClienteTableAdapter adapter = new ClienteDSTableAdapters.ClienteTableAdapter();
            adapter.EliminarCliente(ClienteId);
        }

        public static int InsertarCliente(Cliente obj)
        {
            if (obj == null)
            {
                throw new ArgumentException("El objeto no puede ser nulo");
            }

            if (string.IsNullOrEmpty(obj.documento))
            {
                throw new ArgumentException("El fecha no puede ser nulo o vacio");
            }

            if (string.IsNullOrEmpty(obj.nroDocumento))
            {
                throw new ArgumentException("El nroDocumento no puede ser nulo o vacio");
            }

            if (string.IsNullOrEmpty(obj.nombres))
            {
                throw new ArgumentException("El nombres no puede ser nulo o vacio");
            }

            if (string.IsNullOrEmpty(obj.apellidos))
            {
                throw new ArgumentException("El apellidos no puede ser nulo o vacio");
            }

            if (string.IsNullOrEmpty(obj.eMail))
            {
                throw new ArgumentException("El eMail no puede ser nulo o vacio");
            }

            if (string.IsNullOrEmpty(obj.pais))
            {
                throw new ArgumentException("El pais no puede ser nulo o vacio");
            }

            if (string.IsNullOrEmpty(obj.ciudad))
            {
                throw new ArgumentException("El ciudad no puede ser nulo o vacio");
            }

            if (string.IsNullOrEmpty(obj.telefono))
            {
                throw new ArgumentException("El telefono no puede ser nulo o vacio");
            }

            if (string.IsNullOrEmpty(obj.direccion))
            {
                throw new ArgumentException("El direccion no puede ser nulo o vacio");
            }

            int? id = 0;
            ClienteDSTableAdapters.ClienteTableAdapter adapter = new ClienteDSTableAdapters.ClienteTableAdapter();

            adapter.InsertarCliente(obj.documento, obj.nroDocumento, obj.nombres, obj.apellidos,obj.eMail, obj.pais, obj.ciudad, obj.telefono, obj.direccion, ref id);

            if (id == null || id <= 0)
                throw new Exception("La llave primaria no se generó correctamente");
            return id.Value;
        }

        public static void ActualizarCliente(Cliente obj)
        {
            if (obj == null)
            {
                throw new ArgumentException("El objeto no puede ser nulo");
            }
            if (string.IsNullOrEmpty(obj.documento))
            {
                throw new ArgumentException("El fecha no puede ser nulo o vacio");
            }

            if (string.IsNullOrEmpty(obj.nroDocumento))
            {
                throw new ArgumentException("El nroDocumento no puede ser nulo o vacio");
            }

            if (string.IsNullOrEmpty(obj.nombres))
            {
                throw new ArgumentException("El nombres no puede ser nulo o vacio");
            }

            if (string.IsNullOrEmpty(obj.apellidos))
            {
                throw new ArgumentException("El apellidos no puede ser nulo o vacio");
            }

            if (string.IsNullOrEmpty(obj.eMail))
            {
                throw new ArgumentException("El eMail no puede ser nulo o vacio");
            }

            if (string.IsNullOrEmpty(obj.pais))
            {
                throw new ArgumentException("El pais no puede ser nulo o vacio");
            }

            if (string.IsNullOrEmpty(obj.ciudad))
            {
                throw new ArgumentException("El ciudad no puede ser nulo o vacio");
            }

            if (string.IsNullOrEmpty(obj.telefono))
            {
                throw new ArgumentException("El telefono no puede ser nulo o vacio");
            }

            if (string.IsNullOrEmpty(obj.direccion))
            {
                throw new ArgumentException("El direccion no puede ser nulo o vacio");
            }

            ClienteDSTableAdapters.ClienteTableAdapter adapter = new ClienteDSTableAdapters.ClienteTableAdapter();
            adapter.ActualizarCliente(obj.documento, obj.nroDocumento, obj.nombres, obj.apellidos, obj.eMail, obj.pais, obj.ciudad, obj.telefono, obj.direccion, obj.clienteId);

        }

        public static Cliente GetClienteById(int ClienteId)
        {
            if (ClienteId <= 0)
                throw new ArgumentException("El id de la Cliente no puede ser menor o igual que cero");

            ClienteDSTableAdapters.ClienteTableAdapter adapter = new ClienteDSTableAdapters.ClienteTableAdapter();
            ClienteDS.ClienteDataTable table = adapter.GetClienteBy(ClienteId);
            Cliente obj = getClienteFromRow(table[0]);
            return obj;
        }

    }
}