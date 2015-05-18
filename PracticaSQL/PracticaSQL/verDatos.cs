using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Data.SqlClient;
using System.Data.OleDb;


namespace PracticaSQL
{
    public partial class verDatos : Form
    {
        
        public verDatos()
        {
            InitializeComponent();
                      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 venta = new Form1();
            venta.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void verDatos_Load(object sender, EventArgs e)
        {
            MySQL vertodo = new MySQL();
            ventanita.DataSource = vertodo.libro();
            ventanita.DataMember = "libro";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //crear el PDF
            Document PDF =new Document();
            PdfWriter.GetInstance(PDF,
                        new FileStream("PDF.pdf",
                              FileMode.OpenOrCreate));
            //Añadir Una fuente de texto
            Chunk texto = new Chunk("Texto subrayado",
                        FontFactory.GetFont("Arial", 12,
                            iTextSharp.text.Font.UNDERLINE));
            /*Añadir una imagen
            iTextSharp.text.Image jpg =
                    iTextSharp.text.Image.GetInstance(@"C:\\Users\\EDGAR SHAORAN\\Documents\\ProyectoFinal\\PracticaSQL\\PracticaSQL");
           jpg.Alignment = iTextSharp.text.Image.MIDDLE_ALIGN;

            PDF.Add(jpg);*/
            PDF.Add(new Paragraph(texto));
            PDF.Open();
            PDF.Add(new Paragraph(""));
            PDF.Close();
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            MySQL excel = new MySQL();
           excel.ExportarExcel(ventanita);
           
        }
    }
}