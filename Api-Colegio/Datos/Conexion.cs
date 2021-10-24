using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Conexion
    {
        private static string Usuario = "sa";
        private static string Password = "ANTONY27";
        private static string Servidor = "DESKTOP-TQPJ3ML\\SQLEXPRESS";
        private static string BD = "BDColegio";
        public static string ObtenerCadenaConexionSQL()
        {
            return "Persist Security Info = False; User ID = '" + Usuario
                    + "'; Password = '" + Password
                    + "'; Initial Catalog = '" + BD
                    + "'; Server = '" + Servidor + "'";
        }

    }
}
