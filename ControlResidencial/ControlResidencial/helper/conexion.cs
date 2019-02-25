using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlResidencial.helper
{
    internal static class conexion
    {
        internal static string CadenaConexion { get; set; }

        internal static void ObtenerCadenaConexion()
        {
            CadenaConexion = string.Format("Data Source={0};Initial Catalog={1};Persist Security Info=True;User ID={2};Password={3}",
                Seguridad.Desencripta(regedit.ObtenerRegistro("Instancia")),
                Seguridad.Desencripta(regedit.ObtenerRegistro("BaseDatos")),
                Seguridad.Desencripta(regedit.ObtenerRegistro("Usuario")),
                Seguridad.Desencripta(regedit.ObtenerRegistro("Password")));
        }
    }
}
