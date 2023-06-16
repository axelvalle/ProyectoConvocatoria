using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoConvocatoria
{
    public partial class Clientes : Form
    {
        private List<clCliente> listaClientes = new List<clCliente>();

        public Clientes()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clCliente.AgregarCliente(tbCliente, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);

        }

        private void Clientes_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<clCliente> listaClientes = new List<clCliente>(); // Crear una nueva lista de clientes

            foreach (DataGridViewRow row in tbCliente.Rows)
            {
                string idCliente = row.Cells["IDCliente"].Value?.ToString() ?? "";
                string datosBancarios = row.Cells["DatosBancarios"].Value?.ToString() ?? "";
                string direccion = row.Cells["Direccion"].Value?.ToString() ?? "";
                string telefono = row.Cells["Telefono"].Value?.ToString() ?? "";

                clCliente cliente = new clCliente(idCliente, datosBancarios, direccion, telefono);
                listaClientes.Add(cliente);
            }

            Reservacion reservacion = new Reservacion(listaClientes);
            reservacion.Show();
        }



    }
}

