using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PracticaSQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fecha, autor, titulo, descripcion;
             fecha = fecha_BA.Text;
            autor = autor_BA.Text;
            titulo = titulo_BA.Text;
            descripcion = descripcion_BA.Text;
                        
            if (fecha_BA.Text.Length > 0)
            {
                if (autor_BA.Text.Length > 0)
                {
                    if (titulo_BA.Text.Length > 0)
                    {
                        if (descripcion_BA.Text.Length > 0)
                        {
                            SQLinsert insertar = new SQLinsert();
                            insertar.IngresarDatos(fecha, autor, titulo, descripcion);

                            fecha_BA.ResetText();
                            autor_BA.ResetText();
                            titulo_BA.ResetText();
                            descripcion_BA.ResetText();
                        }
                        else {
                            MessageBox.Show("Ingresa Una Descripcion", "Sin Datos",
                                          MessageBoxButtons.OK,
                                          MessageBoxIcon.Exclamation);
                        }
                    }
                    else {
                        MessageBox.Show("Ingresa Nombre y Descripcion", "Sin Datos",
                                          MessageBoxButtons.OK,
                                          MessageBoxIcon.Exclamation);
                    }

                }
                else {
                    MessageBox.Show("Ingresa un Autor, Nombre y Descripcion", "Sin Datos",
                                          MessageBoxButtons.OK,
                                          MessageBoxIcon.Exclamation);
                }


            }
            else {
                MessageBox.Show("Ingresa Datos Correcto", "Sin Datos",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Exclamation);
            }

                  
                
                      
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            verDatos datos = new verDatos();
            datos.Show();
            this.Hide();
         

        }
    }
}
