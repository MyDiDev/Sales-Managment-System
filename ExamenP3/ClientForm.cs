using System;
using Logica;

namespace ExamenP3
{
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
        }

        private void ClienForm_FormClosing(object sender, EventArgs e)
        {
            Hide();
            principal f = new();
            f.Show();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            string nombre= nameClient.Text;
            string apellido = apellidoClient.Text;
            string correo = correoClient.Text;
            string telefono = phoneClient.Text;

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) || 
                string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(telefono))
            {
                errorLabel.Text = "Llene las entradas";
                return;
            }

            Cliente c = new Cliente(nombre, apellido, correo, telefono);
            c.agregrarCliente();

            MessageBox.Show("Cliente Agregado Exitosamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Hide();
            principal f = new();
            f.Show();
        }
    }
}
