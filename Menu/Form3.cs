using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace proyecto
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public void cargarDatos()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Datos.ListaPedidos;
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            //cargar los datos del archivo txt 
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;

            dataGridView1.Columns.Add("id", "ID");
            dataGridView1.Columns.Add("fecha", "Fecha");
            dataGridView1.Columns.Add("cliente", "Cliente");
            dataGridView1.Columns.Add("productos", "Productos");
            dataGridView1.Columns.Add("estado", "Estado");

            if (File.Exists("pedidos.txt"))
            {
                foreach (string linea in File.ReadAllLines("pedidos.txt"))
                {
                    if (string.IsNullOrWhiteSpace(linea)) continue;

                    var datos = linea.Split(',');

                    if (datos.Length == 5)
                    {
                        dataGridView1.Rows.Add(datos);
                    }
                }
            }
        }

        private void verPedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 nuevoForm = new Form3();
            nuevoForm.Show();
            this.Hide();
        }

    }
}
