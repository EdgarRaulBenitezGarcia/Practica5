using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace PracticaSQL
{
    class SQLinsert : MySQL
    {
         public int ejecutarComando(string sql)
        {
            MySqlCommand myCommand = new MySqlCommand(sql, this.myConnection);
            int afectadas = myCommand.ExecuteNonQuery();
            myCommand.Dispose();
            myCommand = null;
            return afectadas;
        }

         public void obtenerID()
         {

         }


       public  void IngresarDatos(string f, string a, string t, string d)
        {         
            this.abrirConexion();
          //String def= "default";
            string sql = "INSERT INTO `libro` VALUES ("+"default"+",'" + f + "', '" + a + "','" + t + "','" + d + "')";
            this.ejecutarComando(sql);
            this.cerrarConexion();
        
                        }

       
         
    
    }
}
