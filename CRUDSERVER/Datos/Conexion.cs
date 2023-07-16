using System.Data.SqlClient;

namespace CRUDSERVER.Datos
{
    public class Conexion
    {
        //Conexion con ADO.NET      Cadena vacia
        private string cadenaSQL = string.Empty;
           
        //Constructor
        public Conexion() { 
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();

            cadenaSQL = builder.GetSection("ConnectionStrings:CadenaSQL").Value; //Leo todo lo de appsetting
        }

        public string getCadenaSQL()
        {
            return cadenaSQL;
        }
    }
}
