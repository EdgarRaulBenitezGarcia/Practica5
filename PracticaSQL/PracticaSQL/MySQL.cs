using System;
using MySql.Data.MySqlClient;
using System.Data;
using System.IO;
using Microsoft.Office.Interop.Excel;
using System.Windows.Forms;


namespace PracticaSQL
{
    public class MySQL
    {
        protected MySqlConnection myConnection;
        public MySQL()
        {
        }

        protected void abrirConexion()
        {
            string connectionString =
                "Server=localhost;" +
                "Database=autor;" +
                "User ID=root;" +
                "Password=210738113;" +
                "Pooling=false;";
            this.myConnection = new MySqlConnection(connectionString);
            this.myConnection.Open();
        }

        protected void cerrarConexion()
        {
            this.myConnection.Close();
            this.myConnection = null;
        }

        public DataSet libro()
        {
            this.abrirConexion();
            string query = "select * from libro";
            MySqlDataAdapter datalibro = new MySqlDataAdapter(query, myConnection);
            DataSet dsLibro = new DataSet();
            datalibro.Fill(dsLibro, "libro");
            this.cerrarConexion();
            return dsLibro;
        }
        public void ExportarExcel(DataGridView tabla)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);
            int IndiceColumna = 0;

            foreach (DataGridViewColumn col in tabla.Columns) // Columnas
            {
                IndiceColumna++;
                excel.Cells[6, IndiceColumna] = col.Name;
            }
            int IndeceFila = 6;
            foreach (DataGridViewRow row in tabla.Rows) // Filas
            {
                IndeceFila++;
                IndiceColumna = 0;
                foreach (DataGridViewColumn col in tabla.Columns)
                {
                    IndiceColumna++;
                    excel.Cells[IndeceFila + 0, IndiceColumna] = row.Cells[col.Name].Value;
                }
                excel.Visible = true;


            }
        }

    }
}