﻿namespace PracticaSQL
{
    partial class verDatos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(verDatos));
            this.button1 = new System.Windows.Forms.Button();
            this.ventanita = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ventanita)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(375, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Regresar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ventanita
            // 
            this.ventanita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ventanita.Location = new System.Drawing.Point(12, 12);
            this.ventanita.Name = "ventanita";
            this.ventanita.Size = new System.Drawing.Size(806, 253);
            this.ventanita.TabIndex = 1;
            this.ventanita.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(556, 271);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Guardar en Excel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // verDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 321);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ventanita);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "verDatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "verDatos";
            this.Load += new System.EventHandler(this.verDatos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ventanita)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView ventanita;
        private System.Windows.Forms.Button button3;
    }
}