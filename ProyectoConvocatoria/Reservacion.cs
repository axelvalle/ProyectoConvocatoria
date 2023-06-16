using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoConvocatoria
{
    public partial class Reservacion : Form
    {
        private List<clCliente> listaClientes;

        public Reservacion(List<clCliente> clientes)
        {
            InitializeComponent();

            listaClientes = clientes;

            // Configurar el ComboBox con los datos de los clientes
            foreach (clCliente cliente in listaClientes)
            {
                comboBoxClientes.Items.Add(cliente.IDCliente);
            }
        }

        private void Reservacion_Load(object sender, EventArgs e)
        {

        }
    }
}
