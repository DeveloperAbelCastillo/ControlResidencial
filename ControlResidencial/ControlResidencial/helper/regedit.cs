using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlResidencial.helper
{
    internal static class regedit
    {
        internal static string ObtenerRegistro(string cadena)
        {
            const string userRoot = "HKEY_CURRENT_USER";
            string subkey = "ControlResidencial";
            string keyName = userRoot + "\\" + subkey;

            return (string)Registry.GetValue(keyName,cadena,"Error");
        }
    }
}
