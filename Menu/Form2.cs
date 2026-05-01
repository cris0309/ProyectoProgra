using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto
{
    public partial class pedidos : Form
    {
        //clase de pedidos
        public class pedido
        {
            public int id { get; set; }
            public DateTime fecha { get; set; }
            public string cliente { get; set; }
            public string productos { get; set; }
            public string estado { get; set; }
        }
        //define la lista para guardar los pedidos
        public static class Datos
        {
            public static List<pedido> ListaPedidos = new List<pedido>();
        }
       
        public pedidos()
        {
            InitializeComponent();
            cargarDatos();
        }
        //carga los pedidos
        public void cargarDatos()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Datos.ListaPedidos;
        }
        //agregar los pedidos
        private void bAgregar_Click(object sender, EventArgs e)
        {
            pedido nuevo = new pedido()
            {
                id = Datos.ListaPedidos.Count + 1,
                fecha = dtFecha.Value,
                cliente = tbCliente.Text,
                productos = tbProductos.Text,
                estado = estado.Text
            };
            Datos.ListaPedidos.Add(nuevo);

            MessageBox.Show("Pedido agregado correctamente");
            //carga los datos ingresados en la tabla 
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Datos.ListaPedidos;
        }
        //botones que abren otros formularios (menu)
        private void menúToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menu nuevoForm = new menu();
            nuevoForm.Show();
            this.Hide();
        }
        private void verPedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 nuevoForm = new Form3();
            nuevoForm.Show();
            this.Hide();
        }

        private void pedidos_Load(object sender, EventArgs e)
        {

        }
    }
}
