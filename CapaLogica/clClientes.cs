using System;
using System.Windows.Forms;

namespace CapaLogica
{
    public class clCliente
    {
        public string IDCliente { get; set; }
        public string DatosBancarios { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }

        public clCliente(string idCliente, string datosBancarios, string direccion, string telefono)
        {
            IDCliente = idCliente;
            DatosBancarios = datosBancarios;
            Direccion = direccion;
            Telefono = telefono;
        }

        public static void AgregarCliente(DataGridView dataGridView, string idCliente, string datosBancarios, string direccion, string telefono)
        {
            dataGridView.Rows.Add(idCliente, datosBancarios, direccion, telefono);
        }
    }
}
